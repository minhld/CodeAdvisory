using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace CodeAdvisor.Supports
{
    class JavaUtils
    {
        static string javacPath = "";
        static string javaPath = "";
        static string classPath = "";

        static public event EventHandler ProcessDataAvailable, ProcessErrorAvailable, ProcessDone;
        static EventHandler infoHandler, errorHandler, overHandler;

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

        public static bool initJavaUtils(string binPath)
        {
            if (!Directory.Exists(binPath)) return false;

            javacPath = binPath + @"\javac.exe";
            javaPath = binPath + @"\java.exe";
            infoHandler = ProcessDataAvailable;
            errorHandler = ProcessErrorAvailable;
            overHandler = ProcessDone;

            return true;
        }

        public static string compile(string javaFilePath)
        {
            int lastOffs = javaFilePath.LastIndexOf(".java");
            string javaClassPath = javaFilePath.Substring(0, lastOffs) + ".class";

            // delete the class file if it exists
            if (File.Exists(javaClassPath))
            {
                File.Delete(javaClassPath);
            }

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

        public static bool execute(string javaClassPath)
        {
            int offs = javaClassPath.LastIndexOf("\\");
            int offsClass = javaClassPath.LastIndexOf(".class");
            string parentPath = javaClassPath.Substring(0, offs);
            string className = javaClassPath.Substring(offs + 1, offsClass - offs - 1);
            
            Process process = new Process();
            process.StartInfo.FileName = javaPath;
            process.StartInfo.Arguments = "-classpath " + parentPath + " " + className;
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

            return true;
        }

        private static void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            errorHandler(sender, e);
        }

        private static void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            infoHandler(sender, e);
        }
    }
}
