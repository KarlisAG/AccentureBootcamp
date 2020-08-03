using System;
using System.Collections.Generic;
using System.Text;

namespace Day1
{
    public static class test
    {
        public static int randomMethod(this string smth)
        {
            return Int32.TryParse(smth, out int a) ? a : a;
        }
    }
}
