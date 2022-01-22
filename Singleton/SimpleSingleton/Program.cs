using SimpleSingleton.Singleton;
using System;
namespace SimpleSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.Singleton.Instance;
            var singleton2 = Singleton.Singleton.Instance;

            Console.WriteLine(singleton1.Equals(singleton2) ? "Equal" : "Different");

            var log = Log.Instance;
            log.Save("New user registration: {user:name}");
            log.Save("Welcome!, {user:name}");

            log.Read();
        }
    }
}
