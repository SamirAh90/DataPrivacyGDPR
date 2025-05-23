
/*
Detta C#-konsolprogram simulerar insamling och hantering av personlig data 

Användaren kan:

1. Lägga till en person: Inmatningar som kön, födelsedatum, ögonfärg och hårdetaljer.
2. Lista alla personer Visar all sparad persondata.
3. Avsluta: Stänger programmet.

Programmet validerar inmatningarna (t.ex. rätt datumformat, inga siffror i text) och 
använder en Person klass för att lagra informationen. 

 Comments:
        1- Single Line Comments  
        2- Multi Line Comments    
        3 - XML Comments - för method

        Developers:
        Samir Ahmad, student of the Department of Computer Science at Dalarna University.
        Ludwig Lindfors, student of the Department of Computer Science at Dalarna University.

Please read the project report for more details.

 */







namespace DataPrivacyGDPR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar en lista för att hålla alla personer
            List<Person> personList = new List<Person>();
            bool running = true; // Bool som styr while-loopen och programmet

            // Skapar en startperson.
            // Listen kommer alltid hålla denna person så det blir aldrig 0 förutom om vi inte tar bort denna person.
            Hair personHair = new Hair
            {
                HairLength = "Lång",
                HairColor = "Blond"
            };

            Person person1 = new Person(
                Gender.Kvinna,  // Startpersonen är en kvinna
                personHair,     // Hårdetaljer för startpersonen
                new DateTime(1990, 5, 15), // Födelsedatum
                "Blå"  // Ögonfärg
            );

            personList.Add(person1); // Lägger till startpersonen i listan

            // Huvudloop för programmet
            while (running)
            {
                // Rensar konsolen för att ge ett rent utseende när programmet startar
                Console.Clear();

                // Sätter textfärgen för rubriken till cyan.
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t══════════════════════════════════════════════════════════════════════════");
                Console.WriteLine("\t\t\t\t\t      Välkommen till Angelic Good Guys");
                Console.WriteLine("\t\t\t══════════════════════════════════════════════════════════════════════════\n");
                Console.ResetColor(); // Återställer textfärgen till standard efter rubriken

                // Sätter textfärgen för beskrivningen till grön.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t\t\t Detta program samlar in persondata för att bevisa olaglig datainsamling");
                Console.WriteLine("\t\t\t Datan används för att bekämpa GDPR-brott mot Evil Eavesdrop Enterprises \n");
                Console.ResetColor(); // Återställer textfärgen till standard

                // Lägger till en separator i gult för att ge menyn lite struktur.
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t\t\t══════════════════════════════════════════════════════════════════════════\n");
                Console.ResetColor(); // Återställ textfärgen till standard

                // Visar menyn och ge användaren valmöjligheter
                Console.WriteLine();
                Console.WriteLine("Vänligen välj ett av följande alternativ:");
                Console.WriteLine("1. Lägg till en ny person");
                Console.WriteLine("2. Visa alla personer i listan");
                Console.WriteLine("3. Avsluta programmet");
                Console.Write("Ange ditt val: ");


                string? choice = Console.ReadLine(); // Läser in användarens val som en sträng, kan vara null om användaren inte skriver något.

                // Hanterar användarens val med switch-sats
                switch (choice)
                {
                    case "1":
                        AddPerson(personList); // Anropar metoden för att lägga till en person
                        break;
                    case "2":
                        ListPersons(personList); // Anropar metoden för att lista alla personer
                        ListPersons(personList);
                        break;
                    case "3":
                        // Avslutar programmet
                        //Sätter textfärgen för till röd.
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nProgrammet avslutas om 2 sekunder...");
                        Thread.Sleep(2000); // Vänter för 2 sekunder 
                        running = false; // Stop the main loop
                        Console.ResetColor(); // Återställ textfärgen till standard
                        Console.Beep(); // skappar beep ljud
                        break;

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }

                // Fortsätter programmet om det inte ska avslutas
                if (running)
                {
                    Console.WriteLine("\nTryck på en tangent för att fortsätta...");
                    Console.ReadKey(); // Väntar på användarens input innan loopen fortsätter
                }
            }
        }

        /// <summary>
        /// Metod för att lägga till en person
        /// </summary>
        public static void AddPerson(List<Person> personList)
        {
            // Frågar användaren om kön och skapar en variabel för könet
            Gender gender = Gender.Kvinna;
            while (true)
            {
                Console.WriteLine("Ange kön (Kvinna, Man, IckeBinär, Annan): ");
                string? genderInput = "";


                while (true)
                {
                    genderInput = Console.ReadLine();

                    // Kontrollerar om inmatningen är tom
                    if (string.IsNullOrEmpty(genderInput))
                    {
                        Console.WriteLine("Kön kan inte vara tomt. Försök igen.");
                        continue;
                    }

                    // Kontrollerar om inmatningen innehåller siffror
                    if (genderInput.Any(char.IsDigit))
                    {
                        Console.WriteLine("Kön kan inte innehålla siffror. Försök igen.");
                        continue;
                    }

                    // Kontrollerar om inmatningen innehåller specialtecken
                    if (!genderInput.All(char.IsLetter))
                    {
                        Console.WriteLine("Kön kan endast innehålla bokstäver. Försök igen.");
                        continue;
                    }

                    try
                    {
                        // Omvandlar inmatningen till en enum av typen Gender
                        gender = (Gender)Enum.Parse(typeof(Gender), genderInput, true);

                        // Verifierar att den omvandlade enum-värdet är giltigt
                        if (!Enum.IsDefined(typeof(Gender), gender))
                        {
                            Console.WriteLine("Ogiltigt kön. Ange ett av följande alternativ: Woman, Man, Nonbinary, Other.");
                            continue;
                        }

                        break; // Om inmatningen är giltig, bryt ut ur loopen
                    }
                    catch (ArgumentException)
                    {
                        Console.WriteLine("Ogiltigt kön. Ange ett av följande alternativ: Woman, Man, Nonbinary, Other.");
                    }
                }

                // Frågar användaren om födelsedatum
                DateTime birthDate;
                while (true)
                {
                    // frågar användaren ange födelsedatum i formatet yyyy-MM-dd
                    Console.WriteLine("Ange födelsedatum (yyyy-mm-dd): ");
                    string? birthDateInput = Console.ReadLine();  // Trimmar bort extra mellanslag

                    // Kontrollera rom inmatningen är tom
                    if (string.IsNullOrEmpty(birthDateInput))
                    {
                        Console.WriteLine("Födelsedatum kan inte vara tomt. Försök igen.");
                        continue;
                    }

                    if (DateTime.TryParseExact(
                    birthDateInput,             // Användarens inmatning
                    "yyyy-MM-dd",               // Förväntat datumformat
                    null,                       // Kulturinformation (null använder den nuvarande kulturen)
                    System.Globalization.DateTimeStyles.None, // Inga ytterligare formateringsalternativ
                    out birthDate               // Utdataparameter för att lagra det analyserade datumet
                     ))

                    {
                        // Kontrollerar om datumet är i framtiden
                        if (birthDate > DateTime.Now)
                        {
                            Console.WriteLine("Födelsedatum kan inte vara i framtiden. Försök igen.");
                        }
                        // Kontrollerar om året är mindre än 1899
                        else if (birthDate.Year < 1899)
                        {
                            Console.WriteLine("Födelsedatum kan inte vara tidigare än år 1899. Försök igen.");
                        }
                        else
                        {
                            break; // Giltigt datum, bryt ur loopen
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ogiltigt datumformat. Ange datum i formatet yyyy-mm-dd.");
                    }
                }

                // Frågar användaren om ögonfärg
                string? eyeColor = "";
                while (true)
                {
                    Console.WriteLine("Ange ögonfärg (t.ex. Blå, Grön, Brun, Grå, Svart eller skriv din egen färg):");
                    eyeColor = Console.ReadLine();

                    // Kontrollerar om inmatningen är tom
                    if (string.IsNullOrEmpty(eyeColor))
                    {
                        Console.WriteLine("Ögonfärg kan inte vara tomt.");
                        continue;
                    }

                    // Kontrollerar om inmatningen innehåller siffror
                    if (eyeColor.Any(char.IsDigit))
                    {
                        Console.WriteLine("Ögonfärg kan inte innehålla siffror. Försök igen.");
                        continue;
                    }

                    // Kontrollerar om inmatningen innehåller specialtecken
                    if (!eyeColor.All(char.IsLetter))
                    {
                        Console.WriteLine("Kön kan endast innehålla bokstäver. Försök igen.");
                        continue;
                    }

                    break; // Om ögonfärgen är giltig, bryt ur loopen
                }

                while (true)
                {
                    // Frågar användaren om hårdetaljer
                    Hair hair = new Hair();
                    Console.WriteLine("Ange hårlängd (t.ex. Kort, Medium, Lång eller skriv din egen färg): ");
                    hair.HairLength = Console.ReadLine();

                    // Kontrollerar om inmatningen är tom
                    if (string.IsNullOrEmpty(hair.HairLength))
                    {
                        Console.WriteLine("Hårlängd kan inte vara tomt.");
                        continue;
                    }

                    // Kontrollerar om inmatningen innehåller siffror
                    if (hair.HairLength.Any(char.IsDigit))
                    {
                        Console.WriteLine("Hårlängd kan inte innehålla siffror. Försök igen.");
                        continue;
                    }

                    // Kontrollerar om inmatningen innehåller specialtecken
                    if (!hair.HairLength.All(char.IsLetter))
                    {
                        Console.WriteLine("Hårlängd kan endast innehålla bokstäver. Försök igen.");
                        continue;
                    }

                    Console.WriteLine("Ange hårfärg (t.ex. Blond, Brun, Svart, Röd, Grå eller skriv din egen färg): ");
                    hair.HairColor = Console.ReadLine();

                    // Kontrollerar om inmatningen är tom
                    if (string.IsNullOrEmpty(hair.HairColor))
                    {
                        Console.WriteLine("Hårfärg kan inte vara tomt.");
                        continue;
                    }

                    // Kontrollerar om inmatningen innehåller siffror
                    if (hair.HairColor.Any(char.IsDigit))
                    {
                        Console.WriteLine("Hårfärg kan inte innehålla siffror. Försök igen.");
                        continue;
                    }

                    // Kontrollerar om inmatningen innehåller specialtecken
                    if (!hair.HairColor.All(char.IsLetter))
                    {
                        Console.WriteLine("Hårfärg kan endast innehålla bokstäver. Försök igen.");
                        continue;
                    }

                    // Skapar en ny person och lägg till i listan
                    Person newPerson = new Person(gender, hair, birthDate, eyeColor);
                    personList.Add(newPerson);

                    Console.WriteLine("Personen har lagts till!");
                    break; // Bryter ut ur loopen för att återvända till huvudmenyn
                }
                break;
            }
        }

        /// <summary>
        /// Metod för att lista alla personer
        /// </summary>
        public static void ListPersons(List<Person> personList)
        {
            Console.WriteLine("\nAlla tillagda personer:");

            // Kontrollerar om det finns några personer i listan. 

            if (personList.Count == 0)
            {
                Console.WriteLine("Ingen person finns i listan.");
            }
            else
            {
                foreach (var person in personList)
                {
                    // Skriv ut personens information och anävnda ToString() methoden som är definnerat i Person klass.
                    Console.WriteLine(person.ToString());
                }
            }
        }
    }
}

