using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    //##TASK DESCRIPTION
    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

    //Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

    //Note: If the number is a multiple of both 3 and 5, only count it once.

namespace Codewars__Multiples_of_3_or_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySolution
            int Solution(int value)
            {
                int sum = 0;
                for (int i = 0; i < value; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        sum += i;
                    }
                }

                return sum;
            }
            //Codewars solution + code review for myself

            int Solution2(int n)
            {
                return Enumerable.Range(0, n).Where(e => e % 3 == 0 || e % 5 == 0).Sum(); // So Enumerable can be used on any object that implement IEnumerable interface.
                                                                                          // Range generate numbers with specified range like 0-100, rest of code is simply LINQ query. 
            }

        }
    }
}
