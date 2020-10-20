namespace TBP_Projekt
{
    partial class DobavljacPregledForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dobavljacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDobavljacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNovi
            // 
            this.buttonNovi.Location = new System.Drawing.Point(12, 168);
            this.buttonNovi.Name = "buttonNovi";
            this.buttonNovi.Size = new System.Drawing.Size(119, 45);
            this.buttonNovi.TabIndex = 30;
            this.buttonNovi.Text = "Novi";
            this.buttonNovi.UseVisualStyleBackColor = true;
            this.buttonNovi.Click += new System.EventHandler(this.buttonNovi_Click);
            // 
            // buttonIzmjena
            // 
            this.buttonIzmjena.Location = new System.Drawing.Point(137, 168);
            this.buttonIzmjena.Name = "buttonIzmjena";
            this.buttonIzmjena.Size = new System.Drawing.Size(119, 45);
            this.buttonIzmjena.TabIndex = 29;
            this.buttonIzmjena.Text = "Izmjeni";
            this.buttonIzmjena.UseVisualStyleBackColor = true;
            this.buttonIzmjena.Click += new System.EventHandler(this.buttonIzmjena_Click);
            // 
            // buttonBriši
            // 
            this.buttonBriši.Location = new System.Drawing.Point(262, 168);
            this.buttonBriši.Name = "buttonBriši";
            this.buttonBriši.Size = new System.Drawing.Size(119, 45);
            this.buttonBriši.TabIndex = 28;
            this.buttonBriši.Text = "Briši";
            this.buttonBriši.UseVisualStyleBackColor = true;
            this.buttonBriši.Click += new System.EventHandler(this.buttonBriši_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDobavljacDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dobavljacBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(369, 150);
            this.dataGridView1.TabIndex = 27;
            // 
            // dobavljacBindingSource
            // 
            this.dobavljacBindingSource.DataSource = typeof(TBP_Projekt.Dobavljac);
            // 
            // idDobavljacDataGridViewTextBoxColumn
            // 
            this.idDobavljacDataGridViewTextBoxColumn.DataPropertyName = "idDobavljac";
            this.idDobavljacDataGridViewTextBoxColumn.HeaderText = "idDobavljac";
            this.idDobavljacDataGridViewTextBoxColumn.Name = "idDobavljacDataGridViewTextBoxColumn";
            this.idDobavljacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DobavljacPregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 323);
            this.Controls.Add(this.buttonNovi);
            this.Controls.Add(this.buttonIzmjena);
            this.Controls.Add(this.buttonBriši);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DobavljacPregledForm";
            this.Text = "DobavljacPregledForm";
            this.Load += new System.EventHandler(this.DobavljacPregledForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobavljacBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNovi;
        private System.Windows.Forms.Button buttonIzmjena;
        private System.Windows.Forms.Button buttonBriši;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dobavljacBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDobavljacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
    }
}