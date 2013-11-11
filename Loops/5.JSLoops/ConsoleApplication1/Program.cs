using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Dog
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Dog(int a, string b)
        {
            this.Age = a;
            this.Name = b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog gosho = new Dog(3, "test");

        }
    }
}
