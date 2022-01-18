using SimpleObserver.Observers;
using SimpleObserver.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleObserver.Observers
{
    public class ObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 5)
            {
                Console.WriteLine("ObserverA: Reacted to the event.");
            }
        }
    }
}
