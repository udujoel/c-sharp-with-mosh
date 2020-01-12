using System;

namespace c_sharp_with_mosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mypPerson = new Person();
            mypPerson.firstName = "james";
            mypPerson.lastName = "rom";
            mypPerson.Introduce(mypPerson.lastName);
        }
    }

    class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }
    }
}
