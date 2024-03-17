class IngredientManager
    {
        public static void AddIngredient(ref int currentAmount, int maxAmount, int amountToAdd)
        {
            if (currentAmount + amountToAdd <= maxAmount)
            {
                currentAmount += amountToAdd;
            }
            else
            {
                Console.WriteLine($"Слишком много ингредиента. Максимальное количество: {maxAmount}");
                Thread.Sleep(1000);
            }
        }
    }