using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal();
            animal.Age = 10;
            Console.WriteLine(animal.Age);

            var person = new Person();
            person.Swimmable.Swim();

            person.Animal.Age = 50;
            Console.WriteLine(person.Animal.Age);

            person.Animal.Sleep();
        }
    }
}
