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

namespace Market.FirmaSahibi.FirmaSahibi
{
    public partial class FrmBayi : Form
    {
        public FrmBayi()
        {
            InitializeComponent();
        }

        GirisPersonelTut _personel = null;
        BaglantiKontrol _baglanti = null;

        IUMBayiService _uMBayiS;
        IUMBayiAdresService _uMBayiAdresS;

        Bayi _bayi = null;
        BayiAdres _adres = null;
        List<Bayi> _bayiler = null;

        cbxUlkeililce _cbx = null;

        struct Ilkhal
        {
            public string tbxAd;
            public string tbxAdres;
        }

        Ilkhal _ilkhal;

        private void FrmBayi_Load(object sender, EventArgs e)
        {
            Olustur();
            GetirBayiler();
            cbxYukle();
        }

        private void Olustur()
        {
            _personel = GirisPersonelTut.Olustur();
            _baglanti = BaglantiKontrol.KontrolGet();

            _uMBayiS = new UMBayiService(new EfBayiDal());
            _uMBayiAdresS = new UMBayiAdresService(new EfBayiAdresDal());

            _ilkhal = new Ilkhal
            {
                tbxAd = tbxBayiAd.Text,
                tbxAdres = tbxAdres.Text
            };

            _cbx = new cbxUlkeililce(cbxUlke,cbxIl,cbxIlce);
        }

        private void GetirBayiler()
        {
            try
            {
                if (_baglanti.KontrolEt())
                {
                    if (_personel.firma != null && _personel.firma.Id > 0)
                    {
                        _bayiler = _uMBayiS.GetAllByFirma(_personel.firma);

                        dgwBas();
                    }
                    else
                        MessageBox.Show("Personel bilgisi tam gelmediği için bayileri getiremiyoruz.\n" +
                            "Lütfen internet bağlantınızı kontrol edip yeniden giriş yapınız.");
                }
                else
                    MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz ve yeniden giriş yapınız.");
            }
            catch{
                MessageBox.Show("Bayiler getirilirken hata oluştu.");
            }
        }

        private void dgwBas()
        {
            if (_bayiler != null && _bayiler.Count > 0)
            {
                dgwBayi.DataSource = _bayiler;
            }
            else
                MessageBox.Show("Lütfen sisteme en az 1 adet bayi ekleyiniz.");
        }

        private void cbxYukle()
        {
            try
            {
                _cbx.UlkeSet();
            }
            catch
            {
                MessageBox.Show("Ülke, il, ilçe verileri getirilirken hata oluştu.");
            }
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

        private void Temizle()
        {
            _bayi = null;
            _adres = null;

            tbxAdres.Text = _ilkhal.tbxAdres;
            tbxBayiAd.Text = _ilkhal.tbxAd;

            _cbx.Temizle();
        }

        private void dgwBayi_SelectionChanged(object sender, EventArgs e)
        {
            SeciliBayiyiAl();
        }

        private void dgwBayi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeciliBayiyiAl();
        }

        private void SeciliBayiyiAl()
        {
            _bayi = null;
            _adres = null;

            try
            {
                if (Convert.ToInt32(dgwBayi.CurrentRow.Cells[2].Value) > 0)
                {
                    _bayi = new Bayi
                    {
                        Id = Convert.ToInt32(dgwBayi.CurrentRow.Cells[2].Value),
                        Firma = Convert.ToInt32(dgwBayi.CurrentRow.Cells[0].Value),
                        BayiAd = dgwBayi.CurrentRow.Cells[1].Value.ToString()
                    };

                    if (_baglanti.KontrolEt())
                    {
                        _adres = _uMBayiAdresS.GetByBayi(_bayi);
                        if (_adres != null && _adres.Id > 0)
                            AdresEkranaBas();
                    }
                    else
                        MessageBox.Show("Lütfen internet bağlantınızı kontrol edip tekrar giriş yapınız.");
                }
            }
            catch{
                MessageBox.Show("Seçili bayi'nin adres bilgisi getiriliken hata oluştu.");
            }
        }

        private void AdresEkranaBas()
        {
            tbxAdres.Text = _adres.Tarif;
            tbxBayiAd.Text = _bayi.BayiAd;

            try
            {
                _cbx.UlkeSet();
                cbxUlke.SelectedValue = _adres.Ulke;
                _cbx.cbxUlke_SelectedIndexChanged();
                cbxIl.SelectedValue = _adres.Il;
                _cbx.cbxIl_DataSourceChanged();
                _cbx.cbxIl_SelectedIndexChanged();
                cbxIlce.SelectedValue = _adres.Ilce;

                cbxAdresUpdate();
            }
            catch
            {
            }
        }

