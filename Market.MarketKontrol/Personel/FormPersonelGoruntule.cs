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
    public partial class FormPersonelGoruntule:Form
    {
        SorguIslem sorguIslem = new SorguIslem();
        TemelVeri temelVeri;
        public FormPersonelGoruntule()
        {
            InitializeComponent();
           
        }

        private void buttonGor_Click(object sender, EventArgs e)
        {
            if(textBoxTc.TextLength==11)
            {
                temelVeri = sorguIslem.temelVeriAl(textBoxTc.Text.Trim());
                if (temelVeri != null)
                {

                    FormProfil formProfil = new FormProfil(temelVeri);

                    formProfil.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri kontrol ediniz veya aradığınız kullanıcın sistemde kayıtlı olduğundan emin olunuz.");
                }
            }
            else
            {
                
                MessageBox.Show("TC kimlik no 11 haneli olmalıdır.","Dikkat",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                
            }
            
        }

        private void textBoxTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            TemelKurallar.textBox_KeyPress(sender,e);
        }

        /*
         List box katıp ad soyad listeletip tıklamaya göre aça bilirdim
        fakat burası kelime arama yeri değil eğerki görüntülenmek istenen personelin Tc'si bilinmiyor
        o kişinin pek yönetici biri olduğunu söyleyemem
        Çünkü bir kişi bir yere işe giderken Sigorta şartından dolayı ilk olarak kimlik bilgileri alınır...
        Ve bunların bir nüshasıda ellerinde fiziksel döküman olarak depolanır...
         */
    }
   
}
