namespace ClientApp.UI
{
    partial class TradeForm
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
            this.tabControl_TradeForm = new System.Windows.Forms.TabControl();
            this.tradeDetails = new System.Windows.Forms.TabPage();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.text_Id = new System.Windows.Forms.Label();
            this.text_Client = new System.Windows.Forms.Label();
            this.textBox_Memo = new System.Windows.Forms.TextBox();
            this.label_Memo = new System.Windows.Forms.Label();
            this.label_Client = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.listBox_Trades = new System.Windows.Forms.ListBox();
            this.groupBox_Filter_Details = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_Filter_To = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Filter_From = new System.Windows.Forms.DateTimePicker();
            this.textBox_Filter_Client = new System.Windows.Forms.TextBox();
            this.textBox_Filter_Id = new System.Windows.Forms.TextBox();
            this.label_Filter_To = new System.Windows.Forms.Label();
            this.label_Filter_Client = new System.Windows.Forms.Label();
            this.label_Filter_From = new System.Windows.Forms.Label();
            this.label_Filter_Id = new System.Windows.Forms.Label();
            this.tabPage_TradeClient = new System.Windows.Forms.TabPage();
            this.groupBox_ClientInfo = new System.Windows.Forms.GroupBox();
            this.text_ClientInfo_BtcAddress = new System.Windows.Forms.Label();
            this.label_ClientInfo_BtcAddress = new System.Windows.Forms.Label();
            this.label_ClientInfo_LastName = new System.Windows.Forms.Label();
            this.text_ClientInfo_LastName = new System.Windows.Forms.Label();
            this.text_ClientInfo_FirstName = new System.Windows.Forms.Label();
            this.label_ClientInfo_FirstName = new System.Windows.Forms.Label();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.groupBox_Filter_Client = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Filter_BtcAddress = new System.Windows.Forms.TextBox();
            this.textBox_Filter_LastName = new System.Windows.Forms.TextBox();
            this.tabPage_TradeCoins = new System.Windows.Forms.TabPage();
            this.listBox_Chosen_Coins = new System.Windows.Forms.ListBox();
            this.listBox_Potential_Coins = new System.Windows.Forms.ListBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.groupBox_Coin_Filter = new System.Windows.Forms.GroupBox();
            this.textBox_Coin_Filter_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Coin_Filter_Valid = new System.Windows.Forms.ComboBox();
            this.comboBox_Coin_Filter_Scam = new System.Windows.Forms.ComboBox();
            this.label_Coin_Filter_Valid = new System.Windows.Forms.Label();
            this.label_Coin_Filter_Scam = new System.Windows.Forms.Label();
            this.label_Coin_Filter_Name = new System.Windows.Forms.Label();
            this.tabControl_TradeForm.SuspendLayout();
            this.tradeDetails.SuspendLayout();
            this.groupBox_Filter_Details.SuspendLayout();
            this.tabPage_TradeClient.SuspendLayout();
            this.groupBox_ClientInfo.SuspendLayout();
            this.groupBox_Filter_Client.SuspendLayout();
            this.tabPage_TradeCoins.SuspendLayout();
            this.groupBox_Coin_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_TradeForm
            // 
            this.tabControl_TradeForm.Controls.Add(this.tradeDetails);
            this.tabControl_TradeForm.Controls.Add(this.tabPage_TradeClient);
            this.tabControl_TradeForm.Controls.Add(this.tabPage_TradeCoins);
            this.tabControl_TradeForm.Location = new System.Drawing.Point(12, 12);
            this.tabControl_TradeForm.Name = "tabControl_TradeForm";
            this.tabControl_TradeForm.SelectedIndex = 0;
            this.tabControl_TradeForm.Size = new System.Drawing.Size(816, 426);
            this.tabControl_TradeForm.TabIndex = 0;
            // 
            // tradeDetails
            // 
            this.tradeDetails.Controls.Add(this.dateTimePicker_Date);
            this.tradeDetails.Controls.Add(this.text_Id);
            this.tradeDetails.Controls.Add(this.text_Client);
            this.tradeDetails.Controls.Add(this.textBox_Memo);
            this.tradeDetails.Controls.Add(this.label_Memo);
            this.tradeDetails.Controls.Add(this.label_Client);
            this.tradeDetails.Controls.Add(this.label_Date);
            this.tradeDetails.Controls.Add(this.label_Id);
            this.tradeDetails.Controls.Add(this.listBox_Trades);
            this.tradeDetails.Controls.Add(this.groupBox_Filter_Details);
            this.tradeDetails.Location = new System.Drawing.Point(4, 25);
            this.tradeDetails.Name = "tradeDetails";
            this.tradeDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tradeDetails.Size = new System.Drawing.Size(808, 397);
            this.tradeDetails.TabIndex = 0;
            this.tradeDetails.Text = "Trade Details";
            this.tradeDetails.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Checked = false;
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(392, 82);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(118, 22);
            this.dateTimePicker_Date.TabIndex = 8;
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(390, 46);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(23, 25);
            this.text_Id.TabIndex = 7;
            this.text_Id.Text = "0";
            // 
            // text_Client
            // 
            this.text_Client.AutoSize = true;
            this.text_Client.Location = new System.Drawing.Point(404, 334);
            this.text_Client.Name = "text_Client";
            this.text_Client.Size = new System.Drawing.Size(106, 16);
            this.text_Client.TabIndex = 6;
            this.text_Client.Text = "No client chosen";
            // 
            // textBox_Memo
            // 
            this.textBox_Memo.Location = new System.Drawing.Point(392, 154);
            this.textBox_Memo.Multiline = true;
            this.textBox_Memo.Name = "textBox_Memo";
            this.textBox_Memo.Size = new System.Drawing.Size(286, 105);
            this.textBox_Memo.TabIndex = 5;
            // 
            // label_Memo
            // 
            this.label_Memo.AutoSize = true;
            this.label_Memo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Memo.Location = new System.Drawing.Point(318, 152);
            this.label_Memo.Name = "label_Memo";
            this.label_Memo.Size = new System.Drawing.Size(67, 25);
            this.label_Memo.TabIndex = 4;
            this.label_Memo.Text = "Memo";
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Client.Location = new System.Drawing.Point(318, 327);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(62, 25);
            this.label_Client.TabIndex = 4;
            this.label_Client.Text = "Client";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(318, 79);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(53, 25);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "Date";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(318, 44);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(28, 25);
            this.label_Id.TabIndex = 4;
            this.label_Id.Text = "Id";
            // 
            // listBox_Trades
            // 
            this.listBox_Trades.FormattingEnabled = true;
            this.listBox_Trades.ItemHeight = 16;
            this.listBox_Trades.Location = new System.Drawing.Point(18, 220);
            this.listBox_Trades.Name = "listBox_Trades";
            this.listBox_Trades.Size = new System.Drawing.Size(268, 164);
            this.listBox_Trades.TabIndex = 3;
            this.listBox_Trades.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_Trades_MouseDoubleClick);
            // 
            // groupBox_Filter_Details
            // 
            this.groupBox_Filter_Details.Controls.Add(this.dateTimePicker_Filter_To);
            this.groupBox_Filter_Details.Controls.Add(this.dateTimePicker_Filter_From);
            this.groupBox_Filter_Details.Controls.Add(this.textBox_Filter_Client);
            this.groupBox_Filter_Details.Controls.Add(this.textBox_Filter_Id);
            this.groupBox_Filter_Details.Controls.Add(this.label_Filter_To);
            this.groupBox_Filter_Details.Controls.Add(this.label_Filter_Client);
            this.groupBox_Filter_Details.Controls.Add(this.label_Filter_From);
            this.groupBox_Filter_Details.Controls.Add(this.label_Filter_Id);
            this.groupBox_Filter_Details.Location = new System.Drawing.Point(18, 19);
            this.groupBox_Filter_Details.Name = "groupBox_Filter_Details";
            this.groupBox_Filter_Details.Size = new System.Drawing.Size(268, 190);
            this.groupBox_Filter_Details.TabIndex = 2;
            this.groupBox_Filter_Details.TabStop = false;
            this.groupBox_Filter_Details.Text = "Filter";
            // 
            // dateTimePicker_Filter_To
            // 
            this.dateTimePicker_Filter_To.Checked = false;
            this.dateTimePicker_Filter_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Filter_To.Location = new System.Drawing.Point(117, 98);
            this.dateTimePicker_Filter_To.Name = "dateTimePicker_Filter_To";
            this.dateTimePicker_Filter_To.ShowCheckBox = true;
            this.dateTimePicker_Filter_To.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker_Filter_To.TabIndex = 3;
            // 
            // dateTimePicker_Filter_From
            // 
            this.dateTimePicker_Filter_From.Checked = false;
            this.dateTimePicker_Filter_From.CustomFormat = " d/M/yyyy";
            this.dateTimePicker_Filter_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Filter_From.Location = new System.Drawing.Point(117, 64);
            this.dateTimePicker_Filter_From.Name = "dateTimePicker_Filter_From";
            this.dateTimePicker_Filter_From.ShowCheckBox = true;
            this.dateTimePicker_Filter_From.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker_Filter_From.TabIndex = 2;
            // 
            // textBox_Filter_Client
            // 
            this.textBox_Filter_Client.Location = new System.Drawing.Point(117, 135);
            this.textBox_Filter_Client.Name = "textBox_Filter_Client";
            this.textBox_Filter_Client.Size = new System.Drawing.Size(100, 22);
            this.textBox_Filter_Client.TabIndex = 1;
            // 
            // textBox_Filter_Id
            // 
            this.textBox_Filter_Id.Location = new System.Drawing.Point(117, 31);
            this.textBox_Filter_Id.Name = "textBox_Filter_Id";
            this.textBox_Filter_Id.Size = new System.Drawing.Size(100, 22);
            this.textBox_Filter_Id.TabIndex = 1;
            // 
            // label_Filter_To
            // 
            this.label_Filter_To.AutoSize = true;
            this.label_Filter_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_To.Location = new System.Drawing.Point(34, 96);
            this.label_Filter_To.Name = "label_Filter_To";
            this.label_Filter_To.Size = new System.Drawing.Size(36, 25);
            this.label_Filter_To.TabIndex = 0;
            this.label_Filter_To.Text = "To";
            // 
            // label_Filter_Client
            // 
            this.label_Filter_Client.AutoSize = true;
            this.label_Filter_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Client.Location = new System.Drawing.Point(34, 131);
            this.label_Filter_Client.Name = "label_Filter_Client";
            this.label_Filter_Client.Size = new System.Drawing.Size(62, 25);
            this.label_Filter_Client.TabIndex = 0;
            this.label_Filter_Client.Text = "Client";
            // 
            // label_Filter_From
            // 
            this.label_Filter_From.AutoSize = true;
            this.label_Filter_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_From.Location = new System.Drawing.Point(35, 62);
            this.label_Filter_From.Name = "label_Filter_From";
            this.label_Filter_From.Size = new System.Drawing.Size(57, 25);
            this.label_Filter_From.TabIndex = 0;
            this.label_Filter_From.Text = "From";
            // 
            // label_Filter_Id
            // 
            this.label_Filter_Id.AutoSize = true;
            this.label_Filter_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Id.Location = new System.Drawing.Point(34, 27);
            this.label_Filter_Id.Name = "label_Filter_Id";
            this.label_Filter_Id.Size = new System.Drawing.Size(28, 25);
            this.label_Filter_Id.TabIndex = 0;
            this.label_Filter_Id.Text = "Id";
            // 
            // tabPage_TradeClient
            // 
            this.tabPage_TradeClient.Controls.Add(this.groupBox_ClientInfo);
            this.tabPage_TradeClient.Controls.Add(this.listBox_Clients);
            this.tabPage_TradeClient.Controls.Add(this.groupBox_Filter_Client);
            this.tabPage_TradeClient.Location = new System.Drawing.Point(4, 25);
            this.tabPage_TradeClient.Name = "tabPage_TradeClient";
            this.tabPage_TradeClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TradeClient.Size = new System.Drawing.Size(785, 397);
            this.tabPage_TradeClient.TabIndex = 1;
            this.tabPage_TradeClient.Text = "Trade Client";
            this.tabPage_TradeClient.UseVisualStyleBackColor = true;
            // 
            // groupBox_ClientInfo
            // 
            this.groupBox_ClientInfo.Controls.Add(this.text_ClientInfo_BtcAddress);
            this.groupBox_ClientInfo.Controls.Add(this.label_ClientInfo_BtcAddress);
            this.groupBox_ClientInfo.Controls.Add(this.label_ClientInfo_LastName);
            this.groupBox_ClientInfo.Controls.Add(this.text_ClientInfo_LastName);
            this.groupBox_ClientInfo.Controls.Add(this.text_ClientInfo_FirstName);
            this.groupBox_ClientInfo.Controls.Add(this.label_ClientInfo_FirstName);
            this.groupBox_ClientInfo.Location = new System.Drawing.Point(360, 273);
            this.groupBox_ClientInfo.Name = "groupBox_ClientInfo";
            this.groupBox_ClientInfo.Size = new System.Drawing.Size(402, 100);
            this.groupBox_ClientInfo.TabIndex = 11;
            this.groupBox_ClientInfo.TabStop = false;
            this.groupBox_ClientInfo.Text = "Client Info";
            // 
            // text_ClientInfo_BtcAddress
            // 
            this.text_ClientInfo_BtcAddress.AutoSize = true;
            this.text_ClientInfo_BtcAddress.Location = new System.Drawing.Point(139, 62);
            this.text_ClientInfo_BtcAddress.Name = "text_ClientInfo_BtcAddress";
            this.text_ClientInfo_BtcAddress.Size = new System.Drawing.Size(0, 16);
            this.text_ClientInfo_BtcAddress.TabIndex = 0;
            // 
            // label_ClientInfo_BtcAddress
            // 
            this.label_ClientInfo_BtcAddress.AutoSize = true;
            this.label_ClientInfo_BtcAddress.Location = new System.Drawing.Point(22, 62);
            this.label_ClientInfo_BtcAddress.Name = "label_ClientInfo_BtcAddress";
            this.label_ClientInfo_BtcAddress.Size = new System.Drawing.Size(101, 16);
            this.label_ClientInfo_BtcAddress.TabIndex = 0;
            this.label_ClientInfo_BtcAddress.Text = "Bitcoin Address";
            // 
            // label_ClientInfo_LastName
            // 
            this.label_ClientInfo_LastName.AutoSize = true;
            this.label_ClientInfo_LastName.Location = new System.Drawing.Point(211, 31);
            this.label_ClientInfo_LastName.Name = "label_ClientInfo_LastName";
            this.label_ClientInfo_LastName.Size = new System.Drawing.Size(72, 16);
            this.label_ClientInfo_LastName.TabIndex = 0;
            this.label_ClientInfo_LastName.Text = "Last Name";
            // 
            // text_ClientInfo_LastName
            // 
            this.text_ClientInfo_LastName.AutoSize = true;
            this.text_ClientInfo_LastName.Location = new System.Drawing.Point(289, 31);
            this.text_ClientInfo_LastName.Name = "text_ClientInfo_LastName";
            this.text_ClientInfo_LastName.Size = new System.Drawing.Size(0, 16);
            this.text_ClientInfo_LastName.TabIndex = 0;
            // 
            // text_ClientInfo_FirstName
            // 
            this.text_ClientInfo_FirstName.AutoSize = true;
            this.text_ClientInfo_FirstName.Location = new System.Drawing.Point(109, 31);
            this.text_ClientInfo_FirstName.Name = "text_ClientInfo_FirstName";
            this.text_ClientInfo_FirstName.Size = new System.Drawing.Size(0, 16);
            this.text_ClientInfo_FirstName.TabIndex = 0;
            // 
            // label_ClientInfo_FirstName
            // 
            this.label_ClientInfo_FirstName.AutoSize = true;
            this.label_ClientInfo_FirstName.Location = new System.Drawing.Point(22, 31);
            this.label_ClientInfo_FirstName.Name = "label_ClientInfo_FirstName";
            this.label_ClientInfo_FirstName.Size = new System.Drawing.Size(72, 16);
            this.label_ClientInfo_FirstName.TabIndex = 0;
            this.label_ClientInfo_FirstName.Text = "First Name";
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 25;
            this.listBox_Clients.Location = new System.Drawing.Point(9, 119);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(305, 254);
            this.listBox_Clients.TabIndex = 10;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Client_DoubleClick);
            // 
            // groupBox_Filter_Client
            // 
            this.groupBox_Filter_Client.Controls.Add(this.label2);
            this.groupBox_Filter_Client.Controls.Add(this.label1);
            this.groupBox_Filter_Client.Controls.Add(this.textBox_Filter_BtcAddress);
            this.groupBox_Filter_Client.Controls.Add(this.textBox_Filter_LastName);
            this.groupBox_Filter_Client.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Filter_Client.Name = "groupBox_Filter_Client";
            this.groupBox_Filter_Client.Size = new System.Drawing.Size(327, 107);
            this.groupBox_Filter_Client.TabIndex = 9;
            this.groupBox_Filter_Client.TabStop = false;
            this.groupBox_Filter_Client.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitcoin address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last name";
            // 
            // textBox_Filter_BtcAddress
            // 
            this.textBox_Filter_BtcAddress.Location = new System.Drawing.Point(128, 65);
            this.textBox_Filter_BtcAddress.Name = "textBox_Filter_BtcAddress";
            this.textBox_Filter_BtcAddress.Size = new System.Drawing.Size(180, 22);
            this.textBox_Filter_BtcAddress.TabIndex = 0;
            this.textBox_Filter_BtcAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_BtcAddress_KeyUp);
            // 
            // textBox_Filter_LastName
            // 
            this.textBox_Filter_LastName.Location = new System.Drawing.Point(128, 23);
            this.textBox_Filter_LastName.Name = "textBox_Filter_LastName";
            this.textBox_Filter_LastName.Size = new System.Drawing.Size(180, 22);
            this.textBox_Filter_LastName.TabIndex = 0;
            this.textBox_Filter_LastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_LastName_KeyUp);
            // 
            // tabPage_TradeCoins
            // 
            this.tabPage_TradeCoins.Controls.Add(this.groupBox_Coin_Filter);
            this.tabPage_TradeCoins.Controls.Add(this.listBox_Chosen_Coins);
            this.tabPage_TradeCoins.Controls.Add(this.listBox_Potential_Coins);
            this.tabPage_TradeCoins.Location = new System.Drawing.Point(4, 25);
            this.tabPage_TradeCoins.Name = "tabPage_TradeCoins";
            this.tabPage_TradeCoins.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_TradeCoins.Size = new System.Drawing.Size(808, 397);
            this.tabPage_TradeCoins.TabIndex = 2;
            this.tabPage_TradeCoins.Text = "Trade Coins";
            this.tabPage_TradeCoins.UseVisualStyleBackColor = true;
            // 
            // listBox_Chosen_Coins
            // 
            this.listBox_Chosen_Coins.FormattingEnabled = true;
            this.listBox_Chosen_Coins.ItemHeight = 16;
            this.listBox_Chosen_Coins.Location = new System.Drawing.Point(607, 13);
            this.listBox_Chosen_Coins.Name = "listBox_Chosen_Coins";
            this.listBox_Chosen_Coins.Size = new System.Drawing.Size(195, 356);
            this.listBox_Chosen_Coins.TabIndex = 0;
            // 
            // listBox_Potential_Coins
            // 
            this.listBox_Potential_Coins.FormattingEnabled = true;
            this.listBox_Potential_Coins.ItemHeight = 16;
            this.listBox_Potential_Coins.Location = new System.Drawing.Point(390, 13);
            this.listBox_Potential_Coins.Name = "listBox_Potential_Coins";
            this.listBox_Potential_Coins.Size = new System.Drawing.Size(211, 356);
            this.listBox_Potential_Coins.TabIndex = 0;
            this.listBox_Potential_Coins.DoubleClick += new System.EventHandler(this.listBox_Potential_Coins_DoubleClick);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(657, 463);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(753, 463);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // groupBox_Coin_Filter
            // 
            this.groupBox_Coin_Filter.Controls.Add(this.textBox_Coin_Filter_Name);
            this.groupBox_Coin_Filter.Controls.Add(this.comboBox_Coin_Filter_Valid);
            this.groupBox_Coin_Filter.Controls.Add(this.comboBox_Coin_Filter_Scam);
            this.groupBox_Coin_Filter.Controls.Add(this.label_Coin_Filter_Valid);
            this.groupBox_Coin_Filter.Controls.Add(this.label_Coin_Filter_Scam);
            this.groupBox_Coin_Filter.Controls.Add(this.label_Coin_Filter_Name);
            this.groupBox_Coin_Filter.Location = new System.Drawing.Point(7, 13);
            this.groupBox_Coin_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Coin_Filter.Name = "groupBox_Coin_Filter";
            this.groupBox_Coin_Filter.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Coin_Filter.Size = new System.Drawing.Size(364, 160);
            this.groupBox_Coin_Filter.TabIndex = 2;
            this.groupBox_Coin_Filter.TabStop = false;
            this.groupBox_Coin_Filter.Text = "Coin Filter";
            // 
            // textBox_Coin_Filter_Name
            // 
            this.textBox_Coin_Filter_Name.Location = new System.Drawing.Point(188, 38);
            this.textBox_Coin_Filter_Name.Name = "textBox_Coin_Filter_Name";
            this.textBox_Coin_Filter_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Coin_Filter_Name.TabIndex = 2;
            this.textBox_Coin_Filter_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Coin_Filter_Name_KeyUp);
            // 
            // comboBox_Coin_Filter_Valid
            // 
            this.comboBox_Coin_Filter_Valid.FormattingEnabled = true;
            this.comboBox_Coin_Filter_Valid.Location = new System.Drawing.Point(188, 71);
            this.comboBox_Coin_Filter_Valid.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Coin_Filter_Valid.Name = "comboBox_Coin_Filter_Valid";
            this.comboBox_Coin_Filter_Valid.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Coin_Filter_Valid.TabIndex = 0;
            this.comboBox_Coin_Filter_Valid.SelectedIndexChanged += new System.EventHandler(this.comboBox_Coin_Filter_Valid_SelectedIndexChanged);
            // 
            // comboBox_Coin_Filter_Scam
            // 
            this.comboBox_Coin_Filter_Scam.FormattingEnabled = true;
            this.comboBox_Coin_Filter_Scam.Location = new System.Drawing.Point(188, 112);
            this.comboBox_Coin_Filter_Scam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Coin_Filter_Scam.Name = "comboBox_Coin_Filter_Scam";
            this.comboBox_Coin_Filter_Scam.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Coin_Filter_Scam.TabIndex = 0;
            this.comboBox_Coin_Filter_Scam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Coin_Filter_Scam_SelectedIndexChanged);
            // 
            // label_Coin_Filter_Valid
            // 
            this.label_Coin_Filter_Valid.AutoSize = true;
            this.label_Coin_Filter_Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coin_Filter_Valid.Location = new System.Drawing.Point(8, 73);
            this.label_Coin_Filter_Valid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Coin_Filter_Valid.Name = "label_Coin_Filter_Valid";
            this.label_Coin_Filter_Valid.Size = new System.Drawing.Size(165, 25);
            this.label_Coin_Filter_Valid.TabIndex = 0;
            this.label_Coin_Filter_Valid.Text = "Validation system";
            // 
            // label_Coin_Filter_Scam
            // 
            this.label_Coin_Filter_Scam.AutoSize = true;
            this.label_Coin_Filter_Scam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coin_Filter_Scam.Location = new System.Drawing.Point(8, 117);
            this.label_Coin_Filter_Scam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Coin_Filter_Scam.Name = "label_Coin_Filter_Scam";
            this.label_Coin_Filter_Scam.Size = new System.Drawing.Size(115, 25);
            this.label_Coin_Filter_Scam.TabIndex = 0;
            this.label_Coin_Filter_Scam.Text = "Scam Level";
            // 
            // label_Coin_Filter_Name
            // 
            this.label_Coin_Filter_Name.AutoSize = true;
            this.label_Coin_Filter_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coin_Filter_Name.Location = new System.Drawing.Point(8, 38);
            this.label_Coin_Filter_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Coin_Filter_Name.Name = "label_Coin_Filter_Name";
            this.label_Coin_Filter_Name.Size = new System.Drawing.Size(64, 25);
            this.label_Coin_Filter_Name.TabIndex = 0;
            this.label_Coin_Filter_Name.Text = "Name";
            // 
            // TradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 498);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.tabControl_TradeForm);
            this.Name = "TradeForm";
            this.Text = "Order";
            this.tabControl_TradeForm.ResumeLayout(false);
            this.tradeDetails.ResumeLayout(false);
            this.tradeDetails.PerformLayout();
            this.groupBox_Filter_Details.ResumeLayout(false);
            this.groupBox_Filter_Details.PerformLayout();
            this.tabPage_TradeClient.ResumeLayout(false);
            this.groupBox_ClientInfo.ResumeLayout(false);
            this.groupBox_ClientInfo.PerformLayout();
            this.groupBox_Filter_Client.ResumeLayout(false);
            this.groupBox_Filter_Client.PerformLayout();
            this.tabPage_TradeCoins.ResumeLayout(false);
            this.groupBox_Coin_Filter.ResumeLayout(false);
            this.groupBox_Coin_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_TradeForm;
        private System.Windows.Forms.TabPage tradeDetails;
        private System.Windows.Forms.TabPage tabPage_TradeClient;
        private System.Windows.Forms.TabPage tabPage_TradeCoins;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label text_Id;
        private System.Windows.Forms.Label text_Client;
        private System.Windows.Forms.TextBox textBox_Memo;
        private System.Windows.Forms.Label label_Memo;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.ListBox listBox_Trades;
        private System.Windows.Forms.GroupBox groupBox_Filter_Details;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Filter_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Filter_From;
        private System.Windows.Forms.TextBox textBox_Filter_Client;
        private System.Windows.Forms.TextBox textBox_Filter_Id;
        private System.Windows.Forms.Label label_Filter_To;
        private System.Windows.Forms.Label label_Filter_Client;
        private System.Windows.Forms.Label label_Filter_From;
        private System.Windows.Forms.Label label_Filter_Id;
        private System.Windows.Forms.GroupBox groupBox_Filter_Client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Filter_BtcAddress;
        private System.Windows.Forms.TextBox textBox_Filter_LastName;
        private System.Windows.Forms.GroupBox groupBox_ClientInfo;
        private System.Windows.Forms.Label label_ClientInfo_BtcAddress;
        private System.Windows.Forms.Label text_ClientInfo_LastName;
        private System.Windows.Forms.Label text_ClientInfo_FirstName;
        private System.Windows.Forms.Label label_ClientInfo_FirstName;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label text_ClientInfo_BtcAddress;
        private System.Windows.Forms.Label label_ClientInfo_LastName;
        private System.Windows.Forms.ListBox listBox_Potential_Coins;
        private System.Windows.Forms.ListBox listBox_Chosen_Coins;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.GroupBox groupBox_Coin_Filter;
        private System.Windows.Forms.TextBox textBox_Coin_Filter_Name;
        private System.Windows.Forms.ComboBox comboBox_Coin_Filter_Valid;
        private System.Windows.Forms.ComboBox comboBox_Coin_Filter_Scam;
        private System.Windows.Forms.Label label_Coin_Filter_Valid;
        private System.Windows.Forms.Label label_Coin_Filter_Scam;
        private System.Windows.Forms.Label label_Coin_Filter_Name;
    }
}