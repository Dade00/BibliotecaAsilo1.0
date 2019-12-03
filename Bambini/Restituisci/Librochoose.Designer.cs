namespace Bambini.Restituiusci
{
    partial class Librochoose
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
            this.components = new System.ComponentModel.Container();
            this.indietro_button = new System.Windows.Forms.Button();
            this.avanti_button = new System.Windows.Forms.Button();
            this.libro_label = new System.Windows.Forms.Label();
            this.down_button = new System.Windows.Forms.Button();
            this.up_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ElencoLibri = new System.Windows.Forms.DataGridView();
            this.titoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLibri = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElencoLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).BeginInit();
            this.SuspendLayout();
            // 
            // indietro_button
            // 
            this.indietro_button.BackColor = System.Drawing.Color.Transparent;
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.indietro_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Image = global::Bambini.Properties.Resources.Indietro_button;
            this.indietro_button.Location = new System.Drawing.Point(313, 598);
            this.indietro_button.Margin = new System.Windows.Forms.Padding(2);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 75);
            this.indietro_button.TabIndex = 14;
            this.indietro_button.UseVisualStyleBackColor = false;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            this.indietro_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Indietro_button_MouseDown);
            this.indietro_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Indietro_button_MouseUp);
            // 
            // avanti_button
            // 
            this.avanti_button.BackColor = System.Drawing.Color.Transparent;
            this.avanti_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.avanti_button.FlatAppearance.BorderSize = 0;
            this.avanti_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.avanti_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.avanti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avanti_button.Image = global::Bambini.Properties.Resources.Avanti_button;
            this.avanti_button.Location = new System.Drawing.Point(752, 598);
            this.avanti_button.Margin = new System.Windows.Forms.Padding(2);
            this.avanti_button.Name = "avanti_button";
            this.avanti_button.Size = new System.Drawing.Size(380, 75);
            this.avanti_button.TabIndex = 13;
            this.avanti_button.UseVisualStyleBackColor = false;
            this.avanti_button.Click += new System.EventHandler(this.Ok_button_Click);
            this.avanti_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Avanti_button_MouseDown);
            this.avanti_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Avanti_button_MouseUp);
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.BackColor = System.Drawing.Color.Transparent;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold);
            this.libro_label.Location = new System.Drawing.Point(303, 9);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(761, 58);
            this.libro_label.TabIndex = 12;
            this.libro_label.Text = "CHE LIBRO VUOI RESTITUIRE?";
            // 
            // down_button
            // 
            this.down_button.BackColor = System.Drawing.Color.Transparent;
            this.down_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.down_button.FlatAppearance.BorderSize = 0;
            this.down_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.down_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down_button.Image = global::Bambini.Properties.Resources.giù;
            this.down_button.Location = new System.Drawing.Point(1136, 316);
            this.down_button.Margin = new System.Windows.Forms.Padding(2);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(190, 210);
            this.down_button.TabIndex = 11;
            this.down_button.UseVisualStyleBackColor = false;
            this.down_button.Click += new System.EventHandler(this.Down_button_Click);
            this.down_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down_button_MouseDown);
            this.down_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Down_button_MouseUp);
            // 
            // up_button
            // 
            this.up_button.BackColor = System.Drawing.Color.Transparent;
            this.up_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.up_button.FlatAppearance.BorderSize = 0;
            this.up_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.up_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.up_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_button.Image = global::Bambini.Properties.Resources.Su;
            this.up_button.Location = new System.Drawing.Point(1136, 102);
            this.up_button.Margin = new System.Windows.Forms.Padding(2);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(190, 210);
            this.up_button.TabIndex = 10;
            this.up_button.UseVisualStyleBackColor = false;
            this.up_button.Click += new System.EventHandler(this.Up_button_Click);
            this.up_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Up_button_MouseDown);
            this.up_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up_button_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Bambini.Properties.Resources.No_image;
            this.pictureBox1.Location = new System.Drawing.Point(11, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ElencoLibri
            // 
            this.ElencoLibri.AllowUserToAddRows = false;
            this.ElencoLibri.AllowUserToDeleteRows = false;
            this.ElencoLibri.AllowUserToOrderColumns = true;
            this.ElencoLibri.AllowUserToResizeRows = false;
            this.ElencoLibri.AutoGenerateColumns = false;
            this.ElencoLibri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ElencoLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElencoLibri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titoloDataGridViewTextBoxColumn,
            this.autoreDataGridViewTextBoxColumn,
            this.Genere});
            this.ElencoLibri.DataSource = this.bsLibri;
            this.ElencoLibri.Location = new System.Drawing.Point(340, 102);
            this.ElencoLibri.Margin = new System.Windows.Forms.Padding(2);
            this.ElencoLibri.Name = "ElencoLibri";
            this.ElencoLibri.ReadOnly = true;
            this.ElencoLibri.RowHeadersVisible = false;
            this.ElencoLibri.RowHeadersWidth = 62;
            this.ElencoLibri.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ElencoLibri.RowTemplate.Height = 28;
            this.ElencoLibri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ElencoLibri.Size = new System.Drawing.Size(792, 424);
            this.ElencoLibri.TabIndex = 8;
            this.ElencoLibri.CurrentCellChanged += new System.EventHandler(this.ElencoLibri_CurrentCellChanged);
            // 
            // titoloDataGridViewTextBoxColumn
            // 
            this.titoloDataGridViewTextBoxColumn.DataPropertyName = "Titolo";
            this.titoloDataGridViewTextBoxColumn.HeaderText = "Titolo";
            this.titoloDataGridViewTextBoxColumn.Name = "titoloDataGridViewTextBoxColumn";
            this.titoloDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autoreDataGridViewTextBoxColumn
            // 
            this.autoreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.autoreDataGridViewTextBoxColumn.DataPropertyName = "Autore";
            this.autoreDataGridViewTextBoxColumn.HeaderText = "Autore";
            this.autoreDataGridViewTextBoxColumn.Name = "autoreDataGridViewTextBoxColumn";
            this.autoreDataGridViewTextBoxColumn.ReadOnly = true;
            this.autoreDataGridViewTextBoxColumn.Width = 63;
            // 
            // Genere
            // 
            this.Genere.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Genere.DataPropertyName = "Genere";
            this.Genere.HeaderText = "Genere";
            this.Genere.Name = "Genere";
            this.Genere.ReadOnly = true;
            this.Genere.Width = 67;
            // 
            // bsLibri
            // 
            this.bsLibri.DataSource = typeof(Classi.Libro);
            // 
            // Librochoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Bambini.Properties.Resources.Sfondo_che_libro;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.indietro_button);
            this.Controls.Add(this.avanti_button);
            this.Controls.Add(this.libro_label);
            this.Controls.Add(this.down_button);
            this.Controls.Add(this.up_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ElencoLibri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Librochoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librochoose";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Librochoose_Load);
            this.VisibleChanged += new System.EventHandler(this.Librochoose_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElencoLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button indietro_button;
        private System.Windows.Forms.Button avanti_button;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView ElencoLibri;
        private System.Windows.Forms.BindingSource bsLibri;
        private System.Windows.Forms.DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genere;
    }
}