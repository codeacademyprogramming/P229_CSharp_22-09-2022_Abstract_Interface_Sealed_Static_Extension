using System;
using System.Collections.Generic;
using System.Text;

namespace Asbtraction
{
    abstract class Animal
    {
        public string Name;
        public int Age;
        public bool Gender;

        public abstract void Eat();
    }
}
