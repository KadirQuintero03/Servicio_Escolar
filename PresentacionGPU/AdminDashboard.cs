using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Logica;
using System.Windows.Forms;
using System.Collections;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Runtime.InteropServices;
using iTextSharp.tool.xml.html;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentacionGPU
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------
        //Lineas de codigo implementadas con el objetivo de poder darle movilidar al Form UserType

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void AdminDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoPanel();
        }

        void MovimientoPanel()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //----------------------------------------------------------------------------------------

        private void BtnSalirUserType_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinUserType_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Esta funcion permite solo el ingreso de valores NO_numericos en los TextBox
        private static bool Validar_letras(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite el ingreso de letras, no numeros", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            return e.Handled;
        }

        //Esta funcion permite solo el ingreso de valores numericos en los TextBox
        private static bool Validar_numeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permite el ingreso de numeros, no letras", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            return e.Handled;
        }

        //Esta funcion permite solo el ingreso de valores numericos con el detalle que se permite un solo caracter no numerico el cual es ","
        private static bool Validar_notas(KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten numeros en este campo", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            return e.Handled;
        }

        //Esta funcion carga automaticamente la grilla cuando se carga completamente.
        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            CargarES();
            CargarPR();
        }

        //Esta funcion cierra el admin dashboard.
        private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var user = new UserType();
            user.Show();
            this.Close();
        }
        //Llamadas a la capa Logica y la capa Entidades
        Logica.AdminServices adminServices = new Logica.AdminServices();
        Logica.TeacherServices teacherServices = new Logica.TeacherServices();
        Logica.StudentServices studentServices = new Logica.StudentServices();
        Logica.NotasServices notasServices = new Logica.NotasServices();
        Logica.CursosServices cursosServices = new Logica.CursosServices();
        Logica.MateriaServices materiaServices = new Logica.MateriaServices();

        Entidades.Student Student = new Entidades.Student();
        Entidades.Teacher Teacher = new Entidades.Teacher();
        Entidades.Curso Curso = new Entidades.Curso();
        Entidades.User User = new User();

        //Funciones, metodos y eventos de Student -----------------------
        
        //Ejecuta los 3 metodos al hacer click en el boton agregar
        private void BtnAgregarES_Click(object sender, EventArgs e)
        {
            AgregarES();
            CargarES();
            AggNota();
        }

        //Envia los datos del estudiante a la capa logica despues de haberlos captura de los text box y retorna un mensaje
        private bool ValidarTextES()
        {
            if (AggDocES.Text == "" ||
            AggIdES.Text == "" ||
            AggNombreES.Text == "" ||
            AggApellidoES.Text == "" ||
            Agg2ApellidoES.Text == "" ||
            AggGeneroES.Text == "" ||
            AggCorreoES.Text == "" ||
            AggSedeES.Text == "" ||
            AggCursoES.Text == "" 
            )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void AgregarES()
        {

            if (ValidarTextES() == false) {
                Student.Tipo = AggDocES.Text;
                Student.Id = AggIdES.Text;
                Student.Primero_Nombre = AggNombreES.Text;
                Student.Segundo_Nombre = Agg2NombreES.Text;
                Student.Primer_Apellido = AggApellidoES.Text;
                Student.Segundo_Apellido = Agg2ApellidoES.Text;
                Student.Genero = AggGeneroES.Text;
                Student.Correo = AggCorreoES.Text;
                Student.Sede = AggSedeES.Text;

                User.UserName = AggIdES.Text;
                User.Rol = "Estudiante";

                Curso.Nombre_Curso = AggCursoES.Text;
                Student.Id_Curso = cursosServices.GetById(Curso.Nombre_Curso);

                var mensaje = studentServices.Add(Student);
                if (mensaje == "Almacenado correctamente")
                {
                    adminServices.Add(User);
                }
                MessageBox.Show(mensaje);
            } else if (ValidarTextES() == true) {
                MessageBox.Show("Error, primero se deben llenar todos los campos solicitados");
            }
        }
        //Envia el id del estudiante a la capa logica 
        void AggNota()
        {
            Student.Id = AggIdES.Text;
            notasServices.Add2(Student.Id);
        }

        //Al darle click al boton nuevo carga la grilla y limpia los text box de la pestaña de estudiante
        private void BtnNuevoES_Click(object sender, EventArgs e)
        {
            NuevoES();
            CargarES();
        }

        //Limpia los Combo Box y Text Box de la pestaña de estudiante
        void NuevoES()
        {
            AggNombreES.Clear();
            Agg2NombreES.Clear();
            AggApellidoES.Clear();
            Agg2ApellidoES.Clear();
            AggIdES.Clear();
            AggCorreoES.Clear();
            AggCursoES.Text = "";
            AggSedeES.Clear();
            AggGeneroES.Text = "";
            AggDocES.Text = "";
        }

        //Al darle click al boton Modificar carga la grilla y ejecuta el metodo ModificarES
        private void BtnModificarES_Click(object sender, EventArgs e)
        {
            ModificarES();
            CargarES();
        }

        //Envia los datos modificados a la capa de logica y retorna un mensaje 
        void ModificarES()
        {
            Student.Tipo = AggDocES.Text;
            Student.Id = AggIdES.Text;
            Student.Primero_Nombre = AggNombreES.Text;
            Student.Segundo_Nombre = Agg2NombreES.Text;
            Student.Primer_Apellido = AggApellidoES.Text;
            Student.Segundo_Apellido = Agg2ApellidoES.Text;
            Student.Genero = AggGeneroES.Text;
            Student.Correo = AggCorreoES.Text;
            Student.Sede = AggSedeES.Text;

            Curso.Nombre_Curso = AggCursoES.Text;
            Student.Id_Curso = cursosServices.GetById(Curso.Nombre_Curso);
            
            var mensaje = studentServices.Edit(Student);
            MessageBox.Show(mensaje);
        }
        //Envia el id del estudiante que se desea eliminar a la capa logica
        void EliminarES()
        {
            Student.Id = Convert.ToString(GridES.CurrentRow.Cells["N° Id"].Value.ToString());
            var mensaje = studentServices.Delete(Student.Id);
            MessageBox.Show(mensaje);
        }
        //Envia el id del estudiante que se desea eliminar de la tabla de notas a la capa Logica, esto es un proceso interno
        void ELiminarNES()
        {
            Student.Id = Convert.ToString(GridES.CurrentRow.Cells["N° Id"].Value.ToString());
            notasServices.Delete(Student.Id);
        }
        //Evento doble click de la grilla que ejecuta el metodo de transcripcion
        private void GridES_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GES.Show();
            Transcripcion();
        }
        //Transcribe lo de las columnas a los text box
        void Transcripcion()
        {
            AggDocES.Text = GridES.CurrentRow.Cells[1].Value.ToString();
            AggIdES.Text = GridES.CurrentRow.Cells[2].Value.ToString();
            AggNombreES.Text = GridES.CurrentRow.Cells[3].Value.ToString();
            Agg2NombreES.Text = GridES.CurrentRow.Cells[4].Value.ToString();
            AggApellidoES.Text = GridES.CurrentRow.Cells[5].Value.ToString();
            Agg2ApellidoES.Text = GridES.CurrentRow.Cells[6].Value.ToString();
            AggGeneroES.Text = GridES.CurrentRow.Cells[7].Value.ToString();
            AggCursoES.Text = GridES.CurrentRow.Cells[8].Value.ToString();
            AggCorreoES.Text = GridES.CurrentRow.Cells[9].Value.ToString();
            AggSedeES.Text = GridES.CurrentRow.Cells[10].Value.ToString();
        }
        //Carga la grilla con los datos de todos los estudiantes
        public void CargarES()
        {
            GridES.DataSource = studentServices.Consultar_ES();
        }

        //Validaciones de los text Box de la pestaña Estudiante
        private void AggNombreES_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_letras(e);
        }

        private void Agg2NombreES_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_letras(e);
        }

        private void AggApellidoES_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_letras(e);
        }

        private void Agg2ApellidoES_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_letras(e);
        }

        private void AggIdES_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_numeros(e);
        }

        private void TxtNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_notas(e);
        }

        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_notas(e);
        }

        private void txtNota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_notas(e);
        }



        //Funciones, metodos y eventos de Teacher -----------------------------
        private void BtnAgregarPR_Click(object sender, EventArgs e)
        {
            AgregarPR();
            CargarPR();
        }
        //Validacion de que no se ejecute el metodo Agregar si estan todos los textbox vacios
        private bool ValidarTextPR()
        {
            if (AggDocPR.Text == "" || 
            AggIdPR.Text == "" || 
            AggNombrePR.Text == "" || 
            AggApellidoPR.Text == "" || 
            Agg2ApellidoPR.Text == "" || 
            AggGenero.Text == "" ||
            AggCorreoPR.Text == "" ||
            AggSedePR.Text == "" ||
            AggCursoPR.Text == "" ||
            AggIdPR.Text == "" ||
            AggMateriaPR.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void AgregarPR()
        {
            if(ValidarTextPR() == false)
            {
                Teacher teacher = new Teacher();
                Materia materia = new Materia();
                Curso curso = new Curso();
                teacher.Tipo = AggDocPR.Text;
                teacher.Id = AggIdPR.Text;
                teacher.Primero_Nombre = AggNombrePR.Text;
                teacher.Segundo_Nombre = Agg2NombrePR.Text;
                teacher.Primer_Apellido = AggApellidoPR.Text;
                teacher.Segundo_Apellido = Agg2ApellidoPR.Text;
                teacher.Genero = AggGenero.Text;
                teacher.Correo = AggCorreoPR.Text;
                teacher.Sede = AggSedePR.Text;
                teacher.Id_Curso = AggCursoPR.Text;
                User.UserName = AggIdPR.Text;
                User.Rol = "Profesor";

                materia.Nombre_Materia = AggMateriaPR.Text;

                teacher.Materia = Convert.ToString(materiaServices.GetByName(materia));

                var mensaje = teacherServices.Add(teacher);
                if (mensaje == "Almacenado correctamente")
                {
                    adminServices.Add(User);
                    materiaServices.Add2(teacher.Id, teacher.Materia);

                }
                MessageBox.Show(mensaje);
            }else if(ValidarTextPR() == true)
            {
                MessageBox.Show("Error, primero se deben llenar todos los campos solicitados");
            }
        }

        private void BtnNuevoPR_Click(object sender, EventArgs e)
        {
            NuevoPR();
            CargarPR();
        }

        void NuevoPR()
        {
            AggDocPR.Text = "";
            AggNombrePR.Clear();
            Agg2NombrePR.Clear();
            AggApellidoPR.Clear();
            Agg2ApellidoPR.Clear();
            AggIdPR.Clear();
            AggCorreoPR.Clear();
            AggCursoPR.Text = "";
            AggSedePR.Clear();
            AggMateriaPR.Text = "";
            AggGenero.Text = "";
        }

        private void BtnModificarPR_Click(object sender, EventArgs e)
        {
            ModificarPR();
            CargarPR();
        }

        void ModificarPR()
        {
            Teacher.Tipo = AggDocPR.Text;
            Teacher.Id = AggIdPR.Text;
            Teacher.Primero_Nombre = AggNombrePR.Text;
            Teacher.Segundo_Nombre = Agg2NombrePR.Text;
            Teacher.Primer_Apellido = AggApellidoPR.Text;
            Teacher.Segundo_Apellido = Agg2ApellidoPR.Text;
            Teacher.Genero = AggGenero.Text;
            Teacher.Correo = AggCorreoPR.Text;
            Teacher.Sede = AggSedePR.Text;
            Teacher.Id_Curso = AggCursoPR.Text;

            var mensaje = teacherServices.Edit(Teacher);
            MessageBox.Show(mensaje);
        }

        void EliminarPR()
        {
            Teacher.Id = Convert.ToString(GridPR.CurrentRow.Cells["N° Id"].Value.ToString());
            var mensaje = teacherServices.Delete(Teacher.Id);
            MessageBox.Show(mensaje);
        }

        void EliminarAP()
        {
            Teacher.Id = Convert.ToString(GridPR.CurrentRow.Cells["N° Id"].Value.ToString());     
            materiaServices.Delete(Teacher.Id);
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            CargarES();
            CargarPR();
        }

        void CargarPR()
        {
            GridPR.DataSource = teacherServices.Consultar_PR();
        }

        private void Busqueda_ES()
        {
            Student.Id = FIltro.Text;
            GridES.DataSource = studentServices.Filtro(Student.Id);
        }


        private void GridPR_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TranscripcionPR();
            GPR.Show();
        }

        void TranscripcionPR()
        {
            AggDocPR.Text = GridPR.CurrentRow.Cells[1].Value.ToString();
            AggIdPR.Text = GridPR.CurrentRow.Cells[2].Value.ToString();
            AggNombrePR.Text = GridPR.CurrentRow.Cells[3].Value.ToString();
            Agg2NombrePR.Text = GridPR.CurrentRow.Cells[4].Value.ToString();
            AggApellidoPR.Text = GridPR.CurrentRow.Cells[5].Value.ToString();
            Agg2ApellidoPR.Text = GridPR.CurrentRow.Cells[6].Value.ToString();
            AggGenero.Text = GridPR.CurrentRow.Cells[7].Value.ToString();
            AggCorreoPR.Text = GridPR.CurrentRow.Cells[8].Value.ToString();
            AggSedePR.Text = GridPR.CurrentRow.Cells[9].Value.ToString();
            AggCursoPR.Text = GridPR.CurrentRow.Cells[10].Value.ToString();
            AggMateriaPR.Text = GridPR.CurrentRow.Cells[11].Value.ToString();
        }

        private void AggNombrePR_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_letras(e);
        }

        private void Agg2NombrePR_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_letras(e);
        }

        private void AggApellidoPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_letras(e);
        }

        private void Agg2ApellidoPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_letras(e);
        }

        private void AggIdPR_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar_numeros(e);
        }

 
        private void FIltro_TextChanged(object sender, EventArgs e)
        {
            Busqueda_ES();
        }

        private void BtnFIltro_TextChanged(object sender, EventArgs e)
        {
            Busqueda_PR();
        }
        private void Busqueda_PR()
        {
            Teacher.Id = BtnFIltro.Text;
            GridPR.DataSource = teacherServices.Filtro(Teacher.Id);
        }

        private void GridES_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridES.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                ELiminarNES();
                EliminarES();
                CargarES();
            }
        }

        private void GridPR_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridPR.Columns[e.ColumnIndex].Name == "Borrar")
            {

                EliminarAP();
                EliminarPR();
                CargarPR();
            }
        }
    }
}