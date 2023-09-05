using System;
using System.Text;

namespace FizzBuzz
{
	public class FizzBuzzIterations
    {

        public static string Iter1(int input)
        {
            var result = FizzBuzzGenerator(input, 3, 5);
            return result;
        }

        public static string Iter2(int input)
        {
            var result = FizzBuzzGenerator(input, 7, 11);
            return result;
        }


        public static string Iter3(int input)
        {
            var resultFizzBuzz = FizzBuzzGenerator(input, 13, 17);
            if (resultFizzBuzz == input.ToString()) resultFizzBuzz = "";

            var resultFuzzBizz = FuzzBizzGenerator(input, 19, 23);
            if (resultFuzzBizz == input.ToString()) resultFuzzBizz = "";

            string finalResult = resultFizzBuzz + resultFuzzBizz;

            return finalResult.Length > 0 ? finalResult : input.ToString();
        }

        private static string FuzzBizzGenerator(int input, int nbrFuzz, int nbrBizz)
        {
            var result = new StringBuilder();
            if (input % nbrFuzz == 0) result.Append("Fuzz");
            if (input % nbrBizz == 0) result.Append("Bizz");

            return result.Length > 0 ? result.ToString() : input.ToString();
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

