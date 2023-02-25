namespace DavidAndino
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formulario1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foemulario2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulario3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulario1ToolStripMenuItem,
            this.foemulario2ToolStripMenuItem,
            this.formulario3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formulario1ToolStripMenuItem
            // 
            this.formulario1ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulario1ToolStripMenuItem.Name = "formulario1ToolStripMenuItem";
            this.formulario1ToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.formulario1ToolStripMenuItem.Text = "Formulario 1";
            this.formulario1ToolStripMenuItem.Click += new System.EventHandler(this.formulario1ToolStripMenuItem_Click);
            // 
            // foemulario2ToolStripMenuItem
            // 
            this.foemulario2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foemulario2ToolStripMenuItem.Name = "foemulario2ToolStripMenuItem";
            this.foemulario2ToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.foemulario2ToolStripMenuItem.Text = "Formulario 2";
            this.foemulario2ToolStripMenuItem.Click += new System.EventHandler(this.foemulario2ToolStripMenuItem_Click);
            // 
            // formulario3ToolStripMenuItem
            // 
            this.formulario3ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulario3ToolStripMenuItem.Name = "formulario3ToolStripMenuItem";
            this.formulario3ToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.formulario3ToolStripMenuItem.Text = "Formulario 3";
            this.formulario3ToolStripMenuItem.Click += new System.EventHandler(this.formulario3ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 65);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formulario1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foemulario2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulario3ToolStripMenuItem;
    }
}

