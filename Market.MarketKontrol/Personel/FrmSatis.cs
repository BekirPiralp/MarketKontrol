using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.Business.Abstract.LochalMarket;
using Market.Business.Abstract.UzakMarket;
using Market.Business.Concrete.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using UM = Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using Market.Entity.Concrete;
using Market.MarketKontrol.ayarlar;
using LM = Market.DataAccess.Concrete.LochalMarket.EntityFramework;
using Market.Business.Concrete.LochalMarket;

namespace Market.MarketKontrol.Personel
{
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private class SatisListesi {
            public Urun urun { get; set; }
            public int Adet { get; set; }
        }
        private struct Ilkhal
        {
            public Urun urun;
            public string lbxSatis;
            public string PersonelIsim;
            public string ToplamFiyat;
        }

        private BaglantiKontrol _baglanti;
        private IUMUrunService _uMUrunService;
        private IUMSatisService _uMSatisService;
        private IUMFisService _uMFisService;
        private ILMUrunService _lMUrunService;
        private ILMSatisService _lMSatisService;
        private ILMFisService _lMFisService;
        private GirisPersonelTut _personel;
        private Ilkhal _ilkhal;
        
        private List<SatisListesi> _satisListesi = null;
        private Urun _urun = null;

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            Olustur();

            ilkHalAl();
            _baglanti.KontrolEt();
        }

        private void Olustur()
        {
            _baglanti = BaglantiKontrol.KontrolGet();
            _personel = GirisPersonelTut.Olustur();

            _ilkhal = new Ilkhal();
            _uMUrunService = new UMUrunService(new UM.EfUrunDal());
            _uMSatisService = new UMSatisService(new UM.EfSatisDal());
            _uMFisService = new UMFisService(new UM.EfFisDal());
            _lMUrunService = new LMUrunService(new LM.EfUrunDal());
            _lMSatisService = new LMSatisService(new LM.EfSatisDal());
            _lMFisService = new LMFisService(new LM.EfFisDal());
            //_satisListesi kullanıma gerektiği anda üretilecek
        }

        private void ilkHalAl()
        {
            _ilkhal.urun = new Urun {
                Barkod = tbxBarkod.Text,
                Adet = (int)numAdet.Value,
                Fiyat = float.Parse(lblFiyat.Text),
                Indirim = float.Parse(lblindirim.Text)
            };
            _ilkhal.urun.ResimSet(pbxUrun.Image);
            _ilkhal.lbxSatis = lbxSatis.Text;
            _ilkhal.PersonelIsim = lblPersonelisim.Text;
            _ilkhal.ToplamFiyat = lblFiyat.Text;
        }

        private void EkranaUrunBas(Urun urun)
        {
            if (urun == null)
                urun = _ilkhal.urun;
            //tbxBarkod.Text = urun.Barkod;
            numAdet.Value = 1;
            lblFiyat.Text = urun.Fiyat.ToString();
            lblindirim.Text = urun.Indirim.ToString();
            //KdvSabit ;D
            pbxUrun.Image = urun.ResimGet();
        }

        //Satış listessinde istenilen ürün varsa  indexi diğerdurumlarda 0 döner
        private int SatisIndexBul(Urun urun)
        {
            int index = 0;
            if(urun != null && urun.Id>0 && _satisListesi != null && _satisListesi.Count > 0)
            {
                for (int i = 0; i < _satisListesi.Count; i++)
                {
                    if(_satisListesi[i].urun.Id == urun.Id)
                    {
                        index = i;
                        break;
                    } 
                }
            }
            return index;
        }

        private void Temizle()
        {
            EkranaUrunBas(_ilkhal.urun);
            lbxSatis.Items.Clear();
            lbxSatis.Text = _ilkhal.lbxSatis;
            tbxBarkod.Text = _ilkhal.urun.Barkod;
            lblToplamFiyat.Text = _ilkhal.ToplamFiyat;
            lblPersonelisim.Text = _personel.personel == null ? _ilkhal.PersonelIsim
                : (_personel.personel.Ad + " " + _personel.personel.Soyad.ToUpper());

            _satisListesi=null;
        }
        
        //satış iptal
        private void buttoniptal_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =
                MessageBox.Show("Eminmisiniz ?!", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                Temizle();
            }
        }

        private void textBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            KlavyeOlay.NumKeyPress(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarihSaat.Text = DateTime.Now.ToString();
        }

        private void LbxSatisUpdate()
        {
            if(_satisListesi != null && _satisListesi.Count > 0)
            {
                float ToplamFiyat = 0;
                lbxSatis.Items.Clear();
                foreach (var item in _satisListesi)
                {
                    lbxSatis.Items.Add(item.urun.Ad + " " + item.urun.Marka + " X " + item.Adet.ToString());
                    ToplamFiyat += (item.urun.Fiyat * item.Adet);
                }
                lblFiyat.Text = ToplamFiyat.ToString();
            }
            else
            {
                Temizle();
            }
        }

        private void textBoxBarkod_MouseHover(object sender, EventArgs e)
        {
            MouseOlay.tbxMouseHover(sender);
        }

        private void textBoxBarkod_TextChanged(object sender, EventArgs e)
        {
            _urun = null;
            try
            {
                if (_baglanti.KontrolEt())
                {
                    _urun = _uMUrunService.GetByBarkod(tbxBarkod.Text, _personel.bayi, _personel.firma);
                }
                else
                {
                    _urun = _lMUrunService.GetByBarkod(tbxBarkod.Text, _personel.bayi, _personel.firma);
                }
            }
            catch( Exception Hata)
            {
                MessageBox.Show(Hata.Message);
            }
            finally
            {
                EkranaUrunBas(_urun);
            }
        }


        /*Fise ekleme*/
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (_urun != null)
            {
                if (_satisListesi == null)
                {
                    _satisListesi = new List<SatisListesi>();
                }

                if (SatisIndexBul(_urun) > 0 && 
                    _urun.Adet >= 
                    (_satisListesi[SatisIndexBul(_urun)].Adet + (int)numAdet.Value))
                {
                    _satisListesi[SatisIndexBul(_urun)].Adet += (int)numAdet.Value;
                }
                else
                {
                    if (_urun.Adet >= (int)numAdet.Value )
                    {
                        _satisListesi.Add(new SatisListesi { urun = _urun, Adet = (int)numAdet.Value }); 
                    }
                }
                LbxSatisUpdate();
            }
        }

        //Ürün çıkarma
        private void btnCikar_Click(object sender, EventArgs e)
        {
            if(_urun != null)
            {
                if(_satisListesi == null || _satisListesi.Count == 0)
                {
                    Temizle();
                }
                else
                {
                    if (SatisIndexBul(_urun) > 0)
                    {
                        if (_satisListesi[SatisIndexBul(_urun)].Adet <= (int)numAdet.Value)
                        {
                            _satisListesi.RemoveAt(SatisIndexBul(_urun));
                        }
                        else
                        {
                            _satisListesi[SatisIndexBul(_urun)].Adet -= (int)numAdet.Value;
                        }
                        LbxSatisUpdate();
                    }
                }
            }
        }

        //ürün satış ve onay
        private void buttonSat_Click(object sender, EventArgs e)
        {
            
            if(_satisListesi != null && _satisListesi.Count > 0)
            {
                Fis fis;
                Satis satis;
                DateTime tarihSaat;
                try
                {
                    if (_personel != null && _personel.bayi != null && _personel.firma != null && _personel.personel != null &&
                            _personel.personel.Id > 0 && _personel.bayi.Id > 0 && _personel.firma.Id > 0)
                    {
                        float tFiyatHesapla()
                        {
                            float toplam = 0;
                            foreach (var item in _satisListesi)
                            {
                                toplam += item.Adet * (item.urun.Fiyat - (item.urun.Fiyat * item.urun.Indirim / 100));
                            }
                            return toplam;
                        }

                        tarihSaat = DateTime.Now;
                        fis = new Fis
                        {
                            Bayi = _personel.bayi.Id,
                            Firma = _personel.firma.Id,
                            Personel = _personel.personel.Id,
                            TarihSaat = tarihSaat,
                            Kod = tarihSaat.ToString() + _personel.personel.Tc,
                            ToplamFiyat = tFiyatHesapla()
                        };

                        if (_baglanti.KontrolEt())
                        {
                            _uMFisService.Add(fis);
                            fis = _uMFisService.GetByDateTime(_personel.firma, _personel.bayi, _personel.personel, tarihSaat);
                            if (fis == null)
                                throw new Exception("Fis olusturma sırasında bir hata ile karşılaşıldı.");
                            foreach (var item in _satisListesi)
                            {
                                satis = new Satis
                                {
                                    Adet = item.Adet,
                                    Bayi = item.urun.Bayi,
                                    Firma = item.urun.Firma,
                                    Fis = fis.Id,
                                    Urun = item.urun.Id
                                };
                                _uMSatisService.Add(satis);
                                satis = null;
                            }
                            for (int i = 0; i < _satisListesi.Count; i++)
                            {
                                _satisListesi[i].urun.Adet -= _satisListesi[i].Adet;
                                _uMUrunService.Update(_satisListesi[i].urun);
                            }
                        }
                        else
                        {
                            _lMFisService.Add(fis);
                            fis = _lMFisService.GetByDateTime(_personel.firma, _personel.bayi, _personel.personel, tarihSaat);
                            if (fis == null)
                                throw new Exception("Fis olusturma sırasında bir hata ile karşılaşıldı.");
                            foreach (var item in _satisListesi)
                            {
                                satis = new Satis
                                {
                                    Adet = item.Adet,
                                    Bayi = item.urun.Bayi,
                                    Firma = item.urun.Firma,
                                    Fis = fis.Id,
                                    Urun = item.urun.Id
                                };
                                _lMSatisService.Add(satis);
                                satis = null;
                            }
                            for (int i = 0; i < _satisListesi.Count; i++)
                            {
                                _satisListesi[i].urun.Adet -= _satisListesi[i].Adet;
                                _lMUrunService.Update(_satisListesi[i].urun);
                            }
                        }
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
            }
            Temizle();
        }

        
    }
}
