using Empresa.BSS;
using Empresa.Modelos;
using Empresa.VISTAS.PersonaVista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.VISTAS.EmpleadoVista
{
    public partial class EmpleadoInsertarVista : Form
    {
        public EmpleadoInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();

        private void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox4.Text = persona.Nombre;
                textBox2.Text = persona.Apellido;
            }
        }
        EmpleadoBss bssempleado = new EmpleadoBss();
        private void button2_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();
            empleado.IDPersona = IdPersonaSeleccionada;
            empleado.Puesto = Convert.ToString(textBox2.Text);
            empleado.Salario = Convert.ToDecimal(textBox3.Text);
            empleado.FechaContratacion = dateTimePicker1.Value;
            bssempleado.InsertarEmpleadoBss(empleado);
            MessageBox.Show("Se guardó correctamente el usuario");
        }
    }
}
