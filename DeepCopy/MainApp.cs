using System;

namespace DeepCopy
{
    class MyClass
    {
        public int field1;
        public int field2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.field1 = this.field1;
            newCopy.field2 = this.field2;

            return newCopy;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.field1 = 10;
                source.field2 = 20;

                MyClass target = source;
                target.field2 = 30;

                Console.WriteLine($"{source.field1}, {source.field2}");
                Console.WriteLine($"{target.field1}, {target.field2}");
            }

            Console.WriteLine("Deep Copy");
            {
                MyClass source = new MyClass();
                source.field1 = 10;
                source.field2 = 20;

                MyClass target = source.DeepCopy();
                target.field2 = 30;

                Console.WriteLine($"{source.field1}, {source.field2}");
                Console.WriteLine($"{target.field1}, {target.field2}");
            }
        }
    }
}
