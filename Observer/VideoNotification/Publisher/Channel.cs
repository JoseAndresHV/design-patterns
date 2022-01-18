using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoNotification.Subscribers;

namespace VideoNotification.Publisher
{
    public class Channel : ISubject
    {
        private List<IObserver> _observers;
        public string Name { get; set; }

        public Channel(string name)
        {
            Name = name;
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);

            Console.WriteLine($"{ (observer as Subscriber).Name } has subscribed to {Name} Channel");
        }

        public void Detach(IObserver observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);

            Console.WriteLine($"{ (observer as Subscriber).Name } has subscribed to {Name} Channel");
        }

        public void Notify()
        {
            _observers.ForEach(o => o.Update());
        }

        public void UploadVideo(string video)
        {
            Console.WriteLine($"{ Name } has uploaded a new video: { video }");
            Notify();
        }
    }
}
