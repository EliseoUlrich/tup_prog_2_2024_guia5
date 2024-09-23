namespace Repaso
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gBCliente = new System.Windows.Forms.GroupBox();
            this.gBProductos = new System.Windows.Forms.GroupBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbPrecioB = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGrosor = new System.Windows.Forms.TextBox();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rBMesa = new System.Windows.Forms.RadioButton();
            this.rBBanco = new System.Windows.Forms.RadioButton();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.gBCliente.SuspendLayout();
            this.gBProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBCliente
            // 
            this.gBCliente.Controls.Add(this.cmbProducto);
            this.gBCliente.Controls.Add(this.label2);
            this.gBCliente.Controls.Add(this.label1);
            this.gBCliente.Controls.Add(this.btnBorrar);
            this.gBCliente.Controls.Add(this.btnCerrar);
            this.gBCliente.Controls.Add(this.btnIniciar);
            this.gBCliente.Controls.Add(this.tbDireccion);
            this.gBCliente.Controls.Add(this.tbNombre);
            this.gBCliente.Location = new System.Drawing.Point(74, 55);
            this.gBCliente.Name = "gBCliente";
            this.gBCliente.Size = new System.Drawing.Size(263, 203);
            this.gBCliente.TabIndex = 0;
            this.gBCliente.TabStop = false;
            this.gBCliente.Text = "Cliente";
            // 
            // gBProductos
            // 
            this.gBProductos.Controls.Add(this.rBBanco);
            this.gBProductos.Controls.Add(this.rBMesa);
            this.gBProductos.Controls.Add(this.btnImportar);
            this.gBProductos.Controls.Add(this.label7);
            this.gBProductos.Controls.Add(this.label6);
            this.gBProductos.Controls.Add(this.tbLargo);
            this.gBProductos.Controls.Add(this.tbGrosor);
            this.gBProductos.Controls.Add(this.label3);
            this.gBProductos.Controls.Add(this.label4);
            this.gBProductos.Controls.Add(this.label5);
            this.gBProductos.Controls.Add(this.btnAgregar);
            this.gBProductos.Controls.Add(this.btnExportar);
            this.gBProductos.Controls.Add(this.tbPrecioB);
            this.gBProductos.Controls.Add(this.tbAncho);
            this.gBProductos.Controls.Add(this.tbCodigo);
            this.gBProductos.Location = new System.Drawing.Point(343, 55);
            this.gBProductos.Name = "gBProductos";
            this.gBProductos.Size = new System.Drawing.Size(287, 203);
            this.gBProductos.TabIndex = 1;
            this.gBProductos.TabStop = false;
            this.gBProductos.Text = "Productos";
            this.gBProductos.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(68, 33);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(166, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(68, 68);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(166, 20);
            this.tbDireccion.TabIndex = 1;
            this.tbDireccion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(59, 94);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(60, 20);
            this.tbCodigo.TabIndex = 1;
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(59, 68);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(60, 20);
            this.tbAncho.TabIndex = 2;
            // 
            // tbPrecioB
            // 
            this.tbPrecioB.Location = new System.Drawing.Point(59, 43);
            this.tbPrecioB.Name = "tbPrecioB";
            this.tbPrecioB.Size = new System.Drawing.Size(60, 20);
            this.tbPrecioB.TabIndex = 3;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(31, 106);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 35);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar Presupuesto";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(151, 107);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 34);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar Presupuesto";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(165, 166);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(149, 106);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 25);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(191, 150);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(90, 36);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(95, 150);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(88, 36);
            this.btnImportar.TabIndex = 7;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ancho:";
            // 
            // tbGrosor
            // 
            this.tbGrosor.Location = new System.Drawing.Point(206, 68);
            this.tbGrosor.Name = "tbGrosor";
            this.tbGrosor.Size = new System.Drawing.Size(60, 20);
            this.tbGrosor.TabIndex = 9;
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(206, 42);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(60, 20);
            this.tbLargo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Grosor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Largo:";
            // 
            // rBMesa
            // 
            this.rBMesa.AutoSize = true;
            this.rBMesa.Location = new System.Drawing.Point(33, 127);
            this.rBMesa.Name = "rBMesa";
            this.rBMesa.Size = new System.Drawing.Size(51, 17);
            this.rBMesa.TabIndex = 13;
            this.rBMesa.TabStop = true;
            this.rBMesa.Text = "Mesa";
            this.rBMesa.UseVisualStyleBackColor = true;
            // 
            // rBBanco
            // 
            this.rBBanco.AutoSize = true;
            this.rBBanco.Location = new System.Drawing.Point(33, 150);
            this.rBBanco.Name = "rBBanco";
            this.rBBanco.Size = new System.Drawing.Size(56, 17);
            this.rBBanco.TabIndex = 14;
            this.rBBanco.TabStop = true;
            this.rBBanco.Text = "Banco";
            this.rBBanco.UseVisualStyleBackColor = true;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(38, 168);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 312);
            this.Controls.Add(this.gBProductos);
            this.Controls.Add(this.gBCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBCliente.ResumeLayout(false);
            this.gBCliente.PerformLayout();
            this.gBProductos.ResumeLayout(false);
            this.gBProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBCliente;
        private System.Windows.Forms.GroupBox gBProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLargo;
        private System.Windows.Forms.TextBox tbGrosor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox tbPrecioB;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.RadioButton rBBanco;
        private System.Windows.Forms.RadioButton rBMesa;
        private System.Windows.Forms.ComboBox cmbProducto;
    }
}

