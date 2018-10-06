using RegistropDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistropDetalle.UI
{
    public partial class RegistroD : Form
    {
            public List<TelefonosDetalle> Detalle { get; set; }
        public RegistroD()
        {
            InitializeComponent();
            this.Detalle = new List<TelefonosDetalle>();
        }

        private void Limpiar()
        {

        }
       
    }
}
