using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatterns.BehavioralPattern.Observer
{
    class Subject : ISubject
    {
        List<IObserver> observers;
        public int State { get; set; }
        public Subject()
        {
            observers = new List<IObserver>();
        }
        public void attach(IObserver observer)
        {
            Console.WriteLine("Observer was attached"+observer.ToString());
            observers.Add(observer);
        }

        public void deattach(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void notify()
        {
            foreach (var observer in observers)
            {
                Console.WriteLine("Notify observer"+observer);
                observer.update(this);
            }
        }

        public void businessLogic()
        {
            State = new Random().Next(0, 10);
            //Thread.Sleep(10);
            notify();
        }
    }
}
