namespace Maestre.Statistiche_WIP_
{
    partial class LibriLettiDaBambino
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
            this.Indietro_Button = new System.Windows.Forms.Button();
            this.RicercaStatBambini = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeBambino = new System.Windows.Forms.TextBox();
            this.CognomeBambino = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AiutoStatistiche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Indietro_Button
            // 
            this.Indietro_Button.BackgroundImage = global::Maestre.Properties.Resources.Indietro;
            this.Indietro_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Indietro_Button.FlatAppearance.BorderSize = 0;
            this.Indietro_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Indietro_Button.Location = new System.Drawing.Point(266, 418);
            this.Indietro_Button.Name = "Indietro_Button";
            this.Indietro_Button.Size = new System.Drawing.Size(380, 120);
            this.Indietro_Button.TabIndex = 0;
            this.Indietro_Button.UseVisualStyleBackColor = true;
            this.Indietro_Button.Click += new System.EventHandler(this.Indietro_Button_Click);
            // 
            // RicercaStatBambini
            // 
            this.RicercaStatBambini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RicercaStatBambini.FlatAppearance.BorderSize = 0;
            this.RicercaStatBambini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RicercaStatBambini.Location = new System.Drawing.Point(736, 418);
            this.RicercaStatBambini.Name = "RicercaStatBambini";
            this.RicercaStatBambini.Size = new System.Drawing.Size(380, 120);
            this.RicercaStatBambini.TabIndex = 1;
            this.RicercaStatBambini.Text = "AVVIA RICERCA";
            this.RicercaStatBambini.UseVisualStyleBackColor = true;
            this.RicercaStatBambini.Click += new System.EventHandler(this.RicercaStatBambini_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(559, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GROBOLD", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(507, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "COGNOME";
            // 
            // NomeBambino
            // 
            this.NomeBambino.Location = new System.Drawing.Point(639, 227);
            this.NomeBambino.Name = "NomeBambino";
            this.NomeBambino.Size = new System.Drawing.Size(210, 20);
            this.NomeBambino.TabIndex = 4;
            this.NomeBambino.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // CognomeBambino
            // 
            this.CognomeBambino.Location = new System.Drawing.Point(640, 272);
            this.CognomeBambino.Name = "CognomeBambino";
            this.CognomeBambino.Size = new System.Drawing.Size(210, 20);
            this.CognomeBambino.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(524, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 58);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cerca studente";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // AiutoStatistiche
            // 
            this.AiutoStatistiche.BackgroundImage = global::Maestre.Properties.Resources.Aiuto;
            this.AiutoStatistiche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiutoStatistiche.FlatAppearance.BorderSize = 0;
            this.AiutoStatistiche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiutoStatistiche.Location = new System.Drawing.Point(1234, 12);
            this.AiutoStatistiche.Name = "AiutoStatistiche";
            this.AiutoStatistiche.Size = new System.Drawing.Size(120, 120);
            this.AiutoStatistiche.TabIndex = 7;
            this.AiutoStatistiche.UseVisualStyleBackColor = true;
            // 
            // LibriLettiDaBambino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.AiutoStatistiche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CognomeBambino);
            this.Controls.Add(this.NomeBambino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RicercaStatBambini);
            this.Controls.Add(this.Indietro_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibriLettiDaBambino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "a1";
            this.Load += new System.EventHandler(this.LibriLettiDaBambino_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Indietro_Button;
        private System.Windows.Forms.Button RicercaStatBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeBambino;
        private System.Windows.Forms.TextBox CognomeBambino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AiutoStatistiche;
    }
}