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
using Identities;

namespace ProyectoPermisosUsuarios
{
    public partial class FrmUsuarios : Form
    {
        public static string username, password, nombre, apellidoP, apellidoM, fechaNac, rfc = "";
        ControllerUser Cu;

        public FrmUsuarios()
        {
            InitializeComponent();
            VerificarPermisos();
            Cu = new ControllerUser();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            Cu.MostrarGeneral(dtgvUsuarios, txtBuscarUsuario.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddUsuario btn = new FrmAddUsuario();
            btn.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(username))
            {
                FrmAddUsuario formulario = new FrmAddUsuario();
                formulario.SetData(username, password, nombre, apellidoP, apellidoM, fechaNac, rfc);
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dtgvUsuarios.SelectedRows.Count > 0)
            {
                string usernameSeleccionado = dtgvUsuarios.SelectedRows[0].Cells["Username"].Value.ToString();

                Cu.Borrar(usernameSeleccionado);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvUsuarios.Rows[e.RowIndex];

                username = row.Cells["Username"].Value.ToString();
                password = row.Cells["password"].Value.ToString();
                nombre = row.Cells["nombre"].Value.ToString();
                apellidoP = row.Cells["apellidoP"].Value.ToString();
                apellidoM = row.Cells["apellidoM"].Value.ToString();
                fechaNac = Convert.ToDateTime(row.Cells["fechanacimiento"].Value).ToString("yyyy-MM-dd");
                rfc = row.Cells["rfc"].Value.ToString();

                row.Selected = true;
            }
        }

        private void VerificarPermisos()
        {
            btnAdd.Visible = IdentitiesPermisos.Usuarios_Escritura;
            btnEdit.Visible = IdentitiesPermisos.Usuarios_Actualizacion;
            btnDel.Visible = IdentitiesPermisos.Usuarios_Eliminacion;
        }
    }
}
