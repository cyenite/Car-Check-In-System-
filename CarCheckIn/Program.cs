using System;

namespace CarCheckIn
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckIn Member = new CheckIn();
           
            Console.Write("Name: ");
            Member.Name = Console.ReadLine();
            Console.Write("Number Plate: ");
            Member.Numberplate = Console.ReadLine();

            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("NAME: {0} ",Member.Name);
            Console.WriteLine("NUMBERPLATE: {0} ", Member.Numberplate);
            Console.WriteLine("TIME: {0} ", Member.Date);

            Console.ReadKey();
        }

    }
    class CheckIn
    {
        public string Name { get; set; }
        public string Numberplate { get; set; }
        public DateTime Date { get; set; }


        public CheckIn()
        {
            Name = "Unknown";
            Numberplate = "Unregistered";
            Date = DateTime.Now;
        }
    }
}
