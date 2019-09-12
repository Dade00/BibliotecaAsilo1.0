namespace Maestre.Bambini
{
    partial class HomeBambini
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
            this.AggiungiBambino = new System.Windows.Forms.Button();
            this.ModificaBambino = new System.Windows.Forms.Button();
            this.EliminaBambino = new System.Windows.Forms.Button();
            this.indietro_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AggiungiBambino
            // 
            this.AggiungiBambino.Location = new System.Drawing.Point(493, 62);
            this.AggiungiBambino.Name = "AggiungiBambino";
            this.AggiungiBambino.Size = new System.Drawing.Size(380, 120);
            this.AggiungiBambino.TabIndex = 0;
            this.AggiungiBambino.Text = "AGGIUNGI BAMBINO";
            this.AggiungiBambino.UseVisualStyleBackColor = true;
            this.AggiungiBambino.Click += new System.EventHandler(this.AggiungiBambino_Click);
            // 
            // ModificaBambino
            // 
            this.ModificaBambino.Location = new System.Drawing.Point(493, 235);
            this.ModificaBambino.Name = "ModificaBambino";
            this.ModificaBambino.Size = new System.Drawing.Size(380, 120);
            this.ModificaBambino.TabIndex = 1;
            this.ModificaBambino.Text = "MODIFICA BAMBINO";
            this.ModificaBambino.UseVisualStyleBackColor = true;
            this.ModificaBambino.Click += new System.EventHandler(this.ModificaBambino_Click);
            // 
            // EliminaBambino
            // 
            this.EliminaBambino.Location = new System.Drawing.Point(493, 411);
            this.EliminaBambino.Name = "EliminaBambino";
            this.EliminaBambino.Size = new System.Drawing.Size(380, 120);
            this.EliminaBambino.TabIndex = 2;
            this.EliminaBambino.Text = "ELIMINA BAMBINO";
            this.EliminaBambino.UseVisualStyleBackColor = true;
            this.EliminaBambino.Click += new System.EventHandler(this.EliminaBambino_Click);
            // 
            // indietro_button
            // 
            this.indietro_button.Location = new System.Drawing.Point(493, 587);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 120);
            this.indietro_button.TabIndex = 7;
            this.indietro_button.Text = "INDIETRO";
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            // 
            // HomeBambini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.EliminaBambino);
            this.Controls.Add(this.ModificaBambino);
            this.Controls.Add(this.AggiungiBambino);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeBambini";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeBambini";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AggiungiBambino;
        private System.Windows.Forms.Button ModificaBambino;
        private System.Windows.Forms.Button EliminaBambino;
        private System.Windows.Forms.Button indietro_button;
    }
}