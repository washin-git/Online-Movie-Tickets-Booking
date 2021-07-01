namespace MovieTicketsBooking
{
    partial class AdminHome
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
            this.btnAddmovie = new System.Windows.Forms.Button();
            this.btnAdminViewUsers = new System.Windows.Forms.Button();
            this.btnAdminViewMovies = new System.Windows.Forms.Button();
            this.btnAdminhomeCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddmovie
            // 
            this.btnAddmovie.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddmovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddmovie.Location = new System.Drawing.Point(56, 142);
            this.btnAddmovie.Name = "btnAddmovie";
            this.btnAddmovie.Size = new System.Drawing.Size(197, 70);
            this.btnAddmovie.TabIndex = 0;
            this.btnAddmovie.Text = "Add Movies";
            this.btnAddmovie.UseVisualStyleBackColor = false;
            this.btnAddmovie.Click += new System.EventHandler(this.btnAddmovie_Click);
            // 
            // btnAdminViewUsers
            // 
            this.btnAdminViewUsers.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdminViewUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminViewUsers.Location = new System.Drawing.Point(608, 142);
            this.btnAdminViewUsers.Name = "btnAdminViewUsers";
            this.btnAdminViewUsers.Size = new System.Drawing.Size(197, 70);
            this.btnAdminViewUsers.TabIndex = 1;
            this.btnAdminViewUsers.Text = "View Users";
            this.btnAdminViewUsers.UseVisualStyleBackColor = false;
            this.btnAdminViewUsers.Click += new System.EventHandler(this.btnAdminViewUsers_Click);
            // 
            // btnAdminViewMovies
            // 
            this.btnAdminViewMovies.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdminViewMovies.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminViewMovies.Location = new System.Drawing.Point(334, 142);
            this.btnAdminViewMovies.Name = "btnAdminViewMovies";
            this.btnAdminViewMovies.Size = new System.Drawing.Size(197, 70);
            this.btnAdminViewMovies.TabIndex = 2;
            this.btnAdminViewMovies.Text = "View Movies";
            this.btnAdminViewMovies.UseVisualStyleBackColor = false;
            this.btnAdminViewMovies.Click += new System.EventHandler(this.btnAdminViewMovies_Click);
            // 
            // btnAdminhomeCancel
            // 
            this.btnAdminhomeCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdminhomeCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminhomeCancel.Location = new System.Drawing.Point(334, 322);
            this.btnAdminhomeCancel.Name = "btnAdminhomeCancel";
            this.btnAdminhomeCancel.Size = new System.Drawing.Size(197, 70);
            this.btnAdminhomeCancel.TabIndex = 3;
            this.btnAdminhomeCancel.Text = "Cancel";
            this.btnAdminhomeCancel.UseVisualStyleBackColor = false;
            this.btnAdminhomeCancel.Click += new System.EventHandler(this.btnAdminhomeCancel_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 492);
            this.Controls.Add(this.btnAdminhomeCancel);
            this.Controls.Add(this.btnAdminViewMovies);
            this.Controls.Add(this.btnAdminViewUsers);
            this.Controls.Add(this.btnAddmovie);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddmovie;
        private System.Windows.Forms.Button btnAdminViewUsers;
        private System.Windows.Forms.Button btnAdminViewMovies;
        private System.Windows.Forms.Button btnAdminhomeCancel;
    }
}