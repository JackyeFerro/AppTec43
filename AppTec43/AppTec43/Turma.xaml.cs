using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTec43
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Turma : ContentPage
	{
        string aluno;
		public Turma ()
		{
			InitializeComponent ();
		}

        private void BtnAluno01_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno1";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno02_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno2";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno03_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno3";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno04_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno4";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno05_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno5";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno06_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno6";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno07_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno7";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno08_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno8";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno09_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno9";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno10_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno10";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno11_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno11";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }

        private void BtnAluno12_Clicked(object sender, EventArgs e)
        {
            aluno = "Aluno12";
            //navecaçao ate pegina do aluno
            Navigation.PushAsync(new Estoria(aluno));
        }
    }
}