using System;
using Market.Business.Abstract;
using Market.Business.Abstract.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using entity = Market.Entity.Concrete;
using LMS = Market.Business.Concrete.LochalMarket;
using LMDE = Market.DataAccess.Concrete.LochalMarket.EntityFramework;
namespace Market.Business.Concrete.DigerIslemler
{
    public class GirisPersonelTut :IGirisPersonelTut
    {
        public entity.Personel personel { get; set; }
        public entity.PersonelAdres adres { get; set; }
        public entity.PersonelSifre sifre { get; set; }
        public entity.Fotograf fotograf { get; set; }
        public entity.EkBilgi ekBilgi { get; set; }
        public entity.Bayi bayi { get; set; }
        public entity.Firma firma { get; set; }
        public static bool _mudur {get; set;}

        private IPersonelSifreService _pSifreS;
        private IPersonelAdresService _pAdresS;
        private IFotografService _fotografS;
        private IEkBilgiService _ekBilgiS;
        private IMudurService _mudurS;
        private IBayiService _LMbayiS,_UMbayiS;
        private IFirmaService _LMfirmaS,_UMfirmaS;

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
            sifirla();
            this.personel= personel;
            if (personel != null && personel.Id > 0)
                getir();
            
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
                _LMbayiS = new LMS.LMBayiService(new LMDE.EfBayiDal());
                _LMfirmaS = new LMS.LMFirmaService(new LMDE.EfFirmaDal());
                _UMbayiS = new UMBayiService(new EfBayiDal());
                _UMfirmaS = new UMFirmaService(new EfFirmaDal());
            }

            this.sifre = _pSifreS.GetByPersonelId(personel.Id);
            this.adres = _pAdresS.GetByPersonelId(personel.Id);
            this.ekBilgi = _ekBilgiS.GetByPersonelId(personel.Id);
            this.fotograf = _fotografS.GetByPersonelId(personel.Id);
            _mudur = _mudurS.GetByPersonelId(personel.Id) != null ? true : false;

            if (_LMbayiS.GetAll().Count>0)
            {
                try
                {
                    BayiFirmaAl();
                }
                catch 
                {
                    BayiFirmaAta();
                }
                
            }
            else
            {
                BayiFirmaAta(true);
            }

            void BayiFirmaAta(bool bayi = false)
            {
                if (_mudur)
                {
                    if (bayi)
                    {
                        foreach (var item in _LMbayiS.GetAll())
                        {
                            _LMbayiS.Delete(item);
                        }
                    }
                    try
                    {
                        foreach (var item in _LMfirmaS.GetAll())
                        {
                            _LMfirmaS.Delete(item);
                        }
                    }
                    catch {}
                    _LMbayiS.Add(_UMbayiS.GetById(_mudurS.GetByPersonelId(personel.Id).Bayi));
                    _LMfirmaS.Add(_UMfirmaS.GetById(_mudurS.GetByPersonelId(personel.Id).Firma));
                    BayiFirmaAl();
                }
                else
                {
                    throw new Exception("Veri tabanında kayıtlarda sıkıntı var lütfen müdürünüz giriş yapsın");
                }
            }
            void BayiFirmaAl()
            {
                firma = _LMfirmaS.GetById(_LMbayiS.GetAll()[0].Firma);
                bayi = _LMbayiS.GetAll()[0];
            }
        }
        private void sifirla()
        {
            this.sifre = null;
            this.adres = null;
            this.ekBilgi = null;
            this.fotograf = null;
            this.bayi = null;
            this.firma = null;
            _mudur = false;
        }

    }
}
