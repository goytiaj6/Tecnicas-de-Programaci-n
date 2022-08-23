namespace Polimorfismo
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
            this.Btn_Vaca = new System.Windows.Forms.Button();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Vaca
            // 
            this.Btn_Vaca.Location = new System.Drawing.Point(338, 113);
            this.Btn_Vaca.Name = "Btn_Vaca";
            this.Btn_Vaca.Size = new System.Drawing.Size(75, 23);
            this.Btn_Vaca.TabIndex = 0;
            this.Btn_Vaca.Text = "Vaca";
            this.Btn_Vaca.UseVisualStyleBackColor = true;
            this.Btn_Vaca.Click += new System.EventHandler(this.Btn_Vaca_Click);
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(326, 87);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 1;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Btn_Vaca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Vaca;
        private System.Windows.Forms.TextBox TextBox1;
    }
}

