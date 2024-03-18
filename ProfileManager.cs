using System.Collections.Generic;
class Profile
{
    public string Name { get; set; }
    public int Water { get; set; }
    public int Coffe { get; set; }
    public int Milk { get; set; }
    public int Cups { get; set; }

    public Profile(string name, int water, int coffe, int milk, int cups)
    {
        Name = name;
        Water = water;
        Coffe = coffe;
        Milk = milk;
        Cups = cups;
    }
}
class Menu
{
    public static void ShowMenu()
    {
        while (true)
        {

            string[] menuOptions =
            {
                "1. Добавить профиль",
                "2. Приготовить коффе по профилю",
                "3. Назад"
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
                    Console.Clear();
                    ProfileManager.InputCreateProfile();
                    break;
                case 2:
                    Console.Clear();
                    ProfileManager.ViewCreatProfiel();
                    ProfileManager.MakeCoffeWithProfile();
                    break;
                case 3:
                    Console.Clear();
                    MainMenu.ShowMainMenu();
                    break;
                default:
                    Console.WriteLine("Unput incorect");
                    break;
            }
        }

    }
}
class ProfileManager
{
    public static List<Profile> profiles = new List<Profile>();
    public static void MakeCoffeWithProfile()
    {
        Console.WriteLine("Введите имя профиля для приготовления кофе: ");
        try
        {
            string profileName = Console.ReadLine();
            if (profileName == "") { throw new Exception(); }
            else { ProfileSearch(profileName); }
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка ввода.");
            MakeCoffeWithProfile();
        }
    }
    public static void CreateProfile(string name, int water, int coffe, int milk, int cup)
    {
        profiles.Add(new Profile(name, water, coffe, milk, cup));
        Console.WriteLine($"Профиль {name} успешно создан.");
        Console.ReadKey();
        Console.Clear();
    }
    public static void CookingCoffeProfile(Profile profile)
    {
        if (Coffe.CheckIngredient(profile.Water * profile.Cups, profile.Coffe * profile.Cups, profile.Milk * profile.Cups))
        {
            Coffe.PrepairCoffe(profile.Water * profile.Cups, profile.Coffe * profile.Cups, profile.Milk * profile.Cups);
            //ViewCreatingCoffe.AddHistoryCokinh(coffeType, Cup);
            Console.WriteLine($"Коффе приготовлен в колличестве {profile.Cups} штук");
            ViewCreatingCoffe.historyCoking.Add(profile.Name); ViewCreatingCoffe.historyCoking.Add(profile.Cups.ToString());
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine("Недостаточно ингредиентов");
            Console.ReadKey();
            Console.Clear();
        }

    }
    public static void ViewCreatProfiel()
    {
        if (profiles.Count == 0)
        {
            Console.WriteLine("Созданных профилей нет.");
            Menu.ShowMenu();
        }
        else
        {
            foreach (var item in profiles)
            {
                Console.WriteLine($"Имя профиля:{item.Name}\t\tВоды: {item.Water}\tМолока: {item.Milk}\tКоффе: {item.Coffe}\tКол-во кружек: {item.Cups}");
            }
        }
    }
    public static void ProfileSearch(string name)
    {
        Profile profile = profiles.Find(p => p.Name == name);
        if (profile == null)
        {
            Console.WriteLine("Профиль не найден.");
            return;
        }
        CookingCoffeProfile(profile);
    }
    public static void RemoveProfile(string name)
    {
        Profile profile = profiles.Find(p => p.Name == name);
        if (profile == null)
        {
            Console.WriteLine("Профиль не найден");
        }
    }
    public static void InputCreateProfile()
    {
        Console.WriteLine("Введите имя профиля:");
        string profileName = Console.ReadLine();
        try
        {
            if (string.IsNullOrWhiteSpace(profileName))
            {
                throw new ArgumentException();
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Имя профиля не может быть пустым.");
            InputCreateProfile();
            return;
        }

        Console.WriteLine("Введите количество воды (мл):");
        int water = MainMenu.GetUserChoice();
        if (water > 300)
        {
            Console.WriteLine("Превышен лимит, не больше 300 мл");
            Console.ReadKey();
            Console.Clear();
            InputCreateProfile();
            return;
        }

        Console.WriteLine("Введите количество кофе (гр):");
        int coffe = MainMenu.GetUserChoice();
        if (coffe > 150)
        {
            Console.WriteLine("Превышен лимит, не больше 150 гр");
            Console.ReadKey();
            Console.Clear();
            InputCreateProfile();
            return;
        }

        Console.WriteLine("Введите количество молока (мл):");
        int milk = MainMenu.GetUserChoice();
        if (milk > 300)
        {
            Console.WriteLine("Превышен лимит, не больше 300 мл");
            Console.ReadKey();
            Console.Clear();
            InputCreateProfile();
            return;
        }

        Console.WriteLine("Введите количество кружек (шт):");
        int cups = MainMenu.GetUserChoice(); if (coffe > 150)
        {
            Console.WriteLine("Превышен лимит, не больше 3 шт");
            Console.ReadKey();
            Console.Clear();
            InputCreateProfile();
            return;
        }

        CreateProfile(profileName, water, coffe, milk, cups);
    }
}

