using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leal_Camila
{
    internal class Producto
    {
        private int id;
        private string descripcion;
        private float costo;
        private float precioVenta;
        private int stock;
        private int idUsuario;

        //Contructores
        public Producto ()
        {
            this.id = 0;
            this.descripcion = string.Empty;
            this.costo = 0;
            this.precioVenta = 0;
            this.stock = 0;
            this.idUsuario = 0;
        }

        public Producto(int id, string descripcion, float costo,
                       float precioVenta, int stock, int idUsuario)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;

        }
    }
}
