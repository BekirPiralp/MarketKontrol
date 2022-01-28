using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.Business.Abstract.UzakMarket;
using Market.Business.Concrete.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using Market.DataAccess.Concrete.UzakMarket.EntityFramework;

namespace Market.MarketKontrol.ayarlar
{
    public class cbxUlkeililce
    {
        public cbxUlkeililce(ComboBox cbxUlke,ComboBox cbxIl,ComboBox cbxIlce)
        {
            _baglanti = BaglantiKontrol.KontrolGet();

            _uMUlkeS = new UMUlkeService(new EfUlkeDal());
            _uMIlS = new UMIlService(new EfIlDal());
            _uMIlceS = new UMIlceService(new EfIlceDal());

            this.cbxUlke = cbxUlke;
            this.cbxIl = cbxIl;
            this.cbxIlce = cbxIlce;
        }

         ComboBox cbxUlke;
         ComboBox cbxIl;
         ComboBox cbxIlce;
         BaglantiKontrol _baglanti;

         IUMUlkeService _uMUlkeS;
         IUMIlService _uMIlS;
         IUMIlceService _uMIlceS;

        public  void UlkeSet()
        {
            if (_baglanti.KontrolEt())
            {
                cbxUlke.DataSource = _uMUlkeS.GetAll();
                cbxUlke.DisplayMember = "Ad";
                cbxUlke.ValueMember = "Id";
            }
            else
                MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz.");
        }

        public  void cbxUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int SelectValue = Convert.ToInt32(cbxUlke.SelectedValue);

                if (SelectValue == 0)
                {
                    UlkeSet();
                    cbxIl.Items.Clear();
                    cbxIlce.Items.Clear();
                }
                else
                {
                    IlSet(SelectValue);
                }
            }
            catch {
                MessageBox.Show("Ülke verisinde hata oluştu.");
            }
        }

        private  void IlSet(int selectValue)
        {
            if (_baglanti.KontrolEt())
            {
                cbxIl.DataSource = _uMIlS.GetByUlkeId(selectValue);
                cbxIl.ValueMember = "Id";
                cbxIl.DisplayMember = "Ad";
            }else
                MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz.");
        }

        public  void cbxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int SelectValue = Convert.ToInt32(cbxIl.SelectedValue);
                if (SelectValue == 0)
                {
                    UlkeSet();
                }
                else
                {
                    IlceSet(SelectValue);
                }
            }
            catch {
                MessageBox.Show("İl verisinde hata oluştu.");
            }
        }

        private  void IlceSet(int selectValue)
        {
            if (_baglanti.KontrolEt())
            {
                cbxIlce.DataSource = _uMIlceS.GetByIlId(selectValue);
                cbxIlce.ValueMember = "Id";
                cbxIlce.DisplayMember = "Ad";
            }else
                MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz.");
        }

        public  void cbxIl_DataSourceChanged(object sender, EventArgs e)
        {
            cbxIlce.Items.Clear();
        }

        public void Temizle()
        {
            cbxIlce.Items.Clear();
            cbxIl.Items.Clear();
            cbxUlke.SelectedIndex = 0;
            //cbxUlke.Items.Clear();
        }
    }
}
