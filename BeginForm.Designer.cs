
namespace ClientApp
{
    partial class beginForm
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
            this.loginButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginButton.Location = new System.Drawing.Point(12, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(400, 400);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login \r\n(as admin)";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Rockwell Nova Cond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(418, 12);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(400, 400);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // beginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 419);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.loginButton);
            this.Name = "beginForm";
            this.Text = "Start here!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button signUpButton;
    }
}