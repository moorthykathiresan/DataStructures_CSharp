using System;
using DataStrucures_CSharp.Basic_DataStructures;

namespace DataStrucures_CSharp.Inheritance
{
    /// <summary>
    /// Demonstrates inheritance in C#.
    /// </summary>
    public class Inheritance_Demo : IDemo
    {
        public void Demo()
        {
            Parent a = new GreatGrandChild();
            a.print();
        }
    }

    /// <summary>
    /// Parent class
    /// </summary>
    public class Parent
    {
        /// <summary>
        /// Print as A,
        /// </summary>
        public virtual void print()
        {
            Console.WriteLine("PrintA");
        }
    }


    /// <summary>
    /// Child class
    /// </summary>
    public class Child : Parent
    {
        /// <summary>
        /// Print as B.
        /// </summary>
        public override void print()
        {
            Console.WriteLine("PrintB");
        }
    }


    /// <summary>
    /// GrandChild class
    /// </summary>
    public class GrandChild : Child
    {
        /// <summary>
        /// Print as C.
        /// </summary>
        public override void print()
        {
            Console.WriteLine("printC");
        }
    }


    /// <summary>
    /// GreatGrandChild class
    /// </summary>
    public class GreatGrandChild : GrandChild
    {
        /// <summary>
        /// Shadow Print.
        /// </summary>
        public new void print() //Shadows the virtual/Override methods from parents
        {
            Console.WriteLine("Shadow");
        }
    }
}
