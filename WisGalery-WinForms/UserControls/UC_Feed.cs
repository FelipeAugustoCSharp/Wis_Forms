using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WisGalery.FeedContent;

namespace WisGalery.UserControls
{
    public partial class UC_Feed : UserControl
    {
        public UC_Feed()
        {
            InitializeComponent();
        }

        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userPostit.Controls.Clear();
            userPostit.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void postit1_Click(object sender, EventArgs e)
        {
            LerPostit LerPostit = new LerPostit();
            AddUserControl(LerPostit);
        }

        private void postitMore_Click(object sender, EventArgs e)
        {
            Postit postit = new Postit();
            AddUserControl(postit);
        }
    }
}
