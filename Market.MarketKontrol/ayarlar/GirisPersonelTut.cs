using entity = Market.Entity.Concrete;
namespace Market.MarketKontrol.ayarlar
{
    public class GirisPersonelTut
    {
        private entity.Personel personel { get; set; }
        private entity.PersonelAdres adres { get; set; }
        private entity.PersonelSifre sifre { get; set; }
        private entity.Fotograf fotograf { get; set; }
        private entity.EkBilgi ekBilgi { get; set; }
        private bool Mudur = false;
        private static GirisPersonelTut girisPersonel = null;

        private GirisPersonelTut() { }

        public static GirisPersonelTut Olustur()
        {
            if(girisPersonel == null)
            {
                girisPersonel = new GirisPersonelTut();
            }
            return girisPersonel;
        }
        public void SetPersonel
            (entity.Personel personel, entity.PersonelAdres adres,
            entity.PersonelSifre sifre, entity.Fotograf fotograf, entity.EkBilgi ekBilgi,entity.Mudur mudur)
        {
            this.personel= personel;
            this.sifre = sifre;
            this.adres = adres;
            this.ekBilgi = ekBilgi;
            this.fotograf = fotograf;

            if (mudur != null)
                Mudur = true;
            else
                Mudur = false;
        }

    }
}
