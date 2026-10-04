using System;

namespace HybridUI.Utils
{
    public class Logger
    {
        private readonly string _name;

        public Logger(string name)
        {
            _name = name;
        }

        public static Logger GetLogger<T>()
        {
            return new Logger(typeof(T).Name);
        }

        public void Info(string message)
        {
            Console.WriteLine($"[INFO] [{_name}] {message}");
        }

        public void Warn(string message)
        {
            Console.WriteLine($"[WARN] [{_name}] {message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"[ERROR] [{_name}] {message}");
        }
    }
}
