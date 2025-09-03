namespace prl.AybarRcompras
{
    public partial class frmRcompras : Form


    {
        public frmRcompras()
        {
            InitializeComponent();

            
        }
        DateTime vFecha;
        String vProducto;
        int vCantidad;
        int vPrecioUnitario;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstProducto.Text != "")
            {
                nudCantidad.Enabled = true;
            }
            else
                nudCantidad.Enabled = false;



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            vFecha = dtmFecha.Value;
            vProducto = lstProducto.SelectedItem;
            vCantidad = Convert.ToInt32 (nudCantidad.Value);
            vPrecioUnitario = Convert.ToInt32(mskPrecio.Enabled);
        }
    }
}
