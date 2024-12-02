namespace C_AdventOfCode2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.Write("Select a day:");
            while (int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
                Console.Write("Error: Invalid day, retry.\nSelect a day: ");
            
            switch(day)
            {
                case 1:
                    break;
                default:
                    Console.WriteLine("Unimplemented");
                    break;
            }
        }
    }
}