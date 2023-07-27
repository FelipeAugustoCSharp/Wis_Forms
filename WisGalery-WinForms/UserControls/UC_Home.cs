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
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
            rb0.Checked = true;
            txbMy.Enabled = false ;
        }

        private void rb0_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = imagensHome.Images[0];
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = imagensHome.Images[1];
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = imagensHome.Images[2];
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = imagensHome.Images[3];
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = imagensHome.Images[4];
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = imagensHome.Images[5];
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = imagensHome.Images[6];
        }

        private void rb7_CheckedChanged(object sender, EventArgs e)
        {
            picBox.Image = imagensHome.Images[7];
        }

        private void btnEnviarMensagem_Click(object sender, EventArgs e)
        {     
            if (textoMensagem.Text.Trim() == "") return;
            else 
            { 
            myAvatarMessage.Visible = true;
            txbMy.Visible = true;
            txbMy.ForeColor = Color.Black;
            txbMy.Text = textoMensagem.Text;
            friendAvatar.Location = new Point(492,265);
            friendAvatar2.Location = new Point(491, 209);
            txbFriend1.Location = new Point(541, 284);
            txbFriend2.Location = new Point(541, 229);
            }
        }

        private void textoMensagem_TextChanged(object sender, EventArgs e)
        {
            textoMensagem.MaxLength = 24;

        }






        //private void rb1_checkedchanged_1(object sender, eventargs e)
        //{
        //    picturebox1.image = imagelist1.images[0];
        //}

    }
}
