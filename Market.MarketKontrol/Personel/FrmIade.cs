using System;
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
    public partial class FrmIade : Form
    {
        public FrmIade()
        {
            InitializeComponent();
        }

        private IUMIadeService _uMIadeService;
        private ILMIadeService _lMIadeService;
        private IUMSatisService _uMSatisService;
        private ILMSatisService _lMSatisService;
        private IUMFisService _uMFisService;
        private ILMFisService _lMFisService;
        private IUMUrunService _uMUrunService;
        private ILMUrunService _lMUrunService;

        private BaglantiKontrol _baglanti;
        private GirisPersonelTut _personelTut;

        private Satis _satis; //duruma göre çekilecek ve oluşturulacak
        private Fis _fis;
        private Urun _urun;
        private Iade _iade; //Daha önce çoklu ürün alıp iade etmiş olabilir.

        private void FrmIade_Load(object sender, EventArgs e)
        {
            Olustur();
        }

        private void Olustur()
        {
            _personelTut = GirisPersonelTut.Olustur();
            _baglanti = BaglantiKontrol.KontrolGet();

            _uMIadeService = new UMIadeService(new UM.EfIadeDal());
            _uMSatisService = new UMSatisService(new UM.EfSatisDal());
            _uMFisService = new UMFisService(new UM.EfFisDal());
            _uMUrunService = new UMUrunService(new UM.EfUrunDal());

            _lMIadeService = new LMIadeService(new LM.EfIadeDal());
            _lMSatisService = new LMSatisService(new LM.EfSatisDal());
            _lMFisService = new LMFisService(new LM.EfFisDal());
            _lMUrunService = new LMUrunService(new LM.EfUrunDal());

        }

        private void Temizle()
        {
            _satis = null;
            _iade = null;
            _fis = null;
            _urun = null;
            
            tbxFisKod.Text = "";
            tbxBarkod.Text = "";
            tbxAciklama.Text = "";
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
                    _fis = _uMFisService.GetByFisKod(tbxFisKod.Text.Trim());
                    if (_fis != null)
                    {
                        _urun = _uMUrunService.GetByBarkod(tbxBarkod.Text.Trim(), _personelTut.bayi, _personelTut.firma);
                        if (_urun != null)
                        {
                            _satis = _uMSatisService.GetByBarkodFisKod(_personelTut.bayi, _personelTut.firma, _urun, _fis);
                            if (_satis != null)
                            {
                                _iade = _uMIadeService.GetByFisSatis(_personelTut.firma, _personelTut.bayi, _fis, _satis);
                                if (_iade == null)
                                {
                                    _iade = new Iade
                                    {
                                        Firma = _personelTut.firma.Id,
                                        Bayi = _personelTut.bayi.Id,
                                        Fis = _fis.Id,
                                        Satis = _satis.Id,
                                        Personel = _personelTut.personel.Id,
                                        Aciklama = tbxAciklama.Text.Trim(),
                                        TarihSaat = DateTime.Now
                                    };
                                    _uMIadeService.Add(_iade);
                                }
                                else
                                {
                                    throw new Exception("Bu ürün daha önce iade edilmiş");
                                }
                            }
                            else
                            {
                                throw new Exception("Kayıtlarda böyle bir şatış bilgisine ulaşılamadı.");
                            }
                        }
                        else
                        {
                            throw new Exception("Kayıtlarda böyle bir şatışa ait ürün bilgisine ulaşılamadı.");
                        }
                    }
                    else
                    {
                        throw new Exception("Kayıtlarda böyle bir şatışa ait fiş bilgisine ulaşılamadı.");
                    }
                }
                else
                {
                    _fis = _lMFisService.GetByFisKod(tbxFisKod.Text.Trim());
                    if (_fis != null)
                    {
                        _urun = _lMUrunService.GetByBarkod(tbxBarkod.Text.Trim(), _personelTut.bayi, _personelTut.firma);
                        if (_urun != null)
                        {
                            _satis = _lMSatisService.GetByBarkodFisKod(_personelTut.bayi, _personelTut.firma, _urun, _fis);
                            if (_satis != null)
                            {
                                _iade = _lMIadeService.GetByFisSatis(_personelTut.firma, _personelTut.bayi, _fis, _satis);
                                if (_iade == null)
                                {
                                    _iade = new Iade
                                    {
                                        Firma = _personelTut.firma.Id,
                                        Bayi = _personelTut.bayi.Id,
                                        Fis = _fis.Id,
                                        Satis = _satis.Id,
                                        Personel = _personelTut.personel.Id,
                                        Aciklama = tbxAciklama.Text.Trim(),
                                        TarihSaat = DateTime.Now
                                    };
                                    _lMIadeService.Add(_iade);
                                }
                                else
                                {
                                    throw new Exception("Bu ürün daha önce iade edilmiş");
                                }
                            }
                            else
                            {
                                throw new Exception("Kayıtlarda böyle bir şatış bilgisine ulaşılamadı.");
                            }
                        }
                        else
                        {
                            throw new Exception("Kayıtlarda böyle bir şatışa ait ürün bilgisine ulaşılamadı.");
                        }
                    }
                    else
                    {
                        throw new Exception("Kayıtlarda böyle bir şatışa ait fiş bilgisine ulaşılamadı.");
                    }
                }
            }catch(Exception hata)
            {
                MessageBox.Show("İade kayıt esnasında hata ile karşılaşıldı. \n" + hata.Message);
            }
            finally
            {
                Temizle();
            }
        }
    }
}
