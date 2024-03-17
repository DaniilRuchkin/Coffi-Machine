class CheckAndClear
{
    public static int Dirty { get ;set; }

    public static void ShowDirty()
    {
        Console.WriteLine($"Загрязненно на: {Dirty}");
        Console.WriteLine("Почистить ?\n 1. Да\n 2. Нет");
        int result =  int.Parse(Console.ReadLine());
        switch (result)
        {
            case 1:
                ClearDirty();
            break;
            default:
                MainMenu.ShowMainMenu();
            break;
        }
    }
    public static void CheckDirty()
    {
        if(Dirty >= 3)
        {
            ShowDirty();
        }
    }
    public static void ClearDirty()
    {
        if(Dirty == 0)
        {
            Console.WriteLine("Чистить не надо, и так чисто");
        }
        else
        {
            Dirty = 0;
        }
        
    }
    public static void CookingCoffe()
    {
        if (Dirty < 3)
        {
            Dirty+=1;
        }
        else
        {
            ShowDirty();
        }
    }
}   