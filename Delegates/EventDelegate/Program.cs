using System;

namespace EventDelegate1
{
    public class CheckVotingAge
    {
        // step 1=> declare delegate

        public delegate void VotingElligibility();
        public event VotingElligibility EventDelegate;
        public void CheckVotingElligibilty(int age)
        {
            if(age >=18)
            {
                Console.WriteLine("You can vote!!");
            }

            else
            {
                EventDelegate();
            }
        }
    }
    internal class Program
    {
        public static void Message()
        {
            Console.WriteLine("Sorry you cannot vote!!!");
        }
        static void Main(string[] args)
        {
            CheckVotingAge check=new CheckVotingAge();
            check.EventDelegate += Message;
            check.CheckVotingElligibilty(22);
             Console.WriteLine("Hello World!");
        }
    }
}
