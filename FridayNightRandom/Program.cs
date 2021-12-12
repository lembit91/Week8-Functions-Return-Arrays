﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayNightRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayRandomFood();
            DisplayRandomDrink();
            DisplayRandomMovie();
        }

        private static int GenerateRandomIndex(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            return randomIndex;
        }


        private static void DisplayRandomFood()
        {
            string[] foods = { "chicken wings", "pizza", "sushi", "popcorn", "salad" };

            Console.WriteLine($"Computer picked: {foods[GenerateRandomIndex(foods)]}");
        }

        private static void DisplayRandomDrink()
        {
            string[] drinks = { "apple juice", "coke", "fanta", "sprite" };

            Console.WriteLine($"Computer picked: {drinks[GenerateRandomIndex(drinks)]}");
        }

        private static void DisplayRandomMovie()
        {
            string[] movies = { "Matrix", "Titanic", "Sparta", "Lion King" };

            Console.WriteLine($"Computer picked: {movies[GenerateRandomIndex(movies)]}");
        }
    }
}

