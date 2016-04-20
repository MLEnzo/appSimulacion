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
            this.lblMayorA100 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCant = new System.Windows.Forms.TextBox();
            this.txbSemilla = new System.Windows.Forms.TextBox();
            this.txbSucesion = new System.Windows.Forms.TextBox();
            this.cbxCantidad = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.mktbxSemilla = new System.Windows.Forms.MaskedTextBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFibonacci = new System.Windows.Forms.Panel();
            this.lblVariable1 = new System.Windows.Forms.Label();
            this.lblVariable2 = new System.Windows.Forms.Label();
            this.lblNumeroA = new System.Windows.Forms.Label();
            this.txbVariable1 = new System.Windows.Forms.TextBox();
            this.txbVariable2 = new System.Windows.Forms.TextBox();
            this.txbNumeroA = new System.Windows.Forms.TextBox();
            this.txbcantidadFibo = new System.Windows.Forms.TextBox();
            this.lblcantidadFibo = new System.Windows.Forms.Label();
            this.txbSucesionFibo = new System.Windows.Forms.TextBox();
            this.btnGenerarFibo = new System.Windows.Forms.Button();
            this.pnlVonNeumann.SuspendLayout();
            this.pnlFibonacci.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitulo.Location = new System.Drawing.Point(88, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 38);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Generadores";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rdbVonNeumann
            // 
            this.rdbVonNeumann.AutoSize = true;
            this.rdbVonNeumann.Location = new System.Drawing.Point(40, 99);
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
            this.rdbFibonacci.Location = new System.Drawing.Point(161, 99);
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
            this.rdbCongruencia.Location = new System.Drawing.Point(290, 99);
            this.rdbCongruencia.Name = "rdbCongruencia";
            this.rdbCongruencia.Size = new System.Drawing.Size(85, 19);
            this.rdbCongruencia.TabIndex = 3;
            this.rdbCongruencia.TabStop = true;
            this.rdbCongruencia.Text = "Congruencia";
            this.rdbCongruencia.UseVisualStyleBackColor = true;
            // 
            // pnlVonNeumann
            // 
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
            this.pnlVonNeumann.Size = new System.Drawing.Size(375, 173);
            this.pnlVonNeumann.TabIndex = 4;
            this.pnlVonNeumann.Visible = false;
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
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sucesion";
            // 
            // txbCant
            // 
            this.txbCant.Location = new System.Drawing.Point(83, 45);
            this.txbCant.Name = "txbCant";
            this.txbCant.Size = new System.Drawing.Size(73, 20);
            this.txbCant.TabIndex = 7;
            // 
            // txbSemilla
            // 
            this.txbSemilla.Location = new System.Drawing.Point(83, 21);
            this.txbSemilla.Name = "txbSemilla";
            this.txbSemilla.Size = new System.Drawing.Size(73, 20);
            this.txbSemilla.TabIndex = 6;
            // 
            // txbSucesion
            // 
            this.txbSucesion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSucesion.Location = new System.Drawing.Point(78, 92);
            this.txbSucesion.Margin = new System.Windows.Forms.Padding(4);
            this.txbSucesion.Multiline = true;
            this.txbSucesion.Name = "txbSucesion";
            this.txbSucesion.ReadOnly = true;
            this.txbSucesion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbSucesion.Size = new System.Drawing.Size(178, 50);
            this.txbSucesion.TabIndex = 5;
            // 
            // cbxCantidad
            // 
            this.cbxCantidad.AutoSize = true;
            this.cbxCantidad.Location = new System.Drawing.Point(162, 47);
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
            this.btnGenerar.Location = new System.Drawing.Point(269, 73);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(87, 50);
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
            // pnlFibonacci
            // 
            this.pnlFibonacci.Controls.Add(this.btnGenerarFibo);
            this.pnlFibonacci.Controls.Add(this.txbSucesionFibo);
            this.pnlFibonacci.Controls.Add(this.lblcantidadFibo);
            this.pnlFibonacci.Controls.Add(this.txbcantidadFibo);
            this.pnlFibonacci.Controls.Add(this.txbNumeroA);
            this.pnlFibonacci.Controls.Add(this.txbVariable2);
            this.pnlFibonacci.Controls.Add(this.txbVariable1);
            this.pnlFibonacci.Controls.Add(this.lblNumeroA);
            this.pnlFibonacci.Controls.Add(this.lblVariable2);
            this.pnlFibonacci.Controls.Add(this.lblVariable1);
            this.pnlFibonacci.Location = new System.Drawing.Point(40, 124);
            this.pnlFibonacci.Name = "pnlFibonacci";
            this.pnlFibonacci.Size = new System.Drawing.Size(375, 173);
            this.pnlFibonacci.TabIndex = 5;
            // 
            // lblVariable1
            // 
            this.lblVariable1.AutoSize = true;
            this.lblVariable1.Location = new System.Drawing.Point(4, 4);
            this.lblVariable1.Name = "lblVariable1";
            this.lblVariable1.Size = new System.Drawing.Size(58, 15);
            this.lblVariable1.TabIndex = 0;
            this.lblVariable1.Text = "Ingrese V1";
            this.lblVariable1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVariable2
            // 
            this.lblVariable2.AutoSize = true;
            this.lblVariable2.Location = new System.Drawing.Point(4, 24);
            this.lblVariable2.Name = "lblVariable2";
            this.lblVariable2.Size = new System.Drawing.Size(58, 15);
            this.lblVariable2.TabIndex = 1;
            this.lblVariable2.Text = "Ingrese V2";
            // 
            // lblNumeroA
            // 
            this.lblNumeroA.AutoSize = true;
            this.lblNumeroA.Location = new System.Drawing.Point(7, 43);
            this.lblNumeroA.Name = "lblNumeroA";
            this.lblNumeroA.Size = new System.Drawing.Size(53, 15);
            this.lblNumeroA.TabIndex = 2;
            this.lblNumeroA.Text = "Ingrese A";
            // 
            // txbVariable1
            // 
            this.txbVariable1.Location = new System.Drawing.Point(68, 4);
            this.txbVariable1.Name = "txbVariable1";
            this.txbVariable1.Size = new System.Drawing.Size(53, 20);
            this.txbVariable1.TabIndex = 3;
            // 
            // txbVariable2
            // 
            this.txbVariable2.Location = new System.Drawing.Point(68, 24);
            this.txbVariable2.Name = "txbVariable2";
            this.txbVariable2.Size = new System.Drawing.Size(53, 20);
            this.txbVariable2.TabIndex = 4;
            // 
            // txbNumeroA
            // 
            this.txbNumeroA.Location = new System.Drawing.Point(68, 45);
            this.txbNumeroA.Name = "txbNumeroA";
            this.txbNumeroA.Size = new System.Drawing.Size(53, 20);
            this.txbNumeroA.TabIndex = 5;
            // 
            // txbcantidadFibo
            // 
            this.txbcantidadFibo.Location = new System.Drawing.Point(68, 83);
            this.txbcantidadFibo.Name = "txbcantidadFibo";
            this.txbcantidadFibo.Size = new System.Drawing.Size(25, 20);
            this.txbcantidadFibo.TabIndex = 6;
            // 
            // lblcantidadFibo
            // 
            this.lblcantidadFibo.AutoSize = true;
            this.lblcantidadFibo.Location = new System.Drawing.Point(7, 86);
            this.lblcantidadFibo.Name = "lblcantidadFibo";
            this.lblcantidadFibo.Size = new System.Drawing.Size(53, 15);
            this.lblcantidadFibo.TabIndex = 7;
            this.lblcantidadFibo.Text = "Ingrese N";
            // 
            // txbSucesionFibo
            // 
            this.txbSucesionFibo.Location = new System.Drawing.Point(175, 20);
            this.txbSucesionFibo.Multiline = true;
            this.txbSucesionFibo.Name = "txbSucesionFibo";
            this.txbSucesionFibo.Size = new System.Drawing.Size(160, 87);
            this.txbSucesionFibo.TabIndex = 8;
            // 
            // btnGenerarFibo
            // 
            this.btnGenerarFibo.Location = new System.Drawing.Point(110, 119);
            this.btnGenerarFibo.Name = "btnGenerarFibo";
            this.btnGenerarFibo.Size = new System.Drawing.Size(100, 36);
            this.btnGenerarFibo.TabIndex = 9;
            this.btnGenerarFibo.Text = "Generar";
            this.btnGenerarFibo.UseVisualStyleBackColor = true;
            this.btnGenerarFibo.Click += new System.EventHandler(this.btnGenerarFibo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 309);
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
    }
}

