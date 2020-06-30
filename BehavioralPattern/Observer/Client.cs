using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehavioralPattern.Observer
{
    class Client
    {
        static void Main(string[] args)
        {
            ISubject subject = new Subject();

            IObserver observerA = new ObserverA();
            
            IObserver observerB = new ObserverB();

            subject.attach(observerA);
            subject.attach(observerB);

            subject.businessLogic();

            subject.deattach(observerA);

            subject.businessLogic();
        }
    }
}
