namespace presentacion
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCodifgoArt = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.tbxCodArt = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.tbxImagen = new System.Windows.Forms.TextBox();
            this.tbxPrecio = new System.Windows.Forms.TextBox();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblrequerido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodifgoArt
            // 
            this.lblCodifgoArt.AutoSize = true;
            this.lblCodifgoArt.Location = new System.Drawing.Point(97, 15);
            this.lblCodifgoArt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodifgoArt.Name = "lblCodifgoArt";
            this.lblCodifgoArt.Size = new System.Drawing.Size(92, 16);
            this.lblCodifgoArt.TabIndex = 0;
            this.lblCodifgoArt.Text = "Codigo Articulo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(97, 50);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(97, 87);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblImagen
            // 
            this.lblImagen.AutoSize = true;
            this.lblImagen.Location = new System.Drawing.Point(97, 130);
            this.lblImagen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(68, 16);
            this.lblImagen.TabIndex = 3;
            this.lblImagen.Text = "Url Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(97, 171);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio: ";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(97, 217);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(68, 16);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoria: ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(97, 261);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(44, 16);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca";
            // 
            // tbxCodArt
            // 
            this.errorProvider1.SetIconAlignment(this.tbxCodArt, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.tbxCodArt.Location = new System.Drawing.Point(198, 11);
            this.tbxCodArt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxCodArt.Name = "tbxCodArt";
            this.tbxCodArt.Size = new System.Drawing.Size(116, 21);
            this.tbxCodArt.TabIndex = 7;
            this.tbxCodArt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCodArt_KeyPress);
            // 
            // tbxNombre
            // 
            this.errorProvider1.SetIconAlignment(this.tbxNombre, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.tbxNombre.Location = new System.Drawing.Point(198, 47);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(116, 21);
            this.tbxNombre.TabIndex = 8;
            this.tbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombre_KeyPress);
            // 
            // tbxDescripcion
            // 
            this.errorProvider1.SetIconAlignment(this.tbxDescripcion, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.tbxDescripcion.Location = new System.Drawing.Point(198, 84);
            this.tbxDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(116, 21);
            this.tbxDescripcion.TabIndex = 9;
            // 
            // tbxImagen
            // 
            this.errorProvider1.SetIconAlignment(this.tbxImagen, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.tbxImagen.Location = new System.Drawing.Point(198, 122);
            this.tbxImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxImagen.Name = "tbxImagen";
            this.tbxImagen.Size = new System.Drawing.Size(116, 21);
            this.tbxImagen.TabIndex = 10;
            this.tbxImagen.Leave += new System.EventHandler(this.tbxImagen_Leave);
            // 
            // tbxPrecio
            // 
            this.errorProvider1.SetIconAlignment(this.tbxPrecio, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.tbxPrecio.Location = new System.Drawing.Point(198, 162);
            this.tbxPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxPrecio.Name = "tbxPrecio";
            this.tbxPrecio.Size = new System.Drawing.Size(116, 21);
            this.tbxPrecio.TabIndex = 11;
            this.tbxPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecio_KeyPress);
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.comboCategoria, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.comboCategoria.Location = new System.Drawing.Point(198, 207);
            this.comboCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(116, 24);
            this.comboCategoria.TabIndex = 12;
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.comboMarca, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.comboMarca.Location = new System.Drawing.Point(198, 251);
            this.comboMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(116, 24);
            this.comboMarca.TabIndex = 13;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Location = new System.Drawing.Point(119, 309);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(85, 37);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(227, 309);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 37);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(108, 374);
            this.pbxProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(226, 145);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 16;
            this.pbxProducto.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblrequerido
            // 
            this.lblrequerido.AutoSize = true;
            this.errorProvider1.SetIconAlignment(this.lblrequerido, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.lblrequerido.Location = new System.Drawing.Point(322, 11);
            this.lblrequerido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrequerido.Name = "lblrequerido";
            this.lblrequerido.Size = new System.Drawing.Size(13, 16);
            this.lblrequerido.TabIndex = 17;
            this.lblrequerido.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.errorProvider1.SetIconAlignment(this.label1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label1.Location = new System.Drawing.Point(322, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.errorProvider1.SetIconAlignment(this.label2, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.label2.Location = new System.Drawing.Point(322, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "*";
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(433, 554);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblrequerido);
            this.Controls.Add(this.pbxProducto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.comboCategoria);
            this.Controls.Add(this.tbxPrecio);
            this.Controls.Add(this.tbxImagen);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.tbxCodArt);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodifgoArt);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodifgoArt;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox tbxCodArt;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.TextBox tbxImagen;
        private System.Windows.Forms.TextBox tbxPrecio;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblrequerido;
    }
}