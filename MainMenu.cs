
class MainMenu
    {
        private static AddMenu addMenu = new AddMenu();
        public static void ShowMainMenu()
        {
            string[] menuOptions =
            {
                "1. Сделать кофе",
                "2. Добавить ингредиенты",
                "3. Проверить ингредиенты",
                "4. Проверить / очистить кофемашинку",
                "5. Посмотреть историю готовки",
                "6. Добавить профиль",
                "7. Посмотреть список профилей",
                "8. Exit"
            };
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню:");
                foreach (string option in menuOptions)
                {
                    Console.WriteLine(option);
                }

                int result = GetUserChoice();
                switch (result)
                {
                    case 1:
                        Console.Clear();
                        CheckAndClear.CheckDirty();
                        Coffe.ShowCoffeMenu();
                        break;
                    case 2:
                        Console.Clear();
                        addMenu.ShowMenu();
                        addMenu.ShowIngregient();
                        break;
                    case 3:
                        Console.Clear();
                        addMenu.ShowIngregient();
                        break;
                    case 4:
                        Console.Clear();
                        CheckAndClear.ShowDirty();
                    break;
                    case 5:
                        Console.Clear();
                        ViewCreatingCoffe.ViewHistoryCoking();
                    break;
                    case 6:
                        Console.Clear();
                        CreateProfile();
                    break;
                    case 7:
                    ProfileManager.ViewCreatProfiel();
                    break;
                    case 8:
                        Environment.Exit(0);
                    break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Некоректное число");
                    break;
                }
            }
        }
        static void CreateProfile()
        {
            Console.WriteLine("Введите имя профиля:");
            string profileName = Console.ReadLine();

            Console.WriteLine("Введите количество воды (мл):");
            int water = GetUserChoice();

            Console.WriteLine("Введите количество кофе (гр):");
            int coffe = GetUserChoice();

            Console.WriteLine("Введите количество молока (мл):");
            int milk = GetUserChoice();

            Console.WriteLine("Введите количество кружек:");
            int cups = GetUserChoice();

            ProfileManager.CreateProfile(profileName, water, coffe, milk, cups);
        }
        static public int GetUserChoice()
        {
            //Console.WriteLine("Введите ваш выбор: ");
            while (true)
            {
                try
                {
                    int result = int.Parse(Console.ReadLine());
                    if (result < 0)
                    {
                        Console.WriteLine("Ошибка: Введите положительное целое число.");
                        Console.Write("Повторите попытку: ");
                        continue;
                    }
                    return result;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Некорректный формат ввода. Введите целое число.");
                    Console.Write("Повторите попытку: ");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Некоректное число");Console.Write("Повторите попытку: ");
                }
            }
        }
    }