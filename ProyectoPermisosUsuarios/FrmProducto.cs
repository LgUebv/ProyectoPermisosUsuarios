using Controller;
using Identities;
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
    public partial class FrmProducto : Form
    {
        ControllerRefaccion cr;
        static int fila = 0, columna = 0;
        public static int codigoBarras;
        public static string nombre, marca, descripcion;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(codigoBarras.ToString()))
            {
                /*codigoBarras = int.Parse(dtgvProductos.Rows[fila].Cells[0].Value.ToString());
                nombre = dtgvProductos.Rows[fila].Cells[1].Value.ToString();
                marca = dtgvProductos.Rows[fila].Cells[2].Value.ToString();
                descripcion = dtgvProductos.Rows[fila].Cells[3].Value.ToString();*/
                FrmAddRefacciones formulario = new FrmAddRefacciones();
                formulario.SetData(codigoBarras, nombre, descripcion, marca);
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dtgvProductos.SelectedRows.Count > 0)
            {
                codigoBarras = int.Parse(dtgvProductos.SelectedRows[0].Cells["codigoBarras"].Value.ToString());

                cr.Borrar(codigoBarras);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvProductos.Rows[e.RowIndex];

                codigoBarras = int.Parse(row.Cells["CodigoBarras"].Value.ToString());
                nombre = row.Cells["nombre"].Value.ToString();
                descripcion = row.Cells["descripcion"].Value.ToString();
                marca = row.Cells["marca"].Value.ToString();

                row.Selected = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddRefacciones far = new FrmAddRefacciones();
            far.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FrmProducto()
        {
            InitializeComponent();
            cr = new ControllerRefaccion();
            VerificarPermisos();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            cr.Mostrar(dtgvProductos, txtBuscarProducto.Text);
        }
        private void VerificarPermisos()
        {
            int posicionX = 150;
            int espacioEntreBotones = 50;

            if (IdentitiesPermisos.Producto_Escritura)
            {
                posicionX = 30;
                btnAdd.Visible = true;
                btnAdd.Location = new Point(posicionX, btnAdd.Location.Y);
                posicionX += btnAdd.Width + espacioEntreBotones;
            }
            else
            {
                btnAdd.Visible = false;
            }

            if (IdentitiesPermisos.Producto_Actualizacion)
            {
                btnEditar.Visible = true;
                btnEditar.Location = new Point(posicionX, btnEditar.Location.Y);
                posicionX += btnEditar.Width + espacioEntreBotones;
            }
            else
            {
                btnEditar.Visible = false;
            }

            if (IdentitiesPermisos.Producto_Eliminacion)
            {
                btnDel.Visible = true;
                btnDel.Location = new Point(posicionX, btnDel.Location.Y);
            }
            else
            {
                btnDel.Visible = false;
            }
        }
    }
}
