using System;

namespace Exercice7
{
    public class CompteBancaire 
    {
        private string devise; //En Euro
        private float solde; 
        private Client client;
        private Crypto _crypto; //Crypto utilisee sur ce compte
        private float soldecrypto; //Quantite de crypto sur le compte

        public CompteBancaire(string name, float initialsold, string type,float cryptosold, Crypto cryptotype)
        {
            string[] fullname = name.Split(" ");
            Random rand = new Random();
            this.client = new Client(fullname[0],rand.Next(10000),fullname[1]);
            solde = initialsold;
            devise = type;
            _crypto = cryptotype;
            soldecrypto = cryptosold;
        }

        #region Getteurs

        public string GetDevise()
        {
            return devise;
        }
        public float GetSolde()
        {
            return solde;
        }
        public Client GetTitulaire()
        {
            return client;
        }

        public Crypto GetCrypto()
        {
            return _crypto;
        }

        #endregion
        
        #region Setteurs

        public void SetDevise(string dev)
        {
            devise = dev;
        }

        #endregion

        #region Methods

        public void Crediter(float toAdd)
        {
            solde += toAdd;
            Console.WriteLine("Succesfully credited");
        }
        public bool Debiter(float toDebit)
        {
            if (solde<toDebit)
            {
                Console.Error.WriteLine("Couldn't debit the value");
                return false;
            }
            else
            {
                solde -= toDebit;
                Console.WriteLine("Succesfully debited");
                return true;
            }
        }

        public void Decrire()
        {
            Console.WriteLine("Ce compte est le compte de {0}, il y a actuellement {1} {2} sur le compte et {3} {4}",client.GetFullName(),solde,devise,soldecrypto,_crypto.GetShort());
        }

        public void CryptoToEur()
        {
            Console.WriteLine("{0} have " + soldecrypto * _crypto.GetValue() + " Euros in {1}",client.GetFullName(),_crypto.GetName());
        }

        #endregion
    }
}