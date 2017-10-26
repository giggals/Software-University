﻿using System;
using System.IO;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            string[] alphabet = new string[]
            {
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
            };

            string[] input = File.ReadAllLines("input.txt");

            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (input[j].ToString().Contains(alphabet[i]))
                    {
                        Console.WriteLine($"{input[j] } -> {i}");
                        
                    }
                }
            }
        }
    }
}