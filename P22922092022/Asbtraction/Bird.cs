using System;
using System.Collections.Generic;
using System.Text;

namespace Asbtraction
{
    abstract class Bird : Animal
    {
        public bool IsFly;

        public abstract void Fly();
    }
}
