namespace Diskon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txttotalbelanja = new System.Windows.Forms.TextBox();
            this.totalBelanja = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdiskon = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.btnhitung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdiskonrp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txttotalbelanja
            // 
            this.txttotalbelanja.Location = new System.Drawing.Point(122, 32);
            this.txttotalbelanja.Name = "txttotalbelanja";
            this.txttotalbelanja.Size = new System.Drawing.Size(195, 23);
            this.txttotalbelanja.TabIndex = 0;
            // 
            // totalBelanja
            // 
            this.totalBelanja.AutoSize = true;
            this.totalBelanja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalBelanja.Location = new System.Drawing.Point(35, 33);
            this.totalBelanja.Name = "totalBelanja";
            this.totalBelanja.Size = new System.Drawing.Size(81, 17);
            this.totalBelanja.TabIndex = 1;
            this.totalBelanja.Text = "Total Belanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Diskon (%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Harga yang harus dibayar";
            // 
            // txtdiskon
            // 
            this.txtdiskon.Location = new System.Drawing.Point(122, 80);
            this.txtdiskon.Name = "txtdiskon";
            this.txtdiskon.Size = new System.Drawing.Size(195, 23);
            this.txtdiskon.TabIndex = 4;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(35, 157);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(282, 23);
            this.txtharga.TabIndex = 5;
            // 
            // btnhitung
            // 
            this.btnhitung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnhitung.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnhitung.Location = new System.Drawing.Point(345, 33);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(84, 70);
            this.btnhitung.TabIndex = 6;
            this.btnhitung.Text = "HITUNG";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Diskon yang didapatkan";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtdiskonrp
            // 
            this.txtdiskonrp.Location = new System.Drawing.Point(35, 218);
            this.txtdiskonrp.Name = "txtdiskonrp";
            this.txtdiskonrp.Size = new System.Drawing.Size(282, 23);
            this.txtdiskonrp.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(468, 274);
            this.Controls.Add(this.txtdiskonrp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.txtdiskon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalBelanja);
            this.Controls.Add(this.txttotalbelanja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txttotalbelanja;
        private Label totalBelanja;
        private Label label2;
        private Label label3;
        private TextBox txtdiskon;
        private TextBox txtharga;
        private Button btnhitung;
        private Label label4;
        private TextBox txtdiskonrp;
    }
}