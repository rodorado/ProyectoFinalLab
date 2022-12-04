using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentación
{
    public partial class frmPropiedades : Form
    {
        private PropiedadesCLN objPropiedadesCN;
        private int idCuit;
        private int idEsp;
        private double Precio;
        private DateTime Antiguedad;
        private int indice;
        private DataTable miTabla;
        private frmEspecificaciones frmEsp;
        public frmPropiedades()
        {
            objPropiedadesCN = new PropiedadesCLN();
            indice = 0;
            miTabla = new DataTable();
            frmEsp = new frmEspecificaciones();
            InitializeComponent();
        }

        private void frmPropiedades_Load(object sender, EventArgs e)
        {
            MostrarPropiedades();
           
        }

        private void MostrarPropiedades()
        {
            objPropiedadesCN = new PropiedadesCLN(); // supuestamente limpia el data grid view
            dgvPropiedades.DataSource = objPropiedadesCN.consultarPropiedadesCN();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int indiceUltimaFIla = objPropiedadesCN.getIndiceUltFila(dgvPropiedades.Rows.Count); //obtengo el ultimo indice de el data grid view
            int codigoPropiedad = objPropiedadesCN.getCodigoPropiedad(dgvPropiedades.Rows[indiceUltimaFIla].Cells[0].Value);
            DialogResult opcion = MessageBox.Show("¿Está seguro que quiere agregar un nueva propiedad?", "Nueva propiedad", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                Precio = Convert.ToInt32(txtPrecio.Text);
                idCuit = Convert.ToInt32(txtCuit.Text);
                idEsp = Convert.ToInt32(txtEsp.Text);
                Antiguedad = Convert.ToDateTime(txtAntiguedad.Text);
                try
                {
                    objPropiedadesCN.insertarPropiedadesCN(codigoPropiedad, Precio, txtDomicilioP.Text, Antiguedad, txtTipo.Text, idEsp, idCuit);
                }
                catch (Exception ex)
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
            MostrarPropiedades();
        }

       //FUNCIÓN PARA LIMPIAR LOS CAMPOS
        private void LimpiarTextBoxs()
        {
            txtAntiguedad.Clear();
            txtPrecio.Clear();
            txtDomicilioP.Clear();
            txtTipo.Clear();
            txtCuit.Clear();
            txtEsp.Clear();
        }
        //BOTÓN LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxs();
        }

        //INTENTO FALLIDO DEL CELL CLICK
        private void dgvPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //HACER CLICK EN LAS CELDAS PARA PASAR LOS PÁRAMETROS DE LA TABLA A LOS TEXBOX
        private void dgvPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            txtPrecio.Text = dgvPropiedades.CurrentRow.Cells["precio"].Value.ToString();
            txtDomicilioP.Text = dgvPropiedades.CurrentRow.Cells["domicilioP"].Value.ToString();
            txtAntiguedad.Text = dgvPropiedades.CurrentRow.Cells["antiguedad"].Value.ToString();
            txtTipo.Text = dgvPropiedades.CurrentRow.Cells["tipo"].Value.ToString();
            txtEsp.Text = dgvPropiedades.CurrentRow.Cells["idEsp"].Value.ToString();
            txtCuit.Text = dgvPropiedades.CurrentRow.Cells["idCuit"].Value.ToString();
            //Validación por si se selecciona mal una fila
            if (indice == -1)
            {
                MessageBox.Show("Seleccione un fila válida");
            }
            else
            {
                if (dgvPropiedades.Rows[indice].Cells[0].Value == null)
                {
                    MessageBox.Show("Error, haga bien el click");
                }
            }
        }
        //MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {  
            if(dgvPropiedades.SelectedRows.Count > 0)
            {
               
                Precio = Convert.ToInt32(txtPrecio.Text);
                idCuit = Convert.ToInt32(txtCuit.Text);
                idEsp = Convert.ToInt32(txtEsp.Text);
                Antiguedad = Convert.ToDateTime(txtAntiguedad.Text);
                objPropiedadesCN.modificarPropiedadesCN(Convert.ToInt32(dgvPropiedades.Rows[indice].Cells[0].Value), Precio, txtDomicilioP.Text, Antiguedad, txtTipo.Text, idEsp, idCuit);
                MessageBox.Show("Los cambios se modificaron correctamente");
            }
            else
            {
                MessageBox.Show("Seleccione una fila a modificar");
            }
            LimpiarTextBoxs();
            MostrarPropiedades();
        }
        //ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show("¿Desea eliminar la propiedad?", "Eliminar producto", MessageBoxButtons.YesNo);
            if (opcion == DialogResult.Yes)
            {
                objPropiedadesCN.eliminarPropiedadesCN(Convert.ToInt32(dgvPropiedades.Rows[indice].Cells[0].Value));
                MessageBox.Show("Propiedad eliminada con éxito", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarTextBoxs();
            }
            else
            {
                MessageBox.Show("Operación cancelada", "Cancelar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            MostrarPropiedades();
        }
        //BOTON PARA AGREGAR UNA ESPECIFICACIÓN
        private void btnEspecificaciones_Click(object sender, EventArgs e)
        {
            try
            {
                frmEsp.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
