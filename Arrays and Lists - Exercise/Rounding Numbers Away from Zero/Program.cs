﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            
            foreach (var item in numbers)
            {
                double rounded = Math.Round(item, MidpointRounding.AwayFromZero);
                Console.WriteLine(item + " => " + rounded);
            }

        }
    }
}
