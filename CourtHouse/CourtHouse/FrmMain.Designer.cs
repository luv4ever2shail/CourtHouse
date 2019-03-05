namespace CourtHouse
{
    partial class FrmMain
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
            this.evicttile = new MetroFramework.Controls.MetroTile();
            this.woptile = new MetroFramework.Controls.MetroTile();
            this.viewreportbttn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // evicttile
            // 
            this.evicttile.ActiveControl = null;
            this.evicttile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.evicttile.Location = new System.Drawing.Point(70, 92);
            this.evicttile.Name = "evicttile";
            this.evicttile.Size = new System.Drawing.Size(129, 93);
            this.evicttile.TabIndex = 0;
            this.evicttile.Text = "Evictions";
            this.evicttile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.evicttile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.evicttile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.evicttile.UseSelectable = true;
            this.evicttile.Click += new System.EventHandler(this.evicttile_Click);
            // 
            // woptile
            // 
            this.woptile.ActiveControl = null;
            this.woptile.Location = new System.Drawing.Point(285, 92);
            this.woptile.Name = "woptile";
            this.woptile.Size = new System.Drawing.Size(139, 93);
            this.woptile.TabIndex = 1;
            this.woptile.Text = " Writ\r\n of\r\npossession\r\n";
            this.woptile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.woptile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.woptile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.woptile.UseSelectable = true;
            this.woptile.Click += new System.EventHandler(this.woptile_Click);
            // 
            // viewreportbttn
            // 
            this.viewreportbttn.Location = new System.Drawing.Point(181, 222);
            this.viewreportbttn.Name = "viewreportbttn";
            this.viewreportbttn.Size = new System.Drawing.Size(128, 47);
            this.viewreportbttn.Style = MetroFramework.MetroColorStyle.Blue;
            this.viewreportbttn.TabIndex = 2;
            this.viewreportbttn.Text = "View Report";
            this.viewreportbttn.UseSelectable = true;
            this.viewreportbttn.Click += new System.EventHandler(this.viewreportbttn_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(3F, 5F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 299);
            this.Controls.Add(this.viewreportbttn);
            this.Controls.Add(this.woptile);
            this.Controls.Add(this.evicttile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmMain";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 8);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Select Module";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile evicttile;
        private MetroFramework.Controls.MetroTile woptile;
        private MetroFramework.Controls.MetroButton viewreportbttn;
    }
}

