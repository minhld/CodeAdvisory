using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CodeAdvisor.Supports
{
    class JavaUtils
    {
        static string javacPath = "";
        static string javaPath = "";
        static string classPath = "";

        static public event EventHandler ProcessDataAvailable;
        static EventHandler handler;

        static public String ClassPath
        {
            set
            {
                classPath = value;
            }

            get
            {
                return classPath;
            }
        }

        public static void initJavaUtils(string binPath)
        {
            javacPath = binPath + @"\javac.exe";
            javaPath = binPath + @"\java.exe";
            handler = ProcessDataAvailable;
        }

        public static string compile(string javaFilePath)
        {
            int lastOffs = javaFilePath.LastIndexOf(".java");
            string javaClassPath = javaFilePath.Substring(0, lastOffs) + ".class";
            
            string compileString = javacPath + " " + javaFilePath;

            Process process = new Process();
            process.StartInfo.FileName = javacPath;
            process.StartInfo.Arguments = javaFilePath;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.OutputDataReceived += Process_OutputDataReceived;
            process.ErrorDataReceived += Process_ErrorDataReceived;

            process.Start();

            process.BeginErrorReadLine();
            process.BeginOutputReadLine();

            process.WaitForExit();

            classPath = javaClassPath;
            return javaClassPath;
        }

        private static void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            handler(sender, e);
        }

        private static void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            handler(sender, e);
        }
    }
}
