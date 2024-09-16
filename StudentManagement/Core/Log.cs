using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Core
{
    public static class Log
    {

        private static readonly ALog Logger = new Logger();

        public static void DebugArr(string message) { }
        public static void Debug(string message) => Logger.WriteLog("DEBUG", message);
        public static void Info(string message) => Logger.WriteLog("INFO", message);
        public static void Warning(string message) => Logger.WriteLog("WARNING", message);
        public static void Error(string message) => Logger.WriteLog("ERROR", message);
    }

    public class Logger: ALog
    {

    }
}
