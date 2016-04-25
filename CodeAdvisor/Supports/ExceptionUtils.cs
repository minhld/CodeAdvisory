using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeAdvisor.Supports
{
    class ExceptionUtils
    {
        public static string parseException(string exMsg)
        {
            string[] exMsgLines = exMsg.Split('\n');
            for (int i = 0; i < exMsgLines.Length; i++)
            {
                if (exMsgLines.Equals(string.Empty)) continue;

            }
            return "";
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
