using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExtension
{
    static class Student
    {
        public static string Name;
        public static int Age { get; set; }
        //public string SurName;

        static Student()
        {
            Console.WriteLine("Static");
        }

        //public Student()
        //{
        //    Console.WriteLine("Public");
        //}

        //public void Adi()
        //{
        //    Console.WriteLine(Name);
        //}

        public static void Test()
        {
            
        }

        public static void Test(string a)
        {

        }
    }
}
