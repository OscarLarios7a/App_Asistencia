namespace AppAsistencia.Presentacion
{
    partial class Personal
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pctBuscar = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnlPaginado = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPaginaUltima = new System.Windows.Forms.Button();
            this.btnPaginaSiguiente = new System.Windows.Forms.Button();
            this.btnPaginaAnterior = new System.Windows.Forms.Button();
            this.btnPrimeraPagina = new System.Windows.Forms.Button();
            this.pnlRegistros = new System.Windows.Forms.Panel();
            this.pnlCargos = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnGuardarCargo = new System.Windows.Forms.Button();
            this.btnGuardarEditarCargo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtSueldoHora = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txtCargos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnGuardarPersonal = new System.Windows.Forms.Button();
            this.btnGuardarEditarPersonal = new System.Windows.Forms.Button();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.btnAgregarCargo = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlPaginado.SuspendLayout();
            this.pnlRegistros.SuspendLayout();
            this.pnlCargos.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.btnAll);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.pctBuscar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.Location = new System.Drawing.Point(491, 25);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(137, 39);
            this.btnAll.TabIndex = 20;
            this.btnAll.Text = "Mostrar Todos";
            this.btnAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAll.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnAgregar.FlatAppearance.BorderSize = 50;
            this.btnAgregar.Image = global::AppAsistencia.Properties.Resources.icons8_add_new_48px;
            this.btnAgregar.Location = new System.Drawing.Point(874, 14);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 58);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pctBuscar
            // 
            this.pctBuscar.Image = global::AppAsistencia.Properties.Resources.estadisticas;
            this.pctBuscar.Location = new System.Drawing.Point(439, 22);
            this.pctBuscar.Name = "pctBuscar";
            this.pctBuscar.Size = new System.Drawing.Size(37, 42);
            this.pctBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBuscar.TabIndex = 2;
            this.pctBuscar.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Location = new System.Drawing.Point(70, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 3);
            this.panel3.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.White;
            this.txtBuscar.Location = new System.Drawing.Point(70, 39);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(363, 19);
            this.txtBuscar.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(990, 517);
            this.dataGridView1.TabIndex = 1;
            // 
            // pnlPaginado
            // 
            this.pnlPaginado.Controls.Add(this.label9);
            this.pnlPaginado.Controls.Add(this.label8);
            this.pnlPaginado.Controls.Add(this.label7);
            this.pnlPaginado.Controls.Add(this.label6);
            this.pnlPaginado.Controls.Add(this.btnPaginaUltima);
            this.pnlPaginado.Controls.Add(this.btnPaginaSiguiente);
            this.pnlPaginado.Controls.Add(this.btnPaginaAnterior);
            this.pnlPaginado.Controls.Add(this.btnPrimeraPagina);
            this.pnlPaginado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPaginado.Location = new System.Drawing.Point(0, 603);
            this.pnlPaginado.Name = "pnlPaginado";
            this.pnlPaginado.Size = new System.Drawing.Size(990, 56);
            this.pnlPaginado.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Honeydew;
            this.label9.Location = new System.Drawing.Point(574, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Honeydew;
            this.label8.Location = new System.Drawing.Point(518, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "de";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Honeydew;
            this.label7.Location = new System.Drawing.Point(481, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Honeydew;
            this.label6.Location = new System.Drawing.Point(401, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Pagina";
            // 
            // btnPaginaUltima
            // 
            this.btnPaginaUltima.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaginaUltima.BackgroundImage = global::AppAsistencia.Properties.Resources.icons8_sort_left_48px___copia;
            this.btnPaginaUltima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaginaUltima.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnPaginaUltima.FlatAppearance.BorderSize = 0;
            this.btnPaginaUltima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaUltima.Location = new System.Drawing.Point(767, 6);
            this.btnPaginaUltima.Name = "btnPaginaUltima";
            this.btnPaginaUltima.Size = new System.Drawing.Size(84, 44);
            this.btnPaginaUltima.TabIndex = 24;
            this.btnPaginaUltima.Tag = "Ultima Pagina";
            this.btnPaginaUltima.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaginaUltima.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaginaUltima.UseVisualStyleBackColor = true;
            // 
            // btnPaginaSiguiente
            // 
            this.btnPaginaSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPaginaSiguiente.BackgroundImage = global::AppAsistencia.Properties.Resources.icons8_end_48px_1;
            this.btnPaginaSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaginaSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnPaginaSiguiente.FlatAppearance.BorderSize = 0;
            this.btnPaginaSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaSiguiente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPaginaSiguiente.Location = new System.Drawing.Point(654, 6);
            this.btnPaginaSiguiente.Name = "btnPaginaSiguiente";
            this.btnPaginaSiguiente.Size = new System.Drawing.Size(96, 44);
            this.btnPaginaSiguiente.TabIndex = 23;
            this.btnPaginaSiguiente.Tag = "Siguiente Pagina";
            this.btnPaginaSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaginaSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaginaSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnPaginaAnterior
            // 
            this.btnPaginaAnterior.BackgroundImage = global::AppAsistencia.Properties.Resources.icons8_skip_to_start_48px;
            this.btnPaginaAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaginaAnterior.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnPaginaAnterior.FlatAppearance.BorderSize = 0;
            this.btnPaginaAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaAnterior.Location = new System.Drawing.Point(240, 6);
            this.btnPaginaAnterior.Name = "btnPaginaAnterior";
            this.btnPaginaAnterior.Size = new System.Drawing.Size(80, 44);
            this.btnPaginaAnterior.TabIndex = 22;
            this.btnPaginaAnterior.Tag = "Anterior Pagina";
            this.btnPaginaAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaginaAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaginaAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimeraPagina
            // 
            this.btnPrimeraPagina.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPrimeraPagina.BackgroundImage = global::AppAsistencia.Properties.Resources.icons8_sort_left_48px;
            this.btnPrimeraPagina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrimeraPagina.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnPrimeraPagina.FlatAppearance.BorderSize = 0;
            this.btnPrimeraPagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeraPagina.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrimeraPagina.Location = new System.Drawing.Point(140, 6);
            this.btnPrimeraPagina.Name = "btnPrimeraPagina";
            this.btnPrimeraPagina.Size = new System.Drawing.Size(70, 44);
            this.btnPrimeraPagina.TabIndex = 21;
            this.btnPrimeraPagina.Tag = "Primera Pagina";
            this.btnPrimeraPagina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrimeraPagina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrimeraPagina.UseVisualStyleBackColor = false;
            // 
            // pnlRegistros
            // 
            this.pnlRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRegistros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pnlRegistros.Controls.Add(this.pnlCargos);
            this.pnlRegistros.Controls.Add(this.button1);
            this.pnlRegistros.Controls.Add(this.panel11);
            this.pnlRegistros.Controls.Add(this.cmbPais);
            this.pnlRegistros.Controls.Add(this.btnAgregarCargo);
            this.pnlRegistros.Controls.Add(this.panel10);
            this.pnlRegistros.Controls.Add(this.label5);
            this.pnlRegistros.Controls.Add(this.label4);
            this.pnlRegistros.Controls.Add(this.label3);
            this.pnlRegistros.Controls.Add(this.label2);
            this.pnlRegistros.Controls.Add(this.label1);
            this.pnlRegistros.Controls.Add(this.panel9);
            this.pnlRegistros.Controls.Add(this.txtSueldo);
            this.pnlRegistros.Controls.Add(this.panel8);
            this.pnlRegistros.Controls.Add(this.txtCargo);
            this.pnlRegistros.Controls.Add(this.panel7);
            this.pnlRegistros.Controls.Add(this.panel6);
            this.pnlRegistros.Controls.Add(this.txtIdentificacion);
            this.pnlRegistros.Controls.Add(this.panel5);
            this.pnlRegistros.Controls.Add(this.txtNombres);
            this.pnlRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegistros.Location = new System.Drawing.Point(18, 123);
            this.pnlRegistros.Name = "pnlRegistros";
            this.pnlRegistros.Size = new System.Drawing.Size(959, 474);
            this.pnlRegistros.TabIndex = 3;
            // 
            // pnlCargos
            // 
            this.pnlCargos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCargos.Controls.Add(this.panel15);
            this.pnlCargos.Controls.Add(this.label12);
            this.pnlCargos.Controls.Add(this.label11);
            this.pnlCargos.Controls.Add(this.panel13);
            this.pnlCargos.Controls.Add(this.txtSueldoHora);
            this.pnlCargos.Controls.Add(this.panel14);
            this.pnlCargos.Controls.Add(this.txtCargos);
            this.pnlCargos.Location = new System.Drawing.Point(599, 186);
            this.pnlCargos.Name = "pnlCargos";
            this.pnlCargos.Size = new System.Drawing.Size(357, 174);
            this.pnlCargos.TabIndex = 25;
            this.pnlCargos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.btnGuardarCargo);
            this.panel15.Controls.Add(this.btnGuardarEditarCargo);
            this.panel15.Location = new System.Drawing.Point(37, 84);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(281, 67);
            this.panel15.TabIndex = 24;
            // 
            // btnGuardarCargo
            // 
            this.btnGuardarCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarCargo.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnGuardarCargo.FlatAppearance.BorderSize = 50;
            this.btnGuardarCargo.Image = global::AppAsistencia.Properties.Resources.icons8_add_new_48px;
            this.btnGuardarCargo.Location = new System.Drawing.Point(8, 6);
            this.btnGuardarCargo.Name = "btnGuardarCargo";
            this.btnGuardarCargo.Size = new System.Drawing.Size(132, 58);
            this.btnGuardarCargo.TabIndex = 20;
            this.btnGuardarCargo.Text = "Guardar";
            this.btnGuardarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCargo.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEditarCargo
            // 
            this.btnGuardarEditarCargo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEditarCargo.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnGuardarEditarCargo.FlatAppearance.BorderSize = 50;
            this.btnGuardarEditarCargo.Image = global::AppAsistencia.Properties.Resources.icons8_add_new_48px;
            this.btnGuardarEditarCargo.Location = new System.Drawing.Point(146, 6);
            this.btnGuardarEditarCargo.Name = "btnGuardarEditarCargo";
            this.btnGuardarEditarCargo.Size = new System.Drawing.Size(132, 58);
            this.btnGuardarEditarCargo.TabIndex = 21;
            this.btnGuardarEditarCargo.Text = "Guardar";
            this.btnGuardarEditarCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEditarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEditarCargo.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Honeydew;
            this.label12.Location = new System.Drawing.Point(14, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Sueldo por Hora:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Honeydew;
            this.label11.Location = new System.Drawing.Point(87, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cargo:";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Honeydew;
            this.panel13.Location = new System.Drawing.Point(146, 77);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(194, 1);
            this.panel13.TabIndex = 17;
            // 
            // txtSueldoHora
            // 
            this.txtSueldoHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtSueldoHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldoHora.ForeColor = System.Drawing.Color.White;
            this.txtSueldoHora.Location = new System.Drawing.Point(146, 54);
            this.txtSueldoHora.Name = "txtSueldoHora";
            this.txtSueldoHora.Size = new System.Drawing.Size(194, 19);
            this.txtSueldoHora.TabIndex = 16;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Honeydew;
            this.panel14.Location = new System.Drawing.Point(149, 35);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(194, 1);
            this.panel14.TabIndex = 15;
            // 
            // txtCargos
            // 
            this.txtCargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtCargos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargos.ForeColor = System.Drawing.Color.White;
            this.txtCargos.Location = new System.Drawing.Point(149, 13);
            this.txtCargos.Name = "txtCargos";
            this.txtCargos.Size = new System.Drawing.Size(194, 19);
            this.txtCargos.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::AppAsistencia.Properties.Resources.icons8_undo_64px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(880, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 72);
            this.button1.TabIndex = 24;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnGuardarPersonal);
            this.panel11.Controls.Add(this.btnGuardarEditarPersonal);
            this.panel11.Location = new System.Drawing.Point(34, 312);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(294, 64);
            this.panel11.TabIndex = 23;
            // 
            // btnGuardarPersonal
            // 
            this.btnGuardarPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnGuardarPersonal.FlatAppearance.BorderSize = 50;
            this.btnGuardarPersonal.Image = global::AppAsistencia.Properties.Resources.icons8_add_new_48px;
            this.btnGuardarPersonal.Location = new System.Drawing.Point(6, 3);
            this.btnGuardarPersonal.Name = "btnGuardarPersonal";
            this.btnGuardarPersonal.Size = new System.Drawing.Size(132, 58);
            this.btnGuardarPersonal.TabIndex = 20;
            this.btnGuardarPersonal.Text = "Guardar";
            this.btnGuardarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarPersonal.UseVisualStyleBackColor = true;
            // 
            // btnGuardarEditarPersonal
            // 
            this.btnGuardarEditarPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEditarPersonal.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnGuardarEditarPersonal.FlatAppearance.BorderSize = 50;
            this.btnGuardarEditarPersonal.Image = global::AppAsistencia.Properties.Resources.icons8_add_new_48px;
            this.btnGuardarEditarPersonal.Location = new System.Drawing.Point(141, 3);
            this.btnGuardarEditarPersonal.Name = "btnGuardarEditarPersonal";
            this.btnGuardarEditarPersonal.Size = new System.Drawing.Size(132, 58);
            this.btnGuardarEditarPersonal.TabIndex = 21;
            this.btnGuardarEditarPersonal.Text = "Guardar";
            this.btnGuardarEditarPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarEditarPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarEditarPersonal.UseVisualStyleBackColor = true;
            // 
            // cmbPais
            // 
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(189, 139);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(261, 28);
            this.cmbPais.TabIndex = 22;
            // 
            // btnAgregarCargo
            // 
            this.btnAgregarCargo.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarCargo.FlatAppearance.BorderColor = System.Drawing.Color.Honeydew;
            this.btnAgregarCargo.FlatAppearance.BorderSize = 0;
            this.btnAgregarCargo.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCargo.Location = new System.Drawing.Point(456, 186);
            this.btnAgregarCargo.Name = "btnAgregarCargo";
            this.btnAgregarCargo.Size = new System.Drawing.Size(137, 39);
            this.btnAgregarCargo.TabIndex = 19;
            this.btnAgregarCargo.Text = "+ Agregar Cargo";
            this.btnAgregarCargo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCargo.UseVisualStyleBackColor = false;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(28, 474);
            this.panel10.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Honeydew;
            this.label5.Location = new System.Drawing.Point(53, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sueldo por Hora:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Honeydew;
            this.label4.Location = new System.Drawing.Point(126, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(140, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "País:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Honeydew;
            this.label2.Location = new System.Drawing.Point(75, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Identificación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombres y Apellidos:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Honeydew;
            this.panel9.Location = new System.Drawing.Point(188, 277);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(262, 3);
            this.panel9.TabIndex = 11;
            // 
            // txtSueldo
            // 
            this.txtSueldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtSueldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.ForeColor = System.Drawing.Color.White;
            this.txtSueldo.Location = new System.Drawing.Point(188, 255);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(262, 19);
            this.txtSueldo.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Honeydew;
            this.panel8.Location = new System.Drawing.Point(188, 222);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(262, 3);
            this.panel8.TabIndex = 9;
            // 
            // txtCargo
            // 
            this.txtCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.ForeColor = System.Drawing.Color.White;
            this.txtCargo.Location = new System.Drawing.Point(188, 200);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(262, 19);
            this.txtCargo.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Honeydew;
            this.panel7.Location = new System.Drawing.Point(189, 167);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(262, 3);
            this.panel7.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Honeydew;
            this.panel6.Location = new System.Drawing.Point(188, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(262, 3);
            this.panel6.TabIndex = 5;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.ForeColor = System.Drawing.Color.White;
            this.txtIdentificacion.Location = new System.Drawing.Point(188, 85);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(262, 19);
            this.txtIdentificacion.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Location = new System.Drawing.Point(188, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(262, 3);
            this.panel5.TabIndex = 3;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.White;
            this.txtNombres.Location = new System.Drawing.Point(188, 34);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(262, 19);
            this.txtNombres.TabIndex = 2;
            // 
            // Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Controls.Add(this.pnlRegistros);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlPaginado);
            this.Controls.Add(this.panel1);
            this.Name = "Personal";
            this.Size = new System.Drawing.Size(990, 659);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlPaginado.ResumeLayout(false);
            this.pnlPaginado.PerformLayout();
            this.pnlRegistros.ResumeLayout(false);
            this.pnlRegistros.PerformLayout();
            this.pnlCargos.ResumeLayout(false);
            this.pnlCargos.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlPaginado;
        private System.Windows.Forms.PictureBox pctBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel pnlRegistros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnGuardarEditarPersonal;
        private System.Windows.Forms.Button btnGuardarPersonal;
        private System.Windows.Forms.Button btnAgregarCargo;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPaginaUltima;
        private System.Windows.Forms.Button btnPaginaSiguiente;
        private System.Windows.Forms.Button btnPaginaAnterior;
        private System.Windows.Forms.Button btnPrimeraPagina;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlCargos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtSueldoHora;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txtCargos;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnGuardarCargo;
        private System.Windows.Forms.Button btnGuardarEditarCargo;
    }
}
