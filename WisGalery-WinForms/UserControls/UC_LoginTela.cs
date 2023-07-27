using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WisGalery.UserControls
{
    public partial class UC_LoginTela : UserControl
    {
        public UC_LoginTela()
        {
            InitializeComponent();
            UC_Login login = new UC_Login();
            AddUserControl(login);
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelLogin.Controls.Clear();
            panelLogin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            UC_Register register = new UC_Register();
            AddUserControl(register);
        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            UC_Login login = new UC_Login();
            AddUserControl(login);
        }
    }
}
