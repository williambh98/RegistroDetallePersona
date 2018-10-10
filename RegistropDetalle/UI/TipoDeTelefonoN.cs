using RegistropDetalle.BLL;
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
    public partial class TipoDeTelefonoN : Form
    {
        public TipoDeTelefonoN()
        {
            InitializeComponent();
        }

        private TipoDeTelefono LlenarClase()
        {
            TipoDeTelefono t = new TipoDeTelefono();
            t.ID = Convert.ToInt32(IDnumericUpDown.Value);
            t.Tipo = TiptextBox.Text;

            return t;
        }

        private void LlenarCampo(TipoDeTelefono t)
        {
            IDnumericUpDown.Value = t.ID;
            TiptextBox.Text = t.Tipo;
        }


        private bool ValidarGuardar()
        {
            bool paso = false;
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(TiptextBox.Text))
            {
                errorProvider.SetError(TiptextBox, "Llenar Campo");
                paso = false;
            }
            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            TipoDeTelefono t;
            if (!ValidarGuardar())
                return;
            t = LlenarClase();

            if (IDnumericUpDown.Value == 0)
                paso = TipoTPBLL.Guardar(t);

            if (paso)

                MessageBox.Show("Guardado ", "exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else

                MessageBox.Show("No Guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
