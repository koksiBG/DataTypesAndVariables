using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Refactor_Special_Numbers
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            for (int num = 1; num <= numbers; num++)
            {
                int sum = 0;
                int number = num;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                bool specialNumbers = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", num, specialNumbers);
            }
        }
    }
}