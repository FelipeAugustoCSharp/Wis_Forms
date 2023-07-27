using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WisGalery.UserControls;

namespace WisGalery
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home();
            AddUserControl(uc);
        }

        //USER CONTROLS
        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        //BUTTONS ACTION
        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            AddUserControl(uc);
        }

        private void btnFeed_Click_1(object sender, EventArgs e)
        {
            UC_Feed uc = new UC_Feed();
            AddUserControl(uc);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            UC_About uc = new UC_About();
            AddUserControl(uc);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            UC_LoginTela login = new UC_LoginTela();
            AddUserControl(login);
        }

        private void Theme_Click(object sender, EventArgs e)
        {
            if(Theme.Checked == true)
            {
                BackColor = Color.Red;
            }
            else
            {
                BackColor = Color.DarkBlue;
            }
        }
    }
}
