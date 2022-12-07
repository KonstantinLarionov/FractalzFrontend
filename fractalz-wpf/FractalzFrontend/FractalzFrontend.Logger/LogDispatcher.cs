using FractalzFrontend.Application.Abstractions;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace FractalzFrontend.Logger
{
    public class LogDispatcher : ILogDispatcher
    {
        private string TAG_DATE = "__DATE__";
        private string TAG_TEXT = "__TEXT__";
        private string TAG_TEXTHEADER = "__TEXTHEADER__";

        private string _template_success = "<strong style=\"color: darkgreen;\">[__DATE__]</strong> (<i style=\"color: darkgreen;\">__TEXTHEADER__</i>) : __TEXT__";
        private string _template_info = "<strong style=\"color: royalblue;\">[__DATE__]</strong> (<i style=\"color: royalblue;\">__TEXTHEADER__</i>) : __TEXT__";
        private string _template_error = "<strong style=\"color: darkred;\">[__DATE__]</strong> (<i style=\"color: darkred;\">__TEXTHEADER__</i>) : __TEXT__";

        private string Path = Environment.CurrentDirectory + @"\Logs\";
        private string FileName = "StateOn_" + DateTime.Now.ToString("o") + ".html";

        public LogDispatcher() 
        { }

        public void SetFileName(string name) => FileName = name;
        public string GetFileName(string name) => FileName;

        private string CreateRepoLog() 
        {
            var path = Path + DateTime.Now.Date.ToString("o");
            if (!Directory.Exists(path))
            { 
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private string GetFile()
        {
            var pathwithdirectory = CreateRepoLog();
            var pathwithfile = pathwithdirectory + FileName;

            if (!File.Exists(pathwithfile))
            { File.Create(pathwithfile); }

            return pathwithfile;
        }

        public void Success(string header, string message)
        {
            string pathwithfile = GetFile();

            var content = _template_success
                .Replace(TAG_DATE, DateTime.Now.ToString("o"))
                .Replace(TAG_TEXT, message)
                .Replace(TAG_TEXTHEADER, header);

            File.AppendAllText(pathwithfile, content + Environment.NewLine);
        }

        public void Success(string header, object message)
        {
            string pathwithfile = GetFile();

            var content = _template_success
                .Replace(TAG_DATE, DateTime.Now.ToString("o"))
                .Replace(TAG_TEXT, JsonConvert.SerializeObject(message))
                .Replace(TAG_TEXTHEADER, header);

            File.AppendAllText(pathwithfile, content + Environment.NewLine);
        }


        public void Info(string header, string message)
        {
            string pathwithfile = GetFile();

            var content = _template_info
                .Replace(TAG_DATE, DateTime.Now.ToString("o"))
                .Replace(TAG_TEXT, message)
                .Replace(TAG_TEXTHEADER, header);

            File.AppendAllText(pathwithfile, content + Environment.NewLine);
        }

        public void Info(string header, object message)
        {
            string pathwithfile = GetFile();

            var content = _template_info
                .Replace(TAG_DATE, DateTime.Now.ToString("o"))
                .Replace(TAG_TEXT, JsonConvert.SerializeObject(message))
                .Replace(TAG_TEXTHEADER, header);

            File.AppendAllText(pathwithfile, content + Environment.NewLine);
        }

        public void Error(string header, string message)
        { 
            string pathwithfile = GetFile();

            var content = _template_error
                .Replace(TAG_DATE, DateTime.Now.ToString("o"))
                .Replace(TAG_TEXT, message)
                .Replace(TAG_TEXTHEADER, header);

            File.AppendAllText(pathwithfile, content + Environment.NewLine);
        }

        public void Error(string header, object message)
        { 
            string pathwithfile = GetFile();

            var content = _template_error
                .Replace(TAG_DATE, DateTime.Now.ToString("o"))
                .Replace(TAG_TEXT, JsonConvert.SerializeObject(message))
                .Replace(TAG_TEXTHEADER, header);

            File.AppendAllText(pathwithfile, content + Environment.NewLine);
        }
    }
}
