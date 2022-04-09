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
            this.button_Trade = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Trade
            // 
            this.button_Trade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Trade.Font = new System.Drawing.Font("Rockwell Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Trade.Location = new System.Drawing.Point(13, 13);
            this.button_Trade.Margin = new System.Windows.Forms.Padding(4);
            this.button_Trade.Name = "button_Trade";
            this.button_Trade.Size = new System.Drawing.Size(91, 71);
            this.button_Trade.TabIndex = 0;
            this.button_Trade.Text = "Trade";
            this.button_Trade.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Font = new System.Drawing.Font("Rockwell Nova Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(13, 121);
            this.button.Margin = new System.Windows.Forms.Padding(4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(91, 71);
            this.button.TabIndex = 0;
            this.button.Text = "Trade";
            this.button.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 499);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button_Trade);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Trade;
        private System.Windows.Forms.Button button;
    }
}