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
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowMainMenu();
            
        }
    }
    class MainMenu
    {
        public void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Сделать коффе");
                Console.WriteLine("2. Добавить ингредиенты");
                Console.WriteLine("3. Проверить ингредиенты");
                int result =  int.Parse(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        break;
                    case 2:
                        AddMenu addMenu = new AddMenu();
                        Console.Clear();
                        addMenu.ShowMenu();
                        break;
                    default:
                        Console.WriteLine("Unput incorect");
                        break;
                }
            }
        }
    }
    class AddMenu
    {
        public static int realWater {get; set;}
        public static int realCoffe {get; set;}
        public static int realMilk {get; set;}
        const int maxWater = 900;
        const int maxCoffe = 150;
        const int maxMilk = 300;
        MainMenu mainMenu = new MainMenu();
        public void ShowMenu()
        {
            Console.WriteLine("1. Добавить воды");
            Console.WriteLine("2. Добавить кофе");
            Console.WriteLine("3. Добавить молоко");
            Console.WriteLine("4. Назад");
            
            int result =  int.Parse(Console.ReadLine());
            switch (result)
            {
                case 1:
                    ShowWoterMenu();
                    break;
                case 2:
                    ShowCoffeMenu();
                    break;
                case 3:
                    ShowMilkMenu();
                break;
                case 4:
                    mainMenu.ShowMainMenu();
                break;
                default:
                    Console.WriteLine("Unput incorect");
                    Console.Clear();
                    ShowMenu();
                    break;
            }
        }
        public void ShowWoterMenu()
        {
            Console.WriteLine($"Воды: {realWater}/{maxWater}");
            Console.Write("Налить воды:....");
            int result = int.Parse(Console.ReadLine());
            AddWater(result);
        }
        public void AddWater(int water)
        {
            if (realWater <= maxWater && realWater+water <= maxWater)
            {
                realWater += water;
                Console.Clear();
                mainMenu.ShowMainMenu();
            }
            else
            {
                Console.WriteLine("Перелив воды");
                Thread.Sleep(1000);
                Console.Clear();
                mainMenu.ShowMainMenu();
            }
            
        }
        public void ShowCoffeMenu()
        {
            Console.WriteLine($"Коффе: {realCoffe}/{maxCoffe}");
            Console.Write("Положить коффе....");
            int result = int.Parse(Console.ReadLine());
            AddCoffe(result);
        }
        public void AddCoffe(int coffe)
        {
            if(realCoffe <= maxCoffe && realCoffe+coffe <= maxCoffe)
            {
                realCoffe+=coffe;
                Console.Clear();
                mainMenu.ShowMainMenu();
            }
            else
            {
                Console.WriteLine("Много коффе");
                Thread.Sleep(1000);
                Console.Clear();
                mainMenu.ShowMainMenu();
            }
        }
        public void ShowMilkMenu()
        {
            Console.WriteLine($"Молоко: {realMilk}/{maxMilk}");
            Console.Write("Налить молоко....");
            int result = int.Parse(Console.ReadLine());
            AddMilk(result);
        }
        public void AddMilk(int milk)
        {
            if (realMilk <= maxMilk && realMilk+milk <= maxMilk)
            {
                realMilk+=milk;
                Console.Clear();
                mainMenu.ShowMainMenu();
            }
            else
            {
                Console.WriteLine("Много молока");
                Thread.Sleep(1000);
                Console.Clear();
                mainMenu.ShowMainMenu();
            }
        }
    }
}

