namespace ProyectoPermisosUsuarios
{
    partial class FrmHerramientas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvHerramientas = new System.Windows.Forms.DataGridView();
            this.txtBuscarHerramienta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Tomato;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDel.Location = new System.Drawing.Point(498, 361);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(149, 38);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "ELIMINAR";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditar.Location = new System.Drawing.Point(265, 361);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 38);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "MODIFICAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(36, 361);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 38);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "AGREGAR";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvHerramientas
            // 
            this.dtgvHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHerramientas.Location = new System.Drawing.Point(11, 74);
            this.dtgvHerramientas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvHerramientas.Name = "dtgvHerramientas";
            this.dtgvHerramientas.RowHeadersWidth = 51;
            this.dtgvHerramientas.RowTemplate.Height = 24;
            this.dtgvHerramientas.Size = new System.Drawing.Size(665, 270);
            this.dtgvHerramientas.TabIndex = 27;
            this.dtgvHerramientas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHerramientas_CellEnter);
            // 
            // txtBuscarHerramienta
            // 
            this.txtBuscarHerramienta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarHerramienta.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtBuscarHerramienta.Location = new System.Drawing.Point(11, 43);
            this.txtBuscarHerramienta.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarHerramienta.Name = "txtBuscarHerramienta";
            this.txtBuscarHerramienta.Size = new System.Drawing.Size(665, 27);
            this.txtBuscarHerramienta.TabIndex = 26;
            this.txtBuscarHerramienta.TextChanged += new System.EventHandler(this.txtBuscarHerramienta_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 28);
            this.label1.TabIndex = 25;
            this.label1.Text = "BUSCAR HERRAMIENTAS";
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.Red;
            this.lblExit.Location = new System.Drawing.Point(652, -2);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(31, 34);
            this.lblExit.TabIndex = 31;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // FrmHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 410);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvHerramientas);
            this.Controls.Add(this.txtBuscarHerramienta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHerramientas";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvHerramientas;
        private System.Windows.Forms.TextBox txtBuscarHerramienta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblExit;
    }
}