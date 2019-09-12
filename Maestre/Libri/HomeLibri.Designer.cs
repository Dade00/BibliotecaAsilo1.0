namespace Maestre.Libri
{
    partial class HomeLibri
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
            this.EliminaLibro = new System.Windows.Forms.Button();
            this.ModificaLibro = new System.Windows.Forms.Button();
            this.AggiungiLibro = new System.Windows.Forms.Button();
            this.indietro_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EliminaLibro
            // 
            this.EliminaLibro.Location = new System.Drawing.Point(492, 388);
            this.EliminaLibro.Name = "EliminaLibro";
            this.EliminaLibro.Size = new System.Drawing.Size(380, 120);
            this.EliminaLibro.TabIndex = 5;
            this.EliminaLibro.Text = "ELIMINA LIBRO";
            this.EliminaLibro.UseVisualStyleBackColor = true;
            // 
            // ModificaLibro
            // 
            this.ModificaLibro.Location = new System.Drawing.Point(492, 228);
            this.ModificaLibro.Name = "ModificaLibro";
            this.ModificaLibro.Size = new System.Drawing.Size(380, 120);
            this.ModificaLibro.TabIndex = 4;
            this.ModificaLibro.Text = "MODIFICA LIBRO";
            this.ModificaLibro.UseVisualStyleBackColor = true;
            // 
            // AggiungiLibro
            // 
            this.AggiungiLibro.Location = new System.Drawing.Point(492, 72);
            this.AggiungiLibro.Name = "AggiungiLibro";
            this.AggiungiLibro.Size = new System.Drawing.Size(380, 120);
            this.AggiungiLibro.TabIndex = 3;
            this.AggiungiLibro.Text = "AGGIUNGI LIBRO";
            this.AggiungiLibro.UseVisualStyleBackColor = true;
            // 
            // indietro_button
            // 
            this.indietro_button.Location = new System.Drawing.Point(492, 549);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 120);
            this.indietro_button.TabIndex = 6;
            this.indietro_button.Text = "INDIETRO";
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // HomeLibri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.EliminaLibro);
            this.Controls.Add(this.ModificaLibro);
            this.Controls.Add(this.AggiungiLibro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeLibri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeLibri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EliminaLibro;
        private System.Windows.Forms.Button ModificaLibro;
        private System.Windows.Forms.Button AggiungiLibro;
        private System.Windows.Forms.Button indietro_button;
    }
}