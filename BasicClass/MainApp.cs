using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    class Cat
    {
        public string name;
        public string color;

        public void Meow()
        {
            Console.WriteLine($"{name} : 야옹");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.name = "키티";
            kitty.color = "하얀색";
            kitty.Meow();
            Console.WriteLine($"{kitty.name} : {kitty.color}");

            Cat nero = new Cat();
            nero.name = "네로";
            nero.color = "검은색";
            nero.Meow();
            Console.WriteLine($"{nero.name} : {nero.color}");
        }
    }
}
