﻿using System.Diagnostics;
using System.IO.Pipes;
using System.Net.Security;

namespace Logicalprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 2; i <= num/2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(num + " is Not Prime Number");
                    return;
                }
            }
            Console.WriteLine(num + " is Prime Number");
        } 
    }
}