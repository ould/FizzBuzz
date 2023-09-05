using System;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
	public class FizzBuzzIterations
    {
        private IDictionary<Func<int, bool>, string> _lienInputResult;

        public FizzBuzzIterations()
        {
            _lienInputResult = new Dictionary<Func<int, bool>, string>();
        }

        public string Iter1(int input)
        {
            
            _lienInputResult.Add(i => i%3 == 0, "Fizz");
            _lienInputResult.Add(i => i%5 == 0, "Buzz");

            return SuperFizzBuzzGenerator(input, _lienInputResult);

        }      

        public string Iter2(int input)
        {    
            _lienInputResult.Add(i => i%7 == 0, "Fizz");
            _lienInputResult.Add(i => i%11 == 0, "Buzz");

            return SuperFizzBuzzGenerator(input, _lienInputResult);
        }


        public string Iter3(int input)
        {
            _lienInputResult.Add(i=> i%13 ==0, "Fizz");
            _lienInputResult.Add(i => i % 17 == 0, "Buzz");
            _lienInputResult.Add(i => i % 19 == 0, "Fuzz");
            _lienInputResult.Add(i => i % 23 == 0, "Bizz");

            return SuperFizzBuzzGenerator(input, _lienInputResult);
        }

        public string SuperFizzBuzz(int input)
        {
            
            _lienInputResult.Add(i => i % 3 != 0, "Fizz");
            _lienInputResult.Add(i => (i !=0) && (i % 2 != 0), "Buzz");
            _lienInputResult.Add(i => Math.Sqrt(input)%1 == 0 , "Fuzz");

            var result = SuperFizzBuzzGenerator(input, _lienInputResult);
            return result;


        }

        private string SuperFizzBuzzGenerator(int input, IDictionary<Func<int, bool>, string> lienInputResult)
        {
            var result = new StringBuilder();
            foreach (var paire in lienInputResult)
            {
                if (paire.Key.Invoke(input)) result.Append(paire.Value);
            }

            return result.Length > 0 ? result.ToString() : input.ToString();
        }




    }
}

