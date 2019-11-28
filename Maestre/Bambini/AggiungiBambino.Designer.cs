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
            this.label3 = new System.Windows.Forms.Label();
            this.TabellaBambini = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.AnnullaModificaBambini = new System.Windows.Forms.Button();
            this.ConfermaModificaBambini = new System.Windows.Forms.Button();
            this.Bambini_pic = new System.Windows.Forms.PictureBox();
            this.AiutoAggiungiBambini = new System.Windows.Forms.Button();
            this.CercaFotoBambini = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.cognome_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nome_tb = new System.Windows.Forms.TextBox();
            this.labeltitolo = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(443, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 122;
            this.label3.Text = "FOTO";
            // 
            // TabellaBambini
            // 
            this.TabellaBambini.AllowUserToAddRows = false;
            this.TabellaBambini.AllowUserToDeleteRows = false;
            this.TabellaBambini.AllowUserToOrderColumns = true;
            this.TabellaBambini.AllowUserToResizeColumns = false;
            this.TabellaBambini.AllowUserToResizeRows = false;
            this.TabellaBambini.AutoGenerateColumns = false;
            this.TabellaBambini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabellaBambini.ColumnHeadersHeight = 35;
            this.TabellaBambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.TabellaBambini.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.TabellaBambini.DataSource = this.bsBambini;
            this.TabellaBambini.Location = new System.Drawing.Point(410, 281);
            this.TabellaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBambini.Name = "TabellaBambini";
            this.TabellaBambini.ReadOnly = true;
            this.TabellaBambini.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TabellaBambini.RowHeadersVisible = false;
            this.TabellaBambini.RowHeadersWidth = 100;
            this.TabellaBambini.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.TabellaBambini.RowTemplate.Height = 28;
            this.TabellaBambini.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TabellaBambini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabellaBambini.Size = new System.Drawing.Size(945, 350);
            this.TabellaBambini.TabIndex = 121;
            this.TabellaBambini.SelectionChanged += new System.EventHandler(this.TabellaBambini_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cognome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cognome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Classe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Classe";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DataNascita";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data di nascita";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // bsBambini
            // 
            this.bsBambini.DataSource = typeof(Classi.Bambino);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(815, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(118, 54);
            this.label2.TabIndex = 119;
            this.label2.Text = "DATA DI NASCITA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClasseAddBambini
            // 
            this.ClasseAddBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.ClasseAddBambini.Location = new System.Drawing.Point(938, 104);
            this.ClasseAddBambini.Margin = new System.Windows.Forms.Padding(2);
            this.ClasseAddBambini.Name = "ClasseAddBambini";
            this.ClasseAddBambini.Size = new System.Drawing.Size(66, 30);
            this.ClasseAddBambini.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(831, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 117;
            this.label1.Text = "CLASSE";
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.BackColor = System.Drawing.Color.Transparent;
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
            this.CognomeAddBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.CognomeAddBambini.Location = new System.Drawing.Point(514, 157);
            this.CognomeAddBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CognomeAddBambini.Name = "CognomeAddBambini";
            this.CognomeAddBambini.Size = new System.Drawing.Size(286, 30);
            this.CognomeAddBambini.TabIndex = 115;
            // 
            // NomeAddBambini
            // 
            this.NomeAddBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.NomeAddBambini.Location = new System.Drawing.Point(514, 106);
            this.NomeAddBambini.Margin = new System.Windows.Forms.Padding(2);
            this.NomeAddBambini.Name = "NomeAddBambini";
            this.NomeAddBambini.Size = new System.Drawing.Size(283, 30);
            this.NomeAddBambini.TabIndex = 114;
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.cognome_label.Location = new System.Drawing.Point(385, 162);
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
            this.nome_label.Location = new System.Drawing.Point(434, 108);
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
            this.nascitaAddBambini.CustomFormat = "";
            this.nascitaAddBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.nascitaAddBambini.Location = new System.Drawing.Point(938, 154);
            this.nascitaAddBambini.Name = "nascitaAddBambini";
            this.nascitaAddBambini.Size = new System.Drawing.Size(289, 30);
            this.nascitaAddBambini.TabIndex = 129;
            // 
            // AnnullaModificaBambini
            // 
            this.AnnullaModificaBambini.BackColor = System.Drawing.Color.Transparent;
            this.AnnullaModificaBambini.BackgroundImage = global::Maestre.Properties.Resources.Annulla;
            this.AnnullaModificaBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnullaModificaBambini.FlatAppearance.BorderSize = 0;
            this.AnnullaModificaBambini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AnnullaModificaBambini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AnnullaModificaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnullaModificaBambini.Location = new System.Drawing.Point(492, 636);
            this.AnnullaModificaBambini.Name = "AnnullaModificaBambini";
            this.AnnullaModificaBambini.Size = new System.Drawing.Size(383, 120);
            this.AnnullaModificaBambini.TabIndex = 127;
            this.AnnullaModificaBambini.UseVisualStyleBackColor = false;
            this.AnnullaModificaBambini.Click += new System.EventHandler(this.AnnullaModificaBambini_Click);
            // 
            // ConfermaModificaBambini
            // 
            this.ConfermaModificaBambini.BackColor = System.Drawing.Color.Transparent;
            this.ConfermaModificaBambini.BackgroundImage = global::Maestre.Properties.Resources.Aggiungi;
            this.ConfermaModificaBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfermaModificaBambini.FlatAppearance.BorderSize = 0;
            this.ConfermaModificaBambini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ConfermaModificaBambini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ConfermaModificaBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaModificaBambini.Location = new System.Drawing.Point(938, 198);
            this.ConfermaModificaBambini.Name = "ConfermaModificaBambini";
            this.ConfermaModificaBambini.Size = new System.Drawing.Size(246, 78);
            this.ConfermaModificaBambini.TabIndex = 126;
            this.ConfermaModificaBambini.UseVisualStyleBackColor = false;
            this.ConfermaModificaBambini.Click += new System.EventHandler(this.ConfermaModificaBambini_Click);
            // 
            // Bambini_pic
            // 
            this.Bambini_pic.BackColor = System.Drawing.Color.Transparent;
            this.Bambini_pic.InitialImage = null;
            this.Bambini_pic.Location = new System.Drawing.Point(129, 18);
            this.Bambini_pic.Name = "Bambini_pic";
            this.Bambini_pic.Size = new System.Drawing.Size(250, 250);
            this.Bambini_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bambini_pic.TabIndex = 128;
            this.Bambini_pic.TabStop = false;
            // 
            // AiutoAggiungiBambini
            // 
            this.AiutoAggiungiBambini.BackColor = System.Drawing.Color.Transparent;
            this.AiutoAggiungiBambini.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoAggiungiBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoAggiungiBambini.FlatAppearance.BorderSize = 0;
            this.AiutoAggiungiBambini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AiutoAggiungiBambini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AiutoAggiungiBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoAggiungiBambini.Location = new System.Drawing.Point(1235, 11);
            this.AiutoAggiungiBambini.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoAggiungiBambini.Name = "AiutoAggiungiBambini";
            this.AiutoAggiungiBambini.Size = new System.Drawing.Size(120, 120);
            this.AiutoAggiungiBambini.TabIndex = 125;
            this.AiutoAggiungiBambini.UseVisualStyleBackColor = false;
            this.AiutoAggiungiBambini.Click += new System.EventHandler(this.AiutoAggiungiBambini_Click);
            // 
            // CercaFotoBambini
            // 
            this.CercaFotoBambini.BackColor = System.Drawing.Color.Transparent;
            this.CercaFotoBambini.BackgroundImage = global::Maestre.Properties.Resources.Inserisci_foto;
            this.CercaFotoBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CercaFotoBambini.FlatAppearance.BorderSize = 0;
            this.CercaFotoBambini.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CercaFotoBambini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CercaFotoBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CercaFotoBambini.Location = new System.Drawing.Point(514, 207);
            this.CercaFotoBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CercaFotoBambini.Name = "CercaFotoBambini";
            this.CercaFotoBambini.Size = new System.Drawing.Size(130, 45);
            this.CercaFotoBambini.TabIndex = 124;
            this.CercaFotoBambini.UseVisualStyleBackColor = false;
            this.CercaFotoBambini.Click += new System.EventHandler(this.CercaFotoBambini_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.Color.Transparent;
            this.search_button.BackgroundImage = global::Maestre.Properties.Resources.cerca;
            this.search_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.search_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.search_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Location = new System.Drawing.Point(92, 552);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(182, 58);
            this.search_button.TabIndex = 135;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // cognome_tb
            // 
            this.cognome_tb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.cognome_tb.Location = new System.Drawing.Point(17, 483);
            this.cognome_tb.Name = "cognome_tb";
            this.cognome_tb.Size = new System.Drawing.Size(362, 30);
            this.cognome_tb.TabIndex = 134;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("GROBOLD", 16F);
            this.label5.Location = new System.Drawing.Point(13, 453);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 27);
            this.label5.TabIndex = 133;
            this.label5.Text = "Cognome:";
            // 
            // nome_tb
            // 
            this.nome_tb.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.nome_tb.Location = new System.Drawing.Point(17, 391);
            this.nome_tb.Name = "nome_tb";
            this.nome_tb.Size = new System.Drawing.Size(362, 30);
            this.nome_tb.TabIndex = 132;
            // 
            // labeltitolo
            // 
            this.labeltitolo.AutoSize = true;
            this.labeltitolo.BackColor = System.Drawing.Color.Transparent;
            this.labeltitolo.Font = new System.Drawing.Font("GROBOLD", 16F);
            this.labeltitolo.Location = new System.Drawing.Point(13, 361);
            this.labeltitolo.Name = "labeltitolo";
            this.labeltitolo.Size = new System.Drawing.Size(80, 27);
            this.labeltitolo.TabIndex = 131;
            this.labeltitolo.Text = "Nome:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("GROBOLD", 20F);
            this.label.Location = new System.Drawing.Point(12, 308);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(260, 33);
            this.label.TabIndex = 130;
            this.label.Text = "Cerca un bambino:";
            // 
            // update
            // 
            this.update.Enabled = true;
            // 
            // AggiungiBambino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Maestre.Properties.Resources.Sfondo_maestre;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.cognome_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nome_tb);
            this.Controls.Add(this.labeltitolo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.AnnullaModificaBambini);
            this.Controls.Add(this.ConfermaModificaBambini);
            this.Controls.Add(this.nascitaAddBambini);
            this.Controls.Add(this.Bambini_pic);
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
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button search_button;
        private TextBox cognome_tb;
        private Label label5;
        private TextBox nome_tb;
        private Label labeltitolo;
        private Label label;
        private Timer update;
    }
}