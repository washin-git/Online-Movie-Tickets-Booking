namespace MovieTicketsBooking
{
    partial class WelcomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomePage));
            this.Register = new System.Windows.Forms.Button();
            this.LoginPage = new System.Windows.Forms.Button();
            this.welcomGK = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.LightCoral;
            this.Register.ForeColor = System.Drawing.Color.MintCream;
            this.Register.Location = new System.Drawing.Point(177, 326);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(149, 66);
            this.Register.TabIndex = 0;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // LoginPage
            // 
            this.LoginPage.BackColor = System.Drawing.Color.LightCoral;
            this.LoginPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginPage.Location = new System.Drawing.Point(565, 326);
            this.LoginPage.Name = "LoginPage";
            this.LoginPage.Size = new System.Drawing.Size(149, 66);
            this.LoginPage.TabIndex = 1;
            this.LoginPage.Text = "Login";
            this.LoginPage.UseVisualStyleBackColor = false;
            this.LoginPage.Click += new System.EventHandler(this.LoginPage_Click);
            // 
            // welcomGK
            // 
            this.welcomGK.AutoSize = true;
            this.welcomGK.BackColor = System.Drawing.Color.Brown;
            this.welcomGK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomGK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.welcomGK.Location = new System.Drawing.Point(334, 121);
            this.welcomGK.Name = "welcomGK";
            this.welcomGK.Size = new System.Drawing.Size(262, 25);
            this.welcomGK.TabIndex = 2;
            this.welcomGK.Text = "Welcome To GK Cinemex";
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(928, 596);
            this.Controls.Add(this.welcomGK);
            this.Controls.Add(this.LoginPage);
            this.Controls.Add(this.Register);
            this.Name = "WelcomePage";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button LoginPage;
        private System.Windows.Forms.Label welcomGK;
    }
}

