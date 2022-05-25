using System;
using System.Threading.Tasks;

namespace Async_Await
{
    internal class Program
    {
        public async static  Task<string> SendMessage()
        {
            await Task.Delay(10000);
            return "Welcome to Async Await Training!!";
        }

        public async static Task ReceiveMessage()
        {
            Console.WriteLine("Async Receive MEssage Started!!");// 1
            Task<string> sendMessage = SendMessage();
            Console.WriteLine("Current Time" + DateTime.Now);//2
            Console.WriteLine("Awaiting Result from SendMEssage MEthod");//3
            string message = await sendMessage;//3
            Console.WriteLine("Current Time" + DateTime.Now);//4
            Console.WriteLine("Async MEssage Sent"+sendMessage.Result);



        }
        static void Main(string[] args)
        {
            ReceiveMessage();
            Console.WriteLine("Hello World!");
        }
    }
}
