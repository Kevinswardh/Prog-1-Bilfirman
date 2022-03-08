// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;


namespace bilfirmanpersonal
{
    public class Personalen
    {
        static void ShowSpinner()
        {
            var counter = 0;
            for (int i = 0; i < 50; i++)
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
                Thread.Sleep(75);
            }
        }
        public static void Main()
        {
            Console.WriteLine("");
            Console.WriteLine("Enter username:");
            string namn = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string efternamn = Console.ReadLine();
            string[] contact = new string[2];
            contact[0] = namn;
            contact[1] = efternamn;
            Console.ForegroundColor = ConsoleColor.Green;


            if (contact[0] == "personal" && contact[1] == "personal")
            {
                ShowSpinner();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct ! " + contact[0] + " " + contact[1]);
            }
            else
            {
                ShowSpinner();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong Password!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Please close this window!");
                Environment.Exit(0);
            }
            string path1 = @"c:\applikation\personalnamn.txt";
            string path2 = @"c:\applikation\personallösen.txt";
            string path3 = @"c:\applikation\personaltid.txt";
            System.IO.Directory.CreateDirectory(@"c:\applikation\");
            if (!File.Exists(path1))
            {
                // Create a file to write to.
                using (File.CreateText(path1))
                {

                }
            }

            if (!File.Exists(path2))
            {
                // Create a file to write to.
                using (File.CreateText(path2))
                {

                }
            }
            if (!File.Exists(path3))
            {
                // Create a file to write to.
                using (File.CreateText(path3))
                {

                }
            }

            string S = "";
            S += "\\";
            string input;
            string savePath = (@"c:\applikation\");
            int ID = 0;
            bool login = false;

            string[] användarArray = File.ReadAllLines(@"c:\applikation\personalnamn.txt");
            ArrayList användarnamn = new ArrayList(användarArray);
            string[] lösenArray = File.ReadAllLines(@"c:\applikation\personallösen.txt");
            ArrayList lösenord = new ArrayList(lösenArray);
            string[] tidArray = File.ReadAllLines(@"c:\applikation\personaltid.txt");
            ArrayList time = new ArrayList(tidArray);

        start:
            if (login == true)
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
            Console.WriteLine("                  l           PERSONAL MENY          l     ");
            Console.WriteLine("                  ------------------------------------     ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("               _________________       ___________________     ");
            Console.WriteLine("               l Logga in : [1] l      l Registrera: [2] l     ");
            Console.WriteLine("               ------------------      -------------------      ");
            Console.WriteLine("                           ___________________");
            Console.WriteLine("                           l  Huvud Meny: [3] l ");
            Console.WriteLine("                           --------------------");
            Console.WriteLine("                           ___________________");
            Console.WriteLine("                           l  Stäng ned: [4]  l ");
            Console.WriteLine("                           -------------------");
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
                    foreach (string name in användarnamn)
                    {
                        if (name == input)
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
                                string lastLogin = Convert.ToString(time[ID]);
                                Console.WriteLine(@"Du var senast inloggad " + lastLogin);
                                time[ID] = (Convert.ToString(DateTime.Now));
                                using (TextWriter writer = File.CreateText(@"c:\applikation\personaltid.txt"))
                                {
                                    foreach (string date in time)
                                    {
                                        writer.WriteLine(date);
                                    }
                                }

                                login = true;
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
                    foreach (string name in användarnamn)
                    {
                        if (name == input)
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
                    using (TextWriter writer = File.CreateText(@"c:\applikation\personalnamn.txt"))
                    {
                        foreach (string name in användarnamn)
                        {
                            writer.WriteLine(name);
                        }
                    }
                    using (TextWriter writer = File.CreateText(@"c:\applikation\personallösen.txt"))
                    {
                        foreach (string pass in lösenord)
                        {
                            writer.WriteLine(pass);
                        }
                    }
                    time.Add(Convert.ToString(DateTime.Now));
                    using (TextWriter writer = File.CreateText(@"c:\applikation\personaltid.txt"))
                    {
                        foreach (string date in time)
                        {
                            writer.WriteLine(date);
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
                case "till huvudmeny":
                    goto programslut;
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
            Console.WriteLine("                        _______________________");
            Console.WriteLine("                        l Personal lista: [1] l");
            Console.WriteLine("                        -----------------------");
            Console.WriteLine("_____________________       __________________       ___________________     ");
            Console.WriteLine("l Byta lösenord: [2] l      l  Logga ut : [3] l      l  Stäng ned: [5]  l  ");
            Console.WriteLine("----------------------      -------------------      -------------------      ");
            Console.ForegroundColor = ConsoleColor.White;
            menyval:
            input = Console.ReadLine();
            input.ToLower();
            switch (input)
            {
                case "1":
                case "lista över personal":
                   
                    foreach (string name in användarnamn)
                    {
                        string[] lines = File.ReadAllLines(@"C:\applikation\personalnamn.txt");
                        for (int i = 0; i < lines.Length; i++)
                            Console.WriteLine("    >  -  " + lines[i]);
                        goto menyval;
                    }
                    
                    break;

                case "2":
                case "byta lösenord":
                    Console.WriteLine("What would you like your new password to be?");
                    input = Console.ReadLine();
                    lösenord[ID] = input;
                    using (TextWriter writer = File.CreateText(@"c:\applikation\personallösen.txt"))
                    {
                        foreach (string pass in lösenord)
                        {
                            writer.WriteLine(pass);
                        }
                    }
                    Console.WriteLine("Password changed!");
                    Thread.Sleep(3000);
                    break;

                case "3":
                case "logga ut":
                    Console.WriteLine("                  Säker på att du vill logga ut? ja/nej");
                    input = Console.ReadLine();
                    if (input == "ja")
                    {
                        login = false;
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
        programslut:
            Console.Clear();
            Console.WriteLine("Går till Huvudmeny");
        }
    }
}