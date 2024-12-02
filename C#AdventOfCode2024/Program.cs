namespace C_AdventOfCode2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.Write("Select a day:");
            while (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 31)
                Console.Write("Error: Invalid day, retry.\nSelect a day: ");

            int choice;
            Console.Write("Select a choice:");
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
                Console.Write("Error: Invalid day, retry.\nSelect a day: ");

            switch (day)
            {
                case 1:
                    if(choice == 1)
                        Day1.Part1();
                    else if (choice == 2)
                        Day1.Part2();
                    break;
                default:
                    Console.WriteLine("Unimplemented");
                    break;
            }
        }
    }
}