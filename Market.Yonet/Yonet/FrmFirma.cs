using Market.Business.Abstract.UzakMarket;
using Market.Business.Concrete.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;
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

        public FrmFirma()
        {
            InitializeComponent();
        }

        private void FrmFirma_Load(object sender, EventArgs e)
        {
            Olustur();
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
        }
    }
}
