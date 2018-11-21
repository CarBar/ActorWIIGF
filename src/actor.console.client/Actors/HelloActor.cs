using System;
using System.Threading.Tasks;
using Proto;

namespace actor.console.client.Actors
{
    public class HelloActor : IActor
    {
        public Task ReceiveAsync(IContext context)
        {
            Console.WriteLine("Hello Actor Called!");

            if (context.Message is string msg){
                Console.WriteLine($"Hello { msg }!");
            }
            return Actor.Done;
        }
    }
}