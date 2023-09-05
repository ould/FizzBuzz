using System;
namespace FizzBuzz
{
    public static class HelpersFizzBuzz
    {
        public static Func<int, bool> EstDivisiblePar(int input)
        {
            return i => i % input == 0;
        }

        public static Func<int, bool> EstImpair()
        {
            return i => (i != 0) && (i % 2 != 0);
        }

        public static Func<int, bool> EstCarreParfait()
        {
            return i => Math.Sqrt(i) % 1 == 0;
        }
        public static Func<int, bool> PasDivisiblePar(int input)
        {
            return i => i % input != 0;
        }
    }
}

