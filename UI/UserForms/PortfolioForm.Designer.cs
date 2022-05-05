namespace ClientApp.UI
{
    partial class PortfolioForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortfolioForm));
            this.listBox_Coins = new System.Windows.Forms.ListBox();
            this.label_PortfolioValue = new System.Windows.Forms.Label();
            this.pictureBox_Coin = new System.Windows.Forms.PictureBox();
            this.groupBox_PriceInfo = new System.Windows.Forms.GroupBox();
            this.label_PercentChanged = new System.Windows.Forms.Label();
            this.text_Price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_PercentChanged = new System.Windows.Forms.Label();
            this.text_Volume = new System.Windows.Forms.Label();
            this.text_MarketCap = new System.Windows.Forms.Label();
            this.text_Name = new System.Windows.Forms.Label();
            this.text_Amount = new System.Windows.Forms.Label();
            this.text_PortfolioValue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_FetchCoinPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Coin)).BeginInit();
            this.groupBox_PriceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Coins
            // 
            this.listBox_Coins.FormattingEnabled = true;
            this.listBox_Coins.ItemHeight = 21;
            this.listBox_Coins.Location = new System.Drawing.Point(14, 66);
            this.listBox_Coins.Margin = new System.Windows.Forms.Padding(5);
            this.listBox_Coins.Name = "listBox_Coins";
            this.listBox_Coins.Size = new System.Drawing.Size(256, 403);
            this.listBox_Coins.TabIndex = 0;
            this.listBox_Coins.SelectedIndexChanged += new System.EventHandler(this.listBox_Coins_SelectedIndexChanged);
            // 
            // label_PortfolioValue
            // 
            this.label_PortfolioValue.AutoSize = true;
            this.label_PortfolioValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_PortfolioValue.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PortfolioValue.ForeColor = System.Drawing.Color.White;
            this.label_PortfolioValue.Location = new System.Drawing.Point(18, 20);
            this.label_PortfolioValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_PortfolioValue.Name = "label_PortfolioValue";
            this.label_PortfolioValue.Size = new System.Drawing.Size(217, 32);
            this.label_PortfolioValue.TabIndex = 1;
            this.label_PortfolioValue.Text = "Portfolio Value: ";
            // 
            // pictureBox_Coin
            // 
            this.pictureBox_Coin.Location = new System.Drawing.Point(290, 133);
            this.pictureBox_Coin.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox_Coin.Name = "pictureBox_Coin";
            this.pictureBox_Coin.Size = new System.Drawing.Size(128, 118);
            this.pictureBox_Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Coin.TabIndex = 2;
            this.pictureBox_Coin.TabStop = false;
            // 
            // groupBox_PriceInfo
            // 
            this.groupBox_PriceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox_PriceInfo.Controls.Add(this.label_PercentChanged);
            this.groupBox_PriceInfo.Controls.Add(this.text_Price);
            this.groupBox_PriceInfo.Controls.Add(this.label3);
            this.groupBox_PriceInfo.Controls.Add(this.label_Price);
            this.groupBox_PriceInfo.Controls.Add(this.label4);
            this.groupBox_PriceInfo.Controls.Add(this.text_PercentChanged);
            this.groupBox_PriceInfo.Controls.Add(this.text_Volume);
            this.groupBox_PriceInfo.Controls.Add(this.text_MarketCap);
            this.groupBox_PriceInfo.ForeColor = System.Drawing.Color.White;
            this.groupBox_PriceInfo.Location = new System.Drawing.Point(290, 331);
            this.groupBox_PriceInfo.Name = "groupBox_PriceInfo";
            this.groupBox_PriceInfo.Size = new System.Drawing.Size(265, 154);
            this.groupBox_PriceInfo.TabIndex = 16;
            this.groupBox_PriceInfo.TabStop = false;
            this.groupBox_PriceInfo.Text = "Price info";
            // 
            // label_PercentChanged
            // 
            this.label_PercentChanged.AutoSize = true;
            this.label_PercentChanged.BackColor = System.Drawing.Color.Transparent;
            this.label_PercentChanged.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PercentChanged.Location = new System.Drawing.Point(10, 118);
            this.label_PercentChanged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PercentChanged.Name = "label_PercentChanged";
            this.label_PercentChanged.Size = new System.Drawing.Size(133, 19);
            this.label_PercentChanged.TabIndex = 0;
            this.label_PercentChanged.Text = "Percent Changed";
            // 
            // text_Price
            // 
            this.text_Price.AutoSize = true;
            this.text_Price.BackColor = System.Drawing.Color.Transparent;
            this.text_Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Price.Location = new System.Drawing.Point(52, 25);
            this.text_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(0, 21);
            this.text_Price.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Volume 24H";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.BackColor = System.Drawing.Color.Transparent;
            this.label_Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(10, 25);
            this.label_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(47, 21);
            this.label_Price.TabIndex = 6;
            this.label_Price.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Market Cap";
            // 
            // text_PercentChanged
            // 
            this.text_PercentChanged.AutoSize = true;
            this.text_PercentChanged.BackColor = System.Drawing.Color.Transparent;
            this.text_PercentChanged.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_PercentChanged.Location = new System.Drawing.Point(147, 117);
            this.text_PercentChanged.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text_PercentChanged.Name = "text_PercentChanged";
            this.text_PercentChanged.Size = new System.Drawing.Size(0, 20);
            this.text_PercentChanged.TabIndex = 0;
            // 
            // text_Volume
            // 
            this.text_Volume.AutoSize = true;
            this.text_Volume.BackColor = System.Drawing.Color.Transparent;
            this.text_Volume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Volume.Location = new System.Drawing.Point(104, 83);
            this.text_Volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text_Volume.Name = "text_Volume";
            this.text_Volume.Size = new System.Drawing.Size(0, 21);
            this.text_Volume.TabIndex = 0;
            // 
            // text_MarketCap
            // 
            this.text_MarketCap.AutoSize = true;
            this.text_MarketCap.BackColor = System.Drawing.Color.Transparent;
            this.text_MarketCap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_MarketCap.Location = new System.Drawing.Point(104, 50);
            this.text_MarketCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text_MarketCap.Name = "text_MarketCap";
            this.text_MarketCap.Size = new System.Drawing.Size(0, 21);
            this.text_MarketCap.TabIndex = 0;
            // 
            // text_Name
            // 
            this.text_Name.AutoSize = true;
            this.text_Name.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Name.Location = new System.Drawing.Point(286, 256);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(94, 32);
            this.text_Name.TabIndex = 17;
            this.text_Name.Text = "Name";
            // 
            // text_Amount
            // 
            this.text_Amount.AutoSize = true;
            this.text_Amount.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Amount.Location = new System.Drawing.Point(286, 296);
            this.text_Amount.Name = "text_Amount";
            this.text_Amount.Size = new System.Drawing.Size(116, 32);
            this.text_Amount.TabIndex = 18;
            this.text_Amount.Text = "Amount";
            // 
            // text_PortfolioValue
            // 
            this.text_PortfolioValue.AutoSize = true;
            this.text_PortfolioValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_PortfolioValue.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_PortfolioValue.Location = new System.Drawing.Point(269, -15);
            this.text_PortfolioValue.Name = "text_PortfolioValue";
            this.text_PortfolioValue.Size = new System.Drawing.Size(187, 80);
            this.text_PortfolioValue.TabIndex = 19;
            this.text_PortfolioValue.Text = "Value";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientApp.Properties.Resources.Portfolio_;
            this.pictureBox1.Location = new System.Drawing.Point(426, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // button_FetchCoinPrice
            // 
            this.button_FetchCoinPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FetchCoinPrice.Location = new System.Drawing.Point(290, 77);
            this.button_FetchCoinPrice.Name = "button_FetchCoinPrice";
            this.button_FetchCoinPrice.Size = new System.Drawing.Size(99, 48);
            this.button_FetchCoinPrice.TabIndex = 21;
            this.button_FetchCoinPrice.Text = "Fetch coin prices";
            this.button_FetchCoinPrice.UseVisualStyleBackColor = true;
            this.button_FetchCoinPrice.Click += new System.EventHandler(this.button_FetchCoinPrice_Click);
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(209)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(681, 494);
            this.Controls.Add(this.button_FetchCoinPrice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.text_PortfolioValue);
            this.Controls.Add(this.text_Amount);
            this.Controls.Add(this.text_Name);
            this.Controls.Add(this.groupBox_PriceInfo);
            this.Controls.Add(this.pictureBox_Coin);
            this.Controls.Add(this.label_PortfolioValue);
            this.Controls.Add(this.listBox_Coins);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(115)))), ((int)(((byte)(61)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PortfolioForm";
            this.Text = "PortFolio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Coin)).EndInit();
            this.groupBox_PriceInfo.ResumeLayout(false);
            this.groupBox_PriceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Coins;
        private System.Windows.Forms.Label label_PortfolioValue;
        private System.Windows.Forms.PictureBox pictureBox_Coin;
        private System.Windows.Forms.GroupBox groupBox_PriceInfo;
        private System.Windows.Forms.Label label_PercentChanged;
        private System.Windows.Forms.Label text_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label text_PercentChanged;
        private System.Windows.Forms.Label text_Volume;
        private System.Windows.Forms.Label text_MarketCap;
        private System.Windows.Forms.Label text_Name;
        private System.Windows.Forms.Label text_Amount;
        private System.Windows.Forms.Label text_PortfolioValue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_FetchCoinPrice;
    }
}