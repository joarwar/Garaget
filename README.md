# Garaget
Group Project Garage

Projektuppgift - Garageapplikation
Status: Ej inlämnad
Din identitet är synlig under rättning.

Sista tidpunkt för inlämning: 18 okt 2021 23:55, 6 dagar kvar
Projektet - Garageapplikation

För att koppla samman mycket av det ni lärt er, så skall vi nu bygga en garageapplikation.
Denna applikation skall tillhandahålla den funktionalitet som ett system kan behöva om det skall användas för att simulera ett enkelt garage.

Det skall alltså gå att:
- parkera fordon

- hämta ut fordon

- se efter vilka fordon som finns där och vilka egenskaper de har.

Allt detta i en konsolapplikation med huvudmeny och undermenyer.

Anledningen till att ni skall programmera ett garage är att det är enkelt att förankra uppdelningen i det hela. Vi kan huvudsakligen dela upp ett garage i följandedelar:

Garaget:​ En representation av själva byggnaden inte helheten. Garaget är en plats där en mängd av fordon kan förvaras. Garaget kan alltså representeras som en samling av fordon.

Fordon:​ Bilar, motorcyklar, enhjulingar eller vad för typ av fordon man nu vill ställa in i garaget. 

Detta är de två delar som man ser i ett fysiskt garage. Men ska vi kolla närmare bör det också finnas ärvande subklasser till fordon, alltså att varje fordonstyp är en egen subklass som ärver från Vehicle i systemet. Utöver det behövs det funktionalitet som hanterar att fordon ställs i garaget, att fordon kan tas ut ur garaget samt att vi kan få en presentation av vad som finns i garaget och söka i det.

I mer programmeringsvänliga termer skall vi alltså ha:

En lista​ ​av fordon; klassen ​Garage.​

En fordonsklass

Ett antal subklasser till fordon som ärver egenskaper.

Ett UI (User Interface)) som låter oss använda funktionaliteten hos garaget

Extrauppgifter

BONUS:  

Det går även att abstrahera en övergripande nivå så att det inte finns någon direkt kontakt mellan UI:t och garageklassen. Alltså att ni skapar ännu en klass som hanterar funktionaliteten som UI:t enbart kallar och passar information till.

BONUS:  

Det går att via C# skriva och läsa andra filer i filsystemet från er applikation. Ta reda på hur man gör det här för att kunna spara ert garage (via meny eller automatiskt vid avstängning) och ladda ert garage (via meny eller automatiskt vid start av applikationen)

Kravspecifikation
En generisk samling av fordon:
Class Garage<T> where T: Vehicle

Möjlighet att ​foreach-​loopa på garaget. Alltså att ​Garage implementerar​ interfacet ​IEnumerable ​(​Garage skall inte ärva från någon annan ​            klass​ ​, eller implementera något annat interface ​ ​än ​IEnumerable)
  ○ Det ska finnas en funktion ListVehicles som listar samtliga fordon i garaget
  ○ Det ska finnas en funktion ListTypeOfVehicles som listar samtliga olika typer av fordon i garaget och hur många av dessa som står i garaget
  ○ Det ska finnas en funktion AddVehicle som lägger till ett fordon ur garaget
  ○ Det ska finnas en funktion RemoveVehicle som tar bort fordon ur garaget
  ○ Ha en max-gräns som krävs som inparameter vid instansieringen av ett nytt garage
  ○ Det ska finnas en funktion SearchVehicle som söker efter ett specifikt fordon via REG-NR och skriver ut det om det finns, annars inte.
  ○ Möjlighet att söka efter ett flertal fordon på ett flertal valfria variabler.

Olika fordon, Klassen Vehicle ​och dess ​ärvande subklasser​

  ○ Vehicle innehåller samtliga variabler som ska finnas i samtliga​ fordonstyper. EX. REG-NR, Färg, Antal hjul. Och andra variabler ni kan komma på.

Det måste minst finnas följande subklasser:

  ■Bicycle
  ■Motorcycle
  ■Car
  ■Bus
  ■Truck

  ○ Dessa skall innehålla minst två egna attribut​

Ett textbaserat UI ​​för en konsolapplikation​
Det skall gå att navigera till SAMTLIG funktionalitet från garage via UI🥇
  ○ Det skall gå att SKAPA ett Garage i UI:t.
  ○ Det skall gå att stänga av applikationen från UI:t

Tips:

Huvudmenyn får gärna se ut så här:

Console.WriteLine("Find a vehicle in the garage by adding a parameter." 
                         + "\n1. To find with a registration number." 
                         + "\n2. To find all with colour." 
                         + "\n3. To find all with a specified number of wheels." 
                         + "\n4. To find all with a minimum number of passengers." 
                         + "\n5. To find all with cabriolet" 
                         + "\n0. Exit the finding!");

string input = Console.ReadLine();

\n står för radbrytning (Texten efteråt kommer på nästa rad)

ReadLine läser in en textsträng I detta fall inmatas en siffra men den sparas som en sträng.

Denna meny ska upprepas ett antal gånger, men vi vet inte hur många gånger, så därför är en do while-slinga att föredra framför en for-slinga.

Om er applikation kraschar så kan ni på lämplig plats initiera några fordon som ni inte behöver mata in varje gång som programmet startar.

            // Initialization of some vehicles to play around with. 

            Car volvoS90 = new Car("ABC 123"....); 
            garage.AddVehicle(volvoS90); 
            Car nevs = new Car("ABD 123".....); 
            garage. AddVehicle (nevs); 
            MotorCycle yamaha = new MotorCycle("ABC 124"....); 
            garage. AddVehicle (yamaha); 
            Bus bus54 = new Bus("YXZ 987".....); 
            garage. AddVehicle (bus54); 
            Bus bus4 = new Bus("NKL 123".....); 
            garage. AddVehicle (bus4); 

En bra idé är att när man letar reda på ett fordon är att göra jämförelsen efter att ha gjort om gemena bokstäver till versaler. Det skulle kunna göras så här:

if (item != null && item.Regnr.ToUpper() == findRegNr.ToUpper())

    {

        match1 = true;

        Console.WriteLine("The vehicle was found :");

        Console.WriteLine(item.ToString());

    }
