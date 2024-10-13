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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(507, 366);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(136, 29);
            this.btnDel.TabIndex = 30;
            this.btnDel.Text = "Eliminar Herramienta";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(274, 366);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 29);
            this.btnEditar.TabIndex = 29;
            this.btnEditar.Text = "Modificar Herramienta";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 366);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 29);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Agregar Herramientas";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // dtgvHerramientas
            // 
            this.dtgvHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHerramientas.Location = new System.Drawing.Point(8, 60);
            this.dtgvHerramientas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgvHerramientas.Name = "dtgvHerramientas";
            this.dtgvHerramientas.RowHeadersWidth = 51;
            this.dtgvHerramientas.RowTemplate.Height = 24;
            this.dtgvHerramientas.Size = new System.Drawing.Size(665, 287);
            this.dtgvHerramientas.TabIndex = 27;
            // 
            // txtBuscarHerramienta
            // 
            this.txtBuscarHerramienta.Location = new System.Drawing.Point(8, 28);
            this.txtBuscarHerramienta.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarHerramienta.Name = "txtBuscarHerramienta";
            this.txtBuscarHerramienta.Size = new System.Drawing.Size(667, 20);
            this.txtBuscarHerramienta.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "BUSCAR HERRAMIENTAS";
            // 
            // FrmHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 410);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvHerramientas);
            this.Controls.Add(this.txtBuscarHerramienta);
            this.Controls.Add(this.label1);
            this.Name = "FrmHerramientas";
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
    }
}