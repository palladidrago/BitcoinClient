
namespace ClientApp
{
    partial class AdminPanel
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
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.Label();
            this.groupBox_GeneralInfo = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Filter_BtcAddress = new System.Windows.Forms.TextBox();
            this.textBox_Filter_LastName = new System.Windows.Forms.TextBox();
            this.groupBox_GeneralInfo.SuspendLayout();
            this.groupBox_BtcInfo.SuspendLayout();
            this.groupBox_UselessInfo.SuspendLayout();
            this.groupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientListBox
            // 
            this.clientListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.ItemHeight = 25;
            this.clientListBox.Location = new System.Drawing.Point(12, 112);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(324, 304);
            this.clientListBox.TabIndex = 1;
            this.clientListBox.DoubleClick += new System.EventHandler(this.clientListBox_Client_DoubleClick);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(381, 40);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(42, 32);
            this.label_Id.TabIndex = 2;
            this.label_Id.Text = "ID";
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(459, 40);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(31, 32);
            this.text_Id.TabIndex = 3;
            this.text_Id.Text = "0";
            // 
            // groupBox_GeneralInfo
            // 
            this.groupBox_GeneralInfo.Controls.Add(this.label_PhoneNumber);
            this.groupBox_GeneralInfo.Controls.Add(this.label_BirthYear);
            this.groupBox_GeneralInfo.Controls.Add(this.label_LastName);
            this.groupBox_GeneralInfo.Controls.Add(this.label_FirstName);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_PhoneNumber);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_BirthYear);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_LastName);
            this.groupBox_GeneralInfo.Controls.Add(this.textBox_FirstName);
            this.groupBox_GeneralInfo.Location = new System.Drawing.Point(360, 105);
            this.groupBox_GeneralInfo.Name = "groupBox_GeneralInfo";
            this.groupBox_GeneralInfo.Size = new System.Drawing.Size(211, 291);
            this.groupBox_GeneralInfo.TabIndex = 4;
            this.groupBox_GeneralInfo.TabStop = false;
            this.groupBox_GeneralInfo.Text = "General info";
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Location = new System.Drawing.Point(24, 204);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.label_PhoneNumber.TabIndex = 1;
            this.label_PhoneNumber.Text = "Phone Number";
            // 
            // label_BirthYear
            // 
            this.label_BirthYear.AutoSize = true;
            this.label_BirthYear.Location = new System.Drawing.Point(24, 143);
            this.label_BirthYear.Name = "label_BirthYear";
            this.label_BirthYear.Size = new System.Drawing.Size(75, 17);
            this.label_BirthYear.TabIndex = 1;
            this.label_BirthYear.Text = "Birth Year:";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(24, 88);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(80, 17);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "Last Name:";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(24, 33);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(80, 17);
            this.label_FirstName.TabIndex = 1;
            this.label_FirstName.Text = "First Name:";
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(27, 224);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(116, 22);
            this.textBox_PhoneNumber.TabIndex = 0;
            // 
            // textBox_BirthYear
            // 
            this.textBox_BirthYear.Location = new System.Drawing.Point(27, 163);
            this.textBox_BirthYear.Name = "textBox_BirthYear";
            this.textBox_BirthYear.Size = new System.Drawing.Size(77, 22);
            this.textBox_BirthYear.TabIndex = 0;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(27, 108);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(116, 22);
            this.textBox_LastName.TabIndex = 0;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(27, 53);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(116, 22);
            this.textBox_FirstName.TabIndex = 0;
            // 
            // groupBox_BtcInfo
            // 
            this.groupBox_BtcInfo.Controls.Add(this.textBox_BtcAmount);
            this.groupBox_BtcInfo.Controls.Add(this.label_BtcAmount);
            this.groupBox_BtcInfo.Controls.Add(this.textBox_BtcAddress);
            this.groupBox_BtcInfo.Controls.Add(this.label_BtcAddress);
            this.groupBox_BtcInfo.Location = new System.Drawing.Point(577, 105);
            this.groupBox_BtcInfo.Name = "groupBox_BtcInfo";
            this.groupBox_BtcInfo.Size = new System.Drawing.Size(198, 153);
            this.groupBox_BtcInfo.TabIndex = 5;
            this.groupBox_BtcInfo.TabStop = false;
            this.groupBox_BtcInfo.Text = "Bitcoin info";
            // 
            // textBox_BtcAmount
            // 
            this.textBox_BtcAmount.Location = new System.Drawing.Point(6, 108);
            this.textBox_BtcAmount.Name = "textBox_BtcAmount";
            this.textBox_BtcAmount.Size = new System.Drawing.Size(116, 22);
            this.textBox_BtcAmount.TabIndex = 0;
            // 
            // label_BtcAmount
            // 
            this.label_BtcAmount.AutoSize = true;
            this.label_BtcAmount.Location = new System.Drawing.Point(3, 88);
            this.label_BtcAmount.Name = "label_BtcAmount";
            this.label_BtcAmount.Size = new System.Drawing.Size(105, 17);
            this.label_BtcAmount.TabIndex = 1;
            this.label_BtcAmount.Text = "Bitcoin amount:";
            // 
            // textBox_BtcAddress
            // 
            this.textBox_BtcAddress.Location = new System.Drawing.Point(6, 53);
            this.textBox_BtcAddress.Name = "textBox_BtcAddress";
            this.textBox_BtcAddress.Size = new System.Drawing.Size(116, 22);
            this.textBox_BtcAddress.TabIndex = 0;
            // 
            // label_BtcAddress
            // 
            this.label_BtcAddress.AutoSize = true;
            this.label_BtcAddress.Location = new System.Drawing.Point(3, 33);
            this.label_BtcAddress.Name = "label_BtcAddress";
            this.label_BtcAddress.Size = new System.Drawing.Size(110, 17);
            this.label_BtcAddress.TabIndex = 1;
            this.label_BtcAddress.Text = "Bitcoin Address:";
            // 
            // groupBox_UselessInfo
            // 
            this.groupBox_UselessInfo.Controls.Add(this.textBox_ShoeSize);
            this.groupBox_UselessInfo.Controls.Add(this.label_ShoeSize);
            this.groupBox_UselessInfo.Location = new System.Drawing.Point(577, 296);
            this.groupBox_UselessInfo.Name = "groupBox_UselessInfo";
            this.groupBox_UselessInfo.Size = new System.Drawing.Size(200, 100);
            this.groupBox_UselessInfo.TabIndex = 6;
            this.groupBox_UselessInfo.TabStop = false;
            this.groupBox_UselessInfo.Text = "Useless info";
            // 
            // textBox_ShoeSize
            // 
            this.textBox_ShoeSize.Location = new System.Drawing.Point(9, 53);
            this.textBox_ShoeSize.Name = "textBox_ShoeSize";
            this.textBox_ShoeSize.Size = new System.Drawing.Size(116, 22);
            this.textBox_ShoeSize.TabIndex = 0;
            // 
            // label_ShoeSize
            // 
            this.label_ShoeSize.AutoSize = true;
            this.label_ShoeSize.Location = new System.Drawing.Point(6, 33);
            this.label_ShoeSize.Name = "label_ShoeSize";
            this.label_ShoeSize.Size = new System.Drawing.Size(74, 17);
            this.label_ShoeSize.TabIndex = 1;
            this.label_ShoeSize.Text = "Shoe size:";
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Lime;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(586, 12);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(99, 76);
            this.doneButton.TabIndex = 7;
            this.doneButton.Text = "Update";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(691, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 36);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(691, 54);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 34);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.label2);
            this.groupBox_Filter.Controls.Add(this.label1);
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_BtcAddress);
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_LastName);
            this.groupBox_Filter.Location = new System.Drawing.Point(12, 13);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Size = new System.Drawing.Size(324, 93);
            this.groupBox_Filter.TabIndex = 8;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bitcoin address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
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
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.groupBox_UselessInfo);
            this.Controls.Add(this.groupBox_BtcInfo);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.clientListBox);
            this.Controls.Add(this.groupBox_GeneralInfo);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.groupBox_GeneralInfo.ResumeLayout(false);
            this.groupBox_GeneralInfo.PerformLayout();
            this.groupBox_BtcInfo.ResumeLayout(false);
            this.groupBox_BtcInfo.PerformLayout();
            this.groupBox_UselessInfo.ResumeLayout(false);
            this.groupBox_UselessInfo.PerformLayout();
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientListBox;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Filter_BtcAddress;
        private System.Windows.Forms.TextBox textBox_Filter_LastName;
    }
}