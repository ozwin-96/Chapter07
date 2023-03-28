using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Cat
    {
        public string name;
        public string color;

        public Cat()
        {
            name = "";
            color = "";
        }
        public Cat(string _name, string _color)
        {
            name = _name;
            color = _color;
        }
        ~Cat()
        {
            Console.WriteLine($"{name} : 잘가");
        }

        public void Meow()
        {
            Console.WriteLine($"{name} : 야옹");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.name} : {kitty.color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.name} : {nero.color}");
        }
    }
}
