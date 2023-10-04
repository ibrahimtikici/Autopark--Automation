namespace Otopark_Otomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnAracKayit_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkKaydý kayit = new frmAraçOtoparkKaydý();
            kayit.ShowDialog();
        }

        private void btnAracYerleri_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkYerleri yer = new frmAraçOtoparkYerleri();
            yer.ShowDialog();
        }

        private void btnAracCikis_Click(object sender, EventArgs e)
        {
            frmAraçOtoparkÇýkýþý çýkýþ = new frmAraçOtoparkÇýkýþý();
            çýkýþ.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSatýþ satis = new frmSatýþ();
            satis.ShowDialog();

        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}