using System.Dynamic;
using System.Runtime.Versioning;


int fan = 0;
string faklan = "";
bool fakla = false;
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
    Console.WriteLine($"Du går höger. du kommer till ytligare en korsning, på en av väggarna sitter en fakla. Du kan ta faklan,gå höger eller   gå vänster");
    hoger();
}
else if(val == "vänster"){
    Console.WriteLine($"Du går vänster. du kommer fram till ett sklett, famför dig fortsätter gången. Du kan Inspectera sklettet eller fortsätta gå");
    venster();
}
else if(val == "framåt"){
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"du går framåt men efter bara ett par steg så skjuter spjut ut ur väggen och dödar dig");
    Console.ReadLine();
}
else{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Skriv antingen, 'Farmåt', 'Höger' eller 'Vänster' för att välja en väg");
    firstChoice();
    }
}

void venster(){
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    string val = Console.ReadLine();
    val = val.ToLower();
    Console.ForegroundColor = ConsoleColor.Cyan;
    if(val == "inspectera skelletet"||val=="inspectera"||val=="sklett"){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Du väljer att inspectera sklettet. Du sätter dig på huk och söker igenom sklettets kländer, medans du gör det rör sklettet plötsligt på sig och biter ner i din nacke. Du blöder till döts.");
        Console.ReadLine();
    }
    else if(val == "fortsätt"|| val =="framåt"){
        Console.WriteLine($"Du fortsätter längs gången. Du kommer tillsist till ett rum. Rummet har ett hål i sig med ett rep, hålet går igenom taket och golvet. Klätrar du up för repet eller ner?");
        fram();
    }
    else{
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Skriv antingen, 'Farmåt' eller 'inspectera' för att välja");
        venster();
    }

    void fram(){
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        string val = Console.ReadLine();
        val = val.ToLower();
        Console.ForegroundColor = ConsoleColor.Red;
        if(val =="up"){
            Console.WriteLine($"Du klättar up för repet. Du börjar klätra up för repet men just som det ser ut som du nåt slutet av det så losnar det och du faller till din död.");
            Console.ReadLine();
        }
        else if(val == "ner"){
            Console.WriteLine($"Du klättar ner för repet. Efter att ha klätrat i timmar och utan strykan att klätra längre släpper du taget. Du faller till din död");
            Console.ReadLine();
        }
        else{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Skriv antingen, 'ner' eller 'up' för att välja");
            fram();
        }
    }
}

 void hoger(){
     Console.ForegroundColor = ConsoleColor.DarkYellow;
     string val = Console.ReadLine(); 
     val = val.ToLower();
     Console.ForegroundColor = ConsoleColor.Cyan;
     if(val == "ta faklan"){
        Fakla();
        hoger();
     }
     else if(val == "höger"){
        string tecx = "Du tar den högra vägen. Du kommer till en mörk kosrning. Du kan se en väg åt vänster och en framåt.";
        Console.WriteLine(tecx + faklan);
        hoger2();
     }
     else if(val == "vänster"){
         string imse = "Du går gången till vänster och kommer till ett stort rum fullt av spindelnät";
        if(fakla == true){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{imse} Du håller din fakla högt för att se allt   spindelnät och råkar sätta eld på det. Du hör ett otäkt lätte högt uppe i nätet och en gigantisk spindel faller ner och mossar dig. Du är död");
        }else{
            Console.WriteLine($"{imse} Du navigerar dig genom rummet utan att röra nätet. Du kommer till två vägar, en som går nedåt och en uppåt. Vilken väljer du?");
        }
        venster();
     }
     else{
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Skriv antingen, 'ta faklan', 'Höger' eller 'Vänster' för att välja");
        hoger();
    }
      void Fakla(){
        faklan = " Med faklan kan du   också se en vägg åt höger";
        fakla = true;
        Console.WriteLine($"Du tar Faklan. Går du nu Höger eller Vänster?");
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
            Console.WriteLine($"Du tar en vänstra vägen. direkt efter du går in i gången så rasar den bakom dig. Efter att du har gåt en stund uptäker du att det är en återvänds gränd. Du dör pga brist av vatten.");
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
                if(fan < 10){
                    fan++;
                    Console.WriteLine($"Du tar den högra vägen. Du kommer till en korsning med vägar åt höger eller vänster");
                    hoger3();
                    Console.ReadLine();
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Right is always Right. Du har vunit! Labyrinten gav upp!");
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Du väljer vägen nedåt. Vägen blir brantare och brantare. Du snubblar och lyckas inte stanna tills du kommer till slutet av gången och slår i huvudet och bryter nacken. Du är Död.");
        }
        else if(val == "up"|| val =="uppåt"){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Du tar vägen uppåt. Du går i vad som känns som en oändlighet men tillsist kommer du till ytan. Du har lyckats fly       labyrinten!");
        }else{
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Skriv antingen, 'up' eller 'ner' för att välja");
            venster();
        }
        Console.ReadLine();
     }
}
