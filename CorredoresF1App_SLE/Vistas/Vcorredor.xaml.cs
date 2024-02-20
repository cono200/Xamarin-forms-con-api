using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorredoresF1App_SLE.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorredoresF1App_SLE.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vcorredor : ContentPage
    {
        public Vcorredor()
        {
            InitializeComponent();
            BindingContext = new VMAPi(Navigation);
        }
    }
}