using System;
    
namespace Extension
{
    public static class Helper
    {
        public static bool IsEven(this int i)
        {
            return i % 2 == 0;
        }

        public static bool isDividedBy(this int i, int j)
        {
            return i % j == 0;
        }
    }
}