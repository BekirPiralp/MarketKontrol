using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.Business.Abstract.LochalMarket;
using Market.Business.Abstract.UzakMarket;
using Market.Business.Concrete.UzakMarket;
using LM = Market.DataAccess.Concrete.LochalMarket.EntityFramework;
using Market.MarketKontrol.ayarlar;
using UM = Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using Market.Business.Concrete.LochalMarket;
using Market.Business.Concrete.DigerIslemler;
using Veri=Market.Entity.Concrete;
using Market.MarketKontrol.Mudur;
using Market.MarketKontrol.Personel;

namespace Market.MarketKontrol
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private string _ilkHalTc, _ilkHalSifre;

        BaglantiKontrol _baglanti = null;
        GirisPersonelTut _girenPersonel = null;

        IUMPersonelService _uMPersonelS;
        IUMPersonelSifreService _uMPersonelSifreS;
        IUMPersonelSilService _uMPersonelSilS;

        IUMCalisanService _uMCalisanS;
        IUMMudurService _uMMudurS;
        IUMYoneticiService _uMYoneticiS;

        ILMBayiService _lMBayiS;
        ILMFirmaService _lMFirmaS;

        ILMPersonelService _lMPersonelS;
        ILMPersonelSifreService _lMPersonelSifreS;

        Veri.Bayi _bayi = null;
        Veri.Firma _firma = null;

        #region temel işlemler
        private void btnQuit_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //Minimized küçültme
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            FormTasi.mouseUp();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            FormTasi.mouseDown(e);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            FormTasi.mouseMove(e, this);
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '\0')
            {
                tbxPassword.PasswordChar = '*';
                btnPassword.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.passwordHide;
            }
            else
            {
                tbxPassword.PasswordChar = '\0';
                btnPassword.BackgroundImage = global::Market.MarketKontrol.Properties.Resources.passwordShow;
            }
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/bekir01piralp/");
        }

        private void btnFacebook_Click(object sender, EventArgs e)
        {
            Process.Start("https://tr-tr.facebook.com/bekir.piralp.9");
        }

        private void btnLinkedin_Click(object sender, EventArgs e)
        {
            Process.Start("https://tr.linkedin.com/in/bekir-piralp-26bbab171");
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/BekirPiralp");
        }

        /* Müdür ve Çalışan giriş*/
        private bool mudur = false;
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (mudur)
            {
                btnBoss.FlatAppearance.BorderSize = 0;
                btnEmployee.FlatAppearance.BorderSize = 2;
                mudur = false;
            }
        }

        private void btnBoss_Click(object sender, EventArgs e)
        {
            if (!mudur){
                btnBoss.FlatAppearance.BorderSize = 2;
                btnEmployee.FlatAppearance.BorderSize = 0;
                mudur = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            
            (new KontrolAyarları.Giris()).ShowDialog();
            
        }

        private void tbxMouseHover(object sender, EventArgs args)
        {
            MouseOlay.tbxMouseHover(sender);
        }

        private void tbxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            KlavyeOlay.NumKeyPress(e);
        }

        #endregion

        private void frmGiris_Load(object sender, EventArgs e)
        {
            _ilkHalTc = tbxTc.Text;
            _ilkHalSifre = tbxPassword.Text;

            Olustur();
        }

        private void Olustur()
        {
            _uMPersonelS = new UMPersonelService(new UM.EfPersonelDal());
            _uMPersonelSifreS = new UMPersonelSifreService(new UM.EfPersonelSifreDal());
            _uMPersonelSilS = new UMPersonelSilService(new UM.EfPersonelSilDal());

            _uMYoneticiS = new UMYoneticiService(new UM.EfYoneticiDal());
            _uMMudurS = new UMMudurService(new UM.EfMudurDal());
            _uMCalisanS = new UMCalisanService(new UM.EfCalisanDal());

            _lMBayiS = new LMBayiService(new LM.EfBayiDal());
            _lMFirmaS = new LMFirmaService(new LM.EfFirmaDal());

            _lMPersonelS = new LMPersonelService(new LM.EfPersonelDal());
            _lMPersonelSifreS = new LMPersonelSifreService(new LM.EfPersonelSifreDal());

            _baglanti = BaglantiKontrol.KontrolGet();
            _girenPersonel = GirisPersonelTut.Olustur();

            _firma = _lMFirmaS.GetAll() != null ? (_lMFirmaS.GetAll().Count == 1 ? _lMFirmaS.GetAll()[0] : null) : null;
            _bayi = _lMBayiS.GetAll() != null ? (_lMBayiS.GetAll().Count == 1 ? _lMBayiS.GetAll()[0] : null) : null;

            _girenPersonel.sifirla();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            _baglanti = BaglantiKontrol.KontrolGet();

            GirisKontrol();

            if (mudur)
            {
                MudurGiris();
            }
            else
            {
                PersonelGiris();
            }

            tbxTc.Text = _ilkHalTc;
            tbxPassword.Text = _ilkHalSifre;
            _baglanti.Serbestbirak();
            _girenPersonel.sifirla();
        }

        #region Giriş İşlemleri

        private void GirisKontrol()
        {
            try
            {
                Veri.Personel personel = null;
                if (tbxTc.Text.Trim().Length == 11 && tbxPassword.Text.Trim() != "")
                {
                    if (_baglanti.KontrolEt())
                    {
                        baglantiVarsa(personel);
                       
                    }else
                    {
                        MessageBox.Show("İnternet bağlantınız olmadan giriş yapıyorsunuz. \n" +
                            "Kimi işlemleri gerçekleştiremeye bilirsiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                        baglantiYoksa(personel);
                    }
                }
                else
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
            }
            catch{
                MessageBox.Show("Bilgiler kontrol edilirken hata oluştu");
            }
        }

        private void baglantiYoksa(Veri.Personel personel)
        {
            personel = _lMPersonelS.GetByTc(tbxTc.Text);
            if (personel != null && personel.Id > 0)
            {
                Veri.PersonelSifre sifre = null;
                sifre = _lMPersonelSifreS.GetByPersonelId(personel.Id);
                if (sifre != null && sifre.Id > 0)
                {
                    if (_bayi == null && _firma != null && _bayi.Id > 0 && _firma.Id > 0 && _bayi.Firma == _firma.Id)
                    {
                        if (personel.Firma == _firma.Id && sifre.Firma == _firma.Id)
                        {
                            if (sifre.Sifre.Equals(tbxPassword.Text))
                            {
                                _girenPersonel.SetPersonel(personel);
                            }
                            else
                                sifreHata();
                        }
                        else
                            kimlikHata();
                    }
                    else
                        sisBilEksik();
                }
                else
                    kimlikHata();
            }
            else
                kimlikHata();
        }

        private void baglantiVarsa(Veri.Personel personel)
        {
            personel = _uMPersonelS.GetByTc(tbxTc.Text);
            if (personel != null && personel.Id > 0)
            {
                Veri.PersonelSifre sifre = null;
                sifre = _uMPersonelSifreS.GetByPersonelId(personel.Id);
                if (sifre != null && sifre.Id >0)
                {
                    if (_bayi != null && _firma != null && _bayi.Id > 0 && _firma.Id > 0 && _bayi.Firma == _firma.Id)
                    {
                        if (personel.Firma == _firma.Id && sifre.Firma == _firma.Id)
                        {
                            if (sifre.Sifre.Equals(tbxPassword.Text))
                            {
                                Veri.PersonelSil sil = null;
                                sil = _uMPersonelSilS.GetByPersonelId(personel.Id, personel.Firma);

                                if (sil == null)
                                {
                                    Veri.Yonetici yonetici = null;
                                    if (_firma != null && _firma.Id > 0 && _bayi != null && _bayi.Id > 0)
                                    {
                                        yonetici = _uMYoneticiS.GetByPersonelId(personel.Id, _firma.Id);
                                        if (yonetici != null && yonetici.Id > 0)
                                        {
                                            _girenPersonel.SetPersonel(personel, true);
                                        }
                                        else
                                        {
                                            Veri.Mudur mudur = null;
                                            mudur = _uMMudurS.GetByBayi(_bayi.Id, _firma.Id);
                                            if (mudur != null && mudur.Id > 0 && mudur.Personel == personel.Id)
                                            {
                                                    _girenPersonel.SetPersonel(personel);
                                            }
                                            else
                                            {
                                                Veri.Calisan calisan = null;
                                                calisan = _uMCalisanS.GetByPersonelId(personel.Id, _firma.Id);

                                                if (calisan != null && calisan.Id > 0)
                                                {
                                                    _girenPersonel.SetPersonel(personel);
                                                }
                                            }
                                        }

                                        if (_girenPersonel.personel != null && _girenPersonel.personel.Id > 0)
                                        {
                                            _girenPersonel.firma = _firma;
                                            _girenPersonel.bayi = _bayi;
                                        }
                                    }
                                }
                                else
                                    MessageBox.Show("İlgili personel sistemden silinmiştir.");
                            }
                            else
                                sifreHata();
                        }
                        else
                            kimlikHata();
                    }
                    else
                        sisBilEksik();
                }
                else
                    kimlikHata();
            }
            else
                kimlikHata();
        }

        #endregion

        #region Sayfalara yönlendirme
        private void PersonelGiris()
        {
            if (_girenPersonel != null && _girenPersonel.personel != null) // personel silimişse zaten uzak alışta persone oluşturulmayacak.
            {
                this.WindowState = FormWindowState.Minimized;
                (new FrmPersonel()).ShowDialog();
                this.WindowState = FormWindowState.Normal;
            }
            else
                MessageBox.Show("Bilgilerde eksiklik olduğu için giriş yapamıyorsunuz");
        }

        private void MudurGiris()
        {
            if (_girenPersonel != null && _girenPersonel.personel != null && (GirisPersonelTut._mudur || GirisPersonelTut._firmaSahibiMi)) // sadece müdür veya yönetici girebilir
            {
                this.WindowState = FormWindowState.Minimized;
                (new FrmMudur()).ShowDialog();
                this.WindowState = FormWindowState.Normal;
            }
            else
                MessageBox.Show("Bilgilerde eksiklik olduğu için giriş yapamıyorsunuz");
        }
        #endregion

        #region Hata tanımları
        private void kimlikHata()
        {
            MessageBox.Show(tbxTc.Text + " TC kimlik numaralı kişi sistemde kayıtlı değildir. Veya bilgilerinde eksiklik var");
        }

        private void sisBilEksik()
        {
            MessageBox.Show("Sistem bilgilerinde eksiklik var");
        }

        private void sifreHata()
        {
            MessageBox.Show("Kullanıcı ve şifresi eşleşmiyor");
        }

        #endregion
    }
}
