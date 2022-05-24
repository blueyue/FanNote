using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

using System.Data; //nueva

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {


        // TODO: agregue aquí sus operaciones de servicio
        [OperationContract] Usuario Loginusuario(Usuario obj);
        [OperationContract] void CrearPost(Post obj);
        [OperationContract] void CrearEvento(Evento obj);
        [OperationContract] void CrearAdmin(Usuario obj);
        [OperationContract] void CrearArtistas(Artista obj);
        [OperationContract] void CrearFandom(Fandom obj);
        [OperationContract] void CrearAgencia(Agencia obj);
        [OperationContract] void EditarArtistas(Artista obj);
        [OperationContract] void EditarEvento(Evento obj);
        [OperationContract] void EditarFandom(Fandom obj);
        [OperationContract] void EditarAgencia(Agencia obj);
        [OperationContract] void EditarPost(Post obj);
        [OperationContract] void EditarAdmin(Usuario obj);
        [OperationContract] void EditarROficial(ROficial obj);
        [OperationContract] void EditarROArtista(ROArtista obj);
        [OperationContract] void EditarLinkstream(Linkstream obj);
        [OperationContract] void EditarSubsworld(Subsworld obj);
        [OperationContract] void EditarPrensa(Prensa obj);
        [OperationContract] void EditarFotosfan(Fotosfan obj);
        [OperationContract] void EditarFotoscut(Fotoscut obj);
        [OperationContract] void EliminarArtistas(Artista obj);
        [OperationContract] void EliminarEvento(Evento obj);
        [OperationContract] void EliminarFandom(Fandom obj);
        [OperationContract] void EliminarAgencia(Agencia obj);
        [OperationContract] void EliminarPost(Post obj);
        [OperationContract] void EliminarAdmin(Usuario obj);
        [OperationContract] void EliminarROficial(ROficial obj);
        [OperationContract] void EliminarROArtista(ROArtista obj);
        [OperationContract] void EliminarLinkstream(Linkstream obj);
        [OperationContract] void EliminarSubsworld(Subsworld obj);
        [OperationContract] void EliminarPrensa(Prensa obj);
        [OperationContract] void EliminarFotosfan(Fotosfan obj);
        [OperationContract] void EliminarFotoscut(Fotoscut obj);
        [OperationContract] void EliminarFan(Fan obj);
        [OperationContract] DataSet ListarArtista();
        [OperationContract] DataSet ListarEvento();
        [OperationContract] DataSet ListarFandom();
        [OperationContract] DataSet ListarAgencia();
        [OperationContract] DataSet ListarPost();
        [OperationContract] DataSet ListarAdmin();
        [OperationContract] DataSet ListarROficial();
        [OperationContract] DataSet ListarROArtista();
        [OperationContract] DataSet ListarLinkstream();
        [OperationContract] DataSet ListarSubworld();
        [OperationContract] DataSet ListarPrensa();
        [OperationContract] DataSet ListarFotofan();
        [OperationContract] DataSet ListarFotoCut();
        [OperationContract] DataSet BuscarFan(Fan obj);
        [OperationContract] DataSet BuscarArtista(Artista obj);
        [OperationContract] DataSet BuscarEventoxfecha(DateTime inicio, DateTime fin);
        [OperationContract] DataSet BuscarFandom(Fandom obj);
        [OperationContract] DataSet BuscarAgencia(Agencia obj);
        [OperationContract] DataSet BuscarPost(Post obj);
        [OperationContract] DataSet BuscarAdmin(Usuario obj);
        [OperationContract] DataSet BuscarROficial(ROficial obj);
        [OperationContract] DataSet BuscarROArtista(ROArtista obj);
        [OperationContract] DataSet BuscarLinkstream(Linkstream obj);
        [OperationContract] DataSet BuscarSubsworld(Subsworld obj);
        [OperationContract] DataSet BuscarPrensa(Prensa obj);
        [OperationContract] DataSet BuscarFotosfan(Fotosfan obj);
        [OperationContract] DataSet BuscarSFotoscut(Fotoscut obj);
        [OperationContract] DataTable CboAgencia();
        [OperationContract] DataTable CboArtista();
        [OperationContract] DataSet BuscarEventoxnombre(Evento obj);
        [OperationContract] void DeshabilitarFan(Fan obj);
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class Usuario
    {
        private int _idusuario;
        private string _codusuario;
        private string _username;
        private string _password;
        private string _email;
        private string _imagen;
        private string _tipo;
        private int _estado;

        [DataMember]
        public int idusuario
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }
        [DataMember]
        public string codusuario
        {
            get { return _codusuario; }
            set { _codusuario = value; }
        }
        
        [DataMember]
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        [DataMember]
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }
        [DataMember]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        [DataMember]
        public string imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }

        [DataMember]
        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        [DataMember]
        public int estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }

    [DataContract]
    public class Post
    {
        private int _idusuario;
        private string _contenido;
        private string _fotopost;
        private int _idpost;

        [DataMember]
        public int idpost
        {
            get { return _idpost; }
            set { _idpost = value; }
        }
        [DataMember]
        public int idusuario
        {
            get { return _idusuario; }
            set { _idusuario = value; }
        }
        [DataMember]
        public string contenido
        {
            get { return _contenido; }
            set { _contenido = value; }
        }

        [DataMember]
        public string fotopost
        {
            get { return _fotopost; }
            set { _fotopost = value; }
        }
    }
    [DataContract]
    public class Evento
    {
        private int _idevento;
        private string _nombre;
        private string _promotor;
        private DateTime _fecha;//date
        private string _lugar;
        private string _plataforma;

        [DataMember]
        public int idevento
        {
            get { return _idevento; }
            set { _idevento = value; }
        }
        [DataMember]
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [DataMember]
        public string promotor
        {
            get { return _promotor; }
            set { _promotor = value; }
        }
        [DataMember]
        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        [DataMember]
        public string lugar
        {
            get { return _lugar; }
            set { _lugar = value; }
        }
        [DataMember]
        public string plataforma
        {
            get { return _plataforma; }
            set { _plataforma = value; }
        }
    }
    [DataContract]
    public class Artista
    {
        private int _idartista;
        private string _nombre;
        private int _agencia;
        private DateTime _debut;
        private string _fotoartista;

        [DataMember]
        public int idartista
        {
            get { return _idartista; }
            set { _idartista = value; }
        }
        [DataMember]
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [DataMember]
        public int agencia
        {
            get { return _agencia; }
            set { _agencia = value; }
        }
        [DataMember]
        public DateTime debut
        {
            get { return _debut; }
            set { _debut = value; }
        }
        [DataMember]
        public string fotoartista
        {
            get { return _fotoartista; }
            set { _fotoartista = value; }
        }
    }
    [DataContract]
    public class Fandom
    {
        private int _idfandom;
        private string _nombre;
        private DateTime _creacion;
        private int _miembros;//bigint
        private int _idartista;
        private string _fotofandom;

        [DataMember]
        public int idfandom
        {
            get { return _idfandom; }
            set { _idfandom = value; }
        }
        [DataMember]
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [DataMember]
        public DateTime creacion
        {
            get { return _creacion; }
            set { _creacion = value; }
        }
        [DataMember]
        public int miembros
        {
            get { return _miembros; }
            set { _miembros = value; }
        }
        [DataMember]
        public int idartista
        {
            get { return _idartista; }
            set { _idartista = value; }
        }
        [DataMember]
        public string fotofandom
        {
            get { return _fotofandom; }
            set { _fotofandom = value; }
        }
    }
    [DataContract]
    public class Agencia
    {
        private int _idagencia;
        private string _nombre;
        private string _direccion;
        private int _telefono;//bigint
        private string _email;
        private string _web;
        private string _fotoagencia;

        [DataMember]
        public int idagencia
        {
            get { return _idagencia; }
            set { _idagencia = value; }
        }
        [DataMember]
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [DataMember]
        public string direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        [DataMember]
        public int telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        [DataMember]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }
        [DataMember]
        public string web
        {
            get { return _web; }
            set { _web = value; }
        }
        [DataMember]
        public string fotoagencia
        {
            get { return _fotoagencia; }
            set { _fotoagencia = value; }
        }
    }
    [DataContract]
    public class ROficial
    {
        private int _id1;
        private int _evento;
        private string _linkoficial;
        private string _fotosoficial;
        private string _weboficial;
        private string _archivoficial;

        [DataMember]
        public int id1
        {
            get { return _id1; }
            set { _id1 = value; }
        }
        [DataMember]
        public int evento
        {
            get { return _evento; }
            set { _evento = value; }
        }

        [DataMember]
        public string linkoficial
        {
            get { return _linkoficial; }
            set { _linkoficial = value; }
        }
        [DataMember]
        public string fotosoficial
        {
            get { return _fotosoficial; }
            set { _fotosoficial = value; }
        }
        [DataMember]
        public string weboficial
        {
            get { return _weboficial; }
            set { _weboficial = value; }
        }
        [DataMember]
        public string archivoficial
        {
            get { return _archivoficial; }
            set { _archivoficial = value; }
        }
    }
    [DataContract]
    public class ROArtista
    {
        private int _id2;
        private int _evento;
        private int _artista;
        private int _fandom;
        private string _linkoficial;
        private string _fotosoficial;
        private string _archivoficial;

        [DataMember]
        public int id2
        {
            get { return _id2; }
            set { _id2 = value; }
        }
        [DataMember]
        public int evento
        {
            get { return _evento; }
            set { _evento = value; }
        }

        [DataMember]
        public int artista
        {
            get { return _artista; }
            set { _artista = value; }
        }
        [DataMember]
        public int fandom
        {
            get { return _fandom; }
            set { _fandom = value; }
        }
        [DataMember]
        public string linkoficial
        {
            get { return _linkoficial; }
            set { _linkoficial = value; }
        }
        [DataMember]
        public string fotosoficial
        {
            get { return _fotosoficial; }
            set { _fotosoficial = value; }
        }
        [DataMember]
        public string archivoficial
        {
            get { return _archivoficial; }
            set { _archivoficial = value; }
        }
    }

    [DataContract]
    public class Linkstream
    {
        private int _nro;
        private int _id2;
        private string _servidor;
        private string _link;

        [DataMember]
        public int nro
        {
            get { return _nro; }
            set { _nro = value; }
        }
        [DataMember]
        public int id2
        {
            get { return _id2; }
            set { _id2 = value; }
        }

        [DataMember]
        public string servidor
        {
            get { return _servidor; }
            set { _servidor = value; }
        }
        [DataMember]
        public string link
        {
            get { return _link; }
            set { _link = value; }
        }
    }

    [DataContract]
    public class Subsworld
    {
        private int _nro;
        private int _id2;
        private int _iduser;
        private string _idioma;
        private string _link;

        [DataMember]
        public int nro
        {
            get { return _nro; }
            set { _nro = value; }
        }
        [DataMember]
        public int id2
        {
            get { return _id2; }
            set { _id2 = value; }
        }

        [DataMember]
        public int iduser
        {
            get { return _iduser; }
            set { _iduser = value; }
        }
        [DataMember]
        public string idioma
        {
            get { return _idioma; }
            set { _idioma = value; }
        }
        public string link
        {
            get { return _link; }
            set { _link = value; }
        }
    }

    [DataContract]
    public class Prensa
    {
        private int _nro;
        private int _id2;
        private string _entidad;
        private string _links;

        [DataMember]
        public int nro
        {
            get { return _nro; }
            set { _nro = value; }
        }
        [DataMember]
        public int id2
        {
            get { return _id2; }
            set { _id2 = value; }
        }

        [DataMember]
        public string entidad
        {
            get { return _entidad; }
            set { _entidad = value; }
        }
        [DataMember]
        public string links
        {
            get { return _links; }
            set { _links = value; }
        }
    }
    [DataContract]
    public class Fotosfan
    {
        private int _nro;
        private int _id2;
        private string _descripcion;
        private int _iduser;
        private string _link;

        [DataMember]
        public int nro
        {
            get { return _nro; }
            set { _nro = value; }
        }
        [DataMember]
        public int id2
        {
            get { return _id2; }
            set { _id2 = value; }
        }

        [DataMember]
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        [DataMember]
        public int iduser
        {
            get { return _iduser; }
            set { _iduser = value; }
        }
        public string link
        {
            get { return _link; }
            set { _link = value; }
        }
    }

    [DataContract]
    public class Fotoscut
    {
        private int _nro;
        private int _id2;
        private int _iduser;
        private string _link;

        [DataMember]
        public int nro
        {
            get { return _nro; }
            set { _nro = value; }
        }
        [DataMember]
        public int id2
        {
            get { return _id2; }
            set { _id2 = value; }
        }

        [DataMember]
        public int iduser
        {
            get { return _iduser; }
            set { _iduser = value; }
        }
        [DataMember]
        public string link
        {
            get { return _link; }
            set { _link = value; }
        }
    }
    [DataContract]
    public class Fan
    {
        private int _idfan;
        private int _idfandom;
        private int _direccion;
        private string _telefono;

        [DataMember]
        public int idfan
        {
            get { return _idfan; }
            set { _idfan = value; }
        }
        [DataMember]
        public int idfandom
        {
            get { return _idfandom; }
            set { _idfandom = value; }
        }

        [DataMember]
        public int direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        [DataMember]
        public string telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
    }
}


