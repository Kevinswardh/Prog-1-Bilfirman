// See https://aka.ms/new-console-template for more information
using köpabil;
using säljbil;
using bilfirmanpersonal;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp7
{
    class Program
    {
        static void ShowSpinner()
        {
            var counter = 0;
            for (int i = 0; i < 50; i++)
            {
                switch (counter % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;                         //Funktion för en mer tillfredställande effekt efter handlingar.
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                counter++;
                Thread.Sleep(75);
            }
        }
        static void Main(string[] args)                         
        {
            string path1 = @"c:\applikation\username.txt";
            string path2 = @"c:\applikation\password.txt";
            string path3 = @"c:\applikation\time.txt";
            Directory.CreateDirectory(@"c:\applikation\");  // Skapar en mapp i C:Drive som heter applikation
            if (!File.Exists(path1))
            {
                using (File.CreateText(path1))
                {

                }
            }

            if (!File.Exists(path2))
            {
                using (File.CreateText(path2))                 // skapar 3 text filer i mappen som tigiare skapades.
                {

                }
            }
            if (!File.Exists(path3))
            {
                using (File.CreateText(path3))
                {

                }
            }

            string S = "";
            S += "\\";
            string input;
            string savePath = @"c:\applikation\";
            int ID = 0;
            bool loggain = false;

            string[] användarArray = File.ReadAllLines(@"c:\applikation\username.txt");
            ArrayList användarnamn = new ArrayList(användarArray);
            string[] lösenArray = File.ReadAllLines(@"c:\applikation\password.txt");    //array list för namn/lösenord och tider.
            ArrayList lösenord = new ArrayList(lösenArray);
            string[] tidsArray = File.ReadAllLines(@"c:\applikation\time.txt");
            ArrayList tid = new ArrayList(tidsArray);

        start:
            if (loggain == true)
            {
                goto menu;
            }
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                        /l--------------------l" + S);
            Console.WriteLine("                       / l                    l " + S);
            Console.Write("                      /  l");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("     Bilfirman     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" l  " + S);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                     /   l                    l   " + S);
            Console.WriteLine("                    /____l--------------------l____" + S);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                  ____________________________________      ");
            Console.WriteLine("                  l             HUVUDMENY            l     ");
            Console.WriteLine("                  ------------------------------------     ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("               _________________       ___________________     ");
            Console.WriteLine("               l Logga in : [1] l      l Registrera: [2] l     ");
            Console.WriteLine("               ------------------      -------------------      ");
            Console.WriteLine("                       _________________________");
            Console.WriteLine("                       l Hantera personal: [3]  l ");
            Console.WriteLine("                       -------------------------");
            Console.WriteLine("                           _________________");
            Console.WriteLine("                           l Avsluta: [3]  l ");
            Console.WriteLine("                           ----------------");
            Console.ForegroundColor = ConsoleColor.White;
            input = Console.ReadLine();

            switch (input)
            {
                case "1":
                case "loggain":
                    Console.WriteLine("                   _________________________________");
                    Console.WriteLine("                   l        Ange användarnamn:      l ");
                    Console.WriteLine("                   ----------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    input = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    input = input.ToLower();
                    if (input == "default")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                 !!!!!!!!Felaktigt användarnamn!!!!!!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(3000);
                        goto start;
                    }
                    foreach (string namn in användarnamn)
                    {
                        if (namn == input)
                        {
                            int listNo = användarnamn.IndexOf(input);
                            Console.WriteLine("                   _________________________________");
                            Console.WriteLine("                   l           Ange lösenord:       l ");
                            Console.WriteLine("                   ----------------------------------");
                            Console.ForegroundColor = ConsoleColor.Green;
                            input = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            string passCheck = Convert.ToString(lösenord[listNo]);
                            if (input == passCheck)
                            {
                                ID = listNo;
                                string lastLogin = Convert.ToString(tid[ID]);
                                Console.WriteLine(@"Du var senast inloggad " + lastLogin);
                                Console.WriteLine(" Loggar in...");
                                tid[ID] = Convert.ToString(DateTime.Now);
                                using (TextWriter writer = File.CreateText(@"c:\applikation\time.txt"))
                                {
                                    foreach (string date in tid)
                                    {
                                        writer.WriteLine(date);
                                    }
                                }

                                loggain = true;
                                ShowSpinner();
                                Thread.Sleep(1000);
                                goto start;  // händvisning till start där sedan ett if statment if login == true händvisar till meny
                            }
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("             !!!!!!!! Felaktig information eller error !!!!!!!!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(3000);
                    goto start;

                case "2":
                case "registrering":
                username:
                    Console.WriteLine("                    _________________________________");
                    Console.WriteLine("                    l    Ange önskat användarnamn:   l ");
                    Console.WriteLine("                    ----------------------------------");

                    input = Console.ReadLine();
                    input = input.ToLower();
                    if (input == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("          _____________________________________________________");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("              Oj! nu glömde du visst att ange användarnamnet    ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("          ------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("             Var vänlig och försök igen genom att mata in [1]");
                        Console.WriteLine("                                 eller                    ");
                        Console.WriteLine("                 Gå till huvudmeny genom att mata in      [2]");
                        int svaret = Convert.ToInt32(Console.ReadLine());
                        Thread.Sleep(1000);
                        if (svaret == 1)
                        {
                            goto username;
                        }
                        else if (svaret == 2)
                        {
                            goto start;
                        }
                        else
                        {
                            goto start;
                        }
                    }
                    foreach (string namn in användarnamn)
                    {
                        if (namn == input)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("            _____________________________________________________");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                 Tyvärr! Detta lösenordet är redan taget    ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("            ------------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("                         Var go och försök igen");
                            Thread.Sleep(1000);
                            goto username;
                        }
                    }
                    användarnamn.Add(input);
                    Console.WriteLine("                    _________________________________");
                    Console.WriteLine("                    l      Ange önskat lösenord:     l ");
                    Console.WriteLine("                    ----------------------------------");
                password:
                    input = Console.ReadLine();
                    if (input == "")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("          _____________________________________________________");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("              Oj! nu glömde du visst att ange lösenordet    ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("          ------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                        Thread.Sleep(1000);
                        goto password;
                    }
                    lösenord.Add(input);
                    using (TextWriter writer = File.CreateText(@"c:\applikation\username.txt"))
                    {
                        foreach (string namn in användarnamn)
                        {
                            writer.WriteLine(namn);
                        }
                    }
                    using (TextWriter writer = File.CreateText(@"c:\applikation\password.txt"))
                    {
                        foreach (string lösen in lösenord)
                        {
                            writer.WriteLine(lösen);
                        }
                    }
                    tid.Add(Convert.ToString(DateTime.Now));
                    using (TextWriter writer = File.CreateText(@"c:\applikation\time.txt"))
                    {
                        foreach (string datum in tid)
                        {
                            writer.WriteLine(datum);
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("            _____________________________________________________");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                              Användare skapad   ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("            ------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;

                    ShowSpinner();
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "3":
                    Personalen.Main();

                    break;
                case "4":
                case "avsluta":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("          _____________________________________________________");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                              Stänger ned   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("          ------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;

                    Thread.Sleep(25);
                    ShowSpinner();
                    Environment.Exit(0);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                              Fel inmatning");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(100);
                    goto start;

            }
            goto start;

        menu:                                                                            //inloggad meny
            Console.Clear();

            string user = Convert.ToString(användarnamn[ID]);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                        /l--------------------l" + S);
            Console.WriteLine("                       / l                    l " + S);
            Console.Write("                      /  l");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("     Bilfirman     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" l  " + S);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("                     /   l                    l   " + S);
            Console.WriteLine("                    /____l--------------------l____" + S);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                  ____________________________________      ");
            Console.WriteLine("                          Välkommen in " + user);
            Console.WriteLine("                  ------------------------------------     ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("_________________       ___________________      _______________________");
            Console.WriteLine("l  Köp bil : [1] l      l  Sälj bil: [2]  l      l Övriga tjänster: [3] l");
            Console.WriteLine("------------------      -------------------      -----------------------");
            Console.WriteLine("_____________________       __________________       ___________________     ");
            Console.WriteLine("l Byta lösenord: [4] l      l  Logga ut : [5] l      l  Stäng ned: [6]  l  ");
            Console.WriteLine("----------------------      -------------------      -------------------      ");
            Console.ForegroundColor = ConsoleColor.White;

            input = Console.ReadLine();
            input.ToLower();
            switch (input)
            {
                case "1":
                case "köp bil":
                    köpabil.köpabil.Main();
                    break;

                case "2":
                case "sälj bil":
                    säljabil.Main();

                    break;
                case "3":
                case "övriga tjänster":
                    servicemeny.Service.Main();
                    break;
                case "4":
                case "byta lösenord":
                    Console.WriteLine("What would you like your new password to be?");
                    input = Console.ReadLine();
                    lösenord[ID] = input;
                    using (TextWriter writer = File.CreateText(@"c:\applikation\password.txt"))
                    {
                        foreach (string lösen in lösenord)
                        {
                            writer.WriteLine(lösen);
                        }
                    }
                    Console.WriteLine("Password changed!");
                    Thread.Sleep(3000);
                    break;

                case "5":
                case "logga ut":
                    Console.WriteLine("                  Säker på att du vill logga ut? ja/nej");
                    input = Console.ReadLine();
                    if (input == "ja")
                    {
                        loggain = false;
                        ID = 0;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("          _____________________________________________________");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                               Loggar ut   ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("          ------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                        ShowSpinner();

                    }
                    break;
                case "6":
                case "avsluta":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("          _____________________________________________________");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("                              Stänger ned   ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("          ------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.White;

                    Thread.Sleep(25);
                    ShowSpinner();
                    Environment.Exit(0);
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("                              Fel inmatning");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(100);
                    goto start;
            }
            goto start;

        }

    }

}