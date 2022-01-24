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
using LM = Market.DataAccess.Concrete.LochalMarket.EntityFramework;
using UM = Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using Market.Business.Concrete.LochalMarket;
using Market.Business.Concrete.UzakMarket;
using Market.Business.Concrete.DigerIslemler;
using Market.Entity.Concrete;
using Market.MarketKontrol.ayarlar;

namespace Market.MarketKontrol.Personel
{
    public partial class FrmDefo : Form
    {
        public FrmDefo()
        {
            InitializeComponent();
        }

        private IUMUrunService _uMUrunService;
        private ILMUrunService _lMUrunService;
        private IUMDefoService _uMDefoService;
        private ILMDefoService _lMDefoService;

        private BaglantiKontrol _baglanti;
        private GirisPersonelTut _personelTut;

        private Urun _urun = null;
        private Defo _defo = null;

        private void FrmDefo_Load(object sender, EventArgs e)
        {
            Olustur();
        }

        private void Olustur()
        {
            _personelTut = GirisPersonelTut.Olustur();
            _baglanti = BaglantiKontrol.KontrolGet();

            _uMUrunService = new UMUrunService(new UM.EfUrunDal());
            _uMDefoService = new UMDefoService(new UM.EfDefoDal());

            _lMUrunService = new LMUrunService(new LM.EfUrunDal());
            _lMDefoService = new LMDefoService(new LM.EfDefoDal());
        }

        private void Temizle()
        {
            _urun = null;
            _defo = null;

            tbxAciklama.Text = "";
            tbxBarkod.Text = "";
            numAdet.Value = 1;
        }

        private void tbxMouseHover(object sender, EventArgs e)
        {
            MouseOlay.tbxMouseHover(textBox: sender);
        }

        private void tbxNumKeyPress(object sender, KeyPressEventArgs e)
        {
            KlavyeOlay.NumKeyPress(e);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (_baglanti.KontrolEt())
                {
                    _urun = _uMUrunService.GetByBarkod(tbxBarkod.Text.Trim(), _personelTut.bayi, _personelTut.firma);
                    if (_urun != null && _personelTut.bayi != null && _personelTut.firma != null && _personelTut.personel != null &&
                        _personelTut.bayi.Id > 0 && _personelTut.firma.Id > 0 && _personelTut.personel.Id > 0)
                    {
                        _defo = new Defo
                        {
                            Aciklama = tbxAciklama.Text.Trim(),
                            Adet = (int)numAdet.Value,
                            Bayi = _personelTut.bayi.Id,
                            Firma = _personelTut.firma.Id,
                            Personel = _personelTut.personel.Id,
                            Urun = _urun.Id,
                            TarihSaat = DateTime.Now
                        };
                        _uMDefoService.Add(_defo);
                        _urun.Adet -= _defo.Adet;
                        _uMUrunService.Update(_urun);
                    }
                }
                else
                {
                    _urun = _lMUrunService.GetByBarkod(tbxBarkod.Text.Trim(), _personelTut.bayi, _personelTut.firma);
                    if (_urun != null && _personelTut.bayi != null && _personelTut.firma != null && _personelTut.personel != null &&
                        _personelTut.bayi.Id > 0 && _personelTut.firma.Id > 0 && _personelTut.personel.Id > 0)
                    {
                        _defo = new Defo
                        {
                            Aciklama = tbxAciklama.Text.Trim(),
                            Adet = (int)numAdet.Value,
                            Bayi = _personelTut.bayi.Id,
                            Firma = _personelTut.firma.Id,
                            Personel = _personelTut.personel.Id,
                            Urun = _urun.Id,
                            TarihSaat = DateTime.Now
                        };
                        _lMDefoService.Add(_defo);
                        _urun.Adet -= _defo.Adet;
                        _lMUrunService.Update(_urun);
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Defo nesnesini sisteme kayıt esnasında hata ile karşılaşıldı. Hata :\n" + hata.Message);
            }
            finally
            {
                Temizle();
            }
        }
    }
}
