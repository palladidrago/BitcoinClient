
namespace ClientApp.UI
{
    partial class CoinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinForm));
            this.listBox_Coins = new System.Windows.Forms.ListBox();
            this.groupBox_Filter = new System.Windows.Forms.GroupBox();
            this.textBox_Filter_Name = new System.Windows.Forms.TextBox();
            this.comboBox_Filter_Valid = new System.Windows.Forms.ComboBox();
            this.comboBox_Filter_Scam = new System.Windows.Forms.ComboBox();
            this.label_Filter_Valid = new System.Windows.Forms.Label();
            this.label_Filter_Scam = new System.Windows.Forms.Label();
            this.label_Filter_Name = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Scam = new System.Windows.Forms.Label();
            this.label_Supply = new System.Windows.Forms.Label();
            this.label_Valid = new System.Windows.Forms.Label();
            this.label_Symbol = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Symbol = new System.Windows.Forms.TextBox();
            this.comboBox_Valid = new System.Windows.Forms.ComboBox();
            this.comboBox_Scam = new System.Windows.Forms.ComboBox();
            this.text_Id = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_AddValid = new System.Windows.Forms.Label();
            this.button_AddScam = new System.Windows.Forms.Label();
            this.numericUpDown_Supply = new System.Windows.Forms.NumericUpDown();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_FetchCoinPrice = new System.Windows.Forms.Button();
            this.groupBox_PriceInfo = new System.Windows.Forms.GroupBox();
            this.label_PercentChanged = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_MarketCap = new System.Windows.Forms.Label();
            this.text_Price = new System.Windows.Forms.Label();
            this.text_PercentChanged = new System.Windows.Forms.Label();
            this.text_Volume = new System.Windows.Forms.Label();
            this.text_MarketCap = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.groupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Supply)).BeginInit();
            this.groupBox_PriceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Coins
            // 
            this.listBox_Coins.FormattingEnabled = true;
            this.listBox_Coins.ItemHeight = 21;
            this.listBox_Coins.Location = new System.Drawing.Point(21, 212);
            this.listBox_Coins.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.listBox_Coins.Name = "listBox_Coins";
            this.listBox_Coins.Size = new System.Drawing.Size(397, 403);
            this.listBox_Coins.TabIndex = 0;
            this.listBox_Coins.SelectedIndexChanged += new System.EventHandler(this.listBox_Coins_SelectedIndexChanged);
            this.listBox_Coins.DoubleClick += new System.EventHandler(this.listBox_Coins_DoubleClick);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_Name);
            this.groupBox_Filter.Controls.Add(this.comboBox_Filter_Valid);
            this.groupBox_Filter.Controls.Add(this.comboBox_Filter_Scam);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Valid);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Scam);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Name);
            this.groupBox_Filter.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Filter.Location = new System.Drawing.Point(20, 16);
            this.groupBox_Filter.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox_Filter.Size = new System.Drawing.Size(512, 171);
            this.groupBox_Filter.TabIndex = 1;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // textBox_Filter_Name
            // 
            this.textBox_Filter_Name.Location = new System.Drawing.Point(290, 46);
            this.textBox_Filter_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Filter_Name.Name = "textBox_Filter_Name";
            this.textBox_Filter_Name.Size = new System.Drawing.Size(130, 24);
            this.textBox_Filter_Name.TabIndex = 2;
            this.textBox_Filter_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // comboBox_Filter_Valid
            // 
            this.comboBox_Filter_Valid.FormattingEnabled = true;
            this.comboBox_Filter_Valid.Location = new System.Drawing.Point(290, 84);
            this.comboBox_Filter_Valid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBox_Filter_Valid.Name = "comboBox_Filter_Valid";
            this.comboBox_Filter_Valid.Size = new System.Drawing.Size(208, 27);
            this.comboBox_Filter_Valid.TabIndex = 0;
            this.comboBox_Filter_Valid.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_Valid_SelectedIndexChanged);
            // 
            // comboBox_Filter_Scam
            // 
            this.comboBox_Filter_Scam.FormattingEnabled = true;
            this.comboBox_Filter_Scam.Location = new System.Drawing.Point(290, 126);
            this.comboBox_Filter_Scam.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBox_Filter_Scam.Name = "comboBox_Filter_Scam";
            this.comboBox_Filter_Scam.Size = new System.Drawing.Size(208, 27);
            this.comboBox_Filter_Scam.TabIndex = 0;
            this.comboBox_Filter_Scam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_Scam_SelectedIndexChanged);
            // 
            // label_Filter_Valid
            // 
            this.label_Filter_Valid.AutoSize = true;
            this.label_Filter_Valid.BackColor = System.Drawing.Color.Transparent;
            this.label_Filter_Valid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Valid.ForeColor = System.Drawing.Color.White;
            this.label_Filter_Valid.Location = new System.Drawing.Point(10, 88);
            this.label_Filter_Valid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Filter_Valid.Name = "label_Filter_Valid";
            this.label_Filter_Valid.Size = new System.Drawing.Size(146, 21);
            this.label_Filter_Valid.TabIndex = 0;
            this.label_Filter_Valid.Text = "Validation system";
            // 
            // label_Filter_Scam
            // 
            this.label_Filter_Scam.AutoSize = true;
            this.label_Filter_Scam.BackColor = System.Drawing.Color.Transparent;
            this.label_Filter_Scam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Scam.ForeColor = System.Drawing.Color.White;
            this.label_Filter_Scam.Location = new System.Drawing.Point(10, 128);
            this.label_Filter_Scam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Filter_Scam.Name = "label_Filter_Scam";
            this.label_Filter_Scam.Size = new System.Drawing.Size(98, 21);
            this.label_Filter_Scam.TabIndex = 0;
            this.label_Filter_Scam.Text = "Scam Level";
            // 
            // label_Filter_Name
            // 
            this.label_Filter_Name.AutoSize = true;
            this.label_Filter_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Filter_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Name.ForeColor = System.Drawing.Color.White;
            this.label_Filter_Name.Location = new System.Drawing.Point(10, 46);
            this.label_Filter_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Filter_Name.Name = "label_Filter_Name";
            this.label_Filter_Name.Size = new System.Drawing.Size(58, 21);
            this.label_Filter_Name.TabIndex = 0;
            this.label_Filter_Name.Text = "Name";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(694, 43);
            this.label_Id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(29, 24);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "Id";
            // 
            // label_Scam
            // 
            this.label_Scam.AutoSize = true;
            this.label_Scam.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Scam.Location = new System.Drawing.Point(599, 210);
            this.label_Scam.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Scam.Name = "label_Scam";
            this.label_Scam.Size = new System.Drawing.Size(131, 24);
            this.label_Scam.TabIndex = 0;
            this.label_Scam.Text = "Scam Level";
            // 
            // label_Supply
            // 
            this.label_Supply.AutoSize = true;
            this.label_Supply.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Supply.Location = new System.Drawing.Point(653, 252);
            this.label_Supply.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Supply.Name = "label_Supply";
            this.label_Supply.Size = new System.Drawing.Size(77, 24);
            this.label_Supply.TabIndex = 0;
            this.label_Supply.Text = "Supply";
            // 
            // label_Valid
            // 
            this.label_Valid.AutoSize = true;
            this.label_Valid.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Valid.Location = new System.Drawing.Point(543, 163);
            this.label_Valid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Valid.Name = "label_Valid";
            this.label_Valid.Size = new System.Drawing.Size(187, 24);
            this.label_Valid.TabIndex = 0;
            this.label_Valid.Text = "Validation system";
            // 
            // label_Symbol
            // 
            this.label_Symbol.AutoSize = true;
            this.label_Symbol.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Symbol.Location = new System.Drawing.Point(637, 121);
            this.label_Symbol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Symbol.Name = "label_Symbol";
            this.label_Symbol.Size = new System.Drawing.Size(85, 24);
            this.label_Symbol.TabIndex = 0;
            this.label_Symbol.Text = "Symbol";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(734, 81);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(172, 27);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_Symbol
            // 
            this.textBox_Symbol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Symbol.Location = new System.Drawing.Point(734, 121);
            this.textBox_Symbol.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBox_Symbol.Name = "textBox_Symbol";
            this.textBox_Symbol.Size = new System.Drawing.Size(172, 27);
            this.textBox_Symbol.TabIndex = 2;
            // 
            // comboBox_Valid
            // 
            this.comboBox_Valid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Valid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Valid.FormattingEnabled = true;
            this.comboBox_Valid.Location = new System.Drawing.Point(734, 158);
            this.comboBox_Valid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBox_Valid.Name = "comboBox_Valid";
            this.comboBox_Valid.Size = new System.Drawing.Size(274, 29);
            this.comboBox_Valid.TabIndex = 4;
            // 
            // comboBox_Scam
            // 
            this.comboBox_Scam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Scam.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Scam.FormattingEnabled = true;
            this.comboBox_Scam.Location = new System.Drawing.Point(734, 205);
            this.comboBox_Scam.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.comboBox_Scam.Name = "comboBox_Scam";
            this.comboBox_Scam.Size = new System.Drawing.Size(242, 29);
            this.comboBox_Scam.TabIndex = 4;
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(732, 43);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(24, 25);
            this.text_Id.TabIndex = 5;
            this.text_Id.Text = "0";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Crimson;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Ubuntu", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.Bisque;
            this.button_Save.Location = new System.Drawing.Point(429, 301);
            this.button_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(244, 107);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Bisque;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Delete.Font = new System.Drawing.Font("Ubuntu", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.Crimson;
            this.button_Delete.Location = new System.Drawing.Point(429, 425);
            this.button_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(244, 107);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_AddValid
            // 
            this.button_AddValid.AutoSize = true;
            this.button_AddValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_AddValid.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddValid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddValid.Location = new System.Drawing.Point(1017, 159);
            this.button_AddValid.Name = "button_AddValid";
            this.button_AddValid.Size = new System.Drawing.Size(21, 22);
            this.button_AddValid.TabIndex = 8;
            this.button_AddValid.Text = "+";
            this.button_AddValid.Click += new System.EventHandler(this.button_AddValid_Click);
            // 
            // button_AddScam
            // 
            this.button_AddScam.AutoSize = true;
            this.button_AddScam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_AddScam.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddScam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddScam.Location = new System.Drawing.Point(986, 208);
            this.button_AddScam.Name = "button_AddScam";
            this.button_AddScam.Size = new System.Drawing.Size(21, 23);
            this.button_AddScam.TabIndex = 9;
            this.button_AddScam.Text = "+";
            this.button_AddScam.Click += new System.EventHandler(this.button_AddScam_Click);
            // 
            // numericUpDown_Supply
            // 
            this.numericUpDown_Supply.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Supply.Location = new System.Drawing.Point(734, 250);
            this.numericUpDown_Supply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown_Supply.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numericUpDown_Supply.Name = "numericUpDown_Supply";
            this.numericUpDown_Supply.Size = new System.Drawing.Size(232, 33);
            this.numericUpDown_Supply.TabIndex = 10;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(648, 81);
            this.label_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(75, 24);
            this.label_Name.TabIndex = 11;
            this.label_Name.Text = "Name";
            // 
            // button_FetchCoinPrice
            // 
            this.button_FetchCoinPrice.BackColor = System.Drawing.Color.BurlyWood;
            this.button_FetchCoinPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FetchCoinPrice.Font = new System.Drawing.Font("Ubuntu", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FetchCoinPrice.Location = new System.Drawing.Point(430, 540);
            this.button_FetchCoinPrice.Margin = new System.Windows.Forms.Padding(4);
            this.button_FetchCoinPrice.Name = "button_FetchCoinPrice";
            this.button_FetchCoinPrice.Size = new System.Drawing.Size(243, 56);
            this.button_FetchCoinPrice.TabIndex = 13;
            this.button_FetchCoinPrice.Text = "Fetch coin price";
            this.button_FetchCoinPrice.UseVisualStyleBackColor = false;
            this.button_FetchCoinPrice.Click += new System.EventHandler(this.button_FetchPriceInfo_Click);
            // 
            // groupBox_PriceInfo
            // 
            this.groupBox_PriceInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.groupBox_PriceInfo.Controls.Add(this.label_PercentChanged);
            this.groupBox_PriceInfo.Controls.Add(this.label2);
            this.groupBox_PriceInfo.Controls.Add(this.label_MarketCap);
            this.groupBox_PriceInfo.Controls.Add(this.text_Price);
            this.groupBox_PriceInfo.Controls.Add(this.text_PercentChanged);
            this.groupBox_PriceInfo.Controls.Add(this.text_Volume);
            this.groupBox_PriceInfo.Controls.Add(this.text_MarketCap);
            this.groupBox_PriceInfo.Controls.Add(this.label_Price);
            this.groupBox_PriceInfo.ForeColor = System.Drawing.Color.White;
            this.groupBox_PriceInfo.Location = new System.Drawing.Point(699, 301);
            this.groupBox_PriceInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_PriceInfo.Name = "groupBox_PriceInfo";
            this.groupBox_PriceInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_PriceInfo.Size = new System.Drawing.Size(367, 312);
            this.groupBox_PriceInfo.TabIndex = 14;
            this.groupBox_PriceInfo.TabStop = false;
            this.groupBox_PriceInfo.Text = "Price info";
            // 
            // label_PercentChanged
            // 
            this.label_PercentChanged.AutoSize = true;
            this.label_PercentChanged.BackColor = System.Drawing.Color.Transparent;
            this.label_PercentChanged.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PercentChanged.Location = new System.Drawing.Point(14, 271);
            this.label_PercentChanged.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_PercentChanged.Name = "label_PercentChanged";
            this.label_PercentChanged.Size = new System.Drawing.Size(195, 24);
            this.label_PercentChanged.TabIndex = 0;
            this.label_PercentChanged.Text = "Percent Changed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Volume 24H";
            // 
            // label_MarketCap
            // 
            this.label_MarketCap.AutoSize = true;
            this.label_MarketCap.BackColor = System.Drawing.Color.Transparent;
            this.label_MarketCap.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MarketCap.Location = new System.Drawing.Point(14, 124);
            this.label_MarketCap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_MarketCap.Name = "label_MarketCap";
            this.label_MarketCap.Size = new System.Drawing.Size(132, 24);
            this.label_MarketCap.TabIndex = 0;
            this.label_MarketCap.Text = "Market Cap";
            // 
            // text_Price
            // 
            this.text_Price.AutoSize = true;
            this.text_Price.BackColor = System.Drawing.Color.Transparent;
            this.text_Price.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Price.Location = new System.Drawing.Point(99, 47);
            this.text_Price.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(0, 24);
            this.text_Price.TabIndex = 0;
            // 
            // text_PercentChanged
            // 
            this.text_PercentChanged.AutoSize = true;
            this.text_PercentChanged.BackColor = System.Drawing.Color.Transparent;
            this.text_PercentChanged.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_PercentChanged.Location = new System.Drawing.Point(221, 270);
            this.text_PercentChanged.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.text_PercentChanged.Name = "text_PercentChanged";
            this.text_PercentChanged.Size = new System.Drawing.Size(0, 24);
            this.text_PercentChanged.TabIndex = 0;
            // 
            // text_Volume
            // 
            this.text_Volume.AutoSize = true;
            this.text_Volume.BackColor = System.Drawing.Color.Transparent;
            this.text_Volume.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Volume.Location = new System.Drawing.Point(162, 198);
            this.text_Volume.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.text_Volume.Name = "text_Volume";
            this.text_Volume.Size = new System.Drawing.Size(0, 24);
            this.text_Volume.TabIndex = 0;
            // 
            // text_MarketCap
            // 
            this.text_MarketCap.AutoSize = true;
            this.text_MarketCap.BackColor = System.Drawing.Color.Transparent;
            this.text_MarketCap.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_MarketCap.Location = new System.Drawing.Point(162, 124);
            this.text_MarketCap.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.text_MarketCap.Name = "text_MarketCap";
            this.text_MarketCap.Size = new System.Drawing.Size(0, 24);
            this.text_MarketCap.TabIndex = 0;
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.BackColor = System.Drawing.Color.Transparent;
            this.label_Price.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Price.Location = new System.Drawing.Point(10, 47);
            this.label_Price.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(59, 24);
            this.label_Price.TabIndex = 0;
            this.label_Price.Text = "Price";
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Location = new System.Drawing.Point(430, 218);
            this.pictureBox_Logo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(100, 77);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 12;
            this.pictureBox_Logo.TabStop = false;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.White;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Ubuntu", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.ForeColor = System.Drawing.Color.Black;
            this.button_Clear.Location = new System.Drawing.Point(948, 11);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(121, 56);
            this.button_Clear.TabIndex = 13;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // CoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1082, 635);
            this.Controls.Add(this.groupBox_PriceInfo);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_FetchCoinPrice);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.numericUpDown_Supply);
            this.Controls.Add(this.button_AddScam);
            this.Controls.Add(this.button_AddValid);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.comboBox_Scam);
            this.Controls.Add(this.comboBox_Valid);
            this.Controls.Add(this.textBox_Symbol);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Symbol);
            this.Controls.Add(this.label_Supply);
            this.Controls.Add(this.label_Valid);
            this.Controls.Add(this.label_Scam);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.listBox_Coins);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "CoinForm";
            this.Text = "Coin";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Supply)).EndInit();
            this.groupBox_PriceInfo.ResumeLayout(false);
            this.groupBox_PriceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Coins;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Scam;
        private System.Windows.Forms.Label label_Supply;
        private System.Windows.Forms.Label label_Valid;
        private System.Windows.Forms.Label label_Symbol;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Symbol;
        private System.Windows.Forms.ComboBox comboBox_Filter_Valid;
        private System.Windows.Forms.ComboBox comboBox_Filter_Scam;
        private System.Windows.Forms.Label label_Filter_Valid;
        private System.Windows.Forms.Label label_Filter_Scam;
        private System.Windows.Forms.Label label_Filter_Name;
        private System.Windows.Forms.ComboBox comboBox_Valid;
        private System.Windows.Forms.ComboBox comboBox_Scam;
        private System.Windows.Forms.Label text_Id;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label button_AddValid;
        private System.Windows.Forms.Label button_AddScam;
        private System.Windows.Forms.TextBox textBox_Filter_Name;
        private System.Windows.Forms.NumericUpDown numericUpDown_Supply;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Button button_FetchCoinPrice;
        private System.Windows.Forms.GroupBox groupBox_PriceInfo;
        private System.Windows.Forms.Label label_PercentChanged;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_MarketCap;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.Label text_Price;
        private System.Windows.Forms.Label text_PercentChanged;
        private System.Windows.Forms.Label text_Volume;
        private System.Windows.Forms.Label text_MarketCap;
        private System.Windows.Forms.Button button_Clear;
    }
}