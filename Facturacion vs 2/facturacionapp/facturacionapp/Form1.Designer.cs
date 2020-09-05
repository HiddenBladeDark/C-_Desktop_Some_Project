namespace facturacionapp
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
            this.txtnom = new System.Windows.Forms.Label();
            this.txtnfa = new System.Windows.Forms.Label();
            this.txtpre = new System.Windows.Forms.Label();
            this.txtcan = new System.Windows.Forms.Label();
            this.txtval = new System.Windows.Forms.Label();
            this.txtdes = new System.Windows.Forms.Label();
            this.txttol = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txnom = new System.Windows.Forms.TextBox();
            this.txcod = new System.Windows.Forms.TextBox();
            this.txpre = new System.Windows.Forms.TextBox();
            this.txcant = new System.Windows.Forms.TextBox();
            this.txval = new System.Windows.Forms.TextBox();
            this.txdesc = new System.Windows.Forms.TextBox();
            this.txtol = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnom
            // 
            this.txtnom.AutoSize = true;
            this.txtnom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(64, 51);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(175, 18);
            this.txtnom.TabIndex = 0;
            this.txtnom.Text = "CODIGO PRODUCTO";
            // 
            // txtnfa
            // 
            this.txtnfa.AutoSize = true;
            this.txtnfa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnfa.Location = new System.Drawing.Point(64, 105);
            this.txtnfa.Name = "txtnfa";
            this.txtnfa.Size = new System.Drawing.Size(180, 18);
            this.txtnfa.TabIndex = 1;
            this.txtnfa.Text = "NOMBRE PRODUCTO";
            // 
            // txtpre
            // 
            this.txtpre.AutoSize = true;
            this.txtpre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpre.Location = new System.Drawing.Point(64, 164);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(171, 18);
            this.txtpre.TabIndex = 2;
            this.txtpre.Text = "PRECIO PRODUCTO";
            // 
            // txtcan
            // 
            this.txtcan.AutoSize = true;
            this.txtcan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcan.Location = new System.Drawing.Point(64, 220);
            this.txtcan.Name = "txtcan";
            this.txtcan.Size = new System.Drawing.Size(95, 18);
            this.txtcan.TabIndex = 3;
            this.txtcan.Text = "CANTIDAD";
            // 
            // txtval
            // 
            this.txtval.AutoSize = true;
            this.txtval.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtval.Location = new System.Drawing.Point(64, 304);
            this.txtval.Name = "txtval";
            this.txtval.Size = new System.Drawing.Size(66, 18);
            this.txtval.TabIndex = 4;
            this.txtval.Text = "VALOR";
            // 
            // txtdes
            // 
            this.txtdes.AutoSize = true;
            this.txtdes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.Location = new System.Drawing.Point(64, 344);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(112, 18);
            this.txtdes.TabIndex = 5;
            this.txtdes.Text = "DESCUENTO";
            // 
            // txttol
            // 
            this.txttol.AutoSize = true;
            this.txttol.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttol.Location = new System.Drawing.Point(64, 396);
            this.txttol.Name = "txttol";
            this.txttol.Size = new System.Drawing.Size(143, 18);
            this.txttol.TabIndex = 6;
            this.txttol.Text = "TOTAL A PAGAR";
            // 
            // button1
            // 
            this.button1.Image = global::facturacionapp.Properties.Resources._44028143_933795733486570_2405541681328816128_n;
            this.button1.Location = new System.Drawing.Point(606, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txnom
            // 
            this.txnom.Location = new System.Drawing.Point(389, 49);
            this.txnom.Name = "txnom";
            this.txnom.Size = new System.Drawing.Size(119, 20);
            this.txnom.TabIndex = 8;
            // 
            // txcod
            // 
            this.txcod.Location = new System.Drawing.Point(389, 103);
            this.txcod.Name = "txcod";
            this.txcod.Size = new System.Drawing.Size(119, 20);
            this.txcod.TabIndex = 9;
            // 
            // txpre
            // 
            this.txpre.Location = new System.Drawing.Point(389, 162);
            this.txpre.Name = "txpre";
            this.txpre.Size = new System.Drawing.Size(119, 20);
            this.txpre.TabIndex = 10;
            // 
            // txcant
            // 
            this.txcant.Location = new System.Drawing.Point(389, 218);
            this.txcant.Name = "txcant";
            this.txcant.Size = new System.Drawing.Size(119, 20);
            this.txcant.TabIndex = 11;
            // 
            // txval
            // 
            this.txval.Location = new System.Drawing.Point(389, 302);
            this.txval.Name = "txval";
            this.txval.Size = new System.Drawing.Size(119, 20);
            this.txval.TabIndex = 12;
            // 
            // txdesc
            // 
            this.txdesc.Location = new System.Drawing.Point(389, 344);
            this.txdesc.Name = "txdesc";
            this.txdesc.Size = new System.Drawing.Size(119, 20);
            this.txdesc.TabIndex = 13;
            // 
            // txtol
            // 
            this.txtol.Location = new System.Drawing.Point(389, 394);
            this.txtol.Name = "txtol";
            this.txtol.Size = new System.Drawing.Size(119, 20);
            this.txtol.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::facturacionapp.Properties.Resources._1680x1050_4577969_dragon_slayer_ornstein_dark_souls_ornstein;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtol);
            this.Controls.Add(this.txdesc);
            this.Controls.Add(this.txval);
            this.Controls.Add(this.txcant);
            this.Controls.Add(this.txpre);
            this.Controls.Add(this.txcod);
            this.Controls.Add(this.txnom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttol);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.txtval);
            this.Controls.Add(this.txtcan);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.txtnfa);
            this.Controls.Add(this.txtnom);
            this.Name = "Form1";
            this.Text = "Codigo Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtnom;
        private System.Windows.Forms.Label txtnfa;
        private System.Windows.Forms.Label txtpre;
        private System.Windows.Forms.Label txtcan;
        private System.Windows.Forms.Label txtval;
        private System.Windows.Forms.Label txtdes;
        private System.Windows.Forms.Label txttol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txnom;
        private System.Windows.Forms.TextBox txcod;
        private System.Windows.Forms.TextBox txpre;
        private System.Windows.Forms.TextBox txcant;
        private System.Windows.Forms.TextBox txval;
        private System.Windows.Forms.TextBox txdesc;
        private System.Windows.Forms.TextBox txtol;
    }
}

