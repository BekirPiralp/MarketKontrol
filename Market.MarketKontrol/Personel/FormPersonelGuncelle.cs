using MarketSatis.VeriTabani.Kodlar;
using MarketSatis.VeriTabani.Veritabani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketSatis
{
    public partial class FormPersonelGuncelle : Form
    {
        SorguIslem sorguIslem = new SorguIslem();
        List<Ozel> ulke, ilce, il;
        TemelVeri guncel,temelVeri;
        bool kntrl = false;


        public FormPersonelGuncelle()
        {
            InitializeComponent();
        }

        private void buttonGozat_Click(object sender, EventArgs e)
        {
            openFileDialogResim.Filter= "sadece jpg png tif jpeg ico|*.jpg; *.png; *.tif; *.jpeg; *.ico";
            openFileDialogResim.FileName = "Resim seçin";
            this.openFileDialogResim.ShowDialog();

            textBoxResim.Text = openFileDialogResim.FileName;

            try
            {
                pictureBox1.Image = Image.FromFile(textBoxResim.Text);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("Lütfen resim seçin", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxResim.Text = "";
            }
        }

        private void textBoxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPress(sender: sender, e: e);
        }

        private void textBoxAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPressHarf(sender:sender,e:e);
        }
       
        private void buttonTamam_Click(object sender, EventArgs e)
        {
           
            if(textBoxTc.Text != "" && textBoxTc.Text.Length == 11)
            {
                //veri tabanı bulma ver ekleme kodu yazılacak
                try
                {
                    temelVeri = sorguIslem.temelVeriAl(textBoxTc.Text);
                    guncel = new TemelVeri(); 
                    sorguIslem.temelVeriKopyala(temelVeri, guncel);
                    if(temelVeri==null)
                    {
                        MessageBox.Show("Kullanıcının sistemde kayıtl olduğundan emin olunuz");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("Bir hata ile karşılaşıldı");
                    return;
                }

                if (
                    this.textBoxTc.Text != "" || textBoxAd.Text != "" || textBoxSoyad.Text != "" ||
                    radioButtonCalisan.Checked || radioButtonYonetici.Checked||
                    textBoxAdres.Text != "" || kntrl ||pictureBox1.Image!=null)
                {
                    try
                    {
                        if (checkBoxAd.Checked && textBoxAd.Text != "")
                            guncel.Ad = textBoxAd.Text.Trim();
                        if (checkBoxDurum.Checked)
                            guncel.Yetki = radioButtonYonetici.Checked;
                        if (checkBoxEkbilgi.Checked && textBoxEkbilgi.Text != "")
                            guncel.Ekbilgi = textBoxEkbilgi.Text.Trim();
                        if (checkBoxSoyad.Checked && textBoxSoyad.Text != "")
                            guncel.Soyad = textBoxSoyad.Text.Trim();
                        if (checkBoxResim.Checked && pictureBox1.Image != null)
                            guncel.fotograf = pictureBox1.Image;
                        if (checkBoxAdres.Checked && kntrl && textBoxAdres.Text != "")
                        {
                            guncel.Adres = textBoxAdres.Text.Trim();
                            guncel.il = il[comboBoxil.SelectedIndex].id;
                            guncel.ilce = ilce[comboBoxilçe.SelectedIndex].id;
                            guncel.Ulke = ulke[comboBoxUlke.SelectedIndex].id;
                        }
                    }
                    catch 
                    {

                        MessageBox.Show("Verileri almada bir hata oluştu");
                    }

                    try
                    {
                       if (sorguIslem.temelVeriGuncelle(temelVeri, guncel))
                        {
                            MessageBox.Show("İşlem başarıyla gerçekleşti");
                        }
                        else
                        {
                            MessageBox.Show("Verileri kayıt esnasında bir hata oluştu");
                        }
                    }
                    catch 
                    {
                        MessageBox.Show("Verileri kayıt esnasında bir hata oluştu");
                    }
                        

                }
                else
                {
                    MessageBox.Show("En az bir güncellem yapmalısınız...","Dikkat",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istedğiniz kişinin 11 haneli TC kimlik numarasını giriniz.!","Dikkat",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void comboBoxUlke_MouseHover(object sender, EventArgs e)
        {
            comboBoxil.Items.Clear();
            comboBoxilçe.Items.Clear();
            comboBoxUlke.Items.Clear();

            ulke =
            sorguIslem.ComboBoxVeriEkle(tablo: sorguIslem.tabloUlke, comboBox: (ComboBox)sender);
        }

        private void comboBoxUlke_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxilçe.Items.Clear();
            comboBoxil.Items.Clear();

            il = sorguIslem.ComboBoxVeriEkle(
                tablo: sorguIslem.tabloil,
                comboBox: comboBoxil,
                sart: sorguIslem.sorguUlke + " = " + ulke[comboBoxUlke.SelectedIndex].id);
        }

        private void comboBoxil_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxilçe.Items.Clear();

            ilce = sorguIslem.ComboBoxVeriEkle(
                tablo: sorguIslem.tabloilçe,
                comboBox: comboBoxilçe,
                sart: sorguIslem.sorguUlke + " = " + ulke[comboBoxUlke.SelectedIndex].id +
                " and " + sorguIslem.sorguil + " = " + il[comboBoxUlke.SelectedIndex].id);
           
        }

        private void comboBoxilçe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // şuan için gerek görmüyorum ama seçimi sağlamam lazım
            // peki otomatik gelen değer işine yararsa?

            try
            {
                if(comboBoxilçe.SelectedItem.ToString() != "")
                {
                    kntrl = true; // önlem
                }
            }
            catch
            {

                kntrl = false;
            }
            kntrl = true;//buraya kadar gelsiyse zaten ...
        }

        private void temizle()
        {
            /*Verileri temizleme*/
            kntrl = false;
            textBoxTc.Text = "";
            pictureBox1.Image = null;
            textBoxAd.Text = "";
            textBoxSoyad.Text = "";
            comboBoxil.Items.Clear();
            comboBoxilçe.Items.Clear();
            comboBoxUlke.Items.Clear();
            textBoxAdres.Text = "";
            textBoxEkbilgi.Text = "";
            textBoxResim.Text = "";
            ulke = null;
            il = null;
            ilce = null;
        }

        ~FormPersonelGuncelle()
        {
            temizle();
            GC.Collect();
        }
    }
}
