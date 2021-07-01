namespace MovieTicketsBooking
{
    partial class UserHome
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
            this.btnUserViewmovie = new System.Windows.Forms.Button();
            this.btnUserEditProfile = new System.Windows.Forms.Button();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUserViewmovie
            // 
            this.btnUserViewmovie.BackColor = System.Drawing.Color.Turquoise;
            this.btnUserViewmovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserViewmovie.Location = new System.Drawing.Point(78, 109);
            this.btnUserViewmovie.Name = "btnUserViewmovie";
            this.btnUserViewmovie.Size = new System.Drawing.Size(273, 96);
            this.btnUserViewmovie.TabIndex = 1;
            this.btnUserViewmovie.Text = "View Movies";
            this.btnUserViewmovie.UseVisualStyleBackColor = false;
            this.btnUserViewmovie.Click += new System.EventHandler(this.btnUserViewmovie_Click);
            // 
            // btnUserEditProfile
            // 
            this.btnUserEditProfile.BackColor = System.Drawing.Color.Brown;
            this.btnUserEditProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserEditProfile.Location = new System.Drawing.Point(478, 109);
            this.btnUserEditProfile.Name = "btnUserEditProfile";
            this.btnUserEditProfile.Size = new System.Drawing.Size(270, 96);
            this.btnUserEditProfile.TabIndex = 2;
            this.btnUserEditProfile.Text = "Edit Profile";
            this.btnUserEditProfile.UseVisualStyleBackColor = false;
            this.btnUserEditProfile.Click += new System.EventHandler(this.btnUserEditProfile_Click);
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.BackColor = System.Drawing.Color.Red;
            this.btnUserCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserCancel.Location = new System.Drawing.Point(266, 285);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(270, 96);
            this.btnUserCancel.TabIndex = 3;
            this.btnUserCancel.Text = "Cancel";
            this.btnUserCancel.UseVisualStyleBackColor = false;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserCancel);
            this.Controls.Add(this.btnUserEditProfile);
            this.Controls.Add(this.btnUserViewmovie);
            this.Name = "UserHome";
            this.Text = "UserHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserViewmovie;
        private System.Windows.Forms.Button btnUserEditProfile;
        private System.Windows.Forms.Button btnUserCancel;
    }
}