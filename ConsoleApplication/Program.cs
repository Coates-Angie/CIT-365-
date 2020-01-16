using System;

namespace ConsoleApplication
{
    public class ConsoleApplication
    {
        public static void Main()
        {

            //name and location
            string name = "Angie Coates";
            string location = "Utah";

            Console.WriteLine($"My name is { name} ");
            Console.WriteLine($"I live in {location} ");

            //Output date but not time
            DateTime thisDate1 = new DateTime(2020, 1, 16);
            Console.WriteLine("Today is " + thisDate1.ToString("MMMM dd, yyyy") + ".");

            //Days till Christmas
            DateTime today = new DateTime(2020, 1, 16);
            DateTime christmas = new DateTime(2020, 12, 25);

            // Calculate the interval between the two dates.
            TimeSpan ts = christmas - today;
            // output days till Christmas
            Console.WriteLine("There are " + ts.Days + " days until Christmas!\n");

            //program example from section 2.1

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please enter the width of the window : ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height of the window : ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
                 woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
                 glassArea + " square metres");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}