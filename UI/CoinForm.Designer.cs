﻿
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
            this.id_Text = new System.Windows.Forms.Label();
            this.comboBox_Filter_Valid = new System.Windows.Forms.ComboBox();
            this.comboBox_Filter_Scam = new System.Windows.Forms.ComboBox();
            this.label_Filter_Valid = new System.Windows.Forms.Label();
            this.label_Filter_Scam = new System.Windows.Forms.Label();
            this.label_Filter_Id = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Scam = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Valid = new System.Windows.Forms.Label();
            this.label_Symbol = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Symbol = new System.Windows.Forms.TextBox();
            this.comboBox_Valid = new System.Windows.Forms.ComboBox();
            this.comboBox_Scam = new System.Windows.Forms.ComboBox();
            this.text_Id = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_ = new System.Windows.Forms.Button();
            this.groupBox_Filter.SuspendLayout();
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
            // 
            // groupBox_Filter
            // 
            this.groupBox_Filter.Controls.Add(this.id_Text);
            this.groupBox_Filter.Controls.Add(this.comboBox_Filter_Valid);
            this.groupBox_Filter.Controls.Add(this.comboBox_Filter_Scam);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Valid);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Scam);
            this.groupBox_Filter.Controls.Add(this.label_Filter_Id);
            this.groupBox_Filter.Location = new System.Drawing.Point(16, 20);
            this.groupBox_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_Filter.Name = "groupBox_Filter";
            this.groupBox_Filter.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_Filter.Size = new System.Drawing.Size(364, 160);
            this.groupBox_Filter.TabIndex = 1;
            this.groupBox_Filter.TabStop = false;
            this.groupBox_Filter.Text = "Filter";
            // 
            // id_Text
            // 
            this.id_Text.AutoSize = true;
            this.id_Text.Location = new System.Drawing.Point(188, 46);
            this.id_Text.Name = "id_Text";
            this.id_Text.Size = new System.Drawing.Size(14, 16);
            this.id_Text.TabIndex = 1;
            this.id_Text.Text = "0";
            // 
            // comboBox_Filter_Valid
            // 
            this.comboBox_Filter_Valid.FormattingEnabled = true;
            this.comboBox_Filter_Valid.Location = new System.Drawing.Point(188, 71);
            this.comboBox_Filter_Valid.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Filter_Valid.Name = "comboBox_Filter_Valid";
            this.comboBox_Filter_Valid.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Filter_Valid.TabIndex = 0;
            // 
            // comboBox_Filter_Scam
            // 
            this.comboBox_Filter_Scam.FormattingEnabled = true;
            this.comboBox_Filter_Scam.Location = new System.Drawing.Point(188, 112);
            this.comboBox_Filter_Scam.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Filter_Scam.Name = "comboBox_Filter_Scam";
            this.comboBox_Filter_Scam.Size = new System.Drawing.Size(160, 24);
            this.comboBox_Filter_Scam.TabIndex = 0;
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
            // label_Filter_Id
            // 
            this.label_Filter_Id.AutoSize = true;
            this.label_Filter_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Filter_Id.Location = new System.Drawing.Point(8, 38);
            this.label_Filter_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Filter_Id.Name = "label_Filter_Id";
            this.label_Filter_Id.Size = new System.Drawing.Size(28, 25);
            this.label_Filter_Id.TabIndex = 0;
            this.label_Filter_Id.Text = "Id";
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
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(411, 47);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(64, 25);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name";
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
            this.comboBox_Valid.Size = new System.Drawing.Size(160, 24);
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
            // button_
            // 
            this.button_.Location = new System.Drawing.Point(773, 132);
            this.button_.Name = "button_";
            this.button_.Size = new System.Drawing.Size(33, 23);
            this.button_.TabIndex = 7;
            this.button_.Text = "button1";
            this.button_.UseVisualStyleBackColor = true;
            // 
            // CoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 399);
            this.Controls.Add(this.button_);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.comboBox_Scam);
            this.Controls.Add(this.comboBox_Valid);
            this.Controls.Add(this.textBox_Symbol);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Symbol);
            this.Controls.Add(this.label_Name);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Coins;
        private System.Windows.Forms.GroupBox groupBox_Filter;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Scam;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Valid;
        private System.Windows.Forms.Label label_Symbol;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Symbol;
        private System.Windows.Forms.ComboBox comboBox_Filter_Valid;
        private System.Windows.Forms.ComboBox comboBox_Filter_Scam;
        private System.Windows.Forms.Label label_Filter_Valid;
        private System.Windows.Forms.Label label_Filter_Scam;
        private System.Windows.Forms.Label label_Filter_Id;
        private System.Windows.Forms.ComboBox comboBox_Valid;
        private System.Windows.Forms.ComboBox comboBox_Scam;
        private System.Windows.Forms.Label id_Text;
        private System.Windows.Forms.Label text_Id;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_;
    }
}