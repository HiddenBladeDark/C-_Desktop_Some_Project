﻿namespace AppPrese
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.ELIMINAR = new System.Windows.Forms.Button();
            this.btnmodi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CONSULTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "APELLIDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "TELEFONO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "SALARIO";
            // 
            // txtnit
            // 
            this.txtnit.Location = new System.Drawing.Point(183, 38);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(100, 20);
            this.txtnit.TabIndex = 6;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(183, 178);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 7;
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(183, 233);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(100, 20);
            this.txtape.TabIndex = 8;
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(183, 295);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(100, 20);
            this.txttel.TabIndex = 9;
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(183, 353);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 20);
            this.txtsal.TabIndex = 10;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(110, 113);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "AÑADIR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.Location = new System.Drawing.Point(300, 113);
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.Size = new System.Drawing.Size(75, 23);
            this.ELIMINAR.TabIndex = 12;
            this.ELIMINAR.Text = "ELIMINAR";
            this.ELIMINAR.UseVisualStyleBackColor = true;
            this.ELIMINAR.Click += new System.EventHandler(this.ELIMINAR_Click);
            // 
            // btnmodi
            // 
            this.btnmodi.Location = new System.Drawing.Point(13, 113);
            this.btnmodi.Name = "btnmodi";
            this.btnmodi.Size = new System.Drawing.Size(75, 23);
            this.btnmodi.TabIndex = 13;
            this.btnmodi.Text = "MODIFICAR";
            this.btnmodi.UseVisualStyleBackColor = true;
            this.btnmodi.Click += new System.EventHandler(this.btnmodi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "TABLA EMPLEADOS";
            // 
            // list
            // 
            this.list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list.Location = new System.Drawing.Point(401, 99);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(399, 270);
            this.list.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 423);
            this.Controls.Add(this.list);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnmodi);
            this.Controls.Add(this.ELIMINAR);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.txtape);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button ELIMINAR;
        private System.Windows.Forms.Button btnmodi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView list;
    }
}

