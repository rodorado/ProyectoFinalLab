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
    public partial class frmEspecificaciones : Form
    {
        private EspecificacionesCLN objEspecificacionesCLN;
        private DataTable miTabla;
        private int idEsp;
        private double metros2;
        private int cantAmb;
        private int cantBaños;
        private int indice;
        public frmEspecificaciones()
        {
            objEspecificacionesCLN = new EspecificacionesCLN();
            miTabla = new DataTable();
            indice = 0;
            InitializeComponent();
        }

        private void frmEspecificaciones_Load(object sender, EventArgs e)
        {
            MostrarEsp();
        }

        //MOSTRAR ESPECIFICACIONES
        public void MostrarEsp()
        {
            objEspecificacionesCLN = new EspecificacionesCLN();
            dgvEsp.DataSource = objEspecificacionesCLN.consultarEspecificacionesCN();
        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Está seguro que quiere agregar una nueva especificación?", "Nueva Especificación", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                idEsp = Convert.ToInt32(txtIdEsp.Text);
                metros2 = Convert.ToDouble(txtMetros2.Text);
                cantAmb = Convert.ToInt32(txtAmb.Text);
                cantBaños = Convert.ToInt32(txtBaños.Text);
                try
                {
                    objEspecificacionesCLN.insertarEsp(idEsp, metros2, cantAmb, cantBaños);
                }catch(Exception ex)
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
            MostrarEsp();
        }
        //FUNCIÓN PARA LIMPIAR LOS CAMPOS DE LOS TEXTBOXS
        private void LimpiarTextBoxs()
        {
            txtIdEsp.Clear();
            txtMetros2.Clear();
            txtAmb.Clear();
            txtBaños.Clear();
        }
        //BOTON DE LIMPIAR
        private void button3_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxs();
        }

        //CLICK EN LAS CELDAS
        private void dgvEsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            txtIdEsp.Text = dgvEsp.CurrentRow.Cells["idEsp"].Value.ToString();
            txtMetros2.Text = dgvEsp.CurrentRow.Cells["metros2"].Value.ToString();
            txtAmb.Text = dgvEsp.CurrentRow.Cells["cantAmb"].Value.ToString();
            txtBaños.Text = dgvEsp.CurrentRow.Cells["cantBaños"].Value.ToString();
            //Validación por si se selecciona mal una fila
            if (indice == -1)
            {
                MessageBox.Show("Seleccione un fila válida");
            }
            else
            {
                if (dgvEsp.Rows[indice].Cells[0].Value == null)
                {
                    MessageBox.Show("Error, haga bien el click");
                }
            }
        }
        //MODIFICAR ESP
        private void btnModificarE_Click(object sender, EventArgs e)
        {
            if (dgvEsp.SelectedRows.Count > 0)
            {
                idEsp = Convert.ToInt32(txtIdEsp.Text);
                metros2 = Convert.ToDouble(txtMetros2.Text);
                cantAmb = Convert.ToInt32(txtAmb.Text);
                cantBaños = Convert.ToInt32(txtBaños.Text);
                objEspecificacionesCLN.modificarEsp(Convert.ToInt32(dgvEsp.Rows[indice].Cells[0].Value), metros2, cantAmb, cantBaños);
                MessageBox.Show("Los cambios se modificaron correctamente");
            }
            else
            {
                MessageBox.Show("Seleccione una fila a modificar");
            }
            LimpiarTextBoxs();
            MostrarEsp();
        }
        //ELIMINAR
        private void btnEliminarE_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea eliminar una especificación?", "Eliminar especificación", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                objEspecificacionesCLN.eliminarEsp(Convert.ToInt32(dgvEsp.Rows[indice].Cells[0].Value));
                MessageBox.Show("Especificación eliminada con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarTextBoxs();
            }
            else
            {
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            MostrarEsp();
        }
    }
}
