using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leal_Camila
{
    internal class ProductoVendido
    {
        private int id;
        private int idProductor;
        private int stock;
        private int idVenta;

        //Constructor
        public ProductoVendido()
        {
            this.id = 0;
            this.idProductor = 0;
            this.stock = 0;
            this.idVenta = 0;
        }

        public ProductoVendido(int id, int idProductor, int stock, int idVenta)
        {
            this.id = id;
            this.idProductor = idProductor;
            this.stock = stock;
            this.idVenta = idVenta;
        }

    }
}
