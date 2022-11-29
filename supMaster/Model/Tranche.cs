using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supMaster.Model
{
    public class Tranche
    {
        #region Attributs
        private int _id;
        private string _libelle;
        private int _nbMini;
        private int _nbMax;
        public static List<Tranche> CollTranche = new List<Tranche>();



        #endregion

        #region Constructeur
        public Tranche(int id, string libelle, int nbMin, int nbMax)
        {
            this.Id= id;
            this.Libelle= libelle;
            this.NbMini= nbMin;
            this.NbMax= nbMax;

            CollTranche.Add(this);
        }
        #endregion

        #region Getter Setter
        public int Id { get => _id; set => _id = value; }
        public string Libelle { get => _libelle; set => _libelle = value; }
        public int NbMini { get => _nbMini; set => _nbMini = value; }
        public int NbMax { get => _nbMax; set => _nbMax = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
