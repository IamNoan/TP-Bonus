using System;

namespace Exercices
{
    public class Exo1
    {
        public static int[] des = new int[3]; //variable globale contenant la valeur des 3 dés

        public static void afficheGagne()
        {
            Console.WriteLine("You Win !");
        }

        public static void affichePerdu()
        {
            Console.WriteLine("You Lost :( !");
        }

        public static void afficheResDes()
        {
            Console.WriteLine("[{0}][{1}][{2}]", des[0], des[1], des[2]);
        }

        public static bool succes421()
        {
            bool is4 = false;
            bool is2 = false;
            bool is1 = false;

            foreach (int d in des)
            {
                if (d == 4) is4 = true;
                if (d == 2) is2 = true;
                if (d == 1) is1 = true;
            }

            return is4 && is2 && is1;
        }

        public static int lanceDe()
        {
            Random rand = new Random();
            return rand.Next(1,7);
        }

        public static void lanceDes()
        {
            des[0] = lanceDe();
            des[1] = lanceDe();
            des[2] = lanceDe();
        }

        public static void relanceDes()
        {
            for (int i = 1; i < 4; i++)
            {
                Console.Write("Relancer le de {0} ? ",i);
                string rep = Console.ReadLine();
                if (rep=="oui")
                {
                    des[i-1] = lanceDe();
                }
                else if (rep == "non")
                {
                }
                else
                {
                    throw new ArgumentException("invalid answer");
                }
            }
        }

        public static void main()
        {
            lanceDes();
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Resultat du lancement des des :");
                afficheResDes();
                relanceDes();
            }

            if (succes421())
            {
                afficheGagne();
            }
            else
            {
                Console.Write("Resultat du lancement des des :");
                afficheResDes();
                affichePerdu();
            }
        }
        
    }
}