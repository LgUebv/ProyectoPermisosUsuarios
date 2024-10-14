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
    public partial class FrmHerramientas : Form
    {
        ControllerHerramienta ch;
        static int fila = 0, columna = 0;
        public static int codigoHerramienta;
        public static double medida;
        public static string nombre, marca, descripcion;

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dtgvHerramientas.SelectedRows.Count > 0)
            {
                codigoHerramienta = int.Parse(dtgvHerramientas.SelectedRows[0].Cells["codigoHerramienta"].Value.ToString());

                // Llama al método Borrar del manejador
                ch.Borrar(codigoHerramienta);
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgvHerramientas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegúrate de que la fila es válida
            {
                DataGridViewRow row = dtgvHerramientas.Rows[e.RowIndex];

                // Almacena los datos de la fila seleccionada en las variables
                codigoHerramienta = int.Parse(row.Cells["codigoHerramienta"].Value.ToString()); // Asegúrate de que este valor sea seguro
                nombre = row.Cells["nombre"].Value.ToString();
                medida = double.Parse(row.Cells["medida"].Value.ToString());
                marca = row.Cells["marca"].Value.ToString();
                descripcion = row.Cells["descripcion"].Value.ToString();

                // Cambia el color de la fila seleccionada (opcional)
                row.Selected = true; // Esto selecciona la fila visualmente
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddHerramientas fah = new FrmAddHerramientas();
            fah.Show();
        }

        private void txtBuscarHerramienta_TextChanged(object sender, EventArgs e)
        {
            ch.Mostrar(dtgvHerramientas, txtBuscarHerramienta.Text);
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public FrmHerramientas()
        {
            InitializeComponent();
            ch = new ControllerHerramienta();
            VerificarPermisos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(codigoHerramienta.ToString()))
            {
                /*codigoHerramienta = int.Parse(dtgvHerramientas.Rows[fila].Cells[0].Value.ToString());
                nombre = dtgvHerramientas.Rows[fila].Cells[1].Value.ToString();
                medida = double.Parse(dtgvHerramientas.Rows[fila].Cells[2].Value.ToString());
                marca = dtgvHerramientas.Rows[fila].Cells[3].Value.ToString();
                descripcion = dtgvHerramientas.Rows[fila].Cells[4].Value.ToString();*/
                FrmAddHerramientas formulario = new FrmAddHerramientas();
                formulario.SetData(codigoHerramienta, nombre, medida, marca, descripcion); // Método que debes crear en el formulario
                formulario.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor selecciona un usuario para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void VerificarPermisos()
        {
            if (!IdentitiesPermisos.Herramientas_Escritura)
            {
                btnAdd.Visible = false;
                //falta lo de las posiciones de botones
            }

            btnEditar.Visible = IdentitiesPermisos.Herramientas_Actualizacion;

            if (!IdentitiesPermisos.Herramientas_Eliminacion)
            {
                btnDel.Visible = false;
                //falta lo de las posiciones de botones
            }
        }
    }
}
