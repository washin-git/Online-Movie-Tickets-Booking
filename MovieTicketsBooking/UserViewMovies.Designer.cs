namespace MovieTicketsBooking
{
    partial class UserViewMovies
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
            this.txtUserViewMName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserViewLang = new System.Windows.Forms.TextBox();
            this.dataGridViewUserViewMovie = new System.Windows.Forms.DataGridView();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserViewMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movie Name :-";
            // 
            // txtUserViewMName
            // 
            this.txtUserViewMName.Location = new System.Drawing.Point(255, 115);
            this.txtUserViewMName.Name = "txtUserViewMName";
            this.txtUserViewMName.Size = new System.Drawing.Size(128, 22);
            this.txtUserViewMName.TabIndex = 5;
            this.txtUserViewMName.TextChanged += new System.EventHandler(this.txtUserViewMName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show Time :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Language :-";
            // 
            // txtUserViewLang
            // 
            this.txtUserViewLang.Location = new System.Drawing.Point(255, 285);
            this.txtUserViewLang.Name = "txtUserViewLang";
            this.txtUserViewLang.Size = new System.Drawing.Size(128, 22);
            this.txtUserViewLang.TabIndex = 9;
            this.txtUserViewLang.TextChanged += new System.EventHandler(this.txtUserViewLang_TextChanged);
            // 
            // dataGridViewUserViewMovie
            // 
            this.dataGridViewUserViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUserViewMovie.Location = new System.Drawing.Point(412, 44);
            this.dataGridViewUserViewMovie.Name = "dataGridViewUserViewMovie";
            this.dataGridViewUserViewMovie.RowHeadersWidth = 51;
            this.dataGridViewUserViewMovie.RowTemplate.Height = 24;
            this.dataGridViewUserViewMovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserViewMovie.Size = new System.Drawing.Size(361, 349);
            this.dataGridViewUserViewMovie.TabIndex = 10;
            this.dataGridViewUserViewMovie.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUserViewMovie_CellDoubleClick);
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTime.Location = new System.Drawing.Point(255, 195);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(128, 22);
            this.dateTimePickerTime.TabIndex = 11;
            this.dateTimePickerTime.ValueChanged += new System.EventHandler(this.dateTimePickerTime_ValueChanged);
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnUserCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUserCancel.Location = new System.Drawing.Point(175, 391);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(82, 32);
            this.btnUserCancel.TabIndex = 12;
            this.btnUserCancel.Text = "Cancel";
            this.btnUserCancel.UseVisualStyleBackColor = false;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Location = new System.Drawing.Point(550, 406);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 32);
            this.btnLoad.TabIndex = 16;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // UserViewMovies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnUserCancel);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.dataGridViewUserViewMovie);
            this.Controls.Add(this.txtUserViewLang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserViewMName);
            this.Controls.Add(this.label1);
            this.Name = "UserViewMovies";
            this.Text = "View Movies";
            this.Load += new System.EventHandler(this.UserViewMovies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserViewMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserViewMName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserViewLang;
        private System.Windows.Forms.DataGridView dataGridViewUserViewMovie;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.Button btnUserCancel;
        private System.Windows.Forms.Button btnLoad;
    }
}