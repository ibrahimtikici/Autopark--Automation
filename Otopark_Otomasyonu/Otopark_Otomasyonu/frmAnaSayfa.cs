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
            frmAra�OtoparkKayd� kayit = new frmAra�OtoparkKayd�();
            kayit.ShowDialog();
        }

        private void btnAracYerleri_Click(object sender, EventArgs e)
        {
            frmAra�OtoparkYerleri yer = new frmAra�OtoparkYerleri();
            yer.ShowDialog();
        }

        private void btnAracCikis_Click(object sender, EventArgs e)
        {
            frmAra�Otopark��k��� ��k�� = new frmAra�Otopark��k���();
            ��k��.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSat�� satis = new frmSat��();
            satis.ShowDialog();

        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}