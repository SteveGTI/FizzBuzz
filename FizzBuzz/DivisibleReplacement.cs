using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class DivisibleReplacement
    {
        public int Denominator;

        public string Replacement;

        // Constructor used by testing project
        public DivisibleReplacement(int denominator, string replacement)
        {
            Denominator = denominator;
            Replacement = replacement;
        }

        // Method to evaluate if the numerator parameter ought to be replaced when output
        public string ReplacmentValue(int numerator)
        {
            return (numerator % Denominator == 0 ? Replacement : String.Empty);
        }
    }
}
