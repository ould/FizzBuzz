using System;
using System.Text;

namespace FizzBuzz
{
	public class FizzBuzzIterations
    {
        private IDictionary<int, string> _lienInputResult;

        public FizzBuzzIterations()
        {
            _lienInputResult = new Dictionary<int, string>();
        }

        public string Iter1(int input)
        {
            
            _lienInputResult.Add(3, "Fizz");
            _lienInputResult.Add(5, "Buzz");

            return FizzBuzzGameGenerator(input, _lienInputResult);

        }      

        public string Iter2(int input)
        {    
            _lienInputResult.Add(7, "Fizz");
            _lienInputResult.Add(11, "Buzz");

            return FizzBuzzGameGenerator(input, _lienInputResult);
        }


        public string Iter3(int input)
        {
            _lienInputResult.Add(13, "Fizz");
            _lienInputResult.Add(17, "Buzz");
            _lienInputResult.Add(19, "Fuzz");
            _lienInputResult.Add(23, "Bizz");

            return FizzBuzzGameGenerator(input, _lienInputResult);
        }

        public string SuperFizzBuzz(int input)
        {
            var result = new StringBuilder();
            if (input % 3 != 0) result.Append("Fizz");
            if (input != 0 && input % 2 != 0) result.Append("Buzz");
            if (Math.Sqrt(input) % 1 == 0) result.Append("Fuzz");

            return result.Length > 0 ? result.ToString() : input.ToString();
        }

        private string FizzBuzzGameGenerator(int input, IDictionary<int, string> lienInputResult)
        {
            var result = new StringBuilder();
            foreach (var paire in lienInputResult)
            {
                if (input % paire.Key == 0) result.Append(paire.Value);
            }

            return result.Length > 0 ? result.ToString() : input.ToString();
        }

    }
}

