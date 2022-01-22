using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonAspDotNet.Tools
{
    public sealed class Log
    {
        private static Log _instance = null;
        private string _path;
        private static object _protect = new();
        public static Log GetInstance(string path)
        {
            lock(_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }

            return _instance;
        }

        private Log(string path)
        {
            _path = path;
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, DateTime.Now + " -> " + message + Environment.NewLine);
        }
    }
}
