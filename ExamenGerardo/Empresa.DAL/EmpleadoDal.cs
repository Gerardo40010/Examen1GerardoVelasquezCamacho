using Empresa.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DAL
{
    public class EmpleadoDal
    {
        public DataTable ListarEmpleadoDal()
        {
            string consulta = "select * from TablaEmpleado";
            DataTable Lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarEmpleadoDal(Empleado empleado)
        {
            string consulta = "insert into TablaEmpleado values('" + empleado.IDPersona + "'," +
                                                           "'" + empleado.Puesto + "'," +
                                                            "'" + empleado.Salario + "'," +
                                                             "'" + empleado.FechaContratacion + "'," +
                                                          "'Activo')";
            Conexion.Ejecutar(consulta);
        }
        public Empleado ObtenerEmpleadoIdDal(int id)
        {
            string consulta = $"SELECT * FROM TablaEmpleado WHERE IDEmpleado = {id}";
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "tabla");
            Modelos.Empleado empleado = new Modelos.Empleado();
            if (tabla.Rows.Count > 0)
            {
                empleado.IDEmpleado = Convert.ToInt32(tabla.Rows[0]["IDEmpleado"]);
                empleado.IDPersona = Convert.ToInt32(tabla.Rows[0]["IDPersona"]);
                empleado.Puesto = tabla.Rows[0]["Puesto"].ToString();
                empleado.Salario = Convert.ToDecimal(tabla.Rows[0]["Salario"]);
                empleado.FechaContratacion = Convert.ToDateTime(tabla.Rows[0]["FechaContratacion"]);
            }
            return empleado;
        }
        public void EditarEmpleadoDal(Empleado e)
        {
            string consulta = "UPDATE TablaEmpleado SET idpersona= " + e.IDPersona + " ," +
                                                  "Puesto= '" + e.Puesto + "' " +
                                                   "Salario= '" + e.Salario + "' " +
                                                  "FechaContratacion= '" + e.FechaContratacion + "' " +
                              "WHERE IDEmpleado=" + e.IDEmpleado;
            Conexion.Ejecutar(consulta);
        }
        public void EliminarEmpleadoDal(int id)
        {
            string consulta = "DELETE FROM TablaEmpleado WHERE IDEmpleado = " + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
