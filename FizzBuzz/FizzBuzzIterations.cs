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
            _lienInputResult.Add(HelpersFizzBuzz.EstDivisiblePar(3), "Fizz");
            _lienInputResult.Add(HelpersFizzBuzz.EstDivisiblePar(5), "Buzz");

            return SuperFizzBuzzGenerator(input, _lienInputResult);

        }      

        public string Iter2(int input)
        {    
            _lienInputResult.Add(HelpersFizzBuzz.EstDivisiblePar(7), "Fizz");
            _lienInputResult.Add(HelpersFizzBuzz.EstDivisiblePar(11), "Buzz");

            return SuperFizzBuzzGenerator(input, _lienInputResult);
        }


        public string Iter3(int input)
        {
            _lienInputResult.Add(HelpersFizzBuzz.EstDivisiblePar(13), "Fizz");
            _lienInputResult.Add(HelpersFizzBuzz.EstDivisiblePar(17), "Buzz");
            _lienInputResult.Add(HelpersFizzBuzz.EstDivisiblePar(19), "Fuzz");
            _lienInputResult.Add(HelpersFizzBuzz.EstDivisiblePar(23), "Bizz");

            return SuperFizzBuzzGenerator(input, _lienInputResult);
        }

        public string SuperFizzBuzz(int input)
        {
            
            _lienInputResult.Add(HelpersFizzBuzz.PasDivisiblePar(3), "Fizz");
            _lienInputResult.Add(HelpersFizzBuzz.EstImpair(), "Buzz");
            _lienInputResult.Add(HelpersFizzBuzz.EstCarreParfait() , "Fuzz");

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

