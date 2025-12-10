
//Hlavní Program - Začátek//

string again = "a";
while (again == "a")
{
    Console.Clear();

//metoda pro razítko - hlavičku//
    razitko();

//načítání hodnot//
ulong a = nactiCislo("Zadejte číslo a: ");
ulong b = nactiCislo("Zadejte číslo b: ");

ulong NSD = vypocitatNSD(a, b);
ulong NSN = vypocitatNSN(a, b, NSD);

zobrazitVysledky(a,b,NSD,NSN);

    Console.WriteLine();
    Console.WriteLine("===================================");
    Console.WriteLine("NSD čísel {0} a {1} je {2}", a, b, NSD);
    Console.WriteLine("===================================");
    Console.WriteLine("NSN čísel {0} a {1} je {2}", a, b, NSN);
    Console.WriteLine();


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
static ulong nactiCislo(string zprava){
    Console.Write(zprava);
    ulong cislo;
    while (!ulong.TryParse(Console.ReadLine(), out cislo))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte hodnotu znovu: ");
    }

//metoda která vrací konkrétní datový typ//
return cislo;



}
//metoda pro výpočet NSD dvou čísel//

static ulong vypocitatNSD(ulong a, ulong b){
    while(a != b){
        if( a > b)
            a = a - b;
        else
            b = b - a;
    }
    return a;
}


static ulong vypocitatNSN(ulong a, ulong b, ulong NSD){
    return (a*b)/ NSD;
}

static void zobrazitVysledky(ulong a, ulong b, ulong NSD, ulong NSN){
    
    Console.WriteLine();
    Console.WriteLine("===================================");
    Console.WriteLine("NSD čísel {0} a {1} je {2}", a, b, NSD);
    Console.WriteLine("===================================");
    Console.WriteLine("NSN čísel {0} a {1} je {2}", a, b, NSN);
    Console.WriteLine();
}

