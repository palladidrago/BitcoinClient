
namespace ClientApp.UI
{
    partial class ScamForm
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
            this.listBox_Scam = new System.Windows.Forms.ListBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Scam = new System.Windows.Forms.Label();
            this.textBox_Scam = new System.Windows.Forms.TextBox();
            this.text_Id = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Scam
            // 
            this.listBox_Scam.FormattingEnabled = true;
            this.listBox_Scam.ItemHeight = 16;
            this.listBox_Scam.Location = new System.Drawing.Point(13, 171);
            this.listBox_Scam.Margin = new System.Windows.Forms.Padding(4);
            this.listBox_Scam.Name = "listBox_Scam";
            this.listBox_Scam.Size = new System.Drawing.Size(267, 196);
            this.listBox_Scam.TabIndex = 0;
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
            // label_Scam
            // 
            this.label_Scam.AutoSize = true;
            this.label_Scam.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Scam.Location = new System.Drawing.Point(8, 56);
            this.label_Scam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Scam.Name = "label_Scam";
            this.label_Scam.Size = new System.Drawing.Size(120, 27);
            this.label_Scam.TabIndex = 0;
            this.label_Scam.Text = "Scam Level";
            // 
            // textBox_Scam
            // 
            this.textBox_Scam.Location = new System.Drawing.Point(13, 94);
            this.textBox_Scam.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Scam.Name = "textBox_Scam";
            this.textBox_Scam.Size = new System.Drawing.Size(132, 22);
            this.textBox_Scam.TabIndex = 2;
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
            // ScamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(526, 399);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.textBox_Scam);
            this.Controls.Add(this.label_Scam);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.listBox_Scam);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ScamForm";
            this.Text = "Scam level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Scam;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Scam;
        private System.Windows.Forms.TextBox textBox_Scam;
        private System.Windows.Forms.Label text_Id;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Delete;
    }
}