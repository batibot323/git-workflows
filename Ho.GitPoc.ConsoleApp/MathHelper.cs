using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ho.GitPoc.ConsoleApp
{
    public static class MathHelper
    {
        public static bool IsEven(int myInteger)
        {
            switch (myInteger)
            {
                case 1: return false;
                case 2: return true;
                case 3: return false;
                case 4: return true;
                case 5: return false;
                case 6: return true;
                default: return false;
            }
        }
    }
}
