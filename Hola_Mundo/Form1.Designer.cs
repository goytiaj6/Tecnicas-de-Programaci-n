namespace Hola_Mundo
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
            this.HM = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // HM
            // 
            this.HM.AutoSize = true;
            this.HM.Location = new System.Drawing.Point(376, 134);
            this.HM.Name = "HM";
            this.HM.Size = new System.Drawing.Size(0, 13);
            this.HM.TabIndex = 0;
            this.HM.Click += new System.EventHandler(this.HM_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(361, 214);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 1;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(346, 150);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(100, 20);
            this.Box1.TabIndex = 2;
            this.Box1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 387);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.HM);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HM;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox Box1;
    }
}

