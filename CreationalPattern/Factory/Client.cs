using DesignPatterns.CreationalPattern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPattern.Factory
{
    class Client
    {
        private static void Main(string[] args)
        {
            Creator factoryA = new ConcreteFactoryA();
            Console.WriteLine(factoryA.PerformOperation());

            Creator factoryB = new ConcreteFactoryB();
            Console.WriteLine(factoryB.PerformOperation());
        }
    }
}