        private void cbxAdresUpdate()
        {
            cbxUlke.Update();
            cbxIl.Update();
            cbxIlce.Update();

            cbxUlke.Show();
            cbxIl.Show();
            cbxIlce.Show();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (_baglanti.KontrolEt())
                {
                    VeriEkrandanAl();
                    if (_bayi != null && _adres != null)
                    {
                        if (_baglanti.KontrolEt())
                        {
                            _uMBayiS.Add(_bayi);
                            _bayi = _uMBayiS.GetByAd(_bayi.BayiAd, _personel.firma);

                            if (_bayi != null && _bayi.Id > 0)
                            {
                                _adres.Bayi = _bayi.Id;
                                _uMBayiAdresS.Add(_adres);

                                MessageBox.Show("İşleminiz başarıyla gerçekleştirildi.");
                            }
                            else
                                throw new Exception("Oluşturulan bayi geri çekilirken hata oluştu");
                        }
                        else
                            MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz ve yenşden giriş yapınız.");
                    } 
                }else
                    
                    MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz ve yenşden giriş yapınız.");

            }
            catch{
                MessageBox.Show("Bayi ekleme esnasında hata oluştu");
            }
            finally
            {
                Temizle();
            }
            GetirBayiler();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxBayiAd.Text.Trim() != "" && tbxAdres.Text.Trim() != "" &&cbxIlce.Items != null &&
                        cbxIlce.Items.Count > 0 && cbxIlce.SelectedValue != null &&Convert.ToInt32(cbxIlce.SelectedValue) != 0
                        && _bayi != null && _adres != null && _bayi.Id > 0 && _adres.Id > 0)
                {
                    if (_baglanti.KontrolEt()) // internet kontrolü
                    {
                        VeriEkrandanAl();
                    
                        if (_bayi != null && _adres != null 
                            && _bayi.Id > 0 && _adres.Id > 0 )//güncelleme olduğu için
                        {
                            _uMBayiS.Update(_bayi);
                            _uMBayiAdresS.Update(_adres);
                            MessageBox.Show("İşleminiz başarıyla gerçekleştirildi.");
                        }
                    }
                    else
                        MessageBox.Show("Lütfen internet bağlantınız kontrol ediniz ve yeniden giriş yapınız.");
                }
                else
                    MessageBox.Show("Lütfen bilgileri eksiksiz giriniz.");
            }
            catch{
                MessageBox.Show("Güncelleme esnasında hata ile karşılaşıldı.");
            }
            finally
            {
                Temizle();
            }
            GetirBayiler();
        }

        private void VeriEkrandanAl()
        {
            Bayi bayiGelen = _uMBayiS.GetByAd(tbxBayiAd.Text.Trim(), _personel.firma);

            if(bayiGelen != null && bayiGelen.Id > 0) // aynı isimde bir bayi varsa
            {
                if (bayiGelen.BayiAd.Trim().ToLower().Equals(tbxBayiAd.Text.Trim().ToLower()))
                {
                    if(_bayi == null) // bayi ilk defa oluşturuluyorsa
                    {
                        MessageBox.Show("Aynı isimde şuanda bir bayiniz olduğu için işleminiz gerçekleştiremiyoruz.");
                        bayiGelen = null;
                        Temizle();
                        return;
                    }
                    else // bayi varsa yani güncellemede ise
                    {
                        if(bayiGelen.Id != _bayi.Id) //Başka bir bayide aynı ad var demektir.
                        {
                            MessageBox.Show("Aynı isimde başka bir bayi olduğu için işleminiz geçersiz.");
                            bayiGelen = null;
                            Temizle();
                            return;
                        }
                    }
                    
                }
            }

            


            if (_bayi == null && _adres == null || _bayi.Id <= 0 && _adres.Id <= 0)
            {
                
                _bayi = new Bayi
                {
                    Firma = _personel.firma.Id,
                };
                //bayi yi alma ve alınan bayinin idsini yeni eklemede adrese atama...?
                _adres = new BayiAdres
                {
                    Firma = _personel.firma.Id
                };
            }

            _bayi.BayiAd = tbxBayiAd.Text.Trim();
            _adres.Tarif = tbxAdres.Text.Trim();

            if (cbxIl.SelectedValue != null && cbxIlce.SelectedValue != null && cbxUlke.SelectedValue != null &&
                Convert.ToInt32(cbxIl.SelectedValue) > 0 && Convert.ToInt32(cbxIlce.SelectedValue) > 0
                && Convert.ToInt32(cbxUlke.SelectedValue) > 0)
            {
                _adres.Ulke = Convert.ToInt32(cbxUlke.SelectedValue);
                _adres.Il = Convert.ToInt32(cbxIl.SelectedValue);
                _adres.Ilce = Convert.ToInt32(cbxIlce.SelectedValue);
            }
            else
                MessageBox.Show("Lütfen bilgileri tam olarak ayarlayınız.");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
