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
    public class NPrestamo
    {
        public static DataTable Listar()
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.Listar();
        }

        public static DataTable Buscar(string Valor, string Valor2)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.Buscar(Valor,Valor2);
        }

        public static string Insertar(int IdPersona, int IdLibro, DateTime fechaPrestamo, DateTime fechaDevolucion)
        {
            DPrestamo Datos = new DPrestamo();
            string Existe = Datos.Existe(IdLibro, IdPersona);
            if (Existe.Equals(1))
            {
                return "La persona ya existe";
            }
            else
            {
                Prestamo Obj = new Prestamo();
                Obj.IdPersona = IdPersona;
                Obj.IdLibro = IdLibro;
                Obj.FechaPrestamo = fechaPrestamo;
                Obj.FechaDevolucion = fechaDevolucion;

                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int IdPersona, int IdLibro, DateTime fechaPrestamo, DateTime fechaDevolucion,bool estado)
        {
            DPrestamo Datos = new DPrestamo();
            string Existe = Datos.Existe(IdLibro, IdPersona);
            if (Existe.Equals(1))
            {
                Prestamo Obj = new Prestamo();
                Obj.IdPersona = IdPersona;
                Obj.IdLibro = IdLibro;
                Obj.FechaPrestamo = fechaPrestamo;
                Obj.FechaDevolucion = fechaDevolucion;
                Obj.Estado = estado;

                return Datos.Actualizar(Obj);
            }
            else
            {
                return "El prestamo no existe";
            }
        }

        public static string Eliminar(int IdLibro,int IdPersona)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.Eliminar(IdLibro,IdPersona);
        }

        public static string Desactivar(int IdLibro, int IdPersona)
        {
            DPrestamo Datos = new DPrestamo();
            return Datos.Desactivar(IdLibro,IdPersona);
        }
    }
}
