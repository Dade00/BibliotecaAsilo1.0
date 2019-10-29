namespace Maestre.Bambini
{
    partial class ModificaBambino
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
            this.AnnullaModificaBambini = new System.Windows.Forms.Button();
            this.ConfermaModificaBambini = new System.Windows.Forms.Button();
            this.AiutoModificaBambini = new System.Windows.Forms.Button();
            this.CercaFotoBambini = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TabellaBambini = new System.Windows.Forms.DataGridView();
            this.ClasseModBambini = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libro_label = new System.Windows.Forms.Label();
            this.CognomeModBambini = new System.Windows.Forms.TextBox();
            this.NomeModBambini = new System.Windows.Forms.TextBox();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Bambini_pic = new System.Windows.Forms.PictureBox();
            this.nascitaModificaBambini = new System.Windows.Forms.DateTimePicker();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.bsBambini = new System.Windows.Forms.BindingSource(this.components);
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).BeginInit();
            this.SuspendLayout();
            // 
            // AnnullaModificaBambini
            // 
            this.AnnullaModificaBambini.BackgroundImage = global::Maestre.Properties.Resources.Annulla;
            this.AnnullaModificaBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnullaModificaBambini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AnnullaModificaBambini.FlatAppearance.BorderSize = 0;
            this.AnnullaModificaBambini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AnnullaModificaBambini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AnnullaModificaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnullaModificaBambini.Location = new System.Drawing.Point(226, 544);
            this.AnnullaModificaBambini.Name = "AnnullaModificaBambini";
            this.AnnullaModificaBambini.Size = new System.Drawing.Size(380, 120);
            this.AnnullaModificaBambini.TabIndex = 111;
            this.AnnullaModificaBambini.UseVisualStyleBackColor = true;
            this.AnnullaModificaBambini.Click += new System.EventHandler(this.AnnullaModificaBambini_Click);
            // 
            // ConfermaModificaBambini
            // 
            this.ConfermaModificaBambini.BackgroundImage = global::Maestre.Properties.Resources.Conferma;
            this.ConfermaModificaBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfermaModificaBambini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ConfermaModificaBambini.FlatAppearance.BorderSize = 0;
            this.ConfermaModificaBambini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ConfermaModificaBambini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ConfermaModificaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaModificaBambini.Location = new System.Drawing.Point(761, 544);
            this.ConfermaModificaBambini.Name = "ConfermaModificaBambini";
            this.ConfermaModificaBambini.Size = new System.Drawing.Size(380, 120);
            this.ConfermaModificaBambini.TabIndex = 110;
            this.ConfermaModificaBambini.UseVisualStyleBackColor = true;
            // 
            // AiutoModificaBambini
            // 
            this.AiutoModificaBambini.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoModificaBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoModificaBambini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AiutoModificaBambini.FlatAppearance.BorderSize = 0;
            this.AiutoModificaBambini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AiutoModificaBambini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AiutoModificaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoModificaBambini.Location = new System.Drawing.Point(1235, 11);
            this.AiutoModificaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoModificaBambini.Name = "AiutoModificaBambini";
            this.AiutoModificaBambini.Size = new System.Drawing.Size(120, 120);
            this.AiutoModificaBambini.TabIndex = 109;
            this.AiutoModificaBambini.UseVisualStyleBackColor = true;
            // 
            // CercaFotoBambini
            // 
            this.CercaFotoBambini.BackgroundImage = global::Maestre.Properties.Resources.Inserisci_foto;
            this.CercaFotoBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CercaFotoBambini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CercaFotoBambini.FlatAppearance.BorderSize = 0;
            this.CercaFotoBambini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.CercaFotoBambini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.CercaFotoBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CercaFotoBambini.Location = new System.Drawing.Point(631, 217);
            this.CercaFotoBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CercaFotoBambini.Name = "CercaFotoBambini";
            this.CercaFotoBambini.Size = new System.Drawing.Size(130, 45);
            this.CercaFotoBambini.TabIndex = 108;
            this.CercaFotoBambini.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(560, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 106;
            this.label3.Text = "FOTO";
            // 
            // TabellaBambini
            // 
            this.TabellaBambini.AutoGenerateColumns = false;
            this.TabellaBambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBambini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.dataNascitaDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn});
            this.TabellaBambini.DataSource = this.bsBambini;
            this.TabellaBambini.Location = new System.Drawing.Point(523, 289);
            this.TabellaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBambini.Name = "TabellaBambini";
            this.TabellaBambini.RowHeadersWidth = 62;
            this.TabellaBambini.RowTemplate.Height = 28;
            this.TabellaBambini.Size = new System.Drawing.Size(689, 200);
            this.TabellaBambini.TabIndex = 105;
            // 
            // ClasseModBambini
            // 
            this.ClasseModBambini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClasseModBambini.Location = new System.Drawing.Point(1003, 120);
            this.ClasseModBambini.Margin = new System.Windows.Forms.Padding(2);
            this.ClasseModBambini.Name = "ClasseModBambini";
            this.ClasseModBambini.Size = new System.Drawing.Size(67, 23);
            this.ClasseModBambini.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(901, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 101;
            this.label1.Text = "CLASSE";
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libro_label.Location = new System.Drawing.Point(413, 9);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(486, 55);
            this.libro_label.TabIndex = 100;
            this.libro_label.Text = "Modifica un bambino";
            // 
            // CognomeModBambini
            // 
            this.CognomeModBambini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CognomeModBambini.Location = new System.Drawing.Point(633, 179);
            this.CognomeModBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CognomeModBambini.Name = "CognomeModBambini";
            this.CognomeModBambini.Size = new System.Drawing.Size(237, 23);
            this.CognomeModBambini.TabIndex = 99;
            // 
            // NomeModBambini
            // 
            this.NomeModBambini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NomeModBambini.Location = new System.Drawing.Point(631, 120);
            this.NomeModBambini.Margin = new System.Windows.Forms.Padding(2);
            this.NomeModBambini.Name = "NomeModBambini";
            this.NomeModBambini.Size = new System.Drawing.Size(237, 23);
            this.NomeModBambini.TabIndex = 98;
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cognome_label.Location = new System.Drawing.Point(504, 177);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(125, 25);
            this.cognome_label.TabIndex = 97;
            this.cognome_label.Text = "COGNOME";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_label.Location = new System.Drawing.Point(550, 116);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(76, 25);
            this.nome_label.TabIndex = 96;
            this.nome_label.Text = "NOME";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(884, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 67);
            this.label2.TabIndex = 103;
            this.label2.Text = "ANNO DI NASCITA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bambini_pic
            // 
            this.Bambini_pic.Location = new System.Drawing.Point(125, 139);
            this.Bambini_pic.Name = "Bambini_pic";
            this.Bambini_pic.Size = new System.Drawing.Size(350, 350);
            this.Bambini_pic.TabIndex = 130;
            this.Bambini_pic.TabStop = false;
            // 
            // nascitaModificaBambini
            // 
            this.nascitaModificaBambini.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nascitaModificaBambini.Location = new System.Drawing.Point(1003, 179);
            this.nascitaModificaBambini.Name = "nascitaModificaBambini";
            this.nascitaModificaBambini.Size = new System.Drawing.Size(221, 23);
            this.nascitaModificaBambini.TabIndex = 131;
            // 
            // bsBambini
            // 
            this.bsBambini.DataSource = typeof(Classi.Bambino);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            // 
            // dataNascitaDataGridViewTextBoxColumn
            // 
            this.dataNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.HeaderText = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.Name = "dataNascitaDataGridViewTextBoxColumn";
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            // 
            // ModificaBambino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.nascitaModificaBambini);
            this.Controls.Add(this.Bambini_pic);
            this.Controls.Add(this.AnnullaModificaBambini);
            this.Controls.Add(this.ConfermaModificaBambini);
            this.Controls.Add(this.AiutoModificaBambini);
            this.Controls.Add(this.CercaFotoBambini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TabellaBambini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClasseModBambini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.CognomeModBambini);
            this.Controls.Add(this.NomeModBambini);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificaBambino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificaBambino";
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnnullaModificaBambini;
        private System.Windows.Forms.Button ConfermaModificaBambini;
        private System.Windows.Forms.Button AiutoModificaBambini;
        private System.Windows.Forms.Button CercaFotoBambini;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TabellaBambini;
        private System.Windows.Forms.TextBox ClasseModBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.TextBox CognomeModBambini;
        private System.Windows.Forms.TextBox NomeModBambini;
        private System.Windows.Forms.Label cognome_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Bambini_pic;
        private System.Windows.Forms.DateTimePicker nascitaModificaBambini;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsBambini;
    }
}