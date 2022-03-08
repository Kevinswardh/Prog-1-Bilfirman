using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.IO;

namespace servicemeny
{
    public class Service
    {

        public static void Main()

        {
            
            string S = "";
            S += "\\";
            start:
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
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                   ___________________________________  ");
            Console.WriteLine("                  l          Övriga tjänster         l ");
            Console.WriteLine("                  ------------------------------------ ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  ____________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                                    /" + S);
            Console.WriteLine("                                   /  " + S);
            Console.WriteLine("                                  /    " + S);
            Console.WriteLine("                                 /      " + S);
            Console.WriteLine("                                [Huvudmeny]");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                  /                                   " + S);
            Console.WriteLine("                 /                                     " + S);
            Console.WriteLine("                /                                       " + S);
            Console.WriteLine("               < [Reperationer]                [Service] >");
            Console.WriteLine("                " + S + "                                       / ");
            Console.WriteLine("                 " + S + "                                     / ");
            Console.WriteLine("                  " + S + "                                   / ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("  ----------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            var keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.RightArrow)               // start right
            {
                service:
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                   ___________________________________  ");
                Console.WriteLine("                  l              Service             l ");
                Console.WriteLine("                  ------------------------------------ ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("  __________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                  ______________________________________      ");
                Console.WriteLine("                  l  Vänligen ring in för att boka tid  l");
                Console.WriteLine("                  l                                     l");
                Console.WriteLine("                  l      Telenummer: 123456789          l");
                Console.WriteLine("                  --------------------------------------");
                Console.WriteLine("                  /                                    ");
                Console.WriteLine("                 /                                      ");
                Console.WriteLine("                /                                        ");
                Console.WriteLine("               < [Tillbaka]                           ");
                Console.WriteLine("                " + S + "                                ");
                Console.WriteLine("                 " + S + "                              ");
                Console.WriteLine("                  " + S + "                            ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("  --------------------------------------------------------------------------");
                var keyPressedservice = Console.ReadKey();            //inuti service if statment
                if (keyPressedservice.Key == ConsoleKey.LeftArrow) 
                {
                    goto start;
                }
                else
                {
                    goto service;
                }
            }
            else if (keyPressed.Key == ConsoleKey.LeftArrow)               //start left
            {
                reparationer:
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("                   ___________________________________  ");
                Console.WriteLine("                  l            Reparationer           l ");
                Console.WriteLine("                  ------------------------------------ ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("  __________________________________________________________________________");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                  ______________________________________      ");
                Console.WriteLine("                  l  Vänligen ring in för att boka tid  l");
                Console.WriteLine("                  l                                     l");
                Console.WriteLine("                  l      Telenummer: 987654321          l");
                Console.WriteLine("                  --------------------------------------");
                Console.WriteLine("                                                      " + S);
                Console.WriteLine("                                                       " + S);
                Console.WriteLine("                                                        " + S);
                Console.WriteLine("                                              [Tillbaka] >");
                Console.WriteLine("                                                        / ");
                Console.WriteLine("                                                       / ");
                Console.WriteLine("                                                      / ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("  --------------------------------------------------------------------------");
                var keyPressedservice = Console.ReadKey();            //inuti service if statment
                if (keyPressedservice.Key == ConsoleKey.RightArrow)
                {
                    goto start;
                }
                else
                {
                    goto reparationer;
                }
            }
            else if (keyPressed.Key == ConsoleKey.UpArrow)               //start left
            {
               goto programslut;
            }
            else { goto start; }
            
        programslut:
            Console.WriteLine("Går till huvudmeny");
        }

        
    


}
}