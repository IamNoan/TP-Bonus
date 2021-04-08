using System;

namespace Exercice7
{
    public class Crypto //Classe permettant l'implementation de type de cryptomonnaies avec un court changeant
    {
        private string name;
        private string shortname;
        private float actualvalue;

        public Crypto(string nom, string rac, float value)
        {
            name = nom;
            shortname = rac;
            actualvalue = value;
        }

        public float GetValue()
        {
            return actualvalue;
        }
        
        public string GetName()
        {
            return name;
        }
        public string GetShort()
        {
            return shortname;
        }
        public void Update() //Met a jour la valeur de la crypto aleatoirement
        {
            Random random = new Random();
            int diff; //valeur de changement du court, varie plus ou moins en fonction de change
            int change = random.Next(100); //Variable determinant le type de changement du court, leger, moyen ou fort en pourcentage
            if (change>95) //Gros changement
            {
                diff = random.Next(50, 120);
            }
            else if (change > 75) //Moyen changement
            {
                diff = random.Next(20,50);
            }
            else //Petit changement
            {
                diff = random.Next(10);
            }

            float fdiff = (float) diff; //difference en float pour pouvoir faire varier en fonction d'un pourcentage
            int plusorless = random.Next(2);
            if (plusorless==0) //augmente le cours
            {
                actualvalue = actualvalue + (actualvalue * (fdiff / 100));
            }
            else //reduit le cours
            {
                actualvalue = actualvalue - (actualvalue * (fdiff / 100));
            }
            
        }
    }
}