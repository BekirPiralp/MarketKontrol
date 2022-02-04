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
using Market.Business.Concrete.LochalMarket;
using Market.Business.Concrete.UzakMarket;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using Market.Entity.Concrete;
using Market.MarketKontrol.ayarlar;
using LM = Market.DataAccess.Concrete.LochalMarket.EntityFramework;

namespace Market.MarketKontrol.Ortak
{
    public partial class FrmAyarlar : Form
    {
        GirisPersonelTut _girisPersonel;
        BaglantiKontrol _baglanti;

        IUMPersonelSifreService _uMPersonelSifreS;
        IUMPersonelAdresService _uMPersonelAdresS;
        IUMFotografService _uMFotografS;

        ILMPersonelSifreService _lMPersonelSifreS;

        cbxUlkeililce _cbx;

        //PersonelSifre _sifre;
        //PersonelAdres _adres;
        //Fotograf _foto;

        class Ilkhal{
        public string tbxEskiSifre, tbxYeniSifre, tbxYenisSifre2, tbxTarif;
        public Image foto;}

        Ilkhal _ilkhal;
        public FrmAyarlar()
        {
            InitializeComponent();
        }

        private void FrmAyarlar_Load(object sender, EventArgs e)
        {
            Olustur();
            BaglantiKontrolEt();
            ilkhalAl();
            _cbx.UlkeSet();
        }

       

        private void BaglantiKontrolEt()
        {
            if (!(_baglanti.KontrolEt()))
            {
                MessageBox.Show("Lütfen internet bağkantınız kontrol edip uygulamaya tekrar giriş yapınız.");
            }
        }

        private void ilkhalAl()
        {
            _ilkhal.foto = pbxUser.Image;
            _ilkhal.tbxEskiSifre = tbxEskiSifre.Text;
            _ilkhal.tbxTarif = tbxTarif.Text;
            _ilkhal.tbxYeniSifre = tbxYeniSifre.Text;
            _ilkhal.tbxYenisSifre2 = tbxYenisSifre2.Text;
        }

        private void Olustur()
        {
            _girisPersonel = GirisPersonelTut.Olustur();
            _baglanti = BaglantiKontrol.KontrolGet();

            _cbx = new cbxUlkeililce(cbxUlke, cbxIl, cbxIlce); 

            _uMPersonelAdresS = new UMPersonelAdresService(new EfPersonelAdresDal());
            _uMPersonelSifreS = new UMPersonelSifreService(new EfPersonelSifreDal());
            _uMFotografS = new UMFotografService(new EfFotografDal());

            _lMPersonelSifreS = new LMPersonelSifreService(new LM.EfPersonelSifreDal());
            
            //_sifre = DerinKopyala<PersonelSifre>.Kopyala(_girisPersonel.sifre);
            //_adres = DerinKopyala<PersonelAdres>.Kopyala(_girisPersonel.adres);
            //_foto = DerinKopyala<Fotograf>.Kopyala(_girisPersonel.fotograf);

            _ilkhal = new Ilkhal();
        }

        private void btnGizle_Click(object sender, EventArgs e)
        {
            char passwordChar;
            if (tbxEskiSifre.PasswordChar == '\0')
            {
                passwordChar = '*';
                btnGizle.BackgroundImage = Properties.Resources.passwordHide;
                pass();
            }else
            {
                passwordChar = '\0';
                btnGizle.BackgroundImage = Properties.Resources.passwordShow;
                pass();
            }
            void pass()
            {
                tbxEskiSifre.PasswordChar = passwordChar;
                tbxYeniSifre.PasswordChar = passwordChar;
                tbxYenisSifre2.PasswordChar = passwordChar;
            } 
        }

        private void pbxUser_Click(object sender, EventArgs e)
        {
            string text = ofdUser.FileName;
            ofdUser.ShowDialog();
            if ( !text.Trim().Equals(ofdUser.FileName.Trim()) && ofdUser.FileName.Trim() != "")
            {
                pbxUser.Image = Image.FromFile(ofdUser.FileName);
            }else
            {
                pbxUser.Image = Properties.Resources.user;
            }
        }

        private void btnSifreIptal_Click(object sender, EventArgs e)
        {
            tbxEskiSifre.Text = _ilkhal.tbxEskiSifre;
            tbxYeniSifre.Text = _ilkhal.tbxYeniSifre;
            tbxYenisSifre2.Text = _ilkhal.tbxYenisSifre2;
        }

