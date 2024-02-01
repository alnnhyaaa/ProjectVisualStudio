namespace ParkirKendaraan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.radioButtonMotor = new System.Windows.Forms.RadioButton();
            this.radioButtonMobil = new System.Windows.Forms.RadioButton();
            this.radioButtonTruk = new System.Windows.Forms.RadioButton();
            this.textBoxJamMasuk = new System.Windows.Forms.TextBox();
            this.textBoxJamKeluar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jenis Kendaraan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jam Masuk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jam Keluar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tarif total";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasil.Location = new System.Drawing.Point(44, 304);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(19, 16);
            this.labelHasil.TabIndex = 4;
            this.labelHasil.Text = "...";
            // 
            // radioButtonMotor
            // 
            this.radioButtonMotor.AutoSize = true;
            this.radioButtonMotor.Location = new System.Drawing.Point(46, 62);
            this.radioButtonMotor.Name = "radioButtonMotor";
            this.radioButtonMotor.Size = new System.Drawing.Size(52, 17);
            this.radioButtonMotor.TabIndex = 5;
            this.radioButtonMotor.TabStop = true;
            this.radioButtonMotor.Text = "Motor";
            this.radioButtonMotor.UseVisualStyleBackColor = true;
            // 
            // radioButtonMobil
            // 
            this.radioButtonMobil.AutoSize = true;
            this.radioButtonMobil.Location = new System.Drawing.Point(46, 85);
            this.radioButtonMobil.Name = "radioButtonMobil";
            this.radioButtonMobil.Size = new System.Drawing.Size(50, 17);
            this.radioButtonMobil.TabIndex = 6;
            this.radioButtonMobil.TabStop = true;
            this.radioButtonMobil.Text = "Mobil";
            this.radioButtonMobil.UseVisualStyleBackColor = true;
            // 
            // radioButtonTruk
            // 
            this.radioButtonTruk.AutoSize = true;
            this.radioButtonTruk.Location = new System.Drawing.Point(46, 108);
            this.radioButtonTruk.Name = "radioButtonTruk";
            this.radioButtonTruk.Size = new System.Drawing.Size(47, 17);
            this.radioButtonTruk.TabIndex = 7;
            this.radioButtonTruk.TabStop = true;
            this.radioButtonTruk.Text = "Truk";
            this.radioButtonTruk.UseVisualStyleBackColor = true;
            // 
            // textBoxJamMasuk
            // 
            this.textBoxJamMasuk.Location = new System.Drawing.Point(46, 171);
            this.textBoxJamMasuk.Name = "textBoxJamMasuk";
            this.textBoxJamMasuk.Size = new System.Drawing.Size(229, 20);
            this.textBoxJamMasuk.TabIndex = 8;
            // 
            // textBoxJamKeluar
            // 
            this.textBoxJamKeluar.Location = new System.Drawing.Point(46, 227);
            this.textBoxJamKeluar.Name = "textBoxJamKeluar";
            this.textBoxJamKeluar.Size = new System.Drawing.Size(229, 20);
            this.textBoxJamKeluar.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(210, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(284, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 367);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxJamKeluar);
            this.Controls.Add(this.textBoxJamMasuk);
            this.Controls.Add(this.radioButtonTruk);
            this.Controls.Add(this.radioButtonMobil);
            this.Controls.Add(this.radioButtonMotor);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.RadioButton radioButtonMotor;
        private System.Windows.Forms.RadioButton radioButtonMobil;
        private System.Windows.Forms.RadioButton radioButtonTruk;
        private System.Windows.Forms.TextBox textBoxJamMasuk;
        private System.Windows.Forms.TextBox textBoxJamKeluar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

