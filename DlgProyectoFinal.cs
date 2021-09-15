using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    //---------------------------------------------------------------------
    //Diálogo principal del proyecto final.
    //NJSA. 08/09/2021.
    //---------------------------------------------------------------------
    public partial class DlgProyectoFinal : Form
    {
        //---------------------------------------------------------------------
        //Atributos.
        //---------------------------------------------------------------------

        //---------------------------------------------------------------------
        //Constructor.
        //---------------------------------------------------------------------
        public DlgProyectoFinal()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        //Limpia los campos de datos.
        //---------------------------------------------------------------------
        private void TsbNuevo_Click(object sender, System.EventArgs e)
        {
            TbxCodigo.Text = "";
            TbxNombre.Text = "";
            TbxApellidoP.Text = "";
            TbxApellidoM.Text = "";
            TbxTelefonoMovil.Text = "";
            TbxCorreo.Text = "";
            TbxFechaNacimiento.Text = "";
            TbxLugarProcedencia.Text = "";
            CbxEstadoCivil.SelectedIndex = -1;
        }

        //---------------------------------------------------------------------
        //Guarda los campos de datos en la base de datos.
        //---------------------------------------------------------------------
        private void TsbGuardar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Registro Guardado.");
        }

        //---------------------------------------------------------------------
        //Cierra la aplicación.
        //---------------------------------------------------------------------
        private void TsbCerrar_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        //---------------------------------------------------------------------
        //Eliminar un registro.
        //---------------------------------------------------------------------
        private void TsbEliminar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Registro eliminado.");
            TsbNuevo_Click(sender, e);
        }
    }
}
