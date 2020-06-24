using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Builder
{
    class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();
        public void BuildPartA()
        {
            product.add("Part A");
        }

        public void BuildPartB()
        {
            product.add("Part B");
        }

        public void BuildPartC()
        {
            product.add("Part C");
        }

        public Product GetProduct()
        {
            Product result = product;
            reset();
            return result;

        }
        public void reset()
        {
            product = new Product();
        }
    }
}
