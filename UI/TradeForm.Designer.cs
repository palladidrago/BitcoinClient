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
            this.label_ClientInfo_Username = new System.Windows.Forms.Label();
            this.label_ClientInfo_LastName = new System.Windows.Forms.Label();
            this.text_ClientInfo_Username = new System.Windows.Forms.Label();
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
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Delete = new System.Windows.Forms.Button();
            this.tabControl_TradeForm.SuspendLayout();
            this.tradeDetails.SuspendLayout();
            this.groupBox_Filter_Details.SuspendLayout();
            this.tabPage_TradeClient.SuspendLayout();
            this.groupBox_ClientInfo.SuspendLayout();
            this.groupBox_Filter_Client.SuspendLayout();
            this.tabPage_TradeCoins.SuspendLayout();
            this.groupBox_Coin_Filter.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_TradeForm
            // 
            this.tabControl_TradeForm.Controls.Add(this.tradeDetails);
            this.tabControl_TradeForm.Controls.Add(this.tabPage_TradeClient);
            this.tabControl_TradeForm.Controls.Add(this.tabPage_TradeCoins);
            this.tabControl_TradeForm.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_TradeForm.Location = new System.Drawing.Point(1, 0);
            this.tabControl_TradeForm.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_TradeForm.Name = "tabControl_TradeForm";
            this.tabControl_TradeForm.SelectedIndex = 0;
            this.tabControl_TradeForm.Size = new System.Drawing.Size(752, 346);
            this.tabControl_TradeForm.TabIndex = 0;
            // 
            // tradeDetails
            // 
            this.tradeDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
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
            this.tradeDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tradeDetails.Name = "tradeDetails";
            this.tradeDetails.Padding = new System.Windows.Forms.Padding(2);
            this.tradeDetails.Size = new System.Drawing.Size(744, 317);
            this.tradeDetails.TabIndex = 0;
            this.tradeDetails.Text = "Trade Details";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Checked = false;
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(294, 67);
            this.dateTimePicker_Date.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(90, 21);
            this.dateTimePicker_Date.TabIndex = 8;
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(292, 37);
            this.text_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(18, 20);
            this.text_Id.TabIndex = 7;
            this.text_Id.Text = "0";
            // 
            // text_Client
            // 
            this.text_Client.AutoSize = true;
            this.text_Client.Location = new System.Drawing.Point(303, 271);
            this.text_Client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_Client.Name = "text_Client";
            this.text_Client.Size = new System.Drawing.Size(96, 16);
            this.text_Client.TabIndex = 6;
            this.text_Client.Text = "No client chosen";
            // 
            // textBox_Memo
            // 
            this.textBox_Memo.Location = new System.Drawing.Point(294, 125);
            this.textBox_Memo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Memo.Multiline = true;
            this.textBox_Memo.Name = "textBox_Memo";
            this.textBox_Memo.Size = new System.Drawing.Size(216, 86);
            this.textBox_Memo.TabIndex = 5;
            // 
            // label_Memo
            // 
            this.label_Memo.AutoSize = true;
            this.label_Memo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Memo.Location = new System.Drawing.Point(238, 124);
            this.label_Memo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Memo.Name = "label_Memo";
            this.label_Memo.Size = new System.Drawing.Size(53, 20);
            this.label_Memo.TabIndex = 4;
            this.label_Memo.Text = "Memo";
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Client.Location = new System.Drawing.Point(238, 266);
            this.label_Client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(49, 20);
            this.label_Client.TabIndex = 4;
            this.label_Client.Text = "Client";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date.Location = new System.Drawing.Point(238, 64);
            this.label_Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(44, 20);
            this.label_Date.TabIndex = 4;
            this.label_Date.Text = "Date";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(238, 36);
            this.label_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(23, 20);
            this.label_Id.TabIndex = 4;
            this.label_Id.Text = "Id";
            // 
            // listBox_Trades
            // 
            this.listBox_Trades.FormattingEnabled = true;
            this.listBox_Trades.ItemHeight = 16;
            this.listBox_Trades.Location = new System.Drawing.Point(14, 179);
            this.listBox_Trades.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Trades.Name = "listBox_Trades";
            this.listBox_Trades.Size = new System.Drawing.Size(202, 132);
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
            this.groupBox_Filter_Details.Location = new System.Drawing.Point(14, 15);
            this.groupBox_Filter_Details.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Filter_Details.Name = "groupBox_Filter_Details";
            this.groupBox_Filter_Details.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Filter_Details.Size = new System.Drawing.Size(201, 154);
            this.groupBox_Filter_Details.TabIndex = 2;
            this.groupBox_Filter_Details.TabStop = false;
            this.groupBox_Filter_Details.Text = "Filter";
            // 
            // dateTimePicker_Filter_To
            // 
            this.dateTimePicker_Filter_To.Checked = false;
            this.dateTimePicker_Filter_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Filter_To.Location = new System.Drawing.Point(88, 80);
            this.dateTimePicker_Filter_To.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_Filter_To.Name = "dateTimePicker_Filter_To";
            this.dateTimePicker_Filter_To.ShowCheckBox = true;
            this.dateTimePicker_Filter_To.Size = new System.Drawing.Size(101, 21);
            this.dateTimePicker_Filter_To.TabIndex = 3;
            // 
            // dateTimePicker_Filter_From
            // 
            this.dateTimePicker_Filter_From.Checked = false;
            this.dateTimePicker_Filter_From.CustomFormat = " d/M/yyyy";
            this.dateTimePicker_Filter_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Filter_From.Location = new System.Drawing.Point(88, 52);
            this.dateTimePicker_Filter_From.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_Filter_From.Name = "dateTimePicker_Filter_From";
            this.dateTimePicker_Filter_From.ShowCheckBox = true;
            this.dateTimePicker_Filter_From.Size = new System.Drawing.Size(101, 21);
            this.dateTimePicker_Filter_From.TabIndex = 2;
            // 
            // textBox_Filter_Client
            // 
            this.textBox_Filter_Client.Location = new System.Drawing.Point(88, 110);
            this.textBox_Filter_Client.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Filter_Client.Name = "textBox_Filter_Client";
            this.textBox_Filter_Client.Size = new System.Drawing.Size(76, 21);
            this.textBox_Filter_Client.TabIndex = 1;
            // 
            // textBox_Filter_Id
            // 
            this.textBox_Filter_Id.Location = new System.Drawing.Point(88, 25);
            this.textBox_Filter_Id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Filter_Id.Name = "textBox_Filter_Id";
            this.textBox_Filter_Id.Size = new System.Drawing.Size(76, 21);
            this.textBox_Filter_Id.TabIndex = 1;
            // 
            // label_Filter_To
            // 
            this.label_Filter_To.AutoSize = true;
            this.label_Filter_To.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_To.Location = new System.Drawing.Point(26, 78);
            this.label_Filter_To.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Filter_To.Name = "label_Filter_To";
            this.label_Filter_To.Size = new System.Drawing.Size(30, 22);
            this.label_Filter_To.TabIndex = 0;
            this.label_Filter_To.Text = "To";
            // 
            // label_Filter_Client
            // 
            this.label_Filter_Client.AutoSize = true;
            this.label_Filter_Client.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Client.Location = new System.Drawing.Point(26, 106);
            this.label_Filter_Client.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Filter_Client.Name = "label_Filter_Client";
            this.label_Filter_Client.Size = new System.Drawing.Size(57, 22);
            this.label_Filter_Client.TabIndex = 0;
            this.label_Filter_Client.Text = "Client";
            // 
            // label_Filter_From
            // 
            this.label_Filter_From.AutoSize = true;
            this.label_Filter_From.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_From.Location = new System.Drawing.Point(26, 50);
            this.label_Filter_From.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Filter_From.Name = "label_Filter_From";
            this.label_Filter_From.Size = new System.Drawing.Size(51, 22);
            this.label_Filter_From.TabIndex = 0;
            this.label_Filter_From.Text = "From";
            // 
            // label_Filter_Id
            // 
            this.label_Filter_Id.AutoSize = true;
            this.label_Filter_Id.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Id.Location = new System.Drawing.Point(26, 22);
            this.label_Filter_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Filter_Id.Name = "label_Filter_Id";
            this.label_Filter_Id.Size = new System.Drawing.Size(25, 22);
            this.label_Filter_Id.TabIndex = 0;
            this.label_Filter_Id.Text = "Id";
            // 
            // tabPage_TradeClient
            // 
            this.tabPage_TradeClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.tabPage_TradeClient.Controls.Add(this.groupBox_ClientInfo);
            this.tabPage_TradeClient.Controls.Add(this.listBox_Clients);
            this.tabPage_TradeClient.Controls.Add(this.groupBox_Filter_Client);
            this.tabPage_TradeClient.Location = new System.Drawing.Point(4, 25);
            this.tabPage_TradeClient.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_TradeClient.Name = "tabPage_TradeClient";
            this.tabPage_TradeClient.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_TradeClient.Size = new System.Drawing.Size(744, 317);
            this.tabPage_TradeClient.TabIndex = 1;
            this.tabPage_TradeClient.Text = "Trade Client";
            // 
            // groupBox_ClientInfo
            // 
            this.groupBox_ClientInfo.BackColor = System.Drawing.Color.Silver;
            this.groupBox_ClientInfo.Controls.Add(this.text_ClientInfo_BtcAddress);
            this.groupBox_ClientInfo.Controls.Add(this.label_ClientInfo_BtcAddress);
            this.groupBox_ClientInfo.Controls.Add(this.label_ClientInfo_Username);
            this.groupBox_ClientInfo.Controls.Add(this.label_ClientInfo_LastName);
            this.groupBox_ClientInfo.Controls.Add(this.text_ClientInfo_Username);
            this.groupBox_ClientInfo.Controls.Add(this.text_ClientInfo_LastName);
            this.groupBox_ClientInfo.Controls.Add(this.text_ClientInfo_FirstName);
            this.groupBox_ClientInfo.Controls.Add(this.label_ClientInfo_FirstName);
            this.groupBox_ClientInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ClientInfo.Location = new System.Drawing.Point(241, 220);
            this.groupBox_ClientInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_ClientInfo.Name = "groupBox_ClientInfo";
            this.groupBox_ClientInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_ClientInfo.Size = new System.Drawing.Size(319, 81);
            this.groupBox_ClientInfo.TabIndex = 11;
            this.groupBox_ClientInfo.TabStop = false;
            this.groupBox_ClientInfo.Text = "Client Info";
            // 
            // text_ClientInfo_BtcAddress
            // 
            this.text_ClientInfo_BtcAddress.AutoSize = true;
            this.text_ClientInfo_BtcAddress.BackColor = System.Drawing.Color.Transparent;
            this.text_ClientInfo_BtcAddress.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ClientInfo_BtcAddress.ForeColor = System.Drawing.Color.Black;
            this.text_ClientInfo_BtcAddress.Location = new System.Drawing.Point(104, 50);
            this.text_ClientInfo_BtcAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_ClientInfo_BtcAddress.Name = "text_ClientInfo_BtcAddress";
            this.text_ClientInfo_BtcAddress.Size = new System.Drawing.Size(0, 22);
            this.text_ClientInfo_BtcAddress.TabIndex = 0;
            // 
            // label_ClientInfo_BtcAddress
            // 
            this.label_ClientInfo_BtcAddress.AutoSize = true;
            this.label_ClientInfo_BtcAddress.BackColor = System.Drawing.Color.Transparent;
            this.label_ClientInfo_BtcAddress.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientInfo_BtcAddress.ForeColor = System.Drawing.Color.Black;
            this.label_ClientInfo_BtcAddress.Location = new System.Drawing.Point(16, 50);
            this.label_ClientInfo_BtcAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ClientInfo_BtcAddress.Name = "label_ClientInfo_BtcAddress";
            this.label_ClientInfo_BtcAddress.Size = new System.Drawing.Size(87, 22);
            this.label_ClientInfo_BtcAddress.TabIndex = 0;
            this.label_ClientInfo_BtcAddress.Text = "Bitcoin Address";
            // 
            // label_ClientInfo_Username
            // 
            this.label_ClientInfo_Username.AutoSize = true;
            this.label_ClientInfo_Username.BackColor = System.Drawing.Color.Transparent;
            this.label_ClientInfo_Username.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientInfo_Username.ForeColor = System.Drawing.Color.Black;
            this.label_ClientInfo_Username.Location = new System.Drawing.Point(158, 50);
            this.label_ClientInfo_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ClientInfo_Username.Name = "label_ClientInfo_Username";
            this.label_ClientInfo_Username.Size = new System.Drawing.Size(59, 22);
            this.label_ClientInfo_Username.TabIndex = 0;
            this.label_ClientInfo_Username.Text = "Username";
            // 
            // label_ClientInfo_LastName
            // 
            this.label_ClientInfo_LastName.AutoSize = true;
            this.label_ClientInfo_LastName.BackColor = System.Drawing.Color.Transparent;
            this.label_ClientInfo_LastName.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientInfo_LastName.ForeColor = System.Drawing.Color.Black;
            this.label_ClientInfo_LastName.Location = new System.Drawing.Point(158, 25);
            this.label_ClientInfo_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ClientInfo_LastName.Name = "label_ClientInfo_LastName";
            this.label_ClientInfo_LastName.Size = new System.Drawing.Size(63, 22);
            this.label_ClientInfo_LastName.TabIndex = 0;
            this.label_ClientInfo_LastName.Text = "Last Name";
            // 
            // text_ClientInfo_Username
            // 
            this.text_ClientInfo_Username.AutoSize = true;
            this.text_ClientInfo_Username.BackColor = System.Drawing.Color.Transparent;
            this.text_ClientInfo_Username.ForeColor = System.Drawing.Color.Black;
            this.text_ClientInfo_Username.Location = new System.Drawing.Point(228, 55);
            this.text_ClientInfo_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_ClientInfo_Username.Name = "text_ClientInfo_Username";
            this.text_ClientInfo_Username.Size = new System.Drawing.Size(0, 17);
            this.text_ClientInfo_Username.TabIndex = 0;
            // 
            // text_ClientInfo_LastName
            // 
            this.text_ClientInfo_LastName.AutoSize = true;
            this.text_ClientInfo_LastName.BackColor = System.Drawing.Color.Transparent;
            this.text_ClientInfo_LastName.ForeColor = System.Drawing.Color.Black;
            this.text_ClientInfo_LastName.Location = new System.Drawing.Point(228, 30);
            this.text_ClientInfo_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_ClientInfo_LastName.Name = "text_ClientInfo_LastName";
            this.text_ClientInfo_LastName.Size = new System.Drawing.Size(0, 17);
            this.text_ClientInfo_LastName.TabIndex = 0;
            // 
            // text_ClientInfo_FirstName
            // 
            this.text_ClientInfo_FirstName.AutoSize = true;
            this.text_ClientInfo_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.text_ClientInfo_FirstName.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_ClientInfo_FirstName.ForeColor = System.Drawing.Color.Black;
            this.text_ClientInfo_FirstName.Location = new System.Drawing.Point(82, 25);
            this.text_ClientInfo_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_ClientInfo_FirstName.Name = "text_ClientInfo_FirstName";
            this.text_ClientInfo_FirstName.Size = new System.Drawing.Size(0, 22);
            this.text_ClientInfo_FirstName.TabIndex = 0;
            // 
            // label_ClientInfo_FirstName
            // 
            this.label_ClientInfo_FirstName.AutoSize = true;
            this.label_ClientInfo_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.label_ClientInfo_FirstName.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ClientInfo_FirstName.ForeColor = System.Drawing.Color.Black;
            this.label_ClientInfo_FirstName.Location = new System.Drawing.Point(16, 25);
            this.label_ClientInfo_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ClientInfo_FirstName.Name = "label_ClientInfo_FirstName";
            this.label_ClientInfo_FirstName.Size = new System.Drawing.Size(64, 22);
            this.label_ClientInfo_FirstName.TabIndex = 0;
            this.label_ClientInfo_FirstName.Text = "First Name";
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 20;
            this.listBox_Clients.Location = new System.Drawing.Point(7, 97);
            this.listBox_Clients.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(230, 204);
            this.listBox_Clients.TabIndex = 10;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Client_DoubleClick);
            // 
            // groupBox_Filter_Client
            // 
            this.groupBox_Filter_Client.BackColor = System.Drawing.Color.Silver;
            this.groupBox_Filter_Client.Controls.Add(this.label2);
            this.groupBox_Filter_Client.Controls.Add(this.label1);
            this.groupBox_Filter_Client.Controls.Add(this.textBox_Filter_BtcAddress);
            this.groupBox_Filter_Client.Controls.Add(this.textBox_Filter_LastName);
            this.groupBox_Filter_Client.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Filter_Client.Location = new System.Drawing.Point(4, 5);
            this.groupBox_Filter_Client.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Filter_Client.Name = "groupBox_Filter_Client";
            this.groupBox_Filter_Client.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Filter_Client.Size = new System.Drawing.Size(255, 87);
            this.groupBox_Filter_Client.TabIndex = 9;
            this.groupBox_Filter_Client.TabStop = false;
            this.groupBox_Filter_Client.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitcoin address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell Nova", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last name";
            // 
            // textBox_Filter_BtcAddress
            // 
            this.textBox_Filter_BtcAddress.Location = new System.Drawing.Point(105, 52);
            this.textBox_Filter_BtcAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Filter_BtcAddress.Name = "textBox_Filter_BtcAddress";
            this.textBox_Filter_BtcAddress.Size = new System.Drawing.Size(136, 23);
            this.textBox_Filter_BtcAddress.TabIndex = 0;
            this.textBox_Filter_BtcAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_BtcAddress_KeyUp);
            // 
            // textBox_Filter_LastName
            // 
            this.textBox_Filter_LastName.Location = new System.Drawing.Point(105, 20);
            this.textBox_Filter_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Filter_LastName.Name = "textBox_Filter_LastName";
            this.textBox_Filter_LastName.Size = new System.Drawing.Size(136, 23);
            this.textBox_Filter_LastName.TabIndex = 0;
            this.textBox_Filter_LastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_LastName_KeyUp);
            // 
            // tabPage_TradeCoins
            // 
            this.tabPage_TradeCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.tabPage_TradeCoins.Controls.Add(this.listBox_Chosen_Coins_Supply);
            this.tabPage_TradeCoins.Controls.Add(this.button_Minus_Coin);
            this.tabPage_TradeCoins.Controls.Add(this.button_Plus_Coin);
            this.tabPage_TradeCoins.Controls.Add(this.groupBox_Coin_Filter);
            this.tabPage_TradeCoins.Controls.Add(this.listBox_Chosen_Coins);
            this.tabPage_TradeCoins.Controls.Add(this.listBox_Potential_Coins);
            this.tabPage_TradeCoins.Location = new System.Drawing.Point(4, 25);
            this.tabPage_TradeCoins.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_TradeCoins.Name = "tabPage_TradeCoins";
            this.tabPage_TradeCoins.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_TradeCoins.Size = new System.Drawing.Size(744, 317);
            this.tabPage_TradeCoins.TabIndex = 2;
            this.tabPage_TradeCoins.Text = "Trade Coins";
            // 
            // listBox_Chosen_Coins_Supply
            // 
            this.listBox_Chosen_Coins_Supply.FormattingEnabled = true;
            this.listBox_Chosen_Coins_Supply.ItemHeight = 16;
            this.listBox_Chosen_Coins_Supply.Location = new System.Drawing.Point(598, 12);
            this.listBox_Chosen_Coins_Supply.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Chosen_Coins_Supply.Name = "listBox_Chosen_Coins_Supply";
            this.listBox_Chosen_Coins_Supply.Size = new System.Drawing.Size(86, 276);
            this.listBox_Chosen_Coins_Supply.TabIndex = 4;
            this.listBox_Chosen_Coins_Supply.SelectedIndexChanged += new System.EventHandler(this.listBox_Chosen_Coins_Supply_SelectedIndexChanged);
            // 
            // button_Minus_Coin
            // 
            this.button_Minus_Coin.BackColor = System.Drawing.Color.Red;
            this.button_Minus_Coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minus_Coin.Location = new System.Drawing.Point(688, 161);
            this.button_Minus_Coin.Margin = new System.Windows.Forms.Padding(2);
            this.button_Minus_Coin.Name = "button_Minus_Coin";
            this.button_Minus_Coin.Size = new System.Drawing.Size(54, 141);
            this.button_Minus_Coin.TabIndex = 3;
            this.button_Minus_Coin.Text = "-";
            this.button_Minus_Coin.UseVisualStyleBackColor = false;
            this.button_Minus_Coin.Click += new System.EventHandler(this.button_Minus_Coin_Click);
            // 
            // button_Plus_Coin
            // 
            this.button_Plus_Coin.BackColor = System.Drawing.Color.LawnGreen;
            this.button_Plus_Coin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Plus_Coin.Location = new System.Drawing.Point(688, 12);
            this.button_Plus_Coin.Margin = new System.Windows.Forms.Padding(2);
            this.button_Plus_Coin.Name = "button_Plus_Coin";
            this.button_Plus_Coin.Size = new System.Drawing.Size(54, 130);
            this.button_Plus_Coin.TabIndex = 3;
            this.button_Plus_Coin.Text = "+";
            this.button_Plus_Coin.UseVisualStyleBackColor = false;
            this.button_Plus_Coin.Click += new System.EventHandler(this.button_Plus_Coin_Click);
            // 
            // groupBox_Coin_Filter
            // 
            this.groupBox_Coin_Filter.BackColor = System.Drawing.Color.Silver;
            this.groupBox_Coin_Filter.Controls.Add(this.textBox_Coin_Filter_Name);
            this.groupBox_Coin_Filter.Controls.Add(this.comboBox_Coin_Filter_Valid);
            this.groupBox_Coin_Filter.Controls.Add(this.comboBox_Coin_Filter_Scam);
            this.groupBox_Coin_Filter.Controls.Add(this.label_Coin_Filter_Valid);
            this.groupBox_Coin_Filter.Controls.Add(this.label_Coin_Filter_Scam);
            this.groupBox_Coin_Filter.Controls.Add(this.label_Coin_Filter_Name);
            this.groupBox_Coin_Filter.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Coin_Filter.Location = new System.Drawing.Point(5, 11);
            this.groupBox_Coin_Filter.Name = "groupBox_Coin_Filter";
            this.groupBox_Coin_Filter.Size = new System.Drawing.Size(273, 130);
            this.groupBox_Coin_Filter.TabIndex = 2;
            this.groupBox_Coin_Filter.TabStop = false;
            this.groupBox_Coin_Filter.Text = "Coin Filter";
            // 
            // textBox_Coin_Filter_Name
            // 
            this.textBox_Coin_Filter_Name.Location = new System.Drawing.Point(141, 31);
            this.textBox_Coin_Filter_Name.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Coin_Filter_Name.Name = "textBox_Coin_Filter_Name";
            this.textBox_Coin_Filter_Name.Size = new System.Drawing.Size(76, 20);
            this.textBox_Coin_Filter_Name.TabIndex = 2;
            this.textBox_Coin_Filter_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Coin_Filter_Name_KeyUp);
            // 
            // comboBox_Coin_Filter_Valid
            // 
            this.comboBox_Coin_Filter_Valid.FormattingEnabled = true;
            this.comboBox_Coin_Filter_Valid.Location = new System.Drawing.Point(141, 58);
            this.comboBox_Coin_Filter_Valid.Name = "comboBox_Coin_Filter_Valid";
            this.comboBox_Coin_Filter_Valid.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Coin_Filter_Valid.TabIndex = 0;
            this.comboBox_Coin_Filter_Valid.SelectedIndexChanged += new System.EventHandler(this.comboBox_Coin_Filter_Valid_SelectedIndexChanged);
            // 
            // comboBox_Coin_Filter_Scam
            // 
            this.comboBox_Coin_Filter_Scam.FormattingEnabled = true;
            this.comboBox_Coin_Filter_Scam.Location = new System.Drawing.Point(141, 91);
            this.comboBox_Coin_Filter_Scam.Name = "comboBox_Coin_Filter_Scam";
            this.comboBox_Coin_Filter_Scam.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Coin_Filter_Scam.TabIndex = 0;
            this.comboBox_Coin_Filter_Scam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Coin_Filter_Scam_SelectedIndexChanged);
            // 
            // label_Coin_Filter_Valid
            // 
            this.label_Coin_Filter_Valid.AutoSize = true;
            this.label_Coin_Filter_Valid.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coin_Filter_Valid.Location = new System.Drawing.Point(6, 59);
            this.label_Coin_Filter_Valid.Name = "label_Coin_Filter_Valid";
            this.label_Coin_Filter_Valid.Size = new System.Drawing.Size(135, 20);
            this.label_Coin_Filter_Valid.TabIndex = 0;
            this.label_Coin_Filter_Valid.Text = "Validation system";
            // 
            // label_Coin_Filter_Scam
            // 
            this.label_Coin_Filter_Scam.AutoSize = true;
            this.label_Coin_Filter_Scam.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coin_Filter_Scam.Location = new System.Drawing.Point(6, 93);
            this.label_Coin_Filter_Scam.Name = "label_Coin_Filter_Scam";
            this.label_Coin_Filter_Scam.Size = new System.Drawing.Size(93, 20);
            this.label_Coin_Filter_Scam.TabIndex = 0;
            this.label_Coin_Filter_Scam.Text = "Scam Level";
            // 
            // label_Coin_Filter_Name
            // 
            this.label_Coin_Filter_Name.AutoSize = true;
            this.label_Coin_Filter_Name.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Coin_Filter_Name.Location = new System.Drawing.Point(6, 31);
            this.label_Coin_Filter_Name.Name = "label_Coin_Filter_Name";
            this.label_Coin_Filter_Name.Size = new System.Drawing.Size(53, 20);
            this.label_Coin_Filter_Name.TabIndex = 0;
            this.label_Coin_Filter_Name.Text = "Name";
            // 
            // listBox_Chosen_Coins
            // 
            this.listBox_Chosen_Coins.FormattingEnabled = true;
            this.listBox_Chosen_Coins.ItemHeight = 16;
            this.listBox_Chosen_Coins.Location = new System.Drawing.Point(446, 11);
            this.listBox_Chosen_Coins.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Chosen_Coins.Name = "listBox_Chosen_Coins";
            this.listBox_Chosen_Coins.Size = new System.Drawing.Size(147, 276);
            this.listBox_Chosen_Coins.TabIndex = 0;
            this.listBox_Chosen_Coins.SelectedIndexChanged += new System.EventHandler(this.listBox_Chosen_Coins_SelectedIndexChanged);
            // 
            // listBox_Potential_Coins
            // 
            this.listBox_Potential_Coins.FormattingEnabled = true;
            this.listBox_Potential_Coins.ItemHeight = 16;
            this.listBox_Potential_Coins.Location = new System.Drawing.Point(284, 11);
            this.listBox_Potential_Coins.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Potential_Coins.Name = "listBox_Potential_Coins";
            this.listBox_Potential_Coins.Size = new System.Drawing.Size(159, 276);
            this.listBox_Potential_Coins.TabIndex = 0;
            this.listBox_Potential_Coins.DoubleClick += new System.EventHandler(this.listBox_Potential_Coins_DoubleClick);
            // 
            // button_Clear
            // 
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(2, 17);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(68, 32);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Lime;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(74, 17);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(70, 32);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.button_Delete);
            this.panel1.Controls.Add(this.button_Clear);
            this.panel1.Location = new System.Drawing.Point(525, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 64);
            this.panel1.TabIndex = 2;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Crimson;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(148, 17);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(70, 32);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // TradeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ClientApp.Properties.Resources.lemonspattern;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 411);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl_TradeForm);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox listBox_Chosen_Coins_Supply;
        private System.Windows.Forms.Button button_Minus_Coin;
        private System.Windows.Forms.Button button_Plus_Coin;
        private System.Windows.Forms.Label label_ClientInfo_Username;
        private System.Windows.Forms.Label text_ClientInfo_Username;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Panel panel1;
    }
}