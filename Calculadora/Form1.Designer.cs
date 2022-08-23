namespace Calculadora
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
            this.Box1 = new System.Windows.Forms.TextBox();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbSuma = new System.Windows.Forms.RadioButton();
            this.rdbResta = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicación = new System.Windows.Forms.RadioButton();
            this.rdbDivisión = new System.Windows.Forms.RadioButton();
            this.bOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(290, 70);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(100, 20);
            this.Box1.TabIndex = 0;
            this.Box1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(290, 134);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(100, 20);
            this.Box2.TabIndex = 1;
            // 
            // Box3
            // 
            this.Box3.Location = new System.Drawing.Point(290, 214);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(100, 20);
            this.Box3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Número 2";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // rdbSuma
            // 
            this.rdbSuma.AutoSize = true;
            this.rdbSuma.Location = new System.Drawing.Point(543, 217);
            this.rdbSuma.Name = "rdbSuma";
            this.rdbSuma.Size = new System.Drawing.Size(52, 17);
            this.rdbSuma.TabIndex = 6;
            this.rdbSuma.TabStop = true;
            this.rdbSuma.Text = "Suma";
            this.rdbSuma.UseVisualStyleBackColor = true;
            // 
            // rdbResta
            // 
            this.rdbResta.AutoSize = true;
            this.rdbResta.Location = new System.Drawing.Point(543, 266);
            this.rdbResta.Name = "rdbResta";
            this.rdbResta.Size = new System.Drawing.Size(53, 17);
            this.rdbResta.TabIndex = 7;
            this.rdbResta.TabStop = true;
            this.rdbResta.Text = "Resta";
            this.rdbResta.UseVisualStyleBackColor = true;
            this.rdbResta.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // rdbMultiplicación
            // 
            this.rdbMultiplicación.AutoSize = true;
            this.rdbMultiplicación.Location = new System.Drawing.Point(543, 312);
            this.rdbMultiplicación.Name = "rdbMultiplicación";
            this.rdbMultiplicación.Size = new System.Drawing.Size(89, 17);
            this.rdbMultiplicación.TabIndex = 8;
            this.rdbMultiplicación.TabStop = true;
            this.rdbMultiplicación.Text = "Multiplicación";
            this.rdbMultiplicación.UseVisualStyleBackColor = true;
            // 
            // rdbDivisión
            // 
            this.rdbDivisión.AutoSize = true;
            this.rdbDivisión.Location = new System.Drawing.Point(543, 363);
            this.rdbDivisión.Name = "rdbDivisión";
            this.rdbDivisión.Size = new System.Drawing.Size(62, 17);
            this.rdbDivisión.TabIndex = 9;
            this.rdbDivisión.TabStop = true;
            this.rdbDivisión.Text = "División";
            this.rdbDivisión.UseVisualStyleBackColor = true;
            this.rdbDivisión.CheckedChanged += new System.EventHandler(this.RadioButton4_CheckedChanged);
            // 
            // bOK
            // 
            this.bOK.Location = new System.Drawing.Point(272, 363);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(75, 23);
            this.bOK.TabIndex = 10;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 493);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.rdbDivisión);
            this.Controls.Add(this.rdbMultiplicación);
            this.Controls.Add(this.rdbResta);
            this.Controls.Add(this.rdbSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbSuma;
        private System.Windows.Forms.RadioButton rdbResta;
        private System.Windows.Forms.RadioButton rdbMultiplicación;
        private System.Windows.Forms.RadioButton rdbDivisión;
        private System.Windows.Forms.Button bOK;
    }
}

