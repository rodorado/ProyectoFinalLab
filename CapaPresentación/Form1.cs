using CapaNegocio;


namespace CapaPresentación

{
    public partial class Form1 : Form
    {
        frmPropiedades frmProp;
        public Form1()
        {
            frmProp = new frmPropiedades();
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
    }
}