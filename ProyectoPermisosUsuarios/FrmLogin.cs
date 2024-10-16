﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace ProyectoPermisosUsuarios
{
    public partial class FrmLogin : Form
    {
        ControllerLogin CL;

        public FrmLogin()
        {
            InitializeComponent();
            CL = new ControllerLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] r = CL.Validar(txtUsername.Text, txtPassword.Text);
            if (r[0].Equals("Correcto"))
            {
                this.Hide();

                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Nombre o contraseña incorrectos, favor de consultar con el administrador", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
