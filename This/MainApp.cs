using System;

namespace This
{
    class Employee
    {
        private string name;
        private string position;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
        
        public void SetPosition(string position)
        {
            this.position = position;
        }

        public string GetPosition()
        {
            return position;
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.SetPosition("Waiter");
            Console.WriteLine($"{pooh.GetName()}, {pooh.GetPosition()}");

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.SetPosition("Cleaner");
            Console.WriteLine($"{tigger.GetName()}, {tigger.GetPosition()}");
        }
    }
}
