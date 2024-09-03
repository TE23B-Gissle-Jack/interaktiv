using System.Dynamic;
using System.Runtime.Versioning;


int hogerAmt = 0;
string facklan = "";
bool fackla = false;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Du står i mitten av en labyrint. Det finns 3 vägar du kan ta, Höger, Vänster och framåt. Vilken Väg tar du?");

firstChoice();

 void firstChoice()
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    string val = Console.ReadLine();  
    val = val.ToLower();
    Console.ForegroundColor = ConsoleColor.Cyan;
    if(val == "höger"){
    Console.WriteLine("Du går höger. du kommer till ytligare en korsning, på en av väggarna sitter en fackla. Du kan ta facklan,gå höger eller\ngå vänster");
    hoger();
}
else if(val == "vänster"){
    Console.WriteLine($"Du går vänster. du kommer fram till ett skelett, framför dig fortsätter gången. Du kan Inspektera skelettet eller fortsätta gå");
    venster();
}
else if(val == "framåt"){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Clear();
    Console.WriteLine($"\n\n\n\n\n\n\n\n\ndu går framåt men efter bara ett par steg så skjuter spjut ut ur väggen och dödar dig");
    Console.ReadLine();
}
else if(val== "bakåt"|| val == "bak")
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n                                                           FUCK YOU!");
    Console.ReadLine();
}
else{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Skriv antingen, 'Framåt', 'Höger' eller 'Vänster' för att välja en väg");
    firstChoice();
    }
}

void venster(){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    string val = Console.ReadLine();
    val = val.ToLower();
    Console.ForegroundColor = ConsoleColor.Cyan;
    if(val == "inspectera skelettet"||val=="inspectera"||val=="skelett"){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Du väljer att inspektera skelettet. Du sätter dig på huk och söker igenom skelettets kländer, medan du gör det rör skelettet plötsligt på sig och biter ner i din nacke. Du blöder till döts.");
        Console.ReadLine();
    }
    else if(val == "fortsätt"|| val =="framåt"){
        Console.WriteLine($"Du fortsätter längs gången. Du kommer till sist till ett rum. Rummet har ett hål i sig med ett rep, hålet går igenom taket och golvet. Klättrar du upp för repet eller ner?");
        fram();
    }
    else{
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Skriv antingen, 'Framåt' eller 'inspectera' för att välja");
        venster();
    }

    void fram(){
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string val = Console.ReadLine();
        val = val.ToLower();
        Console.ForegroundColor = ConsoleColor.Red;
        if(val =="up"){
            Console.Clear();
            Console.WriteLine($"\n\n\n\n\n\n\n\n\nDu klättrar upp för repet. Du börjar klättra upp för repet men just som det ser ut som du nått slutet av det så lossnar det och du faller till din död.");
            Console.ReadLine();
        }
        else if(val == "ner"){
            Console.Clear();
            Console.WriteLine($"\n\n\n\n\n\n\n\n\nDu klättrar ner för repet. Efter att ha klättrat i timmar och utan styrkan att klättra längre släpper du taget. Du faller till din död");
            Console.ReadLine();
        }
        else{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Skriv antingen, 'ner' eller 'upp' för att välja");
            fram();
        }
    }
}

 void hoger(){
     Console.ForegroundColor = ConsoleColor.DarkYellow;
     string val = Console.ReadLine(); 
     val = val.ToLower();
     Console.ForegroundColor = ConsoleColor.Cyan;
     if(val == "ta facklan"){
        Fakla();
        hoger();
     }
     else if(val == "höger"){
        string tecx = "Du tar den högra vägen. Du kommer till en mörk kosrning. Du kan se en väg åt vänster och en framåt.";
        Console.WriteLine(tecx + facklan);
        hoger2();
     }
     else if(val == "vänster"){
         string imse = "Du går gången till vänster och kommer till ett stort rum fullt av spindelnät";
        if(fackla == true){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n{imse} Du håller din fackla högt för att se allt\nspindelnät och råkar sätta eld på det. Du hör ett otäckt läte högt uppe i nätet och en gigantisk spindel faller ner och mossar dig. Du är död");
        }else{
            Console.WriteLine($"{imse} Du navigerar dig genom rummet utan att röra nätet. Du kommer till två vägar, en som går nedåt och en uppåt. Vilken väljer du?");
        }
        venster();
     }
     else{
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Skriv antingen, 'ta facklan', 'Höger' eller 'Vänster' för att välja");
        hoger();
    }
      void Fakla(){
        facklan = " Med facklan kan du\nockså se en vägg åt höger";
        fackla = true;
        Console.WriteLine($"Du tar Facklan. Går du nu Höger eller Vänster?");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
     }

      void hoger2(){
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string val = Console.ReadLine();
        val = val.ToLower();
        Console.ForegroundColor = ConsoleColor.Cyan;
        if(val == "framåt"){
            Console.WriteLine($"Du tar vägen rakt fram. Efter bara ett par meter slutar gången i ett stup. Du återvänder till föregående korsning.");
            hoger2();
        }
        else if(val == "vänster"){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine($"\n\n\n\n\n\n\n\n\nDu tar en vänstra vägen. Direkt efter du går in i gången så rasar den bakom dig. Efter att du har gått en stund upptäcker du att det är en återvändsgränd. Du dör pga brist av vatten.");
            Console.ReadLine();
        }
        else if(val == "höger"){
            Console.WriteLine($"Du tar den högra vägen. Du kommer till en korsning med vägar åt höger eller vänster");
            hoger3();
        }
        else{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Skriv antingen, 'framåt', 'Höger' eller 'Vänster' för att välja");
            hoger2();
        }
        void hoger3(){
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string val = Console.ReadLine(); 
            val = val.ToLower();
            Console.ForegroundColor = ConsoleColor.Cyan;
            if(val == "väsnster"){
                venster();
            }
            else if(val == "höger"){
                if(hogerAmt < 5){
                    hogerAmt++;
                    Console.WriteLine($"Du tar den högra vägen. Du kommer till en korsning med vägar åt höger eller vänster");
                    hoger3();
                    Console.ReadLine();
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Right is always Right. Du har vunnit! Labyrinten gav upp!");
                }
            }
            else{
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Skriv antingen,'Höger' eller 'Vänster' för att välja");
                    hoger3();
            }
        }
     }

     void venster(){
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string val = Console.ReadLine();
        val = val.ToLower();
        Console.ForegroundColor = ConsoleColor.Cyan;

        if(val == "ner"|| val == "nedåt"){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n\n\n\n\n\n\n\n\nDu väljer vägen nedåt. Vägen blir brantare och brantare. Du snubblar och lyckas inte stanna tills du kommer till slutet av gången och slår i huvudet och bryter nacken. Du är Död.");
        }
        else if(val == "up"|| val =="uppåt"){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Du tar vägen uppåt. Du går i vad som känns som en oändlighet men tillsist kommer du till ytan. Du har lyckats fly\nlabyrinten!");
        }else{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Skriv antingen, 'up' eller 'ner' för att välja");
            venster();
        }
        Console.ReadLine();
     }
}
