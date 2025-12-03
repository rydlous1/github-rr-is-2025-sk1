
//Hlavní Program - Začátek//

string again = "a";
while (again == "a")
{
    Console.Clear();

//metoda pro razítko - hlavičku//
    razitko();

//načítání hodnot//
ulong a = nactiCislo("Zadejte číslo a");
ulong b = nactiCislo("Zadejte číslo b");



    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a.");
    again = Console.ReadLine();

//Hlavní program - Konec

//nevrací hodnotu//
static void razitko() 
{
    Console.WriteLine("****************************");
    Console.WriteLine("**** Výpočet NSD a NSN *****");
    Console.WriteLine("****************************");
    Console.WriteLine("******* Rudolf Rýdl ********");
    Console.WriteLine("****************************");
    Console.WriteLine();

}



}

//metoda pro načtení//
static ulong nactiCislo(string zprava) {
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu: ");
    }

//metoda která vrací konkrétní datový typ//
return cislo;



}
