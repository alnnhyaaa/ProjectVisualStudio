using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkirKendaraan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jenisKendaraan = string.Empty;

            if (radioButtonMotor.Checked)
                jenisKendaraan = "Motor";
            else if (radioButtonMobil.Checked)
                jenisKendaraan = "Mobil";
            else if (radioButtonTruk.Checked)
                jenisKendaraan = "Truk";

            string jamMasukText = textBoxJamMasuk.Text;
            string jamKeluarText = textBoxJamKeluar.Text;

            if (!string.IsNullOrWhiteSpace(jenisKendaraan) && !string.IsNullOrWhiteSpace(jamMasukText) && !string.IsNullOrWhiteSpace(jamKeluarText))
            {
                try
                {
                    DateTime jamMasuk = DateTime.Parse(jamMasukText);
                    DateTime jamKeluar = DateTime.Parse(jamKeluarText);

                    TimeSpan durasiParkir = jamKeluar - jamMasuk;

                    double tarif = 0;

                    switch (jenisKendaraan)
                    {
                        case "Mobil":
                            tarif = durasiParkir.TotalHours * 5000; // Tarif parkir mobil per jam
                            break;
                        case "Motor":
                            tarif = durasiParkir.TotalHours * 2000; // Tarif parkir motor per jam
                            break;
                        case "Truk":
                            tarif = durasiParkir.TotalHours * 7000; // Tarif parkir truk per jam
                            break;
                    }

                    labelHasil.Text = "Tarif parkir untuk " + jenisKendaraan + " selama " + durasiParkir.TotalHours + " jam adalah: Rp " + tarif;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Format waktu tidak valid. Pastikan Anda memasukkan waktu dengan format yang benar (HH:mm).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silakan lengkapi semua informasi yang diperlukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButtonMobil.Checked = false;
            radioButtonMotor.Checked = false;
            radioButtonTruk.Checked = false;
            textBoxJamMasuk.Clear();
            textBoxJamKeluar.Clear();
            labelHasil.Text = "Total";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
