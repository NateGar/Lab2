using System;
using System.Threading;

namespace Lab2_Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Room Calculator");
            string loop = "y";

            while (loop == "y")
            {

                Console.WriteLine("What is the length of the room?");
                string input1 = Console.ReadLine();
                double length = double.Parse(input1);
                Console.WriteLine("What is the width of the room?");
                string input2 = Console.ReadLine();
                double width = double.Parse(input2);
                Console.WriteLine("What is the height of the room?");
                string input3 = Console.ReadLine();
                double height = double.Parse(input3);

                double area = length * width;
                double perimeter = (length * 2) + (width * 2);
                double volume = length * width * height;

                Console.WriteLine("The area is " + area);
                Console.WriteLine("The perimiter is " + perimeter);
                Console.WriteLine("The Volume is " + volume);

                Console.WriteLine("Continue? y/n");
                string answer = Console.ReadLine();

                if (answer == "y") 
                {
                    loop = "y";
                }
                if (answer == "n")
                {
                    loop = "n";
                }
                
            }
        }
    }
}
