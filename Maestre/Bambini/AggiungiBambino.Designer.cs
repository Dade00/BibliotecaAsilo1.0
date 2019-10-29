using System.Windows.Forms;

namespace Maestre.Bambini
{
    partial class AggiungiBambino
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
            this.AiutoAggiungiBambini = new System.Windows.Forms.Button();
            this.CercaFotoBambini = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TabellaBambini = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBambini = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.ClasseAddBambini = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libro_label = new System.Windows.Forms.Label();
            this.CognomeAddBambini = new System.Windows.Forms.TextBox();
            this.NomeAddBambini = new System.Windows.Forms.TextBox();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.nascitaAddBambini = new System.Windows.Forms.DateTimePicker();
            this.Bambini_pic = new System.Windows.Forms.PictureBox();
            this.AnnullaModificaBambini = new System.Windows.Forms.Button();
            this.ConfermaModificaBambini = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // AiutoAggiungiBambini
            // 
            this.AiutoAggiungiBambini.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoAggiungiBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoAggiungiBambini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.AiutoAggiungiBambini.FlatAppearance.BorderSize = 0;
            this.AiutoAggiungiBambini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.AiutoAggiungiBambini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.AiutoAggiungiBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoAggiungiBambini.Location = new System.Drawing.Point(1235, 11);
            this.AiutoAggiungiBambini.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoAggiungiBambini.Name = "AiutoAggiungiBambini";
            this.AiutoAggiungiBambini.Size = new System.Drawing.Size(120, 120);
            this.AiutoAggiungiBambini.TabIndex = 125;
            this.AiutoAggiungiBambini.UseVisualStyleBackColor = true;
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
            this.CercaFotoBambini.Location = new System.Drawing.Point(633, 213);
            this.CercaFotoBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CercaFotoBambini.Name = "CercaFotoBambini";
            this.CercaFotoBambini.Size = new System.Drawing.Size(130, 45);
            this.CercaFotoBambini.TabIndex = 124;
            this.CercaFotoBambini.UseVisualStyleBackColor = true;
            this.CercaFotoBambini.Click += new System.EventHandler(this.CercaFotoBambini_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(562, 220);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 122;
            this.label3.Text = "FOTO";
            // 
            // TabellaBambini
            // 
            this.TabellaBambini.AutoGenerateColumns = false;
            this.TabellaBambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBambini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.TabellaBambini.DataSource = this.bsBambini;
            this.TabellaBambini.Location = new System.Drawing.Point(509, 278);
            this.TabellaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBambini.Name = "TabellaBambini";
            this.TabellaBambini.RowHeadersWidth = 62;
            this.TabellaBambini.RowTemplate.Height = 28;
            this.TabellaBambini.Size = new System.Drawing.Size(690, 200);
            this.TabellaBambini.TabIndex = 121;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cognome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cognome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataNascita";
            this.dataGridViewTextBoxColumn3.HeaderText = "DataNascita";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Classe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Classe";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bsBambini
            // 
            this.bsBambini.DataSource = typeof(Classi.Bambino);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(884, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(118, 54);
            this.label2.TabIndex = 119;
            this.label2.Text = "ANNO DI NASCITA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClasseAddBambini
            // 
            this.ClasseAddBambini.Font = new System.Drawing.Font("GROBOLD", 10F);
            this.ClasseAddBambini.Location = new System.Drawing.Point(1007, 116);
            this.ClasseAddBambini.Margin = new System.Windows.Forms.Padding(2);
            this.ClasseAddBambini.Name = "ClasseAddBambini";
            this.ClasseAddBambini.Size = new System.Drawing.Size(66, 23);
            this.ClasseAddBambini.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(900, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 117;
            this.label1.Text = "CLASSE";
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libro_label.Location = new System.Drawing.Point(412, 9);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(543, 58);
            this.libro_label.TabIndex = 116;
            this.libro_label.Text = "Aggiungi un bambino";
            this.libro_label.Click += new System.EventHandler(this.libro_label_Click);
            // 
            // CognomeAddBambini
            // 
            this.CognomeAddBambini.Font = new System.Drawing.Font("GROBOLD", 10F);
            this.CognomeAddBambini.Location = new System.Drawing.Point(633, 175);
            this.CognomeAddBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CognomeAddBambini.Name = "CognomeAddBambini";
            this.CognomeAddBambini.Size = new System.Drawing.Size(237, 23);
            this.CognomeAddBambini.TabIndex = 115;
            // 
            // NomeAddBambini
            // 
            this.NomeAddBambini.Font = new System.Drawing.Font("GROBOLD", 10F);
            this.NomeAddBambini.Location = new System.Drawing.Point(630, 116);
            this.NomeAddBambini.Margin = new System.Windows.Forms.Padding(2);
            this.NomeAddBambini.Name = "NomeAddBambini";
            this.NomeAddBambini.Size = new System.Drawing.Size(237, 23);
            this.NomeAddBambini.TabIndex = 114;
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.cognome_label.Location = new System.Drawing.Point(504, 171);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(125, 25);
            this.cognome_label.TabIndex = 113;
            this.cognome_label.Text = "COGNOME";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.nome_label.Location = new System.Drawing.Point(550, 116);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(76, 25);
            this.nome_label.TabIndex = 112;
            this.nome_label.Text = "NOME";
            // 
            // ofdFoto
            // 
            this.ofdFoto.Filter = "Foto del bambino (*.BMP;*.GIF;*.JPG;*.PNG)|*.BMP;*.GIF;*.JPG;*.PNG";
            // 
            // nascitaAddBambini
            // 
            this.nascitaAddBambini.Font = new System.Drawing.Font("GROBOLD", 10F);
            this.nascitaAddBambini.Location = new System.Drawing.Point(1007, 173);
            this.nascitaAddBambini.Name = "nascitaAddBambini";
            this.nascitaAddBambini.Size = new System.Drawing.Size(237, 23);
            this.nascitaAddBambini.TabIndex = 129;
            // 
            // Bambini_pic
            // 
            this.Bambini_pic.Location = new System.Drawing.Point(131, 128);
            this.Bambini_pic.Name = "Bambini_pic";
            this.Bambini_pic.Size = new System.Drawing.Size(350, 350);
            this.Bambini_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bambini_pic.TabIndex = 128;
            this.Bambini_pic.TabStop = false;
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
            this.AnnullaModificaBambini.Location = new System.Drawing.Point(219, 529);
            this.AnnullaModificaBambini.Name = "AnnullaModificaBambini";
            this.AnnullaModificaBambini.Size = new System.Drawing.Size(383, 120);
            this.AnnullaModificaBambini.TabIndex = 127;
            this.AnnullaModificaBambini.UseVisualStyleBackColor = true;
            this.AnnullaModificaBambini.Click += new System.EventHandler(this.AnnullaModificaBambini_Click);
            // 
            // ConfermaModificaBambini
            // 
            this.ConfermaModificaBambini.BackgroundImage = global::Maestre.Properties.Resources.Conferma;
            this.ConfermaModificaBambini.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ConfermaModificaBambini.FlatAppearance.BorderSize = 0;
            this.ConfermaModificaBambini.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.ConfermaModificaBambini.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.ConfermaModificaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaModificaBambini.Location = new System.Drawing.Point(748, 529);
            this.ConfermaModificaBambini.Name = "ConfermaModificaBambini";
            this.ConfermaModificaBambini.Size = new System.Drawing.Size(380, 120);
            this.ConfermaModificaBambini.TabIndex = 126;
            this.ConfermaModificaBambini.UseVisualStyleBackColor = true;
            this.ConfermaModificaBambini.Click += new System.EventHandler(this.ConfermaModificaBambini_Click);
            // 
            // AggiungiBambino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.nascitaAddBambini);
            this.Controls.Add(this.Bambini_pic);
            this.Controls.Add(this.AnnullaModificaBambini);
            this.Controls.Add(this.ConfermaModificaBambini);
            this.Controls.Add(this.AiutoAggiungiBambini);
            this.Controls.Add(this.CercaFotoBambini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TabellaBambini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClasseAddBambini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.CognomeAddBambini);
            this.Controls.Add(this.NomeAddBambini);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AggiungiBambino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AggiungiBambino";
            this.Load += new System.EventHandler(this.AggiungiBambino_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnnullaModificaBambini;
        private System.Windows.Forms.Button ConfermaModificaBambini;
        private System.Windows.Forms.Button AiutoAggiungiBambini;
        private System.Windows.Forms.Button CercaFotoBambini;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TabellaBambini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClasseAddBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.TextBox CognomeAddBambini;
        private System.Windows.Forms.TextBox NomeAddBambini;
        private System.Windows.Forms.Label cognome_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.PictureBox Bambini_pic;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.DateTimePicker nascitaAddBambini;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cognomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascitaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
        private BindingSource bsBambini;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}