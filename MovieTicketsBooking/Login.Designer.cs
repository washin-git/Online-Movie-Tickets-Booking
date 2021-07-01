namespace MovieTicketsBooking
{
    partial class LoginPage
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
            this.lblloginhere = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtLoginUname = new System.Windows.Forms.TextBox();
            this.txtLoginPass = new System.Windows.Forms.TextBox();
            this.btnLoginok = new System.Windows.Forms.Button();
            this.btnLoginRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblloginhere
            // 
            this.lblloginhere.AutoSize = true;
            this.lblloginhere.BackColor = System.Drawing.Color.LightSalmon;
            this.lblloginhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloginhere.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblloginhere.Location = new System.Drawing.Point(321, 71);
            this.lblloginhere.Name = "lblloginhere";
            this.lblloginhere.Size = new System.Drawing.Size(117, 25);
            this.lblloginhere.TabIndex = 0;
            this.lblloginhere.Text = "Login Here";
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.Location = new System.Drawing.Point(169, 180);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(109, 18);
            this.lblUname.TabIndex = 1;
            this.lblUname.Text = "User Name :-";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(169, 280);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(99, 18);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Password :-";
            // 
            // txtLoginUname
            // 
            this.txtLoginUname.Location = new System.Drawing.Point(403, 180);
            this.txtLoginUname.Name = "txtLoginUname";
            this.txtLoginUname.Size = new System.Drawing.Size(140, 22);
            this.txtLoginUname.TabIndex = 3;
            this.txtLoginUname.TextChanged += new System.EventHandler(this.txtLoginUname_TextChanged);
            // 
            // txtLoginPass
            // 
            this.txtLoginPass.Location = new System.Drawing.Point(403, 275);
            this.txtLoginPass.Name = "txtLoginPass";
            this.txtLoginPass.Size = new System.Drawing.Size(140, 22);
            this.txtLoginPass.TabIndex = 4;
            this.txtLoginPass.UseSystemPasswordChar = true;
            // 
            // btnLoginok
            // 
            this.btnLoginok.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoginok.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoginok.Location = new System.Drawing.Point(159, 382);
            this.btnLoginok.Name = "btnLoginok";
            this.btnLoginok.Size = new System.Drawing.Size(139, 66);
            this.btnLoginok.TabIndex = 5;
            this.btnLoginok.Text = "Login";
            this.btnLoginok.UseVisualStyleBackColor = false;
            this.btnLoginok.Click += new System.EventHandler(this.btnLoginok_Click);
            // 
            // btnLoginRegister
            // 
            this.btnLoginRegister.BackColor = System.Drawing.Color.DarkRed;
            this.btnLoginRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoginRegister.Location = new System.Drawing.Point(532, 382);
            this.btnLoginRegister.Name = "btnLoginRegister";
            this.btnLoginRegister.Size = new System.Drawing.Size(139, 66);
            this.btnLoginRegister.TabIndex = 6;
            this.btnLoginRegister.Text = "Register";
            this.btnLoginRegister.UseVisualStyleBackColor = false;
            this.btnLoginRegister.Click += new System.EventHandler(this.btnLoginRegister_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.btnLoginRegister);
            this.Controls.Add(this.btnLoginok);
            this.Controls.Add(this.txtLoginPass);
            this.Controls.Add(this.txtLoginUname);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lblloginhere);
            this.Name = "LoginPage";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloginhere;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtLoginUname;
        private System.Windows.Forms.TextBox txtLoginPass;
        private System.Windows.Forms.Button btnLoginok;
        private System.Windows.Forms.Button btnLoginRegister;
    }
}