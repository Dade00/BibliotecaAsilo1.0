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
            this.SuspendLayout();
            // 
            // EliminaLibro
            // 
            this.EliminaLibro.Location = new System.Drawing.Point(256, 275);
            this.EliminaLibro.Name = "EliminaLibro";
            this.EliminaLibro.Size = new System.Drawing.Size(288, 53);
            this.EliminaLibro.TabIndex = 5;
            this.EliminaLibro.Text = "ELIMINA LIBRO";
            this.EliminaLibro.UseVisualStyleBackColor = true;
            // 
            // ModificaLibro
            // 
            this.ModificaLibro.Location = new System.Drawing.Point(256, 198);
            this.ModificaLibro.Name = "ModificaLibro";
            this.ModificaLibro.Size = new System.Drawing.Size(288, 53);
            this.ModificaLibro.TabIndex = 4;
            this.ModificaLibro.Text = "MODIFICA LIBRO";
            this.ModificaLibro.UseVisualStyleBackColor = true;
            // 
            // AggiungiLibro
            // 
            this.AggiungiLibro.Location = new System.Drawing.Point(256, 123);
            this.AggiungiLibro.Name = "AggiungiLibro";
            this.AggiungiLibro.Size = new System.Drawing.Size(288, 53);
            this.AggiungiLibro.TabIndex = 3;
            this.AggiungiLibro.Text = "AGGIUNGI LIBRO";
            this.AggiungiLibro.UseVisualStyleBackColor = true;
            // 
            // HomeLibri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.EliminaLibro);
            this.Controls.Add(this.ModificaLibro);
            this.Controls.Add(this.AggiungiLibro);
            this.Name = "HomeLibri";
            this.Text = "HomeLibri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EliminaLibro;
        private System.Windows.Forms.Button ModificaLibro;
        private System.Windows.Forms.Button AggiungiLibro;
    }
}