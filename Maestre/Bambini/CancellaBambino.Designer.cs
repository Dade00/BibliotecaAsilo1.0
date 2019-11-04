namespace Maestre.Bambini
{
    partial class CancellaBambino
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
            this.libro_label = new System.Windows.Forms.Label();
            this.NomeDelBambini = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.TabellaBambini = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cognomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascitaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBambini = new System.Windows.Forms.BindingSource(this.components);
            this.CognomeDelBambini = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cerca_button = new System.Windows.Forms.Button();
            this.Bambini_pic = new System.Windows.Forms.PictureBox();
            this.AnnullaEliminaBambini = new System.Windows.Forms.Button();
            this.ConfermaEliminaBambini = new System.Windows.Forms.Button();
            this.AiutoCancellaBambino = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libro_label.Location = new System.Drawing.Point(413, 9);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(537, 58);
            this.libro_label.TabIndex = 39;
            this.libro_label.Text = "Cancella un bambino";
            // 
            // NomeDelBambini
            // 
            this.NomeDelBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.NomeDelBambini.Location = new System.Drawing.Point(555, 119);
            this.NomeDelBambini.Margin = new System.Windows.Forms.Padding(2);
            this.NomeDelBambini.Name = "NomeDelBambini";
            this.NomeDelBambini.Size = new System.Drawing.Size(312, 30);
            this.NomeDelBambini.TabIndex = 77;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome_label.Location = new System.Drawing.Point(384, 121);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(160, 25);
            this.nome_label.TabIndex = 76;
            this.nome_label.Text = "CERCA NOME";
            // 
            // TabellaBambini
            // 
            this.TabellaBambini.AllowUserToAddRows = false;
            this.TabellaBambini.AllowUserToDeleteRows = false;
            this.TabellaBambini.AllowUserToOrderColumns = true;
            this.TabellaBambini.AutoGenerateColumns = false;
            this.TabellaBambini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabellaBambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBambini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.cognomeDataGridViewTextBoxColumn,
            this.classeDataGridViewTextBoxColumn,
            this.dataNascitaDataGridViewTextBoxColumn});
            this.TabellaBambini.DataSource = this.bsBambini;
            this.TabellaBambini.Location = new System.Drawing.Point(509, 240);
            this.TabellaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBambini.Name = "TabellaBambini";
            this.TabellaBambini.ReadOnly = true;
            this.TabellaBambini.RowHeadersVisible = false;
            this.TabellaBambini.RowHeadersWidth = 62;
            this.TabellaBambini.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TabellaBambini.RowTemplate.Height = 28;
            this.TabellaBambini.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TabellaBambini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabellaBambini.Size = new System.Drawing.Size(690, 350);
            this.TabellaBambini.TabIndex = 75;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cognomeDataGridViewTextBoxColumn
            // 
            this.cognomeDataGridViewTextBoxColumn.DataPropertyName = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.HeaderText = "Cognome";
            this.cognomeDataGridViewTextBoxColumn.Name = "cognomeDataGridViewTextBoxColumn";
            this.cognomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classeDataGridViewTextBoxColumn
            // 
            this.classeDataGridViewTextBoxColumn.DataPropertyName = "Classe";
            this.classeDataGridViewTextBoxColumn.HeaderText = "Classe";
            this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
            this.classeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataNascitaDataGridViewTextBoxColumn
            // 
            this.dataNascitaDataGridViewTextBoxColumn.DataPropertyName = "DataNascita";
            this.dataNascitaDataGridViewTextBoxColumn.HeaderText = "Data di nascita";
            this.dataNascitaDataGridViewTextBoxColumn.Name = "dataNascitaDataGridViewTextBoxColumn";
            this.dataNascitaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsBambini
            // 
            this.bsBambini.DataSource = typeof(Classi.Bambino);
            // 
            // CognomeDelBambini
            // 
            this.CognomeDelBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.CognomeDelBambini.Location = new System.Drawing.Point(555, 168);
            this.CognomeDelBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CognomeDelBambini.Name = "CognomeDelBambini";
            this.CognomeDelBambini.Size = new System.Drawing.Size(312, 30);
            this.CognomeDelBambini.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "CERCA COGNOME";
            // 
            // cerca_button
            // 
            this.cerca_button.Location = new System.Drawing.Point(918, 132);
            this.cerca_button.Name = "cerca_button";
            this.cerca_button.Size = new System.Drawing.Size(220, 50);
            this.cerca_button.TabIndex = 130;
            this.cerca_button.Text = "Cerca";
            this.cerca_button.UseVisualStyleBackColor = true;
            this.cerca_button.Click += new System.EventHandler(this.Cerca_button_Click);
            // 
            // Bambini_pic
            // 
            this.Bambini_pic.Location = new System.Drawing.Point(140, 240);
            this.Bambini_pic.Name = "Bambini_pic";
            this.Bambini_pic.Size = new System.Drawing.Size(350, 350);
            this.Bambini_pic.TabIndex = 129;
            this.Bambini_pic.TabStop = false;
            // 
            // AnnullaEliminaBambini
            // 
            this.AnnullaEliminaBambini.BackgroundImage = global::Maestre.Properties.Resources.Annulla;
            this.AnnullaEliminaBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnullaEliminaBambini.FlatAppearance.BorderSize = 0;
            this.AnnullaEliminaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnullaEliminaBambini.Location = new System.Drawing.Point(229, 636);
            this.AnnullaEliminaBambini.Name = "AnnullaEliminaBambini";
            this.AnnullaEliminaBambini.Size = new System.Drawing.Size(380, 120);
            this.AnnullaEliminaBambini.TabIndex = 79;
            this.AnnullaEliminaBambini.UseVisualStyleBackColor = true;
            this.AnnullaEliminaBambini.Click += new System.EventHandler(this.AnnullaEliminaBambini_Click);
            // 
            // ConfermaEliminaBambini
            // 
            this.ConfermaEliminaBambini.BackgroundImage = global::Maestre.Properties.Resources.Conferma;
            this.ConfermaEliminaBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfermaEliminaBambini.FlatAppearance.BorderSize = 0;
            this.ConfermaEliminaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaEliminaBambini.Location = new System.Drawing.Point(758, 637);
            this.ConfermaEliminaBambini.Name = "ConfermaEliminaBambini";
            this.ConfermaEliminaBambini.Size = new System.Drawing.Size(380, 120);
            this.ConfermaEliminaBambini.TabIndex = 78;
            this.ConfermaEliminaBambini.UseVisualStyleBackColor = true;
            this.ConfermaEliminaBambini.Click += new System.EventHandler(this.ConfermaEliminaBambini_Click);
            // 
            // AiutoCancellaBambino
            // 
            this.AiutoCancellaBambino.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoCancellaBambino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoCancellaBambino.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AiutoCancellaBambino.FlatAppearance.BorderSize = 0;
            this.AiutoCancellaBambino.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AiutoCancellaBambino.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AiutoCancellaBambino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoCancellaBambino.Location = new System.Drawing.Point(1235, 11);
            this.AiutoCancellaBambino.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoCancellaBambino.Name = "AiutoCancellaBambino";
            this.AiutoCancellaBambino.Size = new System.Drawing.Size(120, 120);
            this.AiutoCancellaBambino.TabIndex = 48;
            this.AiutoCancellaBambino.UseVisualStyleBackColor = true;
            this.AiutoCancellaBambino.Click += new System.EventHandler(this.AiutoCancellaBambino_Click);
            // 
            // CancellaBambino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.cerca_button);
            this.Controls.Add(this.Bambini_pic);
            this.Controls.Add(this.CognomeDelBambini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnnullaEliminaBambini);
            this.Controls.Add(this.ConfermaEliminaBambini);
            this.Controls.Add(this.NomeDelBambini);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.TabellaBambini);
            this.Controls.Add(this.AiutoCancellaBambino);
            this.Controls.Add(this.libro_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancellaBambino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancellaBambino";
            this.Load += new System.EventHandler(this.CancellaBambino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AiutoCancellaBambino;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.Button AnnullaEliminaBambini;
        private System.Windows.Forms.Button ConfermaEliminaBambini;
        private System.Windows.Forms.TextBox NomeDelBambini;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.DataGridView TabellaBambini;
        private System.Windows.Forms.TextBox CognomeDelBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Bambini_pic;
        private System.Windows.Forms.Button cerca_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsBambini;
    }
}