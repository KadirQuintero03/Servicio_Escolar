using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;
using System.Runtime.InteropServices;

namespace PresentacionGPU
{
    public partial class UserType : Form
    {
        public UserType()
        {
            InitializeComponent();
            BoxUserType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Lineas de codigo implementadas con el objetivo de poder darle movilidar al Form UserType y minimizarlo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        void MovimientoPanel()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //*******************************************************************************************************

        //Funciones para el control de Acceso de Estudiantes, Profesores y Administrador
        //Llamada de los servicios requeridos en la capa Logica
        Logica.AdminServices adminServices = new Logica.AdminServices();
        Logica.StudentServices studentServices = new Logica.StudentServices();
        Logica.TeacherServices teacherServices = new Logica.TeacherServices();

        //Llamada de las entidades requeridas
        Entidades.Student student = new Entidades.Student();
        Entidades.Teacher Teacher = new Entidades.Teacher();
        Entidades.User User = new User();

        //Validaciones y funciones de movimiento
        private void UserType_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoPanel();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BoxUserType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (BoxUserType.Text == "Estudiante")
            {
                MessageBox.Show("Si es tu primera vez entrando al sistema, te recuerdo que tu USUARIO y CONTRASEÑA son tu NUMERO DE IDENTIFICACION.");
            }
        }
        //Evento que se ejecuta cuando le dan click al boton aceptar y ejecuta el metodo Access
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            access(BoxUser, BoxUserType, BoxPassword);
        }

        //Valida si el Rol, usuario y contraseña son correctos y se encuentran en la base de datos
        void access(TextBox BoxUser, ComboBox BoxUserType, TextBox BoxUser2)
        {
            var Admin = new AdminDashboard();
            
            User.UserName = BoxUser.Text;
            User.Contraseña = BoxUser2.Text;
            User.Rol = BoxUserType.Text;
  

            var @Encontrado = adminServices.Exists(User);

            if (@Encontrado == true){
                MessageBox.Show("Bienvenido");
                if (User.Rol == "Administrador")
                {
                    Admin.ShowDialog();

                } else if (User.Rol == "Profesor")
                {
                    AggDatosPR(BoxUser);

                } else if (User.Rol == "Estudiante")
                {
                    AggDatosES(BoxUser);                
                }
            } else
            {
                MessageBox.Show("Usuario y/o contraseña invalidos.");
            }
        }

        //Carga en los text Box del StudentDashborad los datos del estudiante que ingresò
        private void AggDatosES(TextBox Ide)
        {  
            student.Id = BoxUser.Text;
            var lista = studentServices.Busqueda(student.Id);
            var Estudiante = new StudentDashboard();

            Estudiante.txtTID.Text = lista.Tipo;
            Estudiante.txtNID.Text = lista.Id;
            Estudiante.txt1N.Text = lista.Primero_Nombre;
            Estudiante.txt2N.Text = lista.Segundo_Nombre;
            Estudiante.txt1A.Text = lista.Primer_Apellido;
            Estudiante.txt2A.Text = lista.Segundo_Apellido;
            Estudiante.txtCorreo.Text = lista.Correo;
            Estudiante.txtCurso.Text = lista.Id_Curso;
            Estudiante.txtSede.Text = lista.Sede;
            Estudiante.ShowDialog();
        }

        //Carga en los text Box del TeacherDashborad los datos del profesor que ingresò
        private void AggDatosPR(TextBox Ide)
        {     
            Teacher.Id = BoxUser.Text;
            var lista = teacherServices.Busqueda(Teacher.Id);
            var Profesor = new TeacherDashboard();

            Profesor.TxtIdteacher.Text = lista.Tipo;
            Profesor.TxtNidteacher.Text = lista.Id;
            Profesor.TxtNameteacher.Text = lista.Primero_Nombre;
            Profesor.TxtName2teacher.Text = lista.Segundo_Nombre;
            Profesor.TxtApellidoteacher.Text = lista.Primer_Apellido;
            Profesor.TxtApellido2teacher.Text = lista.Segundo_Apellido;
            Profesor.txtCorreoI.Text = lista.Correo;
            Profesor.txtSede.Text = lista.Sede;
            Profesor.txtMateria.Text = lista.Materia;
            Profesor.TxtCursoP.Text = lista.Curso;
            Profesor.ShowDialog();
        }

        private void btnAceptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressEventArgs args = (KeyPressEventArgs)e;
        }


        //********************************************************************
        /*Eventos utilizados con el fin de que cuando se seleccione la caja de texto de del usuario(BoxUser)
         y la caja de texto de la contraseña(BoxPassword) el texto predeterminado de estas se muestre u oculte*/
        private void BoxUser_Enter(object sender, EventArgs e)
        {
            if (BoxUser.Text == "Usuario")
            {
                BoxUser.Text = "";
            }
        }
        
        private void BoxUser_Leave(object sender, EventArgs e)
        {
            if (BoxUser.Text == "")
            {
                BoxUser.Text = "Usuario";
            }
        }

        private void BoxPassword_Enter(object sender, EventArgs e)
        {
            if (BoxPassword.Text == "Contraseña")
            {
                BoxPassword.Text = "";
                BoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void BoxPassword_Leave(object sender, EventArgs e)
        {
            if (BoxPassword.Text == "")
            {
                BoxPassword.Text = "Contraseña";
                BoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void UserType_Load(object sender, EventArgs e)
        {

        }
    }
}