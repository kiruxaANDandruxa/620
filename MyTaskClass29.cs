﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1212.Classes
{
    internal class Calculator29
    {
        public double X;

        public Calculator29(double x29)
        {
            X = x29;
        }
        public bool CalculateA()
        {
            return 2 * X / Math.PI != 0;
        }
        public void DisplayResults29()
        {
            Console.WriteLine($"A = {CalculateA()}");
            Console.ReadLine();
        }
    }
}