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
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.mktbxSemilla = new System.Windows.Forms.MaskedTextBox();
            this.lblSucecion = new System.Windows.Forms.Label();
            this.txbSucesion = new System.Windows.Forms.TextBox();
            this.cbxCantidad = new System.Windows.Forms.CheckBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.pnlVonNeumann.SuspendLayout();
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
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
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
            this.rdbVonNeumann.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.pnlVonNeumann.Controls.Add(this.txbCantidad);
            this.pnlVonNeumann.Controls.Add(this.mktbxSemilla);
            this.pnlVonNeumann.Controls.Add(this.lblSucecion);
            this.pnlVonNeumann.Controls.Add(this.txbSucesion);
            this.pnlVonNeumann.Controls.Add(this.cbxCantidad);
            this.pnlVonNeumann.Controls.Add(this.btnGenerar);
            this.pnlVonNeumann.Controls.Add(this.lblSemilla);
            this.pnlVonNeumann.Location = new System.Drawing.Point(40, 124);
            this.pnlVonNeumann.Name = "pnlVonNeumann";
            this.pnlVonNeumann.Size = new System.Drawing.Size(375, 173);
            this.pnlVonNeumann.TabIndex = 4;
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(100, 45);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(56, 20);
            this.txbCantidad.TabIndex = 8;
           
            // 
            // mktbxSemilla
            // 
            this.mktbxSemilla.Location = new System.Drawing.Point(100, 14);
            this.mktbxSemilla.Mask = "9999";
            this.mktbxSemilla.Name = "mktbxSemilla";
            this.mktbxSemilla.Size = new System.Drawing.Size(41, 20);
            this.mktbxSemilla.TabIndex = 7;
            // 
            // lblSucecion
            // 
            this.lblSucecion.AutoSize = true;
            this.lblSucecion.Location = new System.Drawing.Point(22, 92);
            this.lblSucecion.Name = "lblSucecion";
            this.lblSucecion.Size = new System.Drawing.Size(49, 15);
            this.lblSucecion.TabIndex = 6;
            this.lblSucecion.Text = "Sucecion";
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
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemilla.Location = new System.Drawing.Point(37, 16);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(56, 19);
            this.lblSemilla.TabIndex = 0;
            this.lblSemilla.Text = "Semilla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 309);
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
    }
}

