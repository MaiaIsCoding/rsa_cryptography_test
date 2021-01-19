namespace WindowsFormsApplication1
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
            this.ToEncrypt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.EncryptedBox = new System.Windows.Forms.RichTextBox();
            this.ToDecrypt = new System.Windows.Forms.RichTextBox();
            this.DecryptedBox = new System.Windows.Forms.TextBox();
            this.PrivateBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToEncrypt
            // 
            this.ToEncrypt.Location = new System.Drawing.Point(110, 19);
            this.ToEncrypt.Name = "ToEncrypt";
            this.ToEncrypt.Size = new System.Drawing.Size(343, 20);
            this.ToEncrypt.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Encrypt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Decrypt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EncryptedBox
            // 
            this.EncryptedBox.Location = new System.Drawing.Point(110, 57);
            this.EncryptedBox.Name = "EncryptedBox";
            this.EncryptedBox.Size = new System.Drawing.Size(343, 76);
            this.EncryptedBox.TabIndex = 9;
            this.EncryptedBox.Text = "";
            // 
            // ToDecrypt
            // 
            this.ToDecrypt.Location = new System.Drawing.Point(110, 153);
            this.ToDecrypt.Name = "ToDecrypt";
            this.ToDecrypt.Size = new System.Drawing.Size(343, 73);
            this.ToDecrypt.TabIndex = 10;
            this.ToDecrypt.Text = "";
            // 
            // DecryptedBox
            // 
            this.DecryptedBox.Location = new System.Drawing.Point(110, 337);
            this.DecryptedBox.Name = "DecryptedBox";
            this.DecryptedBox.Size = new System.Drawing.Size(343, 20);
            this.DecryptedBox.TabIndex = 0;
            // 
            // PrivateBox
            // 
            this.PrivateBox.Location = new System.Drawing.Point(110, 245);
            this.PrivateBox.Name = "PrivateBox";
            this.PrivateBox.Size = new System.Drawing.Size(343, 73);
            this.PrivateBox.TabIndex = 11;
            this.PrivateBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Texto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Texto Encriptado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Texto Encriptado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Chave Privada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Texto Decifrado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrivateBox);
            this.Controls.Add(this.ToDecrypt);
            this.Controls.Add(this.EncryptedBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToEncrypt);
            this.Controls.Add(this.DecryptedBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ToEncrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox EncryptedBox;
        private System.Windows.Forms.RichTextBox ToDecrypt;
        private System.Windows.Forms.TextBox DecryptedBox;
        private System.Windows.Forms.RichTextBox PrivateBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

