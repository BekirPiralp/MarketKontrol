using Market.Business.Abstract.UzakMarket;
using Market.Business.Concrete.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using Market.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.FirmaSahibi.FirmaSahibi
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        class BayiyeGoreKazanc
        {
            public Bayi bayi = null;
            public double kazanc = 0;
        }

        GirisPersonelTut _girenPersonel;
        BaglantiKontrol _baglanti;

        List<Bayi> _bayiler = null;
        List<Fis> _fisLer = null;
        List<BayiyeGoreKazanc> _bayilerKazanc = null;
        
        int _ilkSec = 20;
        int _yenileme = 6000;

        IUMFisService _uMFisS;
        IUMBayiService _uMBayiS;

        private void Homepage_Load(object sender, EventArgs e)
        {
            
            Olustur();
            Kontrol();
            timer1.Interval = _yenileme;
            timer1.Start();
        }


        private void BaglantiHata()
        {
            MessageBox.Show("Lütfen internet bağlantınız kontrol edip yeniden giriş yapınız.");
        }

        private void Yenile()
        {
            if(_bayilerKazanc != null && _bayilerKazanc.Count>0)
                _bayilerKazanc.Clear();
            try
            {
                        chartIslem();
            }
            catch
            {
                MessageBox.Show("Yenileme sırasında bir hata oluştu.");
            }
        }

        private void Kontrol()
        {
            if (!_baglanti.KontrolEt())
                BaglantiHata();
        }

        private void Olustur()
        {
            _girenPersonel = GirisPersonelTut.Olustur();
            _baglanti = BaglantiKontrol.KontrolGet();

            _uMFisS = new UMFisService(new EfFisDal());
            _uMBayiS = new UMBayiService(new EfBayiDal());

            

            if (_baglanti.KontrolEt())
            {
                if (_girenPersonel.firma != null && _girenPersonel.firma.Id > 0)
                {
                    _bayiler = _uMBayiS.GetAllByFirma(_girenPersonel.firma);

                    if (_bayiler != null && _bayiler.Count > 0)
                    {
                        _bayilerKazanc = new List<BayiyeGoreKazanc>();
                        chartIslem();
                    }
                }
                else
                    MessageBox.Show("Giren personel ile gelmesi gereken bilgiler tam gelmediği için \n" +
                        "işleminizi gerçekleştiremiyoruz");

            }
            else
                BaglantiHata();
        }

        private void  chartIslem()
        {
            KazancAl();
            Sirala();
            Sec();
            EkranaBas();
            chartBayi.Update();
        }

        private void EkranaBas()
        {
            if(_bayilerKazanc != null && _bayilerKazanc.Count > 0)
            {
                if(chartBayi.Series["Veri"].Points.Count>0)
                    chartBayi.Series["Veri"].Points.Clear();
                for (int i = 0; i < _bayilerKazanc.Count; i++)
                {
                    chartBayi.Series["Veri"].Points.Add(_bayilerKazanc[i].kazanc);
                    chartBayi.Series["Veri"].Points[i].AxisLabel = "Bayi: " + _bayilerKazanc[i].bayi.BayiAd +
                        " Kazanç: " + _bayilerKazanc[i].kazanc + " TL";
                }
            }
        }

        private void Sec()
        {
            if(_bayilerKazanc != null && _bayilerKazanc.Count > 0)
            {
                List<BayiyeGoreKazanc> liste = new List<BayiyeGoreKazanc>();
                for (int i = 0; i < _bayilerKazanc.Count; i++)
                {
                    if (i < _ilkSec)
                    {
                        liste.Add(_bayilerKazanc[i]);
                    }
                    else
                        break;
                }
                _bayilerKazanc = liste;
            }
        }

        private void Sirala()
        {
            if(_bayilerKazanc != null && _bayilerKazanc.Count > 0)
            {
                _bayilerKazanc = (from bayik in _bayilerKazanc
                                 orderby bayik.kazanc descending // Büyükten ufağa sırala
                                 select new BayiyeGoreKazanc { bayi = bayik.bayi, kazanc = Math.Round(bayik.kazanc,2) }).ToList();
            }
        }

        bool kontrol = true; //kazanç varmı
        private void KazancAl()
        {
            _fisLer = null;
            if (_baglanti.KontrolEt())
            {
                if (_bayilerKazanc != null)
                {
                    kontrol = true;
                    double toplam = 0;
                    foreach (var bayi in _bayiler)
                    {
                        toplam = 0;
                        _fisLer = _uMFisS.GetAllByMonth(_girenPersonel.firma, bayi);
                        if (_fisLer != null && _fisLer.Count > 0)
                        {
                            foreach (var fis in _fisLer)
                            {
                                toplam += fis.ToplamFiyat;
                            }
                        }

                        _bayilerKazanc.Add(new BayiyeGoreKazanc
                        {
                            bayi = bayi,
                            kazanc = toplam
                        });
                    }
                }
                else
                {
                    if (kontrol)
                    {
                        kontrol = false;
                        MessageBox.Show("Bayilerin satış bilgileri gelmedi.");
                    }
                }
            }
            else
                BaglantiHata();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
