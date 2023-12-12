using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitap_ornk
{
    internal class Kitap
    {
        int id;
        string kitapAd;
        string yazar;
        string sayfaSayisi;
        string tur;
        DateTime tarih;
        bool ciltli;

        public int Id { get => id; set => id = value; }
        public string KitapAd { get => kitapAd; set => kitapAd = value; }
        public string Yazar { get => yazar; set => yazar = value; }
        public string SayfaSayisi { get => sayfaSayisi; set => sayfaSayisi = value; }
        public string Tur { get => tur; set => tur = value; }
        public DateTime Tarih { get => tarih; set => tarih = value; }
        public bool Ciltli { get => ciltli; set => ciltli = value; }

        public Kitap(int id, string kitapAd, string yazar, string sayfaSayisi, string tur, DateTime tarih, bool ciltli)
        {
            this.id = id;
            this.kitapAd = kitapAd;
            this.yazar = yazar;
            this.sayfaSayisi = sayfaSayisi;
            this.tur = tur;
            this.tarih = tarih;
            this.ciltli = ciltli;
        }
    }
}
