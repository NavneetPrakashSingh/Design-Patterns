using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Singleton
{
    class Singleton
    {
        private Singleton() { }
        private static Singleton instance;
        public static Singleton getInstance()
        {
            if (instance != null)
            {
                return instance;
            }
            else
            {
                instance = new Singleton();
                return instance;
            }
        }
        public string someBusinessLogic()
        {
            return "business logic method invoked";
        }
    }
}
