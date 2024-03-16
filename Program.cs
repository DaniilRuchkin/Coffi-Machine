using System.Linq.Expressions;

namespace CoffieMachineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Coffi Mashine off, on ? \n1. On\n2. Off");
                int result =  int.Parse(Console.ReadLine());
                if (result == 1)
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            MainMenu.ShowMainMenu();
        }
    }
}

