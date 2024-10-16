namespace Sezar_Sifreleme
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
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.txtSifreliVeri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSifreCoz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veri:";
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(393, 95);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(319, 29);
            this.txtVeri.TabIndex = 1;
            // 
            // btnSifrele
            // 
            this.btnSifrele.Location = new System.Drawing.Point(393, 207);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(124, 55);
            this.btnSifrele.TabIndex = 2;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // txtSifreliVeri
            // 
            this.txtSifreliVeri.Location = new System.Drawing.Point(393, 145);
            this.txtSifreliVeri.Name = "txtSifreliVeri";
            this.txtSifreliVeri.Size = new System.Drawing.Size(319, 29);
            this.txtSifreliVeri.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifreli Veri:";
            // 
            // btnSifreCoz
            // 
            this.btnSifreCoz.Location = new System.Drawing.Point(588, 207);
            this.btnSifreCoz.Name = "btnSifreCoz";
            this.btnSifreCoz.Size = new System.Drawing.Size(124, 55);
            this.btnSifreCoz.TabIndex = 5;
            this.btnSifreCoz.Text = "Şifre Çöz";
            this.btnSifreCoz.UseVisualStyleBackColor = true;
            this.btnSifreCoz.Click += new System.EventHandler(this.btnSifreCoz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 554);
            this.Controls.Add(this.btnSifreCoz);
            this.Controls.Add(this.txtSifreliVeri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.txtVeri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.TextBox txtSifreliVeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSifreCoz;
    }
}

