namespace ProyectoPrueba.Proyecto
{
    partial class FrmProyecto
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblProp = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cbPropietario = new System.Windows.Forms.ComboBox();
            this.cbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblTiempoEstP = new System.Windows.Forms.Label();
            this.lblCostoEstP = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.txtIdProp = new System.Windows.Forms.TextBox();
            this.txtTiempoEstP = new System.Windows.Forms.TextBox();
            this.txtCostoEstP = new System.Windows.Forms.TextBox();
            this.DgvProyecto = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdProyecto = new System.Windows.Forms.Label();
            this.btnPropietario = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProyecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProyecto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(47, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblProp
            // 
            this.lblProp.AutoSize = true;
            this.lblProp.Location = new System.Drawing.Point(267, 56);
            this.lblProp.Name = "lblProp";
            this.lblProp.Size = new System.Drawing.Size(57, 13);
            this.lblProp.TabIndex = 1;
            this.lblProp.Text = "Propietario";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Location = new System.Drawing.Point(515, 56);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(54, 13);
            this.lblEmpleado.TabIndex = 2;
            this.lblEmpleado.Text = "Empleado";
            // 
            // cbPropietario
            // 
            this.cbPropietario.FormattingEnabled = true;
            this.cbPropietario.Location = new System.Drawing.Point(361, 48);
            this.cbPropietario.Name = "cbPropietario";
            this.cbPropietario.Size = new System.Drawing.Size(121, 21);
            this.cbPropietario.TabIndex = 3;
            this.cbPropietario.SelectedIndexChanged += new System.EventHandler(this.cbPropietario_SelectedIndexChanged);
            // 
            // cbEmpleado
            // 
            this.cbEmpleado.FormattingEnabled = true;
            this.cbEmpleado.Location = new System.Drawing.Point(608, 48);
            this.cbEmpleado.Name = "cbEmpleado";
            this.cbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cbEmpleado.TabIndex = 4;
            this.cbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbEmpleado_SelectedIndexChanged);
            // 
            // lblTiempoEstP
            // 
            this.lblTiempoEstP.AutoSize = true;
            this.lblTiempoEstP.Location = new System.Drawing.Point(47, 127);
            this.lblTiempoEstP.Name = "lblTiempoEstP";
            this.lblTiempoEstP.Size = new System.Drawing.Size(87, 13);
            this.lblTiempoEstP.TabIndex = 5;
            this.lblTiempoEstP.Text = "Tiempo estimado";
            // 
            // lblCostoEstP
            // 
            this.lblCostoEstP.AutoSize = true;
            this.lblCostoEstP.Location = new System.Drawing.Point(267, 127);
            this.lblCostoEstP.Name = "lblCostoEstP";
            this.lblCostoEstP.Size = new System.Drawing.Size(80, 13);
            this.lblCostoEstP.TabIndex = 6;
            this.lblCostoEstP.Text = "Costo Estimado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.Location = new System.Drawing.Point(575, 49);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(22, 20);
            this.txtIdEmpleado.TabIndex = 9;
            // 
            // txtIdProp
            // 
            this.txtIdProp.Enabled = false;
            this.txtIdProp.Location = new System.Drawing.Point(324, 49);
            this.txtIdProp.Name = "txtIdProp";
            this.txtIdProp.Size = new System.Drawing.Size(22, 20);
            this.txtIdProp.TabIndex = 8;
            // 
            // txtTiempoEstP
            // 
            this.txtTiempoEstP.Location = new System.Drawing.Point(136, 120);
            this.txtTiempoEstP.Name = "txtTiempoEstP";
            this.txtTiempoEstP.Size = new System.Drawing.Size(100, 20);
            this.txtTiempoEstP.TabIndex = 10;
            // 
            // txtCostoEstP
            // 
            this.txtCostoEstP.Location = new System.Drawing.Point(361, 120);
            this.txtCostoEstP.Name = "txtCostoEstP";
            this.txtCostoEstP.Size = new System.Drawing.Size(100, 20);
            this.txtCostoEstP.TabIndex = 11;
            // 
            // DgvProyecto
            // 
            this.DgvProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProyecto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.IdProyecto,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.DgvProyecto.Location = new System.Drawing.Point(85, 195);
            this.DgvProyecto.Name = "DgvProyecto";
            this.DgvProyecto.Size = new System.Drawing.Size(644, 243);
            this.DgvProyecto.TabIndex = 19;
            this.DgvProyecto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProyecto_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(330, 166);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 28;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(411, 166);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 29;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(492, 166);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuardar.Location = new System.Drawing.Point(624, 166);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 23);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Agregar Tarea";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // lblIdProyecto
            // 
            this.lblIdProyecto.AutoSize = true;
            this.lblIdProyecto.Location = new System.Drawing.Point(123, 166);
            this.lblIdProyecto.Name = "lblIdProyecto";
            this.lblIdProyecto.Size = new System.Drawing.Size(35, 13);
            this.lblIdProyecto.TabIndex = 33;
            this.lblIdProyecto.Text = "label2";
            this.lblIdProyecto.Visible = false;
            // 
            // btnPropietario
            // 
            this.btnPropietario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPropietario.Location = new System.Drawing.Point(361, 76);
            this.btnPropietario.Name = "btnPropietario";
            this.btnPropietario.Size = new System.Drawing.Size(121, 23);
            this.btnPropietario.TabIndex = 34;
            this.btnPropietario.Text = "Agregar Propietario";
            this.btnPropietario.UseVisualStyleBackColor = false;
            this.btnPropietario.Click += new System.EventHandler(this.btnPropietario_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEmpleado.Location = new System.Drawing.Point(608, 76);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(121, 23);
            this.btnEmpleado.TabIndex = 35;
            this.btnEmpleado.Text = "Agregar Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(318, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 31);
            this.label2.TabIndex = 36;
            this.label2.Text = "ABM Proyecto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Width = 40;
            // 
            // IdProyecto
            // 
            this.IdProyecto.DataPropertyName = "id_proyecto";
            this.IdProyecto.HeaderText = "Id Proyecto";
            this.IdProyecto.Name = "IdProyecto";
            this.IdProyecto.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "nombre";
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "monto_estimado";
            this.Column3.HeaderText = "Costo Estimado";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tiempo_estimado";
            this.Column4.HeaderText = "Tiempo Estimado";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "id_propietario_FK";
            this.Column5.HeaderText = "Id Propietario";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "legajo_FK";
            this.Column6.HeaderText = "Id Empleado";
            this.Column6.Name = "Column6";
            // 
            // FrmProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnPropietario);
            this.Controls.Add(this.lblIdProyecto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.DgvProyecto);
            this.Controls.Add(this.txtCostoEstP);
            this.Controls.Add(this.txtTiempoEstP);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.txtIdProp);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCostoEstP);
            this.Controls.Add(this.lblTiempoEstP);
            this.Controls.Add(this.cbEmpleado);
            this.Controls.Add(this.cbPropietario);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblProp);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmProyecto";
            this.Text = "FrmProyecto";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProyecto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblProp;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cbPropietario;
        private System.Windows.Forms.ComboBox cbEmpleado;
        private System.Windows.Forms.Label lblTiempoEstP;
        private System.Windows.Forms.Label lblCostoEstP;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.TextBox txtIdProp;
        private System.Windows.Forms.TextBox txtTiempoEstP;
        private System.Windows.Forms.TextBox txtCostoEstP;
        private System.Windows.Forms.DataGridView DgvProyecto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdProyecto;
        private System.Windows.Forms.Button btnPropietario;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProyecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}