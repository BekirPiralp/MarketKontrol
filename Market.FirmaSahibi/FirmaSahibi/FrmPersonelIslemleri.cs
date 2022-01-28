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
using Market.MarketKontrol.ayarlar;
using Veri = Market.Entity.Concrete;

namespace Market.FirmaSahibi.FirmaSahibi
{
    public partial class FrmPersonelIslemleri : Form
    {
        public FrmPersonelIslemleri()
        {
            InitializeComponent();
        }

        class Hal
        {
            public string Tc, Ad, Soyad, Gorev, Adres, EkBilgi, YeniSifre;
            public Image foto;
        }

        BaglantiKontrol _baglanti;
        GirisPersonelTut _girenPersonel;

        IUMPersonelService _uMPersonelS;
        IUMPersonelAdresService _uMPersonelAdresS;
        IUMPersonelSifreService _uMPersonelSifreS;
        IUMPersonelSilService _uMPersonelSilS;
        IUMEkBilgiService _uMEkBilgiS;
        IUMCalisanService _uMCalisanS;
        IUMMudurService _uMMudurS;
        IUMFotografService _uMFotografS;

        IUMBayiService _uMBayiS;

        Veri.Personel _personel = null;
        Veri.PersonelAdres _adres = null;
        Veri.PersonelSifre _sifre = null;
        Veri.PersonelSil _sil = null;
        Veri.Fotograf _foto = null;
        Veri.Calisan _calisan = null;
        Veri.EkBilgi _ekBilgi = null;

        List<Veri.Personel> _personeller = null;
        List<Veri.Calisan> _calisanlar = null;

        Hal _ilkhal;

        private cbxUlkeililce _cbx;

        private void tbxMouseHover(object sender, EventArgs eventArgs)
        {
            MouseOlay.tbxMouseHover(sender);
        }

        private void FrmPersonelIslemleri_Load(object sender, EventArgs e)
        {
            _cbx = new cbxUlkeililce(cbxUlke, cbxIl, cbxIlce);
            Olustur();
            LoadBayiler();
            LoadPersonel();
            Temizle();
            EkranTemizle();
        }

        
        private void Olustur()
        {
            _baglanti = BaglantiKontrol.KontrolGet();
            _girenPersonel = GirisPersonelTut.Olustur();

            _uMPersonelS = new UMPersonelService(new EfPersonelDal());
            _uMPersonelAdresS = new UMPersonelAdresService(new EfPersonelAdresDal());
            _uMPersonelSifreS = new UMPersonelSifreService(new EfPersonelSifreDal());
            _uMPersonelSilS = new UMPersonelSilService(new EfPersonelSilDal());
            _uMCalisanS = new UMCalisanService(new EfCalisanDal());
            _uMMudurS = new UMMudurService(new EfMudurDal());
            _uMFotografS = new UMFotografService(new EfFotografDal());
            _uMEkBilgiS = new UMEkBilgiService(new EfEkBilgiDal());

            _uMBayiS = new UMBayiService(new EfBayiDal());

            _ilkhal = new Hal
            {
                Adres = tbxAdres.Text,
                Ad = tbxAd.Text,
                EkBilgi = tbxEkBilgi.Text,
                foto = pbxFoto.Image,
                Gorev = tbxGorev.Text,
                Soyad = tbxSoyad.Text,
                Tc = tbxTc.Text,
                YeniSifre = tbxYeniSifre.Text
            };
        }

        private void LoadBayiler()
        {
            try
            {
                if(_girenPersonel != null && _girenPersonel.firma != null && _girenPersonel.firma.Id > 0)
                {
                    if (_baglanti.KontrolEt())
                    {
                        List<Bayi> result = _uMBayiS.GetAllByFirma(_girenPersonel.firma);
                        if (result != null && result.Count > 0)
                        {
                            cbxBayi.DataSource = result;
                            cbxBayi.ValueMember = "Id"; //Bayinin Id si
                            cbxBayi.DisplayMember = "BayiAd";
                        }
                        else
                            MessageBox.Show("Firmaya ait kayıtlı bir bayi bulunamamıştır.");
                    }
                    else
                        baglantiHata();
                }
                else
                {
                    MessageBox.Show("Giriş yapan personelin bilgileri tam olarak alınamadığı için " +
                        "\n işlemlerinizi gerçekleştiremiyoruz.");
                }
            }
            catch
            {
                MessageBox.Show("Bayiler yüklenirken hata oluştu.");
            }
        }

