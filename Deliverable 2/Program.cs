using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your message?");
            string input = Console.ReadLine();
            input = input.ToUpper();
            int checksum = 0;
            string message = "";
            foreach (char a in input)
            {
                int num = a;
                message = message + (num - 64) + "-";
                checksum = checksum + num;
            }
            Console.WriteLine(message);
            Console.WriteLine("checksum = " + checksum);
        }
    }

}
    

