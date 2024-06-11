using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns._5_Singleton
{
    // sealed means that this class cannot be inhirite otherwise the idea of singelton will disrupt
    public sealed class Logger
    {
        // Private static variable to hold the single instance of the class.
        private static readonly Logger _instance = new Logger();

        // Private constructor to prevent instantiation from other classes.
        private Logger()
        {
        }

        // Public static property to provide global access to the instance.
        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        // Method to log messages.
        public void Log(string message)
        {
            Console.WriteLine("Log message: " + message);
        }
    }

}
