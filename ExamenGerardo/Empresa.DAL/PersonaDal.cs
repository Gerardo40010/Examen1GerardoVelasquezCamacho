using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.Modelos;
namespace Empresa.DAL
{
    public class PersonaDal
    {
        public DataTable ListarPersonaDal()
        {
            string consulta = "select * from Persona";
            DataTable Lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into Persona values('" + persona.Nombre + "'," +
                                                          "'" + persona.Apellido + "'," +
                                                          "'Activo')";
            Conexion.Ejecutar(consulta);
        }
        public Persona ObtenerPersonaIdDal(int id)
        {
            string consulta = "SELECT * FROM PERSONA WHERE IDPERSONA=" + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Persona persona = new Persona();
            if (tabla.Rows.Count > 0)
            {
                persona.IDPersona = Convert.ToInt32(tabla.Rows[0]["idpersona"]);
                persona.Nombre = tabla.Rows[0]["nombre"].ToString();
                persona.Apellido = tabla.Rows[0]["apellido"].ToString();
                persona.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return persona;
        }
        public void EditarPersonaDal(Persona p)
        {
            string consulta = "UPDATE PERSONA SET nombre='" + p.Nombre + "' ," +
                                                         "apellido= '" + p.Apellido + "' ," +
                                "WHERE IDPERSONA=" + p.IDPersona;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarPersonaDal(int id)
        {
            string consulta = "DELETE FROM PERSONA WHERE IDPERSONA=" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
