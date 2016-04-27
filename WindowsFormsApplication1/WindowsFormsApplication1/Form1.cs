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
            lblIngreseV1yV22.Visible = false;
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
            else
            {

                txbCant.Visible = false;

            }
        }

        private void cbxIndicarInterVN_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIndicarInterVN.Checked == true)
            {
                lblCorch1.Visible = true;
                txbInter1VN.Visible = true;
                lblComa.Visible = true;
                txbInter2VN.Visible = true;
                lblCorch2.Visible = true;
            }
            else
            {
                lblCorch1.Visible = false;
                txbInter1VN.Visible = false;
                lblComa.Visible = false;
                txbInter2VN.Visible = false;
                lblCorch2.Visible = false;
                txbInter1VN.Text = "0";
                txbInter2VN.Text = "9";
            }
        } //indicar intevalo preferencial en Von Neuman

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            long gen;
            string s = "";
            string sus = "";          //inicializa variables
            string sus3 = "";
            string sus4 = "";
            int a = Convert.ToInt32(txbInter1VN.Text);
            int b = Convert.ToInt32(txbInter2VN.Text);
            string su = "";
            int cant;


            if (txbCant.Text == "")
            {                        //verifica si en caso de que el usuario ingrese vacio la sasilla de cantidad 
                cant = 4;
            }
            else
            {
                cant = Convert.ToInt32(txbCant.Text); //obtiene cantidad de numeros deseado
            }


            if (cant == 0)
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
                else
                {
                    //falta agregar label que indique que no es mayor a 101 la semilla ingresada
                    lblMayorA100.Visible = true;
                    break;
                }

            }


            for (int i = 0; i < cant; i++)                      //for que genera suscesion por un intebalo
            {
                int r = Convert.ToInt32(sus3.Substring(i, 1));
                int R1 = (r * (b - a)) + a;
                su = su + Convert.ToString(R1);
            }


            for (int i = 0; i < cant - 1; i++)               //for que separa los numeros aleatorios de la sucesion
            {
                sus4 = sus4 + su.Substring(i, 1) + ", ";


            }
            sus4 = sus4 + su.Substring(cant, 1); //agrega la ultima sucesion faltante
            txbSucesion.Text = sus4;//muestra por pantalla la sucesion final obtenida





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


        private void cbxIndicarInterbFibo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxIndicarInterbFibo.Checked == true)
            {
                lblCorchFibo.Visible = true;
                txbInterb1Fibo.Visible = true;
                lblComaFibo.Visible = true;
                txbInterb2Fibo.Visible = true;
                lblCorch2Fibo.Visible = true;

            }
            else
            {
                lblCorchFibo.Visible = false;
                txbInterb1Fibo.Visible = false;
                lblComaFibo.Visible = false;
                txbInterb2Fibo.Visible = false;
                lblCorch2Fibo.Visible = false;
                txbInterb1Fibo.Text = "0";
                txbInterb2Fibo.Text = "9";
            }
        }  //indicar intevalo preferencial en Fibonacci


        private void btnGenerarFibo_Click(object sender, EventArgs e) //CODIGO METODO FIBONACCI
        {
            txbSucesionFibo.Text = "";
            int v1, v2, A, n, sumaV, Vx, K;    //declaracion de variables
                                               //asignacion de variables
            if (txbVariable1.Text == "")
            {
                v1 = 0;
            }
            else { v1 = Convert.ToInt32(txbVariable1.Text); }
            if (txbVariable2.Text == "")
            {
                v2 = 0;
            }
            else { v2 = Convert.ToInt32(txbVariable2.Text); }
            if (txbNumeroA.Text == "")
            {
                A = 0;
            }
            else { A = Convert.ToInt32(txbNumeroA.Text); }
            if (txbcantidadFibo.Text == "")
            {
                n = 50;
            }
            else { n = Convert.ToInt32(txbcantidadFibo.Text); }

            
            string sus = "";
            string sus2 = "";
            string sus3 = "";
            string sus4 = "";
            string sus5 = "";

            int ind = txbVariable1.TextLength + txbVariable2.TextLength;

            sus4 = txbVariable1.Text + txbVariable2.Text;

            int a = Convert.ToInt32(txbInterb1Fibo.Text);
            int b = Convert.ToInt32(txbInterb2Fibo.Text);

            

            for (int i = 0; i < (txbVariable1.TextLength); i++)                                           //separa los 2 primeros numeros aleatorios(ingresados por el usuario)
            {
                sus3 = sus3 + (txbVariable1.Text.Substring(i, 1)) + ", ";
            }
            for (int i = 0; i < (txbVariable2.TextLength)-1; i++)
            {
                sus3 = sus3 + (txbVariable2.Text.Substring(i, 1)) + ", ";
            }

            sus3 = sus3 + (txbVariable2.Text.Substring((txbVariable1.TextLength)-1, 1));


            if (v1 == 0)                                                  
            {
                if (v2 == 0) { lblIngreseV1yV22.Visible = true ; }     //condiciona si la variable 1 y 2 es cero aparezca un mensaje de Error


            }
            else                                                       
            {

                if (n == 0)                                         //condiciona si el n ingresado es igual a cero muestra los primeros numeros ingresados
                {
                    txbcantidadFibo.Text = sus3;
                }
                else                                               //ejecuta el siguiente codigo si no se cumplen las demas condiciones
                {
                    for (int i = 1; i <= n; i++)  //for con codigo principal de fibo

                    {


                        sumaV = v1 + v2;  //suma variable v1 y v2


                        if (sumaV <= A)   //determina el valor de K
                        { K = 0; }
                        else { K = -1; }

                        Vx = sumaV + (K * A);  //formula generadora de N° aleatorio

                        sus = sus + Convert.ToString(Vx);   //muestra el resultado

                        v1 = v2;    //reasigna las variables
                        v2 = Vx;
                    }

                    sus4 = sus4 + sus;
                    for (int i = 0; i < (n - 1); i++)                      //for que genera suscesion por un intebalo
                    {
                        int r = Convert.ToInt32(sus4.Substring(i, 1));
                        int R1 = (r * (b - a)) + a;
                        sus5 = sus5 + Convert.ToString(R1);
                    }


                    if (((n) - ind) == 1)                                   //condicion para agregar un unico elemento a la suscesion 
                    {
                        sus2 = sus2 + sus5.Substring(((n - ind) - 1), 1);
                    }
                    else
                    {

                        for (int i = 0; i < ((n) - ind) - 1; i++)               //for que separa los numeros aleatorios de la sucesion
                        {
                            sus2 = sus2 + sus5.Substring(i, 1) + ", ";
                        }
                        sus2 = sus2 + sus5.Substring((n - 1), 1);
                    }

                    txbSucesionFibo.Text = sus3 +", "+ sus2; //muestra la sucesion final obtenida
                }


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


    //falta agregar condicion cuando n sea menor o igual que la cantidad de elementos ingresados por el usuario que ingresa


