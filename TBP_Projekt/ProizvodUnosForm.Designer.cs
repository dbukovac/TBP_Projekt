namespace TBP_Projekt
{
    partial class ProizvodUnosForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRoba = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.idRoba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaSaKolicinomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idRobaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaskladistenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trenutnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minkolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenajednenabaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjedostaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinanarucivanjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbahasRobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodhasRobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaSaKolicinomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 45);
            this.button1.TabIndex = 15;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNaziv
            // 
            this.textBoxNaziv.Location = new System.Drawing.Point(12, 27);
            this.textBoxNaziv.Name = "textBoxNaziv";
            this.textBoxNaziv.Size = new System.Drawing.Size(119, 22);
            this.textBoxNaziv.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv";
            // 
            // dataGridViewRoba
            // 
            this.dataGridViewRoba.AllowUserToAddRows = false;
            this.dataGridViewRoba.AllowUserToDeleteRows = false;
            this.dataGridViewRoba.AutoGenerateColumns = false;
            this.dataGridViewRoba.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoba.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRobaDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn1,
            this.cijenaskladistenjaDataGridViewTextBoxColumn,
            this.trenutnakolicinaDataGridViewTextBoxColumn,
            this.minkolicinaDataGridViewTextBoxColumn,
            this.cijenajednenabaveDataGridViewTextBoxColumn,
            this.trajanjedostaveDataGridViewTextBoxColumn,
            this.kolicinanarucivanjaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.narudzbahasRobaDataGridViewTextBoxColumn,
            this.proizvodhasRobaDataGridViewTextBoxColumn});
            this.dataGridViewRoba.DataSource = this.robaBindingSource;
            this.dataGridViewRoba.Location = new System.Drawing.Point(12, 75);
            this.dataGridViewRoba.MultiSelect = false;
            this.dataGridViewRoba.Name = "dataGridViewRoba";
            this.dataGridViewRoba.ReadOnly = true;
            this.dataGridViewRoba.RowTemplate.Height = 24;
            this.dataGridViewRoba.Size = new System.Drawing.Size(313, 150);
            this.dataGridViewRoba.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "Dodaj u listu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRoba,
            this.naziv,
            this.kolicina,
            this.kolicinaDataGridViewTextBoxColumn,
            this.idRobaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.robaSaKolicinomBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(331, 75);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(339, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kolicina";
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(12, 278);
            this.numKolicina.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(120, 22);
            this.numKolicina.TabIndex = 20;
            // 
            // idRoba
            // 
            this.idRoba.DataPropertyName = "idRoba";
            this.idRoba.HeaderText = "idRoba";
            this.idRoba.Name = "idRoba";
            this.idRoba.ReadOnly = true;
            // 
            // naziv
            // 
            this.naziv.DataPropertyName = "naziv";
            this.naziv.HeaderText = "naziv";
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.DataPropertyName = "kolicina";
            this.kolicina.HeaderText = "kolicina";
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idRobaDataGridViewTextBoxColumn
            // 
            this.idRobaDataGridViewTextBoxColumn.DataPropertyName = "IdRoba";
            this.idRobaDataGridViewTextBoxColumn.HeaderText = "IdRoba";
            this.idRobaDataGridViewTextBoxColumn.Name = "idRobaDataGridViewTextBoxColumn";
            this.idRobaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // robaSaKolicinomBindingSource
            // 
            this.robaSaKolicinomBindingSource.DataSource = typeof(TBP_Projekt.RobaSaKolicinom);
            // 
            // idRobaDataGridViewTextBoxColumn1
            // 
            this.idRobaDataGridViewTextBoxColumn1.DataPropertyName = "idRoba";
            this.idRobaDataGridViewTextBoxColumn1.HeaderText = "idRoba";
            this.idRobaDataGridViewTextBoxColumn1.Name = "idRobaDataGridViewTextBoxColumn1";
            this.idRobaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            this.nazivDataGridViewTextBoxColumn1.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn1.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            this.nazivDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cijenaskladistenjaDataGridViewTextBoxColumn
            // 
            this.cijenaskladistenjaDataGridViewTextBoxColumn.DataPropertyName = "cijena_skladistenja";
            this.cijenaskladistenjaDataGridViewTextBoxColumn.HeaderText = "cijena_skladistenja";
            this.cijenaskladistenjaDataGridViewTextBoxColumn.Name = "cijenaskladistenjaDataGridViewTextBoxColumn";
            this.cijenaskladistenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trenutnakolicinaDataGridViewTextBoxColumn
            // 
            this.trenutnakolicinaDataGridViewTextBoxColumn.DataPropertyName = "trenutna_kolicina";
            this.trenutnakolicinaDataGridViewTextBoxColumn.HeaderText = "trenutna_kolicina";
            this.trenutnakolicinaDataGridViewTextBoxColumn.Name = "trenutnakolicinaDataGridViewTextBoxColumn";
            this.trenutnakolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minkolicinaDataGridViewTextBoxColumn
            // 
            this.minkolicinaDataGridViewTextBoxColumn.DataPropertyName = "min_kolicina";
            this.minkolicinaDataGridViewTextBoxColumn.HeaderText = "min_kolicina";
            this.minkolicinaDataGridViewTextBoxColumn.Name = "minkolicinaDataGridViewTextBoxColumn";
            this.minkolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cijenajednenabaveDataGridViewTextBoxColumn
            // 
            this.cijenajednenabaveDataGridViewTextBoxColumn.DataPropertyName = "cijena_jedne_nabave";
            this.cijenajednenabaveDataGridViewTextBoxColumn.HeaderText = "cijena_jedne_nabave";
            this.cijenajednenabaveDataGridViewTextBoxColumn.Name = "cijenajednenabaveDataGridViewTextBoxColumn";
            this.cijenajednenabaveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // trajanjedostaveDataGridViewTextBoxColumn
            // 
            this.trajanjedostaveDataGridViewTextBoxColumn.DataPropertyName = "trajanje_dostave";
            this.trajanjedostaveDataGridViewTextBoxColumn.HeaderText = "trajanje_dostave";
            this.trajanjedostaveDataGridViewTextBoxColumn.Name = "trajanjedostaveDataGridViewTextBoxColumn";
            this.trajanjedostaveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinanarucivanjaDataGridViewTextBoxColumn
            // 
            this.kolicinanarucivanjaDataGridViewTextBoxColumn.DataPropertyName = "kolicina_narucivanja";
            this.kolicinanarucivanjaDataGridViewTextBoxColumn.HeaderText = "kolicina_narucivanja";
            this.kolicinanarucivanjaDataGridViewTextBoxColumn.Name = "kolicinanarucivanjaDataGridViewTextBoxColumn";
            this.kolicinanarucivanjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // narudzbahasRobaDataGridViewTextBoxColumn
            // 
            this.narudzbahasRobaDataGridViewTextBoxColumn.DataPropertyName = "Narudzba_has_Roba";
            this.narudzbahasRobaDataGridViewTextBoxColumn.HeaderText = "Narudzba_has_Roba";
            this.narudzbahasRobaDataGridViewTextBoxColumn.Name = "narudzbahasRobaDataGridViewTextBoxColumn";
            this.narudzbahasRobaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proizvodhasRobaDataGridViewTextBoxColumn
            // 
            this.proizvodhasRobaDataGridViewTextBoxColumn.DataPropertyName = "Proizvod_has_Roba";
            this.proizvodhasRobaDataGridViewTextBoxColumn.HeaderText = "Proizvod_has_Roba";
            this.proizvodhasRobaDataGridViewTextBoxColumn.Name = "proizvodhasRobaDataGridViewTextBoxColumn";
            this.proizvodhasRobaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // robaBindingSource
            // 
            this.robaBindingSource.DataSource = typeof(TBP_Projekt.Roba);
            // 
            // ProizvodUnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 323);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridViewRoba);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxNaziv);
            this.Controls.Add(this.label1);
            this.Name = "ProizvodUnosForm";
            this.Text = "ProizvodUnosForm";
            this.Load += new System.EventHandler(this.ProizvodUnosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaSaKolicinomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.BindingSource robaSaKolicinomBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRoba;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRobaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaskladistenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trenutnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minkolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenajednenabaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjedostaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinanarucivanjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn narudzbahasRobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodhasRobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
    }
}