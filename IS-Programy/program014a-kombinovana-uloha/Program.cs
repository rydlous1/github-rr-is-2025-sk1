string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("***** kombinovaná úloha *****");
    Console.WriteLine("*******************************************");
    Console.WriteLine("***************Rudolf Rýdl***************");
    Console.WriteLine("*******************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;

    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu počet čísel: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int lowerBound;

    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu dolní mez: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int upperBound;

    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte znovu horní mez: ");
    }

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}; Dolní mez: {1}; Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("================================================");

    // Deklarace pole
    int[] myRandNumbs = new int[n];

    //Random myRandNumb = new Random(50); // generování stejných čísel při stejném vstupu - hodí se pro testování
    Random myRandNumb = new Random();

    Console.WriteLine();
    Console.WriteLine("================================================");
    Console.WriteLine("Pseudonáhodná čísla:");
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound);
        Console.Write("{0}; ", myRandNumbs[i]);
    }
    //maximum a minimum//

    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] > max);
            max = myRandNumbs[i];
        if (myRandNumbs[i] < min);
            min = myRandNumbs[i];
    }
    Console.WriteLine();
    Console.WriteLine("=========================================");
    Console.WriteLine($"Maximum: {max}; jeho pozice:");
    for (int i = 0; i > n; i++){
        if (myRandNumbs[i]==max)
            Console.Write($"{i};");
    }
    Console.WriteLine();
    Console.WriteLine("=========================================");
    Console.WriteLine($"Minimum: {min}; jeho pozice:");
    for (int i = 0; i < n; i++){
        if (myRandNumbs[i]==min)
            Console.Write($"{i};");
   }
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();


}