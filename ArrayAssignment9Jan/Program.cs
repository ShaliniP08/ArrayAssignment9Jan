using System;

namespace ArrayAssignment9Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n, rollNo;
            float max,min;
            string studentName;
            float total = 0.0f, avg = 0.0f;

            Console.WriteLine("Enter name of the student");
            studentName = Console.ReadLine();

            Console.WriteLine("Enter roll number");
            rollNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of subjects");
            n = Convert.ToInt32(Console.ReadLine());

            float[] marks = new float[n];
            Console.WriteLine("Enter marks");
            Console.WriteLine("--------------------");

            for (i = 0; i < n; i++)
            {
                marks[i] = Single.Parse(Console.ReadLine());
                if (marks[i] >= 0 && marks[i] <= 100)
                {
                    total = total + marks[i];
                }
                else
                {
                    Console.WriteLine("Error: Wrong Input");
                    i--;
                }
            }

            avg = total / marks.Length;
            max = marks[0];
            min = marks[0];
            for (i = 1; i < n; i++)
            {
                if (marks[i] > max)
                {
                    max = marks[i];
                }
                if (marks[i] < min)
                {
                    min = marks[i];
                }
            }

            Console.WriteLine("\nEntered marks are :");
            for(i=0;i<n;i++)
            {
                Console.WriteLine(marks[i]);
            }
            
            Console.WriteLine($"Highest Marks : {max}");
            Console.WriteLine($"Lowest Marks : {min}");
            Console.WriteLine($"Total : {total}");
            Console.WriteLine($"Average : {avg}");
            Console.ReadLine();
        }
    }
}
