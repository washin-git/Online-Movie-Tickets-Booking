namespace MovieTicketsBooking
{
    partial class UserEditProfile
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
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUserEditsave = new System.Windows.Forms.Button();
            this.btnUserEditCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name :- ";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(129, 224);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(99, 18);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password :-";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(361, 115);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(160, 22);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(361, 224);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(160, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // btnUserEditsave
            // 
            this.btnUserEditsave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUserEditsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserEditsave.Location = new System.Drawing.Point(132, 365);
            this.btnUserEditsave.Name = "btnUserEditsave";
            this.btnUserEditsave.Size = new System.Drawing.Size(98, 39);
            this.btnUserEditsave.TabIndex = 10;
            this.btnUserEditsave.Text = "Save";
            this.btnUserEditsave.UseVisualStyleBackColor = false;
            this.btnUserEditsave.Click += new System.EventHandler(this.btnUserEditsave_Click);
            // 
            // btnUserEditCancel
            // 
            this.btnUserEditCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnUserEditCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserEditCancel.Location = new System.Drawing.Point(520, 365);
            this.btnUserEditCancel.Name = "btnUserEditCancel";
            this.btnUserEditCancel.Size = new System.Drawing.Size(98, 39);
            this.btnUserEditCancel.TabIndex = 11;
            this.btnUserEditCancel.Text = "Cancel";
            this.btnUserEditCancel.UseVisualStyleBackColor = false;
            this.btnUserEditCancel.Click += new System.EventHandler(this.btnUserEditCancel_Click);
            // 
            // UserEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserEditCancel);
            this.Controls.Add(this.btnUserEditsave);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Name = "UserEditProfile";
            this.Text = "EditProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUserEditsave;
        private System.Windows.Forms.Button btnUserEditCancel;
    }
}