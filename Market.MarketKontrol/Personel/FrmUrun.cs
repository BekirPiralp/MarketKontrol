using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.Business.Concrete.DigerIslemler;
using Market.Business.Concrete.UzakMarket;
using LM = Market.DataAccess.Concrete.LochalMarket.EntityFramework;
using UM = Market.DataAccess.Concrete.UzakMarket.EntityFramework;
using Market.Entity.Concrete;
using Market.MarketKontrol.ayarlar;
using Market.Restriction.Utilities;
using Market.Restriction.ValidationRules.FluentValidation;
using Market.Restriction.ValidationRules.FluentValidation.UzakMarket;
using Market.Business.Concrete.LochalMarket;

namespace Market.MarketKontrol.Personel
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void pbxUrun_Click(object sender, EventArgs e)
        {
            string text = ofdUrun.FileName;
            ofdUrun.ShowDialog();
            if (!(text.Trim().Equals(ofdUrun.FileName.Trim())) && ofdUrun.FileName.Trim() != "")
                pbxUrun.Image = Image.FromFile(ofdUrun.FileName.Trim());
            else
                    pbxUrun.Image = Properties.Resources.urun;
        }
        
        private Urun _ilkhal,_SecUrun;
        private GirisPersonelTut personel;
        private BaglantiKontrol baglantiKontrol;
        private UMUrunService _uMUrunService;
        private LMUrunService _lMUrunService;
        private LMDepoEkleUrunService _depoEkleUrunService;

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            try
            {
                Atamalar();

                ilkdegerleriKopyala();
                baglantiKontrol.KontrolEt();
                LoadUruns();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Açılış sırasında hata oluştu:\n" + hata.Message);
            }
        }

        private void LoadUruns()
        {
            if (baglantiKontrol.KontrolEt())
                dgwUrun.DataSource = _uMUrunService.GetByAll(personel.bayi, personel.firma);
            else
                dgwUrun.DataSource = _lMUrunService.GetByAll(personel.bayi, personel.firma);
            Temizle();
        }

        private void Atamalar()
        {
            personel = GirisPersonelTut.Olustur();
            baglantiKontrol = BaglantiKontrol.KontrolGet();
            _ilkhal = new Urun();
            _uMUrunService = new UMUrunService(new UM.EfUrunDal());
            _lMUrunService = new LMUrunService(new LM.EfUrunDal());
            _depoEkleUrunService = new LMDepoEkleUrunService(new LM.EfDepoEkleUrunDal());
        }

        private void ilkdegerleriKopyala()
        {
            EkrandanAl(_ilkhal);
        }
        private void Temizle()
        {
            EkranaKopyala(_ilkhal);
            _SecUrun = null;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnYeniUrunKaydet_Click(object sender, EventArgs e)
        {
            Urun urunGel = null;
            if (baglantiKontrol.KontrolEt() && personel.firma != null && personel.bayi!=null)
            {
                try
                {
                    urunGel = _uMUrunService.GetByBarkod(tbxBarkod.Text.Trim(), personel.bayi, personel.firma);
                    if (urunGel == null)
                    {
                        Urun yeni = new Urun
                        {
                            Ad = tbxAd.Text.Trim(),
                            Aciklama = tbxAciklama.Text.Trim(),
                            Adet = (int)numAdet.Value,
                            Barkod = tbxBarkod.Text.Trim(),
                            Bayi = personel.bayi.Id,
                            Firma = personel.firma.Id,
                            Fiyat = (float)numFiyat.Value,
                            Marka = tbxMarka.Text.Trim(),
                            UretimYeri = tbxUretimYeri.Text.Trim()

                        };
                        yeni.ResimSet(pbxUrun.Image);
                        _uMUrunService.Add(yeni);
                    }
                    else
                    {
                        throw new Exception("Bu ürün bu bayi için sistemde kayıtlı");
                    }
                }
                catch (Exception hata)
                {

                    MessageBox.Show("Ürün kaydetme sırasında ile Karşılaşıldı :\n" + hata.Message);
                }
            }
            else
            {
                MessageBox.Show("Şuanda internet bağlantısı yok veya bir hata ile karşılaşıldı bu işlemi gerçekleştiremezsiniz");
            }
            LoadUruns();
        }

        /*Fare üzerine geldiğinde ekranı temizleme*/
        private void tbxs_MouseHover(object sender, EventArgs e)
        {
            MouseOlay.tbxMouseHover(sender);
        }

        private void dgwUrun_SelectionChanged(object sender, EventArgs e)
        {
            
            SecAl();
        }

        private void dgwUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SecAl();
        }

        private void SecAl()
        {
            if (dgwUrun.Rows.Count>0)
            {
                _SecUrun = new Urun();
                _SecUrun.Firma = int.Parse(dgwUrun.CurrentRow.Cells[0].Value.ToString());
                _SecUrun.Bayi = int.Parse(dgwUrun.CurrentRow.Cells[1].Value.ToString());
                _SecUrun.Barkod = dgwUrun.CurrentRow.Cells[2].Value.ToString();
                _SecUrun.Ad = dgwUrun.CurrentRow.Cells[3].Value.ToString();
                _SecUrun.Marka = dgwUrun.CurrentRow.Cells[4].Value.ToString();
                _SecUrun.UretimYeri = dgwUrun.CurrentRow.Cells[5].Value.ToString();
                _SecUrun.Fiyat = float.Parse(dgwUrun.CurrentRow.Cells[6].Value.ToString());
                _SecUrun.Indirim = float.Parse(dgwUrun.CurrentRow.Cells[7].Value.ToString());
                _SecUrun.Adet = int.Parse(dgwUrun.CurrentRow.Cells[8].Value.ToString());
                _SecUrun.Aciklama = dgwUrun.CurrentRow.Cells[9].Value.ToString();
                _SecUrun.Resim = (byte[])(dgwUrun.CurrentRow.Cells[10].Value);
                _SecUrun.Id = int.Parse(dgwUrun.CurrentRow.Cells[11].Value.ToString());
            }
            else
            {
                _SecUrun = null;
            }
            if(_SecUrun != null)
            {
                EkranaKopyala(_SecUrun);
            }
            else
            {
                Temizle();
            }
        }

        private void EkrandanAl (Urun urun)
        {
            urun.Ad = tbxAd.Text;
            urun.Adet = (int)numAdet.Value;
            urun.Barkod = tbxBarkod.Text;
            urun.Fiyat = (float)numFiyat.Value;
            urun.Marka = tbxMarka.Text;
            urun.UretimYeri = tbxUretimYeri.Text;
            urun.ResimSet(pbxUrun.Image);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglantiKontrol.KontrolEt())
                {
                    if (_SecUrun != null)
                    {
                        EkrandanAl(_SecUrun);
                        _uMUrunService.Update(_SecUrun);
                    }
                    else
                    {
                        throw new Exception("Güncellemek istediğiniz ürünü seçiniz");
                    }

                }
                else
                {
                    throw new Exception("Lütfen bağlantınızı kontrol ediniz");
                }
            }
            catch(Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
            finally
            {
                LoadUruns();
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            DialogResult result =
            MessageBox.Show("Depoya eklemek istediğiniz kadar ürün adedi giriniz. \nDiğer şekilde Güncelleme yapınız." +
                "\nAdet verisini doğru girdiğinize emin misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (_SecUrun != null)
                    {
                        Urun urun;
                        DepoEkleUrun depoEkle;
                        urun = DerinKopyala<Urun>.Kopyala(_SecUrun);
                        EkrandanAl(_SecUrun);
                        urun.Adet += _SecUrun.Adet;
                        if (baglantiKontrol.KontrolEt())
                        {
                            _uMUrunService.Update(urun);
                        }
                        else
                        {
                            depoEkle = new DepoEkleUrun { Urun = urun.Id, Adet = _SecUrun.Adet };
                            _lMUrunService.Update(urun);
                            _depoEkleUrunService.Add(depoEkle);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir ürün seçin");
                    }
                }
                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message);
                }
                finally
                {
                    LoadUruns();
                }
            }
        }

        private void tbxBarkod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (baglantiKontrol.KontrolEt())
                {
                    dgwUrun.DataSource = tbxBarkod.Text.Trim() == "" ?
                        _uMUrunService.GetByAll(personel.bayi, personel.firma)
                        : _uMUrunService.GetByAllBarkod(tbxBarkod.Text, personel.bayi, personel.firma);
                }
                else
                {
                    dgwUrun.DataSource = tbxBarkod.Text.Trim() == "" ?
                        _lMUrunService.GetByAll(personel.bayi, personel.firma)
                        : _lMUrunService.GetByAllBarkod(tbxBarkod.Text, personel.bayi, personel.firma);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
                Temizle();
            }
                       
        }

        private void EkranaKopyala (Urun urun)
        {
            tbxAciklama.Text = urun.Aciklama;
            tbxAd.Text = urun.Ad;
            tbxBarkod.Text = urun.Barkod;
            tbxMarka.Text = urun.Marka;
            tbxUretimYeri.Text = urun.UretimYeri;
            numAdet.Value = urun.Adet;
            numFiyat.Value = (Decimal)urun.Fiyat;
            pbxUrun.Image = urun.ResimGet();
        }

       
    }
}
