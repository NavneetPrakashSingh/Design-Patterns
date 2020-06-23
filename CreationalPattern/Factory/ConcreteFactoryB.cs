using DesignPatterns.BehavioralPattern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPattern.Factory
{
    class ConcreteFactoryB : Creator
    {
        public override IProduct CreateFactory()
        {
            return new ProductB();
        }
    }
}
