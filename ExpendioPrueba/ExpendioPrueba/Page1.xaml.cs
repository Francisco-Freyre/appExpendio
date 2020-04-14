using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExpendioPrueba
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string u, string p)
        {
            InitializeComponent();

            lbl.Text = "Bienvenido " + u + "Contraseña " + p;
        }
    }
}