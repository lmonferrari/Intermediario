using System;

namespace Composition
{
    class Animal
    {
        private int _age;

        public int Age
        {
            get => _age; set => _age = value;
        }

        public void Eat()
        {
            Console.WriteLine("Nhamy Nhamy! Delicious food!");
        }

        public void Sleep()
        {
            Console.WriteLine("hmmmm not now! Time to sleep!!!");
        }

    }
}
