﻿using System;
using System.Collections.Generic;

class LongestAreaInArray
{
    static void Main()
    {
        int countOfInputs = int.Parse(Console.ReadLine());
        List<string> longestSequence = new List<string>();
        List<string> currentSequence = new List<string>();
        

        for (int count = 0; count < countOfInputs; count++)
        {
            string input = Console.ReadLine();
            if (currentSequence.Contains(input))
            {
                currentSequence.Add(input);  
            }
            else
            {
                if (longestSequence.Count < currentSequence.Count)
                {
                    longestSequence.Clear();
                    foreach (var item in currentSequence)
                    {
                        longestSequence.Add(item);
                    }
                }
                currentSequence.Clear();
                currentSequence.Add(input);
            }
        }

        if (longestSequence.Count < currentSequence.Count)
        {
            longestSequence.Clear();
            foreach (var item in currentSequence)
            {
                longestSequence.Add(item);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Result:");
        Console.WriteLine(longestSequence.Count);
        foreach (var item in longestSequence)
        {
            Console.WriteLine(item);
        }
    }
}
