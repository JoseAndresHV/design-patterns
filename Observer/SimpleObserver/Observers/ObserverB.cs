using SimpleObserver.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObserver.Observers
{
    public class ObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State >= 5)
            {
                Console.WriteLine("ObserverB: Reacted to the event.");
            }
        }
    }
}
