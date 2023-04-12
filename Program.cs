using System;

namespace Arrays_Lumpkin_Dalton
{
    class Program
    {
        static void Main(string[] args)
        {
            //requests the nums from user
            Console.WriteLine("gimmi like 5 numbers rn.");

            //This be the array
            int[] intArray = { 0, 0, 0, 0, 0 };

            //this be the sum
            int addedNum = 0;

            //used for setting the numbers
            int intIndex = 0;

            //loops throught the array assigning the ints
            foreach (int num in intArray)
            {
                intArray[intIndex] = Convert.ToInt32(Console.ReadLine());
                intIndex++;
            }

            //loops through afterward and adds the digits
            foreach (int num in intArray)
            {
                addedNum += num
;
            }
            //tells them the sum
            Console.WriteLine($"{addedNum} is the sum of those numbas! \n")
;
            //sorts the array
            Array.Sort(intArray);

            //prints it out
            foreach (int num in intArray)
            {
                Console.Write($"if you want it sorted then its: {num}");
            }


        }
    }
}
