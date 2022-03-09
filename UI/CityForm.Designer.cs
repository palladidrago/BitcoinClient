
namespace ClientApp.UI
{
    partial class CityForm
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
            this.listBox_City = new System.Windows.Forms.ListBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_City
            // 
            this.listBox_City.Font = new System.Drawing.Font("Gisha", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_City.FormattingEnabled = true;
            this.listBox_City.ItemHeight = 24;
            this.listBox_City.Location = new System.Drawing.Point(12, 12);
            this.listBox_City.Name = "listBox_City";
            this.listBox_City.Size = new System.Drawing.Size(287, 196);
            this.listBox_City.TabIndex = 0;
            this.listBox_City.Click += new System.EventHandler(this.listBox_City_Click);
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(316, 12);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(28, 25);
            this.label_Id.TabIndex = 1;
            this.label_Id.Text = "Id";
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(373, 12);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(0, 25);
            this.text_Id.TabIndex = 2;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(316, 57);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(70, 25);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Name:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(402, 57);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 4;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.Location = new System.Drawing.Point(457, 97);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(65, 55);
            this.button_Delete.TabIndex = 5;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(458, 158);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(64, 55);
            this.button_Clear.TabIndex = 5;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.Lime;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(321, 97);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(131, 116);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Update/Add";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 225);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.listBox_City);
            this.Name = "CityForm";
            this.Text = "City Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_City;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label text_Id;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Update;
    }
}