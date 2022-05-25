using System;
using System.Threading.Tasks;
namespace TaskContinuation
{
    internal class Program
    {
        public static int addEven( int  a)
        {
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                if(i%2==0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Task<int> t =Task.Run(() =>
          
            {
               return  addEven(10);
            });
            Task<double> taskSquare = t.ContinueWith((tasks) =>
            {
                return (double)Math.Sqrt(tasks.Result);
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
        //   t.Wait();
            Console.WriteLine($"First Task Result :Sum {t.Result}");
            Console.WriteLine( $" Second Task Result :Sum {taskSquare.Result}");
            Console.WriteLine("Hello World!");
        }
    }
}
