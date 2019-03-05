namespace CourtHouse
{
    partial class EvictionsHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtsearch = new MetroFramework.Controls.MetroTextBox();
            this.evictionsdatagrid = new System.Windows.Forms.DataGridView();
            this.newbttn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.evictionsdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            // 
            // 
            // 
            this.txtsearch.CustomButton.Image = null;
            this.txtsearch.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtsearch.CustomButton.Name = "";
            this.txtsearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsearch.CustomButton.TabIndex = 1;
            this.txtsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsearch.CustomButton.UseSelectable = true;
            this.txtsearch.CustomButton.Visible = false;
            this.txtsearch.Lines = new string[0];
            this.txtsearch.Location = new System.Drawing.Point(15, 74);
            this.txtsearch.MaxLength = 32767;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PromptText = "Search Record";
            this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearch.SelectedText = "";
            this.txtsearch.SelectionLength = 0;
            this.txtsearch.SelectionStart = 0;
            this.txtsearch.ShortcutsEnabled = true;
            this.txtsearch.Size = new System.Drawing.Size(209, 23);
            this.txtsearch.TabIndex = 1;
            this.txtsearch.UseSelectable = true;
            this.txtsearch.WaterMark = "Search Record";
            this.txtsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsearch_KeyDown);
            // 
            // evictionsdatagrid
            // 
            this.evictionsdatagrid.AllowUserToAddRows = false;
            this.evictionsdatagrid.AllowUserToDeleteRows = false;
            this.evictionsdatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.evictionsdatagrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.evictionsdatagrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.evictionsdatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.evictionsdatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.evictionsdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.evictionsdatagrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.evictionsdatagrid.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.evictionsdatagrid.Location = new System.Drawing.Point(15, 119);
            this.evictionsdatagrid.Name = "evictionsdatagrid";
            this.evictionsdatagrid.ReadOnly = true;
            this.evictionsdatagrid.RowHeadersVisible = false;
            this.evictionsdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.evictionsdatagrid.Size = new System.Drawing.Size(977, 548);
            this.evictionsdatagrid.TabIndex = 2;
            this.evictionsdatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evictionsdatagrid_CellDoubleClick);
            // 
            // newbttn
            // 
            this.newbttn.Location = new System.Drawing.Point(917, 74);
            this.newbttn.Name = "newbttn";
            this.newbttn.Size = new System.Drawing.Size(75, 23);
            this.newbttn.TabIndex = 3;
            this.newbttn.Text = "New Item";
            this.newbttn.UseSelectable = true;
            this.newbttn.Click += new System.EventHandler(this.newbttn_Click);
            // 
            // EvictionsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 690);
            this.Controls.Add(this.newbttn);
            this.Controls.Add(this.evictionsdatagrid);
            this.Controls.Add(this.txtsearch);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "EvictionsHome";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Evictions Home";
            this.Load += new System.EventHandler(this.EvictionsHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evictionsdatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtsearch;
        private System.Windows.Forms.DataGridView evictionsdatagrid;
        private MetroFramework.Controls.MetroButton newbttn;
    }
}