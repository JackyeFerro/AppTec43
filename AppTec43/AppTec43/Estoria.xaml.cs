using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTec43
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Estoria : ContentPage
	{
		public Estoria (string aluno)
		{
			InitializeComponent ();

            switch(aluno)
            {
                case "Aluno1":
                    vName.Text = "paulo babidi";
                    vFoto.Source = "https://i.ibb.co/LhxwN1v/Babidi-Icon.jpg";
                    vEstoria.Text = "haaaaaaaaaa inseto cabeludo";
                    break;                
                case "Aluno2":
                    vName.Text = "Yan";
                    vFoto.Source = "https://i.ibb.co/bKpTVgz/YanIcon.jpg";
                    vEstoria.Text = "po gente";
                    break;               
                case "Aluno3":
                    vName.Text = "moreti";
                    vFoto.Source = "https://i.ibb.co/qjBtgF0/moreti-Icon.jpg";
                    vEstoria.Text ="Aquela construção que é bem observada: a Construção Civil,";
                    break;                
                case "Aluno4":
                    vName.Text = "valerio";
                    vFoto.Source = "https://i.ibb.co/KrbmN7h/Valerioicon.jpg";
                    vEstoria.Text = "Mano olha essas musicas cara";
                    break;               
                case "Aluno5":
                    vName.Text = "pedro";
                    vFoto.Source = "https://i.ibb.co/LCRjs1g/Pedro-Icon.jpg";
                    vEstoria.Text = "mano vamo votar no João amoedo";
                    break;              
                case "Aluno6":
                    vName.Text = "uzaias";
                    vFoto.Source = "https://i.ibb.co/YN9WLr0/Uzaias-Icon.jpg";
                    vEstoria.Text = "moro cara moro";
                    break;                
                case "Aluno7":
                    vName.Text = "mirassol";
                    vFoto.Source = "https://i.ibb.co/qFjzMYm/mirassol-Icon.png";
                    vEstoria.Text = "Imagina se eu foce PM";
                    break;               
                case "Aluno8":
                    vName.Text = "espiga";
                    vFoto.Source = "https://i.ibb.co/TLtMCpJ/espigaverdadeira-Icon.jpg";
                    vEstoria.Text = "haaaaa cara para";
                    break;               
                case "Aluno9":
                    vName.Text = "vitor";
                    vFoto.Source = "https://i.ibb.co/KKY5vb7/Vitor-Icon.jpg";
                    vEstoria.Text = "mano vo tirar a carta sexta cara";
                    break;               
                case "Aluno10":
                    vName.Text = "seninha";
                    vFoto.Source = "https://i.ibb.co/t8v87KY/seninha-Icon.jpg";
                    vEstoria.Text = "stop man";
                    break;              
                case "Aluno11":
                    vName.Text = "yuri";
                    vFoto.Source = "https://i.ibb.co/0CrSdxB/YuriIcon.jpg";
                    vEstoria.Text = "sou otaku mesmo";
                    break;                
                case "Aluno12":
                    vName.Text = "Zé o sabio";
                    vFoto.Source = "https://i.ibb.co/G7tb48g/sabio-Icon.jpg";
                    vEstoria.Text = "O amor é a sabedoria dos loucos e a loucura dos sábios.";
                    break;
                default:
                    break;
                  
            }
		}

        private async void BtnNarrar_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync(vEstoria.Text);
        }
    }
}