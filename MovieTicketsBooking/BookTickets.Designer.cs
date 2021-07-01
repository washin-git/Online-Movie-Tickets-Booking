namespace MovieTicketsBooking
{
    partial class BookTickets
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
            this.txtMN = new System.Windows.Forms.TextBox();
            this.MName = new System.Windows.Forms.Label();
            this.MType = new System.Windows.Forms.Label();
            this.MLanguage = new System.Windows.Forms.Label();
            this.Tickets = new System.Windows.Forms.Label();
            this.txtML = new System.Windows.Forms.TextBox();
            this.txtMT = new System.Windows.Forms.TextBox();
            this.txtTik = new System.Windows.Forms.TextBox();
            this.MShow = new System.Windows.Forms.Label();
            this.txtMST = new System.Windows.Forms.TextBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMN
            // 
            this.txtMN.Location = new System.Drawing.Point(351, 68);
            this.txtMN.Name = "txtMN";
            this.txtMN.Size = new System.Drawing.Size(211, 22);
            this.txtMN.TabIndex = 0;
            // 
            // MName
            // 
            this.MName.AutoSize = true;
            this.MName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MName.Location = new System.Drawing.Point(195, 69);
            this.MName.Name = "MName";
            this.MName.Size = new System.Drawing.Size(102, 18);
            this.MName.TabIndex = 1;
            this.MName.Text = "Movie Name";
            // 
            // MType
            // 
            this.MType.AutoSize = true;
            this.MType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MType.Location = new System.Drawing.Point(195, 135);
            this.MType.Name = "MType";
            this.MType.Size = new System.Drawing.Size(94, 18);
            this.MType.TabIndex = 2;
            this.MType.Text = "Movie Type";
            // 
            // MLanguage
            // 
            this.MLanguage.AutoSize = true;
            this.MLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MLanguage.Location = new System.Drawing.Point(195, 253);
            this.MLanguage.Name = "MLanguage";
            this.MLanguage.Size = new System.Drawing.Size(130, 18);
            this.MLanguage.TabIndex = 3;
            this.MLanguage.Text = "Movie Language";
            // 
            // Tickets
            // 
            this.Tickets.AutoSize = true;
            this.Tickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tickets.Location = new System.Drawing.Point(195, 321);
            this.Tickets.Name = "Tickets";
            this.Tickets.Size = new System.Drawing.Size(113, 18);
            this.Tickets.TabIndex = 4;
            this.Tickets.Text = "No Of Tickets";
            // 
            // txtML
            // 
            this.txtML.Location = new System.Drawing.Point(351, 251);
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(211, 22);
            this.txtML.TabIndex = 5;
            // 
            // txtMT
            // 
            this.txtMT.Location = new System.Drawing.Point(351, 135);
            this.txtMT.Name = "txtMT";
            this.txtMT.Size = new System.Drawing.Size(211, 22);
            this.txtMT.TabIndex = 6;
            // 
            // txtTik
            // 
            this.txtTik.Location = new System.Drawing.Point(351, 322);
            this.txtTik.Name = "txtTik";
            this.txtTik.Size = new System.Drawing.Size(211, 22);
            this.txtTik.TabIndex = 7;
            this.txtTik.TextChanged += new System.EventHandler(this.txtTik_TextChanged);
            // 
            // MShow
            // 
            this.MShow.AutoSize = true;
            this.MShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MShow.Location = new System.Drawing.Point(195, 194);
            this.MShow.Name = "MShow";
            this.MShow.Size = new System.Drawing.Size(114, 18);
            this.MShow.TabIndex = 8;
            this.MShow.Text = "Showing Time";
            // 
            // txtMST
            // 
            this.txtMST.Location = new System.Drawing.Point(351, 190);
            this.txtMST.Name = "txtMST";
            this.txtMST.Size = new System.Drawing.Size(211, 22);
            this.txtMST.TabIndex = 9;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.Turquoise;
            this.btnBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBook.Location = new System.Drawing.Point(140, 469);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(91, 32);
            this.btnBook.TabIndex = 10;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCancelBook
            // 
            this.btnCancelBook.BackColor = System.Drawing.Color.Red;
            this.btnCancelBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelBook.Location = new System.Drawing.Point(570, 469);
            this.btnCancelBook.Name = "btnCancelBook";
            this.btnCancelBook.Size = new System.Drawing.Size(91, 32);
            this.btnCancelBook.TabIndex = 11;
            this.btnCancelBook.Text = "Cancel";
            this.btnCancelBook.UseVisualStyleBackColor = false;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(351, 396);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(211, 22);
            this.txtAmount.TabIndex = 13;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(678, 323);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 18);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "450";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Per Ticket =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(714, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "LKR";
            // 
            // BookTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelBook);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.txtMST);
            this.Controls.Add(this.MShow);
            this.Controls.Add(this.txtTik);
            this.Controls.Add(this.txtMT);
            this.Controls.Add(this.txtML);
            this.Controls.Add(this.Tickets);
            this.Controls.Add(this.MLanguage);
            this.Controls.Add(this.MType);
            this.Controls.Add(this.MName);
            this.Controls.Add(this.txtMN);
            this.Name = "BookTickets";
            this.Text = "BookTickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MName;
        private System.Windows.Forms.Label MType;
        private System.Windows.Forms.Label MLanguage;
        private System.Windows.Forms.Label Tickets;
        private System.Windows.Forms.Label MShow;
        public System.Windows.Forms.TextBox txtMN;
        public System.Windows.Forms.TextBox txtML;
        public System.Windows.Forms.TextBox txtMT;
        public System.Windows.Forms.TextBox txtTik;
        public System.Windows.Forms.TextBox txtMST;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}