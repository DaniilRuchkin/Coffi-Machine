class AddMenu
{
    public static int RealWater { get; set; }
    public static int RealCoffe { get; set; }
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
        string[] menuOptions =
        {
                "1. Добавить воды",
                "2. Добавить кофе",
                "3. Добавить молоко",
                "4. Назад",
            };

        Console.WriteLine("Меню:");
        foreach (string option in menuOptions)
        {
            Console.WriteLine(option);
        }
        int result = MainMenu.GetUserChoice();

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
                Console.Clear();
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
        Console.Write("Налить воды:");
        int result = MainMenu.GetUserChoice();
        AddWater(result);
    }
    public void AddWater(int water)
    {
        if (RealWater <= maxWater && RealWater + water <= maxWater)
        {
            RealWater += water;
        }
        else
        {
            Console.WriteLine("Перелив воды! Невозможно добавить больше.");
            Thread.Sleep(1000);
        }
        Console.Clear();
        ShowMenu();

    }
    public void ShowCoffeMenu()
    {
        Console.WriteLine($"Коффе: {RealCoffe}/{maxCoffe}");
        Console.Write("Положить коффе....");
        int result = MainMenu.GetUserChoice();
        AddCoffe(result);
    }
    public void AddCoffe(int coffe)
    {
        if (RealCoffe <= maxCoffe && RealCoffe + coffe <= maxCoffe)
        {
            RealCoffe += coffe;
        }
        else
        {
            Console.WriteLine("Много коффе! Невозможно добавить больше.");
            Thread.Sleep(1000);
        }
        Console.Clear();
        ShowMenu();
    }
    public void ShowMilkMenu()
    {
        Console.WriteLine($"Молоко: {realMilk}/{maxMilk}");
        Console.Write("Налить молоко....");
        int result = MainMenu.GetUserChoice();
        AddMilk(result);
    }
    public void AddMilk(int milk)
    {
        if (RealMilk <= maxMilk && RealMilk + milk <= maxMilk)
        {
            IngredientManager.AddIngredient(ref realMilk, maxMilk, milk);
        }
        else
        {
            Console.WriteLine("Много молока! Невозможно добавить больше.");
            Thread.Sleep(1000);
        }
        Console.Clear();
        ShowMenu();
    }
    public void ShowIngregient()
    {
        Console.WriteLine($"Воды: {RealWater}/{maxWater}");
        Console.WriteLine($"Коффе: {RealCoffe}/{maxCoffe}");
        Console.WriteLine($"Молоко: {realMilk}/{maxMilk}");
        Console.ReadKey();
        Console.Clear();
    }
}
