using System;
using System.Collections.Generic;

using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

//Librerias necesarias nuevas
using System.Data;
using System.Data.SqlClient; // Cliente SQL Server

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.

    //http://localhost:63818/Service1.svc
    public class Service1 : IService1
    {
        SqlConnection cn = new SqlConnection("Server=DESKTOP-5I4L21C\\SVR1; database=FanNote; integrated security = sspi");

        public Usuario Loginusuario(Usuario obj)
        {
            Usuario lista = new Usuario();

            SqlCommand cmd = new SqlCommand("SP_LOGINuser", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = obj.codusuario;
            cmd.Parameters.Add("@CONTRASEÑA", SqlDbType.VarChar).Value = obj.password;
            cn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    lista.idusuario = (int.Parse(reader["idusuario"].ToString()));
                    lista.username = (reader["username"].ToString());
                    //Console.WriteLine(reader["username"].ToString());
                    lista.email = (reader["email"].ToString());
                    lista.imagen = (reader["imagen"].ToString());
                    lista.tipo = (reader["tipo"].ToString());
                    lista.estado = (int.Parse(reader["estado"].ToString()));
                    lista.password = (reader["password"].ToString());
                    return lista;
                }

            }
            else
            {

                Console.WriteLine("mp hay datos");


            }
            return lista;
        }
        //------------------------------------------CREACION------------------------------------------//
        public void CrearPost(Post obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_registrarpostsadmin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@idpost", SqlDbType.Int).Value = obj.idpost;
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idusuario;
            cmd.Parameters.Add("@contenido", SqlDbType.VarChar).Value = obj.contenido;
            cmd.Parameters.Add("@fotopost", SqlDbType.VarChar).Value = obj.fotopost;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void CrearEvento(Evento obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_registrareventos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@idevento", SqlDbType.Int).Value = obj.idusuario;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cmd.Parameters.Add("@promotor", SqlDbType.VarChar).Value = obj.promotor;
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = obj.fecha;
            cmd.Parameters.Add("@lugar", SqlDbType.VarChar).Value = obj.lugar;
            cmd.Parameters.Add("@plataforma", SqlDbType.VarChar).Value = obj.plataforma;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void CrearAdmin(Usuario obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_registraradmin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idusuario;
            cmd.Parameters.Add("@codusuario", SqlDbType.VarChar).Value = obj.codusuario;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = obj.username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
            cmd.Parameters.Add("@imagen", SqlDbType.VarChar).Value = obj.imagen;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = obj.tipo;
            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = obj.estado;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void CrearArtistas(Artista obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_registrarartistas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@idartista", SqlDbType.Int).Value = obj.idartista;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cmd.Parameters.Add("@agencia", SqlDbType.Int).Value = obj.agencia;
            cmd.Parameters.Add("@debut", SqlDbType.DateTime).Value = obj.debut;
            cmd.Parameters.Add("@fotoartista", SqlDbType.VarChar).Value = obj.fotoartista;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void CrearFandom(Fandom obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_registrarfandom", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@idfandom", SqlDbType.Int).Value = obj.idfandom;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cmd.Parameters.Add("@creacion", SqlDbType.DateTime).Value = obj.creacion;
            cmd.Parameters.Add("@miembros", SqlDbType.Int).Value = obj.miembros;
            cmd.Parameters.Add("@idartista", SqlDbType.Int).Value = obj.idartista;
            cmd.Parameters.Add("@fotofandom", SqlDbType.VarChar).Value = obj.fotofandom;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void CrearAgencia(Agencia obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_registraragencia", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = obj.idagencia;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = obj.direccion;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = obj.telefono;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
            cmd.Parameters.Add("@web", SqlDbType.VarChar).Value = obj.web;
            cmd.Parameters.Add("@fotoagencia", SqlDbType.VarChar).Value = obj.fotoagencia;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        //------------------------------------------EDICION------------------------------------------//
        public void EditarArtistas(Artista obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_editarartistas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idartista", SqlDbType.Int).Value = obj.idartista;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cmd.Parameters.Add("@agencia", SqlDbType.Int).Value = obj.agencia;
            cmd.Parameters.Add("@debut", SqlDbType.DateTime).Value = obj.debut;
            cmd.Parameters.Add("@fotoartista", SqlDbType.VarChar).Value = obj.fotoartista;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EditarEvento(Evento obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_editareventos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idevento", SqlDbType.Int).Value = obj.idevento;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cmd.Parameters.Add("@promotor", SqlDbType.VarChar).Value = obj.promotor;
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = obj.fecha;
            cmd.Parameters.Add("@lugar", SqlDbType.VarChar).Value = obj.lugar;
            cmd.Parameters.Add("@plataforma", SqlDbType.VarChar).Value = obj.plataforma;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EditarFandom(Fandom obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_editarfandom", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idfandom", SqlDbType.Int).Value = obj.idfandom;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cmd.Parameters.Add("@creacion", SqlDbType.DateTime).Value = obj.creacion;
            cmd.Parameters.Add("@miembros", SqlDbType.Int).Value = obj.miembros;
            cmd.Parameters.Add("@idartista", SqlDbType.Int).Value = obj.idartista;
            cmd.Parameters.Add("@fotofandom", SqlDbType.VarChar).Value = obj.fotofandom;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EditarAgencia(Agencia obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_editaragencia", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = obj.idagencia;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = obj.direccion;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = obj.telefono;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
            cmd.Parameters.Add("@web", SqlDbType.VarChar).Value = obj.web;
            cmd.Parameters.Add("@fotoagencia", SqlDbType.VarChar).Value = obj.fotoagencia;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EditarPost(Post obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_editarpostsadmin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idpost", SqlDbType.Int).Value = obj.idpost;
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idusuario;
            cmd.Parameters.Add("@contenido", SqlDbType.VarChar).Value = obj.contenido;
            cmd.Parameters.Add("@fotopost", SqlDbType.VarChar).Value = obj.fotopost;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EditarAdmin(Usuario obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_editaradmin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idusuario;
            cmd.Parameters.Add("@codusuario", SqlDbType.VarChar).Value = obj.codusuario;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = obj.username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = obj.password;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.email;
            cmd.Parameters.Add("@imagen", SqlDbType.VarChar).Value = obj.imagen;
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = obj.tipo;
            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = obj.estado;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        //---RECURSOS---
        public void EditarROficial(ROficial obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITARrecursosoficiales", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id1", SqlDbType.Int).Value = obj.id1;
            cmd.Parameters.Add("@evento", SqlDbType.Int).Value = obj.evento;
            cmd.Parameters.Add("@linkoficial", SqlDbType.VarChar).Value = obj.linkoficial;
            cmd.Parameters.Add("@fotosoficial", SqlDbType.VarChar).Value = obj.fotosoficial;
            cmd.Parameters.Add("@weboficial", SqlDbType.VarChar).Value = obj.weboficial;
            cmd.Parameters.Add("@archivoficial", SqlDbType.VarChar).Value = obj.archivoficial;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EditarROArtista(ROArtista obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITARrecursosxartista", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id2", SqlDbType.Int).Value = obj.id2;
            cmd.Parameters.Add("@evento", SqlDbType.Int).Value = obj.evento;
            cmd.Parameters.Add("@artista", SqlDbType.Int).Value = obj.artista;
            cmd.Parameters.Add("@fandom", SqlDbType.Int).Value = obj.fandom;
            cmd.Parameters.Add("@linkoficial", SqlDbType.VarChar).Value = obj.linkoficial;
            cmd.Parameters.Add("@fotosoficial", SqlDbType.VarChar).Value = obj.fotosoficial;
            cmd.Parameters.Add("@archivoficial", SqlDbType.VarChar).Value = obj.archivoficial;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EditarLinkstream(Linkstream obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITARlinkstream", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = obj.nro;
            cmd.Parameters.Add("@id2", SqlDbType.Int).Value = obj.id2;
            cmd.Parameters.Add("@servidor", SqlDbType.VarChar).Value = obj.servidor;
            cmd.Parameters.Add("@link", SqlDbType.VarChar).Value = obj.link;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EditarSubsworld(Subsworld obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITARsubsworld", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = obj.nro;
            cmd.Parameters.Add("@id2", SqlDbType.Int).Value = obj.id2;
            cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = obj.iduser;
            cmd.Parameters.Add("@idioma", SqlDbType.VarChar).Value = obj.idioma;
            cmd.Parameters.Add("@link", SqlDbType.VarChar).Value = obj.link;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EditarPrensa(Prensa obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITARprensa", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = obj.nro;
            cmd.Parameters.Add("@id2", SqlDbType.Int).Value = obj.id2;
            cmd.Parameters.Add("@entidad", SqlDbType.VarChar).Value = obj.entidad;
            cmd.Parameters.Add("@links", SqlDbType.VarChar).Value = obj.links;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        public void EditarFotosfan(Fotosfan obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITARfotosfan", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = obj.nro;
            cmd.Parameters.Add("@id2", SqlDbType.Int).Value = obj.id2;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj.descripcion;
            cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = obj.iduser;
            cmd.Parameters.Add("@link", SqlDbType.VarChar).Value = obj.link;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        public void EditarFotoscut(Fotoscut obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_EDITARfotoscut", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = obj.nro;
            cmd.Parameters.Add("@id2", SqlDbType.Int).Value = obj.id2;
            cmd.Parameters.Add("@iduser", SqlDbType.Int).Value = obj.iduser;
            cmd.Parameters.Add("@link", SqlDbType.VarChar).Value = obj.link;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        //------------------------------------------ELIMINAR------------------------------------------//

        public void EliminarArtistas(Artista obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_eliminarartistasxid", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idartista", SqlDbType.Int).Value = obj.idartista;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        public void EliminarEvento(Evento obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_eliminareventos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idevento", SqlDbType.Int).Value = obj.idevento;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        public void EliminarFandom(Fandom obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_eliminarfandomxid", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idfandom", SqlDbType.Int).Value = obj.idfandom;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EliminarAgencia(Agencia obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_eliminaragencia", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idagencia", SqlDbType.Int).Value = obj.idagencia;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EliminarPost(Post obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_eliminarpostsadmin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idpost", SqlDbType.Int).Value = obj.idpost;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EliminarAdmin(Usuario obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_eliminaradmin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idusuario;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        //---RECURSOS---
        public void EliminarROficial(ROficial obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_Eliminarrecursosoficiales", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id1", SqlDbType.Int).Value = obj.id1;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EliminarROArtista(ROArtista obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_Eliminarrecursosxartista", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@id2", SqlDbType.Int).Value = obj.id2;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EliminarLinkstream(Linkstream obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_Eliminarlinkstream", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = obj.nro;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EliminarSubsworld(Subsworld obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_Eliminarsubsworld", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = obj.nro;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

            }

        }
        public void EliminarPrensa(Prensa obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_Eliminarprensa", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = obj.nro;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        public void EliminarFotosfan(Fotosfan obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_Eliminarfotosfan", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = obj.nro;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        public void EliminarFotoscut(Fotoscut obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_Eliminarfotoscut", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nro", SqlDbType.Int).Value = obj.nro;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        public void EliminarFan(Fan obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_eliminarfan", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idfan;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }
        public void DeshabilitarFan(Fan obj)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("SP_deshabilitaradmin", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idfan;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
        }

        //------------------------------------------LISTADOS------------------------------------------//

        public DataSet ListarArtista()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarartistas", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "artistas");
            return ds;
        }
        public DataSet ListarEvento()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listareventos", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "eventos");
            return ds;
        }
        public DataSet ListarFandom()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarfandom", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "fandoms");
            return ds;
        }
        public DataSet ListarAgencia()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listaragencia", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "agencias");
            return ds;
        }
        public DataSet ListarPost()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarpostsadmin", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "posts");
            return ds;
        }
        public DataSet ListarAdmin()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listaradmins", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "admins");
            return ds;
        }
        //---RECURSOS---
        public DataSet ListarROficial()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarrecursosoficiales", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "roficials");
            return ds;
        }
        public DataSet ListarROArtista()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarrecursosxartista", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "roartistas");
            return ds;
        }
        public DataSet ListarLinkstream()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarlinkstream", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "linkstreams");
            return ds;
        }
        public DataSet ListarSubworld()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarsubsworld", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "subworlds");
            return ds;
        }
        public DataSet ListarPrensa()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarprensa", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "prensas");
            return ds;
        }
        public DataSet ListarFotofan()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarfotosfan", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "fotosfan");
            return ds;
        }
        public DataSet ListarFotoCut()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarfotoscut", cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "fotoscut");
            return ds;
        }


        //------------------------------------------BUSQUEDAS------------------------------------------//

        public DataSet BuscarFan(Fan obj)
        {
            SqlCommand cmd = new SqlCommand("SP_listarfans ", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idfan;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "fansb");
            return ds;
        }
        public DataSet BuscarArtista(Artista obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarartistas", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "artistasb");
            return ds;
        }
        public DataSet BuscarEventoxfecha(DateTime inicio, DateTime fin)
        {
            SqlCommand cmd = new SqlCommand("SP_buscareventosxfecha ", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@inicio", SqlDbType.DateTime).Value = inicio;
            cmd.Parameters.Add("@fin", SqlDbType.DateTime).Value = fin;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "eventosb1");
            return ds;
        }
        public DataSet BuscarEventoxnombre(Evento obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscareventosxnombre", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "eventosb2");
            return ds;
        }
        public DataSet BuscarFandom(Fandom obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarfandom  ", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "fandomb");
            return ds;
        }
        public DataSet BuscarAgencia(Agencia obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscaragencia", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.nombre;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "agenciab");
            return ds;
        }
        public DataSet BuscarPost(Post obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarpostsadmin  ", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idusuario", SqlDbType.Int).Value = obj.idusuario;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "postb");
            return ds;
        }
        public DataSet BuscarAdmin(Usuario obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscaradmins", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = obj.username;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "adminsb");
            return ds;
        }
        //--buscar recursos
        public DataSet BuscarROficial(ROficial obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarrecursosoficiales", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idevento", SqlDbType.Int).Value = obj.evento;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "roficialb");
            return ds;
        }
        public DataSet BuscarROArtista(ROArtista obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarrecursosxartista", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idevento", SqlDbType.Int).Value = obj.evento;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "roaartistasb");
            return ds;
        }
        public DataSet BuscarLinkstream(Linkstream obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarlinkstream", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idrecurso2", SqlDbType.Int).Value = obj.id2;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "linkstreamb");
            return ds;
        }
        public DataSet BuscarSubsworld(Subsworld obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarsubsworld", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idrecurso2", SqlDbType.Int).Value = obj.id2;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "subworldb");
            return ds;
        }
        public DataSet BuscarPrensa(Prensa obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarprensa", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idrecurso2", SqlDbType.Int).Value = obj.id2;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "subworldb");
            return ds;
        }
        public DataSet BuscarFotosfan(Fotosfan obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarfotosfan", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idrecurso2", SqlDbType.Int).Value = obj.id2;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "subworldb");
            return ds;
        }
        public DataSet BuscarSFotoscut(Fotoscut obj)
        {
            SqlCommand cmd = new SqlCommand("SP_buscarfotoscut", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idrecurso2", SqlDbType.Int).Value = obj.id2;
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "subworldb");
            return ds;
        }

        //-----------------------------------------------------
        public DataTable CboAgencia()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listaragencia", cn);
            DataTable dt = new DataTable("agencia");
            da.Fill(dt);
            return dt;
        }
        public DataTable CboArtista()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_listarartistas", cn);
            DataTable dt = new DataTable("artista");
            da.Fill(dt);
            return dt;
        }
    }
}
