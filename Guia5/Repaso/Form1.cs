using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso
{
    public partial class Form1 : Form
    {
        Presupuesto pedido;
        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (pedido != null)
            {
                string[] lista = pedido.Resumen();
                FormVer fVer = new FormVer();
                fVer.lbxVer.Items.AddRange(lista);
                fVer.ShowDialog();
                pedido = null;
            }
            else
            {
                MessageBox.Show("Cree un presupuesto");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem != null)
            {
                int codigo = Convert.ToInt32(cmbProducto.SelectedItem);
                pedido.QuitarProducto(codigo);

                cmbProducto.Items.Remove(cmbProducto.SelectedItem);
                cmbProducto.Text = "";
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;
            pedido = new Presupuesto(nombre, direccion);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            double precioBase = Convert.ToInt32(tbPrecioB.Text);
            double largo = Convert.ToInt32(tbLargo.Text);
            int codigo = Convert.ToInt32(tbCodigo.Text);
            Producto unProducto = null;
            if (rBBanco.Checked)
            {
                unProducto = new Banco(precioBase, largo);
                unProducto.Codigo = codigo;
            }
            else if (rBMesa.Checked)
            {
                double ancho = Convert.ToInt32(tbAncho.Text);
                double grosor = Convert.ToInt32(tbGrosor.Text);

                unProducto = new Mesa(precioBase, largo, ancho, grosor);
                unProducto.Codigo = codigo;
            }
            if (pedido != null)
            {
                if (unProducto != null)
                {
                    pedido.AgregarProducto(unProducto);
                    cmbProducto.Items.Add(codigo);

                }
                else
                {
                    MessageBox.Show("Seleccione un tipo");
                }
            }
            else { MessageBox.Show("Cree un presupuesto"); }

        }
    }   
}
