using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSingleton.Singleton
{
    public class Log
    {
        private readonly static Log _instance = new Log();
        private string _path = "log.txt";

        private Log()
        {
        }

        public static Log Instance
        {
            get
            {
                return _instance;
            }
        }

        public void Save(string message)
        {
            File.AppendAllText(_path, message + Environment.NewLine);
        }

        public void Read()
        {
            var log = File.ReadAllText(_path);
            Console.WriteLine(log);
        }
    }
}
