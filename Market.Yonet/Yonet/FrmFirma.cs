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
            public string tbxPrsnlAd, tbxPrsnlTc, tbxPrsnlSoyad, tbxPrsnlGorev, tbxPrsnlAdres, tbxEkbilgi;
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
                tbxPrsnlGorev = tbxGorev.Text,
                cinsiyet = true,
                tbxPrsnlAdres = tbxAdres.Text,
                tbxEkbilgi = tbxEkBilgi.Text,

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
            catch{
                MessageBox.Show("Firmalar getirilirken hata oluştu.");
            }
        }

        private List<Firma> firmalarAl()
        {
            List<Firma>  result = null;
            try
            {
                if (_baglanti.KontrolEt())
                {
                    result = _uMFirmaS.GetAll();
                    if (result == null || result.Count <= 0 || result[0].Id <= 0)
                        result = null;
                }
            }
            catch{}
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

        private void Temizle()
        {
            // genel temzileme için

        }

        //ilkhal methodu yazılacak ve ona göre nesne oluşturulacak

        private void tbxMouseHover(object sender, EventArgs args)
        {
            MouseOlay.tbxMouseHover(sender);
        }
    }
}
