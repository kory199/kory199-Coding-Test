﻿using System;

namespace _10998_A_X_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStr = null;
            int A = 0;
            int B = 0;

            inputStr = Console.ReadLine().Split(' ');

            A = int.Parse(inputStr[0]);
            B = int.Parse(inputStr[1]);

            Console.WriteLine(A * B);
        }
    }
}
