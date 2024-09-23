using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repaso
{
    public class Presupuesto
    {
        private Cliente solicitante;
        public double Precio
        {
            get
            {
                double total = 0;
                foreach (Producto p in listaProducto)
                {
                    total += p.Precio();
                }
                return total;
            }
        }
        ArrayList listaProducto = new ArrayList();
        public Presupuesto(string nombre, string direccion)
        {
            solicitante = new Cliente(nombre, direccion);
        }
        public void AgregarProducto(Producto producto)
        { 
            listaProducto.Add(producto);
        }

        public Producto BuscarProducto(int codigo)
        {
            int inf = 0, sup = listaProducto.Count - 1;
            int centro = (sup + inf) / 2;
            while (inf <= sup)
            {
                Producto p = listaProducto[centro] as Producto;
                if (p == null) return null;
                if (p.Codigo == codigo) return p;
                else if (codigo < p.Codigo)
                {
                    sup = centro - 1;
                }
                else inf = centro + 1;
                centro = (sup + inf) / 2;
            }
            return null;
        
        }
        public bool QuitarProducto(int codigo)
        {
            listaProducto.Sort();
            Producto buscado = BuscarProducto(codigo);
            if (buscado != null)
            { 
                listaProducto.Remove(buscado);
                return true;
            
            }
            return false;
        }
        public string[] Resumen()
        {
            string[] result = new string[listaProducto.Count+2];
            int n = 0;
            result[n++]=solicitante.ToString();
            foreach (Producto p in listaProducto)
            {
                result[n++] = $"{p.Codigo} -Peso{p.Peso()} - Precio:${p.Precio():f2}";
            }
            result[n++] = $"Total: ${Precio:f2}";
            return result;
        
        }




    }
}
