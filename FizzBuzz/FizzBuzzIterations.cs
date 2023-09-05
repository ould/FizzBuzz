using System;
namespace FizzBuzz
{
	public class FizzBuzzIterations
    {
		public FizzBuzzIterations()
		{
		}

        public string Iter1(int valeur)
        {
            if (valeur % 3 == 0) return "Fizz";
            return valeur.ToString();
        }
    }
}

