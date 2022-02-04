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
using Market.Business.Abstract.UzakMarket;
using Market.Business.Concrete.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using Market.Entity.Concrete;
using Market.FirmaSahibi.FirmaSahibi;
using Market.MarketKontrol.ayarlar;

namespace Market.FirmaSahibi
{
    public partial class Form1 : Form
    {
        BaglantiKontrol _baglanti;
        GirisPersonelTut _girenPersonel;

        IUMPersonelService _uMPersonelS;
        IUMYoneticiService _uMYoneticiS;
        IUMPersonelSifreService _uMPersonelSifreS;

        string _ilkHalTc, _ilkHalSifre;

        public Form1()
        {
            InitializeComponent();
        }

        #region pencere temel buton
        private void btnQuit_Click(object sender, EventArgs e)
        {
            //exit
            _baglanti.Serbestbirak();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //Minimized küçültme
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region pencere taşıma
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
        #endregion

        #region temel ayarlar
        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar == '\0')
            {
                tbxPassword.PasswordChar = '*';
                btnPassword.BackgroundImage = global::Market.FirmaSahibi.Properties.Resources.passwordHide;
            }
            else
            {
                tbxPassword.PasswordChar = '\0';
                btnPassword.BackgroundImage = global::Market.FirmaSahibi.Properties.Resources.passwordShow;
            }
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

        #region Link yollama
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
        #endregion

        private void btnGiris_Click(object sender, EventArgs e)
        {
            _baglanti = BaglantiKontrol.KontrolGet();
            if (_baglanti.KontrolEt())
            {
                if (tbxTc.Text.Trim().Length == 11 && tbxPassword.Text.Trim() != "")
                {
                    Personel personel = null;
                    try
                    {
                        personel = _uMPersonelS.GetByTc(tbxTc.Text.Trim());
                        if (personel != null)
                        {
                            Yonetici yonetici = null;
                            yonetici = _uMYoneticiS.GetByPersonelId(personel.Id);
                            if (yonetici != null) // Bu kişi yönetici ise
                            {
                                PersonelSifre sifre = null;
                                sifre = _uMPersonelSifreS.GetByPersonelId(personel.Id, yonetici.Firma);

                                if (sifre != null)
                                {
                                    if (sifre.Sifre.Equals(tbxPassword.Text))
                                    {
                                        _girenPersonel.SetPersonel(personel, true,true);
                                        GiriIslem();
                                    }
                                    else
                                        MessageBox.Show("Yanlış bilgiler");
                                }
                            }
                        }
                        else
                            MessageBox.Show("Yanlış bilgiler");
                    }
                    catch
                    {
                        MessageBox.Show("Giriş işlemi sırasında hata oluştu.");
                    }
                }
                else
                    MessageBox.Show("Lütfen bilgileri eksiksiz olarak giriniz");
            }
            else
                MessageBox.Show("Lütfen internet bağlantınız kontrol ediniz.");
            _baglanti.Serbestbirak();
        }

        private void GiriIslem()
        {
            this.WindowState = FormWindowState.Minimized;
            (new FrmSahibi()).ShowDialog();
            this.WindowState = FormWindowState.Normal;


            tbxPassword.Text = _ilkHalSifre;
            tbxTc.Text = _ilkHalTc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _baglanti = BaglantiKontrol.KontrolGet();
            _girenPersonel = GirisPersonelTut.Olustur();

            _uMPersonelS = new UMPersonelService(new EfPersonelDal());
            _uMYoneticiS = new UMYoneticiService(new EfYoneticiDal());
            _uMPersonelSifreS = new UMPersonelSifreService(new EfPersonelSifreDal());

            _ilkHalSifre = tbxPassword.Text;
            _ilkHalTc = tbxTc.Text;
        }

        
    }
}
