namespace PesoIdeal
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbttnMasc = new System.Windows.Forms.RadioButton();
            this.rbttnFem = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxPeso = new System.Windows.Forms.TextBox();
            this.txtboxAltura = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura (metros)";
            // 
            // rbttnMasc
            // 
            this.rbttnMasc.AutoSize = true;
            this.rbttnMasc.Location = new System.Drawing.Point(6, 19);
            this.rbttnMasc.Name = "rbttnMasc";
            this.rbttnMasc.Size = new System.Drawing.Size(73, 17);
            this.rbttnMasc.TabIndex = 4;
            this.rbttnMasc.TabStop = true;
            this.rbttnMasc.Text = "Masculino";
            this.rbttnMasc.UseVisualStyleBackColor = true;
            // 
            // rbttnFem
            // 
            this.rbttnFem.AutoSize = true;
            this.rbttnFem.Location = new System.Drawing.Point(6, 42);
            this.rbttnFem.Name = "rbttnFem";
            this.rbttnFem.Size = new System.Drawing.Size(67, 17);
            this.rbttnFem.TabIndex = 5;
            this.rbttnFem.TabStop = true;
            this.rbttnFem.Text = "Feminino";
            this.rbttnFem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbttnMasc);
            this.groupBox1.Controls.Add(this.rbttnFem);
            this.groupBox1.Location = new System.Drawing.Point(29, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calcular!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxPeso
            // 
            this.txtboxPeso.Location = new System.Drawing.Point(100, 26);
            this.txtboxPeso.Name = "txtboxPeso";
            this.txtboxPeso.Size = new System.Drawing.Size(100, 20);
            this.txtboxPeso.TabIndex = 8;
            // 
            // txtboxAltura
            // 
            this.txtboxAltura.Location = new System.Drawing.Point(143, 69);
            this.txtboxAltura.Name = "txtboxAltura";
            this.txtboxAltura.Size = new System.Drawing.Size(100, 20);
            this.txtboxAltura.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxAltura);
            this.Controls.Add(this.txtboxPeso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbttnMasc;
        private System.Windows.Forms.RadioButton rbttnFem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtboxPeso;
        private System.Windows.Forms.TextBox txtboxAltura;
    }
}

