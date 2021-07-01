namespace MovieTicketsBooking
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.conPassword = new System.Windows.Forms.Label();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtCPassword = new System.Windows.Forms.TextBox();
            this.btnRegsave = new System.Windows.Forms.Button();
            this.btnRegCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSalmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(306, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Location = new System.Drawing.Point(101, 139);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(0, 17);
            this.FullName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name :- ";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(101, 257);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(99, 18);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password :-";
            // 
            // conPassword
            // 
            this.conPassword.AutoSize = true;
            this.conPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPassword.Location = new System.Drawing.Point(101, 312);
            this.conPassword.Name = "conPassword";
            this.conPassword.Size = new System.Drawing.Size(164, 18);
            this.conPassword.TabIndex = 4;
            this.conPassword.Text = "Confirm Password :-";
            // 
            // txtUname
            // 
            this.txtUname.Location = new System.Drawing.Point(309, 195);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(160, 22);
            this.txtUname.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(309, 257);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(160, 22);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtCPassword
            // 
            this.txtCPassword.Location = new System.Drawing.Point(309, 312);
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.Size = new System.Drawing.Size(160, 22);
            this.txtCPassword.TabIndex = 8;
            this.txtCPassword.UseSystemPasswordChar = true;
            // 
            // btnRegsave
            // 
            this.btnRegsave.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRegsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegsave.Location = new System.Drawing.Point(160, 397);
            this.btnRegsave.Name = "btnRegsave";
            this.btnRegsave.Size = new System.Drawing.Size(98, 39);
            this.btnRegsave.TabIndex = 9;
            this.btnRegsave.Text = "Register";
            this.btnRegsave.UseVisualStyleBackColor = false;
            this.btnRegsave.Click += new System.EventHandler(this.btnRegsave_Click);
            // 
            // btnRegCancel
            // 
            this.btnRegCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnRegCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegCancel.Location = new System.Drawing.Point(538, 397);
            this.btnRegCancel.Name = "btnRegCancel";
            this.btnRegCancel.Size = new System.Drawing.Size(98, 39);
            this.btnRegCancel.TabIndex = 10;
            this.btnRegCancel.Text = "Cancel";
            this.btnRegCancel.UseVisualStyleBackColor = false;
            this.btnRegCancel.Click += new System.EventHandler(this.btnRegCancel_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 478);
            this.Controls.Add(this.btnRegCancel);
            this.Controls.Add(this.btnRegsave);
            this.Controls.Add(this.txtCPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.conPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label conPassword;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtCPassword;
        private System.Windows.Forms.Button btnRegsave;
        private System.Windows.Forms.Button btnRegCancel;
    }
}