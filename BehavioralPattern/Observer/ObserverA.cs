using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPattern.Observer
{
    class ObserverA : IObserver
    {
        public void update(ISubject subject)
        {
            if ((subject as Subject).State > 0)
            {
                Console.WriteLine("State was changed in Observer A");
            }
        }
    }
}
