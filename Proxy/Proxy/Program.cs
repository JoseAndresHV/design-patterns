using Proxy;

Client client = new Client();

Console.WriteLine("Client: Executing the client code with a real subject:");
RealSubject subject = new RealSubject();
client.ClientCode(subject);

Console.WriteLine();

Console.WriteLine("Client: Executing the same client code with a proxy:");
Proxy.Proxy proxy = new Proxy.Proxy(subject);
client.ClientCode(proxy);