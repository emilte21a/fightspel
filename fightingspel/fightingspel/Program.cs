

static void startvar()
{
    string p1 = "";
    int spel2 = 0;
    string p22 = "";
    int aktivspelare = 0;
    int hp1 = 100;
    int hp2 = 100;
    string foremal = "";
    int fmal = 0;

    Console.WriteLine("Välj ditt namn");
    p1 = Console.ReadLine();
    

    Console.Clear();
    Console.WriteLine("Du kommer att få en slumpmässig motståndare!");

    fight(hp1, hp2, aktivspelare, p1, spel2, p22, foremal, fmal);
}

static void fight(int hp1, int hp2, int aktivspelare, string p1, int spel2, string p22, string foremal, int fmal)
{
    
    Random p2 = new Random();
    spel2 = p2.Next(1, 4);

    if (spel2 == 1)
    {
        p22 = "Pappa";


    }
    if (spel2 == 2)
    {
        p22 = "Mamma";

    }

    if (spel2 == 3)
    {
        p22 = "Bruce lee";

    }

    Console.WriteLine("Du kom precis hem inför dörren, men något känns fel. Hallen luktar annorlunda och du ser smutsiga spår till ditt sovrum. När du kommer dit så ser du någon där i mörkret.");
    Console.WriteLine($"Där i mörkret stod {p22}!");
    Console.WriteLine("De har intagit en kamphållning och kommer emot dig snabbt! Du vet inte vem som lyckas landa slaget först.");
    Console.WriteLine("Tryck ENTER för att se!");
    Console.ReadLine();
    Console.Clear();

    Random aspel = new Random();
    aktivspelare = aspel.Next(1, 3);

    int v = 1;
    int dmg = 0;
    Random gen = new Random();
    while (v == 1)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{p1}:{hp1}      {p22}:{hp2}");
        Console.ForegroundColor = ConsoleColor.White;

    if (aktivspelare == 1)
    {
        //Accepterade svar på attack
        string [] attack = {"a", "b", "c"};

        
        //Du får välja en utav tre attacker
        Console.WriteLine($"Du närmar dig och har nu valet till hur du ska skada {p22}!");
        Console.WriteLine("");
        Console.WriteLine($"Ska du slå, sparka eller använda närmsta föremål för att slå {p22}?");
        Console.WriteLine("[A]: Slag (17-35 skada");
        Console.WriteLine("[B]: Spark (7-50 skada");
        Console.WriteLine("[C]: Närmsta slumpmässiga föremål (1-100 skada)");
        Console.WriteLine("");
        
        if (hp1 <= 0)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{p1}:0      {p22}:{hp2}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{p22} däckade dig!");
            break;
        }  

        //Koden ser till så att du ger ett giltigt svar
        Console.WriteLine("Skriv in ditt svar [A], [B] eller [C]: ");
        string slag = Console.ReadLine().ToLower();
        while (attack.Contains(slag) == false)
        {
            Console.WriteLine("Välj svaren [A], [B] eller [C]");
            slag = Console.ReadLine().ToLower();

        }

        

        //En switch som låter dig skriva ett av tre alternativ. Slå, Sparka eller slå med ett slumpmässigt föremål
        switch (slag)
        { //switch för slag

        

        
        

        //Första fallet då man slår sin motståndare
        case "a":
            dmg = gen.Next(17, 36);

            if (dmg < 28)
            {
                Console.WriteLine($"Du slog {p22} och skadade de med {dmg} skada!");
                hp2 = hp2 - dmg;
                Console.WriteLine("Tryck ENTER för att fortsätta slåss!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine($"Du skadade {p22} med en crit på {dmg} skada!");
                hp2 = hp2 - dmg;

                Console.WriteLine("Tryck ENTER för att fortsätta slåss!");
                Console.ReadLine();
            }
                aktivspelare = 2;
                Console.Clear();
                break;
        
        //Andra fallet då man sparkar motståndaren
        case "b":
                    
            dmg = gen.Next(7, 51);

            if (dmg < 38)
            {
                Console.WriteLine($"Du slog {p22} och skadade de med {dmg} skada!");
                hp2 = hp2 - dmg;

                Console.WriteLine("Tryck ENTER för att fortsätta slåss!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine($"Du skadade {p22} med en crit på {dmg} skada!");
                hp2 = hp2 - dmg;

                Console.WriteLine("Tryck ENTER för att fortsätta slåss!");
                Console.ReadLine();
            }
                aktivspelare = 2;
                Console.Clear();
                break;
        

        //tredje fallet där man får ett av tre slumpmässiga föremål.
        case "c":
            
            fmal = p2.Next(1, 4);

            switch(fmal)
            { //Switch
            case 1:  
                foremal = "lykta";
                dmg = gen.Next(25, 40);
                break;
    
            case 2:
                foremal = "kruka";
                dmg = gen.Next(10, 25);
                break;
                            
            case 3:
                foremal = "stol";
                dmg = gen.Next(50, 70);
                break;
            }//Switch
        


            Console.WriteLine($"Du tog ett slumpmässigt föremål. Det blev en {foremal}");
            Console.WriteLine("");

            if (dmg < 50)
            {
                Console.WriteLine($"Du slog {p22} med en {foremal} och skadade de med {dmg} skada!");
                hp2 = hp2 - dmg;

                Console.WriteLine("Skriv ENTER för att fortsätta slåss!");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine($"Du skadade {p22} med en {foremal} med en crit på {dmg} skada!");
                hp2 = hp2 - dmg;

                Console.WriteLine("Skriv ENTER för att fortsätta slåss!");
                Console.ReadLine();
            }
            aktivspelare = 2;
            Console.Clear();
        
        break;

        }
        }//Switch för slag  
               
        else
        {

            if (hp2 <= 0)
            {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{p1}:{hp1}      {p22}:0");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Du vann!");
            
            break;
            }
        
            Console.WriteLine($"{p22} steg hastigt fram och kommer att slå dig nu.");
            dmg = gen.Next(1, 61);


            if (dmg < 40)
            {
                Console.WriteLine($"{p22} skadade dig med {dmg} skada!");
                hp1 = hp1 - dmg;

                Console.WriteLine("Skriv ENTER för att fortsätta slåss!");
                Console.ReadLine();
                aktivspelare = 1;
                Console.Clear();
            }

            else
            {
                Console.WriteLine($"{p22} skadade dig med en crit på {dmg} skada!");
                hp1 = hp1 - dmg;

                Console.WriteLine("Skriv ENTER för att fortsätta slåss!");
                Console.ReadLine();
                aktivspelare = 1;
                Console.Clear();
            }
        

        }
    }


}

Console.WriteLine("Hej och välkommen till 'någon är i huset'");
Console.WriteLine("Är du redo att starta?");

string start = Console.ReadLine().ToLower();
while (start != "ja" && start != "nej")
{
    Console.WriteLine("Du måste skriva ja eller nej");
    start = Console.ReadLine().ToLower();
}

while (start == "ja")
{
    startvar();
    Console.ReadLine();


    Console.WriteLine("Vill du spela igen? Ja eller Nej");
    start = Console.ReadLine().ToLower();
    while (start != "ja" && start != "nej")
    {
        Console.WriteLine("Du måste skriva ja eller nej");
        start = Console.ReadLine().ToLower();
    }
}

if (start == "nej")
{
    Console.WriteLine("Okej..hejdå");
}


Console.ReadLine();
