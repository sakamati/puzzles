using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurseSortStack
{
    /// <summary>
    /// Program to sort a stack using Recursion
    /// Ref: http://www.geeksforgeeks.org/sort-a-stack-using-recursion/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(30);
            stack.Push(5);
            stack.Push(18);
            stack.Push(14);
            stack.Push(3);

            Console.WriteLine("Before sort");
            PrintStack(stack);
            RecurseSort(stack);

            Console.WriteLine("After sort");
            PrintStack(stack);

            Console.ReadLine();

        }

        static void PrintStack(Stack<int> stack)
        {
            var ar = stack.ToArray();
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
        }

        static void RecurseSort(Stack<int> stack)
        {
            if(stack.Count !=0)
            {
                int element = stack.Pop();
                RecurseSort(stack);
                InsertElementInStack(stack, element);
            }
        }

        static void InsertElementInStack(Stack<int> stack, int element)
        {
            if (stack.Count != 0 && element < stack.Peek())
            {
                int popped = stack.Pop();
                InsertElementInStack(stack, element);
                stack.Push(popped);
            }
            else
            {
                stack.Push(element);
            }
        }
    }
}
