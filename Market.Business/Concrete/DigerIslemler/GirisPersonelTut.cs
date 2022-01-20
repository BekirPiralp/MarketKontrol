using Market.Business.Abstract;
using Market.Business.Abstract.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using entity = Market.Entity.Concrete;
namespace Market.Business.Concrete.DigerIslemler
{
    public class GirisPersonelTut :IGirisPersonelTut
    {
        private entity.Personel personel { get; set; }
        private entity.PersonelAdres adres { get; set; }
        private entity.PersonelSifre sifre { get; set; }
        private entity.Fotograf fotograf { get; set; }
        private entity.EkBilgi ekBilgi { get; set; }
        private static bool _mudur {get; set;}

        private IPersonelSifreService _pSifreS;
        private IPersonelAdresService _pAdresS;
        private IFotografService _fotografS;
        private IEkBilgiService _ekBilgiS;
        private IMudurService _mudurS;

        private static GirisPersonelTut girisPersonel = null;

        private GirisPersonelTut() { }

        public static GirisPersonelTut Olustur()
        {
            if(girisPersonel == null)
            {
                girisPersonel = new GirisPersonelTut();
                _mudur = false;
            }
            return girisPersonel;
        }

        

        /// <summary>
        /// Personel Nesnesi Sayesinde diğer özellikleri otomatik set ediliyor
        /// </summary>
        /// <param name="personel"></param>
        
        public void SetPersonel(entity.Personel personel)
        {

            this.personel= personel;
            if (personel != null && personel.Id > 0)
                getir();
            else
                sifirla();

        }

        private void getir()
        {
            if (_pSifreS == null)
            {
                _pSifreS = new UMPersonelSifreService(new EfPersonelSifreDal());
                _pAdresS = new UMPersonelAdresService(new EfPersonelAdresDal());
                _ekBilgiS = new UMEkBilgiService(new EfEkBilgiDal());
                _fotografS = new UMFotografService(new EfFotografDal());
                _mudurS = new UMMudurService(new EfMudurDal());
            }

            this.sifre = _pSifreS.GetByPersonelId(personel.Id);
            this.adres = _pAdresS.GetByPersonelId(personel.Id);
            this.ekBilgi = _ekBilgiS.GetByPersonelId(personel.Id);
            this.fotograf = _fotografS.GetByPersonelId(personel.Id);
            _mudur = _mudurS.GetByPersonelId(personel.Id) != null ? true : false;
        }
        private void sifirla()
        {
            this.sifre = null;
            this.adres = null;
            this.ekBilgi = null;
            this.fotograf = null;
            _mudur = false;
        }

    }
}
