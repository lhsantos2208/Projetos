using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Olá!","Olá, " + txtNome.Text + "!","Ok");
        }

        private void btnImagem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Imagem());
        }

        private void btnTexti_Clicked(object sender, EventArgs e)
        {
            var Navegacao = new Paginas.Texto();
            Navigation.PushModalAsync(Navegacao);
        }

        private void btnEventos_Pressed(object sender, EventArgs e)
        {
            lblEventos.Text = "Pressionado!";
        }

        private void btnEventos_Released(object sender, EventArgs e)
        {
            lblEventos.Text = "Liberado!";
        }
    }
}
