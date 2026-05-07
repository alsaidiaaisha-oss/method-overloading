using System;

namespace InheritanceExample
{
    // Parent Class
    class Animal
    {
        // Normal Function
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }

        // Virtual Function
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound");
        }

        // Virtual Function
        public virtual void Move()
        {
            Console.WriteLine("Animal is moving");
        }
    }

    // Child Class
    class Dog : Animal
    {
        // Override Function
        public override void Sound()
        {
            Console.WriteLine("Dog barks");
        }

        // Override Function
        public override void Move()
        {
            Console.WriteLine("Dog runs");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Object from Child Class
            Dog dog1 = new Dog();

            dog1.Eat();
            dog1.Sound();
            dog1.Move();
        }
    }
}