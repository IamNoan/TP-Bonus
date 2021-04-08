namespace Exercice7
{
    public class Client
    {
        private string nom;
        private int numero;
        private string prenom;

        public Client(string nnom, int nnumero, string nprenom)
        {
            nom = nnom;
            prenom = nprenom;
            nnumero = numero;
        }

        #region Getteurs

        public string GetFullName()
        {
            return nom + " " + prenom;
        }

        public int GetNumber()
        {
            return numero;
        }

        #endregion
        
        
    }
}