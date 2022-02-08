using System;

namespace sortering
{
    class Program
    {
        static void Main(string[] args)
        {
            int räknare=0;
            while (räknare <=1000)
            {
                Random slump=new Random();
                int rand = slump.Next(1,1001);
                Console.WriteLine(rand);
                räknare=räknare+1;
            }
        }
    }
}
