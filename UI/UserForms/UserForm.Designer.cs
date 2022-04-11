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
            this.pictureBox_PowerOff = new System.Windows.Forms.PictureBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Chart = new System.Windows.Forms.Button();
            this.button_Report = new System.Windows.Forms.Button();
            this.button_Coin = new System.Windows.Forms.Button();
            this.button_Trade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PowerOff)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_PowerOff
            // 
            this.pictureBox_PowerOff.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_PowerOff.Image = global::ClientApp.Properties.Resources.power_power_off_power_on_turn_off_turn_on_icon_1892481;
            this.pictureBox_PowerOff.Location = new System.Drawing.Point(426, 10);
            this.pictureBox_PowerOff.Name = "pictureBox_PowerOff";
            this.pictureBox_PowerOff.Size = new System.Drawing.Size(63, 59);
            this.pictureBox_PowerOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_PowerOff.TabIndex = 9;
            this.pictureBox_PowerOff.TabStop = false;
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
            // button_Chart
            // 
            this.button_Chart.BackColor = System.Drawing.Color.Crimson;
            this.button_Chart.FlatAppearance.BorderSize = 0;
            this.button_Chart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Chart.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Chart.ForeColor = System.Drawing.Color.White;
            this.button_Chart.Location = new System.Drawing.Point(247, 196);
            this.button_Chart.Margin = new System.Windows.Forms.Padding(2);
            this.button_Chart.Name = "button_Chart";
            this.button_Chart.Size = new System.Drawing.Size(235, 111);
            this.button_Chart.TabIndex = 4;
            this.button_Chart.Text = "Chart";
            this.button_Chart.UseVisualStyleBackColor = false;
            this.button_Chart.Click += new System.EventHandler(this.button_Chart_Click);
            // 
            // button_Report
            // 
            this.button_Report.BackColor = System.Drawing.Color.Crimson;
            this.button_Report.FlatAppearance.BorderSize = 0;
            this.button_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Report.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Report.ForeColor = System.Drawing.Color.White;
            this.button_Report.Location = new System.Drawing.Point(247, 80);
            this.button_Report.Margin = new System.Windows.Forms.Padding(2);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(235, 113);
            this.button_Report.TabIndex = 5;
            this.button_Report.Text = "Report";
            this.button_Report.UseVisualStyleBackColor = false;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // button_Coin
            // 
            this.button_Coin.BackColor = System.Drawing.Color.Crimson;
            this.button_Coin.FlatAppearance.BorderSize = 0;
            this.button_Coin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Coin.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Coin.ForeColor = System.Drawing.Color.White;
            this.button_Coin.Location = new System.Drawing.Point(8, 196);
            this.button_Coin.Margin = new System.Windows.Forms.Padding(2);
            this.button_Coin.Name = "button_Coin";
            this.button_Coin.Size = new System.Drawing.Size(235, 111);
            this.button_Coin.TabIndex = 6;
            this.button_Coin.Text = "Coin";
            this.button_Coin.UseVisualStyleBackColor = false;
            this.button_Coin.Click += new System.EventHandler(this.button_Coin_Click);
            // 
            // button_Trade
            // 
            this.button_Trade.BackColor = System.Drawing.Color.Crimson;
            this.button_Trade.FlatAppearance.BorderSize = 0;
            this.button_Trade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Trade.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Trade.ForeColor = System.Drawing.Color.White;
            this.button_Trade.Location = new System.Drawing.Point(8, 81);
            this.button_Trade.Margin = new System.Windows.Forms.Padding(2);
            this.button_Trade.Name = "button_Trade";
            this.button_Trade.Size = new System.Drawing.Size(235, 111);
            this.button_Trade.TabIndex = 7;
            this.button_Trade.Text = "Trade";
            this.button_Trade.UseVisualStyleBackColor = false;
            this.button_Trade.Click += new System.EventHandler(this.button_Trade_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(209)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(499, 318);
            this.Controls.Add(this.pictureBox_PowerOff);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Chart);
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.button_Coin);
            this.Controls.Add(this.button_Trade);
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
        private System.Windows.Forms.Button button_Chart;
        private System.Windows.Forms.Button button_Report;
        private System.Windows.Forms.Button button_Coin;
        private System.Windows.Forms.Button button_Trade;
    }
}