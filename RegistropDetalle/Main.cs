using RegistropDetalle.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistropDetalle
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void registrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroD rg = new RegistroD();
            rg.MdiParent = this;
            rg.Show();
        }
    }
}
