using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Builder
{
    class Client
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            var concreteBuilder = new ConcreteBuilder();
            director.builder = concreteBuilder;

            director.buildMinimumViableProduct();
            concreteBuilder.GetProduct().print();

            director.buildCompleteProduct();
            concreteBuilder.GetProduct().print();
        }
        
    }
}
