using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leal_Camila
{
    internal class Propiedades
    {
        private int id;
        private string comentarios;
        private int idUsuario;


        //Constructores
        public Propiedades()
        {
            this.id = 0;
            this.comentarios = string.Empty;
            this.idUsuario = 0;
        }

        public Propiedades(int id, string comentarios, int idUsuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idUsuario = idUsuario;
        }
    }
}
