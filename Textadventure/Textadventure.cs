using System;

namespace ConsoleApp2
{
    class Textadventure
    {
        static void Main(string[] args)
        {
            bool GAME_OVER = true;
            string input = "";
            string kreuzung = "start";
            while (GAME_OVER)
            {

                Console.WriteLine("Du machst dich auf die Reise um ein \u001b[33mLegendäres " +
                "Schwert\u001b[0m zu erlangen das dein \u001b[32mVater\u001b[0m dier Vererbt hat." +
                " Der erzählungen nachsoll das Schwert die Schärfeste Klinge " +
                "haben und kann mit einem Schwung durch \u001b[31mDrachenhaut\u001b[0m schneiden" +
                " als sei es Butter!                            " +
                "                                                                                                                                                                                                                                                               \u001b[34mWillst du dich auf die Reise machen ?\u001b[0m" +
                "                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   (Es wird mit \u001b[92mja\u001b[0m und \u001b[31mnein\u001b[0m geantwortet und alle anderen befehle werden klein geschrieben!)");
                input = Console.ReadLine();
                if (input == "ja")
                {
                    Console.Clear();
                    Console.WriteLine(" Du machst dich auch den Weg durch unzählig viele \u001b[32mWälder\u001b[0m und \u001b[90mSchluchten\u001b[0m, über \u001b[93mBerge\u001b[0m und \u001b[34mSeen\u001b[0m un erreichst schließlich                                  eine \u001b[95mAlte Ruine\u001b[0m die der Beschreibungen entspricht!" +
                        "                                                                                                                                                                                                                                                                                                                                                                                                                                                          \u001b[91mTraust du dich hineinzugehen?\u001b[0m");
                    input = Console.ReadLine();
                    if (input == "ja")
                    {
                        GAME_OVER = true;
                        Console.Clear();
                        Console.WriteLine("                  Du öffnest zwei großen Metall Türen, die das Innere \u001b[95mder Ruine\u001b[0m vom Rest der Welt                                                      abschneiden und blickst in ein Meer aus \u001b[7mDunkelheit\u001b[0m.                                                                                                                                                                                                                                                                                                                                                                                                                            Du entfachst eine kleine \u001b[91mFlamme\u001b[0m über deine Hand damit du die Dunkelheit vertreiben kannst.");;
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Du gehst Tief runter in die Ruine und triffst schlißlich auf eine Kreuzung. Du wirst zu einer entscheidung gezwungen.");
                       
                        WegeKreuz(true, true, true, true);
                        
                        input = Console.ReadLine();
                        if (input == "zurück")
                        {
                            Console.WriteLine("Du hast es dir anders überlegt und willst umkehren, doch als du dich auf den weg zum ausgang machst fällt die Tür zu und du sitzt Fest.");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        GAME_OVER = true;
                        Console.Clear();
                        Console.WriteLine("             Deine unschlüssigkeit hat ein Rudel wilder \u001b[31mWölfe\u001b[0m angelockt die dich sofort \u001b[93mangegriffen\u001b[0m haben!                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      Du hast es nicht so mit Tieren :(");
                        Console.ReadLine();

                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("                                                                                                                                                                                                                                                                              Du hast zu viel \u001b[31mAngst\u001b[0m und verkrümmelst dich zurück in dein \u001b[96mDorf\u001b[0m");
                    Console.ReadLine();
                    GAME_OVER = true;
                }


                if (GAME_OVER)
                {
                    Console.Clear();
                    Console.WriteLine("                                                                                                                                                                      \u001b[31mDu hast es nicht geschaft\u001b[0m                                                                                                                                                                                                                                                                                                                                                                                                                                                         \u001b[31mDrücke einen belibigen knopf um von vorne zubeginnen!\u001b[0m ");
                    Console.ReadKey();
                }

            }



        }
        static void WegeKreuz(bool geradeaus, bool links, bool rechts, bool zurück)
        {
            string links;
            string rechts;
            string zurück;
            string geradeaus;
            if (geradeaus)
            {
                geradeaus = "geradeaus";
            }
            else
            {
                geradeaus = "___/___";
            }
            if (links)
            {
                links = "links";
            }
            else
            {
                links = "___/___";
            }
             if (rechts)
            {
                rechts = "rechts";
            }
            else
            {
                rechts = "___/___";
            }
            if (zurück)
            {
                zurück = "zurück";
            }
            else
            {
                zurück = "___/___";
            }
            Console.WriteLine("" +
                        "      " + geradeaus + "\n " +
                        links + "         " + rechts + "\n" +
                        "       " + zurück);
        }


    }
}