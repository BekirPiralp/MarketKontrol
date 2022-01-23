using System;
using System.Windows.Forms;
using Market.Business.Concrete.LochalMarket;
using Market.DataAccess.Concrete.LochalMarket;
using Market.Entity.Concrete;

namespace Market.MarketKontrol.KontrolAyarları
{
    public partial class Baglanti : Form
    {
        public Baglanti()
        {
            InitializeComponent();
        }

        private LMBaglantiStringiService BaglantiService;
        private void Baglanti_Load(object sender, EventArgs e)
        {
            BaglantiService = new LMBaglantiStringiService(new BaglantiStringiDal());
            lblEskiBaglanti.Text = BaglantiService.Get() != null ? BaglantiService.Get().ConnetionString
                : "";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            BaglantiService.Set(
                new BaglantiStringi { ConnetionString = tbxYeniBaglanti.Text.Trim() });
            this.Close();
        }
    }
}
