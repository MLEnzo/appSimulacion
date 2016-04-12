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
            if (Convert.ToInt32(txbSemilla.Text) >= 101)   //comprueba si es mayor o igua a 101
            {

                var x0 = Convert.ToInt32(txbSemilla.Text); //inicializa variables
                int gen;
                string s = "";
                string sus = "";




                gen = x0 * x0;                            //realiza operacion cuadrados
                int d = (Convert.ToString(gen)).Length;   //obtiene numeros de digitos 

                

                if (d < 8) {                                //comprueba si es mayor a 8 digitos
                    int j = 8 - d;
                    for (int i = 0; i < j; i++)           //un for que agrega ceros depende de los digitos
                    {
                        s = s + "0";
                    }

                    sus = s + (Convert.ToString(gen));
                }
                int ultdig = (Convert.ToInt32(sus.Length)) - 4;
                string sus2 = sus.Substring(2, ultdig);



                //txbSucesion.Text = Convert.ToString(gen); //convierte el resultado a string para mostrar en pantalla
                txbSucesion.Text = sus + " " + sus2; }
        

                    else {
                        txbSucesion.Text = "";         //vacia o no mustra la sucecion si se efectua un error
                    }//termina else de if(semilla>101)

                } //termina while
            
            }
        }



