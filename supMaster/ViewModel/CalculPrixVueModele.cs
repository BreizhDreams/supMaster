using supMaster.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace supMaster.ViewModel
{
    public class CalculPrixVueModele : BaseVueModele
    {
        #region Attributs
        private ObservableCollection<Support> _lesSupports;
        private ObservableCollection<Tranche> _lesTranches;
        private ObservableCollection<Tarif> _lesTarifs;
        private double _prixConfig;
        private ObservableCollection<Colonne> _lesColonneList;
        private ObservableCollection<Colonne> _lesColonneList2;
        private ObservableCollection<Colonne> _col3;
        private ObservableCollection<Colonne> _col4;
        private ObservableCollection<Colonne> _col5;
        private ObservableCollection<Colonne> _col6;
        private ObservableCollection<Colonne> _col7;
        private ObservableCollection<Colonne> _col8;
        private ObservableCollection<Colonne> _col9;
        private ObservableCollection<Colonne> _col10;

        #endregion

        #region Constructeur
        public CalculPrixVueModele()
        {
            LesSupports= new ObservableCollection<Support>();
            LesTranches= new ObservableCollection<Tranche>();
            LesTarifs = new ObservableCollection<Tarif>();
            LesColonneList= new ObservableCollection<Colonne>();
            LesColonneList2=new ObservableCollection<Colonne>();
            Col3 = new ObservableCollection<Colonne>();
            Col4 = new ObservableCollection<Colonne>();
            Col5 = new ObservableCollection<Colonne>();
            Col6 = new ObservableCollection<Colonne>();
            Col7 = new ObservableCollection<Colonne>();
            Col8 = new ObservableCollection<Colonne>();
            Col9 = new ObservableCollection<Colonne>();
            Col10 = new ObservableCollection<Colonne>();

            AddConfig();
        }


        #endregion

        #region Getter Setter
        public ObservableCollection<Support> LesSupports
        {
            get { return _lesSupports;}
            set { SetProperty(ref _lesSupports, value); }
        }
        public ObservableCollection<Tranche> LesTranches
        {
            get { return _lesTranches; }
            set { SetProperty(ref _lesTranches, value); }
        }
        public ObservableCollection<Tarif> LesTarifs
        {
            get { return _lesTarifs; }
            set { SetProperty(ref _lesTarifs, value); }
        }

        public double PrixConfig
        {
            get { return _prixConfig; }
            set { SetProperty(ref _prixConfig, value); }
        }


        public ObservableCollection<Colonne> LesColonneList
        {
            get { return _lesColonneList; }
            set { SetProperty(ref _lesColonneList, value); }
        }

        public ObservableCollection<Colonne> LesColonneList2
        {
            get { return _lesColonneList2; }
            set { SetProperty(ref _lesColonneList2, value); }
        }

        public ObservableCollection<Colonne> Col3
        {
            get { return _col3; }
            set { SetProperty(ref _col3, value); }
        }
        public ObservableCollection<Colonne> Col4
        {
            get { return _col4; }
            set { SetProperty(ref _col4, value); }
        }
        public ObservableCollection<Colonne> Col5
        {
            get { return _col5; }
            set { SetProperty(ref _col5, value); }
        }
        public ObservableCollection<Colonne> Col6
        {
            get { return _col6; }
            set { SetProperty(ref _col6, value); }
        }
        public ObservableCollection<Colonne> Col7
        {
            get { return _col7; }
            set { SetProperty(ref _col7, value); }
        }
        public ObservableCollection<Colonne> Col8
        {
            get { return _col8; }
            set { SetProperty(ref _col8, value); }
        }
        public ObservableCollection<Colonne> Col9
        {
            get { return _col9; }
            set { SetProperty(ref _col9, value); }
        }
        public ObservableCollection<Colonne> Col10
        {
            get { return _col10; }
            set { SetProperty(ref _col10, value); }
        }
        #endregion

        #region Methodes
        public void AddConfig()
        {
            Support download = new Support(1,"Telechargement (csv,xls)",5);
            Support cd_rom = new Support(2,"CD-ROM (toute quantité; csv,xls)",30);
            Support papier = new Support(3,"Liste Papier",30);
            Support etiquette = new Support(4,"Etiquette",30);

            LesSupports.Add(download);
            LesSupports.Add(cd_rom);
            LesSupports.Add(papier);
            LesSupports.Add(etiquette);

            Tranche T1 = new Tranche(1, "De 1 à 2499", 1, 2499);
            Tranche T2 = new Tranche(2, "De 2500 à 4999", 2500, 4999);
            Tranche T3 = new Tranche(3, "De 5000 à 9999", 5000, 9999);
            Tranche T4 = new Tranche(4, "De 10000 à 14999", 10000, 14999);
            Tranche T5 = new Tranche(5, "De 15000 à 24999", 15000, 24999);
            Tranche T6 = new Tranche(6, "De 25000 à 49999", 25000, 49999);
            Tranche T7 = new Tranche(7, "De 50000 à 99999", 50000, 99999);
            Tranche T8 = new Tranche(8, "Au delà de 100000 adresses", 100000, 10000000);

            LesTranches.Add(T1);
            LesTranches.Add(T2);
            LesTranches.Add(T3);
            LesTranches.Add(T4);
            LesTranches.Add(T5);
            LesTranches.Add(T6);
            LesTranches.Add(T7);
            LesTranches.Add(T8);

            Tarif tel1 = new Tarif(0.33, download, T1);
            Tarif tel2 = new Tarif(0.30, download, T2);
            Tarif tel3 = new Tarif(0.26, download, T3);
            Tarif tel4 = new Tarif(0.23, download, T4);
            Tarif tel5 = new Tarif(0.21, download, T5);
            Tarif tel6 = new Tarif(0.19, download, T6);
            Tarif tel7 = new Tarif(0.16, download, T7);
            Tarif tel8 = new Tarif(0.14, download, T8);
            LesTarifs.Add(tel1);
            LesTarifs.Add(tel2);
            LesTarifs.Add(tel3);
            LesTarifs.Add(tel4);
            LesTarifs.Add(tel5);
            LesTarifs.Add(tel6);
            LesTarifs.Add(tel7);
            LesTarifs.Add(tel8);

            Tarif cd1 = new Tarif(0.33, cd_rom, T1);
            Tarif cd2 = new Tarif(0.30, cd_rom, T2);
            Tarif cd3 = new Tarif(0.26, cd_rom, T3);
            Tarif cd4 = new Tarif(0.23, cd_rom, T4);
            Tarif cd5 = new Tarif(0.21, cd_rom, T5);
            Tarif cd6 = new Tarif(0.19, cd_rom, T6);
            Tarif cd7 = new Tarif(0.16, cd_rom, T7);
            Tarif cd8 = new Tarif(0.14, cd_rom, T8);
            LesTarifs.Add(cd1);
            LesTarifs.Add(cd2);
            LesTarifs.Add(cd3);
            LesTarifs.Add(cd4);
            LesTarifs.Add(cd5);
            LesTarifs.Add(cd6);
            LesTarifs.Add(cd7);
            LesTarifs.Add(cd8);

            Tarif pap1 = new Tarif(0.23, papier, T1);
            Tarif pap2 = new Tarif(0.20, papier, T2);
            Tarif pap3 = new Tarif(0.18, papier, T3);
            Tarif pap4 = new Tarif(0.16, papier, T4);
            Tarif pap5 = new Tarif(0.15, papier, T5);
            Tarif pap6 = new Tarif(0.14, papier, T6);
            Tarif pap7 = new Tarif(0.13, papier, T7);
            Tarif pap8 = new Tarif(0.12, papier, T8);
            LesTarifs.Add(pap1);
            LesTarifs.Add(pap2);
            LesTarifs.Add(pap3);
            LesTarifs.Add(pap4);
            LesTarifs.Add(pap5);
            LesTarifs.Add(pap6);
            LesTarifs.Add(pap7);
            LesTarifs.Add(pap8);

            Tarif etiq1 = new Tarif(0.19, etiquette, T1);
            Tarif etiq2 = new Tarif(0.17, etiquette, T2);
            Tarif etiq3 = new Tarif(0.15, etiquette, T3);
            Tarif etiq4 = new Tarif(0.13, etiquette, T4);
            Tarif etiq5 = new Tarif(0.11, etiquette, T5);
            Tarif etiq6 = new Tarif(0.10, etiquette, T6);
            Tarif etiq7 = new Tarif(0.09, etiquette, T7);
            Tarif etiq8 = new Tarif(0.08, etiquette, T8);
            LesTarifs.Add(etiq1);
            LesTarifs.Add(etiq2);
            LesTarifs.Add(etiq3);
            LesTarifs.Add(etiq4);
            LesTarifs.Add(etiq5);
            LesTarifs.Add(etiq6);
            LesTarifs.Add(etiq7);
            LesTarifs.Add(etiq8);


            #region Peuplement Colonne
            LesColonneList.Add(new Colonne("Selon Supports "));
            LesColonneList.Add(new Colonne(download.NomSupport));
            LesColonneList.Add(new Colonne(cd_rom.NomSupport));
            LesColonneList.Add(new Colonne(papier.NomSupport));
            LesColonneList.Add(new Colonne(etiquette.NomSupport));

            LesColonneList2.Add(new Colonne(T1.Libelle));
            LesColonneList2.Add(new Colonne(tel1.LeTarif.ToString()));
            LesColonneList2.Add(new Colonne(cd1.LeTarif.ToString()));
            LesColonneList2.Add(new Colonne(pap1.LeTarif.ToString()));
            LesColonneList2.Add(new Colonne(etiq1.LeTarif.ToString()));

            Col3.Add(new Colonne(T2.Libelle));
            Col3.Add(new Colonne(tel2.LeTarif.ToString()));
            Col3.Add(new Colonne(cd2.LeTarif.ToString()));
            Col3.Add(new Colonne(pap2.LeTarif.ToString()));
            Col3.Add(new Colonne(etiq2.LeTarif.ToString()));

            Col4.Add(new Colonne(T3.Libelle));
            Col4.Add(new Colonne(tel3.LeTarif.ToString()));
            Col4.Add(new Colonne(cd3.LeTarif.ToString()));
            Col4.Add(new Colonne(pap3.LeTarif.ToString()));
            Col4.Add(new Colonne(etiq3.LeTarif.ToString()));

            Col5.Add(new Colonne(T4.Libelle));
            Col5.Add(new Colonne(tel4.LeTarif.ToString()));
            Col5.Add(new Colonne(cd4.LeTarif.ToString()));
            Col5.Add(new Colonne(pap4.LeTarif.ToString()));
            Col5.Add(new Colonne(etiq4.LeTarif.ToString()));

            Col6.Add(new Colonne(T5.Libelle));
            Col6.Add(new Colonne(tel5.LeTarif.ToString()));
            Col6.Add(new Colonne(cd5.LeTarif.ToString()));
            Col6.Add(new Colonne(pap5.LeTarif.ToString()));
            Col6.Add(new Colonne(etiq5.LeTarif.ToString()));

            Col7.Add(new Colonne(T6.Libelle));
            Col7.Add(new Colonne(tel6.LeTarif.ToString()));
            Col7.Add(new Colonne(cd6.LeTarif.ToString()));
            Col7.Add(new Colonne(pap6.LeTarif.ToString()));
            Col7.Add(new Colonne(etiq6.LeTarif.ToString()));

            Col8.Add(new Colonne(T7.Libelle));
            Col8.Add(new Colonne(tel7.LeTarif.ToString()));
            Col8.Add(new Colonne(cd7.LeTarif.ToString()));
            Col8.Add(new Colonne(pap7.LeTarif.ToString()));
            Col8.Add(new Colonne(etiq7.LeTarif.ToString()));

            Col9.Add(new Colonne(T8.Libelle));
            Col9.Add(new Colonne(tel8.LeTarif.ToString()));
            Col9.Add(new Colonne(cd8.LeTarif.ToString()));
            Col9.Add(new Colonne(pap8.LeTarif.ToString()));
            Col9.Add(new Colonne(etiq8.LeTarif.ToString()));

            Col10.Add(new Colonne("Prix Facturés en Euros"));
            Col10.Add(new Colonne(download.CoutFixe.ToString()));
            Col10.Add(new Colonne(cd_rom.CoutFixe.ToString()));
            Col10.Add(new Colonne(papier.CoutFixe.ToString()));
            Col10.Add(new Colonne(etiquette.CoutFixe.ToString()));

            #endregion
        }

        public double calculPrixTotal(int nbDoc,Support leSupport)
        {
            foreach(Tranche laTranche in LesTranches)
            {
                foreach(Support leSupp in LesSupports)
                {
                    if(leSupport == leSupp)
                    {
                        if (nbDoc >= laTranche.NbMini && nbDoc <= laTranche.NbMax)
                        {
                            foreach(Tarif lePrix in LesTarifs)
                            {
                                if(lePrix.LeSupport==leSupp && lePrix.LaTranche == laTranche)
                                {
                                    PrixConfig = (nbDoc * lePrix.LeTarif) + leSupp.CoutFixe;
                                }
                            }
                        }
                    }
                }
            }
            return Math.Round(PrixConfig,1);
        }

        #endregion
    }
}
