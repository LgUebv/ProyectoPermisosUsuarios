using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPermisosUsuarios
{
    public partial class FrmAddUsuario : Form
    {
        ControllerUser Cu;
        string username = "";
        public FrmAddUsuario()
        {
            InitializeComponent();
            Cu = new ControllerUser();
            CargarPermisos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FrmUsuarios.username))
            {
                Cu.Guardar(txtUsername, txtPassword, txtNombre, txtApellidoP, txtApellidoM, dtpFechaNac, txtRFC, dtgvPermisos);
                MessageBox.Show("Usuario agregado exitosamente.");
            }
            else
            {
                Cu.Modificar(txtUsername, txtPassword, txtNombre, txtApellidoP, txtApellidoM, dtpFechaNac, txtRFC, dtgvPermisos);
                MessageBox.Show("Usuario modificado exitosamente.");
            }
            Close(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarPermisos()
        {
            dtgvPermisos.Rows.Clear();

            string[] formularios = { "Usuarios", "Herramientas", "Productos" }; 

            foreach (string formulario in formularios)
            {
                dtgvPermisos.Rows.Add(formulario, false, false, false, false);
            }

            dtgvPermisos.AutoResizeColumns();
        }

        public void SetData(string username, string password, string nombre, string apellidoP, string apellidoM, string fechaNacimiento, string rfc)
        {
            txtUsername.Text = username;
            txtPassword.Text = password;
            txtNombre.Text = nombre;
            txtApellidoP.Text = apellidoP;
            txtApellidoM.Text = apellidoM;
            dtpFechaNac.Value = DateTime.Parse(fechaNacimiento);
            txtRFC.Text = rfc;

            // Obtener permisos del usuario y llenarlos en el DataGridView
            var permisos = Cu.ObtenerPermisos(username);
            dtgvPermisos.Rows.Clear();

            foreach (var permiso in permisos)
            {
                dtgvPermisos.Rows.Add(permiso.Formulario, permiso.Lectura, permiso.Escritura, permiso.Actualizacion, permiso.Eliminacion);
            }

            dtgvPermisos.AutoResizeColumns();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
