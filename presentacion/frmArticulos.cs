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
using FontAwesome.Sharp;

namespace presentacion
{
    public partial class Articulos : Form
    {
        private List<Articulo> listaArticulos;
      
        public Articulos()
        {
            InitializeComponent();
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxProducto.Load(imagen);
            }
            catch (Exception)
            {

                pbxProducto.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;


        }


        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            comboBusqueda.Enabled = false;
            comboBusqueda.Items.Add("Precio mayor a");
            comboBusqueda.Items.Add("Precio menor a");
            comboBusqueda.Items.Add("Precio igual a");
            comboBusqueda.SelectedIndex = 0;
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";
        }



        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
                tbxInformacion.Text = "Nombre: " + seleccionado.Nombre + "\r\n" + "Descripcion: " + seleccionado.Descripcion + "\r\n" + "Precio: " + "$" + seleccionado.Precio.ToString("0.00") + "\r\n" + "Categoria: " + seleccionado.Categoria + "\r\n" + "Marca: " + seleccionado.Marca;

                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();

        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;


                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            cargar();
        }





        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = tbxBuscar.Text;


            if (comboBusqueda.Enabled == false)
            {


                if (filtro.Length >= 3)
                {

                    listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                }
                else
                {
                    listaFiltrada = listaArticulos;

                }



                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                ocultarColumnas();
            }
            else
            {


                if (comboBusqueda.SelectedItem.ToString() == "Precio mayor a")
                {
                    if (filtro == "")
                    {
                        listaFiltrada = listaArticulos;

                    }
                    else

                        listaFiltrada = listaArticulos.FindAll(y => y.Precio > decimal.Parse(filtro));
                }
                else if (comboBusqueda.SelectedItem.ToString() == "Precio menor a")
                {
                    if (filtro == "")
                    {
                        listaFiltrada = listaArticulos;
                    }
                    else
                        listaFiltrada = listaArticulos.FindAll(y => y.Precio < decimal.Parse(filtro));
                }
                else if (comboBusqueda.SelectedItem.ToString() == "Precio igual a")

                {
                    if (filtro == "")
                    {
                        listaFiltrada = listaArticulos;
                    }
                    else
                        listaFiltrada = listaArticulos.FindAll(y => y.Precio == decimal.Parse(filtro));
                }
                else if (comboBusqueda.SelectedItem.ToString() == "")
                {
                    listaFiltrada = listaArticulos;
                }
                else
                    listaFiltrada = listaArticulos;


                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
                ocultarColumnas();

            }
        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBusqueda.Enabled = true;

            }
            else
            {
                comboBusqueda.Enabled = false;
                comboBusqueda.Text = "";
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Esta seguro de eliminar este articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (checkBox1.Checked)
            {
                Validacion.soloNumeros(e);
            }
            else
                Validacion.soloLetras(e);

        }

     

       
    }
}
