
namespace ClientApp
{
    partial class BeginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeginForm));
            this.button_Trade = new System.Windows.Forms.Button();
            this.button_City = new System.Windows.Forms.Button();
            this.button_Client = new System.Windows.Forms.Button();
            this.button_Coin = new System.Windows.Forms.Button();
            this.button_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Trade
            // 
            this.button_Trade.BackColor = System.Drawing.Color.Transparent;
            this.button_Trade.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Trade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Trade.Location = new System.Drawing.Point(414, 234);
            this.button_Trade.Name = "button_Trade";
            this.button_Trade.Size = new System.Drawing.Size(400, 233);
            this.button_Trade.TabIndex = 0;
            this.button_Trade.Text = "Trade Form";
            this.button_Trade.UseVisualStyleBackColor = false;
            this.button_Trade.Click += new System.EventHandler(this.button_Trade_Click);
            // 
            // button_City
            // 
            this.button_City.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_City.Location = new System.Drawing.Point(414, 8);
            this.button_City.Name = "button_City";
            this.button_City.Size = new System.Drawing.Size(400, 220);
            this.button_City.TabIndex = 0;
            this.button_City.Text = "City Form";
            this.button_City.UseVisualStyleBackColor = true;
            this.button_City.Click += new System.EventHandler(this.button_City_Click);
            // 
            // button_Client
            // 
            this.button_Client.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Client.Location = new System.Drawing.Point(8, 8);
            this.button_Client.Name = "button_Client";
            this.button_Client.Size = new System.Drawing.Size(400, 220);
            this.button_Client.TabIndex = 0;
            this.button_Client.Text = "Client Form";
            this.button_Client.UseVisualStyleBackColor = true;
            this.button_Client.Click += new System.EventHandler(this.button_Client_Click);
            // 
            // button_Coin
            // 
            this.button_Coin.BackColor = System.Drawing.Color.Transparent;
            this.button_Coin.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Coin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Coin.Location = new System.Drawing.Point(8, 234);
            this.button_Coin.Name = "button_Coin";
            this.button_Coin.Size = new System.Drawing.Size(400, 233);
            this.button_Coin.TabIndex = 0;
            this.button_Coin.Text = "Coin Form";
            this.button_Coin.UseVisualStyleBackColor = false;
            this.button_Coin.Click += new System.EventHandler(this.button_Coin_Click);
            // 
            // button_Report
            // 
            this.button_Report.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Report.Location = new System.Drawing.Point(820, 121);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(311, 220);
            this.button_Report.TabIndex = 0;
            this.button_Report.Text = "Report";
            this.button_Report.UseVisualStyleBackColor = true;
            this.button_Report.Click += new System.EventHandler(this.button_Report_Click);
            // 
            // beginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 492);
            this.Controls.Add(this.button_Client);
            this.Controls.Add(this.button_Report);
            this.Controls.Add(this.button_City);
            this.Controls.Add(this.button_Coin);
            this.Controls.Add(this.button_Trade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "beginForm";
            this.Text = "Start here!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Trade;
        private System.Windows.Forms.Button button_City;
        private System.Windows.Forms.Button button_Client;
        private System.Windows.Forms.Button button_Coin;
        private System.Windows.Forms.Button button_Report;
    }
}