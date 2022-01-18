using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoNotification.Subscribers;

namespace VideoNotification.Publisher
{
    public interface ISubject
    {
        public void Attach(IObserver observer);
        public void Detach(IObserver observer);
        public void Notify();
    }
}
