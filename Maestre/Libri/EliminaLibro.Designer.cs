namespace Maestre.Libri
{
    partial class EliminaLibro
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
            this.libro_label = new System.Windows.Forms.Label();
            this.Libri = new System.Windows.Forms.DataGridView();
            this.TitotloDelLibro = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.CognomeDelBambini = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cerca_button = new System.Windows.Forms.Button();
            this.AiutoAggiungiLibro = new System.Windows.Forms.Button();
            this.Libri_pic = new System.Windows.Forms.PictureBox();
            this.AnnullaEliminaLibro = new System.Windows.Forms.Button();
            this.ConfermaEliminaLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Libri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold);
            this.libro_label.Location = new System.Drawing.Point(481, 11);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(407, 58);
            this.libro_label.TabIndex = 68;
            this.libro_label.Text = "Elimina un libro";
            this.libro_label.Click += new System.EventHandler(this.Libro_label_Click);
            // 
            // Libri
            // 
            this.Libri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Libri.Location = new System.Drawing.Point(509, 240);
            this.Libri.Margin = new System.Windows.Forms.Padding(2);
            this.Libri.Name = "Libri";
            this.Libri.RowHeadersWidth = 62;
            this.Libri.RowTemplate.Height = 28;
            this.Libri.Size = new System.Drawing.Size(690, 350);
            this.Libri.TabIndex = 69;
            // 
            // TitotloDelLibro
            // 
            this.TitotloDelLibro.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.TitotloDelLibro.Location = new System.Drawing.Point(565, 92);
            this.TitotloDelLibro.Margin = new System.Windows.Forms.Padding(2);
            this.TitotloDelLibro.Name = "TitotloDelLibro";
            this.TitotloDelLibro.Size = new System.Drawing.Size(312, 30);
            this.TitotloDelLibro.TabIndex = 71;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.nome_label.Location = new System.Drawing.Point(385, 97);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(170, 25);
            this.nome_label.TabIndex = 70;
            this.nome_label.Text = "CERCA TITOLO";
            this.nome_label.Click += new System.EventHandler(this.Nome_label_Click);
            // 
            // CognomeDelBambini
            // 
            this.CognomeDelBambini.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.CognomeDelBambini.Location = new System.Drawing.Point(565, 137);
            this.CognomeDelBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CognomeDelBambini.Name = "CognomeDelBambini";
            this.CognomeDelBambini.Size = new System.Drawing.Size(312, 30);
            this.CognomeDelBambini.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 132;
            this.label1.Text = "CERCA AUTORE";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("GROBOLD", 14F);
            this.textBox1.Location = new System.Drawing.Point(565, 184);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 30);
            this.textBox1.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 134;
            this.label2.Text = "CERCA GENERE";
            // 
            // cerca_button
            // 
            this.cerca_button.BackgroundImage = global::Maestre.Properties.Resources.cerca;
            this.cerca_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cerca_button.FlatAppearance.BorderSize = 0;
            this.cerca_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerca_button.Location = new System.Drawing.Point(908, 129);
            this.cerca_button.Name = "cerca_button";
            this.cerca_button.Size = new System.Drawing.Size(220, 50);
            this.cerca_button.TabIndex = 131;
            this.cerca_button.UseVisualStyleBackColor = true;
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
            this.AiutoAggiungiLibro.TabIndex = 99;
            this.AiutoAggiungiLibro.UseVisualStyleBackColor = true;
            this.AiutoAggiungiLibro.Click += new System.EventHandler(this.AiutoAggiungiLibro_Click);
            // 
            // Libri_pic
            // 
            this.Libri_pic.Location = new System.Drawing.Point(140, 240);
            this.Libri_pic.Name = "Libri_pic";
            this.Libri_pic.Size = new System.Drawing.Size(350, 350);
            this.Libri_pic.TabIndex = 98;
            this.Libri_pic.TabStop = false;
            // 
            // AnnullaEliminaLibro
            // 
            this.AnnullaEliminaLibro.BackgroundImage = global::Maestre.Properties.Resources.Annulla;
            this.AnnullaEliminaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AnnullaEliminaLibro.FlatAppearance.BorderSize = 0;
            this.AnnullaEliminaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnnullaEliminaLibro.Location = new System.Drawing.Point(229, 636);
            this.AnnullaEliminaLibro.Name = "AnnullaEliminaLibro";
            this.AnnullaEliminaLibro.Size = new System.Drawing.Size(380, 120);
            this.AnnullaEliminaLibro.TabIndex = 73;
            this.AnnullaEliminaLibro.UseVisualStyleBackColor = true;
            this.AnnullaEliminaLibro.Click += new System.EventHandler(this.AnnullaEliminaLibro_Click);
            // 
            // ConfermaEliminaLibro
            // 
            this.ConfermaEliminaLibro.BackgroundImage = global::Maestre.Properties.Resources.Conferma;
            this.ConfermaEliminaLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ConfermaEliminaLibro.FlatAppearance.BorderSize = 0;
            this.ConfermaEliminaLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfermaEliminaLibro.Location = new System.Drawing.Point(758, 637);
            this.ConfermaEliminaLibro.Name = "ConfermaEliminaLibro";
            this.ConfermaEliminaLibro.Size = new System.Drawing.Size(380, 120);
            this.ConfermaEliminaLibro.TabIndex = 72;
            this.ConfermaEliminaLibro.UseVisualStyleBackColor = true;
            this.ConfermaEliminaLibro.Click += new System.EventHandler(this.ConfermaEliminaLibro_Click);
            // 
            // EliminaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CognomeDelBambini);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cerca_button);
            this.Controls.Add(this.AiutoAggiungiLibro);
            this.Controls.Add(this.Libri_pic);
            this.Controls.Add(this.AnnullaEliminaLibro);
            this.Controls.Add(this.ConfermaEliminaLibro);
            this.Controls.Add(this.TitotloDelLibro);
            this.Controls.Add(this.nome_label);
            this.Controls.Add(this.Libri);
            this.Controls.Add(this.libro_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EliminaLibro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EliminaLibro";
            ((System.ComponentModel.ISupportInitialize)(this.Libri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.DataGridView Libri;
        private System.Windows.Forms.TextBox TitotloDelLibro;
        private System.Windows.Forms.Label nome_label;
        private System.Windows.Forms.Button ConfermaEliminaLibro;
        private System.Windows.Forms.Button AnnullaEliminaLibro;
        private System.Windows.Forms.PictureBox Libri_pic;
        private System.Windows.Forms.Button AiutoAggiungiLibro;
        private System.Windows.Forms.Button cerca_button;
        private System.Windows.Forms.TextBox CognomeDelBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}