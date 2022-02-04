using Market.Business.Abstract.UzakMarket;
using Market.Business.Concrete.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using Market.Entity.Concrete;
using Market.MarketKontrol.ayarlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.FirmaSahibi.FirmaSahibi
{
    public partial class FrmMudur : Form
    {
        public FrmMudur()
        {
            InitializeComponent();
        }

        struct Ilkhal
        {
            public string tbxTC;
            public string lblAdSoyad;
        }
        GirisPersonelTut _girenPersonel;
        BaglantiKontrol _baglanti;

        IUMBayiService _uMBayiS;

        IUMPersonelService _uMPersonelS;
        IUMPersonelSilService _uMPersonelSilS;
        IUMMudurService _uMMudurS;
        IUMCalisanService _uMCalisanS;

        Personel _personel = null;
        Calisan _calisan = null;
        Mudur _mudur = null;
        Ilkhal _ilkhal;
        private void FrmMudur_Load(object sender, EventArgs e)
        {
            Olustur();
            BayiAl();
        }

        private void BayiAl()
        {
            try
            {
                if (_baglanti.KontrolEt())
                {
                    List<Bayi> bayiler = null;
                    if (_girenPersonel.firma != null && _girenPersonel.firma.Id > 0)
                    {
                        bayiler = _uMBayiS.GetAllByFirma(_girenPersonel.firma);
                        if (bayiler != null && bayiler.Count > 0)
                        {
                            cbxBayi.DataSource = bayiler;
                            cbxBayi.ValueMember = "Id";
                            cbxBayi.DisplayMember = "BayiAd";
                        }
                    }
                    else
                        MessageBox.Show("Firma bilgisine ulaşılamadığı için bayiler alınamıyor");
                }
                else
                {
                    MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz ve tekrar giriş yapınız.");
                }
            }
            catch{
                MessageBox.Show("Bayiler getirilirken hata oluştu.");
            }
        }

        private void Olustur()
        {
            _girenPersonel = GirisPersonelTut.Olustur();
            _baglanti = BaglantiKontrol.KontrolGet();

            _uMBayiS = new UMBayiService(new EfBayiDal());

            _uMPersonelS = new UMPersonelService(new EfPersonelDal());
            _uMPersonelSilS = new UMPersonelSilService(new EfPersonelSilDal());
            _uMMudurS = new UMMudurService(new EfMudurDal());
            _uMCalisanS = new UMCalisanService(new EfCalisanDal());

            _ilkhal = new Ilkhal {
            tbxTC = tbxTc.Text,
            lblAdSoyad = lblAdSoyad.Text};
        }

        private void Temizle()
        {
            tbxTc.Text = _ilkhal.tbxTC;
            lblAdSoyad.Text = _ilkhal.lblAdSoyad;

            _personel = null;
            _calisan = null;
            _mudur = null;

            if (cbxBayi.Items != null && cbxBayi.Items.Count > 0)
                cbxBayi.SelectedIndex = 0;
        }

        private void tbxTc_MouseHover(object sender, EventArgs e)
        {
            MouseOlay.tbxMouseHover(sender);
        }

        private void tbxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            KlavyeOlay.NumKeyPress(e);
        }

        private void tbxTc_TextChanged(object sender, EventArgs e)
        {
            if (tbxTc.Text.Trim().Length == 11)
            {
                PersonelGetir();
            }
            //else
            // kulanıcı aşırı sıkacak ve çok muzipçe bir işlem
            //    MessageBox.Show("Lütfen geçerli bir TC giriniz.");
        }

        private void PersonelGetir()
        {
            _personel = null;
            try
            {
                if (_baglanti.KontrolEt())
                {
                    _personel = _uMPersonelS.GetByTc(tbxTc.Text, _girenPersonel.firma);
                    if (_personel != null && _personel.Id > 0)
                    {
                        _calisan = _uMCalisanS.GetByPersonelId(_personel.Id,_personel.Firma);
                        
                        if(_calisan != null && _calisan.Id > 0)
                        {
                            _mudur = _uMMudurS.GetByPersonelId(_personel.Id, _personel.Firma);
                            lblAdSoyad.Text = _personel.Ad + " " + _personel.Soyad.ToUpper();
                            if(_mudur != null && _mudur.Id > 0)
                                cbxBayi.SelectedValue = _calisan.Bayi;
                            cbxBayi.Update();
                        }
                        else
                        {
                            MessageBox.Show(_personel.Tc + " TC kimlik nolu şahıs şuanda \n" +
                                "firmanızda çalışıyor olarak gözükmemektedir.");
                            Temizle();
                        }    

                    }
                    else
                        MessageBox.Show("Girmiş olduğunuz TC ye ait firmanızda kayıtlı bir eleman yoktur.");
                }
                else
                    MessageBox.Show("Lütfen internet bağlantınız kontrol ediniz ve tekrar giriş yapınız");
            }
            catch{
                MessageBox.Show("Personel getirilirken hata ile karşılaşıldı.");
            }
        }

        private void bntAta_Click(object sender, EventArgs e)
        {
            if(_personel != null && _personel.Id > 0)
            {
                if(_mudur != null && _mudur.Id > 0)
                {
                    MessageBox.Show("Atamak istediğiniz " + _personel.Tc + " TC kimlik nolu " +
                        lblAdSoyad.Text + " adlı şahıs şu anda başka bir bayide müdürlük yapmaktadır." +
                        "Lütfen öncelikle müdürlükten silip yeni atama yapınız.");
                }
                else
                {
                    int bayi = 0;
                    if (cbxBayi.SelectedValue != null && cbxBayi.Items.Count > 0)
                        bayi = Convert.ToInt32(cbxBayi.SelectedValue);
                    else
                    {
                        MessageBox.Show("Lütfen firmanıza bir bayi ekleyiniz.");
                        return;
                    }

                    if (bayi > 0)
                    {
                        try
                        {
                            VarsaBayiMudurTemizle(bayi);
                            if (_personel != null && _calisan != null)
                            {
                                _mudur = new Mudur
                                {
                                    Personel = _personel.Id,
                                    Firma = _calisan.Firma,
                                    Bayi = bayi
                                };
                                _calisan.Gorev = cbxBayi.Text+" bayisin de Müdür";
                                _calisan.Bayi = bayi;

                                _uMMudurS.Add(_mudur);
                                _uMCalisanS.Update(_calisan);

                                MessageBox.Show("İşleminiz başarıyla gerçekleştirildi.");
                                Temizle();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Yapmak istediğiniz işlem sırasında hata ile karşılaşıldı.");
                            Temizle();
                            return;
                        }
                    }
                    else
                        MessageBox.Show("Lütfen bir bayi seçiniz.");
                }
            }
        }

        private void VarsaBayiMudurTemizle(int bayi)
        {
            Mudur mudur = null;
            try
            {
                if (_baglanti.KontrolEt())
                {
                    if (_girenPersonel.firma != null && _girenPersonel.firma.Id > 0)
                    {
                        mudur = _uMMudurS.GetByBayi(bayi, _girenPersonel.firma.Id);
                    }
                    else
                    {
                        MessageBox.Show("Giren personelin bilgileri tam gelmediği için işlemlerinizi yapamıyoruz.");
                        Temizle();
                        return;
                    }
                    if(mudur != null && mudur.Id > 0)
                    {
                        _uMMudurS.Delete(mudur);
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen internet bağlantınızı kontrol edip yeniden giriş yapınız.");
                    Temizle();
                }
            }
            catch
            {
                Temizle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mudur != null && _mudur.Id > 0)
                {
                    if (_baglanti.KontrolEt())
                    {
                        _uMMudurS.Delete(_mudur);
                        _calisan.Gorev = "Çalışan";
                        _uMCalisanS.Update(_calisan);
                        MessageBox.Show("İşleminiz başarıyla gerçekleşti");
                    }
                    else
                        MessageBox.Show("Lütfen iternet bağlantınız kontrol edip tekrar giriş yapınız.");
                }
            }
            catch{
                MessageBox.Show(lblAdSoyad.Text + " isimli personeli silme işleminiz sırasında hata ile karşılaşıldı.");
                
            }
            Temizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
