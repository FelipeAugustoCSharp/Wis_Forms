using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WisGalery.FeedContent
{
    public partial class LerPostit : UserControl
    {
        public LerPostit()
        {
            InitializeComponent();
            txbRichPostit.Enabled= false;
        }

        private void txbRichPostit_TextChanged(object sender, EventArgs e)
        {
            Postit postit = new Postit();

            txbRichPostit.Text = postit._texto;
            
        }
    }
}
