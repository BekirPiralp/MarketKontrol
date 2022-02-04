using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.Business.Abstract.UzakMarket;
using Market.Business.Concrete.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using Market.Entity.Concrete;
using System.Threading;

namespace Market.MarketKontrol.Mudur
{
    public partial class FrmHomepage : Form
    {
        class UruneGoreAdet
        {
            public string AdveMarka;
            public int Adet;
        }

        GirisPersonelTut _personel = null;
        BaglantiKontrol _baglanti = null;

        Firma _firma = null;
        Bayi _bayi = null;

        List<Satis> _satislar = null;
        List<Urun> _urunler = null;
        List<Fis> _fisler = null;
        List<UruneGoreAdet> _adetler = null;
        
        IUMSatisService _UMSatisS = null;
        IUMUrunService _uMUrunS = null;
        IUMFisService _uMFisS = null;

        int _ilk20 = 20;
        int _yenileme = 600;

        public FrmHomepage()
        {
            InitializeComponent();
        }

        private void FrmHomepage_Load(object sender, EventArgs e)
        {
            Olustur();
            LoadChart();
            timer1.Interval = _yenileme;
            timer1.Start();
        }

        private void LoadChart()
        {
            try
            {
                VerileriGetir();
                VerileriAyarla();
                chartYukleVeri();
                chartSatis.Update();
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem sırasında hata ile karşılaşıldı.");
            }
        }

        private void VerileriAyarla()
        {
            if(_satislar != null && _urunler != null && _satislar.Count > 0 && _urunler.Count > 0)
            {
                _adetler = new List<UruneGoreAdet>();
                foreach (var urun in _urunler)
                {
                    _adetler.Add(new UruneGoreAdet
                    {
                        AdveMarka = urun.Ad + " " + urun.Marka,
                        Adet = Topla(urun)
                    });
                }
                Sirala();
                for (int i = 0; i < _adetler.Count; i++)
                {
                    if (i + 1 > _ilk20)
                    {
                        _adetler.RemoveAt(i);
                    }
                }
            }
        }

        private void Sirala()
        {
            if (_adetler.Count > 0)
            {
                _adetler = (from adet in _adetler
                            orderby adet.Adet descending
                            select new UruneGoreAdet { Adet = adet.Adet,AdveMarka = adet.AdveMarka}).ToList();
            }
        }

        private int Topla(Urun urun)
        {
            int result = 0;
            try
            {
                result = (from satis in _satislar
                          where satis.Urun == urun.Id
                          select satis.Adet).Sum();
            }
            catch 
            {
                result = 0;
            }
            return result;
                
        }

        private void chartYukleVeri()
        {
            if (_adetler != null&&_adetler.Count > 0)
            {
                if(chartSatis.Series["VeriSerisi"].Points.Count > 0)
                    chartSatis.Series["VeriSerisi"].Points.Clear();
                for (int i = 0; i < _adetler.Count; i++)
                {
                    chartSatis.Series["VeriSerisi"].Points.Add(_adetler[i].Adet);
                    chartSatis.Series["VeriSerisi"].Points[i].AxisLabel = "Adet: " + _adetler[i].Adet +" Ürün: "+ _adetler[i].AdveMarka;
                }
            }
        }

        private void VerileriGetir()
        {
            try
            {
                if (_baglanti.KontrolEt())
                {
                    _fisler = _uMFisS.GetAllByMonth(_personel.firma, _personel.bayi);
                    _urunler = _uMUrunS.GetByAll(_bayi, _firma);
                    _satislar = _UMSatisS.GetAllByFisList(_fisler);

                } else
                    MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz.\n"+
                        "Tekrardan giriş yapınız.");
            }
            catch
            {
                MessageBox.Show("Veriler getiriliken hata oluştu");
            }
        }

        private void Olustur()
        {
            _personel = GirisPersonelTut.Olustur();
            _baglanti = BaglantiKontrol.KontrolGet();

            _UMSatisS = new UMSatisService(new EfSatisDal());
            _uMUrunS = new UMUrunService(new EfUrunDal());
            _uMFisS = new UMFisService(new EfFisDal());

            if(_personel.firma != null && _personel.bayi != null)
            {
                _firma = _personel.firma;
                _bayi = _personel.bayi;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadChart();
        }
    }
}
