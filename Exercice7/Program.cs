using System;

namespace Exercice7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Crypto Bitcoin = new Crypto("Bitcoin", "BTC", 47390.01f);
            Crypto Ethereum = new Crypto("Ethereum", "ETH", 1670.05f);
            Crypto DogeCoin = new Crypto("Dogecoin", "DOGE", 0.06f);
            CompteBancaire CompteJean = new CompteBancaire("Jean Paul", 0f, "EUR",0.004f,Bitcoin);
            CompteBancaire CompteThierry = new CompteBancaire("Thierry Simon", 8000.63f, "EUR",5f,Ethereum);
            CompteBancaire CompteElon = new CompteBancaire("Elon Musk",175000000000.0f,"EUR",500f,DogeCoin);
            /*Console.WriteLine("Combien souhaitez-vous ajouter d'argent ?");
            float toAdd = float.Parse(Console.ReadLine());
            Console.WriteLine("Combien souhaitez-vous retirer d'argent ?");
            float toDebit = float.Parse(Console.ReadLine());
            CompteJean.Crediter(toAdd);
            CompteJean.Debiter(toDebit);
            CompteJean.Decrire();
            
            Console.WriteLine("Combien souhaitez-vous transferer d'argent de Jean a Thierry ?");
            float transfert = float.Parse(Console.ReadLine());
            if (CompteJean.Debiter(transfert))
            {CompteJean.CryptoToEur();
                            CompteThierry.CryptoToEur();
                CompteThierry.Crediter(transfert);
            }*/
            CompteJean.Decrire();
            CompteThierry.Decrire();
            for (int i = 0; i < 5; i++)
            {
                CompteJean.CryptoToEur();
                CompteThierry.CryptoToEur();
                CompteElon.CryptoToEur();
                Bitcoin.Update();
                Ethereum.Update();
                DogeCoin.Update();
            }
            
            
        }
    }
}