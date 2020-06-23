using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Factory
{
    class ProductA : IProduct
    {
        public string Operation()
        {
            return "Operation called from Product A";
        }
    }
}
