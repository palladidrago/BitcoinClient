
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
            this.SuspendLayout();
            // 
            // listBox_City
            // 
            this.listBox_City.Font = new System.Drawing.Font("Gisha", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_City.FormattingEnabled = true;
            this.listBox_City.ItemHeight = 24;
            this.listBox_City.Location = new System.Drawing.Point(12, 12);
            this.listBox_City.Name = "listBox_City";
            this.listBox_City.Size = new System.Drawing.Size(291, 148);
            this.listBox_City.TabIndex = 0;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(355, 57);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(28, 25);
            this.label_Id.TabIndex = 1;
            this.label_Id.Text = "Id";
            // 
            // text_Id
            // 
            this.text_Id.AutoSize = true;
            this.text_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Id.Location = new System.Drawing.Point(412, 57);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(159, 25);
            this.text_Id.TabIndex = 2;
            this.text_Id.Text = "PLACEHOLDER";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(355, 102);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(70, 25);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "Name:";
            // 
            // CityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}