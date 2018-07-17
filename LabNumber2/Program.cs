using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{

    class Program
    {

        static double PerimeterCalc(double l, double w)
        {

            return ((2 * l) + (2 * w));

        }

        static double AreaCalc(double l, double w)
        {

            return (l * w);

        }

        static double VolumeCalc(double l, double w, double h)
        {

            return (l * w * h);

        }

        static void Main(string[] args)
        {

            bool whileBreak = false;

            string name;
            double length;
            double width;
            double height;

            char moveOn;
            char again;
            //string parser;  I am now assuming that the user isn't actively trying to impersonate a monkey.

            Console.WriteLine("Hello, welcome to the Classroom Calculator!");

            while (whileBreak == false)
            {
                Console.WriteLine("Please enter the name of the classroom you will be calculating: ");

                name = Console.ReadLine();

                Console.WriteLine($"Please enter the following dimension for the {name} as they appear.");

                Console.WriteLine("Length: ");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Width: ");
                width = double.Parse(Console.ReadLine());

                Console.WriteLine("Height: ");
                height = double.Parse(Console.ReadLine());

                Console.WriteLine($"Continue with these parameters for {name}?");
                Console.WriteLine($"Length: {length}");
                Console.WriteLine($"Width: {width}");
                Console.WriteLine($"Height: {height}");
                Console.WriteLine("Y/N");

                moveOn = char.Parse(Console.ReadLine());

                if(Char.ToLower(moveOn) == 'y')
                {

                    Console.WriteLine($"Perimeter: {PerimeterCalc(length, width)}");
                    Console.WriteLine($"Area: {AreaCalc(length, width)}");
                    Console.WriteLine($"Volume: {VolumeCalc(length, width, height)}");

                    Console.WriteLine("Calculate another classroom? (Y/N)");
                    again = char.Parse(Console.ReadLine());

                    if (Char.ToLower(again) == 'y')
                    {

                        Console.WriteLine("Excellent, restarting...");
                        whileBreak = false;

                    }

                    else if (Char.ToLower(again) == 'n')
                    {

                        Console.WriteLine("Thank you for using this program.");
                        whileBreak = true;

                    }

                }

                else if (Char.ToLower(moveOn) == 'n')
                {

                    Console.WriteLine("Calculate with different parameters? (Y/N)");
                    again = char.Parse(Console.ReadLine());

                    if (Char.ToLower(again) == 'y')
                    {

                        Console.WriteLine("Excellent, resetting...");
                        whileBreak = false;

                    }

                    else if (Char.ToLower(again) == 'n')
                    {

                        Console.WriteLine("Thank you for your time.");
                        whileBreak = true;

                    }

                }
            }


        }

    }

}