        private void LoadPersonel()
        {
            try
            {
                if (_baglanti.KontrolEt() && _girenPersonel.firma != null)
                {
                    _calisanlar = _uMCalisanS.GetAllByFirma(_girenPersonel.firma);
                    _personeller = null;
                    if (_calisanlar != null && _calisanlar.Count > 0)
                    {
                        _personeller = new List<Veri.Personel>();
                        foreach (var item in _calisanlar)
                        {
                            Veri.Personel prsnl = null;
                            prsnl = _uMPersonelS.GetById(item.Personel);
                            if (prsnl != null)
                            {
                                _personeller.Add(prsnl);
                            }
                        }
                    }
                    dgwPersonelYukle();
                }
                else
                    baglantiHata();
            }
            catch
            {
                MessageBox.Show("Personeller getirilirken hata oluştu.");
            }
        }

        private void dgwPersonelYukle()
        {
            if (_personeller != null && _personeller.Count > 0)
            {
                dgwPersonel.DataSource = _personeller;
            }
        }

        private void baglantiHata()
        {
            MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz ve Yeniden giriş yapınız.");
        }

        private void Temizle()
        {
            _adres = null;
            _calisan = null;
            _foto = null;
            _personel = null;
            _ekBilgi = null;
            _sil = null;
            _sifre = null;

            _cbx.Temizle();
            cbxBayiTemizle();
            EkranTemizle();
        }

        private void cbxBayiTemizle()
        {
            try
            {
                if (cbxBayi.Items.Count > 0)
                    cbxBayi.SelectedIndex = 0;
            }
            catch { }
        }

        private void EkranTemizle()
        {
            tbxAdres.Text = _ilkhal.Adres;
            tbxAd.Text = _ilkhal.Ad;
            tbxEkBilgi.Text = _ilkhal.EkBilgi;
            pbxFoto.Image = _ilkhal.foto;
            tbxGorev.Text = _ilkhal.Gorev;
            tbxSoyad.Text = _ilkhal.Soyad;
            tbxTc.Text = _ilkhal.Tc;
            tbxSifreTC.Text = _ilkhal.Tc;
            tbxYeniSifre.Text = _ilkhal.YeniSifre;

            rbtnErkek.Checked = true;
            rbtnKadin.Checked = false;

            _cbx.Temizle();
            cbxBayiTemizle();
        }

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

        private void dgwPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeciliPersonelAl();
        }

        private void dgwPersonel_SelectionChanged(object sender, EventArgs e)
        {
            SeciliPersonelAl();
        }

        private void SeciliPersonelAl()
        {
            _personel = null;
            try
            {
                if (Convert.ToInt32(dgwPersonel.CurrentRow.Cells[5].Value) > 0)
                {
                    _personel = new Veri.Personel
                    {
                        Id = Convert.ToInt32(dgwPersonel.CurrentRow.Cells[5].Value),
                        Ad = dgwPersonel.CurrentRow.Cells[1].Value.ToString(),
                        Soyad = dgwPersonel.CurrentRow.Cells[2].Value.ToString(),
                        Tc = dgwPersonel.CurrentRow.Cells[3].Value.ToString(),
                        Cinsiyet = dgwPersonel.CurrentRow.Cells[4].Value.ToString()[0],
                        Firma = Convert.ToInt32(dgwPersonel.CurrentRow.Cells[0].Value)
                    };

                    _foto = _uMFotografS.GetByPersonelId(_personel.Id, _personel.Firma);
                    _adres = _uMPersonelAdresS.GetByPersonelId(_personel.Id, _personel.Firma);
                    _calisan = _uMCalisanS.GetByPersonelId(_personel.Id, _personel.Firma);
                    _ekBilgi = _uMEkBilgiS.GetByPersonelId(_personel.Id, _personel.Firma);
                }

            }
            catch
            {
            }

            SeciliPersoneliEkranaBas();
        }

        private void SeciliPersoneliEkranaBas()
        {
            if (_personel != null && _personel.Id > 0)
            {
                try
                {
                    tbxAd.Text = _personel.Ad;
                    tbxSoyad.Text = _personel.Soyad;
                    tbxTc.Text = _personel.Tc;
                    tbxGorev.Text = _calisan.Gorev;
                    rbtnErkek.Checked = _personel.Cinsiyet == 'E' ? true : false;

                    pbxFoto.Image = _foto.FotoGet() != null ? _foto.FotoGet() : _ilkhal.foto;

                    tbxAdres.Text = _adres.Tarif;
                    tbxEkBilgi.Text = _ekBilgi.Aciklama;

                    //Normalde olması lazım lakin şuan nedense bir soru işreti oluştu?
                    cbxUlke.SelectedValue = _adres.Ulke;
                    cbxIl.SelectedValue = _adres.Il;
                    cbxIlce.SelectedValue = _adres.Ilce;

                    cbxBayi.SelectedValue = _calisan.Bayi;
                }
                catch { }
            }
            else
                EkranTemizle();
        }

