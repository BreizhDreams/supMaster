namespace supMaster.Model
{
    public class Colonne
    {
        private string _nom;

        public Colonne(string leNom)
        {
            this.Nom = leNom;
        }

        public string Nom { get => _nom; set => _nom = value; }
    }
}
