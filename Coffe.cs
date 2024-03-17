class Coffe
    {
        public enum Assortiment
        {
            Espresso = 1,
            Kapychino = 2
        }
        public static void ShowCoffeMenu()
        {
            Console.WriteLine("1. Приготовить Экспрессо");
            Console.WriteLine("2. Приготовить Капучино");
            Console.WriteLine("3. Вернуться");
            int result = int.Parse(Console.ReadLine());
            switch (result)
            {
                case 1:
                    CreateCoffe(Assortiment.Espresso); break;
                case 2:
                    CreateCoffe(Assortiment.Kapychino); break;
                case 3:
                    MainMenu.ShowMainMenu(); break;
                default:
                    break;
            }
        }
        public static void  CreateCoffe(Assortiment coffeType)
        {
            switch (coffeType)
            {
                case Assortiment.Espresso:
                    if (AddMenu.RealWater > 300 && AddMenu.RealCoffe >=20 && AddMenu.RealMilk >=100)
                    {
                        AddMenu.RealWater -= 300;AddMenu.RealCoffe -= 20; AddMenu.RealMilk -= 100;CheckAndClear.CookingCoffe();
                        Console.WriteLine("Экспрессо приготовленно");
                    }
                    else
                    {
                        Console.WriteLine("Недостатоно ингридиентов");
                    }
                break;
                case Assortiment.Kapychino:
                    if (AddMenu.RealWater > 300 && AddMenu.RealCoffe >= 30 && AddMenu.RealMilk >= 110)
                    {
                        AddMenu.RealWater -= 300; AddMenu.RealCoffe -= 30; AddMenu.RealMilk -= 110;CheckAndClear.CookingCoffe();
                        Console.WriteLine("Капучино приготовленно");
                    }
                    else
                    {
                        Console.WriteLine("Недостатоно ингридиентов");
                    }
                break;
                default:
                    break;
            }
        }
    }