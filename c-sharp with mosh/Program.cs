﻿using System;

namespace c_sharp_with_mosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Person mypPerson = new Person();
            mypPerson.firstName = "james";
            mypPerson.lastName = "rom";
            mypPerson.Introduce();

            Calculator calculator = new Calculator();

            var numbers = new int[3] {1, 2, 3};
            string list = string.Join("-", numbers);

            int count = 0;
            while (count < list.Length)
            {
                Console.WriteLine(list[count]);
                count++;
            }

            Console.WriteLine(list);

            string path = @"c:\windows\system/anywhereIwant";
            Console.WriteLine(path);
        }
    }
}
