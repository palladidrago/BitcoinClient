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
            this.listView_Report = new System.Windows.Forms.ListView();
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
            this.label_Print = new System.Windows.Forms.Label();
            this.button_ClientCoinReport = new System.Windows.Forms.Button();
            this.button_ClientCityReport = new System.Windows.Forms.Button();
            this.button_ValidReport = new System.Windows.Forms.Button();
            this.button_ScamLevels = new System.Windows.Forms.Button();
            this.button_TradeClientCount = new System.Windows.Forms.Button();
            this.button_CoinQuoteReport = new System.Windows.Forms.Button();
            this.pictureBox_Print = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Title_Report = new ClientApp.UI.RoundLabel();
            this.button_CoinReport = new System.Windows.Forms.Button();
            this.groupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Supply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Print)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Report
            // 
            this.listView_Report.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_Name,
            this.columnHeader_Valid,
            this.columnHeader_Scam,
            this.columnHeader_Count});
            this.listView_Report.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Report.HideSelection = false;
            this.listView_Report.Location = new System.Drawing.Point(-1, 70);
            this.listView_Report.Margin = new System.Windows.Forms.Padding(2);
            this.listView_Report.Name = "listView_Report";
            this.listView_Report.Size = new System.Drawing.Size(821, 347);
            this.listView_Report.TabIndex = 0;
            this.listView_Report.UseCompatibleStateImageBehavior = false;
            this.listView_Report.View = System.Windows.Forms.View.Details;
            this.listView_Report.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Report_ColumnClick);
            // 
            // columnHeader_Name
            // 
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Name.Width = 184;
            // 
            // columnHeader_Valid
            // 
            this.columnHeader_Valid.Text = "Validation Method";
            this.columnHeader_Valid.Width = 222;
            // 
            // columnHeader_Scam
            // 
            this.columnHeader_Scam.Text = "Scam Level";
            this.columnHeader_Scam.Width = 221;
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
            this.groupBox_Filter.Location = new System.Drawing.Point(10, 3);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(273, 139);
            this.groupBox_Filter.TabIndex = 2;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // numericUpDown_Supply
            // 
            this.numericUpDown_Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Supply.Location = new System.Drawing.Point(142, 109);
            this.numericUpDown_Supply.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown_Supply.Name = "numericUpDown_Supply";
            this.numericUpDown_Supply.Size = new System.Drawing.Size(90, 26);
            this.numericUpDown_Supply.TabIndex = 3;
            this.numericUpDown_Supply.ValueChanged += new System.EventHandler(this.numericUpDown_Supply_ValueChanged);
            // 
            // textBox_Filter_Name
            // 
            this.textBox_Filter_Name.Location = new System.Drawing.Point(142, 17);
            this.textBox_Filter_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Filter_Name.Name = "textBox_Filter_Name";
            this.textBox_Filter_Name.Size = new System.Drawing.Size(76, 20);
            this.textBox_Filter_Name.TabIndex = 2;
            this.textBox_Filter_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_Name_KeyUp);
            // 
            // comboBox_Filter_Valid
            // 
            this.comboBox_Filter_Valid.FormattingEnabled = true;
            this.comboBox_Filter_Valid.Location = new System.Drawing.Point(142, 44);
            this.comboBox_Filter_Valid.Name = "comboBox_Filter_Valid";
            this.comboBox_Filter_Valid.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Filter_Valid.TabIndex = 0;
            this.comboBox_Filter_Valid.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_Valid_SelectedIndexChanged);
            // 
            // comboBox_Filter_Scam
            // 
            this.comboBox_Filter_Scam.FormattingEnabled = true;
            this.comboBox_Filter_Scam.Location = new System.Drawing.Point(142, 77);
            this.comboBox_Filter_Scam.Name = "comboBox_Filter_Scam";
            this.comboBox_Filter_Scam.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Filter_Scam.TabIndex = 0;
            this.comboBox_Filter_Scam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_Scam_SelectedIndexChanged);
            // 
            // label_Filter_Valid
            // 
            this.label_Filter_Valid.AutoSize = true;
            this.label_Filter_Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Valid.Location = new System.Drawing.Point(8, 46);
            this.label_Filter_Valid.Name = "label_Filter_Valid";
            this.label_Filter_Valid.Size = new System.Drawing.Size(133, 20);
            this.label_Filter_Valid.TabIndex = 0;
            this.label_Filter_Valid.Text = "Validation system";
            // 
            // label_Supply
            // 
            this.label_Supply.AutoSize = true;
            this.label_Supply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Supply.Location = new System.Drawing.Point(8, 110);
            this.label_Supply.Name = "label_Supply";
            this.label_Supply.Size = new System.Drawing.Size(57, 20);
            this.label_Supply.TabIndex = 0;
            this.label_Supply.Text = "Supply";
            // 
            // label_Filter_Scam
            // 
            this.label_Filter_Scam.AutoSize = true;
            this.label_Filter_Scam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Scam.Location = new System.Drawing.Point(8, 76);
            this.label_Filter_Scam.Name = "label_Filter_Scam";
            this.label_Filter_Scam.Size = new System.Drawing.Size(91, 20);
            this.label_Filter_Scam.TabIndex = 0;
            this.label_Filter_Scam.Text = "Scam Level";
            // 
            // label_Filter_Name
            // 
            this.label_Filter_Name.AutoSize = true;
            this.label_Filter_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Name.Location = new System.Drawing.Point(8, 17);
            this.label_Filter_Name.Name = "label_Filter_Name";
            this.label_Filter_Name.Size = new System.Drawing.Size(51, 20);
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
            // label_Print
            // 
            this.label_Print.AutoSize = true;
            this.label_Print.Font = new System.Drawing.Font("Rockwell Nova", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Print.Location = new System.Drawing.Point(707, 115);
            this.label_Print.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Print.Name = "label_Print";
            this.label_Print.Size = new System.Drawing.Size(68, 33);
            this.label_Print.TabIndex = 5;
            this.label_Print.Text = "Print";
            // 
            // button_ClientCoinReport
            // 
            this.button_ClientCoinReport.BackColor = System.Drawing.Color.White;
            this.button_ClientCoinReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClientCoinReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClientCoinReport.Location = new System.Drawing.Point(373, 3);
            this.button_ClientCoinReport.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClientCoinReport.Name = "button_ClientCoinReport";
            this.button_ClientCoinReport.Size = new System.Drawing.Size(61, 63);
            this.button_ClientCoinReport.TabIndex = 8;
            this.button_ClientCoinReport.Text = "Client Coin Report";
            this.button_ClientCoinReport.UseVisualStyleBackColor = false;
            this.button_ClientCoinReport.Click += new System.EventHandler(this.button_ClientCoinReport_Click);
            // 
            // button_ClientCityReport
            // 
            this.button_ClientCityReport.BackColor = System.Drawing.Color.White;
            this.button_ClientCityReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ClientCityReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ClientCityReport.Location = new System.Drawing.Point(438, 3);
            this.button_ClientCityReport.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClientCityReport.Name = "button_ClientCityReport";
            this.button_ClientCityReport.Size = new System.Drawing.Size(61, 63);
            this.button_ClientCityReport.TabIndex = 8;
            this.button_ClientCityReport.Text = "Client City Report";
            this.button_ClientCityReport.UseVisualStyleBackColor = false;
            this.button_ClientCityReport.Click += new System.EventHandler(this.button_ClientCityReport_Click);
            // 
            // button_ValidReport
            // 
            this.button_ValidReport.BackColor = System.Drawing.Color.White;
            this.button_ValidReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ValidReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ValidReport.Location = new System.Drawing.Point(503, 3);
            this.button_ValidReport.Margin = new System.Windows.Forms.Padding(2);
            this.button_ValidReport.Name = "button_ValidReport";
            this.button_ValidReport.Size = new System.Drawing.Size(61, 63);
            this.button_ValidReport.TabIndex = 8;
            this.button_ValidReport.Text = "Valid Report";
            this.button_ValidReport.UseVisualStyleBackColor = false;
            this.button_ValidReport.Click += new System.EventHandler(this.button_ValidReport_Click);
            // 
            // button_ScamLevels
            // 
            this.button_ScamLevels.BackColor = System.Drawing.Color.White;
            this.button_ScamLevels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ScamLevels.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ScamLevels.Location = new System.Drawing.Point(337, 70);
            this.button_ScamLevels.Margin = new System.Windows.Forms.Padding(2);
            this.button_ScamLevels.Name = "button_ScamLevels";
            this.button_ScamLevels.Size = new System.Drawing.Size(61, 63);
            this.button_ScamLevels.TabIndex = 8;
            this.button_ScamLevels.Text = "Scam Report";
            this.button_ScamLevels.UseVisualStyleBackColor = false;
            this.button_ScamLevels.Click += new System.EventHandler(this.button_ScamLevels_Click);
            // 
            // button_TradeClientCount
            // 
            this.button_TradeClientCount.BackColor = System.Drawing.Color.White;
            this.button_TradeClientCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_TradeClientCount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TradeClientCount.Location = new System.Drawing.Point(403, 70);
            this.button_TradeClientCount.Margin = new System.Windows.Forms.Padding(2);
            this.button_TradeClientCount.Name = "button_TradeClientCount";
            this.button_TradeClientCount.Size = new System.Drawing.Size(61, 63);
            this.button_TradeClientCount.TabIndex = 8;
            this.button_TradeClientCount.Text = "Trade Client Report";
            this.button_TradeClientCount.UseVisualStyleBackColor = false;
            this.button_TradeClientCount.Click += new System.EventHandler(this.button_TradeClientCount_Click);
            // 
            // button_CoinQuoteReport
            // 
            this.button_CoinQuoteReport.BackColor = System.Drawing.Color.White;
            this.button_CoinQuoteReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CoinQuoteReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CoinQuoteReport.Location = new System.Drawing.Point(468, 70);
            this.button_CoinQuoteReport.Margin = new System.Windows.Forms.Padding(2);
            this.button_CoinQuoteReport.Name = "button_CoinQuoteReport";
            this.button_CoinQuoteReport.Size = new System.Drawing.Size(61, 63);
            this.button_CoinQuoteReport.TabIndex = 8;
            this.button_CoinQuoteReport.Text = "Coin Quote Report";
            this.button_CoinQuoteReport.UseVisualStyleBackColor = false;
            this.button_CoinQuoteReport.Click += new System.EventHandler(this.button_CoinQuoteReport_Click);
            // 
            // pictureBox_Print
            // 
            this.pictureBox_Print.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_Print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Print.Image = global::ClientApp.Properties.Resources._15022c18a022e53b517ad921c9f9e87d;
            this.pictureBox_Print.Location = new System.Drawing.Point(695, 16);
            this.pictureBox_Print.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_Print.Name = "pictureBox_Print";
            this.pictureBox_Print.Size = new System.Drawing.Size(89, 97);
            this.pictureBox_Print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Print.TabIndex = 4;
            this.pictureBox_Print.TabStop = false;
            this.pictureBox_Print.Click += new System.EventHandler(this.button_Print_Click);
            this.pictureBox_Print.MouseEnter += new System.EventHandler(this.pictureBox_Print_MouseEnter);
            this.pictureBox_Print.MouseLeave += new System.EventHandler(this.pictureBox_Print_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView_Report);
            this.groupBox1.Controls.Add(this.label_Title_Report);
            this.groupBox1.Location = new System.Drawing.Point(10, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(822, 401);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // label_Title_Report
            // 
            this.label_Title_Report._BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(60)))));
            this.label_Title_Report.AutoSize = true;
            this.label_Title_Report.BackColor = System.Drawing.Color.Transparent;
            this.label_Title_Report.cornerRadius = 25;
            this.label_Title_Report.Font = new System.Drawing.Font("Rockwell Nova", 25.8F, System.Drawing.FontStyle.Italic);
            this.label_Title_Report.Location = new System.Drawing.Point(267, 15);
            this.label_Title_Report.Name = "label_Title_Report";
            this.label_Title_Report.Size = new System.Drawing.Size(222, 48);
            this.label_Title_Report.TabIndex = 7;
            this.label_Title_Report.Text = "Coin Report";
            // 
            // button_CoinReport
            // 
            this.button_CoinReport.BackColor = System.Drawing.Color.White;
            this.button_CoinReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CoinReport.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CoinReport.Location = new System.Drawing.Point(308, 3);
            this.button_CoinReport.Margin = new System.Windows.Forms.Padding(2);
            this.button_CoinReport.Name = "button_CoinReport";
            this.button_CoinReport.Size = new System.Drawing.Size(61, 63);
            this.button_CoinReport.TabIndex = 20;
            this.button_CoinReport.Text = "Coin Report";
            this.button_CoinReport.UseVisualStyleBackColor = false;
            this.button_CoinReport.Click += new System.EventHandler(this.button_CoinReport_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(841, 559);
            this.Controls.Add(this.button_CoinReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_ScamLevels);
            this.Controls.Add(this.button_TradeClientCount);
            this.Controls.Add(this.button_CoinQuoteReport);
            this.Controls.Add(this.button_ValidReport);
            this.Controls.Add(this.button_ClientCityReport);
            this.Controls.Add(this.button_ClientCoinReport);
            this.Controls.Add(this.label_Print);
            this.Controls.Add(this.pictureBox_Print);
            this.Controls.Add(this.groupBox_Filter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportForm";
            this.Text = "Report form";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Supply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Print)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Report;
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
        private System.Windows.Forms.PictureBox pictureBox_Print;
        private System.Windows.Forms.Label label_Print;
        private UI.RoundLabel label_Title_Report;
        private System.Windows.Forms.Button button_ClientCoinReport;
        private System.Windows.Forms.Button button_ClientCityReport;
        private System.Windows.Forms.Button button_ValidReport;
        private System.Windows.Forms.Button button_ScamLevels;
        private System.Windows.Forms.Button button_TradeClientCount;
        private System.Windows.Forms.Button button_CoinQuoteReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_CoinReport;
    }
}