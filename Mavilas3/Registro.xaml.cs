using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mavilas3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
       // aqui declaro los datos que va a recibir
        public Registro(string datoUno,string datpDOS)
        {
            InitializeComponent();
            lblDatouno.Text = datoUno;
            txtDatoDos.Text = datpDOS;
        }
    }
}