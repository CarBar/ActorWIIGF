using System;
using actor.console.client.Actors;
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
            context.Send(pid, "Steve Martin");
            Console.ReadLine();
        }
    }
}
