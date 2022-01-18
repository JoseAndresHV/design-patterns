using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoNotification.Publisher;

namespace VideoNotification.Subscribers
{
    public class Subscriber : IObserver
    {
        public string Name { get; set; }
        private Channel _subject { get; set; }

        public Subscriber(string name, Channel channel)
        {
            Name = name;
            _subject = channel;
            _subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"{Name} has recieved a notification from { (_subject as Channel).Name }");
        }
    }
}
