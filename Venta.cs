using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leal_Camila
{
    internal class Venta
    {
        private int id;
        private string comentarios;
        private int idUsuario;


        //Constructores
        public Venta()
        {
            this.id = 0;
            this.comentarios = string.Empty;
            this.idUsuario = 0;
        }

        public Venta(int id, string comentarios, int idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }
    }
}
