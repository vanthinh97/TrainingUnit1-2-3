using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class Singleton
    {
        public static Singleton Instance = new Singleton();
        private Singleton()
        {

        }

        public void Call()
        {
            Console.WriteLine("Call to singleton class");
        }
    }
}
