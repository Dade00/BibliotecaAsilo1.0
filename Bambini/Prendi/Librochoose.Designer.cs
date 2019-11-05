namespace Bambini.Prendi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librochoose));
            this.ElencoLibri = new System.Windows.Forms.DataGridView();
            this.titoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLibri = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.up_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.libro_label = new System.Windows.Forms.Label();
            this.avanti_button = new System.Windows.Forms.Button();
            this.indietro_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ElencoLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ElencoLibri
            // 
            this.ElencoLibri.AllowUserToAddRows = false;
            this.ElencoLibri.AllowUserToDeleteRows = false;
            this.ElencoLibri.AllowUserToOrderColumns = true;
            this.ElencoLibri.AllowUserToResizeColumns = false;
            this.ElencoLibri.AllowUserToResizeRows = false;
            this.ElencoLibri.AutoGenerateColumns = false;
            this.ElencoLibri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ElencoLibri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ElencoLibri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titoloDataGridViewTextBoxColumn,
            this.autoreDataGridViewTextBoxColumn});
            this.ElencoLibri.DataSource = this.bsLibri;
            this.ElencoLibri.Location = new System.Drawing.Point(364, 114);
            this.ElencoLibri.Margin = new System.Windows.Forms.Padding(2);
            this.ElencoLibri.MultiSelect = false;
            this.ElencoLibri.Name = "ElencoLibri";
            this.ElencoLibri.ReadOnly = true;
            this.ElencoLibri.RowHeadersVisible = false;
            this.ElencoLibri.RowHeadersWidth = 62;
            this.ElencoLibri.RowTemplate.Height = 28;
            this.ElencoLibri.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ElencoLibri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ElencoLibri.Size = new System.Drawing.Size(792, 424);
            this.ElencoLibri.TabIndex = 1;
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
            // bsLibri
            // 
            this.bsLibri.DataSource = typeof(Classi.Libro);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Bambini.Properties.Resources.No_image;
            this.pictureBox1.Location = new System.Drawing.Point(10, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // up_button
            // 
            this.up_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.up_button.FlatAppearance.BorderSize = 0;
            this.up_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.up_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.up_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_button.Image = global::Bambini.Properties.Resources.Su;
            this.up_button.Location = new System.Drawing.Point(1160, 114);
            this.up_button.Margin = new System.Windows.Forms.Padding(2);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(190, 210);
            this.up_button.TabIndex = 3;
            this.up_button.UseVisualStyleBackColor = true;
            this.up_button.Click += new System.EventHandler(this.Up_button_Click);
            this.up_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Up_button_MouseDown);
            this.up_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Up_button_MouseUp);
            // 
            // down_button
            // 
            this.down_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.down_button.FlatAppearance.BorderSize = 0;
            this.down_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.down_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down_button.Image = global::Bambini.Properties.Resources.giù;
            this.down_button.Location = new System.Drawing.Point(1160, 328);
            this.down_button.Margin = new System.Windows.Forms.Padding(2);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(190, 210);
            this.down_button.TabIndex = 4;
            this.down_button.UseVisualStyleBackColor = true;
            this.down_button.Click += new System.EventHandler(this.Down_button_Click);
            this.down_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Down_button_MouseDown);
            this.down_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Down_button_MouseUp);
            // 
            // libro_label
            // 
            this.libro_label.AutoSize = true;
            this.libro_label.Font = new System.Drawing.Font("GROBOLD", 36F, System.Drawing.FontStyle.Bold);
            this.libro_label.Location = new System.Drawing.Point(303, 9);
            this.libro_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.libro_label.Name = "libro_label";
            this.libro_label.Size = new System.Drawing.Size(745, 58);
            this.libro_label.TabIndex = 5;
            this.libro_label.Text = "CHE LIBRO VUOI PRENDERE?";
            // 
            // avanti_button
            // 
            this.avanti_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.avanti_button.FlatAppearance.BorderSize = 0;
            this.avanti_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.avanti_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.avanti_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avanti_button.Image = ((System.Drawing.Image)(resources.GetObject("avanti_button.Image")));
            this.avanti_button.Location = new System.Drawing.Point(725, 628);
            this.avanti_button.Margin = new System.Windows.Forms.Padding(2);
            this.avanti_button.Name = "avanti_button";
            this.avanti_button.Size = new System.Drawing.Size(380, 75);
            this.avanti_button.TabIndex = 6;
            this.avanti_button.UseVisualStyleBackColor = true;
            this.avanti_button.Click += new System.EventHandler(this.Ok_button_Click);
            this.avanti_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Avanti_button_MouseDown);
            this.avanti_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Avanti_button_MouseUp);
            // 
            // indietro_button
            // 
            this.indietro_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.indietro_button.FlatAppearance.BorderSize = 0;
            this.indietro_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.indietro_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.indietro_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.indietro_button.Image = global::Bambini.Properties.Resources.Indietro_button;
            this.indietro_button.Location = new System.Drawing.Point(262, 628);
            this.indietro_button.Margin = new System.Windows.Forms.Padding(2);
            this.indietro_button.Name = "indietro_button";
            this.indietro_button.Size = new System.Drawing.Size(380, 75);
            this.indietro_button.TabIndex = 7;
            this.indietro_button.UseVisualStyleBackColor = true;
            this.indietro_button.Click += new System.EventHandler(this.Indietro_button_Click);
            this.indietro_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Indietro_button_MouseDown);
            this.indietro_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Indietro_button_MouseUp);
            // 
            // Librochoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Load += new System.EventHandler(this.Librochoose_Load);
            this.VisibleChanged += new System.EventHandler(this.Librochoose_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ElencoLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLibri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ElencoLibri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Label libro_label;
        private System.Windows.Forms.Button avanti_button;
        private System.Windows.Forms.Button indietro_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn titoloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsLibri;
    }
}