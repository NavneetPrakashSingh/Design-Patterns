using DesignPatterns.CreationalPattern.Factory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPattern.Factory
{
    abstract class Creator
    {
        public abstract IProduct CreateFactory();
        public string PerformOperation()
        {
            var factory = CreateFactory();
            return factory.Operation();
        }
    }
}
