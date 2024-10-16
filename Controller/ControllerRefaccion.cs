﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class ControllerRefaccion
    {
        Funciones f = new Funciones();
        public void Guardar(TextBox codigoBarras, TextBox nombre, TextBox descripcion, TextBox marca)
        {
            MessageBox.Show(f.Guardar($"CALL p_InsertarRefacciones({codigoBarras.Text}, '{nombre.Text}', '{descripcion.Text}', '{marca.Text}')"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Borrar(int ID)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {ID}?", "Atencion!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"CALL p_EliminarRefacciones({ID})");
                MessageBox.Show("Registro eliminado con exito", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modificar(TextBox codigoBarras, TextBox nombre, TextBox descripcion, TextBox marca)
        {
            MessageBox.Show(f.Modificar($"CALL P_ModificarRefacciones({codigoBarras.Text}, '{nombre.Text}', '{descripcion.Text}', '{marca.Text}')"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataGridViewButtonColumn Boton(string t, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = t;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Popup;
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White;
            return b;
        }

        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from Refacciones where nombre like '%{filtro}%'", "Refacciones").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
