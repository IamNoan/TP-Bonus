using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace Exercices
{
    public class Exercice5
    {
        private List<string> mots;

        public void Init_list() //Initialise la liste en parametre a partir du fichier donné (les mots doivent etre sous la forme : "mot1 mot2 mot3 ..." dans le fichier
        {
            List<string> words = new List<string>();
            StreamReader reader = new StreamReader("Words");
            string s = reader.ReadLine();
            string[] arrayofwords = s.Split(" ");
            foreach (var word in arrayofwords)
            {
                words.Add(word);
            }
            reader.Close();
            mots = words;

        }

        public void PrintList() //Affiche la liste de mots possibles
        {
            int i=0;
            foreach (var mot in mots)
            {
                Console.WriteLine(i+" - "+mot+" ");
                i++;
            }
        }

        private void PrintWord(char[] wordarray) //Imprime le mot tel qu'il est découvert
        {
            foreach (var c in wordarray)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }

        public void Game() //Je n'ai pas divisé en plusieurs fonctions par soucis de besoin de variable tout du long de la fonction
        {
            Init_list();
            Random random = new Random();
            int randword = random.Next(mots.Count);
            string toguess = mots[randword]; //Recupere un mot aleatoire dans la liste de mot initialisée au dessus
            int len = toguess.Length;
            char[] toreveal = new char[len];
            for (int i = 0; i < len; i++) //Initialise un array correspondant au mot a réveler avec des * au départ
            {
                toreveal[i] = '*';
            }

            int j = 0;
            char[] wordarray = new char[len];
            foreach (var c in toguess) //Initialise un tableau correspondant au mot pour un parcours plus simple
            {
                wordarray[j] = c;
                j++;
            }
            Console.WriteLine("Welcome to Hangman !");
            Console.WriteLine("The word contains "+ len + " characters");
            Console.WriteLine("Please enter your guesses: ");
            int found = 0;
            int lives = 0;
            while (found<len && lives<8)
            {
                string c = Console.ReadLine();
                if (c.Length!=1)
                {
                    throw new ArgumentException("Invalid Character");
                }
                char ch = c.ToCharArray()[0]; //Récupere le charactere entré par l'utilisateur 
                bool inword = false;
                foreach (var letter in wordarray)
                {
                    if (letter==ch)
                    {
                        inword = true; // Trouve la lettre au moins une fois dans le mot
                        break;
                    }
                }

                if (inword) //Si lettre trouvée
                {
                    for (int i = 0; i < len; i++) //Parcours le mot et l'ajoute dans l'array toreaveal s'il le trouve
                    {
                        if (wordarray[i]==ch)
                        {
                            toreveal[i] = ch;
                            found++;
                        }
                    }
                    Console.WriteLine("Letter found ! Bravo !");
                    
                }
                else
                {
                    Console.WriteLine("Letter not found... Try again !");
                    PrintHangman(lives);
                    lives++;
                }
                PrintWord(toreveal);
                
            }

            if (lives<8)
            {
                Console.WriteLine("Vous avez gagné !");
            }
            else
            {
                Console.WriteLine("Vous avez perdu !");
            }

        }

        private void PrintHangman(int stade) //Fonction qui print le pendu
        {
            switch (stade)
            {
                case 1 :
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 2 :
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 3 :
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 4 :
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 5 :
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 6 :
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine(" /    |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 7 :
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine(" / \\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
            }
        }
    }
}