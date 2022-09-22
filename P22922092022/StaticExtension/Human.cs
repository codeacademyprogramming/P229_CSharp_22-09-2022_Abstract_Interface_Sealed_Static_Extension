using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExtension
{
    class Human
    {
        public static int S_Id;
        public readonly int Id;
        public string Name;

        public Human()
        {
            S_Id++;
            Id = S_Id;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {Id}");
        }
    }
}
