using System;
using System.Collections;

namespace DataStrucures_CSharp.Basic_DataStructures
{
    public class Array_Demo //: IDemo
    {
        public void Demo()
        {
            //Array

            int[] pairedButOneLonely = { 6, 9, 1, 1, 3, 3, 4, 5, 5, 6, 7, 7, 8, 8, 9 };

            var lonelyNumber = 0;

            foreach (var number in pairedButOneLonely)
            {
                lonelyNumber ^= number; //XOR the array to find lonely number
            }

            Console.WriteLine($"Lonely Number: {lonelyNumber}"); 

            //One dimensional Array
            int[] array = { 1, 2, 3 };

            Console.WriteLine("Array");
            DisplayData(array);

            //Two dimentional (multi-dimensional Array)
            int[,] array2D =
            {
                { 1, 2 },
                {3, 4 },
                {5, 6 }
            };

            Console.WriteLine("2D Array");
            DisplayData(array2D); //Foreach iterates without needing nested for

            //Three dimensional Array
            int[,,] array3D = new int[2, 3, 2]
            {
                { { 0,1 }, { 2, 3}, { 4,5 } },
                { { 6, 7 }, { 8,9 }, { 10,11 } }
            };

            Console.WriteLine("3D Array");
            DisplayData(array3D); //Foreach iterates without needing nested for

            //Jagged Array
            int[][] arrayJagged = new[]
            {
                new[]{1,2},
                new[]{3,4,5}
            };

            Console.WriteLine("Jagged Array");
            Console.WriteLine($"Jagged Array Dimension {arrayJagged.Rank}");
            foreach (var item in arrayJagged)
            {
                foreach (var data in item)
                {
                    Console.WriteLine(data);
                }
            }
            var data1 = "Data da";
            var arrays = data1.Split(' ');

            var data2 = Math.Pow(2, 3);

            Console.WriteLine($"Pow: {data2}");
            
            //Array is ref type.
            Console.WriteLine("Array is Ref Type");
            var testArray = new[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            Console.WriteLine("Array as initialized:");
            DisplayArray(testArray);

            ReverseArray(testArray);
            Console.WriteLine("Array After reversed:");
            DisplayArray(testArray);

            ChangeArray(testArray);
            Console.WriteLine("Array after modified inside a subroutine being passed:");
            DisplayArray(testArray);

            // The example displays the following output:
            //         Sun Mon Tue Wed Thu Fri Sat
            //
            //        Array weekDays after the call to ChangeArray:
            //        Sat Fri Thu Wed Tue Mon Sun
            //
            //        Array weekDays after the call to ChangeArrayElements:
            //        Mon Wed Fri Wed Tue Mon Sun

        }

        public static void DisplayData(IEnumerable data)
        {
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }

        public static void DisplayArray(string[] data) => Console.WriteLine(string.Join(' ', data));

        public static void ReverseArray(string[] data) => Array.Reverse(data);

        public static void ChangeArray(string[] data)
        {
            data[0] = "Mon";
            data[1] = "Tue";
        }
    }
}
