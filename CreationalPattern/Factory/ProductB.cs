using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Factory
{
    class ProductB : IProduct
    {
        public string Operation()
        {
            return "Operation from Product B";
        }
    }
}
