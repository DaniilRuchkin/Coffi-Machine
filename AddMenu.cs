class AddMenu
    {
        public static int RealWater {get; set;}
        public static int RealCoffe {get; set;}
        public static int realMilk;
        public static int RealMilk
        {
            get { return realMilk; }
            set { realMilk = value; }
        }
        const int maxWater = 900;
        const int maxCoffe = 150;
        const int maxMilk = 300;
        
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
                    MainMenu.ShowMainMenu();
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
            Console.WriteLine($"Воды: {RealWater}/{maxWater}");
            Console.Write("Налить воды:....");
            int result = int.Parse(Console.ReadLine());
            AddWater(result);
        }
        public void AddWater(int water)
        {
            if (RealWater <= maxWater && RealWater+water <= maxWater)
            {
                RealWater += water;
                Console.Clear();
                MainMenu.ShowMainMenu();
            }
            else
            {
                Console.WriteLine("Перелив воды");
                Thread.Sleep(1000);
                Console.Clear();
                MainMenu.ShowMainMenu();
            }
            
        }
        public void ShowCoffeMenu()
        {
            Console.WriteLine($"Коффе: {RealCoffe}/{maxCoffe}");
            Console.Write("Положить коффе....");
            int result = int.Parse(Console.ReadLine());
            AddCoffe(result);
        }
        public void AddCoffe(int coffe)
        {
            if(RealCoffe <= maxCoffe && RealCoffe+coffe <= maxCoffe)
            {
                RealCoffe+=coffe;
                Console.Clear();
                MainMenu.ShowMainMenu();
            }
            else
            {
                Console.WriteLine("Много коффе");
                Thread.Sleep(1000);
                Console.Clear();
                MainMenu.ShowMainMenu();
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
            if (RealMilk <= maxMilk && RealMilk+milk <= maxMilk)
            {
                IngredientManager.AddIngredient(ref realMilk, maxMilk, milk);
                Console.Clear();
                MainMenu.ShowMainMenu();
            }
            else
            {
                Console.WriteLine("Много молока");
                Thread.Sleep(1000);
                Console.Clear();
                MainMenu.ShowMainMenu();
            }
        }
        public void ShowIngregient()
        {
            Console.WriteLine($"Воды: {RealWater}/{maxWater}");
            Console.WriteLine($"Коффе: {RealCoffe}/{maxCoffe}");
            Console.WriteLine($"Молоко: {realMilk}/{maxMilk}");
        }
    }
    