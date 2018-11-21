using System;
using actor.console.client.Actors;
using actor.console.client.Messages;
using Proto;

namespace actor.console.client
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new RootContext();
            var props = Props.FromProducer(() => new HelloActor());
            var pid = context.Spawn(props);
            context.Send(pid, new Hello { Who = "Steve Martin" });
            Console.ReadLine();
        }
    }
}
