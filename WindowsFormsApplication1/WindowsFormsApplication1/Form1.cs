using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txbCant.Visible = false;
            lblMayorA100.Visible = false;
            txbCant.Text = "0";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        //agregar cantidad preferencial de numeros aleatorios
        private void cbxCantidad_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCantidad.Checked == true)
            {
                txbCant.Visible = true;
            }
            else {

                txbCant.Visible = false;
                
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            long  gen;
            string s = "";
            string sus = "";          //inicializa variables
            string sus3 = "";
            int cant;
           

            if (txbCant.Text == "")
            {                        //verifica si en caso de que el usuario ingrese vacio la sasilla de cantidad 
                cant = 4;
            }
            else {
                cant = Convert.ToInt32(txbCant.Text); //obtiene cantidad de numeros deseado
            }

            
            if (cant==0)
            {
                cant = 50;       //si el usuario no ingresa una cantidad deseada agregara por defecto una cantidad

            }

            var x0 = Convert.ToInt64(txbSemilla.Text);      //asegura que se puede ungresar hasta 19 digitos de numeros 9
            
            
            while (sus3.Length <= cant)    //comprueba si es mayor o igua a 101 y empieza bucle
            {
                lblMayorA100.Visible = false;
                if (x0 >= 101)
                {                                        //comprueba si es mayor o igua a 101 y empieza bucle
                    gen = x0 * x0;                      //realiza operacion cuadrados

                    var Generado = Convert.ToString(gen);
                    int d = Generado.Length;   //obtiene numeros de digitos 


                    s = "";
                    if (d < 8)
                    {                                //comprueba si es mayor a 8 digitos
                        int j = 8 - d;

                        for (int i = 0; i < j; i++)           //un for que agrega ceros depende de los digitos
                        {
                            s = s + "0";
                        }

                    }
                    
                    sus = s + Generado;
                    int ultdig = (Convert.ToInt32(sus.Length)) - 4;  // obtiene ultimo digito y lo resta por 4
                    string sus2 = sus.Substring(2, ultdig);          //numeros de posicion para sacar
                                                                     //los 2 ultimos ceros de la derecha
                    sus3 = sus3 + sus2;

                    //txbSucesion.Text = Convert.ToString(gen); //convierte el resultado a string para mostrar en pantalla
                   
                    x0 = Convert.ToInt64(sus2);
                }
                else {
                    //falta agregar label que indique que no es mayor a 101 la semilla ingresada
                    lblMayorA100.Visible = true;
                    break;
                }

            }
            txbSucesion.Text = sus3.Substring(0,cant);





        }    //CODIGO METODO Von Neumann

    }
}
      



