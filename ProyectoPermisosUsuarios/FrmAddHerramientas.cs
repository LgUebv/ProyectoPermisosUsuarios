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
    public partial class FrmAddHerramientas : Form
    {
        ControllerHerramientas ch;
        public FrmAddHerramientas()
        {
            InitializeComponent();
            ch = new ControllerHerramientas();
            txtCodigoBarras.Text = FrmHerramientas.codigoHerramienta.ToString();
            txtNombreHerramienta.Text = FrmHerramientas.nombre.ToString();
            txtMedidaHerramienta.Text = FrmHerramientas.medida.ToString();
            txtMarcaHerramienta.Text = FrmHerramientas.marca.ToString();
            txtDescripcionHerramienta.Text = FrmHerramientas.descripcion.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FrmHerramientas.codigoHerramienta > 0)
                ch.Modificar(txtCodigoBarras, txtNombreHerramienta, txtMedidaHerramienta, txtMarcaHerramienta, txtDescripcionHerramienta);
            else
                ch.Guardar(txtCodigoBarras, txtNombreHerramienta, txtMedidaHerramienta, txtMarcaHerramienta, txtDescripcionHerramienta);
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetData(int codigoHerramienta, string nombre, double medida, string marca, string descripcion)
        {
            txtCodigoBarras.Text = codigoHerramienta.ToString();
            txtNombreHerramienta.Text = nombre;
            txtMedidaHerramienta.Text = medida.ToString();
            txtMarcaHerramienta.Text = marca;
            txtDescripcionHerramienta.Text = descripcion;
        }
    }
}
