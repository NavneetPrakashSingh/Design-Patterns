using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Singleton
{
    class Client
    {
        static void Main(string[] args)
        {
            Singleton firstInstance = Singleton.getInstance();
            Singleton secondInstance = Singleton.getInstance();

            if(firstInstance == secondInstance)
            {
                Console.WriteLine("Instance are equal");
                Console.WriteLine(firstInstance.GetHashCode());
                Console.WriteLine(secondInstance.GetHashCode());
                Console.WriteLine(firstInstance.someBusinessLogic());
            }
            else
            {
                Console.WriteLine("Instance are not equal");
            }
        }
    }
}
