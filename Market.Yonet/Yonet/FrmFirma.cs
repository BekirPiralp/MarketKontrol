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



namespace Market.Yonet.Yonet
{
    public partial class FrmFirma : Form
    {
        class Ilkhal
        {
            public string tbxFirmaAd;
            public string tbxAtaTc;
            public string tbxPrsnlAd, tbxPrsnlTc, tbxPrsnlSoyad, tbxPrsnlAdres;
            public bool cinsiyet;
            public Image foto;
        }

        BaglantiKontrol _baglanti;

        IUMFirmaService _uMFirmaS;
        IUMPersonelService _uMPersonelS;
        IUMPersonelAdresService _uMPersonelAdresS;
        IUMPersonelSifreService _uMPersonelSifreS;
        IUMFotografService _uMFotografS;

        IUMYoneticiService _uMYoneticiS;
        IUMCalisanService _uMCalisanS;

        IUMIlService _uMIlS;
        IUMIlceService _uMIlceS;
        IUMUlkeService _uMUlkeS;

        cbxUlkeililce _cbx;
        Ilkhal _ilkHal;

        List<Firma> firmalar = null;
        public FrmFirma()
        {
            InitializeComponent();
        }

        private void FrmFirma_Load(object sender, EventArgs e)
        {
            Olustur();
            cbxLoad();
        }

        private void cbxLoad()
        {
            _cbx.UlkeSet();
            cbxFirmaLoad(cbxAtaFirma);
            cbxFirmaLoad(cbxPrsnlFirma);
        }

        private void cbxFirmaLoad(ComboBox cbxFirma)
        {
            if (cbxFirma.Items.Count > 0)
                cbxFirma.Items.Clear();
            if (firmalar != null && firmalar.Count > 0)
            {
                cbxFirma.DataSource = firmalar;
                cbxFirma.DisplayMember = "FirmaAd";
                cbxFirma.ValueMember = "Id";
                cbxFirma.Update();
            }
        }

        private void Olustur()
        {
            _baglanti = BaglantiKontrol.KontrolGet();

            _uMFirmaS = new UMFirmaService(new EfFirmaDal());
            _uMPersonelS = new UMPersonelService(new EfPersonelDal());
            _uMPersonelAdresS = new UMPersonelAdresService(new EfPersonelAdresDal());
            _uMPersonelSifreS = new UMPersonelSifreService(new EfPersonelSifreDal());
            _uMFotografS = new UMFotografService(new EfFotografDal());

            _uMYoneticiS = new UMYoneticiService(new EfYoneticiDal());
            _uMCalisanS = new UMCalisanService(new EfCalisanDal());

            _uMIlS = new UMIlService(new EfIlDal());
            _uMIlceS = new UMIlceService(new EfIlceDal());
            _uMUlkeS = new UMUlkeService(new EfUlkeDal());

            _cbx = new cbxUlkeililce(cbxUlke, cbxIl, cbxIlce);

            _ilkHal = new Ilkhal
            {
                tbxAtaTc = tbxAtaTc.Text,

                tbxFirmaAd = tbxFirmaAd.Text,

                tbxPrsnlTc = tbxPrsnlTc.Text,
                tbxPrsnlAd = tbxAd.Text,
                tbxPrsnlSoyad = tbxSoyad.Text,
                cinsiyet = true,
                tbxPrsnlAdres = tbxAdres.Text,

                foto = pbxUser.Image
            };

            FirmaUpdate();
        }

        private void FirmaUpdate()
        {
            try
            {
                firmalar = firmalarAl();
                if (firmalar == null || firmalar.Count <= 0)
                    MessageBox.Show("Firmaların bilgisi alınamadı.");
            }
            catch
            {
                MessageBox.Show("Firmalar getirilirken hata oluştu.");
            }
        }

        private List<Firma> firmalarAl()
        {
            List<Firma> result = null;
            try
            {
                if (_baglanti.KontrolEt())
                {
                    result = _uMFirmaS.GetAll();
                    if (result == null || result.Count <= 0 || result[0].Id <= 0)
                        result = null;
                }
            }
            catch { }
            return result;
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            string text = ofdUser.FileName;
            ofdUser.ShowDialog();
            if (!text.Trim().Equals(ofdUser.FileName.Trim()) && ofdUser.FileName.Trim() != "")
            {
                pbxUser.Image = Image.FromFile(ofdUser.FileName);
            }
            else
            {
                pbxUser.Image = Properties.Resources.user;
            }
        }

