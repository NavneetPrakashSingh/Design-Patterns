using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Builder
{
    class Director
    {
        public IBuilder builder;

        public void buildMinimumViableProduct()
        {
            builder.BuildPartA();
        }

        public void buildCompleteProduct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }

    }
}
