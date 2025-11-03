string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine(" Program 004b - Pravoúhlý trojúhelník");
    Console.WriteLine("****************************");
    Console.WriteLine("*** Rudolf Rýdl ***");
    Console.WriteLine();

    // Načtení vstupní hodnoty (výšky trojúhelníku)
    Console.Write("Zadejte výšku trojúhelníku (celé kladné číslo): ");
    int height;
    while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {
        Console.Write("Zadejte prosím kladné celé číslo pro výšku: ");
    }

    Console.WriteLine();
    Console.WriteLine("Vykreslený trojúhelník:\n");

    // Výpis trojúhelníku
    for (int i = 1; i <= height; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    Console.WriteLine("Pro ukončení stiskněte libovolnou jinou klávesu.");
    again = Console.ReadLine()!;
}

Console.WriteLine("Program ukončen. Děkujeme!");