
namespace ClientApp.UI
{
    partial class ClientCreateForm
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
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_BirthYear = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.label_BtcAmount = new System.Windows.Forms.Label();
            this.label_BtcAddress = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_BirthYear = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.textBox_BtcAmount = new System.Windows.Forms.TextBox();
            this.textBox_BtcAddress = new System.Windows.Forms.TextBox();
            this.doneButton = new System.Windows.Forms.Button();
            this.label_Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox_Country = new System.Windows.Forms.ComboBox();
            this.label_Country = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FirstName.Location = new System.Drawing.Point(26, 69);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(136, 30);
            this.label_FirstName.TabIndex = 0;
            this.label_FirstName.Text = "First Name";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LastName.Location = new System.Drawing.Point(26, 124);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(137, 30);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "Last Name";
            // 
            // label_BirthYear
            // 
            this.label_BirthYear.AutoSize = true;
            this.label_BirthYear.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BirthYear.Location = new System.Drawing.Point(26, 172);
            this.label_BirthYear.Name = "label_BirthYear";
            this.label_BirthYear.Size = new System.Drawing.Size(123, 30);
            this.label_BirthYear.TabIndex = 2;
            this.label_BirthYear.Text = "Birth Year";
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mail.Location = new System.Drawing.Point(26, 224);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(178, 30);
            this.label_Mail.TabIndex = 3;
            this.label_Mail.Text = "Email Address";
            // 
            // label_BtcAmount
            // 
            this.label_BtcAmount.AutoSize = true;
            this.label_BtcAmount.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BtcAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_BtcAmount.Location = new System.Drawing.Point(26, 279);
            this.label_BtcAmount.Name = "label_BtcAmount";
            this.label_BtcAmount.Size = new System.Drawing.Size(219, 30);
            this.label_BtcAmount.TabIndex = 4;
            this.label_BtcAmount.Text = "Amount of bitcoin";
            // 
            // label_BtcAddress
            // 
            this.label_BtcAddress.AutoSize = true;
            this.label_BtcAddress.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BtcAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_BtcAddress.Location = new System.Drawing.Point(26, 337);
            this.label_BtcAddress.Name = "label_BtcAddress";
            this.label_BtcAddress.Size = new System.Drawing.Size(190, 30);
            this.label_BtcAddress.TabIndex = 4;
            this.label_BtcAddress.Text = "Bitcoin address";
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.AcceptsTab = true;
            this.textBox_FirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FirstName.Location = new System.Drawing.Point(242, 74);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(138, 27);
            this.textBox_FirstName.TabIndex = 0;
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.AcceptsTab = true;
            this.textBox_LastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LastName.Location = new System.Drawing.Point(242, 129);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(138, 27);
            this.textBox_LastName.TabIndex = 1;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            // 
            // textBox_BirthYear
            // 
            this.textBox_BirthYear.AcceptsTab = true;
            this.textBox_BirthYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BirthYear.Location = new System.Drawing.Point(242, 177);
            this.textBox_BirthYear.Name = "textBox_BirthYear";
            this.textBox_BirthYear.Size = new System.Drawing.Size(138, 27);
            this.textBox_BirthYear.TabIndex = 2;
            this.textBox_BirthYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.AcceptsTab = true;
            this.textBox_Mail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Mail.Location = new System.Drawing.Point(242, 229);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(138, 27);
            this.textBox_Mail.TabIndex = 3;
            this.textBox_Mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_BtcAmount
            // 
            this.textBox_BtcAmount.AcceptsTab = true;
            this.textBox_BtcAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BtcAmount.Location = new System.Drawing.Point(242, 284);
            this.textBox_BtcAmount.Name = "textBox_BtcAmount";
            this.textBox_BtcAmount.Size = new System.Drawing.Size(138, 27);
            this.textBox_BtcAmount.TabIndex = 4;
            this.textBox_BtcAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Number_KeyPress);
            // 
            // textBox_BtcAddress
            // 
            this.textBox_BtcAddress.AcceptsTab = true;
            this.textBox_BtcAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BtcAddress.Location = new System.Drawing.Point(242, 342);
            this.textBox_BtcAddress.Name = "textBox_BtcAddress";
            this.textBox_BtcAddress.Size = new System.Drawing.Size(138, 27);
            this.textBox_BtcAddress.TabIndex = 5;
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.doneButton.FlatAppearance.BorderSize = 2;
            this.doneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneButton.Font = new System.Drawing.Font("Ubuntu", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.doneButton.Location = new System.Drawing.Point(446, 93);
            this.doneButton.Margin = new System.Windows.Forms.Padding(2);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(161, 76);
            this.doneButton.TabIndex = 7;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.Transparent;
            this.label_Title.Font = new System.Drawing.Font("Aharoni", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Title.Location = new System.Drawing.Point(214, 9);
            this.label_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(191, 35);
            this.label_Title.TabIndex = 8;
            this.label_Title.Text = "Client info ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClientApp.Properties.Resources.bitcoin;
            this.pictureBox1.Location = new System.Drawing.Point(404, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox_Country
            // 
            this.comboBox_Country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Country.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Country.FormattingEnabled = true;
            this.comboBox_Country.Location = new System.Drawing.Point(242, 404);
            this.comboBox_Country.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Country.Name = "comboBox_Country";
            this.comboBox_Country.Size = new System.Drawing.Size(134, 21);
            this.comboBox_Country.TabIndex = 10;
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Country.Location = new System.Drawing.Point(26, 395);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(104, 30);
            this.label_Country.TabIndex = 4;
            this.label_Country.Text = "Country";
            // 
            // ClientCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(209)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(619, 433);
            this.Controls.Add(this.comboBox_Country);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.textBox_BtcAddress);
            this.Controls.Add(this.textBox_BtcAmount);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_BirthYear);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label_Country);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label_BtcAddress);
            this.Controls.Add(this.label_BtcAmount);
            this.Controls.Add(this.label_Mail);
            this.Controls.Add(this.label_BirthYear);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "ClientCreateForm";
            this.Text = "Create Client";
            this.InputLanguageChanged += new System.Windows.Forms.InputLanguageChangedEventHandler(this.Form_Client_InputLanguageChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_BirthYear;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Label label_BtcAmount;
        private System.Windows.Forms.Label label_BtcAddress;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_BirthYear;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_BtcAmount;
        private System.Windows.Forms.TextBox textBox_BtcAddress;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox_Country;
        private System.Windows.Forms.Label label_Country;
    }
}

