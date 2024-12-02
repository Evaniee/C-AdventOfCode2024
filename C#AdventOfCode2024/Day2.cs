namespace C_AdventOfCode2024
{
    internal class Day2
    {
        public static void Part1()
        {
            string[] lines = File.ReadAllLines("Resources\\Day2.txt");

            List<List<int>> data = new List<List<int>>();
            foreach (string line in lines)
            {
                List<int> values = new List<int>();
                foreach (string split in line.Split(' '))
                    values.Add(int.Parse(split));
                data.Add(values);
            }

            int safe = 0;
            foreach (List<int> line in data) if (ValidLine(line)) safe++;
              
                    Console.WriteLine($"Safe: {safe}");
        }

        private static bool ValidLine(List<int> line)
        {
            // How do values change (True = INC, False = DEC)
            bool increasing = line[0] < line[1];

            // Difference Between Values
            for(int i = 0, j = 1; j < line.Count(); i++, j++)
            {
                // Invalid if no change
                if (line[i] == line[j])
                    return false;

                // Not following sequence
                if (line[i] < line[j] != increasing)
                    return false;

                // Too large of a change
                if (Math.Abs(line[i] - line[j]) > 3)
                    return false;
            }
            return true;
        }
    }
}