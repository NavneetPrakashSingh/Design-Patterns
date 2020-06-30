using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPattern.Observer
{
    interface ISubject
    {
        void attach(IObserver observer);
        void deattach(IObserver observer);
        void notify();

        void businessLogic();
    }
}
