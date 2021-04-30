using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace S2MaldonadoMarilyn
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void suma1_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Asignar valores desde xaml


                double dato1 = Convert.ToDouble(textonota1.Text);
                double dato2 = Convert.ToDouble(textonota2.Text);


                {
                    double suma = (dato1 * 0.3) + (dato2 * 0.2);
                    textototal1.Text = suma.ToString();
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", "ERROR" + ex.Message, "OK");
                throw;
            }
        }

        private void suma2_Clicked(object sender, EventArgs e)
        {
            try
            {
                //Asignar valores desde xaml

                double dato3 = Convert.ToDouble(textonota3.Text);
                double dato4 = Convert.ToDouble(textonota4.Text);

                double suma = (dato3 * 0.3) + (dato4 * 0.2);
                textototal2.Text = suma.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de Alerta", "ERROR" + ex.Message, "SALIO MAL");
                throw;
            }
        }

        private void suma3_Clicked(object sender, EventArgs e)
        {
            try
            {
                double dato5 = Convert.ToDouble(textototal1.Text);
                double dato6 = Convert.ToDouble(textototal2.Text);

                //accion sumar

                double suma3 = dato5 + dato6;
                total3.Text = suma3.ToString();

                if (suma3 > 7)
                {
                    string texto = total3.Text;
                    string mensaje = "APROBASTE CON " + texto;
                    DisplayAlert("Mensaje de alerta", mensaje, "SALIO MAL");
                }

                else
                {
                    string texto1 = total3.Text;
                    string mensaje1 = "REPROBASTE " + texto1;
                    DisplayAlert("Mensaje de alerta", mensaje1, " SALIO MAL");
                }
            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de alerta", "ERROR" + ex.Message, "ACEPTAR");

                throw;
            }
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;
            if (usuario == "estudiante2021" && clave == "uisrael2021")
            {
            }
            else
                DisplayAlert("Advertencia", "¡Datos ERRONEOS!", "OK");
        }
    }
}
