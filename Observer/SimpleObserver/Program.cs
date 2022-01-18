using SimpleObserver.Observers;
using SimpleObserver.Publisher;
using System;

namespace SimpleObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();

            var observerA = new ObserverA();
            subject.Attach(observerA);

            var observerB = new ObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);
        }
    }
}
