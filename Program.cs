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
                int result = MainMenu.GetUserChoice();
                switch (result)
                {
                    case 1:
                        Console.Clear();
                        MainMenu.ShowMainMenu();
                        break;
                    case 2:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некоректный выбор. Повторите ввод");
                        break;
                }
            }
        }
    }
}
