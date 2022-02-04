using System;
using System.Windows.Forms;
using Market.Business.Abstract.UzakMarket;
using Market.Business.Concrete.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;

namespace Market.MarketKontrol.Ortak
{
    public partial class FrmProfil : Form
    {
        public FrmProfil()
        {
            InitializeComponent();
        }

        private GirisPersonelTut _personel;
        private BaglantiKontrol _baglanti;
        private IUMIlService _uMIlService;
        private IUMIlceService _uMIlceService;
        private IUMUlkeService _uMUlkeService;

        private void FrmProfil_Load(object sender, EventArgs e)
        {
            Olustur();
            EkranaBas();
        }

        private void EkranaBas()
        {
            if(_personel.adres != null && _personel.personel != null && _personel.fotograf != null)
            {
                lblTc.Text = _personel.personel.Tc;
                lblAd.Text = _personel.personel.Ad;
                lblSoyad.Text = _personel.personel.Soyad;
                lblCinsiyet.Text = _personel.personel.Cinsiyet.ToString();
                if (_personel.ekBilgi != null)
                    lblEkBilgi.Text = _personel.ekBilgi.Aciklama;
                else
                    lblEkBilgi.Text = "Ek bilginiz bulunamadı.";
                
                pbxUser.Image = _personel.fotograf.FotoGet();

                string Adres = _personel.adres.Tarif;
                try
                {
                    if (_baglanti.KontrolEt())
                    {
                        Adres += " " + _uMIlceService.GetById(_personel.adres.Ilce).Ad;
                        Adres += "/" + _uMIlService.GetById(_personel.adres.Il).Ad;
                        Adres += "/" + _uMUlkeService.GetById(_personel.adres.Ulke).Ad.ToUpper();
                    }

                    if (GirisPersonelTut._firmaSahibiMi)
                    {
                        lblYetki.Text = "Firma Sahibi";
                    }else if (GirisPersonelTut._mudur)
                    {
                        lblYetki.Text = "Müdür";
                    }
                    else
                    {
                        lblYetki.Text = "Personel";
                    }
                }
                catch
                {
                    MessageBox.Show("Bağlantı hatası ile karşılaşıldı.");
                }
                lblAdres.Text = Adres; //il ilçe ve ülke çekilecek
            }
            else
            {
                MessageBox.Show("Verilerinizde eksik olduğu için bu sayfada size birşey gösteremiyoruz.");
            }
        }

        private void Olustur()
        {
            _baglanti = BaglantiKontrol.KontrolGet();
            _personel = GirisPersonelTut.Olustur();
            _uMIlceService = new UMIlceService(new EfIlceDal());
            _uMIlService = new UMIlService(new EfIlDal());
            _uMUlkeService = new UMUlkeService(new EfUlkeDal());
        }
    }
}
