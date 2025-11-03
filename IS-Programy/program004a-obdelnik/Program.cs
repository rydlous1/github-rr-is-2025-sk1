string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("Program 004a - Obdélník");
    Console.WriteLine("****************************");
    Console.WriteLine("*** Rudolf Rýdl ***");
    Console.WriteLine();

    // Načtení šířky (strany a)
    Console.Write("Zadejte délku strany a (šířku): ");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
    {
        Console.Write("Zadejte prosím kladné celé číslo pro šířku: ");
    }

    // Načtení výšky (strany b)
    Console.Write("Zadejte délku strany b (výšku): ");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
    {
        Console.Write("Zadejte prosím kladné celé číslo pro výšku: ");
    }

    Console.WriteLine();
    Console.WriteLine("Vykreslený obdélník:\n");

    // Vykreslení obdélníku pomocí dvojitého cyklu
    for (int i = 0; i < b; i++)  // výška
    {
        for (int j = 0; j < a; j++)  // šířka
        {
            Console.Write("*");
        }
        Console.WriteLine(); // nový řádek po každém řádku obdélníku
    }

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu 'a'.");
    Console.WriteLine("Pro ukončení stiskněte libovolnou jinou klávesu.");
    again = Console.ReadLine()!;
}

Console.WriteLine("Program ukončen. Děkujeme!");
