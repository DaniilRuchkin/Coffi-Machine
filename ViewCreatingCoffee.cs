class ViewCreatingCoffe
{
    private static List<string> historyCoking = new List<string>();
    public static void AddHistoryCokinh(Coffe.Assortiment assortiment,int cup)
    {
        string coffeName = assortiment.ToString();
        historyCoking.Add(coffeName);
        historyCoking.Add(cup.ToString());
    }
    public static void  ViewHistoryCoking()
    {
        Console.WriteLine("История готовки: ");
        for (int i = 0; i < historyCoking.Count; i += 2)
        {
            Console.WriteLine($"Коффе: {historyCoking[i]}\t\t\tКол-во кружек: {historyCoking[i + 1]}");
        }
        Console.ReadKey();
    }

    
}
