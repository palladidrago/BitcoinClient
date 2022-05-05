namespace ClientApp.UI
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.label_Title = new System.Windows.Forms.Label();
            this.groupBox_Chart = new System.Windows.Forms.GroupBox();
            this.chart_Report = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.roundLabel_Valid = new ClientApp.UI.RoundLabel();
            this.roundLabel_CoinQuote = new ClientApp.UI.RoundLabel();
            this.roundLabel_ClientCountry = new ClientApp.UI.RoundLabel();
            this.roundLabel_TradeClient = new ClientApp.UI.RoundLabel();
            this.roundLabel_ClientCoin = new ClientApp.UI.RoundLabel();
            this.roundLabel_Scam = new ClientApp.UI.RoundLabel();
            this.groupBox_Chart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label_Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Title.Font = new System.Drawing.Font("Ubuntu", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(377, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(111, 56);
            this.label_Title.TabIndex = 2;
            this.label_Title.Text = "Coin";
            // 
            // groupBox_Chart
            // 
            this.groupBox_Chart.Controls.Add(this.chart_Report);
            this.groupBox_Chart.Controls.Add(this.label_Title);
            this.groupBox_Chart.Location = new System.Drawing.Point(15, 144);
            this.groupBox_Chart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Chart.Name = "groupBox_Chart";
            this.groupBox_Chart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Chart.Size = new System.Drawing.Size(925, 474);
            this.groupBox_Chart.TabIndex = 3;
            this.groupBox_Chart.TabStop = false;
            // 
            // chart_Report
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Report.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Report.Legends.Add(legend1);
            this.chart_Report.Location = new System.Drawing.Point(7, 68);
            this.chart_Report.Margin = new System.Windows.Forms.Padding(4);
            this.chart_Report.Name = "chart_Report";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_Report.Series.Add(series1);
            this.chart_Report.Size = new System.Drawing.Size(907, 400);
            this.chart_Report.TabIndex = 3;
            this.chart_Report.Text = "chart1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClientApp.Properties.Resources.linegoup;
            this.pictureBox2.Location = new System.Drawing.Point(828, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 130);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientApp.Properties.Resources.linegoup2;
            this.pictureBox1.Location = new System.Drawing.Point(15, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            // roundLabel_Valid
            // 
            this.roundLabel_Valid._BackColor = System.Drawing.Color.Crimson;
            this.roundLabel_Valid.AutoSize = true;
            this.roundLabel_Valid.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel_Valid.cornerRadius = 10;
            this.roundLabel_Valid.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel_Valid.ForeColor = System.Drawing.Color.Black;
            this.roundLabel_Valid.Location = new System.Drawing.Point(704, 82);
            this.roundLabel_Valid.Name = "roundLabel_Valid";
            this.roundLabel_Valid.Size = new System.Drawing.Size(108, 44);
            this.roundLabel_Valid.TabIndex = 1;
            this.roundLabel_Valid.Text = "Valid";
            this.roundLabel_Valid.Click += new System.EventHandler(this.roundLabel_Valid_Click);
            this.roundLabel_Valid.MouseEnter += new System.EventHandler(this.roundLabel_MouseEnter);
            this.roundLabel_Valid.MouseLeave += new System.EventHandler(this.roundLabel_MouseLeave);
            // 
            // roundLabel_CoinQuote
            // 
            this.roundLabel_CoinQuote._BackColor = System.Drawing.Color.Crimson;
            this.roundLabel_CoinQuote.AutoSize = true;
            this.roundLabel_CoinQuote.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel_CoinQuote.cornerRadius = 10;
            this.roundLabel_CoinQuote.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel_CoinQuote.ForeColor = System.Drawing.Color.Black;
            this.roundLabel_CoinQuote.Location = new System.Drawing.Point(436, 26);
            this.roundLabel_CoinQuote.Name = "roundLabel_CoinQuote";
            this.roundLabel_CoinQuote.Size = new System.Drawing.Size(207, 44);
            this.roundLabel_CoinQuote.TabIndex = 1;
            this.roundLabel_CoinQuote.Text = "Coin Quote";
            this.roundLabel_CoinQuote.Click += new System.EventHandler(this.roundLabel_CoinQuote_Click);
            this.roundLabel_CoinQuote.MouseEnter += new System.EventHandler(this.roundLabel_MouseEnter);
            this.roundLabel_CoinQuote.MouseLeave += new System.EventHandler(this.roundLabel_MouseLeave);
            // 
            // roundLabel_ClientCountry
            // 
            this.roundLabel_ClientCountry._BackColor = System.Drawing.Color.Crimson;
            this.roundLabel_ClientCountry.AutoSize = true;
            this.roundLabel_ClientCountry.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel_ClientCountry.cornerRadius = 10;
            this.roundLabel_ClientCountry.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel_ClientCountry.ForeColor = System.Drawing.Color.Black;
            this.roundLabel_ClientCountry.Location = new System.Drawing.Point(412, 82);
            this.roundLabel_ClientCountry.Name = "roundLabel_ClientCountry";
            this.roundLabel_ClientCountry.Size = new System.Drawing.Size(264, 44);
            this.roundLabel_ClientCountry.TabIndex = 1;
            this.roundLabel_ClientCountry.Text = "Client Country";
            this.roundLabel_ClientCountry.Click += new System.EventHandler(this.roundLabel_ClientCountry_Click);
            this.roundLabel_ClientCountry.MouseEnter += new System.EventHandler(this.roundLabel_MouseEnter);
            this.roundLabel_ClientCountry.MouseLeave += new System.EventHandler(this.roundLabel_MouseLeave);
            // 
            // roundLabel_TradeClient
            // 
            this.roundLabel_TradeClient._BackColor = System.Drawing.Color.Crimson;
            this.roundLabel_TradeClient.AutoSize = true;
            this.roundLabel_TradeClient.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel_TradeClient.cornerRadius = 10;
            this.roundLabel_TradeClient.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel_TradeClient.ForeColor = System.Drawing.Color.Black;
            this.roundLabel_TradeClient.Location = new System.Drawing.Point(184, 26);
            this.roundLabel_TradeClient.Name = "roundLabel_TradeClient";
            this.roundLabel_TradeClient.Size = new System.Drawing.Size(226, 44);
            this.roundLabel_TradeClient.TabIndex = 1;
            this.roundLabel_TradeClient.Text = "Trade Client";
            this.roundLabel_TradeClient.Click += new System.EventHandler(this.roundLabel_TradeClient_Click);
            this.roundLabel_TradeClient.MouseEnter += new System.EventHandler(this.roundLabel_MouseEnter);
            this.roundLabel_TradeClient.MouseLeave += new System.EventHandler(this.roundLabel_MouseLeave);
            // 
            // roundLabel_ClientCoin
            // 
            this.roundLabel_ClientCoin._BackColor = System.Drawing.Color.Crimson;
            this.roundLabel_ClientCoin.AutoSize = true;
            this.roundLabel_ClientCoin.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel_ClientCoin.cornerRadius = 10;
            this.roundLabel_ClientCoin.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel_ClientCoin.ForeColor = System.Drawing.Color.Black;
            this.roundLabel_ClientCoin.Location = new System.Drawing.Point(184, 82);
            this.roundLabel_ClientCoin.Name = "roundLabel_ClientCoin";
            this.roundLabel_ClientCoin.Size = new System.Drawing.Size(206, 44);
            this.roundLabel_ClientCoin.TabIndex = 1;
            this.roundLabel_ClientCoin.Text = "Client Coin";
            this.roundLabel_ClientCoin.Click += new System.EventHandler(this.roundLabel_ClientCoin_Click);
            this.roundLabel_ClientCoin.MouseEnter += new System.EventHandler(this.roundLabel_MouseEnter);
            this.roundLabel_ClientCoin.MouseLeave += new System.EventHandler(this.roundLabel_MouseLeave);
            // 
            // roundLabel_Scam
            // 
            this.roundLabel_Scam._BackColor = System.Drawing.Color.Crimson;
            this.roundLabel_Scam.AutoSize = true;
            this.roundLabel_Scam.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel_Scam.cornerRadius = 10;
            this.roundLabel_Scam.Font = new System.Drawing.Font("Rockwell Nova", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel_Scam.ForeColor = System.Drawing.Color.Black;
            this.roundLabel_Scam.Location = new System.Drawing.Point(667, 26);
            this.roundLabel_Scam.Name = "roundLabel_Scam";
            this.roundLabel_Scam.Size = new System.Drawing.Size(107, 44);
            this.roundLabel_Scam.TabIndex = 1;
            this.roundLabel_Scam.Text = "Scam";
            this.roundLabel_Scam.Click += new System.EventHandler(this.roundLabel_Scam_Click);
            this.roundLabel_Scam.MouseEnter += new System.EventHandler(this.roundLabel_MouseEnter);
            this.roundLabel_Scam.MouseLeave += new System.EventHandler(this.roundLabel_MouseLeave);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(988, 617);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_Chart);
            this.Controls.Add(this.roundLabel_Valid);
            this.Controls.Add(this.roundLabel_CoinQuote);
            this.Controls.Add(this.roundLabel_ClientCountry);
            this.Controls.Add(this.roundLabel_TradeClient);
            this.Controls.Add(this.roundLabel_ClientCoin);
            this.Controls.Add(this.roundLabel_Scam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChartForm";
            this.Text = "Chart";
            this.groupBox_Chart.ResumeLayout(false);
            this.groupBox_Chart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundLabel roundLabel_Scam;
        private RoundLabel roundLabel_ClientCoin;
        private RoundLabel roundLabel_TradeClient;
        private RoundLabel roundLabel_ClientCountry;
        private RoundLabel roundLabel_CoinQuote;
        private RoundLabel roundLabel_Valid;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.GroupBox groupBox_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Report;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}