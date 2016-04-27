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

        private void rdbVonNeumann_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVonNeumann.Checked == true)
            {
                pnlVonNeumann.Visible = true;
                pnlFibonacci.Visible = false;
                

            }
            else { pnlVonNeumann.Visible = false; }
        }  //check de radio boton de von Neumann
        //agregar cantidad preferencial de numeros aleatorios (EN METODO VON NEUMANN)
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
            string sus4 = "";

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

            for (int i = 0; i <= sus3.Length; i++)
            {
                for (int j = 1; j < sus3.Length; j++)
                {
                    //agregar codigo para separar sucecion
                }
            }
            txbSucesion.Text = sus3.Substring(0, cant);





        }    //CODIGO METODO Von Neumann




        private void rdbFibonacci_CheckedChanged(object sender, EventArgs e) //check de radio boton de fibonacci
        {
            if (rdbFibonacci.Checked == true)
            {
                pnlFibonacci.Visible = true;
                pnlVonNeumann.Visible = false;

            }
            else { pnlFibonacci.Visible = false; }

        }

        private void btnGenerarFibo_Click(object sender, EventArgs e) //CODIGO METODO FIBONACCI
        {

            int v1, v2, A, n, sumaV, Vx, K;    //declaracion de variables

            v1 = Convert.ToInt32( txbVariable1.Text);      //asicnacion de variables
            v2 = Convert.ToInt32(txbVariable2.Text);
            A = Convert.ToInt32(txbNumeroA.Text);
            n = Convert.ToInt32(txbcantidadFibo.Text);

            txbSucesionFibo.Text = txbVariable1.Text + ", "+ txbVariable2.Text;  //muestra por primera ves los 2 primeros numeros aleatorios(ingresados por el usuario)

            for (int i = 1; i <= n; i++)  //for con condicion de bucle

            {


                sumaV = v1 + v2;  //suma variable v1 y v2


                if (sumaV <= A)   //determina el valor de K
                { K = -1; }
                else { K = 0; }

                Vx = sumaV + (K * A);  //formula generadora de N° aleatorio

                txbSucesionFibo.Text = txbSucesionFibo.Text + ", " + Vx;   //muestra el resultado

                v1 = v2;    //reasigna las variables
                v2 = Vx;
            }

        }
    }
}
      //generar interbalo  [a,b]   agregar codigo   [R1*(b-a)]+a
      /*  ejemplo: [0,7]
       *    susecion= 8, 0 , 3 etc...
       *    
       *    [8*(7-0)]+0 = 56  == se muestra "5, 6" , 0, 3 etc...
       */



