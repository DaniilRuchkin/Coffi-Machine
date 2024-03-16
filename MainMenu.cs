
class MainMenu
    {
        public static void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Сделать коффе");
                Console.WriteLine("2. Добавить ингредиенты");
                Console.WriteLine("3. Проверить ингредиенты");
                Console.WriteLine("4. Проверить / очистить коффемашинку");
                Console.WriteLine("8. Exit");
                int result =  int.Parse(Console.ReadLine());
                switch (result)
                {
                    case 1:
                        CheckAndClear.CheckDirty();
                        Coffe.ShowCoffeMenu();
                        break;
                    case 2:
                        AddMenu addMenu = new AddMenu();
                        Console.Clear();
                        addMenu.ShowMenu();
                        addMenu.ShowIngregient();
                        break;
                    case 3:
                        addMenu = new AddMenu();
                        addMenu.ShowIngregient();
                        break;
                    case 4:
                        CheckAndClear.ShowDirty();
                    break;
                    case 8:
                        Environment.Exit(0);
                    break;
                    default:
                        Console.WriteLine("Unput incorect");
                        break;
                }
            }
        }
    }