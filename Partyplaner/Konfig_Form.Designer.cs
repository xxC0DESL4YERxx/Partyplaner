namespace Partyplaner
{
    partial class Konfig_Form
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.grp_gaeste = new System.Windows.Forms.GroupBox();
			this.grp_gast = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.list_gaeste_wunschabstand = new System.Windows.Forms.ListBox();
			this.lb_wunschabstand = new System.Windows.Forms.Label();
			this.num_wunschabstand = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.lb_name = new System.Windows.Forms.Label();
			this.txt_name = new System.Windows.Forms.TextBox();
			this.lb_beruf = new System.Windows.Forms.Label();
			this.num_startpos_y = new System.Windows.Forms.NumericUpDown();
			this.txt_beruf = new System.Windows.Forms.TextBox();
			this.lb_startpos_y = new System.Windows.Forms.Label();
			this.lb_startpos_x = new System.Windows.Forms.Label();
			this.num_startpos_x = new System.Windows.Forms.NumericUpDown();
			this.list_gaesteliste = new System.Windows.Forms.ListBox();
			this.grp_tisch = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.lb_tisch_groesse_x = new System.Windows.Forms.Label();
			this.num_tisch_pos_y = new System.Windows.Forms.NumericUpDown();
			this.lb_tisch_pos_x = new System.Windows.Forms.Label();
			this.lb_tisch_pos_y = new System.Windows.Forms.Label();
			this.num_tisch_groesse_x = new System.Windows.Forms.NumericUpDown();
			this.num_tisch_pos_x = new System.Windows.Forms.NumericUpDown();
			this.lb_tisch_groesse_y = new System.Windows.Forms.Label();
			this.num_tisch_groesse_y = new System.Windows.Forms.NumericUpDown();
			this.grp_raum = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.lb_raum_groesse_x = new System.Windows.Forms.Label();
			this.num_raum_groesse_y = new System.Windows.Forms.NumericUpDown();
			this.num_raum_groesse_x = new System.Windows.Forms.NumericUpDown();
			this.lb_raum_groesse_y = new System.Windows.Forms.Label();
			this.btn_ok = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.grp_gaeste.SuspendLayout();
			this.grp_gast.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_wunschabstand)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_startpos_y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_startpos_x)).BeginInit();
			this.grp_tisch.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_tisch_pos_y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_tisch_groesse_x)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_tisch_pos_x)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_tisch_groesse_y)).BeginInit();
			this.grp_raum.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_raum_groesse_y)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_raum_groesse_x)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.grp_gaeste, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.grp_tisch, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.grp_raum, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_ok, 1, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1239, 829);
			this.tableLayoutPanel1.TabIndex = 9;
			// 
			// grp_gaeste
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.grp_gaeste, 2);
			this.grp_gaeste.Controls.Add(this.grp_gast);
			this.grp_gaeste.Controls.Add(this.list_gaesteliste);
			this.grp_gaeste.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grp_gaeste.Location = new System.Drawing.Point(3, 376);
			this.grp_gaeste.Name = "grp_gaeste";
			this.grp_gaeste.Size = new System.Drawing.Size(1233, 367);
			this.grp_gaeste.TabIndex = 16;
			this.grp_gaeste.TabStop = false;
			this.grp_gaeste.Text = "Gäste";
			// 
			// grp_gast
			// 
			this.grp_gast.Controls.Add(this.tableLayoutPanel5);
			this.grp_gast.Controls.Add(this.tableLayoutPanel4);
			this.grp_gast.Location = new System.Drawing.Point(310, 26);
			this.grp_gast.Name = "grp_gast";
			this.grp_gast.Size = new System.Drawing.Size(920, 337);
			this.grp_gast.TabIndex = 14;
			this.grp_gast.TabStop = false;
			this.grp_gast.Text = "Gewählten Gast konfigurieren";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
			this.tableLayoutPanel5.Controls.Add(this.lb_wunschabstand, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.list_gaeste_wunschabstand, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.num_wunschabstand, 1, 1);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Right;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(499, 27);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 2;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.00835F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.99164F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(418, 307);
			this.tableLayoutPanel5.TabIndex = 16;
			// 
			// list_gaeste_wunschabstand
			// 
			this.tableLayoutPanel5.SetColumnSpan(this.list_gaeste_wunschabstand, 2);
			this.list_gaeste_wunschabstand.Dock = System.Windows.Forms.DockStyle.Fill;
			this.list_gaeste_wunschabstand.FormattingEnabled = true;
			this.list_gaeste_wunschabstand.ItemHeight = 25;
			this.list_gaeste_wunschabstand.Location = new System.Drawing.Point(3, 3);
			this.list_gaeste_wunschabstand.Name = "list_gaeste_wunschabstand";
			this.list_gaeste_wunschabstand.Size = new System.Drawing.Size(412, 248);
			this.list_gaeste_wunschabstand.TabIndex = 9;
			// 
			// lb_wunschabstand
			// 
			this.lb_wunschabstand.AutoSize = true;
			this.lb_wunschabstand.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_wunschabstand.Location = new System.Drawing.Point(3, 254);
			this.lb_wunschabstand.Name = "lb_wunschabstand";
			this.lb_wunschabstand.Size = new System.Drawing.Size(259, 53);
			this.lb_wunschabstand.TabIndex = 10;
			this.lb_wunschabstand.Text = "Wunschabstand:";
			// 
			// num_wunschabstand
			// 
			this.num_wunschabstand.Dock = System.Windows.Forms.DockStyle.Fill;
			this.num_wunschabstand.Location = new System.Drawing.Point(268, 257);
			this.num_wunschabstand.Name = "num_wunschabstand";
			this.num_wunschabstand.Size = new System.Drawing.Size(147, 31);
			this.num_wunschabstand.TabIndex = 14;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel4.Controls.Add(this.lb_name, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.txt_name, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.lb_beruf, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.num_startpos_y, 1, 3);
			this.tableLayoutPanel4.Controls.Add(this.txt_beruf, 1, 1);
			this.tableLayoutPanel4.Controls.Add(this.lb_startpos_y, 0, 3);
			this.tableLayoutPanel4.Controls.Add(this.lb_startpos_x, 0, 2);
			this.tableLayoutPanel4.Controls.Add(this.num_startpos_x, 1, 2);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Left;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 27);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 4;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(489, 307);
			this.tableLayoutPanel4.TabIndex = 15;
			// 
			// lb_name
			// 
			this.lb_name.AutoSize = true;
			this.lb_name.Location = new System.Drawing.Point(3, 0);
			this.lb_name.Name = "lb_name";
			this.lb_name.Size = new System.Drawing.Size(74, 25);
			this.lb_name.TabIndex = 1;
			this.lb_name.Text = "Name:";
			// 
			// txt_name
			// 
			this.txt_name.Location = new System.Drawing.Point(247, 3);
			this.txt_name.Name = "txt_name";
			this.txt_name.Size = new System.Drawing.Size(237, 31);
			this.txt_name.TabIndex = 0;
			// 
			// lb_beruf
			// 
			this.lb_beruf.AutoSize = true;
			this.lb_beruf.Location = new System.Drawing.Point(3, 76);
			this.lb_beruf.Name = "lb_beruf";
			this.lb_beruf.Size = new System.Drawing.Size(69, 25);
			this.lb_beruf.TabIndex = 3;
			this.lb_beruf.Text = "Beruf:";
			// 
			// num_startpos_y
			// 
			this.num_startpos_y.Location = new System.Drawing.Point(247, 231);
			this.num_startpos_y.Name = "num_startpos_y";
			this.num_startpos_y.Size = new System.Drawing.Size(238, 31);
			this.num_startpos_y.TabIndex = 8;
			this.num_startpos_y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txt_beruf
			// 
			this.txt_beruf.Location = new System.Drawing.Point(247, 79);
			this.txt_beruf.Name = "txt_beruf";
			this.txt_beruf.Size = new System.Drawing.Size(237, 31);
			this.txt_beruf.TabIndex = 2;
			// 
			// lb_startpos_y
			// 
			this.lb_startpos_y.AutoSize = true;
			this.lb_startpos_y.Location = new System.Drawing.Point(3, 228);
			this.lb_startpos_y.Name = "lb_startpos_y";
			this.lb_startpos_y.Size = new System.Drawing.Size(116, 25);
			this.lb_startpos_y.TabIndex = 7;
			this.lb_startpos_y.Text = "Position Y:";
			// 
			// lb_startpos_x
			// 
			this.lb_startpos_x.AutoSize = true;
			this.lb_startpos_x.Location = new System.Drawing.Point(3, 152);
			this.lb_startpos_x.Name = "lb_startpos_x";
			this.lb_startpos_x.Size = new System.Drawing.Size(115, 25);
			this.lb_startpos_x.TabIndex = 5;
			this.lb_startpos_x.Text = "Position X:";
			// 
			// num_startpos_x
			// 
			this.num_startpos_x.Location = new System.Drawing.Point(247, 155);
			this.num_startpos_x.Name = "num_startpos_x";
			this.num_startpos_x.Size = new System.Drawing.Size(238, 31);
			this.num_startpos_x.TabIndex = 6;
			this.num_startpos_x.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// list_gaesteliste
			// 
			this.list_gaesteliste.Dock = System.Windows.Forms.DockStyle.Left;
			this.list_gaesteliste.FormattingEnabled = true;
			this.list_gaesteliste.ItemHeight = 25;
			this.list_gaesteliste.Location = new System.Drawing.Point(3, 27);
			this.list_gaesteliste.Name = "list_gaesteliste";
			this.list_gaesteliste.Size = new System.Drawing.Size(300, 337);
			this.list_gaesteliste.TabIndex = 11;
			// 
			// grp_tisch
			// 
			this.grp_tisch.Controls.Add(this.tableLayoutPanel3);
			this.grp_tisch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grp_tisch.Location = new System.Drawing.Point(622, 3);
			this.grp_tisch.Name = "grp_tisch";
			this.grp_tisch.Size = new System.Drawing.Size(614, 367);
			this.grp_tisch.TabIndex = 12;
			this.grp_tisch.TabStop = false;
			this.grp_tisch.Text = "Tisch";
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.lb_tisch_groesse_x, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.num_tisch_pos_y, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.lb_tisch_pos_x, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.lb_tisch_pos_y, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.num_tisch_groesse_x, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.num_tisch_pos_x, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.lb_tisch_groesse_y, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.num_tisch_groesse_y, 1, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 27);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(608, 337);
			this.tableLayoutPanel3.TabIndex = 14;
			// 
			// lb_tisch_groesse_x
			// 
			this.lb_tisch_groesse_x.AutoSize = true;
			this.lb_tisch_groesse_x.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_tisch_groesse_x.Location = new System.Drawing.Point(3, 0);
			this.lb_tisch_groesse_x.Name = "lb_tisch_groesse_x";
			this.lb_tisch_groesse_x.Size = new System.Drawing.Size(298, 84);
			this.lb_tisch_groesse_x.TabIndex = 7;
			this.lb_tisch_groesse_x.Text = "Grösse X:";
			// 
			// num_tisch_pos_y
			// 
			this.num_tisch_pos_y.Dock = System.Windows.Forms.DockStyle.Fill;
			this.num_tisch_pos_y.Location = new System.Drawing.Point(307, 255);
			this.num_tisch_pos_y.Name = "num_tisch_pos_y";
			this.num_tisch_pos_y.Size = new System.Drawing.Size(298, 31);
			this.num_tisch_pos_y.TabIndex = 13;
			this.num_tisch_pos_y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lb_tisch_pos_x
			// 
			this.lb_tisch_pos_x.AutoSize = true;
			this.lb_tisch_pos_x.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_tisch_pos_x.Location = new System.Drawing.Point(3, 168);
			this.lb_tisch_pos_x.Name = "lb_tisch_pos_x";
			this.lb_tisch_pos_x.Size = new System.Drawing.Size(298, 84);
			this.lb_tisch_pos_x.TabIndex = 11;
			this.lb_tisch_pos_x.Text = "Position X:";
			// 
			// lb_tisch_pos_y
			// 
			this.lb_tisch_pos_y.AutoSize = true;
			this.lb_tisch_pos_y.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_tisch_pos_y.Location = new System.Drawing.Point(3, 252);
			this.lb_tisch_pos_y.Name = "lb_tisch_pos_y";
			this.lb_tisch_pos_y.Size = new System.Drawing.Size(298, 85);
			this.lb_tisch_pos_y.TabIndex = 12;
			this.lb_tisch_pos_y.Text = "Position Y:";
			// 
			// num_tisch_groesse_x
			// 
			this.num_tisch_groesse_x.Dock = System.Windows.Forms.DockStyle.Fill;
			this.num_tisch_groesse_x.Location = new System.Drawing.Point(307, 3);
			this.num_tisch_groesse_x.Name = "num_tisch_groesse_x";
			this.num_tisch_groesse_x.Size = new System.Drawing.Size(298, 31);
			this.num_tisch_groesse_x.TabIndex = 6;
			this.num_tisch_groesse_x.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// num_tisch_pos_x
			// 
			this.num_tisch_pos_x.Dock = System.Windows.Forms.DockStyle.Fill;
			this.num_tisch_pos_x.Location = new System.Drawing.Point(307, 171);
			this.num_tisch_pos_x.Name = "num_tisch_pos_x";
			this.num_tisch_pos_x.Size = new System.Drawing.Size(298, 31);
			this.num_tisch_pos_x.TabIndex = 10;
			this.num_tisch_pos_x.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lb_tisch_groesse_y
			// 
			this.lb_tisch_groesse_y.AutoSize = true;
			this.lb_tisch_groesse_y.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_tisch_groesse_y.Location = new System.Drawing.Point(3, 84);
			this.lb_tisch_groesse_y.Name = "lb_tisch_groesse_y";
			this.lb_tisch_groesse_y.Size = new System.Drawing.Size(298, 84);
			this.lb_tisch_groesse_y.TabIndex = 8;
			this.lb_tisch_groesse_y.Text = "Grösse Y:";
			// 
			// num_tisch_groesse_y
			// 
			this.num_tisch_groesse_y.Dock = System.Windows.Forms.DockStyle.Fill;
			this.num_tisch_groesse_y.Location = new System.Drawing.Point(307, 87);
			this.num_tisch_groesse_y.Name = "num_tisch_groesse_y";
			this.num_tisch_groesse_y.Size = new System.Drawing.Size(298, 31);
			this.num_tisch_groesse_y.TabIndex = 9;
			this.num_tisch_groesse_y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// grp_raum
			// 
			this.grp_raum.Controls.Add(this.tableLayoutPanel2);
			this.grp_raum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grp_raum.Location = new System.Drawing.Point(3, 3);
			this.grp_raum.Name = "grp_raum";
			this.grp_raum.Size = new System.Drawing.Size(613, 367);
			this.grp_raum.TabIndex = 11;
			this.grp_raum.TabStop = false;
			this.grp_raum.Text = "Raum";
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.lb_raum_groesse_x, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.num_raum_groesse_y, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.num_raum_groesse_x, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.lb_raum_groesse_y, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(607, 337);
			this.tableLayoutPanel2.TabIndex = 12;
			// 
			// lb_raum_groesse_x
			// 
			this.lb_raum_groesse_x.AutoSize = true;
			this.lb_raum_groesse_x.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_raum_groesse_x.Location = new System.Drawing.Point(3, 0);
			this.lb_raum_groesse_x.Name = "lb_raum_groesse_x";
			this.lb_raum_groesse_x.Size = new System.Drawing.Size(297, 84);
			this.lb_raum_groesse_x.TabIndex = 1;
			this.lb_raum_groesse_x.Text = "Grösse X:";
			// 
			// num_raum_groesse_y
			// 
			this.num_raum_groesse_y.Dock = System.Windows.Forms.DockStyle.Fill;
			this.num_raum_groesse_y.Location = new System.Drawing.Point(306, 87);
			this.num_raum_groesse_y.Name = "num_raum_groesse_y";
			this.num_raum_groesse_y.Size = new System.Drawing.Size(298, 31);
			this.num_raum_groesse_y.TabIndex = 4;
			this.num_raum_groesse_y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// num_raum_groesse_x
			// 
			this.num_raum_groesse_x.Dock = System.Windows.Forms.DockStyle.Fill;
			this.num_raum_groesse_x.Location = new System.Drawing.Point(306, 3);
			this.num_raum_groesse_x.Name = "num_raum_groesse_x";
			this.num_raum_groesse_x.Size = new System.Drawing.Size(298, 31);
			this.num_raum_groesse_x.TabIndex = 0;
			this.num_raum_groesse_x.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lb_raum_groesse_y
			// 
			this.lb_raum_groesse_y.AutoSize = true;
			this.lb_raum_groesse_y.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb_raum_groesse_y.Location = new System.Drawing.Point(3, 84);
			this.lb_raum_groesse_y.Name = "lb_raum_groesse_y";
			this.lb_raum_groesse_y.Size = new System.Drawing.Size(297, 84);
			this.lb_raum_groesse_y.TabIndex = 2;
			this.lb_raum_groesse_y.Text = "Grösse Y:";
			// 
			// btn_ok
			// 
			this.btn_ok.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_ok.Location = new System.Drawing.Point(622, 749);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(614, 77);
			this.btn_ok.TabIndex = 17;
			this.btn_ok.Text = "OK";
			this.btn_ok.UseVisualStyleBackColor = true;
			// 
			// Konfig_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1239, 829);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Konfig_Form";
			this.Text = "Konfiguration";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.grp_gaeste.ResumeLayout(false);
			this.grp_gast.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_wunschabstand)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_startpos_y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_startpos_x)).EndInit();
			this.grp_tisch.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_tisch_pos_y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_tisch_groesse_x)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_tisch_pos_x)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_tisch_groesse_y)).EndInit();
			this.grp_raum.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_raum_groesse_y)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_raum_groesse_x)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox grp_raum;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label lb_raum_groesse_x;
		private System.Windows.Forms.NumericUpDown num_raum_groesse_y;
		private System.Windows.Forms.NumericUpDown num_raum_groesse_x;
		private System.Windows.Forms.Label lb_raum_groesse_y;
		private System.Windows.Forms.GroupBox grp_tisch;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label lb_tisch_groesse_x;
		private System.Windows.Forms.NumericUpDown num_tisch_pos_y;
		private System.Windows.Forms.Label lb_tisch_pos_x;
		private System.Windows.Forms.Label lb_tisch_pos_y;
		private System.Windows.Forms.NumericUpDown num_tisch_groesse_x;
		private System.Windows.Forms.NumericUpDown num_tisch_pos_x;
		private System.Windows.Forms.Label lb_tisch_groesse_y;
		private System.Windows.Forms.NumericUpDown num_tisch_groesse_y;
		private System.Windows.Forms.GroupBox grp_gaeste;
		private System.Windows.Forms.ListBox list_gaesteliste;
		private System.Windows.Forms.GroupBox grp_gast;
		private System.Windows.Forms.NumericUpDown num_wunschabstand;
		private System.Windows.Forms.Label lb_wunschabstand;
		private System.Windows.Forms.ListBox list_gaeste_wunschabstand;
		private System.Windows.Forms.NumericUpDown num_startpos_y;
		private System.Windows.Forms.Label lb_startpos_y;
		private System.Windows.Forms.NumericUpDown num_startpos_x;
		private System.Windows.Forms.Label lb_startpos_x;
		private System.Windows.Forms.Label lb_beruf;
		private System.Windows.Forms.TextBox txt_beruf;
		private System.Windows.Forms.Label lb_name;
		private System.Windows.Forms.TextBox txt_name;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button btn_ok;
	}
}

