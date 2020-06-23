using DesignPatterns.CreationalPattern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPattern.Factory
{
    class ConcreteFactoryA : Creator
    {
        public override IProduct CreateFactory()
        {
            return new ProductA();
        }
    }
}
