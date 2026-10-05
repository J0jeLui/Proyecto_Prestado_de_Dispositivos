using SistemaPresatamos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaPresatamos
{
    public partial class FrmAdmin : FrmBase, IPanelCRUD
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        public void EjecutarActualizar()
        {

        }


        public void EjecutarBuscar(string id, ErrorProvider alerta)
        {
            try
            {
                // Limpiamos alertas previas
                alerta.Clear();

                if (string.IsNullOrWhiteSpace(id))
                {
                    alerta.SetError(label1, "Ingresa un ID para buscar.");
                    return;
                }

                // 1. Invocamos el método de consulta de la clase modelo (Actividad 2.3)
                // Como ConsultarRegistro regresa un 'object', hacemos un casting a Administrador
                Administrador adminEncontrado = (Administrador)new Administrador().ConsultarRegistro(id);

                if (adminEncontrado != null)
                {
                    // 2. Mapeamos los atributos del objeto de vuelta a las cajas de texto de la pantalla
                    label1.Text = adminEncontrado.Id.ToString();
                    txtCorreoAdmin.Text = adminEncontrado.Correo;
                    txtNombreAdmin.Text = adminEncontrado.Nombre;
                    txtContrasenaAdmin.Text = adminEncontrado.Contrasena;
                    txtRutaImagenAdmin.Text = adminEncontrado.RutaImagen;

                    MessageBox.Show("Registro encontrado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    alerta.SetError(label1, "No se encontró ningún registro con ese ID.");
                    MessageBox.Show("No existe un administrador con el ID proporcionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EjecutarEliminar(StatusStrip barraEstado)
        {
            throw new NotImplementedException();
        }

        public void EjecutarGuardar()
        {
            try
            {
                // 1. Recoger y convertir los datos de las cajas de texto visuales
                int id = int.Parse(label1.Text); // Viene del FrmBase
                string correo = txtCorreoAdmin.Text;
                string nombre = txtNombreAdmin.Text;
                string contrasena = txtContrasenaAdmin.Text;
                string rutaImagen = string.IsNullOrWhiteSpace(txtRutaImagenAdmin.Text) ? "default_admin.png" : txtRutaImagenAdmin.Text;

                // 2. Instanciar el objeto Administrador usando el constructor parametrizado
                // (Esto también mandará a llamar automáticamente al constructor de la EntidadBase)
                Administrador nuevoAdmin = new Administrador(
                    id,
                    correo,
                    nombre,
                    contrasena,
                    rutaImagen,
                    DateTime.Now,
                    true
                );
                nuevoAdmin.InsertarRegistro(nuevoAdmin);

                // 4. Retroalimentación visual para el usuario
                MessageBox.Show("Administrador registrado con éxito.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);


                
                txtCorreoAdmin.Clear();
                txtNombreAdmin.Clear();
                txtContrasenaAdmin.Clear();
                txtRutaImagenAdmin.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("El ID debe ser un número entero válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // Esto atrapa las validaciones que pusiste en los 'set' de tus propiedades (ej. si el correo no tiene '@')
                MessageBox.Show("No se pudo guardar: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnGuardarAdmin_Click(object sender, EventArgs e)
        {
            EjecutarGuardar();
            EjecutarBuscar(label1.Text, new ErrorProvider());

        }
    }
}
