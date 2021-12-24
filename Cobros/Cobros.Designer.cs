
namespace Parcial2_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelCliente = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoCli = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnModCli = new System.Windows.Forms.Button();
            this.btnBorrarCli = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodCobro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomCobro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateVto = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImporteCobro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnCobroNuevo = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.rBtnAsc = new System.Windows.Forms.RadioButton();
            this.rBtnDes = new System.Windows.Forms.RadioButton();
            this.btnCobroAMB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelCliente.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // panelCliente
            // 
            this.panelCliente.ColumnCount = 3;
            this.panelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.panelCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.panelCliente.Controls.Add(this.btnNuevoCli, 0, 2);
            this.panelCliente.Controls.Add(this.label2, 0, 0);
            this.panelCliente.Controls.Add(this.label3, 0, 1);
            this.panelCliente.Controls.Add(this.txtLegajo, 1, 0);
            this.panelCliente.Controls.Add(this.txtNombre, 1, 1);
            this.panelCliente.Controls.Add(this.btnModCli, 1, 2);
            this.panelCliente.Controls.Add(this.btnBorrarCli, 2, 2);
            this.panelCliente.Location = new System.Drawing.Point(66, 664);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.RowCount = 3;
            this.panelCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.panelCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelCliente.Size = new System.Drawing.Size(762, 239);
            this.panelCliente.TabIndex = 2;
            // 
            // btnNuevoCli
            // 
            this.btnNuevoCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNuevoCli.Location = new System.Drawing.Point(32, 166);
            this.btnNuevoCli.Name = "btnNuevoCli";
            this.btnNuevoCli.Size = new System.Drawing.Size(188, 65);
            this.btnNuevoCli.TabIndex = 3;
            this.btnNuevoCli.Text = "NUEVO";
            this.btnNuevoCli.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Legajo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLegajo.Location = new System.Drawing.Point(261, 20);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(238, 38);
            this.txtLegajo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.Location = new System.Drawing.Point(261, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 38);
            this.txtNombre.TabIndex = 6;
            // 
            // btnModCli
            // 
            this.btnModCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModCli.Location = new System.Drawing.Point(273, 166);
            this.btnModCli.Name = "btnModCli";
            this.btnModCli.Size = new System.Drawing.Size(213, 65);
            this.btnModCli.TabIndex = 7;
            this.btnModCli.Text = "MODIFICAR";
            this.btnModCli.UseVisualStyleBackColor = true;
            // 
            // btnBorrarCli
            // 
            this.btnBorrarCli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBorrarCli.Location = new System.Drawing.Point(540, 166);
            this.btnBorrarCli.Name = "btnBorrarCli";
            this.btnBorrarCli.Size = new System.Drawing.Size(188, 65);
            this.btnBorrarCli.TabIndex = 8;
            this.btnBorrarCli.Text = "BORRAR";
            this.btnBorrarCli.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(66, 29);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(335, 50);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "Ocultar AMB Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCodCobro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNomCobro, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateVto, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtImporteCobro, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnCobroNuevo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnOrdenar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.rBtnAsc, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.rBtnDes, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 1047);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 686);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "CÓDIGO COBRO:";
            // 
            // txtCodCobro
            // 
            this.txtCodCobro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodCobro.Location = new System.Drawing.Point(401, 30);
            this.txtCodCobro.Name = "txtCodCobro";
            this.txtCodCobro.Size = new System.Drawing.Size(341, 38);
            this.txtCodCobro.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "NOMBRE / DETALLE:";
            // 
            // txtNomCobro
            // 
            this.txtNomCobro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomCobro.Location = new System.Drawing.Point(400, 128);
            this.txtNomCobro.Name = "txtNomCobro";
            this.txtNomCobro.Size = new System.Drawing.Size(343, 38);
            this.txtNomCobro.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "FECHA VENCIMIENTO:";
            // 
            // dateVto
            // 
            this.dateVto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateVto.Location = new System.Drawing.Point(400, 226);
            this.dateVto.Name = "dateVto";
            this.dateVto.Size = new System.Drawing.Size(343, 38);
            this.dateVto.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "IMPORTE:";
            // 
            // txtImporteCobro
            // 
            this.txtImporteCobro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImporteCobro.Location = new System.Drawing.Point(398, 324);
            this.txtImporteCobro.Name = "txtImporteCobro";
            this.txtImporteCobro.Size = new System.Drawing.Size(346, 38);
            this.txtImporteCobro.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "TIPO DE COBRO:";
            // 
            // cmbTipo
            // 
            this.cmbTipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Normal",
            "Especial"});
            this.cmbTipo.Location = new System.Drawing.Point(397, 421);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(349, 39);
            this.cmbTipo.TabIndex = 19;
            // 
            // btnCobroNuevo
            // 
            this.btnCobroNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCobroNuevo.Location = new System.Drawing.Point(7, 506);
            this.btnCobroNuevo.Name = "btnCobroNuevo";
            this.btnCobroNuevo.Size = new System.Drawing.Size(366, 65);
            this.btnCobroNuevo.TabIndex = 10;
            this.btnCobroNuevo.Text = "ALTA COBRO";
            this.btnCobroNuevo.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrdenar.Location = new System.Drawing.Point(387, 506);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(368, 65);
            this.btnOrdenar.TabIndex = 9;
            this.btnOrdenar.Text = "ORDENAR";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // rBtnAsc
            // 
            this.rBtnAsc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtnAsc.AutoSize = true;
            this.rBtnAsc.Checked = true;
            this.rBtnAsc.Location = new System.Drawing.Point(46, 619);
            this.rBtnAsc.Name = "rBtnAsc";
            this.rBtnAsc.Size = new System.Drawing.Size(289, 36);
            this.rBtnAsc.TabIndex = 20;
            this.rBtnAsc.TabStop = true;
            this.rBtnAsc.Text = "Orden Ascendente";
            this.rBtnAsc.UseVisualStyleBackColor = true;
            // 
            // rBtnDes
            // 
            this.rBtnDes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rBtnDes.AutoSize = true;
            this.rBtnDes.Location = new System.Drawing.Point(418, 619);
            this.rBtnDes.Name = "rBtnDes";
            this.rBtnDes.Size = new System.Drawing.Size(306, 36);
            this.rBtnDes.TabIndex = 21;
            this.rBtnDes.Text = "Orden Descendente";
            this.rBtnDes.UseVisualStyleBackColor = true;
            // 
            // btnCobroAMB
            // 
            this.btnCobroAMB.Location = new System.Drawing.Point(438, 29);
            this.btnCobroAMB.Name = "btnCobroAMB";
            this.btnCobroAMB.Size = new System.Drawing.Size(335, 50);
            this.btnCobroAMB.TabIndex = 5;
            this.btnCobroAMB.Text = "Ocultar AMB Cobro";
            this.btnCobroAMB.UseVisualStyleBackColor = true;
            this.btnCobroAMB.Click += new System.EventHandler(this.btnCobroAMB_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1006, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Pendientes";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(1012, 379);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(263, 64);
            this.btnPagar.TabIndex = 8;
            this.btnPagar.Text = "PAGAR";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1012, 532);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 102;
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1862, 335);
            this.dataGridView3.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1006, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 32);
            this.label10.TabIndex = 10;
            this.label10.Text = "Cancelados";
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(1012, 961);
            this.dataGridView4.MultiSelect = false;
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 102;
            this.dataGridView4.RowTemplate.Height = 40;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1862, 346);
            this.dataGridView4.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1006, 913);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 32);
            this.label11.TabIndex = 12;
            this.label11.Text = "Pagados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 168);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(755, 476);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1012, 92);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 102;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1862, 265);
            this.dataGridView2.TabIndex = 14;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(1012, 1400);
            this.dataGridView5.MultiSelect = false;
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowHeadersWidth = 102;
            this.dataGridView5.RowTemplate.Height = 40;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(1862, 333);
            this.dataGridView5.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1006, 1356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(301, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Ordenador por Importe";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(67, 992);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(365, 32);
            this.label13.TabIndex = 22;
            this.label13.Text = "Agregar Cobros Pendientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2927, 1778);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView5);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCobroAMB);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CobroSoft";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel panelCliente;
        private System.Windows.Forms.Button btnNuevoCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnModCli;
        private System.Windows.Forms.Button btnBorrarCli;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnCobroNuevo;
        private System.Windows.Forms.TextBox txtCodCobro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomCobro;
        private System.Windows.Forms.Button btnCobroAMB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateVto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImporteCobro;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton rBtnAsc;
        private System.Windows.Forms.RadioButton rBtnDes;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

