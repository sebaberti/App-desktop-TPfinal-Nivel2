using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class Marcas : Form
    {

        private List<Marca> listaMarcas;
        private Marca m = null;
        public Marcas()
        {
            InitializeComponent();
        }

       


        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarcas = negocio.listar();
                dgvMarcas.DataSource = listaMarcas;
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }  
        }

        private void Marcas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (m == null)
                    m = new Marca();

               m.Descripcion = (string)tbxMarcaNueva.Text;
                negocio.agregar(m);
                MessageBox.Show("Marca agregada exitosamente");
                cargar();
                tbxMarcaNueva.Text = "";
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionada;
            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar esta marca?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionada.Id);
                    cargar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxMarcaNueva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloLetras((KeyPressEventArgs)e);
        }
    }
}
