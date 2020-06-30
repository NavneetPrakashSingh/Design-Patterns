using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPattern.Observer
{
    interface IObserver
    {
        void update(ISubject subject);
    }
}
