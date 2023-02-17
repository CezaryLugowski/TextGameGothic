using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tekstgra
{
    internal class Encounters
    {
        static Random rand = new Random();

       
        //Bitwy
        public static void NaukaWalki()
        {
            Console.WriteLine("Podczas walki można używać skrótów podanych w nawiasach");
            Console.WriteLine("Wystarczy wpisać np.'a' ");
            Console.ReadKey();
            Walka(false, "Ścierwojad", 8, 25);
        }

        public static void PierwszeSpotkanie()

        {
            Console.WriteLine("Widzisz krwiopijcę, czas na exp");
            Console.ReadKey();
            Walka(false, "Krwiopijca", 10, 32);
        }

        public static void KrolowaPelzaczy()
        {
            Console.ReadKey();
            Walka(false, "Królowa pełzaczy", 24, 49);
        }

        public static void OpentanyNowicjusz()
        {
            Console.ReadKey();
            Walka(false, "Nowicjusz z kamieniem", 27, 50);
        }

        public static void CzarneGobliny()
        {
            Console.ReadKey();
            Walka(false, "Grupa goblinów", 31, 53);
        }

        public static void Ork()
        {
            Console.ReadKey();
            Walka(false, "Ork", 30, 47);
        }

        public static void OpentanyMag()
        {
            Console.ReadKey();
            Walka(false, "Opętany Mag", 30, 40);
        }

        public static void DuzyTroll()
        {
            Console.ReadKey();
            Walka(false, "Duży troll", 50, 60);
        }

        public static void MalyTroll()
        {
            Console.ReadKey();
            Walka(false, "Mały troll", 30, 40);
        }
        public static void Trup()
        {
            Console.ReadKey();
            Walka(false, "Żywy trup", 40, 40);
        }

        public static void HarpiaDuza()
        {
            Console.ReadKey();
            Walka(false, "Harpia", 35, 45);
        }
        public static void SilnyZombie()
        {
            Console.ReadKey();
            Walka(false, "Zombie (silny)", 40, 45);
        }

        public static void Sniacy()
        {
            Console.ReadKey();
            Walka(false, "Śniący", 150, 250);
        }

        public static void LosowaWalka()
        {
            Console.WriteLine("Czas na exp");
            Console.WriteLine("Zwiedzasz barierę w poszukiwaniu odpowiedniego przeciwnika");
            Console.WriteLine("WIDZISZ GO!!");
            Console.WriteLine("Wyciągasz broń");
            Console.ReadKey();
            Walka(true, "", 0, 0);
        }


        //narzędzia do bitwy
        public static void Walka(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;

            if (random)
            {
                n = GetName();
                p = rand.Next(1, 33);
                h = rand.Next(1, 44);
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine("Twój wróg to: " + n);
                Console.WriteLine("Jego siła:" + p + "/ Życie przeciwnika:" + h);
                Console.WriteLine("==============================");
                Console.WriteLine("| (a)tak           (o)brona  |");
                Console.WriteLine("| (s)zybki odwrót  (p)otka   |");
                Console.WriteLine("==============================");
                Console.WriteLine("Potki " + Program.currentPlayer.potion + "  Żyćko " + Program.currentPlayer.health);
                Console.Write(">");
                string input = Console.ReadLine();

                if (input.ToLower() == "a" || input.ToLower() == "atak")
                {
                    //atak
                    Console.WriteLine("Biegniesz w stronę przeciwnika, podnosisz broń nad głowę by zwiększyć zamach i tniesz przeciwnika");
                    Console.WriteLine(n + " kontratakuje");
                    int damage = p - Program.currentPlayer.armorValiu;
                    if (damage <= 0)
                        damage = 0;
                    int atak = rand.Next(0, Program.currentPlayer.weaponValiu) + rand.Next(1, Program.currentPlayer.damage);
                    Console.WriteLine("Zadałeś " + atak + " pt. obrażeń");
                    Console.WriteLine(n + " zadaje Ci " + damage + " pt obrażeń");
                    Program.currentPlayer.health -= damage;
                    h -= atak;
                    Console.WriteLine("Naciśnij ENTER by kontynuować");
                }
                else if (input.ToLower() == "o" || input.ToLower() == "obrona")
                {
                    //obrona
                    Console.WriteLine("Przyjmujesz pozycję do obrony");
                    Console.WriteLine("Trzymasz swoją broń poziomo w obu rękach");
                    Console.WriteLine("Próbujesz parować atak przeciwnika");
                    int damage = (p / 2) - Program.currentPlayer.armorValiu;
                    if (damage <= 0)
                        damage = 0;
                    Console.WriteLine("Otrzymałeś " + damage + " pt obrażeń");
                    Console.WriteLine("Gdy " + n + " wycofuje się atakujesz");
                    Console.WriteLine("Przeciwnik spodziewał się tego i przeszedł do obrony");
                    int atak = (rand.Next(0, Program.currentPlayer.weaponValiu) + rand.Next(1, Program.currentPlayer.damage)) / 3;
                    Console.WriteLine("Zadałeś " + atak + " pt obrażeń");
                    Program.currentPlayer.health -= damage;
                    h -= atak;
                    Console.WriteLine("Naciśnij ENTER by kontynuować");
                }
                else if (input.ToLower() == "s" || input.ToLower() == "szybki odwrót")
                {
                    //ucieczka
                    if (rand.Next(0, 1) == 0)
                    {
                        Console.WriteLine("Odwracasz się od przeciwnika w celu taktycznego odwrotu jak najdalej");
                        Console.WriteLine("Jednak przeciwnik zadaje Ci cios w plecy, padasz na twarz");
                        int damage = p + 5 - Program.currentPlayer.armorValiu;
                        if (damage <= 0)
                            damage = 0;
                        Console.WriteLine("Otrzymujesz " + damage + " pt obrażeń");
                        Console.WriteLine("W ostatniej chwili, odwracasz się i ranisz" + n);
                        int atak = (rand.Next(0, Program.currentPlayer.weaponValiu) + rand.Next(1, Program.currentPlayer.damage)) / 4;
                        Console.WriteLine("Zadajesz " + atak + " pt obrażeń");
                        Console.WriteLine("Naciśnij ENTER by kontynuować");
                        Console.ReadKey();
                        h -= atak;
                        Program.currentPlayer.health -= damage;
                    }
                    else
                    {
                        Console.WriteLine("Biegniesz w stronę przeciwnika, podnosisz broń i przebiegasz obok niego");
                        Console.WriteLine("Uciekasz dzięki ninja ruchom");
                        Console.WriteLine(n + " w pogoni za Tobą upada i głupią twarz sobie rozwala");
                        Console.WriteLine("Sprawia Ci to radość");
                        Console.WriteLine("Naciśnij ENTER by kontynuować");
                        Console.ReadKey();
                        h -= 999;

                    }
                }
                else if (input.ToLower() == "p" || input.ToLower() == "potka")
                {
                    //potion
                    if (Program.currentPlayer.potion <= 0)
                    {
                        Console.WriteLine("Jako że bohater był zbyt zajęty walką to chciał napić się z pustego");
                        Console.WriteLine("Nie ma potek, nie ma żyćka");
                        Console.WriteLine(n + " atakuje");
                        int damage = p - Program.currentPlayer.armorValiu;
                        if (damage <= 0)
                            damage = 0;
                        Console.WriteLine("Otrzymujesz " + damage + " pkt obrażeń");
                        Console.WriteLine("Naciśnij ENTER by kontynuować");
                        Program.currentPlayer.health -= damage;
                    }
                    else
                    {
                        Console.WriteLine("Bierzesz łyk pysznego napoju");
                        Console.WriteLine("Otrzymujesz 15 pt żyćka");
                        Program.currentPlayer.health += 15;
                        Program.currentPlayer.potion -= 1;
                        Console.WriteLine("Naciśnij ENTER by kontynuować");
                    }
                    Console.ReadKey();
                }
                if (Program.currentPlayer.health <= 0)
                {
                    //śmierć
                    Console.WriteLine(n + " zadaje Ci ostateczny cios");
                    Console.WriteLine(" KONIEC GRY ");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }

            int c = rand.Next(10, 50);
            Console.WriteLine(" Pokonujesz przeciwnika, sprawdzając jego truchło znajdujesz " + c + " bryłek rudy");
            Program.currentPlayer.coins += c;
            Console.WriteLine("Obecnie masz " + Program.currentPlayer.coins + " bryłek rudy");
            Console.WriteLine("Naciśnij ENTER by kontynuować");
            Console.ReadKey();
        }

        public static string GetName()
        {
            switch (rand.Next(0, 18))
            {
                case 0:
                    return "Ścierwojad";
                case 1:
                    return "Krwiopijca";
                case 2:
                    return "Goblin";
                case 3:
                    return "Kretoszczur";
                case 4:
                    return "Wilk";
                case 5:
                    return "Topielec";
                case 6:
                    return "Szkielet";
                case 7:
                    return "Zombie";
                case 8:
                    return "Demon";
                case 9:
                    return "TrolL";
                case 10:
                    return "Pełzacz";
                case 11:
                    return "Harpia";
                case 12:
                    return "Golem";
                case 13:
                    return "Zębacz";
                case 14:
                    return "Cierniostwór";
                case 15:
                    return "Pełzacz";
                case 16:
                    return "Golem";
                case 17:
                    return "Wąż błotny";
            }

            return "Zbir";
        }

    }
}
