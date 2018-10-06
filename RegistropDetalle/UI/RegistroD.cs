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
    public partial class RegistroD : Form
    {
        public List<TelefonosDetalle> Detalle { get; set; }
        public RegistroD()
        {
            InitializeComponent();
            this.Detalle = new List<TelefonosDetalle>();
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;
        }
        private void Limpiar()
        {
            errorProvider.Clear();

            IDnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            CedulamaskedTextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;

            this.Detalle = new List<TelefonosDetalle>();
            CargarGrid();
        }
        private void Nuevo_Click(object sender, EventArgs e)
           {
              Limpiar();
           }


        private PersonaDetalle LlenarClase()
        {
            PersonaDetalle persona = new PersonaDetalle();
            persona.PersonaId = Convert.ToInt32(IDnumericUpDown.Value);
            persona.Nombre = NombretextBox.Text;
            persona.Cedula = CedulamaskedTextBox.Text;
            persona.Direccion = DirecciontextBox.Text;
            persona.FechaNacimiento = FechadateTimePicker.Value;

            persona.Telefonos = this.Detalle;

            return persona;
        }

        private void LlenarCampos(PersonaDetalle persona)
        {
            IDnumericUpDown.Value = persona.PersonaId;
            NombretextBox.Text = persona.Nombre;
            CedulamaskedTextBox.Text = persona.Cedula;
            DirecciontextBox.Text = persona.Direccion;
            FechadateTimePicker.Value = persona.FechaNacimiento;

            this.Detalle = persona.Telefonos;
            CargarGrid();
        }

        private bool Validar()
        {
            bool paso = true;

            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, " LLenar Campo");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(DirecciontextBox.Text))
            {
                errorProvider.SetError(DirecciontextBox, "Llenar Campo");
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text))
            {
                errorProvider.SetError(CedulamaskedTextBox, "Llenar campo");
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(CedulamaskedTextBox.Text.Replace("_", ""))) { }

            if(this.Detalle.Count == 0)
            {
                errorProvider.SetError(DetalledataGridView, " Debe agregar algun telefono");
                TelefonomaskedTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<TelefonosDetalle>)DetalledataGridView.DataSource;
            //Todo: Validar Campos del detalle
            //Agregar un nuevo detalle con los datosintroducidos

            this.Detalle.Add(
                new TelefonosDetalle(
                  Id:  0,
                  PersonaId: (int)IDnumericUpDown.Value,
                  Telefono: TelefonomaskedTextBox.Text,
                  TipoTelefono: TipocomboBox.Text

                    )
                    );
            CargarGrid();
            TelefonomaskedTextBox.Focus();
            TelefonomaskedTextBox.Clear();
      
        }

        private void Filabutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
               CargarGrid();
            }
        }

       private bool ExisteEnLaBaseDeDatos()
        {
            PersonaDetalle persona = PersonaDetalleBLL.Buscar((int)IDnumericUpDown.Value);
            return (persona != null);
        }
    
        private void Buscar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            PersonaDetalle personas = new PersonaDetalle();
            int.TryParse(IDnumericUpDown.Text, out id);
            personas = PersonaDetalleBLL.Buscar(id);

            if (personas != null)
            {
                MessageBox.Show("Encontrado");
                LlenarCampos(personas);
            }
            else
            {
                MessageBox.Show("No se encontro");
                Limpiar();
            }

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            PersonaDetalle persona;
            bool paso = false;
            if (!Validar())
                return;

            persona = LlenarClase();
            if (IDnumericUpDown.Value == 0)
                paso = PersonaDetalleBLL.Guardar(persona);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un campo que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = PersonaDetalleBLL.Modificar(persona);
            }
            if (paso)
            {
                MessageBox.Show("Guardado con exito");
                Limpiar();
            }
            else
                MessageBox.Show("No se Guardo");
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);
            if (!ExisteEnLaBaseDeDatos())
            {
                MessageBox.Show("No se Encuentra en la base de datos");
                return;
            }
            if(PersonaDetalleBLL.Eliminar(id))
            {
                MessageBox.Show("Se elimino exitosamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
        }
    }
}
