using System;
namespace DataStrucures_CSharp.Basic_DataStructures
{
    public class Struct_Demo //: IDemo
    {
        public void Demo()
        {
            Test d1 = default;
            d1.publicVal = 10;

            Console.WriteLine(d1.Foo());

            MyData myData = new MyData
            {
                value = 10,
                value2 = null
            };

            MyData d; // = new MyData();

            d.value = 2;

            Console.WriteLine(d.value);
            d = default; // new MyData();
            Console.WriteLine(d.value);
            d.Foo();
            d.value = 3;
            Console.WriteLine(d.value);

            //(d as IFoo).Foo();
            //myData[1].value = 11;

            //foreach (var item in myData)
            {
                Console.WriteLine(myData.value);
                Console.WriteLine(myData.value2);
            }
        }
    }

    struct Test
    {
        private int myVal;
        public int publicVal;
        public int Foo()
        {
            return myVal;
        }
    }

    struct MyData : IFoo
    {
        public static int value3 = 123;
        //public MyData(Foo foo)
        //{
        //    value = 0;
        //    value2 = foo;
        //}
        public int value;
        public Foo value2; // { get; set;  }

        public void Foo()
        {
            Console.WriteLine("Foo");
        }
    }

    interface IFoo
    {
        void Foo();
    }

    class Foo
    {

    }
}
