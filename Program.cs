class Program
{
    static void Main()
    {
        Dictionary<int, string> pizzaMenu = new()
        {
            { 1, "Margarita" }, { 2, "Klasika" }, { 3, "Morska" }, { 4, "Kmečka" },
            { 5, "Kraška" }, { 6, "Vegi" }, { 7, "Pikantna" }, { 8, "Tuna" }
        };

        Dictionary<string, double> pizzaPrices = new()
        {
            { "Margarita", 8 }, { "Klasika", 10 }, { "Morska", 14 }, { "Kmečka", 10 },
            { "Kraška", 15 }, { "Vegi", 11 }, { "Pikantna", 14 }, { "Tuna", 16 }
        };

        Dictionary<int, string> dodatkiMenu = new()
        {
            { 1, "Jajce" }, { 2, "Gobe" }, { 3, "Testo z drožmi" }, { 4, "Polnjen rob s sirom" },
            { 5, "Čebula" }, { 6, "Zelenjava" }, { 7, "Ajvar" }, { 8, "Paradižnik" },
            { 9, "Artičoke" }, { 10, "Mozzarella" }, { 11, "Pikantna omaka" }, { 12, "Hrenovke" },
            { 13, "Morski sadeži" }, { 14, "Feferoni" }, { 15, "Tatarska omaka" }, { 16, "Tuna" },
            { 17, "Beluši" }, { 18, "Olive" }, { 19, "Pršut" }, { 20, "Domača salama" },
            { 21, "Slanina" }, { 22, "Koruza" }, { 23, "Kisla smetana" }, { 24, "Sardele" },
            { 25, "Hren" }, { 26, "Brez dodatkov" }
        };

        Dictionary<string, double> dodatkiPrices = new()
        {
            { "Jajce", 1 }, { "Gobe", 1.2 }, { "Testo z drožmi", 1.5 }, { "Polnjen rob s sirom", 0.80 },
            { "Čebula", 0.90 }, { "Zelenjava", 0.75 }, { "Ajvar", 0.45 }, { "Paradižnik", 0.85 },
            { "Artičoke", 1.30 }, { "Mozzarella", 1.60 }, { "Pikantna omaka", 1.10 }, { "Hrenovke", 1.15 },
            { "Morski sadeži", 2.20 }, { "Feferoni", 1.60 }, { "Tatarska omaka", 1.35 }, { "Tuna", 2 },
            { "Beluši", 1.45 }, { "Olive", 1 }, { "Pršut", 2.8 }, { "Domača salama", 2.6 },
            { "Slanina", 2.1 }, { "Koruza", 1.25 }, { "Kisla smetana", 0.95 }, { "Sardele", 1.95 },
            { "Hren", 0.65 }, { "Brez dodatkov", 0 }
        };

        Dictionary<int, string> drinkMenu = new()
        {
            { 1, "Sok" }, { 2, "Voda" }, { 3, "Gazirana voda" }, { 4, "Voda z okusom" },
            { 5, "Čaj" }, { 6, "Kava" }, { 7, "Brezalkoholno pivo" }, { 8, "Radler" },
            { 9, "Laško" }, { 10, "Union" }, { 11, "Heineken" }, { 12, "Guinness" },
            { 13, "Borovničevec" }, { 14, "Whisky" }, { 15, "Viljamovka" }, { 16, "Jägermeister" },
            { 17, "Rum" }, { 18, "Belo vino" }, { 19, "Rdeče vino" }, { 20, "Rum-cola" },
            { 21, "Bambus" }, { 22, "Špricer" }, { 23, "Nič, hvala" }
        };

        Dictionary<string, double> drinkPrices = new()
        {
            { "Sok", 0.8 }, { "Voda", 1.2 }, { "Gazirana voda", 1.3 }, { "Voda z okusom", 1.4 },
            { "Čaj", 1.2 }, { "Kava", 1.2 }, { "Brezalkoholno pivo", 1.8 }, { "Radler", 1.9 },
            { "Laško", 2.4 }, { "Union", 2.4 }, { "Heineken", 2.6 }, { "Guinness", 3.5 },
            { "Borovničevec", 3.2 }, { "Whisky", 3.8 }, { "Viljamovka", 3.3 }, { "Jägermeister", 3.4 },
            { "Rum", 3 }, { "Belo vino", 1.5 }, { "Rdeče vino", 1.6 }, { "Rum-cola", 2 },
            { "Bambus", 2.2 }, { "Špricer", 1.5 }, { "Nič, hvala", 0 }
        };

        string selectedPizza = GetSelection("Izberite pico:", pizzaMenu);
        double pizzaPrice = pizzaPrices[selectedPizza];

        string selectedTopping = GetSelection("Izberite dodatek:", dodatkiMenu);
        double toppingPrice = dodatkiPrices[selectedTopping];

        string selectedDrink = GetSelection("Izberite pijačo:", drinkMenu);
        double drinkPrice = drinkPrices[selectedDrink];

        // Add VAT and calculate final price
        decimal ddvHrana = 9.5m / 100;
        decimal ddvPijaca = 22m / 100;

        decimal cenaHrana = (decimal)(pizzaPrice + toppingPrice);
        decimal cenaPijace = (decimal)drinkPrice;
        decimal ddvHranaAmount = cenaHrana * ddvHrana;
        decimal ddvPijacaAmount = cenaPijace * ddvPijaca;

        decimal totalPrice = cenaHrana + ddvHranaAmount + cenaPijace + ddvPijacaAmount;
        totalPrice = Math.Round(totalPrice, 2);

        Console.WriteLine($"\nCena z DDV znaša {totalPrice} EUR.");
    }

    static string GetSelection(string prompt, Dictionary<int, string> menu)
    {
        Console.WriteLine(prompt);
        foreach (var item in menu) Console.WriteLine($"{item.Key} - {item.Value}");

        string? selection;
        int userChoice;

        while (true)
        {
            string input = Console.ReadLine() ?? "";

            if (int.TryParse(input, out userChoice) && menu.TryGetValue(userChoice, out selection))
            {
                return selection;
            }
            else
            {
                Console.WriteLine("Neveljavna izbira, poskusite znova.");
            }
        }
    }
}
