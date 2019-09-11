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
            this.SuspendLayout();
            // 
            // AggiungiBambino
            // 
            this.AggiungiBambino.Location = new System.Drawing.Point(244, 104);
            this.AggiungiBambino.Name = "AggiungiBambino";
            this.AggiungiBambino.Size = new System.Drawing.Size(288, 53);
            this.AggiungiBambino.TabIndex = 0;
            this.AggiungiBambino.Text = "AGGIUNGI BAMBINO";
            this.AggiungiBambino.UseVisualStyleBackColor = true;
            // 
            // ModificaBambino
            // 
            this.ModificaBambino.Location = new System.Drawing.Point(244, 179);
            this.ModificaBambino.Name = "ModificaBambino";
            this.ModificaBambino.Size = new System.Drawing.Size(288, 53);
            this.ModificaBambino.TabIndex = 1;
            this.ModificaBambino.Text = "MODIFICA BAMBINO";
            this.ModificaBambino.UseVisualStyleBackColor = true;
            // 
            // EliminaBambino
            // 
            this.EliminaBambino.Location = new System.Drawing.Point(244, 256);
            this.EliminaBambino.Name = "EliminaBambino";
            this.EliminaBambino.Size = new System.Drawing.Size(288, 53);
            this.EliminaBambino.TabIndex = 2;
            this.EliminaBambino.Text = "ELIMINA BAMBINO";
            this.EliminaBambino.UseVisualStyleBackColor = true;
            // 
            // HomeBambini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.EliminaBambino);
            this.Controls.Add(this.ModificaBambino);
            this.Controls.Add(this.AggiungiBambino);
            this.Name = "HomeBambini";
            this.Text = "HomeBambini";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AggiungiBambino;
        private System.Windows.Forms.Button ModificaBambino;
        private System.Windows.Forms.Button EliminaBambino;
    }
}