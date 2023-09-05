using System;
using System.Text;

namespace FizzBuzz
{
	public class FizzBuzzIterations
    {

        public static string Iter1(int valeur)
        {
            var result = FizzBuzzGenerator(valeur, 3, 5);
            return result;
        }

        public static string Iter2(int valeur)
        {
            var result = FizzBuzzGenerator(valeur, 7, 11);
            return result;
        }

        public static string Iter3(int v)
        {
            throw new NotImplementedException();
        }

        private static string FizzBuzzGenerator(int input, int nbrFizz, int nbrBuzz)
        {
            var result = new StringBuilder();
            if (input % nbrFizz == 0) result.Append("Fizz");
            if (input % nbrBuzz == 0) result.Append("Buzz");

            return result.Length > 0 ? result.ToString() : input.ToString();
        }
    }
}

