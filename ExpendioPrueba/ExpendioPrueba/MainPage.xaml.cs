using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExpendioPrueba
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        SqlConnection conexion = new SqlConnection("data source = 192.168.0.2; initial catalog = sistemaVentas; user id = valles; password = valles");
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnInicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page1(EnUser.Text, EnPass.Text));
        }

        private async void btnConexion_Clicked(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                await DisplayAlert("Correcto", "Conexion correcta", "Aceptar");
            }
            catch (Exception )
            {
               // Console.WriteLine(e.Message);
                await DisplayAlert("Error", "No nos pudimos conectar", "Aceptar");
            }
        }
    }
}
