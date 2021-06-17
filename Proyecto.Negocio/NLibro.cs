using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Proyecto.Datos;
using Proyecto.Entidades;

namespace Proyecto.Negocio
{
    public class NLibro
    {
        public static DataTable Listar()
        {
            DLibro Datos = new DLibro();
            return Datos.Listar();
        }

        public static DataTable ListarDisponible()
        {
            DLibro Datos = new DLibro();
            return Datos.ListarDisponibles();
        }

        public static DataTable Buscar(string Valor)
        {
            DLibro Datos = new DLibro();
            return Datos.Buscar(Valor);
        }

        public static string Insertar(int IdLibro,string Titulo, string Autor, string ISBM, string Editorial, string AnioEdicion, string NumeroEdicion, string Pais, string Idioma, string Materia,string NumeroPaginas, string UbicacionEstante, string Descripcion)
        {
            DLibro Datos = new DLibro();
            string Existe = Datos.Existe(IdLibro);
            if (Existe.Equals(1))
            {
                return "El libro ya existe";
            }
            else
            {
                Libro Obj = new Libro();
                Obj.Titulo = Titulo;
                Obj.Autor = Autor;
                Obj.ISBM = ISBM;
                Obj.Editorial = Editorial;
                Obj.AnioEdicion = AnioEdicion;
                Obj.NumeroEdicion = NumeroEdicion;
                Obj.Pais = Pais;
                Obj.Idioma = Idioma;
                Obj.Materia = Materia;
                Obj.NumeroPaginas = NumeroPaginas;
                Obj.UbicacionEstante = UbicacionEstante;
                Obj.Descripcion = Descripcion;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int IdLibro,string Titulo, string Autor, string ISBM, string Editorial, string AnioEdicion, string NumeroEdicion, string Pais, string Idioma, string Materia, string NumeroPaginas, string UbicacionEstante, string Descripcion,bool Estado)
        {
        
            DLibro Datos = new DLibro();
            string Existe = Datos.Existe(IdLibro);
            if (Existe.Equals("1"))
            {
                Libro Obj = new Libro();
                Obj.IdLibro = IdLibro;
                Obj.Titulo = Titulo;
                Obj.Autor = Autor;
                Obj.ISBM = ISBM;
                Obj.Editorial = Editorial;
                Obj.AnioEdicion = AnioEdicion;
                Obj.NumeroEdicion = NumeroEdicion;
                Obj.Pais = Pais;
                Obj.Idioma = Idioma;
                Obj.Materia = Materia;
                Obj.NumeroPaginas = NumeroPaginas;
                Obj.UbicacionEstante = UbicacionEstante;
                Obj.Descripcion = Descripcion;
                Obj.estado = Estado;
                return Datos.Actualizar(Obj);
            }
            else
            {
                return "El libro no existe";
            }
        }

        public static string Eliminar(int Id)
        {
            DLibro Datos = new DLibro();
            return Datos.Eliminar(Id);
        }

        public static string Activar(int IdLibro)
        {
            DLibro Datos = new DLibro();
            return Datos.Activar(IdLibro);
        }

        public static string Desactivar(int IdLibro)
        {
            DLibro Datos = new DLibro();
            return Datos.Desactivar(IdLibro);
        }
    }
}
