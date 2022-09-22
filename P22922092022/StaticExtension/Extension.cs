using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExtension
{
    static class Extension
    {
        public static bool DevideByFive(this int num, int b,int c, string d)
        {
            if (num % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsDevided(this int num1, int num2)
        {
            if (num1 % num2 == 0)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
