using supMaster.Model;
using supMaster.ViewModel;

namespace supMaster.View;

public partial class CalculPrixVue : ContentPage
{
    CalculPrixVueModele vueModele;
    public CalculPrixVue()
	{
		
		InitializeComponent();
		BindingContext = vueModele = new CalculPrixVueModele();

		
	}
    
    private void calculPrix_Clicked(object sender, EventArgs e)
    {
        
        int i = 0;
        if(int.TryParse(nbDocUser.Text, out i) == true)
        {
            if ((cBoxCDROM.IsChecked || cBoxEtiquette.IsChecked || cBoxListe.IsChecked || cBoxTelechargement.IsChecked) && nbDocUser.Text != null)
            {
                foreach (Support leSupp in Support.collSupport)
                {
                    if (leSupp.NomSupport.Contains(verifSupport(cBoxCDROM.IsChecked, cBoxListe.IsChecked, cBoxTelechargement.IsChecked, cBoxEtiquette.IsChecked)))
                    {
                        vueModele.calculPrixTotal(int.Parse(nbDocUser.Text), leSupp);
                    }
                }

            }
            else
            {
                DisplayAlert("Erreur", "Veuillez saisir une valeur et choisir un Type", "OK");
            }
        }
        else
        {
            DisplayAlert("Erreur", "Veuillez saisir un entier avant de Valider", "J'AI COMPRIS");
        }


    }

    private string verifSupport(bool cdRom, bool list, bool tele, bool etiquette)
    {
        string result = "";
        if(cdRom)
        {
            result = "CD-ROM";
        }
        else if(list)
        {
            result = "Liste";
        }
        else if(tele)
        {
            result = "Tele";
        }
        else
        {
            result = "Etiquette";
        }
        return result;
        
    }

    private void verifCheckBoxCDROM(object sender, CheckedChangedEventArgs e)
    {
        CheckBox laCheckBox = sender as CheckBox;
        if(laCheckBox == cBoxCDROM && laCheckBox.IsChecked==true)
        {
            cBoxEtiquette.IsEnabled= false;
            cBoxListe.IsEnabled = false;
            cBoxTelechargement.IsEnabled=false;
        }
        else
        {
            cBoxEtiquette.IsEnabled = true;
            cBoxListe.IsEnabled = true;
            cBoxTelechargement.IsEnabled = true;
        }
    }

    private void verifCheckBoxTelechargement(object sender, CheckedChangedEventArgs e)
    {
        CheckBox laCheckBox = sender as CheckBox;
        if (laCheckBox == cBoxTelechargement && laCheckBox.IsChecked == true)
        {
            cBoxEtiquette.IsEnabled = false;
            cBoxListe.IsEnabled = false;
            cBoxCDROM.IsEnabled = false;
        }
        else
        {
            cBoxEtiquette.IsEnabled = true;
            cBoxListe.IsEnabled = true;
            cBoxCDROM.IsEnabled = true;
        }
    }

    private void verifCheckBoxListe(object sender, CheckedChangedEventArgs e)
    {
        CheckBox laCheckBox = sender as CheckBox;
        if (laCheckBox == cBoxListe && laCheckBox.IsChecked == true)
        {
            cBoxEtiquette.IsEnabled = false;
            cBoxCDROM.IsEnabled = false;
            cBoxTelechargement.IsEnabled = false;
        }
        else
        {
            cBoxEtiquette.IsEnabled = true;
            cBoxCDROM.IsEnabled = true;
            cBoxTelechargement.IsEnabled = true;
        }
    }

    private void verifCheckBoxEtiquette(object sender, CheckedChangedEventArgs e)
    {
        CheckBox laCheckBox = sender as CheckBox;
        if (laCheckBox == cBoxEtiquette && laCheckBox.IsChecked == true)
        {
            cBoxCDROM.IsEnabled = false;
            cBoxListe.IsEnabled = false;
            cBoxTelechargement.IsEnabled = false;
        }
        else
        {
            cBoxCDROM.IsEnabled = true;
            cBoxListe.IsEnabled = true;
            cBoxTelechargement.IsEnabled = true;
        }
    }
}