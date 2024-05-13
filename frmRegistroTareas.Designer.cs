namespace RegistroTareas.pry
{
    partial class frmRegistroTareas
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
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpNueva = new System.Windows.Forms.DateTimePicker();
            this.cmbNueva = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTarea = new System.Windows.Forms.Button();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbEntreFechas = new System.Windows.Forms.ComboBox();
            this.btnBuscarFechas = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbFecha = new System.Windows.Forms.ComboBox();
            this.btnUnaFecha = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpUnaFecha = new System.Windows.Forms.DateTimePicker();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(185, 33);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(190, 26);
            this.txtTarea.TabIndex = 0;
            this.txtTarea.TextChanged += new System.EventHandler(this.txtTarea_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion de tarea:";
            // 
            // dtpNueva
            // 
            this.dtpNueva.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNueva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNueva.Location = new System.Drawing.Point(185, 87);
            this.dtpNueva.Name = "dtpNueva";
            this.dtpNueva.Size = new System.Drawing.Size(190, 26);
            this.dtpNueva.TabIndex = 2;
            // 
            // cmbNueva
            // 
            this.cmbNueva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNueva.FormattingEnabled = true;
            this.cmbNueva.Location = new System.Drawing.Point(185, 132);
            this.cmbNueva.Name = "cmbNueva";
            this.cmbNueva.Size = new System.Drawing.Size(190, 28);
            this.cmbNueva.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estado de tareas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha:";
            // 
            // btnTarea
            // 
            this.btnTarea.Enabled = false;
            this.btnTarea.Location = new System.Drawing.Point(237, 185);
            this.btnTarea.Name = "btnTarea";
            this.btnTarea.Size = new System.Drawing.Size(138, 33);
            this.btnTarea.TabIndex = 6;
            this.btnTarea.Text = "Agregar Tarea";
            this.btnTarea.UseVisualStyleBackColor = true;
            this.btnTarea.Click += new System.EventHandler(this.btnTarea_Click);
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Location = new System.Drawing.Point(497, 44);
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersWidth = 62;
            this.dgvTareas.RowTemplate.Height = 28;
            this.dgvTareas.Size = new System.Drawing.Size(643, 647);
            this.dgvTareas.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTarea);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbNueva);
            this.groupBox1.Controls.Add(this.dtpNueva);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTarea);
            this.groupBox1.Location = new System.Drawing.Point(48, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 232);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva tarea";
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(186, 90);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(190, 26);
            this.dtpDesde.TabIndex = 9;
            // 
            // dtpHasta
            // 
            this.dtpHasta.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(186, 133);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(190, 26);
            this.dtpHasta.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbEntreFechas);
            this.groupBox2.Controls.Add(this.btnBuscarFechas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpHasta);
            this.groupBox2.Controls.Add(this.dtpDesde);
            this.groupBox2.Location = new System.Drawing.Point(47, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 228);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar entre fechas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Estado de tareas:";
            // 
            // cmbEntreFechas
            // 
            this.cmbEntreFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntreFechas.FormattingEnabled = true;
            this.cmbEntreFechas.Location = new System.Drawing.Point(186, 41);
            this.cmbEntreFechas.Name = "cmbEntreFechas";
            this.cmbEntreFechas.Size = new System.Drawing.Size(190, 28);
            this.cmbEntreFechas.TabIndex = 13;
            // 
            // btnBuscarFechas
            // 
            this.btnBuscarFechas.Enabled = false;
            this.btnBuscarFechas.Location = new System.Drawing.Point(238, 178);
            this.btnBuscarFechas.Name = "btnBuscarFechas";
            this.btnBuscarFechas.Size = new System.Drawing.Size(138, 33);
            this.btnBuscarFechas.TabIndex = 7;
            this.btnBuscarFechas.Text = "Buscar";
            this.btnBuscarFechas.UseVisualStyleBackColor = true;
            this.btnBuscarFechas.Click += new System.EventHandler(this.btnBuscarFechas_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hasta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Desde:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cmbFecha);
            this.groupBox3.Controls.Add(this.btnUnaFecha);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dtpUnaFecha);
            this.groupBox3.Location = new System.Drawing.Point(47, 549);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 201);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar en fecha ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Estado de tareas:";
            // 
            // cmbFecha
            // 
            this.cmbFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFecha.FormattingEnabled = true;
            this.cmbFecha.Location = new System.Drawing.Point(186, 48);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(190, 28);
            this.cmbFecha.TabIndex = 15;
            // 
            // btnUnaFecha
            // 
            this.btnUnaFecha.Enabled = false;
            this.btnUnaFecha.Location = new System.Drawing.Point(238, 137);
            this.btnUnaFecha.Name = "btnUnaFecha";
            this.btnUnaFecha.Size = new System.Drawing.Size(138, 33);
            this.btnUnaFecha.TabIndex = 7;
            this.btnUnaFecha.Text = "Buscar";
            this.btnUnaFecha.UseVisualStyleBackColor = true;
            this.btnUnaFecha.Click += new System.EventHandler(this.btnUnaFecha_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "En el dia: ";
            // 
            // dtpUnaFecha
            // 
            this.dtpUnaFecha.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpUnaFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUnaFecha.Location = new System.Drawing.Point(186, 91);
            this.dtpUnaFecha.Name = "dtpUnaFecha";
            this.dtpUnaFecha.Size = new System.Drawing.Size(190, 26);
            this.dtpUnaFecha.TabIndex = 9;
            // 
            // btnListar
            // 
            this.btnListar.Enabled = false;
            this.btnListar.Location = new System.Drawing.Point(910, 717);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(230, 33);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "Listar todas las tareas";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmRegistroTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 768);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTareas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de tareas";
            this.Load += new System.EventHandler(this.frmRegistroTareas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNueva;
        private System.Windows.Forms.ComboBox cmbNueva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTarea;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarFechas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUnaFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpUnaFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEntreFechas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbFecha;
        private System.Windows.Forms.Button btnListar;
    }
}

