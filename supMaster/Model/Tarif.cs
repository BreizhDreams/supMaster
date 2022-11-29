using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supMaster.Model
{
    public  class Tarif
    {
        #region Attributs
        private double _leTarif;
        private Support _leSupport;
        private Tranche _laTranche;
        public static List<Tarif> collTarif = new List<Tarif>();

        #endregion

        #region Constructeur
        public Tarif(double lePrix, Support leSupp, Tranche laTranche)
        {
            this.LeTarif= lePrix;
            this.LeSupport= leSupp;
            this.LaTranche= laTranche;
            collTarif.Add(this);
        }


        #endregion

        #region Getter Setter
        public double LeTarif { get => _leTarif; set => _leTarif = value; }
        public Support LeSupport { get => _leSupport; set => _leSupport = value; }
        public Tranche LaTranche { get => _laTranche; set => _laTranche = value; }
        #endregion

        #region Methodes

        #endregion
    }
}
