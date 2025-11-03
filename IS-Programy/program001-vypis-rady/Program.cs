string again = "a";
while (again == "a") 
{
    Console.Clear();
    Console.WriteLine("**");
    Console.WriteLine(" Název programu ");
    Console.WriteLine("**");
    Console.WriteLine("*** Rudolf Rýdl **");
    Console.WriteLine("**");
    Console.WriteLine();

    // Vstup hodnoty do programu - špatně řešený
    //Console.Write("Zadejte první číslo řady: ");
    //int first = int.Parse(Console.ReadLine());

    //Vstup hodnoty do programu - řešený správně
    Console.Write("Zadejte hodnotu (celé číslo): ");
    int first;

    while (!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }

    // Načtení poslední hodnoty
    Console.WriteLine("Zadejte poslední číslo řady");
    int last;
    while (!int.TryParse(Console.ReadLine(), out last))
    {
        Console.WriteLine("Nezadali jste celé číslo. Zadejte hodnotu znovu: ");
    }
    
    // Načtení kroku
    Console.Write("Zadejte krok (rozdíl mezi čísly): ");
    int step;
    while (!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Krok musí být celé číslo větší než 0. Zadejte znovu: ");
    }
    Console.WriteLine();
        Console.WriteLine("Výpis řady");
        
       
        // Výpis číselné řady
    if (first <= last)
    {
        for (int i = first; i <= last; i += step)
        {
        Console.WriteLine(i);
        }
    }
    else
    {
        for (int i = first; i >= last; i -= step)
{
Console.WriteLine(i);
}
}
Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
Console.WriteLine("Pro ukončení stiskněte libovolnou jinou klávesu.");
again = Console.ReadLine();
}
Console.WriteLine("Program ukončen. Děkujeme!");