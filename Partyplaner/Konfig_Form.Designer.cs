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
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_gast_hinzufuegen = new System.Windows.Forms.Button();
            this.btn_gast_loeschen = new System.Windows.Forms.Button();
            this.grp_gast = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_wunschabstand = new System.Windows.Forms.Label();
            this.list_gaeste_wunschabstand = new System.Windows.Forms.ListBox();
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
            this.tableLayoutPanel6.SuspendLayout();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(620, 431);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // grp_gaeste
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.grp_gaeste, 2);
            this.grp_gaeste.Controls.Add(this.tableLayoutPanel6);
            this.grp_gaeste.Controls.Add(this.grp_gast);
            this.grp_gaeste.Controls.Add(this.list_gaesteliste);
            this.grp_gaeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_gaeste.Location = new System.Drawing.Point(2, 152);
            this.grp_gaeste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_gaeste.Name = "grp_gaeste";
            this.grp_gaeste.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_gaeste.Size = new System.Drawing.Size(616, 233);
            this.grp_gaeste.TabIndex = 16;
            this.grp_gaeste.TabStop = false;
            this.grp_gaeste.Text = "Gäste";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btn_gast_hinzufuegen, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_gast_loeschen, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(154, 190);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(460, 41);
            this.tableLayoutPanel6.TabIndex = 19;
            // 
            // btn_gast_hinzufuegen
            // 
            this.btn_gast_hinzufuegen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_gast_hinzufuegen.Location = new System.Drawing.Point(232, 2);
            this.btn_gast_hinzufuegen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_gast_hinzufuegen.Name = "btn_gast_hinzufuegen";
            this.btn_gast_hinzufuegen.Size = new System.Drawing.Size(226, 37);
            this.btn_gast_hinzufuegen.TabIndex = 1;
            this.btn_gast_hinzufuegen.Text = "Gast hinzufügen";
            this.btn_gast_hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_gast_hinzufuegen.Click += new System.EventHandler(this.Btn_gast_hinzufuegen_Click);
            // 
            // btn_gast_loeschen
            // 
            this.btn_gast_loeschen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_gast_loeschen.Enabled = false;
            this.btn_gast_loeschen.Location = new System.Drawing.Point(2, 2);
            this.btn_gast_loeschen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_gast_loeschen.Name = "btn_gast_loeschen";
            this.btn_gast_loeschen.Size = new System.Drawing.Size(226, 37);
            this.btn_gast_loeschen.TabIndex = 0;
            this.btn_gast_loeschen.Text = "Gast löschen";
            this.btn_gast_loeschen.UseVisualStyleBackColor = true;
            this.btn_gast_loeschen.Click += new System.EventHandler(this.Btn_gast_loeschen_Click);
            // 
            // grp_gast
            // 
            this.grp_gast.Controls.Add(this.tableLayoutPanel5);
            this.grp_gast.Controls.Add(this.tableLayoutPanel4);
            this.grp_gast.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_gast.Location = new System.Drawing.Point(154, 15);
            this.grp_gast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_gast.Name = "grp_gast";
            this.grp_gast.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_gast.Size = new System.Drawing.Size(460, 175);
            this.grp_gast.TabIndex = 14;
            this.grp_gast.TabStop = false;
            this.grp_gast.Text = "Gewählten Gast konfigurieren";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel5.Controls.Add(this.lb_wunschabstand, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.list_gaeste_wunschabstand, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.num_wunschabstand, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(249, 15);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.00835F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.99164F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(209, 158);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // lb_wunschabstand
            // 
            this.lb_wunschabstand.AutoSize = true;
            this.lb_wunschabstand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_wunschabstand.Location = new System.Drawing.Point(2, 131);
            this.lb_wunschabstand.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_wunschabstand.Name = "lb_wunschabstand";
            this.lb_wunschabstand.Size = new System.Drawing.Size(129, 27);
            this.lb_wunschabstand.TabIndex = 10;
            this.lb_wunschabstand.Text = "Wunschabstand:";
            // 
            // list_gaeste_wunschabstand
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.list_gaeste_wunschabstand, 2);
            this.list_gaeste_wunschabstand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_gaeste_wunschabstand.FormattingEnabled = true;
            this.list_gaeste_wunschabstand.Location = new System.Drawing.Point(2, 2);
            this.list_gaeste_wunschabstand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_gaeste_wunschabstand.Name = "list_gaeste_wunschabstand";
            this.list_gaeste_wunschabstand.Size = new System.Drawing.Size(205, 127);
            this.list_gaeste_wunschabstand.TabIndex = 9;
            // 
            // num_wunschabstand
            // 
            this.num_wunschabstand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_wunschabstand.Enabled = false;
            this.num_wunschabstand.Location = new System.Drawing.Point(135, 133);
            this.num_wunschabstand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_wunschabstand.Name = "num_wunschabstand";
            this.num_wunschabstand.Size = new System.Drawing.Size(72, 20);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(244, 158);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(2, 0);
            this.lb_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(38, 13);
            this.lb_name.TabIndex = 1;
            this.lb_name.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Location = new System.Drawing.Point(124, 2);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(118, 20);
            this.txt_name.TabIndex = 0;
            // 
            // lb_beruf
            // 
            this.lb_beruf.AutoSize = true;
            this.lb_beruf.Location = new System.Drawing.Point(2, 39);
            this.lb_beruf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_beruf.Name = "lb_beruf";
            this.lb_beruf.Size = new System.Drawing.Size(35, 13);
            this.lb_beruf.TabIndex = 3;
            this.lb_beruf.Text = "Beruf:";
            // 
            // num_startpos_y
            // 
            this.num_startpos_y.Enabled = false;
            this.num_startpos_y.Location = new System.Drawing.Point(124, 119);
            this.num_startpos_y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_startpos_y.Name = "num_startpos_y";
            this.num_startpos_y.Size = new System.Drawing.Size(118, 20);
            this.num_startpos_y.TabIndex = 8;
            this.num_startpos_y.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_beruf
            // 
            this.txt_beruf.Enabled = false;
            this.txt_beruf.Location = new System.Drawing.Point(124, 41);
            this.txt_beruf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_beruf.Name = "txt_beruf";
            this.txt_beruf.Size = new System.Drawing.Size(118, 20);
            this.txt_beruf.TabIndex = 2;
            // 
            // lb_startpos_y
            // 
            this.lb_startpos_y.AutoSize = true;
            this.lb_startpos_y.Location = new System.Drawing.Point(2, 117);
            this.lb_startpos_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_startpos_y.Name = "lb_startpos_y";
            this.lb_startpos_y.Size = new System.Drawing.Size(57, 13);
            this.lb_startpos_y.TabIndex = 7;
            this.lb_startpos_y.Text = "Position Y:";
            // 
            // lb_startpos_x
            // 
            this.lb_startpos_x.AutoSize = true;
            this.lb_startpos_x.Location = new System.Drawing.Point(2, 78);
            this.lb_startpos_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_startpos_x.Name = "lb_startpos_x";
            this.lb_startpos_x.Size = new System.Drawing.Size(57, 13);
            this.lb_startpos_x.TabIndex = 5;
            this.lb_startpos_x.Text = "Position X:";
            // 
            // num_startpos_x
            // 
            this.num_startpos_x.Enabled = false;
            this.num_startpos_x.Location = new System.Drawing.Point(124, 80);
            this.num_startpos_x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_startpos_x.Name = "num_startpos_x";
            this.num_startpos_x.Size = new System.Drawing.Size(118, 20);
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
            this.list_gaesteliste.Location = new System.Drawing.Point(2, 15);
            this.list_gaesteliste.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_gaesteliste.Name = "list_gaesteliste";
            this.list_gaesteliste.Size = new System.Drawing.Size(152, 216);
            this.list_gaesteliste.TabIndex = 11;
            // 
            // grp_tisch
            // 
            this.grp_tisch.Controls.Add(this.tableLayoutPanel3);
            this.grp_tisch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_tisch.Location = new System.Drawing.Point(312, 2);
            this.grp_tisch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_tisch.Name = "grp_tisch";
            this.grp_tisch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_tisch.Size = new System.Drawing.Size(306, 146);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(302, 129);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // lb_tisch_groesse_x
            // 
            this.lb_tisch_groesse_x.AutoSize = true;
            this.lb_tisch_groesse_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_tisch_groesse_x.Location = new System.Drawing.Point(2, 0);
            this.lb_tisch_groesse_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tisch_groesse_x.Name = "lb_tisch_groesse_x";
            this.lb_tisch_groesse_x.Size = new System.Drawing.Size(147, 32);
            this.lb_tisch_groesse_x.TabIndex = 7;
            this.lb_tisch_groesse_x.Text = "Grösse X:";
            // 
            // num_tisch_pos_y
            // 
            this.num_tisch_pos_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_tisch_pos_y.Location = new System.Drawing.Point(153, 98);
            this.num_tisch_pos_y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_tisch_pos_y.Name = "num_tisch_pos_y";
            this.num_tisch_pos_y.Size = new System.Drawing.Size(147, 20);
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
            this.lb_tisch_pos_x.Location = new System.Drawing.Point(2, 64);
            this.lb_tisch_pos_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tisch_pos_x.Name = "lb_tisch_pos_x";
            this.lb_tisch_pos_x.Size = new System.Drawing.Size(147, 32);
            this.lb_tisch_pos_x.TabIndex = 11;
            this.lb_tisch_pos_x.Text = "Position X:";
            // 
            // lb_tisch_pos_y
            // 
            this.lb_tisch_pos_y.AutoSize = true;
            this.lb_tisch_pos_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_tisch_pos_y.Location = new System.Drawing.Point(2, 96);
            this.lb_tisch_pos_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tisch_pos_y.Name = "lb_tisch_pos_y";
            this.lb_tisch_pos_y.Size = new System.Drawing.Size(147, 33);
            this.lb_tisch_pos_y.TabIndex = 12;
            this.lb_tisch_pos_y.Text = "Position Y:";
            // 
            // num_tisch_groesse_x
            // 
            this.num_tisch_groesse_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_tisch_groesse_x.Location = new System.Drawing.Point(153, 2);
            this.num_tisch_groesse_x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_tisch_groesse_x.Name = "num_tisch_groesse_x";
            this.num_tisch_groesse_x.Size = new System.Drawing.Size(147, 20);
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
            this.num_tisch_pos_x.Location = new System.Drawing.Point(153, 66);
            this.num_tisch_pos_x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_tisch_pos_x.Name = "num_tisch_pos_x";
            this.num_tisch_pos_x.Size = new System.Drawing.Size(147, 20);
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
            this.lb_tisch_groesse_y.Location = new System.Drawing.Point(2, 32);
            this.lb_tisch_groesse_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_tisch_groesse_y.Name = "lb_tisch_groesse_y";
            this.lb_tisch_groesse_y.Size = new System.Drawing.Size(147, 32);
            this.lb_tisch_groesse_y.TabIndex = 8;
            this.lb_tisch_groesse_y.Text = "Grösse Y:";
            // 
            // num_tisch_groesse_y
            // 
            this.num_tisch_groesse_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_tisch_groesse_y.Location = new System.Drawing.Point(153, 34);
            this.num_tisch_groesse_y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_tisch_groesse_y.Name = "num_tisch_groesse_y";
            this.num_tisch_groesse_y.Size = new System.Drawing.Size(147, 20);
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
            this.grp_raum.Location = new System.Drawing.Point(2, 2);
            this.grp_raum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_raum.Name = "grp_raum";
            this.grp_raum.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_raum.Size = new System.Drawing.Size(306, 146);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 15);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(302, 129);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // lb_raum_groesse_x
            // 
            this.lb_raum_groesse_x.AutoSize = true;
            this.lb_raum_groesse_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_raum_groesse_x.Location = new System.Drawing.Point(2, 0);
            this.lb_raum_groesse_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_raum_groesse_x.Name = "lb_raum_groesse_x";
            this.lb_raum_groesse_x.Size = new System.Drawing.Size(147, 32);
            this.lb_raum_groesse_x.TabIndex = 1;
            this.lb_raum_groesse_x.Text = "Grösse X:";
            // 
            // num_raum_groesse_y
            // 
            this.num_raum_groesse_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_raum_groesse_y.Location = new System.Drawing.Point(153, 34);
            this.num_raum_groesse_y.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_raum_groesse_y.Name = "num_raum_groesse_y";
            this.num_raum_groesse_y.Size = new System.Drawing.Size(147, 20);
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
            this.num_raum_groesse_x.Location = new System.Drawing.Point(153, 2);
            this.num_raum_groesse_x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.num_raum_groesse_x.Name = "num_raum_groesse_x";
            this.num_raum_groesse_x.Size = new System.Drawing.Size(147, 20);
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
            this.lb_raum_groesse_y.Location = new System.Drawing.Point(2, 32);
            this.lb_raum_groesse_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_raum_groesse_y.Name = "lb_raum_groesse_y";
            this.lb_raum_groesse_y.Size = new System.Drawing.Size(147, 32);
            this.lb_raum_groesse_y.TabIndex = 2;
            this.lb_raum_groesse_y.Text = "Grösse Y:";
            // 
            // btn_ok
            // 
            this.btn_ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ok.Location = new System.Drawing.Point(312, 389);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(306, 40);
            this.btn_ok.TabIndex = 17;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // Konfig_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 431);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Konfig_Form";
            this.Text = "Konfiguration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grp_gaeste.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.Button btn_gast_hinzufuegen;
		private System.Windows.Forms.Button btn_gast_loeschen;
	}
}

