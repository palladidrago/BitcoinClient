
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
            this.label_Count = new System.Windows.Forms.Label();
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
            this.numericUpDown_Count = new System.Windows.Forms.NumericUpDown();
            this.label_Name = new System.Windows.Forms.Label();
            this.groupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Coins
            // 
            this.listBox_Coins.FormattingEnabled = true;
            this.listBox_Coins.ItemHeight = 16;
            this.listBox_Coins.Location = new System.Drawing.Point(16, 187);
            this.listBox_Coins.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Coins.Name = "listBox_Coins";
            this.listBox_Coins.Size = new System.Drawing.Size(304, 196);
            this.listBox_Coins.TabIndex = 0;
            this.listBox_Coins.DoubleClick += new System.EventHandler(this.listBox_Coins_DoubleClick);
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.textBox_Filter_Name);
            this.groupBox_Filter.Controls.Add(this.comboBox_Filter_Valid);
            this.groupBox_Filter.Controls.Add(this.comboBox_Filter_Scam);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Valid);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Scam);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Name);
            this.groupBox_Filter.Location = new System.Drawing.Point(16, 20);
            this.groupBox_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Filter.Size = new System.Drawing.Size(364, 160);
            this.groupBox_Filter.TabIndex = 1;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // textBox_Filter_Name
            // 
            this.textBox_Filter_Name.Location = new System.Drawing.Point(188, 38);
            this.textBox_Filter_Name.Name = "textBox_Filter_Name";
            this.textBox_Filter_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Filter_Name.TabIndex = 2;
            this.textBox_Filter_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Filter_KeyUp);
            // 
            // comboBox_Filter_Valid
            // 
            this.comboBox_Filter_Valid.FormattingEnabled = true;
            this.comboBox_Filter_Valid.Location = new System.Drawing.Point(188, 71);
            this.comboBox_Filter_Valid.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Filter_Valid.Name = "comboBox_Filter_Valid";
            this.comboBox_Filter_Valid.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Filter_Valid.TabIndex = 0;
            this.comboBox_Filter_Valid.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_Valid_SelectedIndexChanged);
            // 
            // comboBox_Filter_Scam
            // 
            this.comboBox_Filter_Scam.FormattingEnabled = true;
            this.comboBox_Filter_Scam.Location = new System.Drawing.Point(188, 112);
            this.comboBox_Filter_Scam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Filter_Scam.Name = "comboBox_Filter_Scam";
            this.comboBox_Filter_Scam.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Filter_Scam.TabIndex = 0;
            this.comboBox_Filter_Scam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filter_Scam_SelectedIndexChanged);
            // 
            // label_Filter_Valid
            // 
            this.label_Filter_Valid.AutoSize = true;
            this.label_Filter_Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Valid.Location = new System.Drawing.Point(8, 73);
            this.label_Filter_Valid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Filter_Valid.Name = "label_Filter_Valid";
            this.label_Filter_Valid.Size = new System.Drawing.Size(165, 25);
            this.label_Filter_Valid.TabIndex = 0;
            this.label_Filter_Valid.Text = "Validation system";
            // 
            // label_Filter_Scam
            // 
            this.label_Filter_Scam.AutoSize = true;
            this.label_Filter_Scam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Scam.Location = new System.Drawing.Point(8, 117);
            this.label_Filter_Scam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Filter_Scam.Name = "label_Filter_Scam";
            this.label_Filter_Scam.Size = new System.Drawing.Size(115, 25);
            this.label_Filter_Scam.TabIndex = 0;
            this.label_Filter_Scam.Text = "Scam Level";
            // 
            // label_Filter_Name
            // 
            this.label_Filter_Name.AutoSize = true;
            this.label_Filter_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Name.Location = new System.Drawing.Point(8, 38);
            this.label_Filter_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Filter_Name.Name = "label_Filter_Name";
            this.label_Filter_Name.Size = new System.Drawing.Size(64, 25);
            this.label_Filter_Name.TabIndex = 0;
            this.label_Filter_Name.Text = "Name";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(411, 11);
            this.label_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(28, 25);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "Id";
            // 
            // label_Scam
            // 
            this.label_Scam.AutoSize = true;
            this.label_Scam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Scam.Location = new System.Drawing.Point(411, 174);
            this.label_Scam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Scam.Name = "label_Scam";
            this.label_Scam.Size = new System.Drawing.Size(115, 25);
            this.label_Scam.TabIndex = 0;
            this.label_Scam.Text = "Scam Level";
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Count.Location = new System.Drawing.Point(636, 15);
            this.label_Count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(65, 25);
            this.label_Count.TabIndex = 0;
            this.label_Count.Text = "Count";
            // 
            // label_Valid
            // 
            this.label_Valid.AutoSize = true;
            this.label_Valid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Valid.Location = new System.Drawing.Point(411, 129);
            this.label_Valid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Valid.Name = "label_Valid";
            this.label_Valid.Size = new System.Drawing.Size(165, 25);
            this.label_Valid.TabIndex = 0;
            this.label_Valid.Text = "Validation system";
            // 
            // label_Symbol
            // 
            this.label_Symbol.AutoSize = true;
            this.label_Symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Symbol.Location = new System.Drawing.Point(411, 86);
            this.label_Symbol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Symbol.Name = "label_Symbol";
            this.label_Symbol.Size = new System.Drawing.Size(78, 25);
            this.label_Symbol.TabIndex = 0;
            this.label_Symbol.Text = "Symbol";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(503, 47);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(132, 22);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_Symbol
            // 
            this.textBox_Symbol.Location = new System.Drawing.Point(503, 86);
            this.textBox_Symbol.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Symbol.Name = "textBox_Symbol";
            this.textBox_Symbol.Size = new System.Drawing.Size(132, 22);
            this.textBox_Symbol.TabIndex = 2;
            // 
            // comboBox_Valid
            // 
            this.comboBox_Valid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Valid.FormattingEnabled = true;
            this.comboBox_Valid.Location = new System.Drawing.Point(596, 132);
            this.comboBox_Valid.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Valid.Name = "comboBox_Valid";
            this.comboBox_Valid.Size = new System.Drawing.Size(210, 24);
            this.comboBox_Valid.TabIndex = 4;
            // 
            // comboBox_Scam
            // 
            this.comboBox_Scam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Scam.FormattingEnabled = true;
            this.comboBox_Scam.Location = new System.Drawing.Point(540, 176);
            this.comboBox_Scam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Scam.Name = "comboBox_Scam";
            this.comboBox_Scam.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Scam.TabIndex = 4;
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Location = new System.Drawing.Point(503, 20);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(14, 16);
            this.text_Id.TabIndex = 5;
            this.text_Id.Text = "0";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.LightGreen;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Ubuntu", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.Chocolate;
            this.button_Save.Location = new System.Drawing.Point(416, 224);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(188, 163);
            this.button_Save.TabIndex = 6;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Tomato;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Delete.Font = new System.Drawing.Font("Ubuntu", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.SpringGreen;
            this.button_Delete.Location = new System.Drawing.Point(619, 224);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(187, 163);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_AddValid
            // 
            this.button_AddValid.AutoSize = true;
            this.button_AddValid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_AddValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddValid.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddValid.Location = new System.Drawing.Point(814, 129);
            this.button_AddValid.Name = "button_AddValid";
            this.button_AddValid.Size = new System.Drawing.Size(30, 32);
            this.button_AddValid.TabIndex = 8;
            this.button_AddValid.Text = "+";
            this.button_AddValid.Click += new System.EventHandler(this.button_AddValid_Click);
            // 
            // button_AddScam
            // 
            this.button_AddScam.AutoSize = true;
            this.button_AddScam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_AddScam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddScam.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_AddScam.Location = new System.Drawing.Point(707, 174);
            this.button_AddScam.Name = "button_AddScam";
            this.button_AddScam.Size = new System.Drawing.Size(30, 32);
            this.button_AddScam.TabIndex = 9;
            this.button_AddScam.Text = "+";
            // 
            // numericUpDown_Count
            // 
            this.numericUpDown_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Count.Location = new System.Drawing.Point(713, 15);
            this.numericUpDown_Count.Maximum = new decimal(new int[] {
            2100000000,
            0,
            0,
            0});
            this.numericUpDown_Count.Name = "numericUpDown_Count";
            this.numericUpDown_Count.Size = new System.Drawing.Size(120, 30);
            this.numericUpDown_Count.TabIndex = 10;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(411, 44);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(64, 25);
            this.label_Name.TabIndex = 11;
            this.label_Name.Text = "Name";
            // 
            // CoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 399);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.numericUpDown_Count);
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
            this.Controls.Add(this.label_Count);
            this.Controls.Add(this.label_Valid);
            this.Controls.Add(this.label_Scam);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.groupBox_Filter);
            this.Controls.Add(this.listBox_Coins);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CoinForm";
            this.Text = "Coin";
            this.groupBox_Filter.ResumeLayout(false);
            this.groupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Coins;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Scam;
        private System.Windows.Forms.Label label_Count;
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
        private System.Windows.Forms.NumericUpDown numericUpDown_Count;
        private System.Windows.Forms.Label label_Name;
    }
}