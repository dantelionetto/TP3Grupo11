namespace TP3Grupo11
{
    partial class Principal
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtCantDias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHasta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProb10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProb8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProb7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProb1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProb2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProb5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProb6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPrecio10 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrecio8 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrecio7 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPrecio5 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtPrecio6 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gdrSimulacion = new System.Windows.Forms.DataGridView();
            this.diaTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndClientesTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroRandomDemandaTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demandaTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDemandaTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobranteDiarioTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.promedioSobranteTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadDiariaTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadPromedioTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSimulacion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.groupBox5.Controls.Add(this.btnLimpiar);
            this.groupBox5.Controls.Add(this.btnGenerar);
            this.groupBox5.Controls.Add(this.txtDesde);
            this.groupBox5.Controls.Add(this.txtCantDias);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtHasta);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(14, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(268, 162);
            this.groupBox5.TabIndex = 53;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SIMULACIONES";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(151, 123);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(45, 123);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 15;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(121, 54);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(116, 20);
            this.txtDesde.TabIndex = 8;
            // 
            // txtCantDias
            // 
            this.txtCantDias.Location = new System.Drawing.Point(121, 24);
            this.txtCantDias.Name = "txtCantDias";
            this.txtCantDias.Size = new System.Drawing.Size(116, 20);
            this.txtCantDias.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad de dias (X)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Desde el dia ( i )";
            // 
            // txtHasta
            // 
            this.txtHasta.Location = new System.Drawing.Point(121, 84);
            this.txtHasta.Name = "txtHasta";
            this.txtHasta.Size = new System.Drawing.Size(116, 20);
            this.txtHasta.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Iteraciones ( j )";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtProb10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtProb8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtProb7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtProb1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtProb2);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtProb5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtProb6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(306, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 78);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DEMANDA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(447, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "10";
            // 
            // txtProb10
            // 
            this.txtProb10.Location = new System.Drawing.Point(443, 46);
            this.txtProb10.Name = "txtProb10";
            this.txtProb10.Size = new System.Drawing.Size(35, 20);
            this.txtProb10.TabIndex = 30;
            this.txtProb10.Text = "0,05";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(389, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "8";
            // 
            // txtProb8
            // 
            this.txtProb8.Location = new System.Drawing.Point(383, 46);
            this.txtProb8.Name = "txtProb8";
            this.txtProb8.Size = new System.Drawing.Size(35, 20);
            this.txtProb8.TabIndex = 28;
            this.txtProb8.Text = "0,05";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "7";
            // 
            // txtProb7
            // 
            this.txtProb7.Location = new System.Drawing.Point(323, 46);
            this.txtProb7.Name = "txtProb7";
            this.txtProb7.Size = new System.Drawing.Size(35, 20);
            this.txtProb7.TabIndex = 26;
            this.txtProb7.Text = "0,1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Probabilidad (%)";
            // 
            // txtProb1
            // 
            this.txtProb1.Location = new System.Drawing.Point(96, 46);
            this.txtProb1.Name = "txtProb1";
            this.txtProb1.Size = new System.Drawing.Size(35, 20);
            this.txtProb1.TabIndex = 16;
            this.txtProb1.Text = "0,1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "2";
            // 
            // txtProb2
            // 
            this.txtProb2.Location = new System.Drawing.Point(152, 46);
            this.txtProb2.Name = "txtProb2";
            this.txtProb2.Size = new System.Drawing.Size(35, 20);
            this.txtProb2.TabIndex = 18;
            this.txtProb2.Text = "0,2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "6";
            // 
            // txtProb5
            // 
            this.txtProb5.Location = new System.Drawing.Point(210, 46);
            this.txtProb5.Name = "txtProb5";
            this.txtProb5.Size = new System.Drawing.Size(35, 20);
            this.txtProb5.TabIndex = 20;
            this.txtProb5.Text = "0,4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "1";
            // 
            // txtProb6
            // 
            this.txtProb6.Location = new System.Drawing.Point(265, 46);
            this.txtProb6.Name = "txtProb6";
            this.txtProb6.Size = new System.Drawing.Size(35, 20);
            this.txtProb6.TabIndex = 22;
            this.txtProb6.Text = "0,1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(218, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "5";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(235)))));
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtPrecio10);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtPrecio8);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtPrecio7);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtPrecio1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtPrecio2);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtPrecio5);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.txtPrecio6);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(306, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 78);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRECIO UNIDAD";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(448, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "10";
            // 
            // txtPrecio10
            // 
            this.txtPrecio10.Location = new System.Drawing.Point(434, 47);
            this.txtPrecio10.Name = "txtPrecio10";
            this.txtPrecio10.Size = new System.Drawing.Size(44, 20);
            this.txtPrecio10.TabIndex = 30;
            this.txtPrecio10.Text = "80";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(386, 27);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "8";
            // 
            // txtPrecio8
            // 
            this.txtPrecio8.Location = new System.Drawing.Point(372, 47);
            this.txtPrecio8.Name = "txtPrecio8";
            this.txtPrecio8.Size = new System.Drawing.Size(44, 20);
            this.txtPrecio8.TabIndex = 28;
            this.txtPrecio8.Text = "80";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(326, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "7";
            // 
            // txtPrecio7
            // 
            this.txtPrecio7.Location = new System.Drawing.Point(309, 47);
            this.txtPrecio7.Name = "txtPrecio7";
            this.txtPrecio7.Size = new System.Drawing.Size(44, 20);
            this.txtPrecio7.TabIndex = 26;
            this.txtPrecio7.Text = "80";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Precio";
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.Location = new System.Drawing.Point(66, 47);
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(44, 20);
            this.txtPrecio1.TabIndex = 16;
            this.txtPrecio1.Text = "100";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(139, 27);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(13, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "2";
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.Location = new System.Drawing.Point(125, 47);
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(44, 20);
            this.txtPrecio2.TabIndex = 18;
            this.txtPrecio2.Text = "100";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(262, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(13, 13);
            this.label19.TabIndex = 19;
            this.label19.Text = "6";
            // 
            // txtPrecio5
            // 
            this.txtPrecio5.Location = new System.Drawing.Point(184, 47);
            this.txtPrecio5.Name = "txtPrecio5";
            this.txtPrecio5.Size = new System.Drawing.Size(44, 20);
            this.txtPrecio5.TabIndex = 20;
            this.txtPrecio5.Text = "100";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(81, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "1";
            // 
            // txtPrecio6
            // 
            this.txtPrecio6.Location = new System.Drawing.Point(248, 47);
            this.txtPrecio6.Name = "txtPrecio6";
            this.txtPrecio6.Size = new System.Drawing.Size(44, 20);
            this.txtPrecio6.TabIndex = 22;
            this.txtPrecio6.Text = "80";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 27);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Cantidad";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(198, 27);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 24;
            this.label23.Text = "5";
            // 
            // gdrSimulacion
            // 
            this.gdrSimulacion.AllowUserToAddRows = false;
            this.gdrSimulacion.AllowUserToDeleteRows = false;
            this.gdrSimulacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrSimulacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diaTabla,
            this.rndClientesTabla,
            this.clienteTabla,
            this.nroRandomDemandaTabla,
            this.demandaTabla,
            this.precioDemandaTabla,
            this.stockTabla,
            this.sobranteDiarioTabla,
            this.promedioSobranteTabla,
            this.utilidadDiariaTabla,
            this.utilidadPromedioTabla});
            this.gdrSimulacion.Location = new System.Drawing.Point(12, 175);
            this.gdrSimulacion.Name = "gdrSimulacion";
            this.gdrSimulacion.ReadOnly = true;
            this.gdrSimulacion.Size = new System.Drawing.Size(784, 406);
            this.gdrSimulacion.TabIndex = 55;
            // 
            // diaTabla
            // 
            this.diaTabla.HeaderText = "Dia";
            this.diaTabla.Name = "diaTabla";
            this.diaTabla.ReadOnly = true;
            this.diaTabla.Width = 50;
            // 
            // rndClientesTabla
            // 
            this.rndClientesTabla.HeaderText = "Nro Random Clientes";
            this.rndClientesTabla.Name = "rndClientesTabla";
            this.rndClientesTabla.ReadOnly = true;
            this.rndClientesTabla.Width = 60;
            // 
            // clienteTabla
            // 
            this.clienteTabla.HeaderText = "Cliente";
            this.clienteTabla.Name = "clienteTabla";
            this.clienteTabla.ReadOnly = true;
            this.clienteTabla.Width = 90;
            // 
            // nroRandomDemandaTabla
            // 
            this.nroRandomDemandaTabla.HeaderText = "Nro Random Demanda";
            this.nroRandomDemandaTabla.Name = "nroRandomDemandaTabla";
            this.nroRandomDemandaTabla.ReadOnly = true;
            this.nroRandomDemandaTabla.Width = 60;
            // 
            // demandaTabla
            // 
            this.demandaTabla.HeaderText = "Demanda";
            this.demandaTabla.Name = "demandaTabla";
            this.demandaTabla.ReadOnly = true;
            this.demandaTabla.Width = 60;
            // 
            // precioDemandaTabla
            // 
            this.precioDemandaTabla.HeaderText = "Precio Demanda";
            this.precioDemandaTabla.Name = "precioDemandaTabla";
            this.precioDemandaTabla.ReadOnly = true;
            this.precioDemandaTabla.Width = 70;
            // 
            // stockTabla
            // 
            this.stockTabla.HeaderText = "Stock";
            this.stockTabla.Name = "stockTabla";
            this.stockTabla.ReadOnly = true;
            this.stockTabla.Width = 50;
            // 
            // sobranteDiarioTabla
            // 
            this.sobranteDiarioTabla.HeaderText = "Sobrante Diario";
            this.sobranteDiarioTabla.Name = "sobranteDiarioTabla";
            this.sobranteDiarioTabla.ReadOnly = true;
            this.sobranteDiarioTabla.Width = 70;
            // 
            // promedioSobranteTabla
            // 
            this.promedioSobranteTabla.HeaderText = "Sobrante Promedio";
            this.promedioSobranteTabla.Name = "promedioSobranteTabla";
            this.promedioSobranteTabla.ReadOnly = true;
            this.promedioSobranteTabla.Width = 70;
            // 
            // utilidadDiariaTabla
            // 
            this.utilidadDiariaTabla.HeaderText = "Utilidad Diaria";
            this.utilidadDiariaTabla.Name = "utilidadDiariaTabla";
            this.utilidadDiariaTabla.ReadOnly = true;
            this.utilidadDiariaTabla.Width = 70;
            // 
            // utilidadPromedioTabla
            // 
            this.utilidadPromedioTabla.HeaderText = "Utilidad Promedio";
            this.utilidadPromedioTabla.Name = "utilidadPromedioTabla";
            this.utilidadPromedioTabla.ReadOnly = true;
            this.utilidadPromedioTabla.Width = 70;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 586);
            this.Controls.Add(this.gdrSimulacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrSimulacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtDesde;
        private System.Windows.Forms.TextBox txtCantDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtProb10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProb8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProb7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProb2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProb5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProb6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPrecio10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrecio8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPrecio7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPrecio5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtPrecio6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView gdrSimulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndClientesTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroRandomDemandaTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn demandaTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDemandaTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobranteDiarioTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn promedioSobranteTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadDiariaTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadPromedioTabla;
    }
}

