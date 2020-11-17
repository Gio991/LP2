namespace Prova_I
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
            this.bttn1 = new System.Windows.Forms.Button();
            this.lstbxSaidas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bttn1
            // 
            this.bttn1.Location = new System.Drawing.Point(139, 156);
            this.bttn1.Name = "bttn1";
            this.bttn1.Size = new System.Drawing.Size(173, 147);
            this.bttn1.TabIndex = 0;
            this.bttn1.Text = "Iniciar!";
            this.bttn1.UseVisualStyleBackColor = true;
            this.bttn1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstbxSaidas
            // 
            this.lstbxSaidas.FormattingEnabled = true;
            this.lstbxSaidas.Location = new System.Drawing.Point(441, 12);
            this.lstbxSaidas.Name = "lstbxSaidas";
            this.lstbxSaidas.Size = new System.Drawing.Size(321, 407);
            this.lstbxSaidas.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstbxSaidas);
            this.Controls.Add(this.bttn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn1;
        private System.Windows.Forms.ListBox lstbxSaidas;
    }
}

