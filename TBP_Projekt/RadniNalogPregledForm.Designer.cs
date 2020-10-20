namespace TBP_Projekt
{
    partial class RadniNalogPregledForm
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
            this.components = new System.ComponentModel.Container();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNovi = new System.Windows.Forms.Button();
            this.buttonBriši = new System.Windows.Forms.Button();
            this.dataGridViewRoba = new System.Windows.Forms.DataGridView();
            this.proizvodidProizvodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.proizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radninaloghasProizvodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewNarudzbe = new System.Windows.Forms.DataGridView();
            this.idRadninalogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zavrseno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radninalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninaloghasProizvodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 45);
            this.button2.TabIndex = 46;
            this.button2.Text = "Izmjeni";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 45);
            this.button1.TabIndex = 45;
            this.button1.Text = "Zaključi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(300, 168);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(101, 45);
            this.buttonNovi.TabIndex = 44;
            this.buttonNovi.Text = "Novi";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.buttonNovi_Click);
            // 
            // buttonBriši
            // 
            this.buttonBriši.Location = new System.Drawing.Point(621, 168);
            this.buttonBriši.Name = "buttonBriši";
            this.buttonBriši.Size = new System.Drawing.Size(119, 45);
            this.buttonBriši.TabIndex = 43;
            this.buttonBriši.Text = "Briši";
            this.buttonBriši.UseVisualStyleBackColor = true;
            this.buttonBriši.Click += new System.EventHandler(this.buttonBriši_Click);
            // 
            // dataGridViewRoba
            // 
            this.dataGridViewRoba.AllowUserToAddRows = false;
            this.dataGridViewRoba.AllowUserToDeleteRows = false;
            this.dataGridViewRoba.AutoGenerateColumns = false;
            this.dataGridViewRoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.proizvodidProizvodDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn});
            this.dataGridViewRoba.DataSource = this.radninaloghasProizvodBindingSource;
            this.dataGridViewRoba.Location = new System.Drawing.Point(436, 12);
            this.dataGridViewRoba.Name = "dataGridViewRoba";
            this.dataGridViewRoba.ReadOnly = true;
            this.dataGridViewRoba.RowTemplate.Height = 24;
            this.dataGridViewRoba.Size = new System.Drawing.Size(304, 150);
            this.dataGridViewRoba.TabIndex = 42;
            // 
            // proizvodidProizvodDataGridViewTextBoxColumn
            // 
            this.proizvodidProizvodDataGridViewTextBoxColumn.DataPropertyName = "Proizvod_idProizvod";
            this.proizvodidProizvodDataGridViewTextBoxColumn.DataSource = this.proizvodBindingSource;
            this.proizvodidProizvodDataGridViewTextBoxColumn.DisplayMember = "naziv";
            this.proizvodidProizvodDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.proizvodidProizvodDataGridViewTextBoxColumn.HeaderText = "Proizvod_idProizvod";
            this.proizvodidProizvodDataGridViewTextBoxColumn.Name = "proizvodidProizvodDataGridViewTextBoxColumn";
            this.proizvodidProizvodDataGridViewTextBoxColumn.ReadOnly = true;
            this.proizvodidProizvodDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.proizvodidProizvodDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.proizvodidProizvodDataGridViewTextBoxColumn.ValueMember = "idProizvod";
            // 
            // proizvodBindingSource
            // 
            this.proizvodBindingSource.DataSource = typeof(TBP_Projekt.Proizvod);
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radninaloghasProizvodBindingSource
            // 
            this.radninaloghasProizvodBindingSource.DataSource = typeof(TBP_Projekt.Radni_nalog_has_Proizvod);
            // 
            // dataGridViewNarudzbe
            // 
            this.dataGridViewNarudzbe.AllowUserToAddRows = false;
            this.dataGridViewNarudzbe.AllowUserToDeleteRows = false;
            this.dataGridViewNarudzbe.AutoGenerateColumns = false;
            this.dataGridViewNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRadninalogDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.zavrseno});
            this.dataGridViewNarudzbe.DataSource = this.radninalogBindingSource;
            this.dataGridViewNarudzbe.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewNarudzbe.Name = "dataGridViewNarudzbe";
            this.dataGridViewNarudzbe.ReadOnly = true;
            this.dataGridViewNarudzbe.RowTemplate.Height = 24;
            this.dataGridViewNarudzbe.Size = new System.Drawing.Size(418, 150);
            this.dataGridViewNarudzbe.TabIndex = 41;
            this.dataGridViewNarudzbe.SelectionChanged += new System.EventHandler(this.dataGridViewNarudzbe_SelectionChanged);
            // 
            // idRadninalogDataGridViewTextBoxColumn
            // 
            this.idRadninalogDataGridViewTextBoxColumn.DataPropertyName = "idRadni_nalog";
            this.idRadninalogDataGridViewTextBoxColumn.HeaderText = "idRadni_nalog";
            this.idRadninalogDataGridViewTextBoxColumn.Name = "idRadninalogDataGridViewTextBoxColumn";
            this.idRadninalogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "opis";
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zavrseno
            // 
            this.zavrseno.DataPropertyName = "zavrseno";
            this.zavrseno.HeaderText = "zavrseno";
            this.zavrseno.Name = "zavrseno";
            this.zavrseno.ReadOnly = true;
            // 
            // radninalogBindingSource
            // 
            this.radninalogBindingSource.DataSource = typeof(TBP_Projekt.Radni_nalog);
            // 
            // RadniNalogPregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonNovi);
            this.Controls.Add(this.buttonBriši);
            this.Controls.Add(this.dataGridViewRoba);
            this.Controls.Add(this.dataGridViewNarudzbe);
            this.Name = "RadniNalogPregledForm";
            this.Text = "RadniNalogPregledForm";
            this.Load += new System.EventHandler(this.RadniNalogPregledForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninaloghasProizvodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radninalogBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.Button buttonBriši;
        private System.Windows.Forms.DataGridView dataGridViewRoba;
        private System.Windows.Forms.DataGridView dataGridViewNarudzbe;
        private System.Windows.Forms.BindingSource proizvodBindingSource;
        private System.Windows.Forms.BindingSource radninaloghasProizvodBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRadninalogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource radninalogBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn proizvodidProizvodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zavrseno;
    }
}