using MarketSatis.VeriTabani.Kodlar;
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
    public partial class FormPersonelCikar : Form
    {
        private String Tc;
        private TemelVeri temelVeri;
        private SorguIslem sorguIslem = new SorguIslem();
        public FormPersonelCikar(String TcAl)
        {
            Tc = TcAl;
            InitializeComponent();
        }
        

        private void textBoxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPress(sender:sender,e:e);
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTamam_Click(object sender, EventArgs e)
        {
            if (textBoxTC.Text.Length == 11)
            {
                DialogResult dialogResult =
                MessageBox.Show("Eminisiniz ?", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    if (string.Compare(Tc, textBoxTC.Text) == 0)
                    {
                        MessageBox.Show("Kendinizi silemezsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        temelVeri = sorguIslem.temelVeriAl(this.textBoxTC.Text.Trim());
                        if(temelVeri != null && textBox1.Text != "")
                        {
                            /*Personel birçok kez işten çıkarılmış olabilir...*/
                            if (sorguIslem.temelVeriCikar(temelVeri: temelVeri, aciklama: textBox1.Text.Trim()))
                            {
                                MessageBox.Show("İslem başarılı");
                            }
                            else
                            {
                                MessageBox.Show("İslem başarısız");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen istenilen birl gileri tam giriniz ve Çıkarmak istediğiniz personelin " +
                                "sistemde kayıtlı olduğundan emin olunuz.");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Lütfen emin olduktan sonra tekrar geliniz.!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("TC kimlik numarası 11 hanelidir.!", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
