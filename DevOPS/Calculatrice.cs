using System;
using System.Collections.Generic;
using System.Text;

namespace DevOPS
{
    public class Calculatrice
    {
        public Calculatrice()
        {

        }
        public int add(int a, int b)
        {
            return a + b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            int result = 0;
            if (b != 0)
            {
                result = a / b;
            }
            return result;
        }
    }
}
