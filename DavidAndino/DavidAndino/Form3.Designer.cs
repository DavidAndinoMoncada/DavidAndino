namespace DavidAndino
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PagoTotalAsincronobutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NombreProducto1textBox = new System.Windows.Forms.TextBox();
            this.CantidadProducto1textBox = new System.Windows.Forms.TextBox();
            this.PrecioProducto1textBox = new System.Windows.Forms.TextBox();
            this.NombreProducto2textBox = new System.Windows.Forms.TextBox();
            this.CantidadProducto2textBox = new System.Windows.Forms.TextBox();
            this.PrecioProducto2textBox = new System.Windows.Forms.TextBox();
            this.CalculoTotaltextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PagoTotalAsincronobutton
            // 
            this.PagoTotalAsincronobutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.PagoTotalAsincronobutton.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagoTotalAsincronobutton.ForeColor = System.Drawing.Color.White;
            this.PagoTotalAsincronobutton.Location = new System.Drawing.Point(381, 333);
            this.PagoTotalAsincronobutton.Margin = new System.Windows.Forms.Padding(4);
            this.PagoTotalAsincronobutton.Name = "PagoTotalAsincronobutton";
            this.PagoTotalAsincronobutton.Size = new System.Drawing.Size(183, 71);
            this.PagoTotalAsincronobutton.TabIndex = 0;
            this.PagoTotalAsincronobutton.Text = "Total a Pagar";
            this.PagoTotalAsincronobutton.UseVisualStyleBackColor = false;
            this.PagoTotalAsincronobutton.Click += new System.EventHandler(this.PagoTotalAsincronobutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Producto 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio del Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre del Producto 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 214);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(531, 256);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio del Producto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(253, 481);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total a Pagar:";
            // 
            // NombreProducto1textBox
            // 
            this.NombreProducto1textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProducto1textBox.Location = new System.Drawing.Point(227, 163);
            this.NombreProducto1textBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreProducto1textBox.Name = "NombreProducto1textBox";
            this.NombreProducto1textBox.Size = new System.Drawing.Size(165, 27);
            this.NombreProducto1textBox.TabIndex = 8;
            // 
            // CantidadProducto1textBox
            // 
            this.CantidadProducto1textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadProducto1textBox.Location = new System.Drawing.Point(227, 208);
            this.CantidadProducto1textBox.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadProducto1textBox.Name = "CantidadProducto1textBox";
            this.CantidadProducto1textBox.Size = new System.Drawing.Size(165, 27);
            this.CantidadProducto1textBox.TabIndex = 9;
            // 
            // PrecioProducto1textBox
            // 
            this.PrecioProducto1textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioProducto1textBox.Location = new System.Drawing.Point(227, 254);
            this.PrecioProducto1textBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioProducto1textBox.Name = "PrecioProducto1textBox";
            this.PrecioProducto1textBox.Size = new System.Drawing.Size(165, 27);
            this.PrecioProducto1textBox.TabIndex = 10;
            // 
            // NombreProducto2textBox
            // 
            this.NombreProducto2textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProducto2textBox.Location = new System.Drawing.Point(716, 163);
            this.NombreProducto2textBox.Margin = new System.Windows.Forms.Padding(4);
            this.NombreProducto2textBox.Name = "NombreProducto2textBox";
            this.NombreProducto2textBox.Size = new System.Drawing.Size(165, 27);
            this.NombreProducto2textBox.TabIndex = 11;
            // 
            // CantidadProducto2textBox
            // 
            this.CantidadProducto2textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadProducto2textBox.Location = new System.Drawing.Point(716, 208);
            this.CantidadProducto2textBox.Margin = new System.Windows.Forms.Padding(4);
            this.CantidadProducto2textBox.Name = "CantidadProducto2textBox";
            this.CantidadProducto2textBox.Size = new System.Drawing.Size(165, 27);
            this.CantidadProducto2textBox.TabIndex = 12;
            // 
            // PrecioProducto2textBox
            // 
            this.PrecioProducto2textBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioProducto2textBox.Location = new System.Drawing.Point(716, 254);
            this.PrecioProducto2textBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrecioProducto2textBox.Name = "PrecioProducto2textBox";
            this.PrecioProducto2textBox.Size = new System.Drawing.Size(165, 27);
            this.PrecioProducto2textBox.TabIndex = 13;
            // 
            // CalculoTotaltextBox
            // 
            this.CalculoTotaltextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculoTotaltextBox.Location = new System.Drawing.Point(402, 480);
            this.CalculoTotaltextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CalculoTotaltextBox.Name = "CalculoTotaltextBox";
            this.CalculoTotaltextBox.Size = new System.Drawing.Size(221, 28);
            this.CalculoTotaltextBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(395, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "Factura";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form3
            // 
            this.AcceptButton = this.PagoTotalAsincronobutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(908, 554);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CalculoTotaltextBox);
            this.Controls.Add(this.PrecioProducto2textBox);
            this.Controls.Add(this.CantidadProducto2textBox);
            this.Controls.Add(this.NombreProducto2textBox);
            this.Controls.Add(this.PrecioProducto1textBox);
            this.Controls.Add(this.CantidadProducto1textBox);
            this.Controls.Add(this.NombreProducto1textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PagoTotalAsincronobutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PagoTotalAsincronobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NombreProducto1textBox;
        private System.Windows.Forms.TextBox CantidadProducto1textBox;
        private System.Windows.Forms.TextBox PrecioProducto1textBox;
        private System.Windows.Forms.TextBox NombreProducto2textBox;
        private System.Windows.Forms.TextBox CantidadProducto2textBox;
        private System.Windows.Forms.TextBox PrecioProducto2textBox;
        private System.Windows.Forms.TextBox CalculoTotaltextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}