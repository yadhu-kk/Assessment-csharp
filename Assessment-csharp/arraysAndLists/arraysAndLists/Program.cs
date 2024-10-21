using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TASK-3

namespace arraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, avg = 0, passed = 0, failed = 0;
            Console.Write("Enter the number of students: ");
            if (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int[] grades = new int[num];
            Console.WriteLine("Enter the grades (0-100) for each student:");

            for (int i = 0; i < num; i++)
            {
                Console.Write($"Student {i + 1}: ");
                if (!int.TryParse(Console.ReadLine(), out grades[i]) || grades[i] < 0 || grades[i] > 100)
                {
                    Console.WriteLine("Please enter a number between 0 and 100.");
                    i--; 
                    continue;
                }

                sum += grades[i];

                if (grades[i] >= 50)
                    passed++;
                else
                    failed++;
            }

            avg = sum / num;

            Console.WriteLine($"\nResults:");
            Console.WriteLine($"Average grade: {avg}");
            Console.WriteLine($"Highest grade: {grades.Max()}");
            Console.WriteLine($"Lowest grade: {grades.Min()}");
            Console.WriteLine($"Number of students passed (>= 50): {passed}");
            Console.WriteLine($"Number of students failed (< 50): {failed}");
            Console.ReadLine();
        }
    }
}
    

