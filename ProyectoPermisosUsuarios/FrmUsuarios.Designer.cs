namespace ProyectoPermisosUsuarios
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.txtBuscarUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Tomato;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDel.Location = new System.Drawing.Point(490, 355);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(169, 42);
            this.btnDel.TabIndex = 37;
            this.btnDel.Text = "ELIMINAR";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.GreenYellow;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(265, 355);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(169, 42);
            this.btnEdit.TabIndex = 36;
            this.btnEdit.Text = "MODIFICAR";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(24, 355);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 42);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Location = new System.Drawing.Point(11, 73);
            this.dtgvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.RowHeadersWidth = 51;
            this.dtgvUsuarios.RowTemplate.Height = 24;
            this.dtgvUsuarios.Size = new System.Drawing.Size(665, 270);
            this.dtgvUsuarios.TabIndex = 34;
            this.dtgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellClick);
            // 
            // txtBuscarUsuario
            // 
            this.txtBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarUsuario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBuscarUsuario.Location = new System.Drawing.Point(11, 42);
            this.txtBuscarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarUsuario.Name = "txtBuscarUsuario";
            this.txtBuscarUsuario.Size = new System.Drawing.Size(665, 27);
            this.txtBuscarUsuario.TabIndex = 33;
            this.txtBuscarUsuario.TextChanged += new System.EventHandler(this.txtBuscarUsuario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 28);
            this.label1.TabIndex = 32;
            this.label1.Text = "BUSCAR USUARIOS";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Red;
            this.lblExit.Location = new System.Drawing.Point(654, -1);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(31, 34);
            this.lblExit.TabIndex = 38;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 410);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvUsuarios);
            this.Controls.Add(this.txtBuscarUsuario);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.TextBox txtBuscarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExit;
    }
}

