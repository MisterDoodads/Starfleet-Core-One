using System;

namespace Hello_World___VStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome, {0}, to my world. Press any key to continue...", name);
            Console.ReadLine();
        }
    }
}
