namespace ProyectoPrueba.Tarea
{
    partial class FrmTarea
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
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtCostoReal = new System.Windows.Forms.TextBox();
            this.txtHorasReal = new System.Windows.Forms.TextBox();
            this.txtCostoEst = new System.Windows.Forms.TextBox();
            this.txtHorasEst = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCostoRealT = new System.Windows.Forms.Label();
            this.lblHorasReal = new System.Windows.Forms.Label();
            this.lblCostoEstT = new System.Windows.Forms.Label();
            this.lblHorasEstT = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.DgvTarea = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblIdProy = new System.Windows.Forms.Label();
            this.txtIdProyecto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdTarea = new System.Windows.Forms.Label();
            this.btnCerrarTarea = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarea)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(124, 113);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(137, 20);
            this.DtpFecha.TabIndex = 4;
            // 
            // txtCostoReal
            // 
            this.txtCostoReal.Location = new System.Drawing.Point(400, 149);
            this.txtCostoReal.Name = "txtCostoReal";
            this.txtCostoReal.Size = new System.Drawing.Size(100, 20);
            this.txtCostoReal.TabIndex = 7;
            // 
            // txtHorasReal
            // 
            this.txtHorasReal.Location = new System.Drawing.Point(124, 150);
            this.txtHorasReal.Name = "txtHorasReal";
            this.txtHorasReal.Size = new System.Drawing.Size(56, 20);
            this.txtHorasReal.TabIndex = 6;
            // 
            // txtCostoEst
            // 
            this.txtCostoEst.Location = new System.Drawing.Point(654, 68);
            this.txtCostoEst.Name = "txtCostoEst";
            this.txtCostoEst.Size = new System.Drawing.Size(122, 20);
            this.txtCostoEst.TabIndex = 3;
            // 
            // txtHorasEst
            // 
            this.txtHorasEst.Location = new System.Drawing.Point(400, 67);
            this.txtHorasEst.Name = "txtHorasEst";
            this.txtHorasEst.Size = new System.Drawing.Size(100, 20);
            this.txtHorasEst.TabIndex = 2;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(124, 67);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(137, 20);
            this.txtDescrip.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(36, 119);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 13);
            this.lblFecha.TabIndex = 33;
            this.lblFecha.Text = "Fecha Final";
            // 
            // lblCostoRealT
            // 
            this.lblCostoRealT.AutoSize = true;
            this.lblCostoRealT.Location = new System.Drawing.Point(333, 156);
            this.lblCostoRealT.Name = "lblCostoRealT";
            this.lblCostoRealT.Size = new System.Drawing.Size(59, 13);
            this.lblCostoRealT.TabIndex = 32;
            this.lblCostoRealT.Text = "Costo Real";
            // 
            // lblHorasReal
            // 
            this.lblHorasReal.AutoSize = true;
            this.lblHorasReal.Location = new System.Drawing.Point(35, 157);
            this.lblHorasReal.Name = "lblHorasReal";
            this.lblHorasReal.Size = new System.Drawing.Size(71, 13);
            this.lblHorasReal.TabIndex = 31;
            this.lblHorasReal.Text = "Horas Reales";
            // 
            // lblCostoEstT
            // 
            this.lblCostoEstT.AutoSize = true;
            this.lblCostoEstT.Location = new System.Drawing.Point(570, 75);
            this.lblCostoEstT.Name = "lblCostoEstT";
            this.lblCostoEstT.Size = new System.Drawing.Size(80, 13);
            this.lblCostoEstT.TabIndex = 30;
            this.lblCostoEstT.Text = "Costo Estimado";
            // 
            // lblHorasEstT
            // 
            this.lblHorasEstT.AutoSize = true;
            this.lblHorasEstT.Location = new System.Drawing.Point(306, 74);
            this.lblHorasEstT.Name = "lblHorasEstT";
            this.lblHorasEstT.Size = new System.Drawing.Size(86, 13);
            this.lblHorasEstT.TabIndex = 29;
            this.lblHorasEstT.Text = "Horas Estimadas";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(35, 75);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(63, 13);
            this.lblDescrip.TabIndex = 28;
            this.lblDescrip.Text = "Descripción";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(400, 111);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(50, 20);
            this.txtEstado.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(352, 118);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 40;
            this.lblEstado.Text = "Estado";
            // 
            // DgvTarea
            // 
            this.DgvTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.DgvTarea.Location = new System.Drawing.Point(26, 222);
            this.DgvTarea.Name = "DgvTarea";
            this.DgvTarea.Size = new System.Drawing.Size(750, 216);
            this.DgvTarea.TabIndex = 42;
            this.DgvTarea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTarea_CellContentClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregar.Location = new System.Drawing.Point(375, 193);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificar.Location = new System.Drawing.Point(465, 193);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminar.Location = new System.Drawing.Point(701, 193);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblIdProy
            // 
            this.lblIdProy.AutoSize = true;
            this.lblIdProy.Location = new System.Drawing.Point(35, 45);
            this.lblIdProy.Name = "lblIdProy";
            this.lblIdProy.Size = new System.Drawing.Size(63, 13);
            this.lblIdProy.TabIndex = 46;
            this.lblIdProy.Text = "ID Proyecto";
            // 
            // txtIdProyecto
            // 
            this.txtIdProyecto.Enabled = false;
            this.txtIdProyecto.Location = new System.Drawing.Point(124, 38);
            this.txtIdProyecto.Name = "txtIdProyecto";
            this.txtIdProyecto.Size = new System.Drawing.Size(27, 20);
            this.txtIdProyecto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // lblIdTarea
            // 
            this.lblIdTarea.AutoSize = true;
            this.lblIdTarea.Location = new System.Drawing.Point(309, 202);
            this.lblIdTarea.Name = "lblIdTarea";
            this.lblIdTarea.Size = new System.Drawing.Size(35, 13);
            this.lblIdTarea.TabIndex = 48;
            this.lblIdTarea.Text = "label2";
            this.lblIdTarea.Visible = false;
            // 
            // btnCerrarTarea
            // 
            this.btnCerrarTarea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCerrarTarea.Location = new System.Drawing.Point(558, 193);
            this.btnCerrarTarea.Name = "btnCerrarTarea";
            this.btnCerrarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarTarea.TabIndex = 49;
            this.btnCerrarTarea.Text = "Cerrar Tarea";
            this.btnCerrarTarea.UseVisualStyleBackColor = false;
            this.btnCerrarTarea.Click += new System.EventHandler(this.btnCerrarTarea_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 31);
            this.label2.TabIndex = 50;
            this.label2.Text = "ABM Tarea";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Width = 40;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Proyecto";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id Tarea";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "descripcion";
            this.Column3.HeaderText = "Descripción";
            this.Column3.Name = "Column3";
            this.Column3.Width = 160;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "horas_estimadas";
            this.Column4.HeaderText = "Horas Estimadas";
            this.Column4.Name = "Column4";
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "costo_estimado";
            this.Column5.HeaderText = "Costo Estimado";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "horas_reales";
            this.Column6.HeaderText = "Horas Reales";
            this.Column6.Name = "Column6";
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "costo_real";
            this.Column7.HeaderText = "Costo Real";
            this.Column7.Name = "Column7";
            this.Column7.Width = 120;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "fecha_final";
            this.Column8.HeaderText = "Fecha Finalización";
            this.Column8.Name = "Column8";
            this.Column8.Width = 70;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "estado";
            this.Column9.HeaderText = "Estado";
            this.Column9.Name = "Column9";
            this.Column9.Width = 55;
            // 
            // FrmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCerrarTarea);
            this.Controls.Add(this.lblIdTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIdProyecto);
            this.Controls.Add(this.lblIdProy);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.DgvTarea);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.txtCostoReal);
            this.Controls.Add(this.txtHorasReal);
            this.Controls.Add(this.txtCostoEst);
            this.Controls.Add(this.txtHorasEst);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCostoRealT);
            this.Controls.Add(this.lblHorasReal);
            this.Controls.Add(this.lblCostoEstT);
            this.Controls.Add(this.lblHorasEstT);
            this.Controls.Add(this.lblDescrip);
            this.Name = "FrmTarea";
            this.Text = "FrmTarea";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTarea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.TextBox txtCostoReal;
        private System.Windows.Forms.TextBox txtHorasReal;
        private System.Windows.Forms.TextBox txtCostoEst;
        private System.Windows.Forms.TextBox txtHorasEst;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCostoRealT;
        private System.Windows.Forms.Label lblHorasReal;
        private System.Windows.Forms.Label lblCostoEstT;
        private System.Windows.Forms.Label lblHorasEstT;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.DataGridView DgvTarea;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblIdProy;
        private System.Windows.Forms.TextBox txtIdProyecto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdTarea;
        private System.Windows.Forms.Button btnCerrarTarea;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}