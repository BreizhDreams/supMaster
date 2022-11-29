using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supMaster.Model
{
    public class Support
    {
        #region Attributs
        private int _id;
        private string _nomSupport;
        private int _coutFixe;
        public static List<Support> collSupport = new List<Support>();
        private static List<Tranche> lesTranches;


        #endregion

        #region Constructeur
        public Support(int id, string nom, int coutFixe)
        {
            this.Id = id;
            this.NomSupport= nom;
            this.CoutFixe= coutFixe;
            collSupport.Add(this);
            LesTranches = new List<Tranche>();
            
        }

        #endregion

        #region Getter Setter
        public int Id { get => _id; set => _id = value; }
        public string NomSupport { get => _nomSupport; set => _nomSupport = value; }
        public int CoutFixe { get => _coutFixe; set => _coutFixe = value; }
        public static List<Tranche> LesTranches { get => lesTranches; set => lesTranches = value; }

        #endregion

        #region Methodes

        #endregion
    }
}
