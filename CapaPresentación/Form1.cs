using CapaNegocio;


namespace CapaPresentación

{
    /*GRUPO NÚMERO 7 (C4) UTN-FRT TEC.PROGRAMACIÓN LABORATORIO II 2022
     
     INMOBILIARIA CRUD COMPLETO EN 3 TABLAS: PROPIEDAD, INMOBILIARIA(SUCURSALES) Y ESPECIFICACIONES.
     
    - CUBA TIMO, IGNACIO 55964
    - DORADO, ROCÍO 55579
    - GONZALEZ, JOAQUIN 55714
     */
    public partial class Form1 : Form
    {
        frmPropiedades frmProp;
        frmInmobiliaria frmInmo;
        public Form1()
        {
            frmProp = new frmPropiedades();
            frmInmo = new frmInmobiliaria();
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnPropiedades_Click(object sender, EventArgs e)
        {
            try
            {
                frmProp.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            try
            {
                frmInmo.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}