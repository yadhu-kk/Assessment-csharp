using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TASK-1

namespace variablesAndCalculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
                try
                {
                   
                    Console.Write("Enter hourly rate: $");
                    decimal hourlyRate = GetValidDecimalInput();

             
                    Console.Write("Enter hours worked: ");
                    decimal hoursWorked = GetValidDecimalInput();

                    
                    decimal regularPay = CalculateRegularPay(hourlyRate, hoursWorked);
                    decimal overtimePay = CalculateOvertimePay(hourlyRate, hoursWorked);
                    decimal grossPay = regularPay + overtimePay;

                    
                    const decimal taxRate = 0.20m;
                    decimal tax = grossPay * taxRate;
                    decimal netPay = grossPay - tax;
             
                    Console.WriteLine("\nPay Calculation Results:");
                    Console.WriteLine($"Regular Pay: ${regularPay}");
                    Console.WriteLine($"Overtime Pay: ${overtimePay}");
                    Console.WriteLine($"Gross Pay: ${grossPay}");
                    Console.WriteLine($"Tax (20%): ${tax}");
                    Console.WriteLine($"Net Pay: ${netPay}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }

            static decimal GetValidDecimalInput()
            {
                while (true)
                {
                    if (decimal.TryParse(Console.ReadLine(), out decimal result) && result >= 0)
                    {
                        return result;
                    }
                    Console.Write("Invalid input. Please enter a non-negative number: ");
                }
            }

            static decimal CalculateRegularPay(decimal rate, decimal hours)
            {
                return rate * Math.Min(hours, 40);
            }

            static decimal CalculateOvertimePay(decimal rate, decimal hours)
            {
                if (hours <= 40) return 0;
                return (hours - 40) * rate * 1.5m;
            }
        }
       
        
    
}
