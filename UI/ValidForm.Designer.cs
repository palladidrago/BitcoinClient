
namespace ClientApp.UI
{
    partial class ValidForm
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
            this.listBox_Valid = new System.Windows.Forms.ListBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Valid = new System.Windows.Forms.Label();
            this.textBox_Valid = new System.Windows.Forms.TextBox();
            this.text_Id = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Valid
            // 
            this.listBox_Valid.FormattingEnabled = true;
            this.listBox_Valid.ItemHeight = 16;
            this.listBox_Valid.Location = new System.Drawing.Point(13, 171);
            this.listBox_Valid.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Valid.Name = "listBox_Valid";
            this.listBox_Valid.Size = new System.Drawing.Size(267, 196);
            this.listBox_Valid.TabIndex = 0;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(13, 12);
            this.label_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(31, 27);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "Id";
            // 
            // label_Valid
            // 
            this.label_Valid.AutoSize = true;
            this.label_Valid.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Valid.Location = new System.Drawing.Point(8, 56);
            this.label_Valid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Valid.Name = "label_Valid";
            this.label_Valid.Size = new System.Drawing.Size(190, 27);
            this.label_Valid.TabIndex = 0;
            this.label_Valid.Text = "Validation Method";
            // 
            // textBox_Valid
            // 
            this.textBox_Valid.Location = new System.Drawing.Point(13, 94);
            this.textBox_Valid.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Valid.Name = "textBox_Valid";
            this.textBox_Valid.Size = new System.Drawing.Size(132, 22);
            this.textBox_Valid.TabIndex = 2;
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(86, 9);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(26, 29);
            this.text_Id.TabIndex = 5;
            this.text_Id.Text = "0";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.LightGreen;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Ubuntu", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.Chocolate;
            this.button_Save.Location = new System.Drawing.Point(320, 12);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(194, 163);
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
            this.button_Delete.Location = new System.Drawing.Point(320, 204);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(194, 163);
            this.button_Delete.TabIndex = 6;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // ValidForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(526, 399);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.textBox_Valid);
            this.Controls.Add(this.label_Valid);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.listBox_Valid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ValidForm";
            this.Text = "Validation method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Valid;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Valid;
        private System.Windows.Forms.TextBox textBox_Valid;
        private System.Windows.Forms.Label text_Id;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Delete;
    }
}