using System;
using System.Threading;
namespace Thread1
{
    internal class Program
    {
     public void ThreadMethod1()
        {
          
            Console.WriteLine("ThreadMethod1 Executed" +Thread.CurrentThread.Name);
        
        }
        public void ThreadMethod2()
        {
            for (int i = 0; i < 10; i++)
            {
                  Thread.Sleep(5000);
                Console.WriteLine(i);
            }

            Console.WriteLine("ThreadMethod2 Executed" + Thread.CurrentThread.Name);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Entered");
            Program p=new Program();
            Thread t1 = new Thread(p.ThreadMethod1);
            Thread t2 = new Thread(p.ThreadMethod2);
            //      Thread t3=new Thread()
            t1.Name = "Demo";
            t2.Start();
          t2.Join();
            // Threadpool
            t1.Start();
    
             
        

            Console.WriteLine("Main Method Executed");

        }
    }
}

