﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Minutes
{
    class Centuries_to_Minutes
    {
        static void Main(string[] args)
        {
            int centuries  = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int day = (int)(years * 365.2422);
            int hours = day * 24;
            int minutes = hours * 60;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, day, hours, minutes);
        }
    }
}