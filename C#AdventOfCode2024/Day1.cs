﻿using System.Diagnostics.CodeAnalysis;

namespace C_AdventOfCode2024
{
    internal class Day1
    {
        public static void Part1()
        {
            string[] lines = File.ReadAllLines("Resources\\Day1\\input.txt");

            List<int> locations1 = new List<int>();
            List<int> locations2 = new List<int>();
            foreach (string line in lines)
            {
                string[] splits = line.Split("   ");
                locations1.Add(int.Parse(splits[0]));
                locations2.Add(int.Parse(splits[1]));
            }

            locations1.Sort();
            locations2.Sort();

            List<int> distance = new List<int>();
            for (int i = 0; i < locations1.Count; i++)
                distance.Add(Math.Abs(locations1[i] - locations2[i]));

            int totalDistance = Math.Abs(distance.Sum());
            Console.WriteLine($"Total Distance: {totalDistance}");
        }
    }
}