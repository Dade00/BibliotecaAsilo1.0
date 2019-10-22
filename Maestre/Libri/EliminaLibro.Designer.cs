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
            this.ConfermaEliminaLibro = new System.Windows.Forms.Button();
            this.AnnullaEliminaLibro = new System.Windows.Forms.Button();
            this.Libri_pic = new System.Windows.Forms.PictureBox();
            this.AiutoAggiungiLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Libri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Libri_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Location = new System.Drawing.Point(642, 64);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(83, 13);
            this.libro_label.TabIndex = 68;
            this.libro_label.Text = "Elimina Un Libro";
            this.libro_label.Click += new System.EventHandler(this.Libro_label_Click);
            // 
            // Libri
            // 
            this.Libri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Libri.Location = new System.Drawing.Point(442, 246);
            this.Libri.Margin = new System.Windows.Forms.Padding(2);
            this.Libri.Name = "Libri";
            this.Libri.RowHeadersWidth = 62;
            this.Libri.RowTemplate.Height = 28;
            this.Libri.Size = new System.Drawing.Size(700, 200);
            this.Libri.TabIndex = 69;
            // 
            // TitotloDelLibro
            // 
            this.TitotloDelLibro.Location = new System.Drawing.Point(609, 176);
            this.TitotloDelLibro.Margin = new System.Windows.Forms.Padding(2);
            this.TitotloDelLibro.Name = "TitotloDelLibro";
            this.TitotloDelLibro.Size = new System.Drawing.Size(237, 20);
            this.TitotloDelLibro.TabIndex = 71;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(520, 179);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(85, 13);
            this.nome_label.TabIndex = 70;
            this.nome_label.Text = "CERCA TITOLO";
            this.nome_label.Click += new System.EventHandler(this.Nome_label_Click);
            // 
            // ConfermaEliminaLibro
            // 
            this.ConfermaEliminaLibro.Location = new System.Drawing.Point(762, 513);
            this.ConfermaEliminaLibro.Name = "ConfermaEliminaLibro";
            this.ConfermaEliminaLibro.Size = new System.Drawing.Size(380, 120);
            this.ConfermaEliminaLibro.TabIndex = 72;
            this.ConfermaEliminaLibro.Text = "CONFERMA";
            this.ConfermaEliminaLibro.UseVisualStyleBackColor = true;
            // 
            // AnnullaEliminaLibro
            // 
            this.AnnullaEliminaLibro.Location = new System.Drawing.Point(224, 513);
            this.AnnullaEliminaLibro.Name = "AnnullaEliminaLibro";
            this.AnnullaEliminaLibro.Size = new System.Drawing.Size(380, 120);
            this.AnnullaEliminaLibro.TabIndex = 73;
            this.AnnullaEliminaLibro.Text = "ANNULLA";
            this.AnnullaEliminaLibro.UseVisualStyleBackColor = true;
            this.AnnullaEliminaLibro.Click += new System.EventHandler(this.AnnullaEliminaLibro_Click);
            // 
            // Libri_pic
            // 
            this.Libri_pic.Location = new System.Drawing.Point(61, 96);
            this.Libri_pic.Name = "Libri_pic";
            this.Libri_pic.Size = new System.Drawing.Size(350, 350);
            this.Libri_pic.TabIndex = 98;
            this.Libri_pic.TabStop = false;
            // 
            // AiutoAggiungiLibro
            // 
            this.AiutoAggiungiLibro.Location = new System.Drawing.Point(1125, 11);
            this.AiutoAggiungiLibro.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoAggiungiLibro.Name = "AiutoAggiungiLibro";
            this.AiutoAggiungiLibro.Size = new System.Drawing.Size(230, 80);
            this.AiutoAggiungiLibro.TabIndex = 99;
            this.AiutoAggiungiLibro.Text = "AIUTO";
            this.AiutoAggiungiLibro.UseVisualStyleBackColor = true;
            // 
            // EliminaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
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
    }
}