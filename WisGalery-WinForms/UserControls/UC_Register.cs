using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WisGalery.UserControls
{
    public partial class UC_Register : UserControl
    {
        public UC_Register()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelLogin.Controls.Clear();
            panelLogin.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UC_Login login = new UC_Login();
            AddUserControl(login);
        }
    }
}
