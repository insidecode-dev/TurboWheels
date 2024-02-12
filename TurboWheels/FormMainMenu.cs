using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboWheels.Dal;

namespace LoadMaster
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private readonly ApplicationDbContext _db;

        public FormMainMenu(ApplicationDbContext db)
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            _db = db;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //private Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColor.ColorList.Count);
        //    while (tempIndex == index)
        //    {
        //        index = random.Next(ThemeColor.ColorList.Count);
        //    }
        //    tempIndex = index;
        //    string color = ThemeColor.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}


        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    //Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.Black;
                    currentButton.Font = new Font("Comic Sans MS", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    panelTitleBar.BackColor = Color.Black;
                    panelLogo.BackColor = Color.Gray;//ThemeColor.ChangeColorBrightness(color, -0.3);
                    //ThemeColor.PrimaryColor = color;
                    //ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(104, 0, 213);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);

                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            //
            this.panelDesktopPanel.Dock = DockStyle.Fill;
            childForm.Anchor = AnchorStyles.None;
            childForm.Dock = DockStyle.Fill;
            //            
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }





        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(123, 0, 123);
            panelLogo.BackColor = Color.FromArgb(73, 4, 131);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.panelDesktopPanel.Dock = DockStyle.Fill;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormCreateOrder(_db), sender);
        }
    }
}
