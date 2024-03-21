using Empresa.BSS;
using Empresa.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Empresa.VISTAS.EmpleadoVista
{
    public partial class EmpleadoEditarVista : Form
    {
        int idx = 0;
        Empleado p = new Empleado();
        EmpleadoBss bss = new EmpleadoBss();
        Persona persona = new Persona();
        public EmpleadoEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerEmpleadoId(idx);
            textBox4.Text = persona.Nombre;
            textBox1.Text = persona.Apellido;
            textBox2.Text = p.Puesto;
           // textBox3.Text = p.Salario;
           // dateTimePicker1 = p.FechaContratacion;
        }

    }
}
