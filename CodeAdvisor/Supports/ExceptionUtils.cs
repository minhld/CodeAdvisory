using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using System.IO;

namespace CodeAdvisor.Supports
{
    class ExceptionUtils
    {
        public static string sendPost(string url, string jsonRequest)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            var data = Encoding.ASCII.GetBytes(jsonRequest);

            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;

        }

        public static string parseException(string exMsg)
        {
            string exceptions = "", exceptionMessage = "";
            List<string> functionList = new List<string>();

            string[] exMsgLines = exMsg.Split('\n');
            string funcName = "";
            for (int i = 0; i < exMsgLines.Length; i++)
            {
                if (exMsgLines[i].Equals(string.Empty)) continue;

                // to simplify, let's consider the first line of exception is expression
                // the other lines only contain stack functions
                if (i == 0)
                {
                    string[] exs = checkException(exMsgLines[i]);
                    exceptions = exs[0];
                    exceptionMessage = exs[1];
                }
                else
                {
                    funcName = checkFunctions(exMsgLines[i]);
                    if (!funcName.Equals(string.Empty))
                    {
                        functionList.Add(funcName);
                    }
                }
            }

            RequestJSON req = new RequestJSON(exceptions, exceptionMessage, functionList.ToArray());

            return JsonConvert.SerializeObject(req);
        }

        public static string[] checkException(string exLine)
        {
            exLine = exLine.ToLower();
            string exceptionName = "", exceptionExpression = "";

            // 1. find exceptions
            Regex regex = new Regex(@"[\w.]+exception");
            MatchCollection matches = regex.Matches(exLine);

            for (int i = 0; i < matches.Count; i++)
            {
                exceptionName += " " + matches[i].Value;

                // remove it out of the exception string
                exLine = exLine.Replace(matches[i].Value, "");
            }
            exceptionName = exceptionName.Trim();

            string[] exLineParts = exLine.Split(' ');
            for (int i = 0; i < exLineParts.Length; i++)
            {
                if (!Regex.IsMatch(exLineParts[i], @"\W+"))
                {
                    exceptionExpression += " " + exLineParts[i];
                }
            }
            exceptionExpression = exceptionExpression.Trim();

            return new string[] { exceptionName, exceptionExpression };
        }

        public static string checkFunctions(string exMsgLine)
        {
            string funcName = Regex.Match(exMsgLine, @"\.\w+\(").Value;
            funcName = Regex.Replace(funcName, @"\W+", "");
            return funcName;
        }
    }
}
