using System;

namespace Exercices
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Pour tester les exo de 1 a 3, faire ex_.main() avec _=numéro 
            //Exercice5 exercice5 = new Exercice5();
            //exercice5.Game();
            Exercice6 ex6 = new Exercice6();
            bool res = ex6.Dicho(51);
            Console.WriteLine(res);
        }
    }
}