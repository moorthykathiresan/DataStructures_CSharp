using System;
using System.Linq;
using DataStrucures_CSharp.Basic_DataStructures;

namespace DataStrucures_CSharp.Operators
{
    public class Xor_Demo : IDemo
    {
        public void Demo()
        {

            Console.WriteLine("Demo: Cypher/Decypher with Xor");
            var testNumber = 9856874;
            var cyph = testNumber.ToString().ToArray().Select(c => (char)(c ^ 1));
            var decyph = int.Parse(string.Join("", cyph.Select(c => (char)(c ^ 1))));

            Console.WriteLine($"Original Number: {testNumber}");
            Console.WriteLine($"Cyph: {string.Join("", cyph)}");
            Console.WriteLine($"Decyph: {decyph}");

            Console.WriteLine("Demo: Find the first duplicate number in a array with Xor");

            //Console.WriteLine("Demo: Find odd number in a duplicate array with Xor");

            var duplicateArray = new [] { 2, 4, 5, 2, 8, 9 }; // 2 is duplicate

            var duplicate = 0;
            var sum = 0;
            var previousSum = 0;

            for(var i =0; i < duplicateArray.Length; i++)
            {
                sum ^= duplicateArray[i];
                if(sum == previousSum && i != 0)
                {
                    duplicate = duplicateArray[i];
                    break;
                }

                previousSum = sum;
            }

            Console.WriteLine($"Found Duplicate: {duplicate}");
           
        }

        //static void PrintArray()
    }
}
