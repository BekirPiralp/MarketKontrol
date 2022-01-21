using System;
using System.Drawing;
using System.Windows.Forms;
using Market.MarketKontrol.ayarlar;
using Market.MarketKontrol.Ortak;

namespace Market.MarketKontrol.Personel
{
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
            random = new Random();
            //varsayılan olarak buton satış açık olacak
            btnSatis_Click(btnSatis,new MouseEventArgs(MouseButtons.Left,1,0,0,0));
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
            FormTasi.mouseMove(e,this);
        }

        private Button seciliButton;
        private Random random;
        private int tempIndex;
        private Form aktifForm;

        private Color RenkSec()
        {
            int index = random.Next(TemaRenk.RenklerList.Count);
            while(tempIndex == index)
            {
                index=random.Next(TemaRenk.RenklerList.Count);
            }
            tempIndex = index;
            string color = TemaRenk.RenklerList[index];
            return ColorTranslator.FromHtml(color);
        }

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
            if(btnSender != null)
            {
                if(seciliButton != (Button)btnSender)
                {
                    btnKapali();
                    seciliButton = (Button)btnSender;
                    Color color = RenkSec();
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
                if(control.GetType() == typeof(Button))
                {
                    control.BackColor = Color.FromArgb(51, 51, 56);
                    control.ForeColor = Color.Gainsboro;
                    control.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmSatis(), sender);
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmUrun(), sender);
        }

        private void btnDefoIade_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmIade(), sender);
        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmProfil(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAyarlar(), sender);
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmHakkinda(), sender);
        }

        private void btnDefo_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmDefo(), sender);
        }
    }
}
