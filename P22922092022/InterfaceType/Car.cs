using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceType
{
    class Car : ITest
    {
        public string Name => throw new NotImplementedException();

        public void test(string a)
        {
            throw new NotImplementedException();
        }

        public void test()
        {
            throw new NotImplementedException();
        }
    }
}
