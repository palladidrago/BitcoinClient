namespace ClientApp.UI
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.listView_Coins = new System.Windows.Forms.ListView();
            this.columnHeader_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Valid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Scam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.numericUpDown_Supply = new System.Windows.Forms.NumericUpDown();
            this.textBox_Filter_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Filter_Valid = new System.Windows.Forms.ComboBox();
            this.comboBox_Filter_Scam = new System.Windows.Forms.ComboBox();
            this.label_Filter_Valid = new System.Windows.Forms.Label();
            this.label_Supply = new System.Windows.Forms.Label();
            this.label_Filter_Scam = new System.Windows.Forms.Label();
            this.label_Filter_Name = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.label_Coin_Report = new System.Windows.Forms.Label();
            this.pictureBox_Print = new System.Windows.Forms.PictureBox();
            this.label_Print = new System.Windows.Forms.Label();
            this.groupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Supply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Print)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_Coins
            // 
            this.listView_Coins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Valid,
            this.columnHeader_Scam,
            this.columnHeader_Count});
            this.listView_Coins.HideSelection = false;
            this.listView_Coins.Location = new System.Drawing.Point(12, 250);
            this.listView_Coins.Name = "listView_Coins";
            this.listView_Coins.Size = new System.Drawing.Size(965, 426);
            this.listView_Coins.TabIndex = 0;
            this.listView_Coins.UseCompatibleStateImageBehavior = false;
            this.listView_Coins.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 101;
            // 
            // columnHeader_Valid
            // 
            this.columnHeader_Valid.Text = "Validation Method";
            this.columnHeader_Valid.Width = 152;
            // 
            // columnHeader_Scam
            // 
            this.columnHeader_Scam.Text = "Scam Level";
            this.columnHeader_Scam.Width = 156;
            // 
            // columnHeader_Count
            // 
            this.columnHeader_Count.Text = "Count";
            this.columnHeader_Count.Width = 150;
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.numericUpDown_Supply);
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_Name);
            this.groupBox_Filter.Controls.Add(this.comboBox_Filter_Valid);
            this.groupBox_Filter.Controls.Add(this.comboBox_Filter_Scam);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Valid);
            this.groupBox_Filter.Controls.Add(this.label_Supply);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Scam);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Name);
            this.groupBox_Filter.Location = new System.Drawing.Point(13, 4);
            this.groupBox_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Filter.Size = new System.Drawing.Size(364, 171);
            this.groupBox_Filter.TabIndex = 2;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // numericUpDown_Supply
            // 
            this.numericUpDown_Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Supply.Location = new System.Drawing.Point(190, 134);
            this.numericUpDown_Supply.Name = "numericUpDown_Supply";
            this.numericUpDown_Supply.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown_Supply.TabIndex = 3;
            this.numericUpDown_Supply.ValueChanged += new System.EventHandler(this.numericUpDown_Supply_ValueChanged);
            // 
            // textBox_Filter_Name
            // 
            this.textBox_Filter_Name.Location = new System.Drawing.Point(190, 21);
            this.textBox_Filter_Name.Name = "textBox_Filter_Name";
            this.textBox_Filter_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Filter_Name.TabIndex = 2;
            this.textBox_Filter_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_Name_KeyUp);
            // 
            // comboBox_Filter_Valid
            // 
            this.comboBox_Filter_Valid.FormattingEnabled = true;
            this.comboBox_Filter_Valid.Location = new System.Drawing.Point(190, 54);
            this.comboBox_Filter_Valid.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Filter_Valid.Name = "comboBox_Filter_Valid";
            this.comboBox_Filter_Valid.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Filter_Valid.TabIndex = 0;
            this.comboBox_Filter_Valid.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_Valid_SelectedIndexChanged);
            // 
            // comboBox_Filter_Scam
            // 
            this.comboBox_Filter_Scam.FormattingEnabled = true;
            this.comboBox_Filter_Scam.Location = new System.Drawing.Point(190, 95);
            this.comboBox_Filter_Scam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Filter_Scam.Name = "comboBox_Filter_Scam";
            this.comboBox_Filter_Scam.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Filter_Scam.TabIndex = 0;
            this.comboBox_Filter_Scam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_Scam_SelectedIndexChanged);
            // 
            // label_Filter_Valid
            // 
            this.label_Filter_Valid.AutoSize = true;
            this.label_Filter_Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Valid.Location = new System.Drawing.Point(10, 56);
            this.label_Filter_Valid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Filter_Valid.Name = "label_Filter_Valid";
            this.label_Filter_Valid.Size = new System.Drawing.Size(165, 25);
            this.label_Filter_Valid.TabIndex = 0;
            this.label_Filter_Valid.Text = "Validation system";
            // 
            // label_Supply
            // 
            this.label_Supply.AutoSize = true;
            this.label_Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Supply.Location = new System.Drawing.Point(10, 136);
            this.label_Supply.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Supply.Name = "label_Supply";
            this.label_Supply.Size = new System.Drawing.Size(73, 25);
            this.label_Supply.TabIndex = 0;
            this.label_Supply.Text = "Supply";
            // 
            // label_Filter_Scam
            // 
            this.label_Filter_Scam.AutoSize = true;
            this.label_Filter_Scam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Scam.Location = new System.Drawing.Point(10, 94);
            this.label_Filter_Scam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Filter_Scam.Name = "label_Filter_Scam";
            this.label_Filter_Scam.Size = new System.Drawing.Size(115, 25);
            this.label_Filter_Scam.TabIndex = 0;
            this.label_Filter_Scam.Text = "Scam Level";
            // 
            // label_Filter_Name
            // 
            this.label_Filter_Name.AutoSize = true;
            this.label_Filter_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Name.Location = new System.Drawing.Point(10, 21);
            this.label_Filter_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Filter_Name.Name = "label_Filter_Name";
            this.label_Filter_Name.Size = new System.Drawing.Size(64, 25);
            this.label_Filter_Name.TabIndex = 0;
            this.label_Filter_Name.Text = "Name";
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // label_Coin_Report
            // 
            this.label_Coin_Report.AutoSize = true;
            this.label_Coin_Report.Font = new System.Drawing.Font("Rockwell Nova", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coin_Report.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_Coin_Report.Location = new System.Drawing.Point(363, 179);
            this.label_Coin_Report.Name = "label_Coin_Report";
            this.label_Coin_Report.Size = new System.Drawing.Size(280, 59);
            this.label_Coin_Report.TabIndex = 3;
            this.label_Coin_Report.Text = "Coin Report";
            // 
            // pictureBox_Print
            // 
            this.pictureBox_Print.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_Print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Print.Image = global::ClientApp.Properties.Resources._15022c18a022e53b517ad921c9f9e87d;
            this.pictureBox_Print.Location = new System.Drawing.Point(825, 25);
            this.pictureBox_Print.Name = "pictureBox_Print";
            this.pictureBox_Print.Size = new System.Drawing.Size(118, 119);
            this.pictureBox_Print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Print.TabIndex = 4;
            this.pictureBox_Print.TabStop = false;
            this.pictureBox_Print.Click += new System.EventHandler(this.button_Print_Click);
            this.pictureBox_Print.MouseEnter += new System.EventHandler(this.pictureBox_Print_MouseEnter);
            this.pictureBox_Print.MouseLeave += new System.EventHandler(this.pictureBox_Print_MouseLeave);
            // 
            // label_Print
            // 
            this.label_Print.AutoSize = true;
            this.label_Print.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Print.Location = new System.Drawing.Point(852, 148);
            this.label_Print.Name = "label_Print";
            this.label_Print.Size = new System.Drawing.Size(57, 27);
            this.label_Print.TabIndex = 5;
            this.label_Print.Text = "Print";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(999, 688);
            this.Controls.Add(this.label_Print);
            this.Controls.Add(this.pictureBox_Print);
            this.Controls.Add(this.label_Coin_Report);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.listView_Coins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.Text = "Report";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Supply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Print)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Coins;
        private System.Windows.Forms.ColumnHeader columnHeader_Name;
        private System.Windows.Forms.ColumnHeader columnHeader_Valid;
        private System.Windows.Forms.ColumnHeader columnHeader_Scam;
        private System.Windows.Forms.ColumnHeader columnHeader_Count;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.NumericUpDown numericUpDown_Supply;
        private System.Windows.Forms.TextBox textBox_Filter_Name;
        private System.Windows.Forms.ComboBox comboBox_Filter_Valid;
        private System.Windows.Forms.ComboBox comboBox_Filter_Scam;
        private System.Windows.Forms.Label label_Filter_Valid;
        private System.Windows.Forms.Label label_Supply;
        private System.Windows.Forms.Label label_Filter_Scam;
        private System.Windows.Forms.Label label_Filter_Name;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Label label_Coin_Report;
        private System.Windows.Forms.PictureBox pictureBox_Print;
        private System.Windows.Forms.Label label_Print;
    }
}