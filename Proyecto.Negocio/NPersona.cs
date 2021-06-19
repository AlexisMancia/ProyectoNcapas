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
    public class NPersona
    {
        public static DataTable Listar()
        {
            DPersona Datos = new DPersona();
            return Datos.Listar();
        }
        public static DataTable Buscar(string Valor)
        {
            DPersona Datos = new DPersona();
            return Datos.Buscar(Valor);
        }

        public static string Insertar(string Nombre, string Apellido, string Telefono, int Edad)
        {
            DPersona Datos = new DPersona();
            string Existe = Datos.Existe(Nombre, Apellido);
            if (Existe.Equals(1))
            {
                return "La persona ya existe";
            }
            else
            {
                Persona Obj = new Persona();
                Obj.Nombre = Nombre;
                Obj.Apellido = Apellido;
                Obj.Telefono = Telefono;
                Obj.Edad = Edad;
                return Datos.Insertar(Obj);
            }
        }

        public static string Actualizar(int Id, string Nombre, string Apellido, string Telefono, int Edad)
        {
            DPersona Datos = new DPersona();
            string Existe = Datos.Existe(Nombre, Apellido);
            if (Existe.Equals(1))
            {
                Persona Obj = new Persona();
                Obj.Nombre = Nombre;
                Obj.Apellido = Apellido;
                Obj.Telefono = Telefono;
                Obj.Edad = Edad;
                return Datos.Actualizar(Obj);
            }
            else
            {
                return "La persona no existe";
            }
        }

        public static string Eliminar(int Id)
        {
            DPersona Datos = new DPersona();
            return Datos.Eliminar(Id);
        }

        public DataTable Login(string Email,string Clave)
        {
            DPersona Datos = new DPersona();
            return Datos.Login(Email, Clave);
        }
    }
}