        private void tbxMouseHover(object sender, EventArgs args)
        {
            MouseOlay.tbxMouseHover(sender);
        }

        #region Adres Combo Box temel olaylar
        private void cbxUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbx.cbxUlke_SelectedIndexChanged(sender, e);
        }

        private void cbxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbx.cbxIl_SelectedIndexChanged(sender, e);
        }

        private void cbxIl_DataSourceChanged(object sender, EventArgs e)
        {
            _cbx.cbxIl_DataSourceChanged(sender, e);
        }
        #endregion

        #region Firma Ekleme İşlemleri
        // ---> *** Firma ekleme işlemleri ***
        private void btnFirmaTemizle_Click(object sender, EventArgs e)
        {
            tbxFirmaAd.Text = _ilkHal.tbxFirmaAd;
        }

        private void btnFirmaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_baglanti.KontrolEt())
                {
                    if (tbxFirmaAd.Text.Trim() != "")
                    {
                        Firma firma = null;
                        firma = _uMFirmaS.GetByName(tbxFirmaAd.Text.Trim());
                        if (firma == null && firma.Id > 0)
                        {
                            firma = new Firma
                            {
                                FirmaAd = tbxFirmaAd.Text.Trim()
                            };

                            _uMFirmaS.Add(firma);
                            basari();
                        }
                        else
                            MessageBox.Show("Şuanda sistemde bu isimli bir firma olduğu için" +
                                "işleminiz gerçekleştiremiyoruz.");
                    }
                    else
                        MessageBox.Show("Lütfen geçerli bir firma adı giriniz.");
                }
                else
                    baglantiHata();
            }
            catch
            {
                MessageBox.Show(" Firma eklenirken hata oluştu işleminiz gerçekleştiremiyoruz.");
            }
            FirmaUpdate();
            btnFirmaTemizle_Click(sender, e);
        }
        // <---
        #endregion

        #region Hazır Uyarılar
        // ---> *** Hazır Uyarılar ***
        private void baglantiHata(){
            MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz ve yeniden giriş yapınız.");
        }
        private void basari(){
            MessageBox.Show("İşleminiz başarıyla gerçekleştirildi.");
        }
        private void gecersizTc(){
            MessageBox.Show("Lütfen geçerli bir TC kimlik numarası giriniz");
        }
        private void gecersizFirmaSecim(){
            MessageBox.Show("Lütfen bir firma seçiniz.");
        }
        // <---
        #endregion

        #region Firmaya Yönetici Atam İşlemleri 
        private void btnAta_Click(object sender, EventArgs e)
        {
            Yonetici yonetici = null;
            Personel personel = null;
            if (tbxAtaTc.Text.Trim().Length == 11)
            {
                personel = personelGetir(tbxAtaTc.Text.Trim());
                if (personel != null && personel.Id > 0)
                {
                    if (cbxAtaFirma.Items.Count > 0 && Convert.ToInt32(cbxAtaFirma.SelectedValue) > 0)
                    { 
                        yonetici = yoneticiGetir(Convert.ToInt32(cbxAtaFirma.SelectedValue));
                        if (yonetici == null) // Firmanın yönetici yoksa
                        {
                            yonetici = yoneticiGetir(personel);
                            if (yonetici == null) // Başka biryere yönetici değilse
                            {
                                Calisan calisan = null;
                                yonetici = new Yonetici
                                {
                                    Firma = Convert.ToInt32(cbxAtaFirma.SelectedValue),
                                    Personel = personel.Id
                                };

                                personel.Firma = yonetici.Firma; //Başka firmada çalışıp yönetici olmuş olabilir.

                                calisan = calisanGetir(personel.Id);

                                try
                                {
                                    if (calisan != null && calisan.Id > 0)
                                    {
                                        _uMCalisanS.Delete(calisan); // yönetici çalışan olamaz
                                    }

                                    _uMPersonelS.Update(personel);
                                    _uMYoneticiS.Add(yonetici);

                                    basari();
                                }
                                catch{
                                    MessageBox.Show("Personel atama işlemi sırasında hata oluştu\n" +
                                        "işleminizi gerçekleştiremiyoruz.");
                                }
                            }
                            else
                                MessageBox.Show(tbxAtaTc.Text + " TC kimlik nolu şahsıs sistemde başka bir firmanın" +
                                    "yöneticisi olarak gözüktüğü için işleminizi gerçekleştiremiyoruz.\n" +
                                    "Not: Bir firmanın bir yöneticisi, bir yöneticinin bir firması olur");
                        }
                        else
                            MessageBox.Show("Bu firmaya ait bir yönetici/sahip atayamazsınız");
                    }
                    else
                        gecersizFirmaSecim();
                }
                else
                    MessageBox.Show(tbxAtaTc.Text + " TC kimlik nolu şahsıs sistemde kayıtlı değildir.\n" +
                        "Lütfen Şahsı kaydediniz.");
            }
            else
                gecersizTc();
        }

        private void btnAtaTemizle_Click(object sender, EventArgs e)
        {
            if (cbxAtaFirma.Items.Count > 0){ 
                cbxAtaFirma.SelectedIndex = 0;
                cbxPrsnlFirma.Update();
            }

            tbxAtaTc.Text = _ilkHal.tbxAtaTc;
        }

        #endregion

        #region Getirme İşlemleri
        private Calisan calisanGetir(int Id)
        {
            Calisan result = null;
            try
            {
                if (_baglanti.KontrolEt())
                {
                    if (Id > 0)
                    {
                        result = _uMCalisanS.GetByPersonelId(Id);
                        if (result != null && result.Id <= 0)
                            result = null;
                    }
                    else
                        throw new Exception("Gerekli olan personelID bilgisi tam gelmediği için\n" +
                            "işleminizi geçekleştriemiyoruz");
                }
                else
                    baglantiHata();
            }
            catch
            {
                MessageBox.Show("Personele ait çalışan bilgisi getirilirken hata oluştu.");
            }
            return result;
        }

        private Yonetici yoneticiGetir(Personel personel)
        {
            Yonetici result = null;
            try
            {
                if (_baglanti.KontrolEt())
                {
                    if (personel != null && personel.Id > 0)
                    {
                        result = _uMYoneticiS.GetByPersonelId(personel.Id);
                        if (result != null && result.Id <= 0)
                            result = null;
                    }
                    else
                        throw new Exception("Gerekli olan personel bilgisi tam gelmediği için\n" +
                            "işleminizi geçekleştriemiyoruz");
                }
                else
                    baglantiHata();
            }
            catch
            {
                MessageBox.Show("Personele ait yönetici bilgisi getirilirken hata oluştu.");
            }
            return result;
        }

        private Personel personelGetir(string TC)
        {
            Personel result = null;
            try
            {
                if (_baglanti.KontrolEt())
                {
                    if (TC.Trim().Length == 11)
                    {
                        result = _uMPersonelS.GetByTc(TC.Trim());
                        if (result != null && result.Id <= 0)
                            result = null;
                    }
                    else
                        gecersizTc();
                }
                else
                    baglantiHata();
            }
            catch
            {
                MessageBox.Show("Personel getirme sırasında hata oluştu.\n" +
                    "Şuanda işleminiz gerçekleştiremiyoruz");
            }
            return result;
        }

        private Yonetici yoneticiGetir(int FirmaID)
        {
            Yonetici result = null;
            try
            {
                if (_baglanti.KontrolEt())
                {
                    if (FirmaID > 0)
                    {
                        result = _uMYoneticiS.GetByFirmaId(FirmaID);
                    }
                    else
                        throw new Exception("Gerekli olan firma id si tam gelmediği için\n" +
                            "işleminizi geçekleştriemiyoruz");
                }
                else
                    baglantiHata();
            }
            catch
            {
                MessageBox.Show("Firmaya ait yönetici bilgisi getirilirken hata oluştu.");
            }
            return result;
        }

        #endregion

        #region Personel Ekleme İşlemleri
        private void btnPrsnlEkle_Click(object sender, EventArgs e)
        {
            Personel personel = null;
            try
            {
                if (_baglanti.KontrolEt())
                {
                    if (tbxPrsnlTc.Text.Trim().Length == 11)
                    {
                        personel = personelGetir(tbxPrsnlTc.Text.Trim());
                        if (personel != null && personel.Id > 0)
                        {
                            MessageBox.Show(tbxPrsnlTc.Text + " TC li Şahıs zaten sistemde kayıtlı.");
                        }
                        else
                        {
                            if (tbxAd.Text.Trim() != "" && tbxSoyad.Text.Trim() != "" && Convert.ToInt32(cbxPrsnlFirma.SelectedValue) > 0 &&
                                tbxAdres.Text.Trim() != "" && Convert.ToInt32(cbxIlce.SelectedValue) > 0 && Convert.ToInt32(cbxIl.SelectedValue) > 0 && Convert.ToInt32(cbxUlke.SelectedValue) > 0)
                            {
                                personel = new Personel
                                {
                                    Tc = tbxPrsnlTc.Text.Trim(),
                                    Ad = tbxAd.Text.Trim(),
                                    Soyad = tbxSoyad.Text.Trim(),
                                    Cinsiyet = rbtnErkek.Checked == true ? 'E' : 'K',
                                    Firma = Convert.ToInt32(cbxPrsnlFirma.SelectedValue)
                                };

                                _uMPersonelS.Add(personel);
                                personel = personelGetir(personel.Tc);

                                if (personel != null && personel.Id > 0)
                                {
                                    Fotograf foto = new Fotograf
                                    {
                                        Personel = personel.Id,
                                        Firma = personel.Firma,
                                        TarihSaat = DateTime.Now
                                    };

                                    foto.FotoSet(pbxUser.Image);

                                    PersonelAdres adres = new PersonelAdres
                                    {
                                        Firma = personel.Firma,
                                        Personel = personel.Id,
                                        Tarif = tbxAdres.Text.Trim(),
                                        Il = Convert.ToInt32(cbxIl.SelectedValue),
                                        Ilce = Convert.ToInt32(cbxIlce.SelectedValue),
                                        Ulke = Convert.ToInt32(cbxUlke.SelectedValue)
                                    };

                                    PersonelSifre sifre = new PersonelSifre
                                    {
                                        Firma = personel.Firma,
                                        Personel = personel.Id,
                                        Sifre = personel.Tc.Trim()
                                    };

                                    if (_baglanti.KontrolEt())
                                    {
                                        _uMPersonelAdresS.Add(adres);
                                        _uMFotografS.Add(foto);
                                        _uMPersonelSifreS.Add(sifre);

                                        basari();
                                        MessageBox.Show("İlgi şahsın şifresi varsayılan olarak TC kimlik numarasıdır.", "N O T");
                                    }
                                    else
                                        baglantiHata();
                                }
                                else
                                    throw new Exception("Kayıt oluşturuken personel geri çekme esnasında hata oluştu");
                            }
                            else
                                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
                        }
                    }
                    else
                        gecersizTc();
                }
                else
                    baglantiHata();
            }
            catch{
                MessageBox.Show("Yönetici / Sahip ekleme işlemi sırasında hata oluştu işleminiz gerçekeleştiremiyoruz.");
            }

            btnAtaTemizle_Click(sender, e);
        }

        private void btnPrsnlTemizle_Click(object sender, EventArgs e)
        {
            if (cbxPrsnlFirma.Items.Count > 0){
                cbxPrsnlFirma.SelectedValue = 0;
                cbxPrsnlFirma.Update();
            }

            tbxPrsnlTc.Text = _ilkHal.tbxPrsnlTc;
            tbxAd.Text = _ilkHal.tbxPrsnlAd;
            tbxSoyad.Text = _ilkHal.tbxPrsnlSoyad;
            tbxAdres.Text = _ilkHal.tbxPrsnlAdres;

            rbtnErkek.Checked = _ilkHal.cinsiyet;
            rbtnKadin.Checked = !_ilkHal.cinsiyet;

            pbxUser.Image = _ilkHal.foto;

            _cbx.Temizle();
        }

        #endregion

    }
}
