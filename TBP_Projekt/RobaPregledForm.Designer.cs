namespace TBP_Projekt
{
    partial class RobaPregledForm
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
            this.buttonNovi = new System.Windows.Forms.Button();
            this.buttonIzmjena = new System.Windows.Forms.Button();
            this.buttonBriši = new System.Windows.Forms.Button();
            this.dataGridViewRoba = new System.Windows.Forms.DataGridView();
            this.idRobaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaskladistenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trenutnakolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minkolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenajednenabaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjedostaveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.robaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonMinKol = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(765, 266);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(119, 45);
            this.buttonNovi.TabIndex = 34;
            this.buttonNovi.Text = "Novi";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.buttonNovi_Click);
            // 
            // buttonIzmjena
            // 
            this.buttonIzmjena.Location = new System.Drawing.Point(890, 266);
            this.buttonIzmjena.Name = "buttonIzmjena";
            this.buttonIzmjena.Size = new System.Drawing.Size(119, 45);
            this.buttonIzmjena.TabIndex = 33;
            this.buttonIzmjena.Text = "Izmjeni";
            this.buttonIzmjena.UseVisualStyleBackColor = true;
            this.buttonIzmjena.Click += new System.EventHandler(this.buttonIzmjena_Click);
            // 
            // buttonBriši
            // 
            this.buttonBriši.Location = new System.Drawing.Point(1015, 266);
            this.buttonBriši.Name = "buttonBriši";
            this.buttonBriši.Size = new System.Drawing.Size(119, 45);
            this.buttonBriši.TabIndex = 32;
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
            this.idRobaDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.cijenaskladistenjaDataGridViewTextBoxColumn,
            this.trenutnakolicinaDataGridViewTextBoxColumn,
            this.minkolicinaDataGridViewTextBoxColumn,
            this.cijenajednenabaveDataGridViewTextBoxColumn,
            this.trajanjedostaveDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn});
            this.dataGridViewRoba.DataSource = this.robaBindingSource;
            this.dataGridViewRoba.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRoba.Name = "dataGridViewRoba";
            this.dataGridViewRoba.ReadOnly = true;
            this.dataGridViewRoba.RowTemplate.Height = 24;
            this.dataGridViewRoba.Size = new System.Drawing.Size(1122, 248);
            this.dataGridViewRoba.TabIndex = 31;
            // 
            // idRobaDataGridViewTextBoxColumn
            // 
            this.idRobaDataGridViewTextBoxColumn.DataPropertyName = "idRoba";
            this.idRobaDataGridViewTextBoxColumn.HeaderText = "idRoba";
            this.idRobaDataGridViewTextBoxColumn.Name = "idRobaDataGridViewTextBoxColumn";
            this.idRobaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
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
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // robaBindingSource
            // 
            this.robaBindingSource.DataSource = typeof(TBP_Projekt.Roba);
            // 
            // buttonMinKol
            // 
            this.buttonMinKol.Location = new System.Drawing.Point(12, 266);
            this.buttonMinKol.Name = "buttonMinKol";
            this.buttonMinKol.Size = new System.Drawing.Size(119, 45);
            this.buttonMinKol.TabIndex = 35;
            this.buttonMinKol.Text = "Minimalne količine";
            this.buttonMinKol.UseVisualStyleBackColor = true;
            this.buttonMinKol.Click += new System.EventHandler(this.buttonMinKol_Click);
            // 
            // RobaPregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 426);
            this.Controls.Add(this.buttonMinKol);
            this.Controls.Add(this.buttonNovi);
            this.Controls.Add(this.buttonIzmjena);
            this.Controls.Add(this.buttonBriši);
            this.Controls.Add(this.dataGridViewRoba);
            this.Name = "RobaPregledForm";
            this.Text = "RobaPregledForm";
            this.Load += new System.EventHandler(this.RobaPregledForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.robaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.Button buttonIzmjena;
        private System.Windows.Forms.Button buttonBriši;
        private System.Windows.Forms.DataGridView dataGridViewRoba;
        private System.Windows.Forms.BindingSource robaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRobaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaskladistenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trenutnakolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minkolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenajednenabaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjedostaveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonMinKol;
    }
}