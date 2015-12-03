using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

namespace Loguer
{
    public class LogDeb
    {

        static void Main(string[] args)
        {
            Exception ex = new Exception();
            LogException("test ", "TestLog", ex.ToString());
        }

        public static void LogException(string strFileName, string strFunctionName, string strContent)
        {
            StreamWriter writer = null;
            StringBuilder strBuilder = null;
            string dir = "C:\\LogError\\";

            //string dir = Environment.CurrentDirectory;
            //string dir = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            string path = Path.Combine(dir, strFileName + ".log");
            strBuilder = new StringBuilder("\nLog : " + DateTime.Now + " : ");
            strBuilder.Append(strFunctionName + " | ");
            strBuilder.Append(strContent);

            writer = new StreamWriter(path, true);
            writer.Write(strBuilder);
            writer.Close();

        }
    }
}
