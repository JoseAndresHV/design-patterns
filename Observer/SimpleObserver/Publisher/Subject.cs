using SimpleObserver.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObserver.Publisher
{
    public class Subject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        public int State { get; set; }

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);

            Console.WriteLine("Subject: Attached an observer.");
        }

        public void Detach(IObserver observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);

            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            _observers.ForEach(o => o.Update(this));
        }

        public void SomeBusinessLogic()
        {
            State = new Random().Next(0, 9);

            Console.WriteLine("Subject: My state has just changed to: " + this.State);
            Notify();
        }
    }
}
