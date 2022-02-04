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

        private void Update()
        {
            cbxUlke.Update();
            cbxIl.Update();
            cbxIlce.Update();
        }

        public  void UlkeSet()
        {
            if (_baglanti.KontrolEt())
            {
                cbxUlke.DataSource = _uMUlkeS.GetAll();
                cbxUlke.DisplayMember = "Ad";
                cbxUlke.ValueMember = "Id";
                Update();
            }
            else
                MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz.");
        }

        public  void cbxUlke_SelectedIndexChanged()
        {
            try
            {
                int SelectValue = 0;
                if(cbxUlke.SelectedValue != null)
                    SelectValue = Convert.ToInt32(cbxUlke.SelectedValue);

                if (SelectValue == 0)
                {
                    UlkeSet();
                    cbxIlce.DataSource = null;
                    cbxIlce.Text = "İlçe";
                    cbxIl.DataSource = null;
                    cbxIl.Text = "İl";
                }
                else
                {
                    IlSet(SelectValue);
                }
                Update();
            }
            catch {
                
            }
        }

        public void cbxUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxUlke_SelectedIndexChanged();
        }

        private  void IlSet(int selectValue)
        {
            if (_baglanti.KontrolEt())
            {
                cbxIl.DataSource = _uMIlS.GetByUlkeId(selectValue);
                cbxIl.ValueMember = "Id";
                cbxIl.DisplayMember = "Ad";
                Update();
            }
            else
                MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz.");
        }

        public  void cbxIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxIl_SelectedIndexChanged();
        }

        public void cbxIl_SelectedIndexChanged()
        {
            try
            {
                int SelectValue = 0;
                if (cbxIl.SelectedValue != null)
                    SelectValue = Convert.ToInt32(cbxIl.SelectedValue);
                if (SelectValue == 0)
                {
                    UlkeSet();
                    Update();
                }
                else
                {
                    IlceSet(SelectValue);
                }
            }
            catch
            {

            }
        }

        private  void IlceSet(int selectValue)
        {
            if (_baglanti.KontrolEt())
            {
                cbxIlce.DataSource = _uMIlceS.GetByIlId(selectValue);
                cbxIlce.ValueMember = "Id";
                cbxIlce.DisplayMember = "Ad";
                Update();
            }
            else
                MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz.");
        }

        public  void cbxIl_DataSourceChanged(object sender, EventArgs e)
        {
            cbxIl_DataSourceChanged();
        }

        public void cbxIl_DataSourceChanged()
        {
            cbxIlce.DataSource = null;
            cbxIlce.Text = "İlçe";
            Update();
        }

        public void Temizle()
        {

            cbxIlce.DataSource = null;
            cbxIlce.Text = "İlçe";
            cbxIl.DataSource = null;
            cbxIl.Text = "İl";
            if(cbxUlke.Items != null && cbxUlke.Items.Count > 0)
                cbxUlke.SelectedIndex = 0;
            cbxUlke.Text = "Ülke";
            //cbxUlke.Items.Clear();
            Update();
        }
    }
}
