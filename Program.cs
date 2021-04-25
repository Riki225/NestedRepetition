using System;

namespace NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter;
            counter = 0;

            Console.WriteLine("Please Enter A Name:");
            string getName;
            getName = Console.ReadLine();

            while (counter < 10) {
                int counter2;
                counter2 = 0;

                while (counter2 < 10) {
                    Console.Write(getName);
                    counter2 ++;
                }

                Console.WriteLine();
                counter ++;
            }

            Console.WriteLine("Goodbye " + getName);
        }
    }
}
