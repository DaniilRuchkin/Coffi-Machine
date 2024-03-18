using System.Globalization;

class Coffe
{
    public enum Assortiment
    {
        Espresso = 1,
        Kapychino = 2
    }
    private const int RequiredWaterEspresso = 300;
    private const int RequiredCoffeEspresso = 20;
    private const int RequiredMilkEspresso = 100;
    private const int RequiredWaterKapuchino = 300;
    private const int RequiredCoffeKapuchino = 30;
    private const int RequiredMilkKapuchino = 110;
    public static int Cup { get; set; }
    public static void ShowCoffeMenu()
    {
        string[] optionMenu = {
                "1. Приготовить Экспрессо",
                "2. Приготовить Капучино",
                "3. Вернуться"
            };

        Console.WriteLine("Меню:");
        foreach (string option in optionMenu)
        {
            Console.WriteLine(option);
        }

        int result = MainMenu.GetUserChoice();
        switch (result)
        {
            case 1:
                Console.Clear();
                CreateCoffe(Assortiment.Espresso); break;
            case 2:
                Console.Clear();
                CreateCoffe(Assortiment.Kapychino); break;
            case 3:
                Console.Clear();
                MainMenu.ShowMainMenu(); break;
        }
    }
    public static void CreateCoffe(Assortiment coffeType)
    {
        Cup = CupAdd();
        int requiredWater = 0, requiredCoffe = 0, requiredMilk = 0;
        switch (coffeType)
        {
            case Assortiment.Espresso:
                requiredCoffe = RequiredCoffeEspresso;
                requiredWater = RequiredWaterEspresso;
                requiredMilk = RequiredMilkEspresso;
                break;
            case Assortiment.Kapychino:
                requiredWater = RequiredWaterKapuchino;
                requiredCoffe = RequiredCoffeKapuchino;
                requiredMilk = RequiredMilkKapuchino;
                break;
            default:
                Console.WriteLine("Неверный выбор коффе");
                break;
        }
        if (Cup <= 0)
        {
            Console.WriteLine("Неверное количество кружек кофе.");
            return;
        }
        if (CheckIngredient(requiredWater * Cup, requiredCoffe * Cup, requiredMilk * Cup))
        {
            PrepairCoffe(requiredWater * Cup, requiredCoffe * Cup, requiredMilk * Cup);
            ViewCreatingCoffe.AddHistoryCokinh(coffeType, Cup);
            Console.WriteLine($"Коффе {coffeType} приготовлен в колличестве {Cup} штук");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"Недостаточно ингредиентов для приготовления {coffeType}.");
        }
    }
    public static bool CheckIngredient(int requiredWater, int requiredCoffe, int requiredMilk)
    {
        return AddMenu.RealWater >= requiredWater && AddMenu.RealCoffe >= requiredCoffe && AddMenu.RealMilk >= requiredMilk;
    }
    public static void PrepairCoffe(int requiredWater, int requiredCoffe, int requiredMilk)
    {
        CheckAndClear.CookingCoffe();
        AddMenu.RealWater -= requiredWater;
        AddMenu.RealCoffe -= requiredCoffe;
        AddMenu.RealMilk -= requiredMilk;
    }
    private static int CupAdd()
    {
        Console.WriteLine("Сколько кружек коффе вы хотите ?");
        return MainMenu.GetUserChoice();
    }
}