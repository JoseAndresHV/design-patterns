using System;
using VideoNotification.Publisher;
using VideoNotification.Subscribers;

namespace VideoNotification
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("JoseAndresHV");

            Subscriber user1 = new Subscriber("Bianca", channel);
            Subscriber user2 = new Subscriber("Joso", channel);

            channel.UploadVideo("Design Patterns");
            channel.UploadVideo("Strategy Pattern");
            channel.UploadVideo("Observer Pattern");
        }
    }
}
