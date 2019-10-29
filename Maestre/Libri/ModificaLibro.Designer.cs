namespace Maestre.Libri
{
    partial class ModificaLibro
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
            this.AiutoAggiungiLibro = new System.Windows.Forms.Button();
            this.CercaFotoLibro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TabellaBambini = new System.Windows.Forms.DataGridView();
            this.CodiceModLibro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GenereModLibro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libro_label = new System.Windows.Forms.Label();
            this.AutoreModLibro = new System.Windows.Forms.TextBox();
            this.TitotloModLibro = new System.Windows.Forms.TextBox();
            this.cognome_label = new System.Windows.Forms.Label();
            this.nome_label = new System.Windows.Forms.Label();
            this.ConfermaModificaLibro = new System.Windows.Forms.Button();
            this.AnnullaModificaLibro = new System.Windows.Forms.Button();
            this.Libri_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // AiutoAggiungiLibro
            // 
            this.AiutoAggiungiLibro.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoAggiungiLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoAggiungiLibro.FlatAppearance.BorderSize = 0;
            this.AiutoAggiungiLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoAggiungiLibro.Location = new System.Drawing.Point(1235, 11);
            this.AiutoAggiungiLibro.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoAggiungiLibro.Name = "AiutoAggiungiLibro";
            this.AiutoAggiungiLibro.Size = new System.Drawing.Size(120, 120);
            this.AiutoAggiungiLibro.TabIndex = 77;
            this.AiutoAggiungiLibro.UseVisualStyleBackColor = true;
            // 
            // CercaFotoLibro
            // 
            this.CercaFotoLibro.BackgroundImage = global::Maestre.Properties.Resources.Inserisci_foto;
            this.CercaFotoLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CercaFotoLibro.FlatAppearance.BorderSize = 0;
            this.CercaFotoLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CercaFotoLibro.Location = new System.Drawing.Point(625, 202);
            this.CercaFotoLibro.Margin = new System.Windows.Forms.Padding(2);
            this.CercaFotoLibro.Name = "CercaFotoLibro";
            this.CercaFotoLibro.Size = new System.Drawing.Size(130, 45);
            this.CercaFotoLibro.TabIndex = 76;
            this.CercaFotoLibro.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(547, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "FOTO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TabellaBambini
            // 
            this.TabellaBambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBambini.Location = new System.Drawing.Point(510, 270);
            this.TabellaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBambini.Name = "TabellaBambini";
            this.TabellaBambini.RowHeadersWidth = 62;
            this.TabellaBambini.RowTemplate.Height = 28;
            this.TabellaBambini.Size = new System.Drawing.Size(686, 200);
            this.TabellaBambini.TabIndex = 73;
            // 
            // CodiceModLibro
            // 
            this.CodiceModLibro.Location = new System.Drawing.Point(992, 168);
            this.CodiceModLibro.Margin = new System.Windows.Forms.Padding(2);
            this.CodiceModLibro.Name = "CodiceModLibro";
            this.CodiceModLibro.Size = new System.Drawing.Size(121, 20);
            this.CodiceModLibro.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(890, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "CODICE";
            // 
            // GenereModLibro
            // 
            this.GenereModLibro.Location = new System.Drawing.Point(992, 125);
            this.GenereModLibro.Margin = new System.Windows.Forms.Padding(2);
            this.GenereModLibro.Name = "GenereModLibro";
            this.GenereModLibro.Size = new System.Drawing.Size(121, 20);
            this.GenereModLibro.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(887, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "GENERE";
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libro_label.Location = new System.Drawing.Point(476, 9);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(441, 58);
            this.libro_label.TabIndex = 68;
            this.libro_label.Text = "Modifica un libro";
            this.libro_label.Click += new System.EventHandler(this.Libro_label_Click);
            // 
            // AutoreModLibro
            // 
            this.AutoreModLibro.Location = new System.Drawing.Point(625, 165);
            this.AutoreModLibro.Margin = new System.Windows.Forms.Padding(2);
            this.AutoreModLibro.Name = "AutoreModLibro";
            this.AutoreModLibro.Size = new System.Drawing.Size(237, 20);
            this.AutoreModLibro.TabIndex = 67;
            // 
            // TitotloModLibro
            // 
            this.TitotloModLibro.Location = new System.Drawing.Point(625, 126);
            this.TitotloModLibro.Margin = new System.Windows.Forms.Padding(2);
            this.TitotloModLibro.Name = "TitotloModLibro";
            this.TitotloModLibro.Size = new System.Drawing.Size(237, 20);
            this.TitotloModLibro.TabIndex = 66;
            // 
            // cognome_label
            // 
            this.cognome_label.AutoSize = true;
            this.cognome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.cognome_label.Location = new System.Drawing.Point(520, 162);
            this.cognome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cognome_label.Name = "cognome_label";
            this.cognome_label.Size = new System.Drawing.Size(98, 25);
            this.cognome_label.TabIndex = 65;
            this.cognome_label.Text = "AUTORE";
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.nome_label.Location = new System.Drawing.Point(529, 123);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(86, 25);
            this.nome_label.TabIndex = 64;
            this.nome_label.Text = "TITOLO";
            // 
            // ConfermaModificaLibro
            // 
            this.ConfermaModificaLibro.BackgroundImage = global::Maestre.Properties.Resources.Conferma;
            this.ConfermaModificaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfermaModificaLibro.FlatAppearance.BorderSize = 0;
            this.ConfermaModificaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaModificaLibro.Location = new System.Drawing.Point(755, 537);
            this.ConfermaModificaLibro.Name = "ConfermaModificaLibro";
            this.ConfermaModificaLibro.Size = new System.Drawing.Size(380, 120);
            this.ConfermaModificaLibro.TabIndex = 78;
            this.ConfermaModificaLibro.UseVisualStyleBackColor = true;
            // 
            // AnnullaModificaLibro
            // 
            this.AnnullaModificaLibro.BackgroundImage = global::Maestre.Properties.Resources.Annulla;
            this.AnnullaModificaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnullaModificaLibro.FlatAppearance.BorderSize = 0;
            this.AnnullaModificaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnullaModificaLibro.Location = new System.Drawing.Point(238, 537);
            this.AnnullaModificaLibro.Name = "AnnullaModificaLibro";
            this.AnnullaModificaLibro.Size = new System.Drawing.Size(380, 120);
            this.AnnullaModificaLibro.TabIndex = 79;
            this.AnnullaModificaLibro.UseVisualStyleBackColor = true;
            this.AnnullaModificaLibro.Click += new System.EventHandler(this.AnnullaModificaLibro_Click);
            // 
            // Libri_pic
            // 
            this.Libri_pic.Location = new System.Drawing.Point(120, 120);
            this.Libri_pic.Name = "Libri_pic";
            this.Libri_pic.Size = new System.Drawing.Size(350, 350);
            this.Libri_pic.TabIndex = 97;
            this.Libri_pic.TabStop = false;
            // 
            // ModificaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Libri_pic);
            this.Controls.Add(this.AnnullaModificaLibro);
            this.Controls.Add(this.ConfermaModificaLibro);
            this.Controls.Add(this.AiutoAggiungiLibro);
            this.Controls.Add(this.CercaFotoLibro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TabellaBambini);
            this.Controls.Add(this.CodiceModLibro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenereModLibro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.AutoreModLibro);
            this.Controls.Add(this.TitotloModLibro);
            this.Controls.Add(this.cognome_label);
            this.Controls.Add(this.nome_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModificaLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificaLibro";
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AiutoAggiungiLibro;
        private System.Windows.Forms.Button CercaFotoLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TabellaBambini;
        private System.Windows.Forms.TextBox CodiceModLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GenereModLibro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.TextBox AutoreModLibro;
        private System.Windows.Forms.TextBox TitotloModLibro;
        private System.Windows.Forms.Label cognome_label;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Button ConfermaModificaLibro;
        private System.Windows.Forms.Button AnnullaModificaLibro;
        private System.Windows.Forms.PictureBox Libri_pic;
    }
}