        private void btnSfreTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnPrsnlTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_baglanti.KontrolEt() && _personel != null && _foto != null && _calisan != null &&
                    _adres != null && _ekBilgi != null)
                {
                    //Tc Ve cinsiyet güncellenemez.
                    _personel.Ad = tbxAd.Text.Trim();
                    _personel.Soyad = tbxSoyad.Text.Trim();
                    _foto.FotoSet(pbxFoto.Image);
                    _calisan.Gorev = tbxGorev.Text;
                    _calisan.Bayi = Convert.ToInt32(cbxBayi.SelectedValue);
                    _ekBilgi.Aciklama = tbxEkBilgi.Text;
                    _ekBilgi.TarihSaat = DateTime.Now;
                    _adres.Tarif = tbxAdres.Text;
                    _adres.Ulke = Convert.ToInt32(cbxUlke.SelectedValue);
                    _adres.Il = Convert.ToInt32(cbxIl.SelectedValue);
                    _adres.Ilce = Convert.ToInt32(cbxIlce.SelectedValue);

                    _uMCalisanS.Update(_calisan);
                    _uMEkBilgiS.Update(_ekBilgi);
                    _uMFotografS.Update(_foto);
                    _uMPersonelAdresS.Update(_adres);
                    _uMPersonelS.Update(_personel);

                    IslemBasariylaGerceklesti();
                }
                else
                    baglantiHata();
            }
            catch
            {
                MessageBox.Show("Personel Güncellemede hata ile karşılaşıldı.");
            }
            Temizle();
        }

        private void btnPrsnlSil_Click(object sender, EventArgs e)
        {
            DialogResult result =
            MessageBox.Show("Personeli neden sildiğinize dair açıklama girmek istiyormusunuz?\n" +
            "İstiyorsanız Evet e tıklayın ve ek bilgi kısmına çıklamanızı giriniz...",
                "Açıklama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            try
            {
                if (_baglanti.KontrolEt() && _personel != null && _calisan != null)
                {
                    _sil = new Veri.PersonelSil
                    {
                        Firma = _personel.Firma,
                        Personel = _personel.Id,
                        TarihSaat = DateTime.Now,
                        Aciklama = result == DialogResult.Yes ? tbxEkBilgi.Text : ""
                    };

                    _sil.Aciklama += ("\n Enson görevi: " + _calisan.Gorev.Trim());

                    // Müdür varsa silme işlemi --->
                    Veri.Mudur geri = null;
                    geri = _uMMudurS.GetByPersonelId(_personel.Id);

                    if (geri != null && geri.Id > 0 && !GirisPersonelTut._firmaSahibiMi)
                        MessageBox.Show("Simek istediğiniz kişi müdür olduğu için silemezsiniz");
                    //_uMMudurS.Delete(geri);
                    // <---
                    else if (geri != null && geri.Id > 0 && GirisPersonelTut._firmaSahibiMi)
                    {
                        _uMMudurS.Delete(geri);
                        Sil();
                    }
                    else
                        Sil();
                    
                    LoadPersonel();
                    void Sil()
                    {
                        _uMCalisanS.Delete(_calisan);
                        _uMPersonelSilS.Add(_sil);

                        IslemBasariylaGerceklesti();
                    }

                }
                else
                    baglantiHata();
            }
            catch
            {
                MessageBox.Show("Personel silme işlemi sırasında hata ile karşılaşıldı.");
            }

            Temizle();
        }

        private void btnPrsnlEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_baglanti.KontrolEt() && tbxTc.Text.Trim().Length == 11 && cbxBayi.SelectedIndex > 0) // kesinlikle bayi seçilmiş olacak
                {
                    _personel = personelGetir();

                    _foto = new Veri.Fotograf();
                    _calisan = new Veri.Calisan();
                    _adres = new Veri.PersonelAdres();
                    _sifre = new Veri.PersonelSifre();

                    //personel veri tabanında hiç kayıtlı değilse
                    if (_personel == null)
                    {
                        _personel = new Veri.Personel();
                        _personel.Tc = tbxTc.Text.Trim();
                        _personel.Cinsiyet = rbtnErkek.Checked == true ? 'E' : 'K';
                        _personel.Firma = _girenPersonel.firma.Id;
                        _personel.Ad = tbxAd.Text.Trim();
                        _personel.Soyad = tbxSoyad.Text.Trim();

                        _uMPersonelS.Add(_personel);

                        _personel = _uMPersonelS.GetByTc(_personel.Tc);

                        bilgiOlustur();

                    }

                    //personel başka firmada çalışmış olabilir
                    else if (_personel.Id > 0 && _uMPersonelSilS.GetByPersonelId(_personel.Id) != null
                        && _uMPersonelSilS.GetByPersonelId(_personel.Id).Firma != _girenPersonel.firma.Id )
                    {
                        //_personel = _uMPersonelS.GetByTc(tbxTc.Text.Trim());
                        _personel.Firma = _girenPersonel.firma.Id;
                        _uMPersonelS.Update(_personel);

                        bilgiOlustur();
                    }

                    else
                    {
                        MessageBox.Show("Silmiş olduğunuz veya şu anda başka firmada çalışıyor olarak gözüken" +
                            "bir personeli ekleyemezsiniz.", "Geçersiz işlem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    void bilgiOlustur()
                    {
                        _foto.FotoSet(pbxFoto.Image);
                        _foto.Id = _personel.Id;
                        _foto.Firma = _personel.Firma;
                        _foto.TarihSaat = DateTime.Now;

                        _uMFotografS.Add(_foto);

                        _calisan.Bayi = Convert.ToInt32(cbxBayi.SelectedValue);
                        _calisan.Firma = _personel.Firma;
                        _calisan.Personel = _personel.Id;
                        _calisan.Gorev = tbxGorev.Text;

                        _uMCalisanS.Add(_calisan);

                        _ekBilgi.Firma = _personel.Firma;
                        _ekBilgi.Bayi = _girenPersonel.bayi.Id;
                        _ekBilgi.Personel = _personel.Id;
                        _ekBilgi.Aciklama = tbxEkBilgi.Text;
                        _ekBilgi.TarihSaat = DateTime.Now;

                        _uMEkBilgiS.Add(_ekBilgi);

                        _adres.Personel = _personel.Id;
                        _adres.Firma = _personel.Firma;
                        _adres.Tarif = tbxAdres.Text;
                        _adres.Ulke = Convert.ToInt32(cbxUlke.SelectedValue);
                        _adres.Il = Convert.ToInt32(cbxIl.SelectedValue);
                        _adres.Ilce = Convert.ToInt32(cbxIlce.SelectedValue);

                        _uMPersonelAdresS.Add(_adres);

                        _sifre.Firma = _personel.Firma;
                        _sifre.Personel = _personel.Id;
                        _sifre.Sifre = _personel.Tc;

                        _uMPersonelSifreS.Add(_sifre);

                        IslemBasariylaGerceklesti();
                        MessageBox.Show("Personelin şifresi varsayılan olarak TC kimlik numarasıdır.");
                    }
                }
                else
                {
                    baglantiHata();
                }
            }
            catch
            {
                MessageBox.Show("Personel eklenmesi sırasında hata ile karşılaşıldı");
            }
            LoadPersonel();
            Temizle();
        }

        private Veri.Personel personelGetir()
        {
            Veri.Personel result = null;
            try
            {
                result = _uMPersonelS.GetByTc(tbxTc.Text.Trim());
            }
            catch
            {
                throw new Exception("TC si girili personel getirilirken hata");
            }
            return result;
        }

        private void btnSfreKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (_baglanti.KontrolEt())
                {
                    if (tbxSifreTC.Text.Trim().Length == 11)
                    {
                        _personel = _uMPersonelS.GetByTc(tbxSifreTC.Text.Trim());
                        if (_personel != null && _personel.Id > 0 &&
                            _personel.Firma == _girenPersonel.firma.Id)
                        {
                            _sifre = _uMPersonelSifreS.GetByPersonelId(_personel.Id);
                            if (_sifre != null && tbxYeniSifre.Text.Length >= 5 && tbxYeniSifre.Text.Trim() != "")
                            {
                                _sifre.Sifre = tbxYeniSifre.Text;
                                _uMPersonelSifreS.Update(_sifre);

                                IslemBasariylaGerceklesti();
                            }
                            else
                            {
                                MessageBox.Show("Lütfen enaz 5 haneli ve boş olmayan şifre giriniz.");
                            }
                        }
                        else
                            MessageBox.Show("Personel bulunamadı veya hata oluştu");
                    }
                    else
                        MessageBox.Show("Lütfen geçerli bir TC kimlik numarsı giriniz");
                }
                else
                    baglantiHata();
            }
            catch
            {
                MessageBox.Show("Personel bilgileri getirilirken hata ile kaşılaşıldı");
            }

            Temizle();
        }

        private void pbxFoto_Click(object sender, EventArgs e)
        {
            string text = ofdUser.FileName;
            ofdUser.ShowDialog();
            if (!text.Trim().Equals(ofdUser.FileName.Trim()) && ofdUser.FileName.Trim() != "")
            {
                pbxFoto.Image = Image.FromFile(ofdUser.FileName);
            }
            else
            {
                pbxFoto.Image = Properties.Resources.user;
            }
        }

        private void IslemBasariylaGerceklesti()
        {
            MessageBox.Show("İşleminiz başarıyla gerçekleşti.");
        }
    }
}
