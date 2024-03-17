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
class   ProfileManager
{
    public static List<Profile> profiles = new List<Profile>();
    public static void CreateProfile(string name, int water, int coffe, int milk, int cup)
    {
        profiles.Add(new Profile(name,water,coffe,milk,cup));
        Console.WriteLine($"Профиль {name} успешно создан.");
        Console.ReadKey();
    }
    public static void CookingCoffeProfile(string name)
    {
        Profile profile = profiles.Find(p => p.Name == name);
        if(Coffe.CheckIngredient(profile.Water * profile.Cups, profile.Coffe * profile.Cups, profile.Milk * profile.Cups))
        {
            Coffe.PrepairCoffe(profile.Water * profile.Cups, profile.Coffe * profile.Cups, profile.Milk * profile.Cups);
        }

    }
    public static void ViewCreatProfiel()
    {
        Console.Clear();
        foreach (var item in profiles)
        {
            Console.WriteLine($"Имя профиля:{item.Name}\tВоды: {item.Water}\tМолока: {item.Milk}\tКоффе: {item.Coffe}\tКол-во кружек: {item.Cups}");
        }
        Console.ReadKey();
        Console.Clear();
    }
    public static void ProfileSearch(string name)
    {
        Profile profile = profiles.Find(p => p.Name == name);
        if(profile == null)
        {
            Console.WriteLine("Профиль не найден.");
            return;
        }
        CookingCoffeProfile(name);
    }
}
    
