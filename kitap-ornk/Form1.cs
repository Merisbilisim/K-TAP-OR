using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kitap_ornk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Kitap Kitap;
        List<Kitap> KitapListesi=new List <Kitap>();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KitapListesi.Add(new Kitap(1, "Sokak Nöbetçileri", "Aslı Arslan", "624", "Roman", new DateTime(2023, 12, 12), true));
            KitapListesi.Add(new Kitap(2, "Yüzükler Efendisi", " J.R.R", "1026", "Fantastik", new DateTime(2022,01,24), false));
            KitapListesi.Add(new Kitap(3, "Paranormal Olaylar", "Işıl Işık", "288", "Korku", new DateTime(2020, 10, 14), false));
            KitapListesi.Add(new Kitap(4, "Öykü Baharı", "Özgür Sinan", "480", "Öykü", new DateTime(2022, 12, 10), true));
            KitapListesi.Add(new Kitap(4, "sıcak Kafa", "Afsin Kum", "192", "Bilim Kurgu", new DateTime(2016, 11, 9),false));
            KitapListesi.Add(new Kitap(4, "Çiçek Senfonisi", "Özdemir Asaf", "488", "Şiir", new DateTime(2008, 12, 16), true));

            dgvListe.DataSource = KitapListesi.ToList();
        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            txtKitapAd.Text = dgvListe.CurrentRow.Cells["kitapAd"].Value.ToString();
            txtYazar.Text = dgvListe.CurrentRow.Cells["yazar"].Value.ToString();
            txtSayfaSayisi.Text = dgvListe.CurrentRow.Cells["sayfaSayisi"].Value.ToString();
            cmbTur.Text = dgvListe.CurrentRow.Cells["tur"].Value.ToString();
            dtpTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["tarih"].Value;
            chkCiltli.Checked = (bool)dgvListe.CurrentRow.Cells["ciltli"].Value;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtId.Text);
            string ad=txtKitapAd.Text;
            string yazar=txtYazar.Text;
            string sayfaSayisi = txtSayfaSayisi.Text;
            string tur=cmbTur.Text;
            DateTime tarih=dtpTarih.Value;
            bool ciltli=chkCiltli.Checked;

            Kitap yenikitaplar=new Kitap(id,ad,yazar,sayfaSayisi,tur,tarih,ciltli);

            KitapListesi.Add(yenikitaplar);
            dgvListe.DataSource = KitapListesi.ToList();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilensatir=dgvListe.Rows[0];
            Kitap seçilenKitap=secilensatir.DataBoundItem as Kitap;
            int id =Convert.ToInt32(txtId.Text);
            string kitapAd=txtKitapAd.Text;
            string yazar = txtYazar.Text;
            string sayfaSayisi = txtSayfaSayisi.Text;
            string tur = cmbTur.Text;
            bool cilt = chkCiltli.Checked;
            DateTime tarih = dtpTarih.Value;


            seçilenKitap.Id = id;
            seçilenKitap.KitapAd = kitapAd;
            seçilenKitap.Yazar= yazar;
            seçilenKitap.SayfaSayisi= sayfaSayisi;
            seçilenKitap.Tur=tur;
            seçilenKitap.Tarih= tarih;
            seçilenKitap.Ciltli= cilt;

            dgvListe.DataSource=null;
            dgvListe.DataSource=KitapListesi.ToList();
        }

        private void btnSİL_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir = dgvListe.SelectedRows[0];
            Kitap secilenKitap=secilenSatir.DataBoundItem as Kitap;
            DialogResult=MessageBox.Show("Seçilen Kitap Silinsin mi?","Kitap Sil", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (DialogResult == DialogResult.Yes)
            {
                KitapListesi.Remove(secilenKitap);
            }
            dgvListe.DataSource = KitapListesi.ToList();
        }
    }
}
