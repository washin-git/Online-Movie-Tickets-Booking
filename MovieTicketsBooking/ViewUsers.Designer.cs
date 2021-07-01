namespace MovieTicketsBooking
{
    partial class AdminViewUsers
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
            this.dataGridViewAdminVUser = new System.Windows.Forms.DataGridView();
            this.lblAdminUname = new System.Windows.Forms.Label();
            this.txtAdminVUsername = new System.Windows.Forms.TextBox();
            this.btnAdminUserCancel = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminVUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdminVUser
            // 
            this.dataGridViewAdminVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminVUser.Location = new System.Drawing.Point(373, 40);
            this.dataGridViewAdminVUser.Name = "dataGridViewAdminVUser";
            this.dataGridViewAdminVUser.RowHeadersWidth = 51;
            this.dataGridViewAdminVUser.RowTemplate.Height = 24;
            this.dataGridViewAdminVUser.Size = new System.Drawing.Size(403, 337);
            this.dataGridViewAdminVUser.TabIndex = 0;
            // 
            // lblAdminUname
            // 
            this.lblAdminUname.AutoSize = true;
            this.lblAdminUname.Location = new System.Drawing.Point(46, 97);
            this.lblAdminUname.Name = "lblAdminUname";
            this.lblAdminUname.Size = new System.Drawing.Size(92, 17);
            this.lblAdminUname.TabIndex = 1;
            this.lblAdminUname.Text = "User Name :-";
            // 
            // txtAdminVUsername
            // 
            this.txtAdminVUsername.Location = new System.Drawing.Point(160, 97);
            this.txtAdminVUsername.Name = "txtAdminVUsername";
            this.txtAdminVUsername.Size = new System.Drawing.Size(149, 22);
            this.txtAdminVUsername.TabIndex = 2;
            this.txtAdminVUsername.TextChanged += new System.EventHandler(this.txtAdminVUsername_TextChanged);
            // 
            // btnAdminUserCancel
            // 
            this.btnAdminUserCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdminUserCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminUserCancel.Location = new System.Drawing.Point(160, 345);
            this.btnAdminUserCancel.Name = "btnAdminUserCancel";
            this.btnAdminUserCancel.Size = new System.Drawing.Size(82, 32);
            this.btnAdminUserCancel.TabIndex = 14;
            this.btnAdminUserCancel.Text = "Cancel";
            this.btnAdminUserCancel.UseVisualStyleBackColor = false;
            this.btnAdminUserCancel.Click += new System.EventHandler(this.btnAdminUserCancel_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Location = new System.Drawing.Point(531, 397);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 32);
            this.btnLoad.TabIndex = 15;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // AdminViewUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdminUserCancel);
            this.Controls.Add(this.txtAdminVUsername);
            this.Controls.Add(this.lblAdminUname);
            this.Controls.Add(this.dataGridViewAdminVUser);
            this.Name = "AdminViewUsers";
            this.Text = "ViewUsers";
            this.Load += new System.EventHandler(this.AdminViewUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminVUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdminVUser;
        private System.Windows.Forms.Label lblAdminUname;
        private System.Windows.Forms.TextBox txtAdminVUsername;
        private System.Windows.Forms.Button btnAdminUserCancel;
        private System.Windows.Forms.Button btnLoad;
    }
}