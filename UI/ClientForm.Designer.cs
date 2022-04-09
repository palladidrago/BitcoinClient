
namespace ClientApp.UI
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.listBox_Client = new System.Windows.Forms.ListBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.Label();
            this.groupBox_GeneralInfo = new System.Windows.Forms.GroupBox();
            this.button_AddCity = new System.Windows.Forms.Label();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.label_BirthYear = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.textBox_BirthYear = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.groupBox_BtcInfo = new System.Windows.Forms.GroupBox();
            this.textBox_BtcAmount = new System.Windows.Forms.TextBox();
            this.label_BtcAmount = new System.Windows.Forms.Label();
            this.textBox_BtcAddress = new System.Windows.Forms.TextBox();
            this.label_BtcAddress = new System.Windows.Forms.Label();
            this.groupBox_UselessInfo = new System.Windows.Forms.GroupBox();
            this.textBox_ShoeSize = new System.Windows.Forms.TextBox();
            this.label_ShoeSize = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Filter_LastName = new System.Windows.Forms.Label();
            this.textBox_Filter_BtcAddress = new System.Windows.Forms.TextBox();
            this.textBox_Filter_LastName = new System.Windows.Forms.TextBox();
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.button_UpdateLogin = new System.Windows.Forms.Button();
            this.groupBox_GeneralInfo.SuspendLayout();
            this.groupBox_BtcInfo.SuspendLayout();
            this.groupBox_UselessInfo.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.groupBox_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Client
            // 
            this.listBox_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Client.FormattingEnabled = true;
            this.listBox_Client.ItemHeight = 20;
            this.listBox_Client.Location = new System.Drawing.Point(9, 91);
            this.listBox_Client.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_Client.Name = "listBox_Client";
            this.listBox_Client.Size = new System.Drawing.Size(244, 244);
            this.listBox_Client.TabIndex = 1;
            this.listBox_Client.DoubleClick += new System.EventHandler(this.clientListBox_Client_DoubleClick);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(286, 32);
            this.label_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(34, 26);
            this.label_Id.TabIndex = 2;
            this.label_Id.Text = "ID";
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(344, 32);
            this.text_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(24, 26);
            this.text_Id.TabIndex = 3;
            this.text_Id.Text = "0";
            // 
            // groupBox_GeneralInfo
            // 
            this.groupBox_GeneralInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_GeneralInfo.Controls.Add(this.button_AddCity);
            this.groupBox_GeneralInfo.Controls.Add(this.comboBox_City);
            this.groupBox_GeneralInfo.Controls.Add(this.label3);
            this.groupBox_GeneralInfo.Controls.Add(this.label_PhoneNumber);
            this.groupBox_GeneralInfo.Controls.Add(this.label_BirthYear);
            this.groupBox_GeneralInfo.Controls.Add(this.label_LastName);
            this.groupBox_GeneralInfo.Controls.Add(this.label_FirstName);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_PhoneNumber);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_BirthYear);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_LastName);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_FirstName);
            this.groupBox_GeneralInfo.Location = new System.Drawing.Point(270, 76);
            this.groupBox_GeneralInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_GeneralInfo.Name = "groupBox_GeneralInfo";
            this.groupBox_GeneralInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_GeneralInfo.Size = new System.Drawing.Size(158, 280);
            this.groupBox_GeneralInfo.TabIndex = 4;
            this.groupBox_GeneralInfo.TabStop = false;
            this.groupBox_GeneralInfo.Text = "General info";
            // 
            // button_AddCity
            // 
            this.button_AddCity.AutoSize = true;
            this.button_AddCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_AddCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddCity.Location = new System.Drawing.Point(116, 227);
            this.button_AddCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.button_AddCity.Name = "button_AddCity";
            this.button_AddCity.Size = new System.Drawing.Size(25, 26);
            this.button_AddCity.TabIndex = 3;
            this.button_AddCity.Text = "+";
            this.button_AddCity.Click += new System.EventHandler(this.button_AddCity_Click);
            // 
            // comboBox_City
            // 
            this.comboBox_City.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_City.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_City.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(20, 232);
            this.comboBox_City.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(92, 21);
            this.comboBox_City.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "City:";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Location = new System.Drawing.Point(18, 166);
            this.label_PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.label_PhoneNumber.TabIndex = 1;
            this.label_PhoneNumber.Text = "Phone Number:";
            // 
            // label_BirthYear
            // 
            this.label_BirthYear.AutoSize = true;
            this.label_BirthYear.Location = new System.Drawing.Point(18, 116);
            this.label_BirthYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_BirthYear.Name = "label_BirthYear";
            this.label_BirthYear.Size = new System.Drawing.Size(56, 13);
            this.label_BirthYear.TabIndex = 1;
            this.label_BirthYear.Text = "Birth Year:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(18, 72);
            this.label_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(61, 13);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(18, 27);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(60, 13);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "First Name:";
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(20, 182);
            this.textBox_PhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(88, 20);
            this.textBox_PhoneNumber.TabIndex = 0;
            // 
            // textBox_BirthYear
            // 
            this.textBox_BirthYear.Location = new System.Drawing.Point(20, 132);
            this.textBox_BirthYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_BirthYear.Name = "textBox_BirthYear";
            this.textBox_BirthYear.Size = new System.Drawing.Size(59, 20);
            this.textBox_BirthYear.TabIndex = 0;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(20, 88);
            this.textBox_LastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(88, 20);
            this.textBox_LastName.TabIndex = 0;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(20, 43);
            this.textBox_FirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(88, 20);
            this.textBox_FirstName.TabIndex = 0;
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // groupBox_BtcInfo
            // 
            this.groupBox_BtcInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_BtcInfo.Controls.Add(this.textBox_BtcAmount);
            this.groupBox_BtcInfo.Controls.Add(this.label_BtcAmount);
            this.groupBox_BtcInfo.Controls.Add(this.textBox_BtcAddress);
            this.groupBox_BtcInfo.Controls.Add(this.label_BtcAddress);
            this.groupBox_BtcInfo.Location = new System.Drawing.Point(433, 76);
            this.groupBox_BtcInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_BtcInfo.Name = "groupBox_BtcInfo";
            this.groupBox_BtcInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_BtcInfo.Size = new System.Drawing.Size(148, 115);
            this.groupBox_BtcInfo.TabIndex = 5;
            this.groupBox_BtcInfo.TabStop = false;
            this.groupBox_BtcInfo.Text = "Bitcoin info";
            // 
            // textBox_BtcAmount
            // 
            this.textBox_BtcAmount.Location = new System.Drawing.Point(4, 88);
            this.textBox_BtcAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_BtcAmount.Name = "textBox_BtcAmount";
            this.textBox_BtcAmount.Size = new System.Drawing.Size(88, 20);
            this.textBox_BtcAmount.TabIndex = 0;
            // 
            // label_BtcAmount
            // 
            this.label_BtcAmount.AutoSize = true;
            this.label_BtcAmount.Location = new System.Drawing.Point(2, 72);
            this.label_BtcAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_BtcAmount.Name = "label_BtcAmount";
            this.label_BtcAmount.Size = new System.Drawing.Size(80, 13);
            this.label_BtcAmount.TabIndex = 1;
            this.label_BtcAmount.Text = "Bitcoin amount:";
            // 
            // textBox_BtcAddress
            // 
            this.textBox_BtcAddress.Location = new System.Drawing.Point(4, 43);
            this.textBox_BtcAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_BtcAddress.Name = "textBox_BtcAddress";
            this.textBox_BtcAddress.Size = new System.Drawing.Size(88, 20);
            this.textBox_BtcAddress.TabIndex = 0;
            // 
            // label_BtcAddress
            // 
            this.label_BtcAddress.AutoSize = true;
            this.label_BtcAddress.Location = new System.Drawing.Point(2, 27);
            this.label_BtcAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_BtcAddress.Name = "label_BtcAddress";
            this.label_BtcAddress.Size = new System.Drawing.Size(83, 13);
            this.label_BtcAddress.TabIndex = 1;
            this.label_BtcAddress.Text = "Bitcoin Address:";
            // 
            // groupBox_UselessInfo
            // 
            this.groupBox_UselessInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_UselessInfo.Controls.Add(this.textBox_ShoeSize);
            this.groupBox_UselessInfo.Controls.Add(this.label_ShoeSize);
            this.groupBox_UselessInfo.Location = new System.Drawing.Point(433, 197);
            this.groupBox_UselessInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_UselessInfo.Name = "groupBox_UselessInfo";
            this.groupBox_UselessInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_UselessInfo.Size = new System.Drawing.Size(150, 58);
            this.groupBox_UselessInfo.TabIndex = 6;
            this.groupBox_UselessInfo.TabStop = false;
            this.groupBox_UselessInfo.Text = "Useless info";
            // 
            // textBox_ShoeSize
            // 
            this.textBox_ShoeSize.Location = new System.Drawing.Point(7, 33);
            this.textBox_ShoeSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_ShoeSize.Name = "textBox_ShoeSize";
            this.textBox_ShoeSize.Size = new System.Drawing.Size(88, 20);
            this.textBox_ShoeSize.TabIndex = 0;
            // 
            // label_ShoeSize
            // 
            this.label_ShoeSize.AutoSize = true;
            this.label_ShoeSize.Location = new System.Drawing.Point(4, 17);
            this.label_ShoeSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ShoeSize.Name = "label_ShoeSize";
            this.label_ShoeSize.Size = new System.Drawing.Size(56, 13);
            this.label_ShoeSize.TabIndex = 1;
            this.label_ShoeSize.Text = "Shoe size:";
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Lime;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(440, 10);
            this.doneButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(74, 62);
            this.doneButton.TabIndex = 7;
            this.doneButton.Text = "Update";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(518, 10);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(73, 29);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(518, 44);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(73, 28);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_Filter.Controls.Add(this.label2);
            this.groupBox_Filter.Controls.Add(this.label_Filter_LastName);
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_BtcAddress);
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_LastName);
            this.groupBox_Filter.Location = new System.Drawing.Point(9, 10);
            this.groupBox_Filter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Filter.Size = new System.Drawing.Size(243, 76);
            this.groupBox_Filter.TabIndex = 8;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitcoin address";
            // 
            // label_Filter_LastName
            // 
            this.label_Filter_LastName.AutoSize = true;
            this.label_Filter_LastName.Location = new System.Drawing.Point(13, 21);
            this.label_Filter_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Filter_LastName.Name = "label_Filter_LastName";
            this.label_Filter_LastName.Size = new System.Drawing.Size(58, 13);
            this.label_Filter_LastName.TabIndex = 1;
            this.label_Filter_LastName.Text = "Last Name";
            // 
            // textBox_Filter_BtcAddress
            // 
            this.textBox_Filter_BtcAddress.Location = new System.Drawing.Point(96, 53);
            this.textBox_Filter_BtcAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Filter_BtcAddress.Name = "textBox_Filter_BtcAddress";
            this.textBox_Filter_BtcAddress.Size = new System.Drawing.Size(136, 20);
            this.textBox_Filter_BtcAddress.TabIndex = 0;
            this.textBox_Filter_BtcAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_Filter_LastName
            // 
            this.textBox_Filter_LastName.Location = new System.Drawing.Point(96, 19);
            this.textBox_Filter_LastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Filter_LastName.Name = "textBox_Filter_LastName";
            this.textBox_Filter_LastName.Size = new System.Drawing.Size(136, 20);
            this.textBox_Filter_LastName.TabIndex = 0;
            this.textBox_Filter_LastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox_Login.Controls.Add(this.button_UpdateLogin);
            this.groupBox_Login.Location = new System.Drawing.Point(433, 262);
            this.groupBox_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Login.Size = new System.Drawing.Size(150, 94);
            this.groupBox_Login.TabIndex = 7;
            this.groupBox_Login.TabStop = false;
            this.groupBox_Login.Text = "Login info";
            // 
            // button_UpdateLogin
            // 
            this.button_UpdateLogin.BackColor = System.Drawing.Color.Crimson;
            this.button_UpdateLogin.FlatAppearance.BorderSize = 0;
            this.button_UpdateLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateLogin.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateLogin.ForeColor = System.Drawing.Color.White;
            this.button_UpdateLogin.Location = new System.Drawing.Point(14, 17);
            this.button_UpdateLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_UpdateLogin.Name = "button_UpdateLogin";
            this.button_UpdateLogin.Size = new System.Drawing.Size(118, 66);
            this.button_UpdateLogin.TabIndex = 0;
            this.button_UpdateLogin.Text = "Update login";
            this.button_UpdateLogin.UseVisualStyleBackColor = false;
            this.button_UpdateLogin.Click += new System.EventHandler(this.button_UpdateLogin_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox_Login);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.groupBox_UselessInfo);
            this.Controls.Add(this.groupBox_BtcInfo);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.listBox_Client);
            this.Controls.Add(this.groupBox_GeneralInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientForm";
            this.Text = "Client Form";
            this.groupBox_GeneralInfo.ResumeLayout(false);
            this.groupBox_GeneralInfo.PerformLayout();
            this.groupBox_BtcInfo.ResumeLayout(false);
            this.groupBox_BtcInfo.PerformLayout();
            this.groupBox_UselessInfo.ResumeLayout(false);
            this.groupBox_UselessInfo.PerformLayout();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.groupBox_Login.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Client;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label text_Id;
        private System.Windows.Forms.GroupBox groupBox_GeneralInfo;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.Label label_BirthYear;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_BirthYear;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.GroupBox groupBox_BtcInfo;
        private System.Windows.Forms.TextBox textBox_BtcAmount;
        private System.Windows.Forms.Label label_BtcAmount;
        private System.Windows.Forms.TextBox textBox_BtcAddress;
        private System.Windows.Forms.Label label_BtcAddress;
        private System.Windows.Forms.GroupBox groupBox_UselessInfo;
        private System.Windows.Forms.TextBox textBox_ShoeSize;
        private System.Windows.Forms.Label label_ShoeSize;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Filter_LastName;
        private System.Windows.Forms.TextBox textBox_Filter_BtcAddress;
        private System.Windows.Forms.TextBox textBox_Filter_LastName;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label button_AddCity;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.Button button_UpdateLogin;
    }
}