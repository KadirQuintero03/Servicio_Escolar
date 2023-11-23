using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionGPU
{
    public partial class TeacherDashboard : Form
    {
        public TeacherDashboard()
        {
            InitializeComponent();
        }
        //Metodos para hacer posible la movilidad del form en la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Cierra el form abierto y devuelve al form anterior
        private void BtnSalirES_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TeacherDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Funciones de validar los Text donde solo se tendra permitida la entrada de valores numericos.
        private static bool Validar_notas(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros en este campo", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            return e.Handled;
        }

        private static bool Validar_numeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite el ingreso de numeros, no letras", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            return e.Handled;
        }

        //Validacion de que se cierre por completo el form
        private void TeacherDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var user = new UserType();
            user.Show();
            this.Close();
        }
        //Validacion de que cursos van a aparecer en el Combo Box dependiendo del grado asignado al profesor
        private void ValidarCB()
        {
            if (TxtCursoP.Text == "6")
            {
                CursoCB.Items.Add("A601");
                CursoCB.Items.Add("A602");

            }
            else if (TxtCursoP.Text == "7")
            {
                CursoCB.Items.Add("B701");
                CursoCB.Items.Add("B702");
            }
            else if (TxtCursoP.Text == "8")
            {
                CursoCB.Items.Add("C801");
                CursoCB.Items.Add("C802");
            }
            else if (TxtCursoP.Text == "9")
            {
                CursoCB.Items.Add("D901");
                CursoCB.Items.Add("D902");
            }
            else if (TxtCursoP.Text == "10")
            {
                CursoCB.Items.Add("E101");
                CursoCB.Items.Add("E102");
            }
            else if (TxtCursoP.Text == "11")
            {
                CursoCB.Items.Add("F111");
                CursoCB.Items.Add("F112");
            }

        }

        //Llamadas a la capa Logica y la capa Entidades
        Entidades.Student Student = new Entidades.Student();
        Logica.StudentServices Students = new Logica.StudentServices();
        Logica.NotasServices notas = new Logica.NotasServices();
        Entidades.Materia materia = new Entidades.Materia();
        Logica.MateriaServices materiaServices = new Logica.MateriaServices();
        Entidades.Curso curso = new Entidades.Curso();
        Logica.CursosServices cursosServices = new Logica.CursosServices();

        //Ejecuta el metodo actualizar al darle click al Boton Actualizar
        private void button3_Click(object sender, EventArgs e)
        {
            Actualizar();
        }
        
        //Actualiza las notas modificadas por el profesor
        void Actualizar()
        {
            //Toma los valores de la grilla dependiendo de la columna
            Student.Id = GridES.CurrentRow.Cells[0].Value.ToString();
            materia.Nombre_Materia = txtMateria.Text;
            materia.Id_Materia = Convert.ToString(materiaServices.GetByName(materia));
            var Nota1 = Convert.ToDecimal(GridES.CurrentRow.Cells[6].Value.ToString());
            var Nota2 = Convert.ToDecimal(GridES.CurrentRow.Cells[7].Value.ToString());
            var Nota3 = Convert.ToDecimal(GridES.CurrentRow.Cells[8].Value.ToString());
            var Definitiva = Convert.ToDecimal(GridES.CurrentRow.Cells[9].Value.ToString());

            //Envia las notas y retorna un mensaje si se actualizò o no
            var mensaje = notas.Edit2(Student.Id, materia.Id_Materia, Nota1,Nota2,Nota3,Definitiva);
            
            MessageBox.Show(mensaje, "Actualizacion",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        
        //Al cargar el form se ejecuta los metodos CargarES y Validar CB
        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            CargarES();
            ValidarCB();
        }

        //Al cambiar de pestañas se ejecuta el metodo CargarES
        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            CargarES();
        }

        //Busca en la base de datos el nombre de la materia y el curso, dependiendo de lo datos del profesor
        //y carga la grilla con respecto a esos datos
        void CargarES()
        {
            materia.Nombre_Materia = txtMateria.Text;
            materia.Id_Materia = materiaServices.GetByName(materia);
            curso.Nombre_Curso = CursoCB.Text;
            curso.Id_Curso = cursosServices.GetById(curso.Nombre_Curso);
            GridES.DataSource = notas.Consultar_Notas(materia, curso);
        }

        //Al darle click al boton limpiar ejecuta el metodo Limpiar
        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        //Limpia la grilla y el text box de filtrar
        void Limpiar()
        {
            //GridES.items.Clear();
        }

        //Al darle click al boton calcular  ejecuta el metodo calcular
        private void BtnCalcularDef_Click(object sender, EventArgs e)
        {
            CalcularDefinitiva();
        }

        //Calcula la definitiva de las 3 notas correspondientes
        public void CalcularDefinitiva()
        {
            double Nota1 = Convert.ToDouble(GridES.CurrentRow.Cells[6].Value.ToString());
            double Nota2 = Convert.ToDouble(GridES.CurrentRow.Cells[7].Value.ToString());
            double Nota3 = Convert.ToDouble(GridES.CurrentRow.Cells[8].Value.ToString());
            double definitiva = ((Nota1*0.30)+(Nota2*0.30)+(Nota3*0.40));
            GridES.CurrentRow.Cells[9].Value = definitiva.ToString();
        }

        //Al darle click al boton cambiar contraseña se abrirà el otro form
        private void BtnCambiarContraseñaPR_Click(object sender, EventArgs e)
        {
            var cambiar = new CambioContra();
            cambiar.Show();
        }

        //Al seleccionar un item del Combo Box ejecuta el metodo CargarES
        private void CursoCB_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarES();
        }

        //Evento que se ejecuta cuando el texto del texbox cambia y si no esta vacio ejecuta el metodo filtro
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                FIltro();
            }
        }

        //Filtra la grilla dependiendo de el dato ingresado
        private void FIltro()
        {
            Student.Id = txtID.Text;
            materia.Nombre_Materia = txtMateria.Text;
            curso.Nombre_Curso = CursoCB.Text;
            GridES.DataSource = notas.Filtro(Student.Id, materia.Nombre_Materia, curso.Nombre_Curso);
        }
        
        //Eventos que ejecutan las validaciones de los text box
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_numeros(e);
        }

        private void txtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_notas(e);
        }

        private void txtN2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_notas(e);
        }

        private void txtN3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_notas(e);
        }
    }
}
