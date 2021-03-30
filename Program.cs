using System;

namespace NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            string getname;
            int counter;
            int counter2;

            counter = 0;

            getname = Console.ReadLine();

            while (counter < 10) {
                counter2 = 0;

                while (counter2 < 5) {
                    Console.Write(getname);
                    counter2 = counter2 + 1;
                }

                Console.WriteLine();
                counter = counter + 1;
            }

            Console.WriteLine("Goodbye" + " " + getname);
        }
    }
}
