namespace Maestre.Statistiche_WIP_
{
    partial class LibriLetti
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
            this.Bambini_pic = new System.Windows.Forms.PictureBox();
            this.TabellaBambini = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NLibriLetti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClasseStudScelto = new System.Windows.Forms.Label();
            this.CogomeStudScelto = new System.Windows.Forms.Label();
            this.NomeStudScelto = new System.Windows.Forms.Label();
            this.Indietro_button = new System.Windows.Forms.Button();
            this.StampaStatStudente = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).BeginInit();
            this.SuspendLayout();
            // 
            // Bambini_pic
            // 
            this.Bambini_pic.Location = new System.Drawing.Point(517, 63);
            this.Bambini_pic.Name = "Bambini_pic";
            this.Bambini_pic.Size = new System.Drawing.Size(204, 200);
            this.Bambini_pic.TabIndex = 132;
            this.Bambini_pic.TabStop = false;
            // 
            // TabellaBambini
            // 
            this.TabellaBambini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabellaBambini.Location = new System.Drawing.Point(319, 293);
            this.TabellaBambini.Margin = new System.Windows.Forms.Padding(2);
            this.TabellaBambini.Name = "TabellaBambini";
            this.TabellaBambini.RowHeadersWidth = 62;
            this.TabellaBambini.RowTemplate.Height = 28;
            this.TabellaBambini.Size = new System.Drawing.Size(728, 200);
            this.TabellaBambini.TabIndex = 131;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(598, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 133;
            this.label1.Text = "TOTALE LIBRI LETTI";
            // 
            // NLibriLetti
            // 
            this.NLibriLetti.Location = new System.Drawing.Point(731, 520);
            this.NLibriLetti.Name = "NLibriLetti";
            this.NLibriLetti.Size = new System.Drawing.Size(38, 20);
            this.NLibriLetti.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(745, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 135;
            this.label2.Text = "NOME:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 136;
            this.label3.Text = "COGNOME:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(745, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 137;
            this.label4.Text = "CLASSE:";
            // 
            // ClasseStudScelto
            // 
            this.ClasseStudScelto.AutoSize = true;
            this.ClasseStudScelto.Location = new System.Drawing.Point(802, 186);
            this.ClasseStudScelto.Name = "ClasseStudScelto";
            this.ClasseStudScelto.Size = new System.Drawing.Size(35, 13);
            this.ClasseStudScelto.TabIndex = 138;
            this.ClasseStudScelto.Text = "label5";
            // 
            // CogomeStudScelto
            // 
            this.CogomeStudScelto.AutoSize = true;
            this.CogomeStudScelto.Location = new System.Drawing.Point(816, 150);
            this.CogomeStudScelto.Name = "CogomeStudScelto";
            this.CogomeStudScelto.Size = new System.Drawing.Size(35, 13);
            this.CogomeStudScelto.TabIndex = 139;
            this.CogomeStudScelto.Text = "label6";
            // 
            // NomeStudScelto
            // 
            this.NomeStudScelto.AutoSize = true;
            this.NomeStudScelto.Location = new System.Drawing.Point(793, 116);
            this.NomeStudScelto.Name = "NomeStudScelto";
            this.NomeStudScelto.Size = new System.Drawing.Size(35, 13);
            this.NomeStudScelto.TabIndex = 140;
            this.NomeStudScelto.Text = "label7";
            // 
            // Indietro_button
            // 
            this.Indietro_button.Location = new System.Drawing.Point(222, 565);
            this.Indietro_button.Name = "Indietro_button";
            this.Indietro_button.Size = new System.Drawing.Size(380, 120);
            this.Indietro_button.TabIndex = 141;
            this.Indietro_button.Text = "INDIETRO";
            this.Indietro_button.UseVisualStyleBackColor = true;
            this.Indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // StampaStatStudente
            // 
            this.StampaStatStudente.Location = new System.Drawing.Point(764, 565);
            this.StampaStatStudente.Name = "StampaStatStudente";
            this.StampaStatStudente.Size = new System.Drawing.Size(380, 120);
            this.StampaStatStudente.TabIndex = 142;
            this.StampaStatStudente.Text = "STAMPA";
            this.StampaStatStudente.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(598, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 13);
            this.label8.TabIndex = 143;
            this.label8.Text = "Quanti Libri Ha Letto Lo Studente";
            // 
            // LibriLetti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StampaStatStudente);
            this.Controls.Add(this.Indietro_button);
            this.Controls.Add(this.NomeStudScelto);
            this.Controls.Add(this.CogomeStudScelto);
            this.Controls.Add(this.ClasseStudScelto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NLibriLetti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bambini_pic);
            this.Controls.Add(this.TabellaBambini);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibriLetti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibriLetti";
            ((System.ComponentModel.ISupportInitialize)(this.Bambini_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabellaBambini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bambini_pic;
        private System.Windows.Forms.DataGridView TabellaBambini;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NLibriLetti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ClasseStudScelto;
        private System.Windows.Forms.Label CogomeStudScelto;
        private System.Windows.Forms.Label NomeStudScelto;
        private System.Windows.Forms.Button Indietro_button;
        private System.Windows.Forms.Button StampaStatStudente;
        private System.Windows.Forms.Label label8;
    }
}