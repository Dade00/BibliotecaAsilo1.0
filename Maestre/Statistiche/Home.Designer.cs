namespace Maestre.Statistiche_WIP_
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.StatBambini = new System.Windows.Forms.Button();
            this.StatLibri = new System.Windows.Forms.Button();
            this.DelStat = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(655, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistiche";
            // 
            // StatBambini
            // 
            this.StatBambini.Location = new System.Drawing.Point(159, 161);
            this.StatBambini.Name = "StatBambini";
            this.StatBambini.Size = new System.Drawing.Size(380, 120);
            this.StatBambini.TabIndex = 1;
            this.StatBambini.Text = "QUANTI LIBRI HA LETTO OGNI BAMBINI";
            this.StatBambini.UseVisualStyleBackColor = true;
            this.StatBambini.Click += new System.EventHandler(this.Button1_Click);
            // 
            // StatLibri
            // 
            this.StatLibri.Location = new System.Drawing.Point(827, 161);
            this.StatLibri.Name = "StatLibri";
            this.StatLibri.Size = new System.Drawing.Size(380, 120);
            this.StatLibri.TabIndex = 2;
            this.StatLibri.Text = "QUANTE VOLTE UN LIBRO E\' STATO LETTO";
            this.StatLibri.UseVisualStyleBackColor = true;
            // 
            // DelStat
            // 
            this.DelStat.Location = new System.Drawing.Point(493, 333);
            this.DelStat.Name = "DelStat";
            this.DelStat.Size = new System.Drawing.Size(380, 120);
            this.DelStat.TabIndex = 3;
            this.DelStat.Text = "ELIMINA  STATISTICHE";
            this.DelStat.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(493, 599);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(380, 120);
            this.button4.TabIndex = 4;
            this.button4.Text = "INDIETRO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.DelStat);
            this.Controls.Add(this.StatLibri);
            this.Controls.Add(this.StatBambini);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StatBambini;
        private System.Windows.Forms.Button StatLibri;
        private System.Windows.Forms.Button DelStat;
        private System.Windows.Forms.Button button4;
    }
}