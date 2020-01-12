using System;

namespace c_sharp_with_mosh
{
    class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine($"My name is {firstName} {lastName}");
        }
    }
}