using System;
using System.Threading.Tasks;
using actor.console.client.Messages;
using Proto;

namespace actor.console.client.Actors
{
    public class HelloActor : IActor
    {
        public Task ReceiveAsync(IContext context)
        {
            Console.WriteLine("Hello Actor Called!");

            if (context.Message is Hello msg){
                Console.WriteLine($"Hello { msg.Who }!");
            }
            return Actor.Done;
        }
    }
}