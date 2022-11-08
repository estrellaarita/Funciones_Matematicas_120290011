using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Funciones_Matematicas.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class operaciones : ContentPage
    {
        public operaciones()
        {
            InitializeComponent();
        }

        private void sumar_Clicked(object sender, EventArgs e)
        {
            //Capturamos los datos ingresados por el usuario
            double nu1 = Convert.ToInt32(txtnum1.Text);
            double nu2 = Convert.ToInt32(txtnum2.Text);
            double suma = nu1 + nu2;
            //Mostramos el resultado mediante texto
            DisplayAlert("El total de la suma es:", suma.ToString(),"Cerrar");
        }

        private void restar_Clicked(object sender, EventArgs e)
        {
            //Capturamos los datos ingresados por el usuario
            int nu1 = Convert.ToInt32(txtnum1.Text);
            int nu2 = Convert.ToInt32(txtnum2.Text);
            int resta = nu1 - nu2;
            //Mostramos el resultado mediante texto
            DisplayAlert("El total de la resta es:", resta.ToString(), "Cerrar");
        }

        private void multiplicar_Clicked(object sender, EventArgs e)
        {
            //Capturamos los datos ingresados por el usuario
            int nu1 = Convert.ToInt32(txtnum1.Text);
            int nu2 = Convert.ToInt32(txtnum2.Text);
            int multiplicar = nu1 * nu2;
            //Mostramos el resultado mediante texto
            DisplayAlert("El total de la multiplicacion es:", multiplicar.ToString(), "Cerrar");
        }

        private void dividir_Clicked(object sender, EventArgs e)
        {
            //Capturamos los datos ingresados por el usuario
            double nu1 = Convert.ToInt32(txtnum1.Text);
            double nu2 = Convert.ToInt32(txtnum2.Text);
            double dividir = nu1 / nu2;
            //Mostramos el resultado mediante texto
            DisplayAlert("El total de la divicion es:", dividir.ToString(), "Cerrar");
        }
    }
}