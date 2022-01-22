using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Market.MarketKontrol.ayarlar;
using Market.MarketKontrol.Ortak;

namespace Market.FirmaSahibi.FirmaSahibi
{
    public partial class FrmSahibi : Form
    {
        public FrmSahibi()
        {
            InitializeComponent();
        }
        private void mouseUp(object sender, MouseEventArgs e)
        {
            FormTasi.mouseUp();
        }
        private void mouseDown(object sender, MouseEventArgs e)
        {
            FormTasi.mouseDown(e);
        }
        private void mouseMove(object sender, MouseEventArgs e)
        {
            FormTasi.mouseMove(e, this);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            //çıkış
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //görev çubuğuna küçültme
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            //büyültme küçültme
            this.WindowState = this.WindowState == FormWindowState.Normal
                ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private Button seciliButton;
        private Form aktifForm;

        private void OpenForm(Form form, object btnSender)
        {
            if (aktifForm != null)
            { aktifForm.Close(); }
            btnAktif(btnSender);
            aktifForm = form;
            aktifForm.TopLevel = false; // bu sayede düşük düzey pencere olacak yani panel içi gösterile bilecek
            aktifForm.FormBorderStyle = FormBorderStyle.None;
            aktifForm.Dock = DockStyle.Fill;
            this.pnlWindow.Controls.Add(aktifForm);
            this.pnlWindow.Tag = aktifForm;
            aktifForm.BringToFront(); // formu öne getiriyoruz
            aktifForm.Show();
            lblTitle.Text = aktifForm.Text;
        }

        private void btnAktif(object btnSender)
        {
            if (btnSender != null)
            {
                if (seciliButton != (Button)btnSender)
                {
                    btnKapali();
                    seciliButton = (Button)btnSender;
                    Color color = pnlTitle.BackColor;
                    seciliButton.BackColor = color;
                    seciliButton.ForeColor = Color.White;
                    seciliButton.Font = new System.Drawing.Font("Monotype Corsiva", 22.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    pnlTitle.BackColor = color;
                    pnlLogo.BackColor = TemaRenk.RenkDonusturme(color, -0.3);
                }
            }
        }
        private void btnKapali()
        {
            foreach (Control control in pnlListWindow.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.FromArgb(51, 51, 56);
                    control.ForeColor = Color.Gainsboro;
                    control.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHakkinda(), sender);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmProfil(),sender);
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAyarlar(), sender);
        }

        private void btnAnaEkran_Click(object sender, EventArgs e)
        {
            OpenForm(new FirmaSahibi.Homepage(), sender);
        }

        private void btnPrsnlAyarlari_Click(object sender, EventArgs e)
        {
            OpenForm(new FirmaSahibi.FrmPersonelIslemleri(), sender);
        }

        private void btnBayi_Click(object sender, EventArgs e)
        {
            OpenForm(new FirmaSahibi.FrmBayi(),sender);
        }

        private void btnMudur_Click(object sender, EventArgs e)
        {
            OpenForm(new FirmaSahibi.FrmMudur(), sender);
        }
    }
}
