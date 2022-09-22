using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceType
{
    class Human : Person, ITest, Itest2
    {
        private string _name;
        public string Name => _name;

        public void test()
        {
            throw new NotImplementedException();
        }

        public void test(string a)
        {
            throw new NotImplementedException();
        }

        public void walk()
        {
            throw new NotImplementedException();
        }
    }
}
