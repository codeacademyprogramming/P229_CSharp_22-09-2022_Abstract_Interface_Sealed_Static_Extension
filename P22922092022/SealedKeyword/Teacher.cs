using System;
using System.Collections.Generic;
using System.Text;

namespace SealedKeyword
{
    sealed class Teacher : Student
    {
        public override void Test()
        {
            base.Test();
        }
    }
}
