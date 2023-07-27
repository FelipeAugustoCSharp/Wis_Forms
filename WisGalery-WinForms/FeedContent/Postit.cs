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

namespace WisGalery.FeedContent
{
    public partial class Postit : UserControl
    {
        public string _texto;
        public Postit()
        {
            InitializeComponent();
        }


        private void EnviarMensagem_Click(object sender, EventArgs e)
        {
            _texto = TextoEscrito.Text;
        }
    }
}
