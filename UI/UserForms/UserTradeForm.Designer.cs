namespace ClientApp.UI
{
    partial class UserTradeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTradeForm));
            this.tabPage_TradeCoins = new System.Windows.Forms.TabPage();
            this.button_FetchCoinPrice = new System.Windows.Forms.Button();
            this.groupBox_PriceInfo = new System.Windows.Forms.GroupBox();
            this.label_PercentChanged = new System.Windows.Forms.Label();
            this.text_Price = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_PercentChanged = new System.Windows.Forms.Label();
            this.text_Volume = new System.Windows.Forms.Label();
            this.text_MarketCap = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.listBox_Chosen_Coins_Supply = new System.Windows.Forms.ListBox();
            this.button_Minus_Coin = new System.Windows.Forms.Button();
            this.button_Plus_Coin = new System.Windows.Forms.Button();
            this.groupBox_Coin_Filter = new System.Windows.Forms.GroupBox();
            this.textBox_Coin_Filter_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Coin_Filter_Valid = new System.Windows.Forms.ComboBox();
            this.comboBox_Coin_Filter_Scam = new System.Windows.Forms.ComboBox();
            this.label_Coin_Filter_Valid = new System.Windows.Forms.Label();
            this.label_Coin_Filter_Scam = new System.Windows.Forms.Label();
            this.label_Coin_Filter_Name = new System.Windows.Forms.Label();
            this.listBox_Chosen_Coins = new System.Windows.Forms.ListBox();
            this.listBox_Potential_Coins = new System.Windows.Forms.ListBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.tabControl_TradeForm = new System.Windows.Forms.TabControl();
            this.tradeDetails = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.text_Id = new System.Windows.Forms.Label();
            this.textBox_Memo = new System.Windows.Forms.TextBox();
            this.label_Memo = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.listBox_Trades = new System.Windows.Forms.ListBox();
            this.groupBox_Filter_Details = new System.Windows.Forms.GroupBox();
            this.textBox_Filter_Id = new System.Windows.Forms.TextBox();
            this.label_Filter_Id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage_TradeCoins.SuspendLayout();
            this.groupBox_PriceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.groupBox_Coin_Filter.SuspendLayout();
            this.tabControl_TradeForm.SuspendLayout();
            this.tradeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox_Filter_Details.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_TradeCoins
            // 
            this.tabPage_TradeCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(209)))), ((int)(((byte)(239)))));
            this.tabPage_TradeCoins.Controls.Add(this.button_FetchCoinPrice);
            this.tabPage_TradeCoins.Controls.Add(this.groupBox_PriceInfo);
            this.tabPage_TradeCoins.Controls.Add(this.pictureBox_Logo);
            this.tabPage_TradeCoins.Controls.Add(this.listBox_Chosen_Coins_Supply);
            this.tabPage_TradeCoins.Controls.Add(this.button_Minus_Coin);
            this.tabPage_TradeCoins.Controls.Add(this.button_Plus_Coin);
            this.tabPage_TradeCoins.Controls.Add(this.groupBox_Coin_Filter);
            this.tabPage_TradeCoins.Controls.Add(this.listBox_Chosen_Coins);
            this.tabPage_TradeCoins.Controls.Add(this.listBox_Potential_Coins);
            this.tabPage_TradeCoins.Location = new System.Drawing.Point(4, 28);
            this.tabPage_TradeCoins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_TradeCoins.Name = "tabPage_TradeCoins";
            this.tabPage_TradeCoins.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_TradeCoins.Size = new System.Drawing.Size(1123, 417);
            this.tabPage_TradeCoins.TabIndex = 2;
            this.tabPage_TradeCoins.Text = "Trade Coins";
            // 
            // button_FetchCoinPrice
            // 
            this.button_FetchCoinPrice.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FetchCoinPrice.Location = new System.Drawing.Point(0, 316);
            this.button_FetchCoinPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_FetchCoinPrice.Name = "button_FetchCoinPrice";
            this.button_FetchCoinPrice.Size = new System.Drawing.Size(123, 57);
            this.button_FetchCoinPrice.TabIndex = 16;
            this.button_FetchCoinPrice.Text = "Fetch coin price";
            this.button_FetchCoinPrice.UseVisualStyleBackColor = true;
            this.button_FetchCoinPrice.Click += new System.EventHandler(this.button_FetchCoinPrice_Click);
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
            this.groupBox_PriceInfo.Location = new System.Drawing.Point(131, 182);
            this.groupBox_PriceInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_PriceInfo.Name = "groupBox_PriceInfo";
            this.groupBox_PriceInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_PriceInfo.Size = new System.Drawing.Size(345, 190);
            this.groupBox_PriceInfo.TabIndex = 15;
            this.groupBox_PriceInfo.TabStop = false;
            this.groupBox_PriceInfo.Text = "Price info";
            // 
            // label_PercentChanged
            // 
            this.label_PercentChanged.AutoSize = true;
            this.label_PercentChanged.BackColor = System.Drawing.Color.Transparent;
            this.label_PercentChanged.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PercentChanged.Location = new System.Drawing.Point(11, 143);
            this.label_PercentChanged.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label_PercentChanged.Name = "label_PercentChanged";
            this.label_PercentChanged.Size = new System.Drawing.Size(160, 21);
            this.label_PercentChanged.TabIndex = 0;
            this.label_PercentChanged.Text = "Percent Changed";
            // 
            // text_Price
            // 
            this.text_Price.AutoSize = true;
            this.text_Price.BackColor = System.Drawing.Color.Transparent;
            this.text_Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Price.Location = new System.Drawing.Point(77, 21);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(0, 23);
            this.text_Price.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Volume 24H";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.BackColor = System.Drawing.Color.Transparent;
            this.label_Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(11, 21);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(57, 23);
            this.label_Price.TabIndex = 6;
            this.label_Price.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Market Cap";
            // 
            // text_PercentChanged
            // 
            this.text_PercentChanged.AutoSize = true;
            this.text_PercentChanged.BackColor = System.Drawing.Color.Transparent;
            this.text_PercentChanged.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_PercentChanged.Location = new System.Drawing.Point(188, 142);
            this.text_PercentChanged.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.text_PercentChanged.Name = "text_PercentChanged";
            this.text_PercentChanged.Size = new System.Drawing.Size(0, 21);
            this.text_PercentChanged.TabIndex = 0;
            // 
            // text_Volume
            // 
            this.text_Volume.AutoSize = true;
            this.text_Volume.BackColor = System.Drawing.Color.Transparent;
            this.text_Volume.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Volume.Location = new System.Drawing.Point(139, 95);
            this.text_Volume.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.text_Volume.Name = "text_Volume";
            this.text_Volume.Size = new System.Drawing.Size(0, 23);
            this.text_Volume.TabIndex = 0;
            // 
            // text_MarketCap
            // 
            this.text_MarketCap.AutoSize = true;
            this.text_MarketCap.BackColor = System.Drawing.Color.Transparent;
            this.text_MarketCap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_MarketCap.Location = new System.Drawing.Point(132, 55);
            this.text_MarketCap.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.text_MarketCap.Name = "text_MarketCap";
            this.text_MarketCap.Size = new System.Drawing.Size(0, 23);
            this.text_MarketCap.TabIndex = 0;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Location = new System.Drawing.Point(3, 182);
            this.pictureBox_Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(120, 113);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 5;
            this.pictureBox_Logo.TabStop = false;
            // 
            // listBox_Chosen_Coins_Supply
            // 
            this.listBox_Chosen_Coins_Supply.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Chosen_Coins_Supply.FormattingEnabled = true;
            this.listBox_Chosen_Coins_Supply.ItemHeight = 21;
            this.listBox_Chosen_Coins_Supply.Location = new System.Drawing.Point(919, 15);
            this.listBox_Chosen_Coins_Supply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_Chosen_Coins_Supply.Name = "listBox_Chosen_Coins_Supply";
            this.listBox_Chosen_Coins_Supply.Size = new System.Drawing.Size(113, 340);
            this.listBox_Chosen_Coins_Supply.TabIndex = 4;
            this.listBox_Chosen_Coins_Supply.SelectedIndexChanged += new System.EventHandler(this.listBox_Chosen_Coins_Supply_SelectedIndexChanged);
            // 
            // button_Minus_Coin
            // 
            this.button_Minus_Coin.BackColor = System.Drawing.Color.Red;
            this.button_Minus_Coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minus_Coin.Location = new System.Drawing.Point(1039, 198);
            this.button_Minus_Coin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Minus_Coin.Name = "button_Minus_Coin";
            this.button_Minus_Coin.Size = new System.Drawing.Size(72, 174);
            this.button_Minus_Coin.TabIndex = 3;
            this.button_Minus_Coin.Text = "-";
            this.button_Minus_Coin.UseVisualStyleBackColor = false;
            this.button_Minus_Coin.Click += new System.EventHandler(this.button_Minus_Coin_Click);
            // 
            // button_Plus_Coin
            // 
            this.button_Plus_Coin.BackColor = System.Drawing.Color.LawnGreen;
            this.button_Plus_Coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Plus_Coin.Location = new System.Drawing.Point(1039, 15);
            this.button_Plus_Coin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Plus_Coin.Name = "button_Plus_Coin";
            this.button_Plus_Coin.Size = new System.Drawing.Size(72, 160);
            this.button_Plus_Coin.TabIndex = 3;
            this.button_Plus_Coin.Text = "+";
            this.button_Plus_Coin.UseVisualStyleBackColor = false;
            this.button_Plus_Coin.Click += new System.EventHandler(this.button_Plus_Coin_Click);
            // 
            // groupBox_Coin_Filter
            // 
            this.groupBox_Coin_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox_Coin_Filter.Controls.Add(this.textBox_Coin_Filter_Name);
            this.groupBox_Coin_Filter.Controls.Add(this.comboBox_Coin_Filter_Valid);
            this.groupBox_Coin_Filter.Controls.Add(this.comboBox_Coin_Filter_Scam);
            this.groupBox_Coin_Filter.Controls.Add(this.label_Coin_Filter_Valid);
            this.groupBox_Coin_Filter.Controls.Add(this.label_Coin_Filter_Scam);
            this.groupBox_Coin_Filter.Controls.Add(this.label_Coin_Filter_Name);
            this.groupBox_Coin_Filter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Coin_Filter.Location = new System.Drawing.Point(7, 14);
            this.groupBox_Coin_Filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Coin_Filter.Name = "groupBox_Coin_Filter";
            this.groupBox_Coin_Filter.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Coin_Filter.Size = new System.Drawing.Size(469, 160);
            this.groupBox_Coin_Filter.TabIndex = 2;
            this.groupBox_Coin_Filter.TabStop = false;
            this.groupBox_Coin_Filter.Text = "Coin Filter";
            // 
            // textBox_Coin_Filter_Name
            // 
            this.textBox_Coin_Filter_Name.Location = new System.Drawing.Point(188, 38);
            this.textBox_Coin_Filter_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Coin_Filter_Name.Name = "textBox_Coin_Filter_Name";
            this.textBox_Coin_Filter_Name.Size = new System.Drawing.Size(100, 28);
            this.textBox_Coin_Filter_Name.TabIndex = 2;
            this.textBox_Coin_Filter_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Coin_Filter_Name_KeyUp);
            // 
            // comboBox_Coin_Filter_Valid
            // 
            this.comboBox_Coin_Filter_Valid.FormattingEnabled = true;
            this.comboBox_Coin_Filter_Valid.Location = new System.Drawing.Point(188, 71);
            this.comboBox_Coin_Filter_Valid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Coin_Filter_Valid.Name = "comboBox_Coin_Filter_Valid";
            this.comboBox_Coin_Filter_Valid.Size = new System.Drawing.Size(160, 29);
            this.comboBox_Coin_Filter_Valid.TabIndex = 0;
            this.comboBox_Coin_Filter_Valid.SelectedIndexChanged += new System.EventHandler(this.comboBox_Coin_Filter_Valid_SelectedIndexChanged);
            // 
            // comboBox_Coin_Filter_Scam
            // 
            this.comboBox_Coin_Filter_Scam.FormattingEnabled = true;
            this.comboBox_Coin_Filter_Scam.Location = new System.Drawing.Point(188, 112);
            this.comboBox_Coin_Filter_Scam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_Coin_Filter_Scam.Name = "comboBox_Coin_Filter_Scam";
            this.comboBox_Coin_Filter_Scam.Size = new System.Drawing.Size(160, 29);
            this.comboBox_Coin_Filter_Scam.TabIndex = 0;
            this.comboBox_Coin_Filter_Scam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Coin_Filter_Scam_SelectedIndexChanged);
            // 
            // label_Coin_Filter_Valid
            // 
            this.label_Coin_Filter_Valid.AutoSize = true;
            this.label_Coin_Filter_Valid.BackColor = System.Drawing.Color.Transparent;
            this.label_Coin_Filter_Valid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coin_Filter_Valid.Location = new System.Drawing.Point(8, 73);
            this.label_Coin_Filter_Valid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Coin_Filter_Valid.Name = "label_Coin_Filter_Valid";
            this.label_Coin_Filter_Valid.Size = new System.Drawing.Size(170, 22);
            this.label_Coin_Filter_Valid.TabIndex = 0;
            this.label_Coin_Filter_Valid.Text = "Validation system";
            // 
            // label_Coin_Filter_Scam
            // 
            this.label_Coin_Filter_Scam.AutoSize = true;
            this.label_Coin_Filter_Scam.BackColor = System.Drawing.Color.Transparent;
            this.label_Coin_Filter_Scam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coin_Filter_Scam.Location = new System.Drawing.Point(8, 114);
            this.label_Coin_Filter_Scam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Coin_Filter_Scam.Name = "label_Coin_Filter_Scam";
            this.label_Coin_Filter_Scam.Size = new System.Drawing.Size(115, 22);
            this.label_Coin_Filter_Scam.TabIndex = 0;
            this.label_Coin_Filter_Scam.Text = "Scam Level";
            // 
            // label_Coin_Filter_Name
            // 
            this.label_Coin_Filter_Name.AutoSize = true;
            this.label_Coin_Filter_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Coin_Filter_Name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coin_Filter_Name.Location = new System.Drawing.Point(8, 38);
            this.label_Coin_Filter_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Coin_Filter_Name.Name = "label_Coin_Filter_Name";
            this.label_Coin_Filter_Name.Size = new System.Drawing.Size(66, 22);
            this.label_Coin_Filter_Name.TabIndex = 0;
            this.label_Coin_Filter_Name.Text = "Name";
            // 
            // listBox_Chosen_Coins
            // 
            this.listBox_Chosen_Coins.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Chosen_Coins.FormattingEnabled = true;
            this.listBox_Chosen_Coins.ItemHeight = 21;
            this.listBox_Chosen_Coins.Location = new System.Drawing.Point(716, 14);
            this.listBox_Chosen_Coins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_Chosen_Coins.Name = "listBox_Chosen_Coins";
            this.listBox_Chosen_Coins.Size = new System.Drawing.Size(195, 340);
            this.listBox_Chosen_Coins.TabIndex = 0;
            this.listBox_Chosen_Coins.SelectedIndexChanged += new System.EventHandler(this.listBox_Chosen_Coins_SelectedIndexChanged);
            // 
            // listBox_Potential_Coins
            // 
            this.listBox_Potential_Coins.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Potential_Coins.FormattingEnabled = true;
            this.listBox_Potential_Coins.ItemHeight = 21;
            this.listBox_Potential_Coins.Location = new System.Drawing.Point(500, 14);
            this.listBox_Potential_Coins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_Potential_Coins.Name = "listBox_Potential_Coins";
            this.listBox_Potential_Coins.Size = new System.Drawing.Size(211, 340);
            this.listBox_Potential_Coins.TabIndex = 0;
            this.listBox_Potential_Coins.SelectedIndexChanged += new System.EventHandler(this.listBox_Potential_Coins_SelectedIndexChanged);
            this.listBox_Potential_Coins.DoubleClick += new System.EventHandler(this.listBox_Potential_Coins_DoubleClick);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Lime;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(109, 22);
            this.button_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(93, 39);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(13, 22);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(91, 39);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Crimson;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(208, 22);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(93, 39);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // tabControl_TradeForm
            // 
            this.tabControl_TradeForm.Controls.Add(this.tradeDetails);
            this.tabControl_TradeForm.Controls.Add(this.tabPage_TradeCoins);
            this.tabControl_TradeForm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_TradeForm.Location = new System.Drawing.Point(3, 14);
            this.tabControl_TradeForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl_TradeForm.Name = "tabControl_TradeForm";
            this.tabControl_TradeForm.SelectedIndex = 0;
            this.tabControl_TradeForm.Size = new System.Drawing.Size(1131, 449);
            this.tabControl_TradeForm.TabIndex = 3;
            // 
            // tradeDetails
            // 
            this.tradeDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(209)))), ((int)(((byte)(239)))));
            this.tradeDetails.Controls.Add(this.pictureBox2);
            this.tradeDetails.Controls.Add(this.dateTimePicker_Date);
            this.tradeDetails.Controls.Add(this.text_Id);
            this.tradeDetails.Controls.Add(this.textBox_Memo);
            this.tradeDetails.Controls.Add(this.label_Memo);
            this.tradeDetails.Controls.Add(this.label_Date);
            this.tradeDetails.Controls.Add(this.label_Id);
            this.tradeDetails.Controls.Add(this.listBox_Trades);
            this.tradeDetails.Controls.Add(this.groupBox_Filter_Details);
            this.tradeDetails.Location = new System.Drawing.Point(4, 28);
            this.tradeDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tradeDetails.Name = "tradeDetails";
            this.tradeDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tradeDetails.Size = new System.Drawing.Size(1123, 417);
            this.tradeDetails.TabIndex = 0;
            this.tradeDetails.Text = "Trade Details";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClientApp.Properties.Resources.phonePortfolio;
            this.pictureBox2.Location = new System.Drawing.Point(683, 69);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(432, 294);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Checked = false;
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(392, 84);
            this.dateTimePicker_Date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(119, 24);
            this.dateTimePicker_Date.TabIndex = 8;
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(389, 46);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(23, 25);
            this.text_Id.TabIndex = 7;
            this.text_Id.Text = "0";
            // 
            // textBox_Memo
            // 
            this.textBox_Memo.Location = new System.Drawing.Point(389, 142);
            this.textBox_Memo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Memo.Multiline = true;
            this.textBox_Memo.Name = "textBox_Memo";
            this.textBox_Memo.Size = new System.Drawing.Size(287, 105);
            this.textBox_Memo.TabIndex = 5;
            // 
            // label_Memo
            // 
            this.label_Memo.AutoSize = true;
            this.label_Memo.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Memo.Location = new System.Drawing.Point(315, 140);
            this.label_Memo.Name = "label_Memo";
            this.label_Memo.Size = new System.Drawing.Size(72, 27);
            this.label_Memo.TabIndex = 4;
            this.label_Memo.Text = "Memo";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(317, 80);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(57, 27);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "Date";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(317, 44);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(31, 27);
            this.label_Id.TabIndex = 4;
            this.label_Id.Text = "Id";
            // 
            // listBox_Trades
            // 
            this.listBox_Trades.FormattingEnabled = true;
            this.listBox_Trades.ItemHeight = 19;
            this.listBox_Trades.Location = new System.Drawing.Point(19, 122);
            this.listBox_Trades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox_Trades.Name = "listBox_Trades";
            this.listBox_Trades.Size = new System.Drawing.Size(268, 232);
            this.listBox_Trades.TabIndex = 3;
            this.listBox_Trades.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox_Trades_MouseClick);
            // 
            // groupBox_Filter_Details
            // 
            this.groupBox_Filter_Details.Controls.Add(this.textBox_Filter_Id);
            this.groupBox_Filter_Details.Controls.Add(this.label_Filter_Id);
            this.groupBox_Filter_Details.Location = new System.Drawing.Point(19, 18);
            this.groupBox_Filter_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Filter_Details.Name = "groupBox_Filter_Details";
            this.groupBox_Filter_Details.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox_Filter_Details.Size = new System.Drawing.Size(268, 89);
            this.groupBox_Filter_Details.TabIndex = 2;
            this.groupBox_Filter_Details.TabStop = false;
            this.groupBox_Filter_Details.Text = "Filter";
            // 
            // textBox_Filter_Id
            // 
            this.textBox_Filter_Id.Location = new System.Drawing.Point(117, 31);
            this.textBox_Filter_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Filter_Id.Name = "textBox_Filter_Id";
            this.textBox_Filter_Id.Size = new System.Drawing.Size(100, 24);
            this.textBox_Filter_Id.TabIndex = 1;
            this.textBox_Filter_Id.TextChanged += new System.EventHandler(this.textBox_Filter_Id_TextChanged);
            this.textBox_Filter_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Filter_Id_KeyPress);
            // 
            // label_Filter_Id
            // 
            this.label_Filter_Id.AutoSize = true;
            this.label_Filter_Id.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Id.Location = new System.Drawing.Point(35, 27);
            this.label_Filter_Id.Name = "label_Filter_Id";
            this.label_Filter_Id.Size = new System.Drawing.Size(31, 27);
            this.label_Filter_Id.TabIndex = 0;
            this.label_Filter_Id.Text = "Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Clear);
            this.panel1.Location = new System.Drawing.Point(721, 465);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 79);
            this.panel1.TabIndex = 4;
            // 
            // UserTradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClientApp.Properties.Resources.bluesea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 554);
            this.Controls.Add(this.tabControl_TradeForm);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserTradeForm";
            this.Text = "UserTradeForm";
            this.tabPage_TradeCoins.ResumeLayout(false);
            this.groupBox_PriceInfo.ResumeLayout(false);
            this.groupBox_PriceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.groupBox_Coin_Filter.ResumeLayout(false);
            this.groupBox_Coin_Filter.PerformLayout();
            this.tabControl_TradeForm.ResumeLayout(false);
            this.tradeDetails.ResumeLayout(false);
            this.tradeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox_Filter_Details.ResumeLayout(false);
            this.groupBox_Filter_Details.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage_TradeCoins;
        private System.Windows.Forms.Button button_FetchCoinPrice;
        private System.Windows.Forms.GroupBox groupBox_PriceInfo;
        private System.Windows.Forms.Label label_PercentChanged;
        private System.Windows.Forms.Label text_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label text_PercentChanged;
        private System.Windows.Forms.Label text_Volume;
        private System.Windows.Forms.Label text_MarketCap;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.ListBox listBox_Chosen_Coins_Supply;
        private System.Windows.Forms.Button button_Minus_Coin;
        private System.Windows.Forms.Button button_Plus_Coin;
        private System.Windows.Forms.GroupBox groupBox_Coin_Filter;
        private System.Windows.Forms.TextBox textBox_Coin_Filter_Name;
        private System.Windows.Forms.ComboBox comboBox_Coin_Filter_Valid;
        private System.Windows.Forms.ComboBox comboBox_Coin_Filter_Scam;
        private System.Windows.Forms.Label label_Coin_Filter_Valid;
        private System.Windows.Forms.Label label_Coin_Filter_Scam;
        private System.Windows.Forms.Label label_Coin_Filter_Name;
        private System.Windows.Forms.ListBox listBox_Chosen_Coins;
        private System.Windows.Forms.ListBox listBox_Potential_Coins;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.TabControl tabControl_TradeForm;
        private System.Windows.Forms.TabPage tradeDetails;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label text_Id;
        private System.Windows.Forms.TextBox textBox_Memo;
        private System.Windows.Forms.Label label_Memo;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.ListBox listBox_Trades;
        private System.Windows.Forms.GroupBox groupBox_Filter_Details;
        private System.Windows.Forms.TextBox textBox_Filter_Id;
        private System.Windows.Forms.Label label_Filter_Id;
        private System.Windows.Forms.Panel panel1;
    }
}