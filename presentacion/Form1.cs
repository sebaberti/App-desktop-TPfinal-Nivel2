using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using dominio;
using negocio;
using FontAwesome.Sharp;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace presentacion
{
    public partial class frmPresentacion : Form

    {
        private Form activeForm;
        private IconButton currentBtn;
        
        
        public frmPresentacion()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
           
        }

        private void BotonActivo(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DesactivarBoton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(22,11,22);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void DesactivarBoton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(11, 7, 17);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
       
        private void OpenChildForm(Form childForm, object btnSender)
        {
          
           if(activeForm != null)
            {
               activeForm.Close();
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelPadre.Controls.Add(childForm);
            this.panelPadre.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTittle.Text = childForm.Text;
            activeForm = childForm;
        }

       

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Tomato);
            OpenChildForm(new Articulos(), sender);
           

        }
        private void btnMarcas_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Tomato);
            OpenChildForm(new Marcas(), sender);
        }
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            BotonActivo(sender, Color.Tomato);
            OpenChildForm(new Categorias(), sender);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frmPresentacion_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset(); 
        }
        private void Reset()
        { 
            DesactivarBoton();
            lblTittle.Text = "GESTOR DE ARTICULOS";
        }

       
    }
    }

