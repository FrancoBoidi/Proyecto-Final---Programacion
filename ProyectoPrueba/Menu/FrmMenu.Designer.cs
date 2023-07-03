namespace ProyectoPrueba.Menu
{
    partial class FrmMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.btnFuncion = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnProp = new System.Windows.Forms.Button();
            this.btnProyecto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.btnFuncion);
            this.panel1.Controls.Add(this.btnEmpleado);
            this.panel1.Controls.Add(this.btnProp);
            this.panel1.Controls.Add(this.btnProyecto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(167, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 338);
            this.panel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(276, 218);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 34);
            this.button6.TabIndex = 6;
            this.button6.Text = "ABM Observación";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnFuncion
            // 
            this.btnFuncion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFuncion.Location = new System.Drawing.Point(276, 166);
            this.btnFuncion.Name = "btnFuncion";
            this.btnFuncion.Size = new System.Drawing.Size(130, 34);
            this.btnFuncion.TabIndex = 5;
            this.btnFuncion.Text = "ABM Función";
            this.btnFuncion.UseVisualStyleBackColor = false;
            this.btnFuncion.Click += new System.EventHandler(this.btnFuncion_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEmpleado.Location = new System.Drawing.Point(276, 116);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(130, 34);
            this.btnEmpleado.TabIndex = 4;
            this.btnEmpleado.Text = "ABM Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnProp
            // 
            this.btnProp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProp.Location = new System.Drawing.Point(74, 192);
            this.btnProp.Name = "btnProp";
            this.btnProp.Size = new System.Drawing.Size(130, 34);
            this.btnProp.TabIndex = 3;
            this.btnProp.Text = "ABM Propietario";
            this.btnProp.UseVisualStyleBackColor = false;
            this.btnProp.Click += new System.EventHandler(this.btnProp_Click);
            // 
            // btnProyecto
            // 
            this.btnProyecto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProyecto.Location = new System.Drawing.Point(74, 143);
            this.btnProyecto.Name = "btnProyecto";
            this.btnProyecto.Size = new System.Drawing.Size(130, 34);
            this.btnProyecto.TabIndex = 1;
            this.btnProyecto.Text = "ABM Proyecto";
            this.btnProyecto.UseVisualStyleBackColor = false;
            this.btnProyecto.Click += new System.EventHandler(this.btnProyecto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 11);
            this.label1.MaximumSize = new System.Drawing.Size(200, 50);
            this.label1.MinimumSize = new System.Drawing.Size(200, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENÚ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnFuncion;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnProp;
        private System.Windows.Forms.Button btnProyecto;
    }
}