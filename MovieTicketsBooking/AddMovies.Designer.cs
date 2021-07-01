namespace MovieTicketsBooking
{
    partial class AdminAddMovies
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdminAddMName = new System.Windows.Forms.TextBox();
            this.txtAdminAddMType = new System.Windows.Forms.TextBox();
            this.txtAdminAddLanguage = new System.Windows.Forms.TextBox();
            this.btnAdminSave = new System.Windows.Forms.Button();
            this.btnAdminEditMovie = new System.Windows.Forms.Button();
            this.btnAdminMovieCancel = new System.Windows.Forms.Button();
            this.btnAdminnAddMDelete = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Name :- ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = " Movie Type :- ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Show Time :- ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Movie Language :- ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtAdminAddMName
            // 
            this.txtAdminAddMName.Location = new System.Drawing.Point(415, 83);
            this.txtAdminAddMName.Name = "txtAdminAddMName";
            this.txtAdminAddMName.Size = new System.Drawing.Size(171, 22);
            this.txtAdminAddMName.TabIndex = 4;
            this.txtAdminAddMName.TextChanged += new System.EventHandler(this.txtAdminAddMName_TextChanged);
            // 
            // txtAdminAddMType
            // 
            this.txtAdminAddMType.Location = new System.Drawing.Point(415, 160);
            this.txtAdminAddMType.Name = "txtAdminAddMType";
            this.txtAdminAddMType.Size = new System.Drawing.Size(171, 22);
            this.txtAdminAddMType.TabIndex = 5;
            this.txtAdminAddMType.TextChanged += new System.EventHandler(this.txtAdminAddMType_TextChanged);
            // 
            // txtAdminAddLanguage
            // 
            this.txtAdminAddLanguage.Location = new System.Drawing.Point(412, 322);
            this.txtAdminAddLanguage.Name = "txtAdminAddLanguage";
            this.txtAdminAddLanguage.Size = new System.Drawing.Size(171, 22);
            this.txtAdminAddLanguage.TabIndex = 7;
            this.txtAdminAddLanguage.TextChanged += new System.EventHandler(this.txtAdminAddLanguage_TextChanged);
            // 
            // btnAdminSave
            // 
            this.btnAdminSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdminSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminSave.Location = new System.Drawing.Point(121, 426);
            this.btnAdminSave.Name = "btnAdminSave";
            this.btnAdminSave.Size = new System.Drawing.Size(89, 32);
            this.btnAdminSave.TabIndex = 8;
            this.btnAdminSave.Text = "Save";
            this.btnAdminSave.UseVisualStyleBackColor = false;
            this.btnAdminSave.Click += new System.EventHandler(this.btnAdminSave_Click);
            // 
            // btnAdminEditMovie
            // 
            this.btnAdminEditMovie.BackColor = System.Drawing.Color.LightCoral;
            this.btnAdminEditMovie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminEditMovie.Location = new System.Drawing.Point(290, 426);
            this.btnAdminEditMovie.Name = "btnAdminEditMovie";
            this.btnAdminEditMovie.Size = new System.Drawing.Size(89, 32);
            this.btnAdminEditMovie.TabIndex = 9;
            this.btnAdminEditMovie.Text = "Edit";
            this.btnAdminEditMovie.UseVisualStyleBackColor = false;
            this.btnAdminEditMovie.Click += new System.EventHandler(this.btnAdminEditMovie_Click);
            // 
            // btnAdminMovieCancel
            // 
            this.btnAdminMovieCancel.BackColor = System.Drawing.Color.Red;
            this.btnAdminMovieCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminMovieCancel.Location = new System.Drawing.Point(650, 426);
            this.btnAdminMovieCancel.Name = "btnAdminMovieCancel";
            this.btnAdminMovieCancel.Size = new System.Drawing.Size(89, 32);
            this.btnAdminMovieCancel.TabIndex = 10;
            this.btnAdminMovieCancel.Text = "Cancel";
            this.btnAdminMovieCancel.UseVisualStyleBackColor = false;
            this.btnAdminMovieCancel.Click += new System.EventHandler(this.btnAdminMovieCancel_Click);
            // 
            // btnAdminnAddMDelete
            // 
            this.btnAdminnAddMDelete.BackColor = System.Drawing.Color.Red;
            this.btnAdminnAddMDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminnAddMDelete.Location = new System.Drawing.Point(463, 426);
            this.btnAdminnAddMDelete.Name = "btnAdminnAddMDelete";
            this.btnAdminnAddMDelete.Size = new System.Drawing.Size(89, 32);
            this.btnAdminnAddMDelete.TabIndex = 11;
            this.btnAdminnAddMDelete.Text = "Delete";
            this.btnAdminnAddMDelete.UseVisualStyleBackColor = false;
            this.btnAdminnAddMDelete.Click += new System.EventHandler(this.btnAdminnAddMDelete_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(415, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AdminAddMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnAdminnAddMDelete);
            this.Controls.Add(this.btnAdminMovieCancel);
            this.Controls.Add(this.btnAdminEditMovie);
            this.Controls.Add(this.btnAdminSave);
            this.Controls.Add(this.txtAdminAddLanguage);
            this.Controls.Add(this.txtAdminAddMType);
            this.Controls.Add(this.txtAdminAddMName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminAddMovies";
            this.Text = "AddMovies";
            this.Load += new System.EventHandler(this.AdminAddMovies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdminAddMName;
        private System.Windows.Forms.TextBox txtAdminAddMType;
        private System.Windows.Forms.TextBox txtAdminAddLanguage;
        private System.Windows.Forms.Button btnAdminSave;
        private System.Windows.Forms.Button btnAdminEditMovie;
        private System.Windows.Forms.Button btnAdminMovieCancel;
        private System.Windows.Forms.Button btnAdminnAddMDelete;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}