using Entidades;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using iTextSharp.tool.xml;
using Org.BouncyCastle.Math;
using System.Runtime.InteropServices;

namespace PresentacionGPU
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        //Metodos para hacer posible la movilidad del form en la pantalla
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void StudentDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            MovimientoPanel();
        }

        void MovimientoPanel()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Validacion de que se cierre por completo el form
        private void StudentDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            var user = new UserType();
            user.Show();
            this.Close();
        }

        Logica.StudentServices Students = new StudentServices();

        //Abre el form de cambiar Contraseña
        private void BtnCambiarContraseñaES_Click(object sender, EventArgs e)
        {
            var cambiar = new CambioContra();
            cambiar.Show();
        }
        //Cierra el form abierto y devuelve al form anterior
        private void BtnSalirES_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Llama al metodo Descargar Notas al darle click al boton descargar
        private void BtnDescargarNotasES_Click(object sender, EventArgs e)
        {
            DescargarNota();
        }

        //Descarga un documento pdf con las notas correspondientes del estudiante que ingresò
        void DescargarNota()
        {   //Especificacion de las caracteristicas de guardado del pdf 
            SaveFileDialog guardar = new SaveFileDialog();
            string TitutloPdf = "Boletin";
            guardar.FileName = TitutloPdf + ".pdf";
            string PaginaHtml_Texto = Properties.Resources.plantilla.ToString();
            PaginaHtml_Texto = PaginaHtml_Texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));
            string filas = string.Empty;
            //Llamada de la capa Logica para usar los metodos almacenados allà
            NotasServices notas = new NotasServices();
            Student student = new Student();
            //Toma el id del estudiante y lo busca en la base de datos, retornando asi la lista de todas las notas correspondientes
            student.Id = txtNID.Text;
            var lista = notas.Reporte(student.Id);
            //Recorre la lista y llena cada campo del recurso de la Pagina Html con los datos de la lista
            foreach (var item in lista)
            {
                PaginaHtml_Texto = PaginaHtml_Texto.Replace("@ID", txtNID.Text);
                PaginaHtml_Texto = PaginaHtml_Texto.Replace("@NOMBRE", txt1N.Text);
                PaginaHtml_Texto = PaginaHtml_Texto.Replace("@APELLIDO", txt1A.Text);
                PaginaHtml_Texto = PaginaHtml_Texto.Replace("@2APELLIDO", txt2A.Text);
                PaginaHtml_Texto = PaginaHtml_Texto.Replace("@CURSO", txtCurso.Text);
                filas += "<tr>";
                filas += "<td>" + item.Nombre_Materia.ToString() + "</td>";
                filas += "<td>" + item.Nota1.ToString() + "</td>";
                filas += "<td>" + item.Nota2.ToString()+ "</td>";
                filas += "<td>" + item.Nota3.ToString()+ "</td>";
                filas += "<td>" + item.Definitiva.ToString() + "</td>";
                filas += "</tr>";

            }
            PaginaHtml_Texto = PaginaHtml_Texto.Replace("@FILAS", filas);

            //Validacion de que el usuario dio click en el boton de guardar
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(guardar.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    //Agregamos la imagen del banner al documento
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.universidad, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(60, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;

                    //img.SetAbsolutePosition(10,100);
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                    pdfDoc.Add(img);


                    //pdfDoc.Add(new Phrase("Hola Mundo"));
                    using (StringReader sr = new StringReader(PaginaHtml_Texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                }
            }
        }

        private void Grperfilescolar_Enter(object sender, EventArgs e)
        {

        }
    }
}