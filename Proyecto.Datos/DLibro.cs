using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Proyecto.Entidades;


namespace Proyecto.Datos
{
    public class DLibro
    {
        public DataTable Listar()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_listar", SqlCon);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }

        public DataTable ListarDisponibles()
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_listar_estado_true", SqlCon);
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

        }

        public DataTable Buscar(string Valor)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_buscar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public String Existe(int IdLibro)
        {
      
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.Int).Value = IdLibro;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                ParExiste.SqlDbType = SqlDbType.Int;
                ParExiste.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public String Insertar(Libro Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@isbm", SqlDbType.VarChar).Value = Obj.ISBM;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.Titulo;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.Autor;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.Editorial;
                Comando.Parameters.Add("@anioEdicion", SqlDbType.VarChar).Value = Obj.AnioEdicion;
                Comando.Parameters.Add("@numeroEdicion", SqlDbType.VarChar).Value = Obj.NumeroEdicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.Pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.Idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.Materia;
                Comando.Parameters.Add("@numeroPaginas", SqlDbType.VarChar).Value = Obj.NumeroPaginas;
                Comando.Parameters.Add("@UbicacionEstante", SqlDbType.VarChar).Value = Obj.UbicacionEstante;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo ingresar el libro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Actualizar(Libro Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdLibro", SqlDbType.Int).Value = Obj.IdLibro;
                Comando.Parameters.Add("@isbm", SqlDbType.VarChar).Value = Obj.ISBM;
                Comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = Obj.Titulo;
                Comando.Parameters.Add("@autor", SqlDbType.VarChar).Value = Obj.Autor;
                Comando.Parameters.Add("@editorial", SqlDbType.VarChar).Value = Obj.Editorial;
                Comando.Parameters.Add("@anioEdicion", SqlDbType.VarChar).Value = Obj.AnioEdicion;
                Comando.Parameters.Add("@numeroEdicion", SqlDbType.VarChar).Value = Obj.NumeroEdicion;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = Obj.Pais;
                Comando.Parameters.Add("@idioma", SqlDbType.VarChar).Value = Obj.Idioma;
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = Obj.Materia;
                Comando.Parameters.Add("@numeroPaginas", SqlDbType.VarChar).Value = Obj.NumeroPaginas;
                Comando.Parameters.Add("@UbicacionEstante", SqlDbType.VarChar).Value = Obj.UbicacionEstante;
                Comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = Obj.Descripcion;
                //Aca va a tronar en dado caso
                Comando.Parameters.Add("@estado", SqlDbType.Bit).Value = Obj.estado;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Eliminar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idlibro", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Activar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_activar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdLibro", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo activar el libro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        
        public string Desactivar(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("libro_desactivar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@IdLibro", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo Desactivar el registro";

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

    }
}
