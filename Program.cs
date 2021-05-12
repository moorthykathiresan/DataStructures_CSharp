using System;
using System.Reflection;
using System.Linq;
using DataStrucures_CSharp.Basic_DataStructures;

namespace DataStrucures_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {


            var demos = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass && typeof(IDemo).IsAssignableFrom(t));

            foreach (var demoType in demos)
            {
                try
                {
                    var demo = Activator.CreateInstance(demoType) as IDemo;
                    demo.Demo();
                }
                catch
                {
                    // Ignore failed demo.
                }
            }

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }


        //static bool pairInSortedRotated(int[] arr,
        //                            int n, int x)
        //{
        //    // Find the pivot element 
        //    int i;
        //    for (i = 0; i < n - 1; i++)
        //        if (arr[i] > arr[i + 1])
        //            break;

        //    // l is now index of smallest element         
        //    int l = (i + 1) % n;

        //    // r is now index of largest element                 
        //    int r = i;

        //    // Keep moving either l or r till they meet 
        //    while (l != r)
        //    {
        //        // If we find a pair with sum x, we 
        //        // return true 
        //        if (arr[l] + arr[r] == x)
        //            return true;

        //        // If current pair sum is less,   
        //        // move to the higher sum 
        //        if (arr[l] + arr[r] < x)
        //            l = (l + 1) % n;

        //        // Move to the lower sum side     
        //        else
        //            r = (n + r - 1) % n;
        //    }
        //    return false;
        //}

        //// Driver Code 
        //public static void Main()
        //{
        //    int[] arr = { 11, 15, 6, 8, 9, 10 };
        //    int sum = 16;
        //    int n = arr.Length;

        //    if (pairInSortedRotated(arr, n, sum))
        //        Console.WriteLine("Array has two elements" +
        //                                   " with sum 16");
        //    else
        //        Console.WriteLine("Array doesn't have two" +
        //                            " elements with sum 16 ");
        //}
    }
}
