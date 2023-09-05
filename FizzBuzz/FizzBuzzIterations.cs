using System;
using System.Text;

namespace FizzBuzz
{
	public class FizzBuzzIterations
    {
		public FizzBuzzIterations()
		{
		}

        public static string Iter1(int valeur)
        {
            var result = new StringBuilder();
            if (valeur % 3 == 0) result.Append("Fizz");
            if (valeur % 5 == 0) result.Append("Buzz");

            return result.Length > 0 ? result.ToString() : valeur.ToString();
        }
    }
}

