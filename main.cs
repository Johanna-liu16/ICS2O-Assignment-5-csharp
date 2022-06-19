// Created by: Johanna Liu
// Created on: May 2022
//
// This program calculates the value of pi

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the value of π
        const int num = 4;
        int userInput;
        int counter = 0;
        double answer = 0;
        double denominator = 1;

        // input
        Console.WriteLine("This program calculates the value of π");

        Console.WriteLine("");
        Console.Write("Enter a number: ");
        userInput = Convert.ToInt32(Console.ReadLine());

        // process
       while (counter < userInput)
       {
         if (counter % 2 == 0)
         {
           denominator = counter * 2 + 1;
           answer += num / denominator;
         }
         else
         {
           denominator = counter * 2 + 1;
           answer += -(num / denominator);
         }

        counter++;
       }
       // output
       Console.WriteLine("");
       Console.WriteLine("The value of π is " + answer);

      Console.WriteLine("\nDone.");
    }
}