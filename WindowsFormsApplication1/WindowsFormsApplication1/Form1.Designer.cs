namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rdbVonNeumann = new System.Windows.Forms.RadioButton();
            this.rdbFibonacci = new System.Windows.Forms.RadioButton();
            this.rdbCongruencia = new System.Windows.Forms.RadioButton();
            this.pnlVonNeumann = new System.Windows.Forms.Panel();
            this.lblCorch2 = new System.Windows.Forms.Label();
            this.lblComa = new System.Windows.Forms.Label();
            this.lblCorch1 = new System.Windows.Forms.Label();
            this.txbInter2VN = new System.Windows.Forms.TextBox();
            this.txbInter1VN = new System.Windows.Forms.TextBox();
            this.cbxIndicarInterVN = new System.Windows.Forms.CheckBox();
            this.lblMayorA100 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCant = new System.Windows.Forms.TextBox();
            this.txbSemilla = new System.Windows.Forms.TextBox();
            this.txbSucesion = new System.Windows.Forms.TextBox();
            this.cbxCantidad = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.pnlFibonacci = new System.Windows.Forms.Panel();
            this.lblIngreseV1yV22 = new System.Windows.Forms.Label();
            this.lblIngreseV1yV2 = new System.Windows.Forms.Label();
            this.lblCorch2Fibo = new System.Windows.Forms.Label();
            this.lblComaFibo = new System.Windows.Forms.Label();
            this.lblCorchFibo = new System.Windows.Forms.Label();
            this.txbInterb2Fibo = new System.Windows.Forms.TextBox();
            this.txbInterb1Fibo = new System.Windows.Forms.TextBox();
            this.cbxIndicarInterbFibo = new System.Windows.Forms.CheckBox();
            this.btnGenerarFibo = new System.Windows.Forms.Button();
            this.txbSucesionFibo = new System.Windows.Forms.TextBox();
            this.lblcantidadFibo = new System.Windows.Forms.Label();
            this.txbcantidadFibo = new System.Windows.Forms.TextBox();
            this.txbNumeroA = new System.Windows.Forms.TextBox();
            this.lblVariable2 = new System.Windows.Forms.Label();
            this.txbVariable2 = new System.Windows.Forms.TextBox();
            this.txbVariable1 = new System.Windows.Forms.TextBox();
            this.lblNumeroA = new System.Windows.Forms.Label();
            this.lblVariable1 = new System.Windows.Forms.Label();
            this.mktbxSemilla = new System.Windows.Forms.MaskedTextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlVonNeumann.SuspendLayout();
            this.pnlFibonacci.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitulo.Location = new System.Drawing.Point(174, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Generadores";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdbVonNeumann
            // 
            this.rdbVonNeumann.AutoSize = true;
            this.rdbVonNeumann.Location = new System.Drawing.Point(52, 62);
            this.rdbVonNeumann.Name = "rdbVonNeumann";
            this.rdbVonNeumann.Size = new System.Drawing.Size(93, 19);
            this.rdbVonNeumann.TabIndex = 1;
            this.rdbVonNeumann.TabStop = true;
            this.rdbVonNeumann.Text = "Von Neumann";
            this.rdbVonNeumann.UseVisualStyleBackColor = true;
            this.rdbVonNeumann.CheckedChanged += new System.EventHandler(this.rdbVonNeumann_CheckedChanged);
            // 
            // rdbFibonacci
            // 
            this.rdbFibonacci.AutoSize = true;
            this.rdbFibonacci.Location = new System.Drawing.Point(202, 62);
            this.rdbFibonacci.Name = "rdbFibonacci";
            this.rdbFibonacci.Size = new System.Drawing.Size(73, 19);
            this.rdbFibonacci.TabIndex = 2;
            this.rdbFibonacci.TabStop = true;
            this.rdbFibonacci.Text = "Fibonacci";
            this.rdbFibonacci.UseVisualStyleBackColor = true;
            this.rdbFibonacci.CheckedChanged += new System.EventHandler(this.rdbFibonacci_CheckedChanged);
            // 
            // rdbCongruencia
            // 
            this.rdbCongruencia.AutoSize = true;
            this.rdbCongruencia.Location = new System.Drawing.Point(355, 62);
            this.rdbCongruencia.Name = "rdbCongruencia";
            this.rdbCongruencia.Size = new System.Drawing.Size(85, 19);
            this.rdbCongruencia.TabIndex = 3;
            this.rdbCongruencia.TabStop = true;
            this.rdbCongruencia.Text = "Congruencia";
            this.rdbCongruencia.UseVisualStyleBackColor = true;
            // 
            // pnlVonNeumann
            // 
            this.pnlVonNeumann.Controls.Add(this.lblCorch2);
            this.pnlVonNeumann.Controls.Add(this.lblComa);
            this.pnlVonNeumann.Controls.Add(this.lblCorch1);
            this.pnlVonNeumann.Controls.Add(this.txbInter2VN);
            this.pnlVonNeumann.Controls.Add(this.txbInter1VN);
            this.pnlVonNeumann.Controls.Add(this.cbxIndicarInterVN);
            this.pnlVonNeumann.Controls.Add(this.lblMayorA100);
            this.pnlVonNeumann.Controls.Add(this.label2);
            this.pnlVonNeumann.Controls.Add(this.txbCant);
            this.pnlVonNeumann.Controls.Add(this.txbSemilla);
            this.pnlVonNeumann.Controls.Add(this.txbSucesion);
            this.pnlVonNeumann.Controls.Add(this.cbxCantidad);
            this.pnlVonNeumann.Controls.Add(this.btnGenerar);
            this.pnlVonNeumann.Controls.Add(this.lblSemilla);
            this.pnlVonNeumann.Location = new System.Drawing.Point(40, 124);
            this.pnlVonNeumann.Name = "pnlVonNeumann";
            this.pnlVonNeumann.Size = new System.Drawing.Size(458, 308);
            this.pnlVonNeumann.TabIndex = 4;
            this.pnlVonNeumann.Visible = false;
            // 
            // lblCorch2
            // 
            this.lblCorch2.AutoSize = true;
            this.lblCorch2.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorch2.Location = new System.Drawing.Point(136, 106);
            this.lblCorch2.Name = "lblCorch2";
            this.lblCorch2.Size = new System.Drawing.Size(10, 15);
            this.lblCorch2.TabIndex = 15;
            this.lblCorch2.Text = "]";
            // 
            // lblComa
            // 
            this.lblComa.AutoSize = true;
            this.lblComa.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComa.Location = new System.Drawing.Point(104, 108);
            this.lblComa.Name = "lblComa";
            this.lblComa.Size = new System.Drawing.Size(10, 15);
            this.lblComa.TabIndex = 14;
            this.lblComa.Text = ",";
            // 
            // lblCorch1
            // 
            this.lblCorch1.AutoSize = true;
            this.lblCorch1.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorch1.Location = new System.Drawing.Point(73, 107);
            this.lblCorch1.Name = "lblCorch1";
            this.lblCorch1.Size = new System.Drawing.Size(10, 15);
            this.lblCorch1.TabIndex = 13;
            this.lblCorch1.Text = "[";
            // 
            // txbInter2VN
            // 
            this.txbInter2VN.Location = new System.Drawing.Point(113, 104);
            this.txbInter2VN.Name = "txbInter2VN";
            this.txbInter2VN.Size = new System.Drawing.Size(21, 20);
            this.txbInter2VN.TabIndex = 12;
            // 
            // txbInter1VN
            // 
            this.txbInter1VN.Location = new System.Drawing.Point(83, 105);
            this.txbInter1VN.Name = "txbInter1VN";
            this.txbInter1VN.Size = new System.Drawing.Size(22, 20);
            this.txbInter1VN.TabIndex = 11;
            // 
            // cbxIndicarInterVN
            // 
            this.cbxIndicarInterVN.AutoSize = true;
            this.cbxIndicarInterVN.Location = new System.Drawing.Point(162, 104);
            this.cbxIndicarInterVN.Name = "cbxIndicarInterVN";
            this.cbxIndicarInterVN.Size = new System.Drawing.Size(115, 19);
            this.cbxIndicarInterVN.TabIndex = 10;
            this.cbxIndicarInterVN.Text = "Indicar Interbalo ";
            this.cbxIndicarInterVN.UseVisualStyleBackColor = true;
            this.cbxIndicarInterVN.CheckedChanged += new System.EventHandler(this.cbxIndicarInterVN_CheckedChanged);
            // 
            // lblMayorA100
            // 
            this.lblMayorA100.AutoSize = true;
            this.lblMayorA100.BackColor = System.Drawing.SystemColors.Control;
            this.lblMayorA100.Font = new System.Drawing.Font("Microsoft YaHei", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayorA100.ForeColor = System.Drawing.Color.Red;
            this.lblMayorA100.Location = new System.Drawing.Point(172, 24);
            this.lblMayorA100.Name = "lblMayorA100";
            this.lblMayorA100.Size = new System.Drawing.Size(198, 17);
            this.lblMayorA100.TabIndex = 9;
            this.lblMayorA100.Text = "Ingrese una semilla mayor a 100";
            this.lblMayorA100.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sucesion";
            // 
            // txbCant
            // 
            this.txbCant.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCant.Location = new System.Drawing.Point(83, 67);
            this.txbCant.Name = "txbCant";
            this.txbCant.Size = new System.Drawing.Size(73, 21);
            this.txbCant.TabIndex = 7;
            // 
            // txbSemilla
            // 
            this.txbSemilla.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSemilla.Location = new System.Drawing.Point(83, 21);
            this.txbSemilla.Name = "txbSemilla";
            this.txbSemilla.Size = new System.Drawing.Size(73, 21);
            this.txbSemilla.TabIndex = 6;
            // 
            // txbSucesion
            // 
            this.txbSucesion.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSucesion.Location = new System.Drawing.Point(76, 165);
            this.txbSucesion.Margin = new System.Windows.Forms.Padding(4);
            this.txbSucesion.Multiline = true;
            this.txbSucesion.Name = "txbSucesion";
            this.txbSucesion.ReadOnly = true;
            this.txbSucesion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSucesion.Size = new System.Drawing.Size(225, 116);
            this.txbSucesion.TabIndex = 5;
            // 
            // cbxCantidad
            // 
            this.cbxCantidad.AutoSize = true;
            this.cbxCantidad.Location = new System.Drawing.Point(162, 67);
            this.cbxCantidad.Name = "cbxCantidad";
            this.cbxCantidad.Size = new System.Drawing.Size(111, 19);
            this.cbxCantidad.TabIndex = 3;
            this.cbxCantidad.Text = "Indicar Cantidad";
            this.cbxCantidad.UseVisualStyleBackColor = true;
            this.cbxCantidad.CheckedChanged += new System.EventHandler(this.cbxCantidad_CheckedChanged);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(325, 124);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(87, 82);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemilla.Location = new System.Drawing.Point(16, 20);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(56, 19);
            this.lblSemilla.TabIndex = 0;
            this.lblSemilla.Text = "Semilla";
            // 
            // pnlFibonacci
            // 
            this.pnlFibonacci.Controls.Add(this.lblIngreseV1yV22);
            this.pnlFibonacci.Controls.Add(this.lblIngreseV1yV2);
            this.pnlFibonacci.Controls.Add(this.lblCorch2Fibo);
            this.pnlFibonacci.Controls.Add(this.lblComaFibo);
            this.pnlFibonacci.Controls.Add(this.lblCorchFibo);
            this.pnlFibonacci.Controls.Add(this.txbInterb2Fibo);
            this.pnlFibonacci.Controls.Add(this.txbInterb1Fibo);
            this.pnlFibonacci.Controls.Add(this.cbxIndicarInterbFibo);
            this.pnlFibonacci.Controls.Add(this.btnGenerarFibo);
            this.pnlFibonacci.Controls.Add(this.txbSucesionFibo);
            this.pnlFibonacci.Controls.Add(this.lblcantidadFibo);
            this.pnlFibonacci.Controls.Add(this.txbcantidadFibo);
            this.pnlFibonacci.Controls.Add(this.txbNumeroA);
            this.pnlFibonacci.Controls.Add(this.lblVariable2);
            this.pnlFibonacci.Controls.Add(this.txbVariable2);
            this.pnlFibonacci.Controls.Add(this.txbVariable1);
            this.pnlFibonacci.Controls.Add(this.lblNumeroA);
            this.pnlFibonacci.Controls.Add(this.lblVariable1);
            this.pnlFibonacci.Location = new System.Drawing.Point(40, 124);
            this.pnlFibonacci.Name = "pnlFibonacci";
            this.pnlFibonacci.Size = new System.Drawing.Size(458, 308);
            this.pnlFibonacci.TabIndex = 5;
            // 
            // lblIngreseV1yV22
            // 
            this.lblIngreseV1yV22.AutoSize = true;
            this.lblIngreseV1yV22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseV1yV22.ForeColor = System.Drawing.Color.Red;
            this.lblIngreseV1yV22.Location = new System.Drawing.Point(24, 197);
            this.lblIngreseV1yV22.Name = "lblIngreseV1yV22";
            this.lblIngreseV1yV22.Size = new System.Drawing.Size(195, 15);
            this.lblIngreseV1yV22.TabIndex = 23;
            this.lblIngreseV1yV22.Text = "Ingrese la variable 1 y la variable 2";
            this.lblIngreseV1yV22.Visible = false;
            // 
            // lblIngreseV1yV2
            // 
            this.lblIngreseV1yV2.AutoSize = true;
            this.lblIngreseV1yV2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreseV1yV2.ForeColor = System.Drawing.Color.Red;
            this.lblIngreseV1yV2.Location = new System.Drawing.Point(28, 197);
            this.lblIngreseV1yV2.Name = "lblIngreseV1yV2";
            this.lblIngreseV1yV2.Size = new System.Drawing.Size(0, 16);
            this.lblIngreseV1yV2.TabIndex = 22;
            this.lblIngreseV1yV2.Visible = false;
            // 
            // lblCorch2Fibo
            // 
            this.lblCorch2Fibo.AutoSize = true;
            this.lblCorch2Fibo.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorch2Fibo.Location = new System.Drawing.Point(115, 171);
            this.lblCorch2Fibo.Name = "lblCorch2Fibo";
            this.lblCorch2Fibo.Size = new System.Drawing.Size(10, 15);
            this.lblCorch2Fibo.TabIndex = 21;
            this.lblCorch2Fibo.Text = "]";
            // 
            // lblComaFibo
            // 
            this.lblComaFibo.AutoSize = true;
            this.lblComaFibo.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComaFibo.Location = new System.Drawing.Point(82, 171);
            this.lblComaFibo.Name = "lblComaFibo";
            this.lblComaFibo.Size = new System.Drawing.Size(10, 15);
            this.lblComaFibo.TabIndex = 20;
            this.lblComaFibo.Text = ",";
            // 
            // lblCorchFibo
            // 
            this.lblCorchFibo.AutoSize = true;
            this.lblCorchFibo.Font = new System.Drawing.Font("Arial", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorchFibo.Location = new System.Drawing.Point(44, 172);
            this.lblCorchFibo.Name = "lblCorchFibo";
            this.lblCorchFibo.Size = new System.Drawing.Size(10, 15);
            this.lblCorchFibo.TabIndex = 19;
            this.lblCorchFibo.Text = "[";
            // 
            // txbInterb2Fibo
            // 
            this.txbInterb2Fibo.Location = new System.Drawing.Point(88, 169);
            this.txbInterb2Fibo.Name = "txbInterb2Fibo";
            this.txbInterb2Fibo.Size = new System.Drawing.Size(21, 20);
            this.txbInterb2Fibo.TabIndex = 18;
            // 
            // txbInterb1Fibo
            // 
            this.txbInterb1Fibo.Location = new System.Drawing.Point(60, 170);
            this.txbInterb1Fibo.Name = "txbInterb1Fibo";
            this.txbInterb1Fibo.Size = new System.Drawing.Size(22, 20);
            this.txbInterb1Fibo.TabIndex = 17;
            // 
            // cbxIndicarInterbFibo
            // 
            this.cbxIndicarInterbFibo.AutoSize = true;
            this.cbxIndicarInterbFibo.Location = new System.Drawing.Point(139, 170);
            this.cbxIndicarInterbFibo.Name = "cbxIndicarInterbFibo";
            this.cbxIndicarInterbFibo.Size = new System.Drawing.Size(115, 19);
            this.cbxIndicarInterbFibo.TabIndex = 16;
            this.cbxIndicarInterbFibo.Text = "Indicar Interbalo ";
            this.cbxIndicarInterbFibo.UseVisualStyleBackColor = true;
            this.cbxIndicarInterbFibo.CheckedChanged += new System.EventHandler(this.cbxIndicarInterbFibo_CheckedChanged);
            // 
            // btnGenerarFibo
            // 
            this.btnGenerarFibo.Location = new System.Drawing.Point(162, 231);
            this.btnGenerarFibo.Name = "btnGenerarFibo";
            this.btnGenerarFibo.Size = new System.Drawing.Size(123, 60);
            this.btnGenerarFibo.TabIndex = 9;
            this.btnGenerarFibo.Text = "Generar";
            this.btnGenerarFibo.UseVisualStyleBackColor = true;
            this.btnGenerarFibo.Click += new System.EventHandler(this.btnGenerarFibo_Click);
            // 
            // txbSucesionFibo
            // 
            this.txbSucesionFibo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSucesionFibo.Location = new System.Drawing.Point(162, 10);
            this.txbSucesionFibo.Multiline = true;
            this.txbSucesionFibo.Name = "txbSucesionFibo";
            this.txbSucesionFibo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSucesionFibo.Size = new System.Drawing.Size(250, 131);
            this.txbSucesionFibo.TabIndex = 8;
            // 
            // lblcantidadFibo
            // 
            this.lblcantidadFibo.AutoSize = true;
            this.lblcantidadFibo.Location = new System.Drawing.Point(11, 110);
            this.lblcantidadFibo.Name = "lblcantidadFibo";
            this.lblcantidadFibo.Size = new System.Drawing.Size(53, 15);
            this.lblcantidadFibo.TabIndex = 7;
            this.lblcantidadFibo.Text = "Ingrese N";
            // 
            // txbcantidadFibo
            // 
            this.txbcantidadFibo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbcantidadFibo.Location = new System.Drawing.Point(72, 107);
            this.txbcantidadFibo.Name = "txbcantidadFibo";
            this.txbcantidadFibo.Size = new System.Drawing.Size(25, 21);
            this.txbcantidadFibo.TabIndex = 6;
            // 
            // txbNumeroA
            // 
            this.txbNumeroA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumeroA.Location = new System.Drawing.Point(72, 69);
            this.txbNumeroA.Name = "txbNumeroA";
            this.txbNumeroA.Size = new System.Drawing.Size(53, 21);
            this.txbNumeroA.TabIndex = 5;
            // 
            // lblVariable2
            // 
            this.lblVariable2.AutoSize = true;
            this.lblVariable2.Location = new System.Drawing.Point(11, 54);
            this.lblVariable2.Name = "lblVariable2";
            this.lblVariable2.Size = new System.Drawing.Size(58, 15);
            this.lblVariable2.TabIndex = 1;
            this.lblVariable2.Text = "Ingrese V2";
            // 
            // txbVariable2
            // 
            this.txbVariable2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVariable2.Location = new System.Drawing.Point(72, 48);
            this.txbVariable2.Name = "txbVariable2";
            this.txbVariable2.Size = new System.Drawing.Size(53, 21);
            this.txbVariable2.TabIndex = 4;
            // 
            // txbVariable1
            // 
            this.txbVariable1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVariable1.Location = new System.Drawing.Point(72, 28);
            this.txbVariable1.Name = "txbVariable1";
            this.txbVariable1.Size = new System.Drawing.Size(53, 21);
            this.txbVariable1.TabIndex = 3;
            // 
            // lblNumeroA
            // 
            this.lblNumeroA.AutoSize = true;
            this.lblNumeroA.Location = new System.Drawing.Point(11, 73);
            this.lblNumeroA.Name = "lblNumeroA";
            this.lblNumeroA.Size = new System.Drawing.Size(53, 15);
            this.lblNumeroA.TabIndex = 2;
            this.lblNumeroA.Text = "Ingrese A";
            // 
            // lblVariable1
            // 
            this.lblVariable1.AutoSize = true;
            this.lblVariable1.Location = new System.Drawing.Point(11, 34);
            this.lblVariable1.Name = "lblVariable1";
            this.lblVariable1.Size = new System.Drawing.Size(58, 15);
            this.lblVariable1.TabIndex = 0;
            this.lblVariable1.Text = "Ingrese V1";
            this.lblVariable1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mktbxSemilla
            // 
            this.mktbxSemilla.Location = new System.Drawing.Point(100, 14);
            this.mktbxSemilla.Mask = "9999";
            this.mktbxSemilla.Name = "mktbxSemilla";
            this.mktbxSemilla.Size = new System.Drawing.Size(41, 20);
            this.mktbxSemilla.TabIndex = 7;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(100, 45);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(56, 20);
            this.txbCantidad.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 454);
            this.Controls.Add(this.pnlFibonacci);
            this.Controls.Add(this.pnlVonNeumann);
            this.Controls.Add(this.rdbCongruencia);
            this.Controls.Add(this.rdbFibonacci);
            this.Controls.Add(this.rdbVonNeumann);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "AppGeneradores";
            this.pnlVonNeumann.ResumeLayout(false);
            this.pnlVonNeumann.PerformLayout();
            this.pnlFibonacci.ResumeLayout(false);
            this.pnlFibonacci.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rdbVonNeumann;
        private System.Windows.Forms.RadioButton rdbFibonacci;
        private System.Windows.Forms.RadioButton rdbCongruencia;
        private System.Windows.Forms.Panel pnlVonNeumann;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.CheckBox cbxCantidad;
        private System.Windows.Forms.Label lblSucecion;
        private System.Windows.Forms.TextBox txbSucesion;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.MaskedTextBox mktbxSemilla;
        private System.Windows.Forms.TextBox txbCant;
        private System.Windows.Forms.TextBox txbSemilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMayorA100;
        private System.Windows.Forms.Panel pnlFibonacci;
        private System.Windows.Forms.Label lblVariable1;
        private System.Windows.Forms.Button btnGenerarFibo;
        private System.Windows.Forms.TextBox txbSucesionFibo;
        private System.Windows.Forms.Label lblcantidadFibo;
        private System.Windows.Forms.TextBox txbcantidadFibo;
        private System.Windows.Forms.TextBox txbNumeroA;
        private System.Windows.Forms.TextBox txbVariable2;
        private System.Windows.Forms.TextBox txbVariable1;
        private System.Windows.Forms.Label lblNumeroA;
        private System.Windows.Forms.Label lblVariable2;
        private System.Windows.Forms.Label lblCorch2;
        private System.Windows.Forms.Label lblComa;
        private System.Windows.Forms.Label lblCorch1;
        private System.Windows.Forms.TextBox txbInter2VN;
        private System.Windows.Forms.TextBox txbInter1VN;
        private System.Windows.Forms.CheckBox cbxIndicarInterVN;
        private System.Windows.Forms.Label lblCorch2Fibo;
        private System.Windows.Forms.Label lblComaFibo;
        private System.Windows.Forms.Label lblCorchFibo;
        private System.Windows.Forms.TextBox txbInterb2Fibo;
        private System.Windows.Forms.TextBox txbInterb1Fibo;
        private System.Windows.Forms.CheckBox cbxIndicarInterbFibo;
        private System.Windows.Forms.Label lblIngreseV1yV2;
        private System.Windows.Forms.Label lblIngreseV1yV22;
    }
}

