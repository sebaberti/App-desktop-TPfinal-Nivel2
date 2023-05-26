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
    public partial class Categorias : Form
    {
        private List<Categoria> listaCategorias;
        private Categoria cat = null;
        public Categorias()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                listaCategorias = negocio.listar();
                dgvCategorias.DataSource = listaCategorias;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Categorias_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (cat == null)
                    cat = new Categoria();

                cat.Descripcion = (string)tbxNuevaCategoria.Text;
                negocio.agregar(cat);
                MessageBox.Show("Categoria agregada exitosamente");
                cargar();
                tbxNuevaCategoria.Text = "";
            }
            catch (Exception ex)

            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionada;
            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar esta categoria?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionada.Id);
                    cargar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxNuevaCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Validacion.soloLetras((KeyPressEventArgs)e);
        }
    }
}
