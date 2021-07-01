namespace MovieTicketsBooking
{
    partial class AdminView_Movie
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
            this.dataGridViewAdminViewMovie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminViewMName = new System.Windows.Forms.TextBox();
            this.txtAdminViewLang = new System.Windows.Forms.TextBox();
            this.dateTimePickerShow = new System.Windows.Forms.DateTimePicker();
            this.btnAdminCancel = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminViewMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdminViewMovie
            // 
            this.dataGridViewAdminViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdminViewMovie.Location = new System.Drawing.Point(331, 37);
            this.dataGridViewAdminViewMovie.Name = "dataGridViewAdminViewMovie";
            this.dataGridViewAdminViewMovie.RowHeadersWidth = 51;
            this.dataGridViewAdminViewMovie.RowTemplate.Height = 24;
            this.dataGridViewAdminViewMovie.ShowCellErrors = false;
            this.dataGridViewAdminViewMovie.Size = new System.Drawing.Size(444, 349);
            this.dataGridViewAdminViewMovie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Name :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Show Time :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Language :-";
            // 
            // txtAdminViewMName
            // 
            this.txtAdminViewMName.Location = new System.Drawing.Point(174, 94);
            this.txtAdminViewMName.Name = "txtAdminViewMName";
            this.txtAdminViewMName.Size = new System.Drawing.Size(128, 22);
            this.txtAdminViewMName.TabIndex = 4;
            this.txtAdminViewMName.TextChanged += new System.EventHandler(this.txtAdminViewMName_TextChanged);
            // 
            // txtAdminViewLang
            // 
            this.txtAdminViewLang.Location = new System.Drawing.Point(174, 266);
            this.txtAdminViewLang.Name = "txtAdminViewLang";
            this.txtAdminViewLang.Size = new System.Drawing.Size(128, 22);
            this.txtAdminViewLang.TabIndex = 6;
            this.txtAdminViewLang.TextChanged += new System.EventHandler(this.txtAdminViewLang_TextChanged);
            // 
            // dateTimePickerShow
            // 
            this.dateTimePickerShow.Location = new System.Drawing.Point(174, 184);
            this.dateTimePickerShow.Name = "dateTimePickerShow";
            this.dateTimePickerShow.Size = new System.Drawing.Size(128, 22);
            this.dateTimePickerShow.TabIndex = 7;
            this.dateTimePickerShow.ValueChanged += new System.EventHandler(this.dateTimePickerShow_ValueChanged);
            // 
            // btnAdminCancel
            // 
            this.btnAdminCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnAdminCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdminCancel.Location = new System.Drawing.Point(174, 373);
            this.btnAdminCancel.Name = "btnAdminCancel";
            this.btnAdminCancel.Size = new System.Drawing.Size(82, 32);
            this.btnAdminCancel.TabIndex = 13;
            this.btnAdminCancel.Text = "Cancel";
            this.btnAdminCancel.UseVisualStyleBackColor = false;
            this.btnAdminCancel.Click += new System.EventHandler(this.btnAdminCancel_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoad.Location = new System.Drawing.Point(507, 407);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 32);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // AdminView_Movie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdminCancel);
            this.Controls.Add(this.dateTimePickerShow);
            this.Controls.Add(this.txtAdminViewLang);
            this.Controls.Add(this.txtAdminViewMName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewAdminViewMovie);
            this.Name = "AdminView_Movie";
            this.Text = "View_Movie";
            this.Load += new System.EventHandler(this.AdminView_Movie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdminViewMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdminViewMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminViewMName;
        private System.Windows.Forms.TextBox txtAdminViewLang;
        private System.Windows.Forms.DateTimePicker dateTimePickerShow;
        private System.Windows.Forms.Button btnAdminCancel;
        private System.Windows.Forms.Button btnLoad;
    }
}