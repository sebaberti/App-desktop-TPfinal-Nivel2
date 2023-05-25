using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
    
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
     
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                     articulo = new Articulo();
         
                articulo.Codigo = tbxCodArt.Text;
                articulo.Nombre = tbxNombre.Text;    
                articulo.Descripcion = tbxDescripcion.Text;
                articulo.ImagenUrl = tbxImagen.Text;
                articulo.Categoria = (Categoria)comboCategoria.SelectedItem;
                articulo.Marca = (Marca)comboMarca.SelectedItem;
                articulo.Precio = decimal.Parse(tbxPrecio.Text);


                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Modificado Exitosamente");

                    }else {
                   
                    negocio.agregar(articulo);
             
                    MessageBox.Show("Agregado exitosamente");
                    }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)

        {
            CategoriaNegocio articuloNegocio = new CategoriaNegocio();
            MarcaNegocio artNegocio = new MarcaNegocio();
            btnAceptar.Enabled = false;

            try
            {
                comboCategoria.DataSource = articuloNegocio.listar();
                comboCategoria.ValueMember = "Id";
                comboCategoria.DisplayMember = "Descripcion";
                comboMarca.DataSource = artNegocio.listar();
                comboMarca.ValueMember = "Id";
                comboMarca.DisplayMember = "Descripcion";



                if(articulo != null)
                {
                    
                    tbxCodArt.Text = articulo.Codigo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    tbxImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    tbxPrecio.Text = articulo.Precio.ToString();
                    comboCategoria.SelectedValue = articulo.Categoria.Id;
                    comboMarca.SelectedValue = articulo.Marca.Id;

                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


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

        private void tbxImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(tbxImagen.Text);

        }

      private void validarCampo()
        {
                var vr = !string.IsNullOrEmpty(tbxCodArt.Text)&&
                !string.IsNullOrEmpty(tbxPrecio.Text)&&
                !string.IsNullOrEmpty(tbxNombre.Text);
                btnAceptar.Enabled = vr;
        }

     
        private void tbxCodArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();
            
        }

        private void tbxPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();
            Validacion.soloNumeros((KeyPressEventArgs)e);
        }

        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validarCampo();
            Validacion.soloLetras((KeyPressEventArgs)e);
        }
    }
}
