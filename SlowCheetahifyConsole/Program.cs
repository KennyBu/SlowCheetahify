using System;
using System.Configuration;

namespace SlowCheetahifyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the value from the configuration
            //The Slow Cheetah web.config transform will destermine which value to use from the config files
            var value = ConfigurationManager.AppSettings["testSetting"];

            Console.WriteLine(value);
            Console.Read();
        }
    }
}
