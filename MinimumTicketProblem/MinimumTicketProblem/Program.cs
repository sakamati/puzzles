using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumTicketProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] A = { 1, 2, 4, 5, 7, 29, 30 };
            //int[] A = { 2, 15, 16, 17, 19, 25 };
            //int[] A = { 1, 5, 6, 7, 8, 9, 10, 11 };
            //int[] A = { 1, 5, 6, 7 };
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 21, 22, 23, 24, 25 };
            int output = correctSolution2(A);

            Console.WriteLine(output);
            Console.ReadLine();
        }

        static int correctSolution2(int[] A)
        {
            // 2, 7, 25
            if (A.Length >= 23) return 25;

            if (A.Length <= 3) return 2 * A.Length;

            int[] partialSolution = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                partialSolution[i] = subSolution2(A, partialSolution, i);
            }

            return partialSolution[A.Length - 1];
        }

        static int subSolution2(int[] A, int[] partialSoln, int index)
        {
            int minimumTicket = index == 0 ? 2 : partialSoln[index - 1] + 2;

            if (index < 3)
            {
                return minimumTicket;
            }

            for (int i = 0; i < index && index - i > 2; i++)
            {
                if (A[index] - A[i] <= 6)
                {
                    int temp = (i == 0 ? 0 : partialSoln[i - 1]) + 7;
                    minimumTicket = temp < minimumTicket ? temp : minimumTicket;
                }
            }

            return minimumTicket;
        }
    }
}
