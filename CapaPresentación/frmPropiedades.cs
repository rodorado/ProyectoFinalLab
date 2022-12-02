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
        //private string idPropiedad = null;
        private int indice;
        private string precioProp;
        private DataTable miTabla;
        public frmPropiedades()
        {
            objPropiedadesCN = new PropiedadesCLN();
            indice = 0;
            precioProp = "";
            miTabla = new DataTable();
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

        private void LimpiarTextBoxs()
        {
            txtAntiguedad.Clear();
            txtPrecio.Clear();
            txtDomicilioP.Clear();
            txtTipo.Clear();
            txtCuit.Clear();
            txtEsp.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarTextBoxs();
        }

        //INTENTO FALLIDO DEL CELL CLICK
        private void dgvPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //HACER CLICK EN LAS CELDAS
        private void dgvPropiedades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            precioProp = dgvPropiedades.Rows[indice].Cells[1].Value.ToString();
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
            
            /*if(dgvPropiedades.SelectedRows.Count > 0)
            {
                txtPrecio.Text = dgvPropiedades.CurrentRow.Cells["precio"].Value.ToString();
                txtDomicilioP.Text = dgvPropiedades.CurrentRow.Cells["domicilioP"].Value.ToString();
                txtAntiguedad.Text = dgvPropiedades.CurrentRow.Cells["antiguedad"].Value.ToString();
                txtTipo.Text = dgvPropiedades.CurrentRow.Cells["tipo"].Value.ToString();
                txtEsp.Text = dgvPropiedades.CurrentRow.Cells["idEsp"].Value.ToString();
                txtCuit.Text = dgvPropiedades.CurrentRow.Cells["idCuit"].Value.ToString();
                idPropiedad = dgvPropiedades.CurrentRow.Cells["idPropiedad"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila a modificar");
            }*/
            if (txtPrecio.Text == string.Empty || txtDomicilioP.Text == string.Empty || txtAntiguedad.Text == string.Empty || txtTipo.Text == string.Empty || txtEsp.Text == string.Empty || txtCuit.Text == string.Empty)
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Precio = Convert.ToInt32(txtPrecio.Text);
                    idCuit = Convert.ToInt32(txtCuit.Text);
                    idEsp = Convert.ToInt32(txtEsp.Text);
                    Antiguedad = Convert.ToDateTime(txtAntiguedad.Text);
                    objPropiedadesCN.modificarPropiedadesCN(Convert.ToInt32(dgvPropiedades.Rows[indice].Cells[0].Value), Precio, txtDomicilioP.Text, Antiguedad, txtTipo.Text, idEsp, idCuit);
                    MessageBox.Show("Los cambios se modificaron correctamente");
                }
                catch
                {
                    MessageBox.Show("Debe ingresar los tipos de datos correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            LimpiarTextBoxs();
            //btnAgregar.Enabled = true;
            //btnEliminar.Enabled = false;
            MostrarPropiedades();
        }
    }
}
