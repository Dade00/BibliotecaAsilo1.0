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
            this.AiutoCancellaBambino = new System.Windows.Forms.Button();
            this.libro_label = new System.Windows.Forms.Label();
            this.AnnullaEliminaBambini = new System.Windows.Forms.Button();
            this.ConfermaEliminaBambini = new System.Windows.Forms.Button();
            this.NomeDelBambini = new System.Windows.Forms.TextBox();
            this.nome_label = new System.Windows.Forms.Label();
            this.Bambini = new System.Windows.Forms.DataGridView();
            this.CognomeDelBambini = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Bambini_pic = new System.Windows.Forms.PictureBox();
            this.cerca_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // AiutoCancellaBambino
            // 
            this.AiutoCancellaBambino.Location = new System.Drawing.Point(1125, 11);
            this.AiutoCancellaBambino.Margin = new System.Windows.Forms.Padding(2);
            this.AiutoCancellaBambino.Name = "AiutoCancellaBambino";
            this.AiutoCancellaBambino.Size = new System.Drawing.Size(230, 80);
            this.AiutoCancellaBambino.TabIndex = 48;
            this.AiutoCancellaBambino.Text = "AIUTO";
            this.AiutoCancellaBambino.UseVisualStyleBackColor = true;
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Location = new System.Drawing.Point(564, 45);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(239, 13);
            this.libro_label.TabIndex = 39;
            this.libro_label.Text = "Cerca Il Nome Del Bambino Che Vuoi Cancellare ";
            this.libro_label.Click += new System.EventHandler(this.Libro_label_Click);
            // 
            // AnnullaEliminaBambini
            // 
            this.AnnullaEliminaBambini.Location = new System.Drawing.Point(227, 536);
            this.AnnullaEliminaBambini.Name = "AnnullaEliminaBambini";
            this.AnnullaEliminaBambini.Size = new System.Drawing.Size(380, 120);
            this.AnnullaEliminaBambini.TabIndex = 79;
            this.AnnullaEliminaBambini.Text = "ANNULLA";
            this.AnnullaEliminaBambini.UseVisualStyleBackColor = true;
            this.AnnullaEliminaBambini.Click += new System.EventHandler(this.AnnullaEliminaBambini_Click);
            // 
            // ConfermaEliminaBambini
            // 
            this.ConfermaEliminaBambini.Location = new System.Drawing.Point(760, 536);
            this.ConfermaEliminaBambini.Name = "ConfermaEliminaBambini";
            this.ConfermaEliminaBambini.Size = new System.Drawing.Size(380, 120);
            this.ConfermaEliminaBambini.TabIndex = 78;
            this.ConfermaEliminaBambini.Text = "CONFERMA";
            this.ConfermaEliminaBambini.UseVisualStyleBackColor = true;
            // 
            // NomeDelBambini
            // 
            this.NomeDelBambini.Location = new System.Drawing.Point(617, 141);
            this.NomeDelBambini.Margin = new System.Windows.Forms.Padding(2);
            this.NomeDelBambini.Name = "NomeDelBambini";
            this.NomeDelBambini.Size = new System.Drawing.Size(237, 20);
            this.NomeDelBambini.TabIndex = 77;
            // 
            // nome_label
            // 
            this.nome_label.AutoSize = true;
            this.nome_label.Location = new System.Drawing.Point(512, 144);
            this.nome_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nome_label.Name = "nome_label";
            this.nome_label.Size = new System.Drawing.Size(78, 13);
            this.nome_label.TabIndex = 76;
            this.nome_label.Text = "CERCA NOME";
            // 
            // Bambini
            // 
            this.Bambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bambini.Location = new System.Drawing.Point(450, 280);
            this.Bambini.Margin = new System.Windows.Forms.Padding(2);
            this.Bambini.Name = "Bambini";
            this.Bambini.RowHeadersWidth = 62;
            this.Bambini.RowTemplate.Height = 28;
            this.Bambini.Size = new System.Drawing.Size(690, 200);
            this.Bambini.TabIndex = 75;
            // 
            // CognomeDelBambini
            // 
            this.CognomeDelBambini.Location = new System.Drawing.Point(617, 177);
            this.CognomeDelBambini.Margin = new System.Windows.Forms.Padding(2);
            this.CognomeDelBambini.Name = "CognomeDelBambini";
            this.CognomeDelBambini.Size = new System.Drawing.Size(237, 20);
            this.CognomeDelBambini.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "CERCA COGNOME";
            // 
            // Bambini_pic
            // 
            this.Bambini_pic.Location = new System.Drawing.Point(79, 130);
            this.Bambini_pic.Name = "Bambini_pic";
            this.Bambini_pic.Size = new System.Drawing.Size(350, 350);
            this.Bambini_pic.TabIndex = 129;
            this.Bambini_pic.TabStop = false;
            // 
            // cerca_button
            // 
            this.cerca_button.Location = new System.Drawing.Point(875, 144);
            this.cerca_button.Name = "cerca_button";
            this.cerca_button.Size = new System.Drawing.Size(220, 50);
            this.cerca_button.TabIndex = 130;
            this.cerca_button.Text = "button1";
            this.cerca_button.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.Bambini);
            this.Controls.Add(this.AiutoCancellaBambino);
            this.Controls.Add(this.libro_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancellaBambino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancellaBambino";
            ((System.ComponentModel.ISupportInitialize)(this.Bambini)).EndInit();
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
        private System.Windows.Forms.DataGridView Bambini;
        private System.Windows.Forms.TextBox CognomeDelBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Bambini_pic;
        private System.Windows.Forms.Button cerca_button;
    }
}