using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leal_Camila
{
    internal class Usuario
    {
        private int id;
        private string nombre;
        private string apellido;
        private string nombreUsuario;
        private string contraseña;
        private string mail;

        //Constructor
        public Usuario()
        {
            this.id = 0;
            this.nombre = string.Empty;
            this.apellido = string.Empty;
            this.nombreUsuario = string.Empty;
            this.contraseña = string.Empty;
            this.mail = string.Empty;
        }

        public Usuario(int id, string nombre, string apellido,
                       string nombreUsuario, string contraseña, string mail)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nombreUsuario = nombreUsuario;
            this.contraseña = contraseña;
            this.mail = mail;

        }
    }

    
}
