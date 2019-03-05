namespace CourtHouse
{
    partial class ReportAllRecords
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
            this.evictionsdatagrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frmdatepick = new System.Windows.Forms.DateTimePicker();
            this.todatepic = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.countevictxt = new System.Windows.Forms.TextBox();
            this.countwoptxt = new System.Windows.Forms.TextBox();
            this.loaddatabttn = new MetroFramework.Controls.MetroButton();
            this.showallbttn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.evictionsdatagrid)).BeginInit();
            this.SuspendLayout();
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
            this.evictionsdatagrid.Location = new System.Drawing.Point(15, 150);
            this.evictionsdatagrid.Name = "evictionsdatagrid";
            this.evictionsdatagrid.ReadOnly = true;
            this.evictionsdatagrid.RowHeadersVisible = false;
            this.evictionsdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.evictionsdatagrid.Size = new System.Drawing.Size(769, 527);
            this.evictionsdatagrid.TabIndex = 2;
            this.evictionsdatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.evictionsdatagrid_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "From Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date :";
            // 
            // frmdatepick
            // 
            this.frmdatepick.Location = new System.Drawing.Point(103, 63);
            this.frmdatepick.Name = "frmdatepick";
            this.frmdatepick.Size = new System.Drawing.Size(165, 20);
            this.frmdatepick.TabIndex = 4;
            // 
            // todatepic
            // 
            this.todatepic.Location = new System.Drawing.Point(103, 108);
            this.todatepic.Name = "todatepic";
            this.todatepic.Size = new System.Drawing.Size(165, 20);
            this.todatepic.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number Of Evictions Issued :\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number Of WOP Issued :\r\n";
            // 
            // countevictxt
            // 
            this.countevictxt.Location = new System.Drawing.Point(639, 75);
            this.countevictxt.Name = "countevictxt";
            this.countevictxt.ReadOnly = true;
            this.countevictxt.Size = new System.Drawing.Size(127, 20);
            this.countevictxt.TabIndex = 6;
            // 
            // countwoptxt
            // 
            this.countwoptxt.Location = new System.Drawing.Point(639, 108);
            this.countwoptxt.Name = "countwoptxt";
            this.countwoptxt.ReadOnly = true;
            this.countwoptxt.Size = new System.Drawing.Size(127, 20);
            this.countwoptxt.TabIndex = 6;
            // 
            // loaddatabttn
            // 
            this.loaddatabttn.Location = new System.Drawing.Point(290, 85);
            this.loaddatabttn.Name = "loaddatabttn";
            this.loaddatabttn.Size = new System.Drawing.Size(63, 23);
            this.loaddatabttn.TabIndex = 7;
            this.loaddatabttn.Text = "Load";
            this.loaddatabttn.UseSelectable = true;
            this.loaddatabttn.Click += new System.EventHandler(this.loaddatabttn_Click);
            // 
            // showallbttn
            // 
            this.showallbttn.Location = new System.Drawing.Point(370, 85);
            this.showallbttn.Name = "showallbttn";
            this.showallbttn.Size = new System.Drawing.Size(75, 23);
            this.showallbttn.TabIndex = 7;
            this.showallbttn.Text = "ShowAll";
            this.showallbttn.UseSelectable = true;
            this.showallbttn.Click += new System.EventHandler(this.showallbttn_Click);
            // 
            // ReportAllRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 700);
            this.Controls.Add(this.showallbttn);
            this.Controls.Add(this.loaddatabttn);
            this.Controls.Add(this.countwoptxt);
            this.Controls.Add(this.countevictxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.todatepic);
            this.Controls.Add(this.frmdatepick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.evictionsdatagrid);
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "ReportAllRecords";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Report All Records";
            this.Load += new System.EventHandler(this.EvictionsHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.evictionsdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView evictionsdatagrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker frmdatepick;
        private System.Windows.Forms.DateTimePicker todatepic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countevictxt;
        private System.Windows.Forms.TextBox countwoptxt;
        private MetroFramework.Controls.MetroButton loaddatabttn;
        private MetroFramework.Controls.MetroButton showallbttn;
    }
}