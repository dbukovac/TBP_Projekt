namespace TBP_Projekt
{
    partial class ZaposleniciPregledForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonBriši = new System.Windows.Forms.Button();
            this.buttonIzmjena = new System.Windows.Forms.Button();
            this.buttonNovi = new System.Windows.Forms.Button();
            this.idZaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozicijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lozinkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idZaposlenikDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.pozicijaDataGridViewTextBoxColumn,
            this.lozinkaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zaposlenikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonBriši
            // 
            this.buttonBriši.Location = new System.Drawing.Point(468, 168);
            this.buttonBriši.Name = "buttonBriši";
            this.buttonBriši.Size = new System.Drawing.Size(119, 45);
            this.buttonBriši.TabIndex = 24;
            this.buttonBriši.Text = "Briši";
            this.buttonBriši.UseVisualStyleBackColor = true;
            this.buttonBriši.Click += new System.EventHandler(this.buttonBriši_Click);
            // 
            // buttonIzmjena
            // 
            this.buttonIzmjena.Location = new System.Drawing.Point(343, 168);
            this.buttonIzmjena.Name = "buttonIzmjena";
            this.buttonIzmjena.Size = new System.Drawing.Size(119, 45);
            this.buttonIzmjena.TabIndex = 25;
            this.buttonIzmjena.Text = "Izmjeni";
            this.buttonIzmjena.UseVisualStyleBackColor = true;
            this.buttonIzmjena.Click += new System.EventHandler(this.buttonIzmjena_Click);
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(218, 168);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(119, 45);
            this.buttonNovi.TabIndex = 26;
            this.buttonNovi.Text = "Novi";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.buttonNovi_Click);
            // 
            // idZaposlenikDataGridViewTextBoxColumn
            // 
            this.idZaposlenikDataGridViewTextBoxColumn.DataPropertyName = "idZaposlenik";
            this.idZaposlenikDataGridViewTextBoxColumn.HeaderText = "idZaposlenik";
            this.idZaposlenikDataGridViewTextBoxColumn.Name = "idZaposlenikDataGridViewTextBoxColumn";
            this.idZaposlenikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pozicijaDataGridViewTextBoxColumn
            // 
            this.pozicijaDataGridViewTextBoxColumn.DataPropertyName = "pozicija";
            this.pozicijaDataGridViewTextBoxColumn.HeaderText = "pozicija";
            this.pozicijaDataGridViewTextBoxColumn.Name = "pozicijaDataGridViewTextBoxColumn";
            this.pozicijaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            this.lozinkaDataGridViewTextBoxColumn.DataPropertyName = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.HeaderText = "lozinka";
            this.lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            this.lozinkaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zaposlenikBindingSource
            // 
            this.zaposlenikBindingSource.DataSource = typeof(TBP_Projekt.Zaposlenik);
            // 
            // ZaposleniciPregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 323);
            this.Controls.Add(this.buttonNovi);
            this.Controls.Add(this.buttonIzmjena);
            this.Controls.Add(this.buttonBriši);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ZaposleniciPregledForm";
            this.Text = "ZaposleniciPregledForm";
            this.Load += new System.EventHandler(this.ZaposleniciPregledForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaposlenikBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idZaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozicijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zaposlenikBindingSource;
        private System.Windows.Forms.Button buttonBriši;
        private System.Windows.Forms.Button buttonIzmjena;
        private System.Windows.Forms.Button buttonNovi;
    }
}