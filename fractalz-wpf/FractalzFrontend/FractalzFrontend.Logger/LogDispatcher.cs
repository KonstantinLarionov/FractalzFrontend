using FractalzFrontend.Application.Abstractions;
using FractalzFrontend.Application.Domain;
using FractalzFrontend.Application.Extensions;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

using static System.Net.Mime.MediaTypeNames;

namespace FractalzFrontend.Logger
{
    public class LogDispatcher : ILogDispatcher
    {
        private string TAG_DATE = "__DATE__";
        private string TAG_TEXT = "__TEXT__";
        private string TAG_TEXTHEADER = "__TEXTHEADER__";

        private string _template_success = "<strong style=\"color: green;\">[__DATE__]</strong> (<i style=\"color: green;\">__TEXTHEADER__</i>) : __TEXT__";
        private string _template_info = "<strong style=\"color: royalblue;\">[__DATE__]</strong> (<i style=\"color: royalblue;\">__TEXTHEADER__</i>) : __TEXT__";
        private string _template_error = "<strong style=\"color: darkred;\">[__DATE__]</strong> (<i style=\"color: darkred;\">__TEXTHEADER__</i>) : __TEXT__";

        private string Path = Environment.CurrentDirectory + @"\Logs\";
        private string DefaultFileName = LoggerNameFile.AllState.GetEnumMember();
        private string FileName;

        public LogDispatcher() 
        { }

        public void SetFileName(LoggerNameFile name) => FileName = name.GetEnumMember();
        public string GetFileName() => FileName;

        private string CreateRepoLog() 
        {
            var path = Path + DateTime.Now.ToShortDateString();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            return path;
        }

        private string GetFile()
        {
            var pathwithdirectory = CreateRepoLog();
            var pathwithfile = pathwithdirectory + @"\"+ FileName;
            if (!File.Exists(pathwithfile))
            {
                using (var fs = new FileStream(pathwithfile, FileMode.CreateNew))
                    fs.Close();
            }
            return pathwithfile;
        }

        private string GetFileDefault()
        {
            var pathwithdirectory = CreateRepoLog();
            var pathwithfile = pathwithdirectory + @"\"+ DefaultFileName;
            if (!File.Exists(pathwithfile))
            {
                using (var fs = new FileStream(pathwithfile, FileMode.CreateNew))
                    fs.Close();
            }
            return pathwithfile;
        }

        public void Success(string header, string message)
        {
            try
            {
                string pathwithfile = GetFile();
                string pathwithfileDefault = GetFileDefault();

                var content = _template_success
                    .Replace(TAG_DATE, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())
                    .Replace(TAG_TEXT, message)
                    .Replace(TAG_TEXTHEADER, header);
                using (StreamWriter fs = new StreamWriter(pathwithfile, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
                using (StreamWriter fs = new StreamWriter(pathwithfileDefault, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
            }
            catch
            {
            }
        }

        public void Success(string header, object message)
        {
            try
            {
                string pathwithfile = GetFile();
                string pathwithfileDefault = GetFileDefault();

                var content = _template_success
                    .Replace(TAG_DATE, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())
                    .Replace(TAG_TEXT, JsonConvert.SerializeObject(message))
                    .Replace(TAG_TEXTHEADER, header);
                using (StreamWriter fs = new StreamWriter(pathwithfile, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
                using (StreamWriter fs = new StreamWriter(pathwithfileDefault, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
            }
            catch { }
        }


        public void Info(string header, string message)
        {
            try
            {
                string pathwithfile = GetFile();
                string pathwithfileDefault = GetFileDefault();

                var content = _template_info
                    .Replace(TAG_DATE, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())
                    .Replace(TAG_TEXT, message)
                    .Replace(TAG_TEXTHEADER, header);
                using (StreamWriter fs = new StreamWriter(pathwithfile, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
                using (StreamWriter fs = new StreamWriter(pathwithfileDefault, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
            }
            catch { }
        }

        public void Info(string header, object message)
        {
            try
            {
                string pathwithfile = GetFile();
                string pathwithfileDefault = GetFileDefault();

                var content = _template_info
                    .Replace(TAG_DATE, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())
                    .Replace(TAG_TEXT, JsonConvert.SerializeObject(message))
                    .Replace(TAG_TEXTHEADER, header);
                using (StreamWriter fs = new StreamWriter(pathwithfile, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
                using (StreamWriter fs = new StreamWriter(pathwithfileDefault, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
            }
            catch { }
        }

        public void Error(string header, string message)
        {
            try
            {
                string pathwithfile = GetFile();
                string pathwithfileDefault = GetFileDefault();

                var content = _template_error
                    .Replace(TAG_DATE, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())
                    .Replace(TAG_TEXT, message)
                    .Replace(TAG_TEXTHEADER, header);
                using (StreamWriter fs = new StreamWriter(pathwithfile, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
                using (StreamWriter fs = new StreamWriter(pathwithfileDefault, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
            }
            catch { }
        }

        public void Error(string header, object message)
        {
            try
            {
                string pathwithfile = GetFile();
                string pathwithfileDefault = GetFileDefault();

                var content = _template_error
                    .Replace(TAG_DATE, DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())
                    .Replace(TAG_TEXT, JsonConvert.SerializeObject(message))
                    .Replace(TAG_TEXTHEADER, header);
                using (StreamWriter fs = new StreamWriter(pathwithfile, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
                using (StreamWriter fs = new StreamWriter(pathwithfileDefault, true, Encoding.GetEncoding(1251)))
                {
                    fs.WriteLine(content + "</br>");
                }
            }
            catch { }
        }
    }
}
