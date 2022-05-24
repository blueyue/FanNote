using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente_Vistas
{
    public class UsuarioCliente
    {
        private int _idusuario;
        private string _codusuario;
        private string _username;
        private string _password;
        private string _email;
        private string _imagen;
        private string _tipo;
        private int _estado;
        
        public int idusuario
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }
        
        public string codusuario
        {
            get { return _codusuario; }
            set { _codusuario = value; }
        }


        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

 
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public int estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
