using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TASK-7

namespace Calculator
{
    public class calculator
    { 
        public int Divide(int a ,int b)
        {
            if (b == 0) 
            {
               throw new DivideByZeroException("Cannot divided by Zero. .");
            }
            return a / b;
        }
        public void ProcessNumbers(int[] numbers) 
        {
            if (numbers == null || numbers.Length == 0) 
            {
                throw new ArgumentException("cannot be null or empty");
            }
            for (int i = 0; i <= numbers.Length; i++) 
            {
                try
                {
                var result = Divide(numbers[i], 2);
                Console.WriteLine($"Result for {numbers[i]}: {result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Error: Cannot divide {numbers[i]} by 2.");
                }

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           calculator calc = new calculator();
            int[] numbers = { 10, 15, 0, 25 };
            calc.ProcessNumbers(numbers);

        }
    }
}
