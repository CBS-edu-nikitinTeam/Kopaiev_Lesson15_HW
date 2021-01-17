using System;

namespace Task_002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file type");
            string input = Console.ReadLine()?.ToLower().Trim();
            DocumentChooseLogic logic = new DocumentChooseLogic(input);

            // Delay
            Console.ReadLine();
        }
    }
}
