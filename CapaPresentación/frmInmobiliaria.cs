using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentación
{
    public partial class frmInmobiliaria : Form
    {
        private InmobiliariaCLN objInmobiliariaCLN;
        private DataTable miTabla;
        private int idCuit;
        private int indice;
        public frmInmobiliaria()
        {
            objInmobiliariaCLN = new InmobiliariaCLN();
            miTabla = new DataTable();
            indice = 0;
            InitializeComponent();
        }

        private void frmInmobiliaria_Load(object sender, EventArgs e)
        {
            MostrarInmobiliarias();
        }

        private void MostrarInmobiliarias()
        {
            objInmobiliariaCLN = new InmobiliariaCLN();
            dgvInmobiliaria.DataSource = objInmobiliariaCLN.consultarInmobiliariasCN();

        }

        private void btnAgregarI_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Está seguro que quiere agregar una nueva sucursal?", "Nueva sucursal", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                idCuit = Convert.ToInt32(txtIdCuit.Text);
                try
                {
                    objInmobiliariaCLN.InsertarInmobiliariasCN(idCuit, txtRazonSocial.Text, txtDomicilio.Text, txtTelefono.Text, txtEmail.Text);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Hubo un error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpiarTextBoxs();
                }
            }
            else
            {
                MessageBox.Show("Carga de propiedades cancelada");
                LimpiarTextBoxs();
            }
            MostrarInmobiliarias();
        }

        //FUNCIÓN PARA LIMPIAR LOS CAMPOS
        private void LimpiarTextBoxs()
        {
            txtIdCuit.Clear();
            txtRazonSocial.Clear();
            txtDomicilio.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
        }

        private void btnLimpiarI_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxs();
        }

        //CLICK EN LAS CELDAS para traer lo que hay en los campos a los textboxs
        private void dgvInmobiliaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            txtIdCuit.Text = dgvInmobiliaria.CurrentRow.Cells["idCuit"].Value.ToString();
            txtRazonSocial.Text = dgvInmobiliaria.CurrentRow.Cells["razonSocial"].Value.ToString();
            txtDomicilio.Text = dgvInmobiliaria.CurrentRow.Cells["domicilioP"].Value.ToString();
            txtTelefono.Text = dgvInmobiliaria.CurrentRow.Cells["telefono"].Value.ToString();
            txtEmail.Text = dgvInmobiliaria.CurrentRow.Cells["email"].Value.ToString();
            //Validación por si se selecciona mal una fila
            if (indice == -1)
            {
                MessageBox.Show("Seleccione un fila válida");
            }
            else
            {
                if (dgvInmobiliaria.Rows[indice].Cells[0].Value == null)
                {
                    MessageBox.Show("Error, haga bien el click");
                }
            }
        }
        //MODIFICAR
        private void btnModificarI_Click(object sender, EventArgs e)
        {
            if (dgvInmobiliaria.SelectedRows.Count > 0)
            {

 
                idCuit = Convert.ToInt32(txtIdCuit.Text);
                objInmobiliariaCLN.modificarInmobiliariasCN(Convert.ToInt32(dgvInmobiliaria.Rows[indice].Cells[0].Value), txtRazonSocial.Text, txtDomicilio.Text, txtTelefono.Text, txtEmail.Text);
                MessageBox.Show("Los cambios se modificaron correctamente");
            }
            else
            {
                MessageBox.Show("Seleccione una fila a modificar");
            }
            LimpiarTextBoxs();
            MostrarInmobiliarias();
        }

        //ELIMINAR
        private void btnEliminarI_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea eliminar una sucursal?", "Eliminar sucursal", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                objInmobiliariaCLN.eliminarInmobiliariasCN(Convert.ToInt32(dgvInmobiliaria.Rows[indice].Cells[0].Value));
                MessageBox.Show("Sucursal eliminada con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarTextBoxs();
            }
            else
            {
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            MostrarInmobiliarias();
        }
    }
}