        private void btnAdresIptal_Click(object sender, EventArgs e)
        {
            tbxTarif.Text = _ilkhal.tbxTarif;

            _cbx.Temizle();
        }

        private void btnResimIptal_Click(object sender, EventArgs e)
        {
            pbxUser.Image = _ilkhal.foto;
        }

        private void cbxUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbx.cbxUlke_SelectedIndexChanged(sender,e);
        }

        private void cbxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cbx.cbxIl_SelectedIndexChanged(sender, e);
        }

        private void cbxIl_DataSourceChanged(object sender, EventArgs e)
        {
            _cbx.cbxIl_DataSourceChanged(sender, e);
        }

        private void btnAdresKaydet_Click(object sender, EventArgs e)
        {
            if (_baglanti.KontrolEt() && _girisPersonel.adres != null && _girisPersonel.adres.Id > 0)
            {
                PersonelAdres adres = DerinKopyala<PersonelAdres>.Kopyala(_girisPersonel.adres);
                if (cbxIl.SelectedValue != null && cbxIlce.SelectedValue != null && cbxUlke.SelectedValue != null 
                    && Convert.ToInt32(cbxIlce.SelectedValue) != 0 && tbxTarif.Text.Trim() != "") // ilçe seçilmiş ise zaten ulke ve diğerleri seçilmiştir.
                {
                    try
                    {
                        adres.Ulke = Convert.ToInt32(cbxUlke.SelectedValue);
                        adres.Il = Convert.ToInt32(cbxIl.SelectedValue);
                        adres.Ilce = Convert.ToInt32(cbxIlce.SelectedValue);
                        adres.Tarif = tbxTarif.Text.Trim();
                        _uMPersonelAdresS.Update(adres);
                        _girisPersonel.adres = adres;
                        Tamamlandi();
                    }
                    catch
                    {
                        MessageBox.Show("Adres güncelleme sırasında hata oluştu");
                    }

                    btnAdresIptal_Click(sender, e);
                }
                else
                    MessageBox.Show("Lütfen ülke, il, ilçe seçimini yapınız.");

            }
            else
                MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz. Yeniden giriş yapınız.");
        }

        private void Tamamlandi()
        {
            MessageBox.Show("İşleminiz başarıyla tamamlandı");
        }

        private void btnSifreKaydet_Click(object sender, EventArgs e)
        {
            if (_girisPersonel.sifre != null && tbxEskiSifre.Text.Equals(_girisPersonel.sifre.Sifre))
            {
                if (tbxYeniSifre.Text.Equals(tbxYenisSifre2.Text) && tbxYeniSifre.Text.Trim() != "")
                {
                    PersonelSifre sifre = DerinKopyala<PersonelSifre>.Kopyala(_girisPersonel.sifre);
                    sifre.Sifre = tbxYeniSifre.Text;
                    if (_baglanti.KontrolEt())
                    {
                        try
                        {
                            _uMPersonelSifreS.Update(sifre);
                            _girisPersonel.sifre = sifre;
                            Tamamlandi();
                        }
                        catch
                        {
                            MessageBox.Show("Şifre güncelleme sırasında hata oluştu");
                        }

                        btnSifreIptal_Click(sender, e);
                    }
                    else
                        MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz. Yeniden giriş yapınız.");
                }
                else
                    MessageBox.Show("Yeni şifreler bir biriyle eşleşmiyor ve boş olabilir");
            }
            else
                MessageBox.Show("Eski şifreler bir biriyle uyuşmuyor veya şifre bilginiz gelmedi");
        }

        private void btnResimKaydet_Click(object sender, EventArgs e)
        {
            if (_girisPersonel.fotograf != null)
            {
                if (_baglanti.KontrolEt())
                {
                    Fotograf foto = DerinKopyala<Fotograf>.Kopyala(_girisPersonel.fotograf);
                    try
                    {
                        foto.FotoSet(pbxUser.Image);
                        _uMFotografS.Update(foto);
                        _girisPersonel.fotograf = foto;
                        Tamamlandi();
                    }
                    catch 
                    {
                        MessageBox.Show("Profil resmi güncelleme sırasında hata oluştu");
                    }
                    btnResimIptal_Click(sender, e);
                }else
                    MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz. Yeniden giriş yapınız.");

            }else
                MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz. Tekrar giriş yapınız.");
        }
    }
}
