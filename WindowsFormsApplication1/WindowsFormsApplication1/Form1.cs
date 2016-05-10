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
    public partial class appGeneradores : Form
    {
        public appGeneradores()
        {
            InitializeComponent();
            txbCant.Visible = false;
            lblMayorA100.Visible = false;
            txbCant.Text = "0";
            lblIngreseV1yV22.Visible = false;
            //intervalo VM
            cbxIndicarInterVN.Checked = false;
            lblCorch1.Visible = false;
            txbInter1VN.Visible = false;
            lblComa.Visible = false;
            txbInter2VN.Visible = false;
            lblCorch2.Visible = false;
            txbInter1VN.Text = "0";
            txbInter2VN.Text = "9";
            //intervalo Fibo
            cbxIndicarInterbFibo.Checked = false;
            lblCorchFibo.Visible = false;
            txbInterb1Fibo.Visible = false;
            lblComaFibo.Visible = false;
            txbInterb2Fibo.Visible = false;
            lblCorch2Fibo.Visible = false;
            txbInterb1Fibo.Text = "0";
            txbInterb2Fibo.Text = "9";

        }

        private void rdbVonNeumann_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbVonNeumann.Checked == true)
            {
                pnlVonNeumann.Visible = true;
                pnlFibonacci.Visible = false;
                pnlMultiplicativo.Visible = false;
                rdbCongruenciaAditivo.Visible = false;
                rdbCongruenciaMultiplicativo.Visible = false;
                rdbCongruenciaMixto.Visible = false;


            }
            else { pnlVonNeumann.Visible = false; }
        }  //check de radio boton de von Neumann

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
        }//agregar cantidad preferencial de numeros aleatorios (EN METODO VON NEUMANN)

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

            if (cbxIndicarInterVN.Checked == true)
            {
                for (int i = 0; i < cant; i++)                      //for que genera suscesion por un intebalo
                {
                    int r = Convert.ToInt32(sus3.Substring(i, 1));
                    int R1 = (r * (b - a)) + a;
                    su = su + Convert.ToString(R1);
                }
            }
            else { su = sus3; }



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
                pnlMultiplicativo.Visible = false;
                rdbCongruenciaAditivo.Visible = false;
                rdbCongruenciaMultiplicativo.Visible = false;
                rdbCongruenciaMixto.Visible = false;

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
            bool m;


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






            if (v1 == 0)
            {
                if (v2 == 0) { lblIngreseV1yV22.Visible = true; }     //condiciona si la variable 1 y 2 es cero aparezca un mensaje de Error


            }
            else
            {
                if (n == 0)
                {

                    for (int i = 0; i < (txbVariable1.TextLength); i++)                                           //condiciona si el n ingresado es igual a cero muestra los 2 primeros numeros aleatorios(ingresados por el usuario)
                    {
                        sus3 = sus3 + (txbVariable1.Text.Substring(i, 1)) + ", ";
                    }
                    for (int i = 0; i < (txbVariable2.TextLength) - 1; i++)
                    {
                        sus3 = sus3 + (txbVariable2.Text.Substring(i, 1)) + ", ";
                    }

                    sus3 = sus3 + (txbVariable2.Text.Substring((txbVariable1.TextLength) - 1, 1));
                    //agegar condicion de intervalo en N=0
                    txbSucesionFibo.Text = sus3;

                }
                else
                {
                    if (n == ind)                                         //condiciona si el n ingresado es igual muestra los primeros numeros ingresados
                    {
                        if (cbxIndicarInterbFibo.Checked == true)
                        {
                            for (int i = 0; i < (n - 1); i++)                      //for que genera suscesion por un intebalo
                            {
                                int r = Convert.ToInt32(sus4.Substring(i, 1));
                                int R1 = (r * (b - a)) + a;
                                sus5 = sus5 + Convert.ToString(R1);
                            }

                        }
                        else { sus5 = sus4; }

                        for (int i = 0; i < n - 1; i++)
                        {
                            sus3 = sus3 + sus5.Substring(i, 1) + ", ";
                        }
                        sus3 = sus3 + sus4.Substring(n - 1, 1);


                        txbSucesionFibo.Text = sus3;


                    }
                    else
                    {

                        if (n < ind)                                         //condiciona si el n ingresado es igual a cero muestra los primeros numeros ingresados
                        {
                            if (cbxIndicarInterbFibo.Checked == true)
                            {
                                for (int i = 0; i < (n - 1); i++)                      //for que genera suscesion por un intebalo
                                {
                                    int r = Convert.ToInt32(sus4.Substring(i, 1));
                                    int R1 = (r * (b - a)) + a;
                                    sus5 = sus5 + Convert.ToString(R1);
                                }

                            }
                            else { sus5 = sus4; }

                            for (int i = 0; i < n - 1; i++)
                            {
                                sus3 = sus3 + sus5.Substring(i, 1) + ", ";
                            }
                            sus3 = sus3 + sus4.Substring(n - 1, 1);


                            txbSucesionFibo.Text = sus3;


                        }
                        else                                               //ejecuta el siguiente codigo si no se cumplen las demas condiciones
                        {
                            if (cbxIndicarInterbFibo.Checked == true)
                            {
                                for (int i = 0; i < (n - 1); i++)                      //for que genera suscesion por un intebalo
                                {
                                    int r = Convert.ToInt32(sus4.Substring(i, 1));
                                    int R1 = (r * (b - a)) + a;
                                    sus5 = sus5 + Convert.ToString(R1);
                                }

                            }
                            else { sus5 = sus4; }

                            for (int i = 0; i < (sus5.Length - 1); i++)
                            {
                                sus3 = sus3 + sus5.Substring(i, 1) + ", ";
                            }
                            sus3 = sus3 + sus5.Substring((sus5.Length - 1), 1);


                            m = true;
                            for (int i = 1; m; i++)  //for con codigo principal de fibo

                            {

                                sumaV = v1 + v2;  //suma variable v1 y v2


                                if (sumaV <= A)   //determina el valor de K
                                { K = 0; }
                                else { K = -1; }

                                Vx = sumaV + (K * A);  //formula generadora de N° aleatorio

                                sus = sus + Convert.ToString(Vx);   //muestra el resultado

                                v1 = v2;    //reasigna las variables
                                v2 = Vx;

                                if ((sus4 + sus).Length > n) { m = false; }
                            }

                            sus4 = sus4 + sus;


                            if (cbxIndicarInterbFibo.Checked == true)
                            {
                                for (int i = 0; i < (n - 1); i++)                      //for que genera suscesion por un intebalo
                                {
                                    int r = Convert.ToInt32(sus4.Substring(i, 1));
                                    int R1 = (r * (b - a)) + a;
                                    sus5 = sus5 + Convert.ToString(R1);
                                }

                            }
                            else { sus5 = sus; }



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
                                sus2 = sus2 + sus5.Substring((((n) - ind) - 1), 1);
                            }

                            txbSucesionFibo.Text = sus3 + ", " + sus2; //muestra la sucesion final obtenida
                        }


                    }

                }


            }
        }





        private void rdbCongruencia_CheckedChanged(object sender, EventArgs e) //check radio boton de Congruencias
        {
            if (rdbCongruencia.Checked == true)
            {
                rdbCongruenciaAditivo.Visible = true;
                rdbCongruenciaMultiplicativo.Visible = true;
                rdbCongruenciaMixto.Visible = true;
            }
        }

        private void rdbCongruenciaMultiplicativo_CheckedChanged(object sender, EventArgs e)//check radio boton Multiplicativo
        {
            if (rdbCongruenciaMultiplicativo.Checked == true)
            {
                pnlFibonacci.Visible = false;
                pnlVonNeumann.Visible = false;
                pnlMultiplicativo.Visible = true;
                lblCorch1Multi.Visible = false;
                txbInterAmulti.Visible = false;
                lblComaMulti.Visible = false;
                txbInterBmulti.Visible = false;
                lblCorch2Multi.Visible = false;
                txbInterAmulti.Text = "0";
                txbInterBmulti.Text = "9";

            }
        }

        private void btnGenerarMultiplicativo_Click(object sender, EventArgs e) //codigo Congruencias Metodo Multiplicativo
        {
            int sem = Convert.ToInt32(txbSemillaMulti.Text);
            int a = Convert.ToInt32(txbIngreseAcg.Text);
            int m = Convert.ToInt32(txbIngreseMcg.Text);
            int n = 10;
            int V=0, cant=0, b = 0;
            string V1="", sus="", sus1 = ""; 
          


            for (int i = 0; i <= n; i++)
            {
                if (i == 0)
                {
                    V1 = V1 + sem;                    //calculo del modulo cuando se obtiene por primera vez la sucesion
                    b = (a * sem);
                    V = b %= m;
                }

                else
                {
                    b = (a * V);           //calculo del modulo cuando ya se obtuvo una sucesion
                    V = b %= m;
                }

                V1 = V1 + V;

                
            }
            cant = V1.Length;           //asigna a cant la cantidad de elementos que hay en la sucecion
            if (cxbInterbMulti.Checked == true)                  //if que condiciona si se realiza el intervalo o no
            {
                a = Convert.ToInt32(txbInterAmulti.Text);
                b = Convert.ToInt32(txbInterBmulti.Text);

                for (int i = 0; i < cant; i++)                      //for que genera suscesion por un intebalo
                {
                    int r = Convert.ToInt32(V1.Substring(i, 1));
                    int R1 = (r * (b - a)) + a;
                    sus = sus + Convert.ToString(R1);
                }
            }
            else { sus = V1; }

            cant = sus.Length;
            for (int i = 0; i < cant - 1; i++)
            {
                sus1 = sus1 + sus.Substring(i, 1) + ", ";
            }
            sus1 = sus1 + sus.Substring(cant - 1, 1);

            txbSucesionMulti.Text = sus1;          //muestra la sucesion obtenida

        }

        private void cxbInterbMulti_CheckedChanged(object sender, EventArgs e) //checkboxs de interbalo Metodo Multiplicativo
        {
            if (cxbInterbMulti.Checked == true)
            {
                lblCorch1Multi.Visible = true;
                txbInterAmulti.Visible = true;
                lblComaMulti.Visible = true;
                txbInterBmulti.Visible = true;
                lblCorch2Multi.Visible = true;
            }
            else {
                lblCorch1Multi.Visible = false;
                txbInterAmulti.Visible = false;
                lblComaMulti.Visible = false;
                txbInterBmulti.Visible = false;
                lblCorch2Multi.Visible = false;
                txbInterAmulti.Text = "0";
                txbInterBmulti.Text = "9";

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


//falta agregar seguridad de solo ingreso numeros en Von Neuman y Fibo 
//falta agregar congruencia aditiva y mixta
