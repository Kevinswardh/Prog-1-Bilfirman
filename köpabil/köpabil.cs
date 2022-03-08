// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace köpabil
{
    public class köpabil
    {

        public class links
        {
            public static void opentesla()
            {
                var uri = "https://www.tesla.com/en_eu/model3";
                var psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                Process.Start(psi);
            }
            public static void openbmw()
            {
                var uri = "https://www.bmw.se/sv/alla-modeller/x-serie/x5/2021/overblick.html";
                var psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                Process.Start(psi);
            }
            public static void openmustang()
            {
                var uri = "https://www.ford.com/cars/mustang/models/ecoboost-premium-fastback/";
                var psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                Process.Start(psi);
            }
            public static void openvolvo()
            {
                var uri = "https://www.volvocars.com/se/cars/c40-electric/";
                var psi = new ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                Process.Start(psi);
            }
        }
        public static void Main()
        {


            static void ShowSimplePercentage()
            {
                for (int i = 0; i <= 100; i++)
                {

                    Console.Write($"\rProgress: {i}%   ");     // räknar från 1 till 100, skriver ut 1 till 100 i en string där det står progress och procent, med en thread sleep som säger till hur snabbt
                    Thread.Sleep(10);
                }

                Console.Write("\rDone!          ");
            }
            static void ShowSpinner()
            {
                var counter = 0;
                for (int i = 0; i < 30; i++)
                {
                    switch (counter % 4)
                    {
                        case 0: Console.Write("/"); break;
                        case 1: Console.Write("-"); break;
                        case 2: Console.Write("\\"); break;
                        case 3: Console.Write("|"); break;
                    }
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    counter++;
                    Thread.Sleep(100);
                }
            }
            int kostbilett = 320000;                                                                                             /* KOLLA DECIMAL!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! */
            int kostbiltvå = 370000;
            int kostbiltre = 430000;
            int kostbilfyra = 520000;                                                   // varibler
            string bilett = "Tesla Model 3";
            string biltvå = "Volvo C40 Recharge";
            string biltre = "BMW X5";
            string bilfyra = "Ford Mustang70 EcoBoost® Premium Fastback";

            string S = "";
            S += "\\";
            Console.Clear();
            Console.WriteLine("Initializing");
            ShowSimplePercentage();
            ShowSpinner();

            /* Introduktion till bilfirman*/
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("      /l--------------------l" + S);
            Console.WriteLine("     / l                    l " + S);
            Console.Write("    /  l");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("     Bilfirman     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" l  " + S);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   /   l                    l   " + S);
            Console.WriteLine("  /____l--------------------l____" + S);



            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("   Hej och välkommen till Bilfirman! ");
            Console.WriteLine("   ________________________________  ");
            Console.WriteLine("  l Vi kommer att guida dig igenom l ");
            Console.WriteLine("  l   här till valet av din bil    l ");
            Console.WriteLine("  l      Mitt namn är Bertil       l ");
            Console.WriteLine("  l    Bilfirmans medhjälpare      l ");
            Console.WriteLine("  ---------------------------------- ");
            Console.WriteLine("  :::::::::::::::::::::::::::::::::: ");
            Console.WriteLine("  __________________________________ ");
            Console.WriteLine("  l  Vi kommer gå igenom allting   l ");
            Console.WriteLine("  l eftersom men just nu undrar jagl ");
            Console.WriteLine("  l      vad ditt namn är?         l ");

            /* Val av namn */
            Console.ForegroundColor = ConsoleColor.Green;
            string handlarensnamn = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("           Hallå  " + handlarensnamn);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("  l    Vad trevligt att du har     l ");
            Console.WriteLine("  l  besökt oss här på Bilfirman   l ");
            Console.WriteLine("  ----------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("  l   Vill du titta på bilarna     l ");
            Console.WriteLine("  l     som vi har inne idag?      l ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;

            /* Svar på om man vill kolla vad som finns inne */
            väljsiffra();
            static void väljsiffra()
            {
                Console.WriteLine("Svara genom att mata in en siffrorna av nedan");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("           _______________     ");
                Console.WriteLine("           l Svar: Ja[1]  l     ");
                Console.WriteLine("           ---------------     ");
                Console.WriteLine("           _______________      ");
                Console.WriteLine("           l Svar: Nej[2] l     ");
                Console.WriteLine("           ---------------     ");


                int Svar = Convert.ToInt32(Console.ReadLine());

                string bilett = "Tesla Model 3";
                string biltvå = "Volvo C40 Recharge";
                string biltre = "BMW X5";
                string bilfyra = "Ford Mustang70 EcoBoost® Premium Fastback";

                /* Valen som sker efter föra frågan */
                if (Svar == 1)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Trevligt!");
                    Console.WriteLine("");
                    string[] cars = { bilett, biltvå, biltre, bilfyra };
                    Console.WriteLine("");
                    Console.WriteLine("           ____________________________________      ");
                    Console.WriteLine("           l Här Kommer listan över alla bilar l     ");
                    Console.WriteLine("           ------------------------------------     ");
                    foreach (string element in cars)
                    {
                        Console.WriteLine($"    >    - {element}");   /* Lista över bilarna */
                    }
                }
                else if (Svar == 2)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Okej !, Skulle du vara intresserad av att Reperera din nuvarande bil eller ge den service?");
                    Console.WriteLine("Svara genomatt mata in Ja/Nej");
                    string ja = Console.ReadLine();
                    if (ja == "ja")
                    {
                        Console.WriteLine("           ______________________________________      ");
                        Console.WriteLine("           l  Vänligen ring in för att boka tid  l");
                        Console.WriteLine("           l                                     l");
                        Console.WriteLine("           l      Telenummer: 123456789          l");
                        Console.WriteLine("           --------------------------------------");
                        Console.WriteLine("           ______________________________________");
                        Console.WriteLine("           l        Vänligen stäng genom         l");
                        Console.WriteLine("           l        att mata in siffran 1        l");
                        Console.WriteLine("           --------------------------------------");
                        Environment.Exit(1);
                    }
                    else
                    {
                        Console.WriteLine("           _______________________________________");
                        Console.WriteLine("           l    Okej, Du kan stänga rutan genom   l");
                        Console.WriteLine("           l         att mata in siffran 1        l");
                        Console.WriteLine("           ---------------------------------------");
                        Environment.Exit(1);
                    }
                }
                else
                {
                    Console.WriteLine("Du måste tyvärr ge ett svar av antigen 1 eller 2");

                    väljsiffra();
                }
                /*välj siffra >>> */
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Vill du ha information av bilarna?");
            Console.WriteLine("Eller är intresserad av att köpa?");
            Console.WriteLine("");
            Console.WriteLine("");
            Selectthecars(kostbilett, kostbiltvå, kostbiltre, kostbilfyra, bilett, biltvå, biltre, bilfyra);
        }

        static void Selectthecars(int kostbilett, int kostbiltvå, int kostbiltre, int kostbilfyra, string bilett, string biltvå, string biltre, string bilfyra)
        {
        /* int bilettköp = 1;
         int bilettinfo = 2;

         int biltvåköp = 3;
         int biltvåinfo = 4;

         int biltreköp = 5;    Ta bort ifall du inte ska använda igen. Ha eventuellt med i utbildningsyfte
         int biltreinfo = 6;

         int bilfyraköp = 7;
         int bilfyrainfo = 8; */
        meny:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int selectcars = 9;
            
            Console.WriteLine("  ____________________________________         ____________________________________   ");
            Console.WriteLine("  l               Tesla              l         l               Volvo              l   ");
            Console.WriteLine("  ------------------------------------         ------------------------------------   ");
            Console.WriteLine(" _______________       _______________         _______________       _______________  ");
            Console.WriteLine(" l   Köp [1]   l       l   Info [2]  l         l   Köp [3]   l       l   Info [4]  l  ");
            Console.WriteLine(" ---------------       ---------------         ---------------       ---------------  ");
            Console.WriteLine("");
            Console.WriteLine("  ____________________________________         ____________________________________   ");
            Console.WriteLine("  l               BMW                l         l            Ford Mustang          l   ");
            Console.WriteLine("  ------------------------------------         ------------------------------------   ");
            Console.WriteLine(" _______________       _______________         _______________       _______________  ");
            Console.WriteLine(" l   Köp [5]   l       l   Info [6]  l         l   Köp [7]   l       l   Info [8]  l  ");
            Console.WriteLine(" ---------------       ---------------         ---------------       ---------------  ");
            Console.ForegroundColor = ConsoleColor.White;

            selectcars = Convert.ToInt32(Console.ReadLine());



            switch (selectcars)

            {
                /* Tesla köp */

                case 1:
                    Selectthecarone(kostbilett, kostbiltvå, kostbiltre, kostbilfyra, bilett, biltvå, biltre, bilfyra);
                    static void Selectthecarone(int kostbilett, int kostbiltvå, int kostbiltre, int kostbilfyra, string bilett, string biltvå, string biltre, string bilfyra)
                    {


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                        ____________________");
                        Console.WriteLine("                        l Du har valt Tesla l");
                        Console.WriteLine("                        l   Bilen kostar    l");
                        Console.WriteLine("                        l    320.000 kr     l");
                        Console.WriteLine("                        --------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                     SKulle du vilja köpa bilen?");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("           _______________                _______________     ");
                        Console.WriteLine("           l Svar: Ja[1]  l               l Svar: Nej[2] l     ");
                        Console.WriteLine("           ---------------                ---------------     ");

                        int selectbilett = Convert.ToInt32(Console.ReadLine());
                        if (selectbilett == 1)
                        {
                            Console.WriteLine("                         ____________________");
                            Console.WriteLine("                          Du har valt att köpa  ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("                             " + bilett);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("                             " + kostbilett + " KR");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                          Var go och kontakta ");
                            Console.WriteLine("                         associerad säljare på ");
                            Console.WriteLine("                           TeleNr: 1234567");
                            Console.WriteLine("                        ---------------------");
                            Console.WriteLine(" Gå tillbaka till huvudmenyn genom att mata in valfri siffra eller bokstav");
                            Console.ReadKey();

                        }
                        if (selectbilett == 2)
                        {
                            Selectthecars(kostbilett, kostbiltvå, kostbiltre, kostbilfyra, bilett, biltvå, biltre, bilfyra);    // enbart 
                        }
                        if (selectbilett > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("          !!!!!!!  Du måste välja antigen 1 eller 2   !!!!!!!");
                            Selectthecarone(kostbilett, kostbiltvå, kostbiltre, kostbilfyra, bilett, biltvå, biltre, bilfyra);
                        }
                    }
                    /* else   Else blev buggad här, printade ut trotts val 1 var gjort. kanske för jag är i ett switch statment? 
                    {
                        Console.WriteLine("Du måste välja antigen 1 eller 2");
                    } */
                    break;

                /* Tesla info */
                case 2:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("_____________________________________________________________");
                    Console.WriteLine("l  The base Model 3 delivers an EPA-rated all-electric range l");
                    Console.WriteLine("l of 272 miles (438 km) and the Long Range version delivers  l");
                    Console.WriteLine("l    358 miles (576 km). According to Tesla, the Model 3     l");
                    Console.WriteLine("l    carries full self-driving hardware, with periodic       l");
                    Console.WriteLine("l        software updates, adding functionality.             l");
                    Console.WriteLine("--------------------------------------------------------------");

                    links.opentesla();
                    break;

                /* Volvo köp */
                case 3:
                    Selectthecartwo(kostbiltvå, biltvå, kostbilett, kostbiltre, kostbilfyra, bilett, biltre, bilfyra);
                    static void Selectthecartwo(int kostbiltvå, string biltvå, int kostbilett, int kostbiltre, int kostbilfyra, string bilett, string biltre, string bilfyra)
                    {


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                        ____________________");
                        Console.WriteLine("                        l Du har valt Volvo l");
                        Console.WriteLine("                        l   Bilen kostar    l");
                        Console.WriteLine("                        l    370.000 kr     l");
                        Console.WriteLine("                        --------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                     SKulle du vilja köpa bilen?");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("           _______________                _______________     ");
                        Console.WriteLine("           l Svar: Ja[1]  l               l Svar: Nej[2] l     ");
                        Console.WriteLine("           ---------------                ---------------     ");

                        int selectbilett = Convert.ToInt32(Console.ReadLine());
                        if (selectbilett == 1)
                        {
                            Console.WriteLine("                         ____________________");
                            Console.WriteLine("                          Du har valt att köpa  ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("                             " + biltvå);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("                             " + kostbiltvå + " KR");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                          Var go och kontakta ");
                            Console.WriteLine("                         associerad säljare på ");
                            Console.WriteLine("                           TeleNr: 2345678");
                            Console.WriteLine("                        ---------------------");
                            Console.WriteLine(" Gå tillbaka till huvudmenyn genom att mata in valfri siffra eller bokstav");
                            Console.ReadKey();
                        }
                        if (selectbilett == 2)
                        {
                            Selectthecars(kostbilett, kostbiltvå, kostbiltre, kostbilfyra, bilett, biltvå, biltre, bilfyra);
                        }
                        if (selectbilett > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("          !!!!!!!  Du måste välja antigen 1 eller 2   !!!!!!!");
                            Selectthecartwo(kostbiltvå, biltvå, kostbilett, kostbiltre, kostbilfyra, bilett, biltre, bilfyra);
                        }
                    }
                    /* else   Else blev buggad här, printade ut trotts val 1 var gjort. kanske för jag är i ett switch statment? 
                    {
                        Console.WriteLine("Du måste välja antigen 1 eller 2");
                    } */
                    break;

                /* Volvo Info */
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("________________________________________________");
                    Console.WriteLine("l      The full electric Volvo crossover       l");
                    Console.WriteLine("l     with a slimmed profile, black roof,      l");
                    Console.WriteLine("l         glossy black design details          l");
                    Console.WriteLine("l and unique wheels for a powerful impression. l");
                    Console.WriteLine("------------------------------------------------");
                    links.openvolvo();
                    break;

                /* BMW köp */
                case 5:
                    Selectthecartree(kostbiltre, biltre, kostbilett, kostbiltvå, kostbilfyra, bilett, biltvå, bilfyra);

                    static void Selectthecartree(int kostbiltre, string biltre, int kostbilett, int kostbiltvå, int kostbilfyra, string bilett, string biltvå, string bilfyra)
                    {


                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                        _____________________");
                        Console.WriteLine("                        l Du har valt BMW X5 l");
                        Console.WriteLine("                        l    Bilen kostar    l");
                        Console.WriteLine("                        l     430.000 kr     l");
                        Console.WriteLine("                        ---------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                     SKulle du vilja köpa bilen?");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("           _______________                _______________     ");
                        Console.WriteLine("           l Svar: Ja[1]  l               l Svar: Nej[2] l     ");
                        Console.WriteLine("           ---------------                ---------------     ");

                        int selectbilett = Convert.ToInt32(Console.ReadLine());
                        if (selectbilett == 1)
                        {
                            Console.WriteLine("                         ____________________");
                            Console.WriteLine("                          Du har valt att köpa  ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("                             " + biltre);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("                             " + kostbiltre + " KR");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                          Var go och kontakta ");
                            Console.WriteLine("                         associerad säljare på ");
                            Console.WriteLine("                           TeleNr: 34567890");
                            Console.WriteLine("                        ---------------------");
                            Console.WriteLine(" Gå tillbaka till huvudmenyn genom att mata in valfri siffra eller bokstav");
                            Console.ReadKey();
                        }
                        if (selectbilett == 2)
                        {
                            Selectthecars(kostbilett, kostbiltvå, kostbiltre, kostbilfyra, bilett, biltvå, biltre, bilfyra);
                        }
                        if (selectbilett > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("          !!!!!!!  Du måste välja antigen 1 eller 2   !!!!!!!");
                            Selectthecartree(kostbiltre, biltre, kostbilett, kostbiltvå, kostbilfyra, bilett, biltvå, bilfyra);
                        }
                    }
                    /* else   Else blev buggad här, printade ut trotts val 1 var gjort. kanske för jag är i ett switch statment? 
                    {
                        Console.WriteLine("Du måste välja antigen 1 eller 2");
                    } */
                    break;

                /* BMW Info */

                case 6:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("____________________________________________________________________________________________________");
                    Console.WriteLine("l                BMW X5 erbjuder med sitt vidareutvecklade TwinPower Turbo-aggregat                 l");
                    Console.WriteLine("l                och det fantastiska väggreppet hos BMW:s smarta fyrhjulsdrift xDrive               l");
                    Console.WriteLine("l                      är en garanti för körglädje i alla typer av terräng.                         l");
                    Console.WriteLine("l             xOffroad-paketet (tillval) bidrar till att ge ett perfekt avstämning:                 l");
                    Console.WriteLine("l Med de fyra Offroad-körlägena kan fyrhjulsdriften anpassas perfekt efter det aktuella underlaget. l");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    links.openbmw(); // Öppnar bmw länk
                    break;

                /* Mustang köp */
                case 7:
                    Selectthecarfour(kostbilfyra, bilfyra, kostbilett, kostbiltvå, kostbiltre, bilett, biltvå, biltre);
                    static void Selectthecarfour(int kostbilfyra, string bilfyra, int kostbilett, int kostbiltvå, int kostbiltre, string bilett, string biltvå, string biltre)
                    {

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                        ______________________");
                        Console.WriteLine("                        l Du har valt Mustang l");
                        Console.WriteLine("                        l     Bilen kostar    l");
                        Console.WriteLine("                        l      520.000 kr     l");
                        Console.WriteLine("                        ----------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                     SKulle du vilja köpa bilen?");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("           _______________                _______________     ");
                        Console.WriteLine("           l Svar: Ja[1]  l               l Svar: Nej[2] l     ");
                        Console.WriteLine("           ---------------                ---------------     ");

                        int selectbilett = Convert.ToInt32(Console.ReadLine());
                        if (selectbilett == 1)
                        {
                            Console.WriteLine("                         ____________________");
                            Console.WriteLine("                          Du har valt att köpa  ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("                             " + bilfyra);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("                             " + kostbilfyra + " KR");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                          Var go och kontakta ");
                            Console.WriteLine("                         associerad säljare på ");
                            Console.WriteLine("                           TeleNr: 45678901");
                            Console.WriteLine("                        ---------------------");
                            Console.WriteLine(" Gå tillbaka till huvudmenyn genom att mata in valfri siffra eller bokstav");
                            Console.ReadKey();
                        }
                        if (selectbilett == 2)
                        {
                            Selectthecars(kostbilett, kostbiltvå, kostbiltre, kostbilfyra, bilett, biltvå, biltre, bilfyra);
                        }
                        if (selectbilett > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("          !!!!!!!  Du måste välja antigen 1 eller 2   !!!!!!!");
                            Selectthecarfour(kostbilfyra, bilfyra, kostbilett, kostbiltvå, kostbiltre, bilett, biltvå, biltre);
                        }
                    }
                    /* else   Else blev buggad här, printade ut trotts val 1 var gjort. kanske för jag är i ett switch statment? 
                    {
                        Console.WriteLine("Du måste välja antigen 1 eller 2");
                    } */
                    break;

                /* Mustang Info */
                case 8:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("____________________________________________________________________________________________________");
                    Console.WriteLine("l                         The Ford Mustang70 EcoBoost® Premium Fastback features                    l");
                    Console.WriteLine("l                                                                                                   l");
                    Console.WriteLine("l                  The Wheel Stripe Package includes 19 - inch x 8.5 - inch machined                l");
                    Console.WriteLine("l                      face aluminum wheels with Dark Tarnish - painted pockets.                    l");
                    Console.WriteLine("l                                                                                                   l");
                    Console.WriteLine("l                                                 Sync 3                                            l");
                    Console.WriteLine("l                       Don’t drive while distracted.Use voice - operated systems                   l");
                    Console.WriteLine("l                        when possible; don’t use handheld devices while driving.                   l");
                    Console.WriteLine("l                      Some features may be locked out while the vehicle is in gear                 l");
                    Console.WriteLine("l                             Not all features are compatible with all phones.                      l");
                    Console.WriteLine("----------------------------------------------------------------------------------------------------");
                    links.openmustang();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                                     Fel inmatning!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                           Du måste välja en siffra mellan 1-8");
                    
                    goto meny;
                    

                    break;

            }

            if (selectcars == 2)
            {
                Selectthecars(kostbilett,
                              kostbiltvå,
                              kostbiltre,
                              kostbilfyra,
                              bilett,
                              biltvå,
                              biltre,
                              biltvå);
            }
            if (selectcars == 4)
            {
                Selectthecars(kostbilett,
                              kostbiltvå,
                              kostbiltre,
                              kostbilfyra,
                              bilett,
                              biltvå,
                              biltre,
                              biltvå);
            }
            if (selectcars == 6)
            {
                Selectthecars(kostbilett,
                              kostbiltvå,
                              kostbiltre,
                              kostbilfyra,
                              bilett,
                              biltvå,
                              biltre,
                              biltvå);
            }
            if (selectcars == 8)
            {
                Selectthecars(kostbilett,
                              kostbiltvå,
                              kostbiltre,
                              kostbilfyra,
                              bilett,
                              biltvå,
                              biltre,
                              biltvå);
            }
        }
    }
}

