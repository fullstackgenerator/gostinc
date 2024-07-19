using System;
using System.ComponentModel.Design;

Console.WriteLine("Naš meni vsebuje:" +
    "\n 1 - Margarita" +
    "\n 2 - Klasika" +
    "\n 3 - Morska" +
    "\n 4 - Kmečka" +
    "\n 5 - Kraška" +
    "\n 6 - Vegi" +
    "\n 7 - Pikantna" +
    "\n 8 - Tuna" +
    "\n\n Katero želite?");

while (int.TryParse(Console.ReadLine(), out int picaNumber) && picaNumber >= 1 && picaNumber <= 8)
{
    string pica = picaNumber switch
    {
        1 => "Margarita",
        2 => "Klasika",
        3 => "Morska",
        4 => "Kmečka",
        5 => "Kraška",
        6 => "Vegi",
        7 => "Pikantna",
        8 => "Tuna",
        _ => "Drugih nimamo."
    };

    int cenaPica = pica switch
    {
        "Margarita" => 8,
        "Klasika" => 10,
        "Morska" => 14,
        "Kmečka" => 10,
        "Kraška" => 15,
        "Vegi" => 11,
        "Pikantna" => 14,
        "Tuna" => 16,
        _ => 0
    };

    Console.WriteLine("Poleg samih pic imamo tudi sledeče dodatke:" +
            "\n 1 - Jajce" +
            "\n 2 - Gobe" +
            "\n 3 - Testo z drožmi" +
            "\n 4 - Polnjen rob s sirom" +
            "\n 5 - Čebula" +
            "\n 6 - Zelenjava" +
            "\n 7 - Ajvar" +
            "\n 8 - Paradižnik" +
            "\n 9 - Artičoke" +
            "\n 10 - Mozzarella" +
            "\n 11 - Pikantna omaka" +
            "\n 12 - Hrenovke" +
            "\n 13 - Morski sadeži" +
            "\n 14 - Feferoni" +
            "\n 15 - Tatarska omaka" +
            "\n 16 - Tuna" +
            "\n 17 - Beluši" +
            "\n 18 - Olive" +
            "\n 19 - Pršut" +
            "\n 20 - Domača salama" +
            "\n 21 - Slanina" +
            "\n 22 - Koruza" +
            "\n 23 - Kisla smetana" +
            "\n 24 - Sardele" +
            "\n 25 - Hren" +
            "\n 26 - Brez dodatkom prosim." +
            "\n\n Želite še kaj od tega?");


    while (int.TryParse(Console.ReadLine(), out int dodatekNumber) && dodatekNumber >= 1 && dodatekNumber <= 26)
    {
        string dodatek = dodatekNumber switch
        {
            1 => "Jajce",
            2 => "Gobe",
            3 => "Testo z drožmi",
            4 => "Polnjen rob s sirom",
            5 => "Čebula",
            6 => "Zelenjava",
            7 => "Ajvar",
            8 => "Paradižnik",
            9 => "Artičoke",
            10 => "Mozzarella",
            11 => "Pikantna omaka",
            12 => "Hrenovke",
            13 => "Morski sadeži",
            14 => "Feferoni",
            15 => "Tatarska omaka",
            16 => "Tuna",
            17 => "Beluši",
            18 => "Olive",
            19 => "Pršut",
            20 => "Domača salama",
            21 => "Slanina",
            22 => "Koruza",
            23 => "Kisla smetana",
            24 => "Sardele",
            25 => "Hren",
            26 => "Brez dodatkov prosim.",
            _ => "Drugih dodatkom nimamo",
        };

        double cenaDodatek = dodatek switch
        {
            "Nič" => 0,
            "Jajce" => 1,
            "Gobe" => 1.2,
            "Testo z drožmi" => 1.5,
            "Polnjen rob s sirom" => 0.80,
            "Čebula" => 0.90,
            "Zelenjava" => 0.75,
            "Ajvar" => 0.45,
            "Paradižnik" => 0.85,
            "Artičoke" => 1.30,
            "Mozzarella" => 1.60,
            "Pikantna omaka" => 1.10,
            "Hrenovke" => 1.15,
            "Morski sadeži" => 2.20,
            "Feferoni" => 1.60,
            "Tatarska omaka" => 1.35,
            "Tuna" => 2,
            "Beluši" => 1.45,
            "Olive" => 1,
            "Pršut" => 2.8,
            "Domača salama" => 2.6,
            "Slanina" => 2.1,
            "Koruza" => 1.25,
            "Kisla smetana" => 0.95,
            "Sardele" => 1.95,
            "Hren" => 0.65,
            _ => 0
        };

        Console.WriteLine("Kaj vam prinesem za popiti?" +
        "\n 1 - Sok" +
        "\n 2 - Vodo" +
        "\n 3 - Gazirana voda" +
        "\n 4 - Voda z okusom" +
        "\n 5 - Čaj" +
        "\n 6 - Kava" +
        "\n 7 - Brezalkoholno pivo" +
        "\n 8 - Radler" +
        "\n 9 - Laško" +
        "\n 10 - Union" +
        "\n 11 - Heiniken" +
        "\n 12 - Guiness" +
        "\n 13 - Borovničevec" +
        "\n 14 - Whisky" +
        "\n 15 - Viljamovka" +
        "\n 16 - Jägermeister" +
        "\n 17 - Rum" +
        "\n 18 - Belo vino" +
        "\n 19 - Rdeče vino" +
        "\n 20 - Rum-colo" +
        "\n 21 - Bambus" +
        "\n 22 - Špricer" +
        "\n 23 - Nič, hvala");

        while (int.TryParse(Console.ReadLine(), out int pijacaNumber) && pijacaNumber >= 1 && pijacaNumber <= 23)
        {
            string pijaca = pijacaNumber switch
            {
                1 => "Sok",
                2 => "Vodo",
                3 => "Gazirana voda",
                4 => "Voda z okusom",
                5 => "Čaj",
                6 => "Kava",
                7 => "Brezalkoholno pivo",
                8 => "Radler",
                9 => "Laško",
                10 => "Union",
                11 => "Heiniken",
                12 => "Guiness",
                13 => "Borovničevec",
                14 => "Whisky",
                15 => "Viljamovka",
                16 => "Jägermeister",
                17 => "Rum",
                18 => "Belo vino",
                19 => "Rdeče vino",
                20 => "Rum-colo",
                21 => "Bambus",
                22 => "Špricer",
                23 => "Nič, hvala.",
            };

            double cenaPijaca = pijaca switch
            {
                "Sok" => 0.8,
                "Vodo" => 1.2,
                "Gazirana voda" => 1.3,
                "Voda z okusom" => 1.4,
                "Čaj" => 1.2,
                "Kava" => 1.2,
                "Brezalkoholno pivo" => 1.8,
                "Radler" => 1.9,
                "Laško" => 2.4,
                "Union" => 2.4,
                "Heiniken" => 2.6,
                "Guiness" => 3.5,
                "Borovničevec" => 3.2,
                "Whisky" => 3.8,
                "Viljamovka" => 3.3,
                "Jägermeister" => 3.4,
                "Rum" => 3,
                "Belo vino" => 1.5,
                "Rdeče vino" => 1.6,
                "Rum-colo" => 2,
                "Bambus" => 2.2,
                "Špricer" => 1.5,
                _ => 0,
            };

            decimal ddvHrana = 9.5m / 100;
            decimal ddvPijaca = 22m / 100;

            decimal cenaHranaDecimal = (decimal)cenaPica + (decimal)cenaDodatek;
            decimal cenaPijaceDecimal = (decimal)cenaPijaca;
            decimal ddvHranaDecimal = cenaHranaDecimal * ddvHrana;
            decimal ddvPijacaDecimal = cenaPijaceDecimal * ddvPijaca;

            decimal cenaSkupaj = cenaHranaDecimal * ddvHranaDecimal + cenaPijaceDecimal * ddvPijacaDecimal;

            cenaSkupaj = Math.Round(cenaSkupaj, 2);

            Console.WriteLine($"Cena za izbrano jed, skupaj s pijačo in ddv znaša {cenaSkupaj} eur.");
        };
    };
};