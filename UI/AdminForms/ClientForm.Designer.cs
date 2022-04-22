
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
            this.button_AddCountry = new System.Windows.Forms.Label();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_BirthYear = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_BirthYear = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.groupBox_BtcInfo = new System.Windows.Forms.GroupBox();
            this.textBox_BtcAmount = new System.Windows.Forms.TextBox();
            this.label_BtcAmount = new System.Windows.Forms.Label();
            this.textBox_BtcAddress = new System.Windows.Forms.TextBox();
            this.label_BtcAddress = new System.Windows.Forms.Label();
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
            this.pictureBox_Client = new System.Windows.Forms.PictureBox();
            this.groupBox_GeneralInfo.SuspendLayout();
            this.groupBox_BtcInfo.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.groupBox_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Client)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Client
            // 
            this.listBox_Client.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Client.FormattingEnabled = true;
            this.listBox_Client.ItemHeight = 21;
            this.listBox_Client.Location = new System.Drawing.Point(9, 110);
            this.listBox_Client.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_Client.Name = "listBox_Client";
            this.listBox_Client.Size = new System.Drawing.Size(244, 277);
            this.listBox_Client.TabIndex = 1;
            this.listBox_Client.DoubleClick += new System.EventHandler(this.clientListBox_Client_DoubleClick);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.BackColor = System.Drawing.Color.Transparent;
            this.label_Id.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(117, 22);
            this.label_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(34, 25);
            this.label_Id.TabIndex = 2;
            this.label_Id.Text = "ID";
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.BackColor = System.Drawing.Color.Transparent;
            this.text_Id.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(152, 22);
            this.text_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(24, 25);
            this.text_Id.TabIndex = 3;
            this.text_Id.Text = "0";
            // 
            // groupBox_GeneralInfo
            // 
            this.groupBox_GeneralInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.groupBox_GeneralInfo.Controls.Add(this.button_AddCountry);
            this.groupBox_GeneralInfo.Controls.Add(this.comboBox_Country);
            this.groupBox_GeneralInfo.Controls.Add(this.label3);
            this.groupBox_GeneralInfo.Controls.Add(this.label_Mail);
            this.groupBox_GeneralInfo.Controls.Add(this.label_BirthYear);
            this.groupBox_GeneralInfo.Controls.Add(this.label_LastName);
            this.groupBox_GeneralInfo.Controls.Add(this.label_Id);
            this.groupBox_GeneralInfo.Controls.Add(this.text_Id);
            this.groupBox_GeneralInfo.Controls.Add(this.label_FirstName);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_Mail);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_BirthYear);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_LastName);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_FirstName);
            this.groupBox_GeneralInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_GeneralInfo.Location = new System.Drawing.Point(261, 110);
            this.groupBox_GeneralInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_GeneralInfo.Name = "groupBox_GeneralInfo";
            this.groupBox_GeneralInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_GeneralInfo.Size = new System.Drawing.Size(180, 282);
            this.groupBox_GeneralInfo.TabIndex = 4;
            this.groupBox_GeneralInfo.TabStop = false;
            this.groupBox_GeneralInfo.Text = "General info";
            // 
            // button_AddCountry
            // 
            this.button_AddCountry.AutoSize = true;
            this.button_AddCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_AddCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddCountry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddCountry.Location = new System.Drawing.Point(116, 235);
            this.button_AddCountry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.button_AddCountry.Name = "button_AddCountry";
            this.button_AddCountry.Size = new System.Drawing.Size(25, 26);
            this.button_AddCountry.TabIndex = 3;
            this.button_AddCountry.Text = "+";
            this.button_AddCountry.Click += new System.EventHandler(this.button_AddCountry_Click);
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(20, 232);
            this.comboBox_Country.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(92, 29);
            this.comboBox_Country.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(18, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Country:";
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.BackColor = System.Drawing.Color.Transparent;
            this.label_Mail.Location = new System.Drawing.Point(18, 161);
            this.label_Mail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(117, 21);
            this.label_Mail.TabIndex = 1;
            this.label_Mail.Text = "Email Address";
            // 
            // label_BirthYear
            // 
            this.label_BirthYear.AutoSize = true;
            this.label_BirthYear.BackColor = System.Drawing.Color.Transparent;
            this.label_BirthYear.Location = new System.Drawing.Point(18, 116);
            this.label_BirthYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_BirthYear.Name = "label_BirthYear";
            this.label_BirthYear.Size = new System.Drawing.Size(89, 21);
            this.label_BirthYear.TabIndex = 1;
            this.label_BirthYear.Text = "Birth Year:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.BackColor = System.Drawing.Color.Transparent;
            this.label_LastName.Location = new System.Drawing.Point(18, 72);
            this.label_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(97, 21);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.BackColor = System.Drawing.Color.Transparent;
            this.label_FirstName.Location = new System.Drawing.Point(18, 27);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(95, 21);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "First Name:";
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(20, 182);
            this.textBox_Mail.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(156, 27);
            this.textBox_Mail.TabIndex = 0;
            // 
            // textBox_BirthYear
            // 
            this.textBox_BirthYear.Location = new System.Drawing.Point(20, 132);
            this.textBox_BirthYear.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_BirthYear.Name = "textBox_BirthYear";
            this.textBox_BirthYear.Size = new System.Drawing.Size(59, 27);
            this.textBox_BirthYear.TabIndex = 0;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(20, 88);
            this.textBox_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(88, 27);
            this.textBox_LastName.TabIndex = 0;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(20, 43);
            this.textBox_FirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(88, 27);
            this.textBox_FirstName.TabIndex = 0;
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // groupBox_BtcInfo
            // 
            this.groupBox_BtcInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.groupBox_BtcInfo.Controls.Add(this.textBox_BtcAmount);
            this.groupBox_BtcInfo.Controls.Add(this.label_BtcAmount);
            this.groupBox_BtcInfo.Controls.Add(this.textBox_BtcAddress);
            this.groupBox_BtcInfo.Controls.Add(this.label_BtcAddress);
            this.groupBox_BtcInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_BtcInfo.Location = new System.Drawing.Point(447, 110);
            this.groupBox_BtcInfo.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_BtcInfo.Name = "groupBox_BtcInfo";
            this.groupBox_BtcInfo.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_BtcInfo.Size = new System.Drawing.Size(163, 158);
            this.groupBox_BtcInfo.TabIndex = 5;
            this.groupBox_BtcInfo.TabStop = false;
            this.groupBox_BtcInfo.Text = "Bitcoin info";
            // 
            // textBox_BtcAmount
            // 
            this.textBox_BtcAmount.Location = new System.Drawing.Point(5, 116);
            this.textBox_BtcAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_BtcAmount.Name = "textBox_BtcAmount";
            this.textBox_BtcAmount.Size = new System.Drawing.Size(88, 27);
            this.textBox_BtcAmount.TabIndex = 0;
            // 
            // label_BtcAmount
            // 
            this.label_BtcAmount.AutoSize = true;
            this.label_BtcAmount.BackColor = System.Drawing.Color.Transparent;
            this.label_BtcAmount.Location = new System.Drawing.Point(4, 95);
            this.label_BtcAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_BtcAmount.Name = "label_BtcAmount";
            this.label_BtcAmount.Size = new System.Drawing.Size(133, 21);
            this.label_BtcAmount.TabIndex = 1;
            this.label_BtcAmount.Text = "Bitcoin amount:";
            // 
            // textBox_BtcAddress
            // 
            this.textBox_BtcAddress.Location = new System.Drawing.Point(5, 56);
            this.textBox_BtcAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_BtcAddress.Name = "textBox_BtcAddress";
            this.textBox_BtcAddress.Size = new System.Drawing.Size(88, 27);
            this.textBox_BtcAddress.TabIndex = 0;
            // 
            // label_BtcAddress
            // 
            this.label_BtcAddress.AutoSize = true;
            this.label_BtcAddress.BackColor = System.Drawing.Color.Transparent;
            this.label_BtcAddress.Location = new System.Drawing.Point(4, 36);
            this.label_BtcAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_BtcAddress.Name = "label_BtcAddress";
            this.label_BtcAddress.Size = new System.Drawing.Size(132, 21);
            this.label_BtcAddress.TabIndex = 1;
            this.label_BtcAddress.Text = "Bitcoin Address:";
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Lime;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(451, 24);
            this.doneButton.Margin = new System.Windows.Forms.Padding(2);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(82, 62);
            this.doneButton.TabIndex = 7;
            this.doneButton.Text = "Update";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(537, 24);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2);
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
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(537, 58);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(73, 28);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.groupBox_Filter.Controls.Add(this.label2);
            this.groupBox_Filter.Controls.Add(this.label_Filter_LastName);
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_BtcAddress);
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_LastName);
            this.groupBox_Filter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Filter.Location = new System.Drawing.Point(9, 10);
            this.groupBox_Filter.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Filter.Size = new System.Drawing.Size(294, 98);
            this.groupBox_Filter.TabIndex = 8;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitcoin address";
            // 
            // label_Filter_LastName
            // 
            this.label_Filter_LastName.AutoSize = true;
            this.label_Filter_LastName.BackColor = System.Drawing.Color.Transparent;
            this.label_Filter_LastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_LastName.Location = new System.Drawing.Point(43, 28);
            this.label_Filter_LastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Filter_LastName.Name = "label_Filter_LastName";
            this.label_Filter_LastName.Size = new System.Drawing.Size(93, 21);
            this.label_Filter_LastName.TabIndex = 1;
            this.label_Filter_LastName.Text = "Last Name";
            // 
            // textBox_Filter_BtcAddress
            // 
            this.textBox_Filter_BtcAddress.Location = new System.Drawing.Point(143, 57);
            this.textBox_Filter_BtcAddress.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Filter_BtcAddress.Name = "textBox_Filter_BtcAddress";
            this.textBox_Filter_BtcAddress.Size = new System.Drawing.Size(136, 27);
            this.textBox_Filter_BtcAddress.TabIndex = 0;
            this.textBox_Filter_BtcAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // textBox_Filter_LastName
            // 
            this.textBox_Filter_LastName.Location = new System.Drawing.Point(143, 22);
            this.textBox_Filter_LastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Filter_LastName.Name = "textBox_Filter_LastName";
            this.textBox_Filter_LastName.Size = new System.Drawing.Size(136, 27);
            this.textBox_Filter_LastName.TabIndex = 0;
            this.textBox_Filter_LastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(250)))));
            this.groupBox_Login.Controls.Add(this.button_UpdateLogin);
            this.groupBox_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Login.Location = new System.Drawing.Point(447, 281);
            this.groupBox_Login.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_Login.Size = new System.Drawing.Size(163, 111);
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
            this.button_UpdateLogin.Location = new System.Drawing.Point(22, 32);
            this.button_UpdateLogin.Margin = new System.Windows.Forms.Padding(2);
            this.button_UpdateLogin.Name = "button_UpdateLogin";
            this.button_UpdateLogin.Size = new System.Drawing.Size(118, 66);
            this.button_UpdateLogin.TabIndex = 0;
            this.button_UpdateLogin.Text = "Update login";
            this.button_UpdateLogin.UseVisualStyleBackColor = false;
            this.button_UpdateLogin.Click += new System.EventHandler(this.button_UpdateLogin_Click);
            // 
            // pictureBox_Client
            // 
            this.pictureBox_Client.Image = global::ClientApp.Properties.Resources.Client;
            this.pictureBox_Client.Location = new System.Drawing.Point(349, 10);
            this.pictureBox_Client.Name = "pictureBox_Client";
            this.pictureBox_Client.Size = new System.Drawing.Size(60, 95);
            this.pictureBox_Client.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Client.TabIndex = 9;
            this.pictureBox_Client.TabStop = false;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(620, 406);
            this.Controls.Add(this.pictureBox_Client);
            this.Controls.Add(this.groupBox_Login);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.groupBox_BtcInfo);
            this.Controls.Add(this.listBox_Client);
            this.Controls.Add(this.groupBox_GeneralInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.Text = "Client Form";
            this.groupBox_GeneralInfo.ResumeLayout(false);
            this.groupBox_GeneralInfo.PerformLayout();
            this.groupBox_BtcInfo.ResumeLayout(false);
            this.groupBox_BtcInfo.PerformLayout();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.groupBox_Login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Client;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label text_Id;
        private System.Windows.Forms.GroupBox groupBox_GeneralInfo;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_BirthYear;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_BirthYear;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.GroupBox groupBox_BtcInfo;
        private System.Windows.Forms.TextBox textBox_BtcAmount;
        private System.Windows.Forms.Label label_BtcAmount;
        private System.Windows.Forms.TextBox textBox_BtcAddress;
        private System.Windows.Forms.Label label_BtcAddress;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Filter_LastName;
        private System.Windows.Forms.TextBox textBox_Filter_BtcAddress;
        private System.Windows.Forms.TextBox textBox_Filter_LastName;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label button_AddCountry;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.Button button_UpdateLogin;
        private System.Windows.Forms.PictureBox pictureBox_Client;
    }
}