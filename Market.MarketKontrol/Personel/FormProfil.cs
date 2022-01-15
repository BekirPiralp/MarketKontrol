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
    public partial class FormProfil : Form
    {
        //public string Tc { get => Tc; set => Tc = value; }
        //Yukarıdakinde garip şekilde stack over flow hatası aldım
       
        private TemelVeri temelVeri;
        private SorguIslem sorguIslem = new SorguIslem();
   
        public FormProfil()
        {
            InitializeComponent();

        }

        public FormProfil(TemelVeri veri)
        {
            this.temelVeri = veri;
            InitializeComponent();
            this.labelAd.Text = temelVeri.Ad;
            this.labelSoyad.Text = temelVeri.Soyad;
            this.labelTc.Text = temelVeri.Tc;
            this.labelEkBilgi.Text = temelVeri.Ekbilgi;
            this.labelAdres.Text = temelVeri.Adres;
            this.labelCinsiyet.Text = temelVeri.Cinsiyet;
            this.labelYetki.Text = temelVeri.Yetki ? " Yönetici" : " Çalışan";
            this.pictureBox1.Image = temelVeri.fotograf!=null? temelVeri.fotograf:global::MarketSatis.Properties.Resources.boskullanici;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
