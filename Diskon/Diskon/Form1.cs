namespace Diskon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalBelanja = int.Parse(txttotalbelanja.Text);
            int diskon = int.Parse(txtdiskon.Text);
            int diskonDapet = (int)((double)diskon / 100.0 * (double)totalBelanja);
            int sisaUang = totalBelanja - diskonDapet;
            txtharga.Text = sisaUang.ToString();
            txtdiskonrp.Text = diskonDapet.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
                
        }
    }
}