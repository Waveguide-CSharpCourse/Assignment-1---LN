using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_Math
{
    class Program
    {
        static void Main()
        {
            //prompt for name
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            //set size of array
            int arraySize = 0;
            Console.Write("Enter value for array size:");
            arraySize = int.Parse(Console.ReadLine());

            // Enter data to do math functions
            int[] intArray1 = new int[arraySize]; //define array to hold data, 6 integers long
            Console.WriteLine("Enter integers");
            int counter = 0; //counting variable
            for (int i = 0; i < intArray1.Length; i++)
            {
                counter = counter + 1; //increment counter var
                Console.Write("Value for integer {0}:", counter); //prompt user for integer
                try 
                {
                    intArray1[i] = int.Parse(Console.ReadLine()); //read data from console and save to array[i]
                }
                catch (Exception ex) //error case
                {
                    Console.WriteLine("That was not an integer.  Setting value to 0: ", ex.Message);
                    intArray1[i] = 0; //set value to 0 when data other than integer is entered
                }
            }

            // Calculate sum, sort ascending, sort descending, average, median, square, square root of the sum

            // sum, min and max values
            int arraySum = 0; //init arraySum, set to 0
            int arrayMin = int.MaxValue; //init arrayMin to max value const, largest value of int
            int arrayMax = 0; //init arrayMax, set to 0
            for (int i = 0; i < intArray1.Length; i++) //intArray1.Length should be 6, loop counts through array and sets maximum value to arrayMax, minimum to arrayMin
            {
                arraySum = arraySum + intArray1[i]; //current value + intArray1
                if (intArray1[i] > arrayMax) arrayMax = intArray1[i]; 
                if (intArray1[i] < arrayMin) arrayMin = intArray1[i];
            }

            // average
            decimal arrayAvg = (decimal)(arraySum / arraySize); //takes sum of arary and divides by length of array

            //sort ascending
            int[] arrayAscend = new int[arraySize]; //set array to same length
            intArray1.CopyTo(arrayAscend, 0); //copy array to new array
            Array.Sort(arrayAscend);

            //sort descending
            int[] arrayDescend = new int[arraySize]; //set array to same length
            intArray1.CopyTo(arrayDescend, 0); //copy array to new array
            Array.Sort(arrayDescend);
            Array.Reverse(arrayDescend);

            //median
            decimal arrayMedian = (decimal)(arrayAscend[3] + arrayAscend[4]) / 2;

            //square
            decimal arraySQ = (decimal)(arraySum * arraySum);

            //square root
            decimal arraySQRT = (decimal)Math.Sqrt(arraySum);

            // print out answers
            Console.WriteLine("The sum of the numbers entered is = {0}", arraySum);
            Console.WriteLine("The average of the numbers entered is = {0}", arrayAvg);
            Console.WriteLine("The array in ascending order is");
                foreach (int number in arrayAscend)
                {
                    Console.Write(number);
                    Console.Write(' ');
                }
                Console.WriteLine(' ');
            Console.WriteLine("The array in descending order is");
                foreach (int number in arrayDescend)
                {
                    Console.Write(number);
                    Console.Write(' ');
                }
                Console.WriteLine(' ');
            Console.WriteLine("The median of the array is = {0}", arrayMedian);
            Console.WriteLine("The square of the sum of the numbers in the array is = {0}", arraySQ);
            Console.WriteLine("The square root of the sum of the numbers in the array is = {0}", arraySQRT);

            Console.WriteLine("Press enter to close");
            Console.ReadLine();
        }
    }
}
