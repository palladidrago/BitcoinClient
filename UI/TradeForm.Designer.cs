namespace ClientApp.UI
{
    partial class Trade
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
            this.O = new System.Windows.Forms.TabControl();
            this.tradeDetails = new System.Windows.Forms.TabPage();
            this.tradeClient = new System.Windows.Forms.TabPage();
            this.tradeCoins_TabControl = new System.Windows.Forms.TabPage();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.label_Filter_Id = new System.Windows.Forms.Label();
            this.label_Filter_From = new System.Windows.Forms.Label();
            this.label_Filter_Client = new System.Windows.Forms.Label();
            this.label_Filter_To = new System.Windows.Forms.Label();
            this.textBox_Filter_Id = new System.Windows.Forms.TextBox();
            this.textBox_Filter_Client = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Filter_From = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Filter_To = new System.Windows.Forms.DateTimePicker();
            this.listBox_Trades = new System.Windows.Forms.ListBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Memo = new System.Windows.Forms.Label();
            this.textBox_Memo = new System.Windows.Forms.TextBox();
            this.label_Client = new System.Windows.Forms.Label();
            this.text_Client = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Filter_BtcAddress = new System.Windows.Forms.TextBox();
            this.textBox_Filter_LastName = new System.Windows.Forms.TextBox();
            this.listBox_Client = new System.Windows.Forms.ListBox();
            this.groupBox_Client = new System.Windows.Forms.GroupBox();
            this.label_ClientInfo_FirstName = new System.Windows.Forms.Label();
            this.label_ClientInfo_BtcAddress = new System.Windows.Forms.Label();
            this.text_ClientInfo_LastName = new System.Windows.Forms.Label();
            this.text_ClientInfo_FirstName = new System.Windows.Forms.Label();
            this.text_ClientInfo_BtcAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.O.SuspendLayout();
            this.tradeDetails.SuspendLayout();
            this.tradeClient.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox_Client.SuspendLayout();
            this.SuspendLayout();
            // 
            // O
            // 
            this.O.Controls.Add(this.tradeDetails);
            this.O.Controls.Add(this.tradeClient);
            this.O.Controls.Add(this.tradeCoins_TabControl);
            this.O.Location = new System.Drawing.Point(12, 12);
            this.O.Name = "O";
            this.O.SelectedIndex = 0;
            this.O.Size = new System.Drawing.Size(776, 426);
            this.O.TabIndex = 0;
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
            this.tradeDetails.Controls.Add(this.groupBox_Filter);
            this.tradeDetails.Location = new System.Drawing.Point(4, 25);
            this.tradeDetails.Name = "tradeDetails";
            this.tradeDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tradeDetails.Size = new System.Drawing.Size(768, 397);
            this.tradeDetails.TabIndex = 0;
            this.tradeDetails.Text = "Trade Details";
            this.tradeDetails.UseVisualStyleBackColor = true;
            // 
            // tradeClient
            // 
            this.tradeClient.Controls.Add(this.groupBox_Client);
            this.tradeClient.Controls.Add(this.listBox_Client);
            this.tradeClient.Controls.Add(this.groupBox1);
            this.tradeClient.Location = new System.Drawing.Point(4, 25);
            this.tradeClient.Name = "tradeClient";
            this.tradeClient.Padding = new System.Windows.Forms.Padding(3);
            this.tradeClient.Size = new System.Drawing.Size(768, 397);
            this.tradeClient.TabIndex = 1;
            this.tradeClient.Text = "Trade Client";
            this.tradeClient.UseVisualStyleBackColor = true;
            // 
            // tradeCoins_TabControl
            // 
            this.tradeCoins_TabControl.Location = new System.Drawing.Point(4, 25);
            this.tradeCoins_TabControl.Name = "tradeCoins_TabControl";
            this.tradeCoins_TabControl.Padding = new System.Windows.Forms.Padding(3);
            this.tradeCoins_TabControl.Size = new System.Drawing.Size(732, 374);
            this.tradeCoins_TabControl.TabIndex = 2;
            this.tradeCoins_TabControl.Text = "Trade Coins";
            this.tradeCoins_TabControl.UseVisualStyleBackColor = true;
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_Filter_To);
            this.groupBox_Filter.Controls.Add(this.dateTimePicker_Filter_From);
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_Client);
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_Id);
            this.groupBox_Filter.Controls.Add(this.label_Filter_To);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Client);
            this.groupBox_Filter.Controls.Add(this.label_Filter_From);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Id);
            this.groupBox_Filter.Location = new System.Drawing.Point(18, 19);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(268, 190);
            this.groupBox_Filter.TabIndex = 2;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
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
            // textBox_Filter_Id
            // 
            this.textBox_Filter_Id.Location = new System.Drawing.Point(117, 31);
            this.textBox_Filter_Id.Name = "textBox_Filter_Id";
            this.textBox_Filter_Id.Size = new System.Drawing.Size(100, 22);
            this.textBox_Filter_Id.TabIndex = 1;
            // 
            // textBox_Filter_Client
            // 
            this.textBox_Filter_Client.Location = new System.Drawing.Point(117, 135);
            this.textBox_Filter_Client.Name = "textBox_Filter_Client";
            this.textBox_Filter_Client.Size = new System.Drawing.Size(100, 22);
            this.textBox_Filter_Client.TabIndex = 1;
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
            // listBox_Trades
            // 
            this.listBox_Trades.FormattingEnabled = true;
            this.listBox_Trades.ItemHeight = 16;
            this.listBox_Trades.Location = new System.Drawing.Point(18, 220);
            this.listBox_Trades.Name = "listBox_Trades";
            this.listBox_Trades.Size = new System.Drawing.Size(268, 164);
            this.listBox_Trades.TabIndex = 3;
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
            // textBox_Memo
            // 
            this.textBox_Memo.Location = new System.Drawing.Point(392, 154);
            this.textBox_Memo.Multiline = true;
            this.textBox_Memo.Name = "textBox_Memo";
            this.textBox_Memo.Size = new System.Drawing.Size(286, 105);
            this.textBox_Memo.TabIndex = 5;
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
            // text_Client
            // 
            this.text_Client.AutoSize = true;
            this.text_Client.Location = new System.Drawing.Point(392, 335);
            this.text_Client.Name = "text_Client";
            this.text_Client.Size = new System.Drawing.Size(106, 16);
            this.text_Client.TabIndex = 6;
            this.text_Client.Text = "No client chosen";
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(392, 53);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(23, 25);
            this.text_Id.TabIndex = 7;
            this.text_Id.Text = "0";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Filter_BtcAddress);
            this.groupBox1.Controls.Add(this.textBox_Filter_LastName);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 107);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
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
            // 
            // textBox_Filter_LastName
            // 
            this.textBox_Filter_LastName.Location = new System.Drawing.Point(128, 23);
            this.textBox_Filter_LastName.Name = "textBox_Filter_LastName";
            this.textBox_Filter_LastName.Size = new System.Drawing.Size(180, 22);
            this.textBox_Filter_LastName.TabIndex = 0;
            // 
            // listBox_Client
            // 
            this.listBox_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Client.FormattingEnabled = true;
            this.listBox_Client.ItemHeight = 25;
            this.listBox_Client.Location = new System.Drawing.Point(9, 119);
            this.listBox_Client.Name = "listBox_Client";
            this.listBox_Client.Size = new System.Drawing.Size(305, 254);
            this.listBox_Client.TabIndex = 10;
            // 
            // groupBox_Client
            // 
            this.groupBox_Client.Controls.Add(this.text_ClientInfo_BtcAddress);
            this.groupBox_Client.Controls.Add(this.label_ClientInfo_BtcAddress);
            this.groupBox_Client.Controls.Add(this.label5);
            this.groupBox_Client.Controls.Add(this.text_ClientInfo_LastName);
            this.groupBox_Client.Controls.Add(this.text_ClientInfo_FirstName);
            this.groupBox_Client.Controls.Add(this.label_ClientInfo_FirstName);
            this.groupBox_Client.Location = new System.Drawing.Point(360, 273);
            this.groupBox_Client.Name = "groupBox_Client";
            this.groupBox_Client.Size = new System.Drawing.Size(402, 100);
            this.groupBox_Client.TabIndex = 11;
            this.groupBox_Client.TabStop = false;
            this.groupBox_Client.Text = "Client Info";
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
            // label_ClientInfo_BtcAddress
            // 
            this.label_ClientInfo_BtcAddress.AutoSize = true;
            this.label_ClientInfo_BtcAddress.Location = new System.Drawing.Point(22, 62);
            this.label_ClientInfo_BtcAddress.Name = "label_ClientInfo_BtcAddress";
            this.label_ClientInfo_BtcAddress.Size = new System.Drawing.Size(101, 16);
            this.label_ClientInfo_BtcAddress.TabIndex = 0;
            this.label_ClientInfo_BtcAddress.Text = "Bitcoin Address";
            // 
            // text_ClientInfo_LastName
            // 
            this.text_ClientInfo_LastName.AutoSize = true;
            this.text_ClientInfo_LastName.Location = new System.Drawing.Point(289, 31);
            this.text_ClientInfo_LastName.Name = "text_ClientInfo_LastName";
            this.text_ClientInfo_LastName.Size = new System.Drawing.Size(72, 16);
            this.text_ClientInfo_LastName.TabIndex = 0;
            this.text_ClientInfo_LastName.Text = "Last Name";
            this.text_ClientInfo_LastName.Click += new System.EventHandler(this.label3_Click);
            // 
            // text_ClientInfo_FirstName
            // 
            this.text_ClientInfo_FirstName.AutoSize = true;
            this.text_ClientInfo_FirstName.Location = new System.Drawing.Point(109, 31);
            this.text_ClientInfo_FirstName.Name = "text_ClientInfo_FirstName";
            this.text_ClientInfo_FirstName.Size = new System.Drawing.Size(72, 16);
            this.text_ClientInfo_FirstName.TabIndex = 0;
            this.text_ClientInfo_FirstName.Text = "First Name";
            // 
            // text_ClientInfo_BtcAddress
            // 
            this.text_ClientInfo_BtcAddress.AutoSize = true;
            this.text_ClientInfo_BtcAddress.Location = new System.Drawing.Point(139, 62);
            this.text_ClientInfo_BtcAddress.Name = "text_ClientInfo_BtcAddress";
            this.text_ClientInfo_BtcAddress.Size = new System.Drawing.Size(14, 16);
            this.text_ClientInfo_BtcAddress.TabIndex = 0;
            this.text_ClientInfo_BtcAddress.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Name";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // Trade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.O);
            this.Name = "Trade";
            this.Text = "Order";
            this.O.ResumeLayout(false);
            this.tradeDetails.ResumeLayout(false);
            this.tradeDetails.PerformLayout();
            this.tradeClient.ResumeLayout(false);
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Client.ResumeLayout(false);
            this.groupBox_Client.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl O;
        private System.Windows.Forms.TabPage tradeDetails;
        private System.Windows.Forms.TabPage tradeClient;
        private System.Windows.Forms.TabPage tradeCoins_TabControl;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.Label text_Id;
        private System.Windows.Forms.Label text_Client;
        private System.Windows.Forms.TextBox textBox_Memo;
        private System.Windows.Forms.Label label_Memo;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.ListBox listBox_Trades;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Filter_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Filter_From;
        private System.Windows.Forms.TextBox textBox_Filter_Client;
        private System.Windows.Forms.TextBox textBox_Filter_Id;
        private System.Windows.Forms.Label label_Filter_To;
        private System.Windows.Forms.Label label_Filter_Client;
        private System.Windows.Forms.Label label_Filter_From;
        private System.Windows.Forms.Label label_Filter_Id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Filter_BtcAddress;
        private System.Windows.Forms.TextBox textBox_Filter_LastName;
        private System.Windows.Forms.GroupBox groupBox_Client;
        private System.Windows.Forms.Label label_ClientInfo_BtcAddress;
        private System.Windows.Forms.Label text_ClientInfo_LastName;
        private System.Windows.Forms.Label text_ClientInfo_FirstName;
        private System.Windows.Forms.Label label_ClientInfo_FirstName;
        private System.Windows.Forms.ListBox listBox_Client;
        private System.Windows.Forms.Label text_ClientInfo_BtcAddress;
        private System.Windows.Forms.Label label5;
    }
}