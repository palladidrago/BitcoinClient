namespace ClientApp.UI
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.pictureBox_PowerOff = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Trade = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Portfolio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PowerOff)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_PowerOff
            // 
            this.pictureBox_PowerOff.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PowerOff.Image = global::ClientApp.Properties.Resources.power_power_off_power_on_turn_off_turn_on_icon_1892481;
            this.pictureBox_PowerOff.Location = new System.Drawing.Point(380, 248);
            this.pictureBox_PowerOff.Name = "pictureBox_PowerOff";
            this.pictureBox_PowerOff.Size = new System.Drawing.Size(63, 59);
            this.pictureBox_PowerOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_PowerOff.TabIndex = 9;
            this.pictureBox_PowerOff.TabStop = false;
            this.pictureBox_PowerOff.Click += new System.EventHandler(this.pictureBox_PowerOff_Click);
            this.pictureBox_PowerOff.MouseEnter += new System.EventHandler(this.pictureBox_PowerOff_MouseEnter);
            this.pictureBox_PowerOff.MouseLeave += new System.EventHandler(this.pictureBox_PowerOff_MouseLeave);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_Title.Font = new System.Drawing.Font("Spongeboy", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.Black;
            this.label_Title.Location = new System.Drawing.Point(8, 10);
            this.label_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(231, 59);
            this.label_Title.TabIndex = 8;
            this.label_Title.Text = "Welcome,";
            // 
            // button_Trade
            // 
            this.button_Trade.BackColor = System.Drawing.Color.Crimson;
            this.button_Trade.FlatAppearance.BorderSize = 0;
            this.button_Trade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Trade.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Trade.ForeColor = System.Drawing.Color.White;
            this.button_Trade.Location = new System.Drawing.Point(11, 81);
            this.button_Trade.Margin = new System.Windows.Forms.Padding(2);
            this.button_Trade.Name = "button_Trade";
            this.button_Trade.Size = new System.Drawing.Size(214, 107);
            this.button_Trade.TabIndex = 7;
            this.button_Trade.Text = "Trade";
            this.button_Trade.UseVisualStyleBackColor = false;
            this.button_Trade.Click += new System.EventHandler(this.button_Trade_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.Crimson;
            this.button_Update.FlatAppearance.BorderSize = 0;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("Rockwell Nova Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(11, 200);
            this.button_Update.Margin = new System.Windows.Forms.Padding(2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(214, 107);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Update info";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_UpdateInfo_Click);
            // 
            // button_Portfolio
            // 
            this.button_Portfolio.BackColor = System.Drawing.Color.Crimson;
            this.button_Portfolio.FlatAppearance.BorderSize = 0;
            this.button_Portfolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Portfolio.Font = new System.Drawing.Font("Rockwell Nova Cond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Portfolio.ForeColor = System.Drawing.Color.White;
            this.button_Portfolio.Location = new System.Drawing.Point(229, 81);
            this.button_Portfolio.Margin = new System.Windows.Forms.Padding(2);
            this.button_Portfolio.Name = "button_Portfolio";
            this.button_Portfolio.Size = new System.Drawing.Size(214, 107);
            this.button_Portfolio.TabIndex = 10;
            this.button_Portfolio.Text = "Portfolio";
            this.button_Portfolio.UseVisualStyleBackColor = false;
            this.button_Portfolio.Click += new System.EventHandler(this.button_Portfolio_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(209)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(447, 318);
            this.Controls.Add(this.button_Portfolio);
            this.Controls.Add(this.pictureBox_PowerOff);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Trade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Resize += new System.EventHandler(this.UserForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PowerOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_PowerOff;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_Trade;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Portfolio;
    }
}