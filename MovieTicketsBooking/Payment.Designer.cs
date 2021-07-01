namespace MovieTicketsBooking
{
    partial class Payment
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
            this.radioButtonvisa = new System.Windows.Forms.RadioButton();
            this.radioButtonmaster = new System.Windows.Forms.RadioButton();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCVN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnPayCancel = new System.Windows.Forms.Button();
            this.txtYYYY = new System.Windows.Forms.TextBox();
            this.txtMM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButtonvisa
            // 
            this.radioButtonvisa.AutoSize = true;
            this.radioButtonvisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonvisa.Location = new System.Drawing.Point(259, 105);
            this.radioButtonvisa.Name = "radioButtonvisa";
            this.radioButtonvisa.Size = new System.Drawing.Size(99, 21);
            this.radioButtonvisa.TabIndex = 0;
            this.radioButtonvisa.TabStop = true;
            this.radioButtonvisa.Text = "Visa Card";
            this.radioButtonvisa.UseVisualStyleBackColor = true;
            // 
            // radioButtonmaster
            // 
            this.radioButtonmaster.AutoSize = true;
            this.radioButtonmaster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonmaster.Location = new System.Drawing.Point(360, 106);
            this.radioButtonmaster.Name = "radioButtonmaster";
            this.radioButtonmaster.Size = new System.Drawing.Size(117, 21);
            this.radioButtonmaster.TabIndex = 1;
            this.radioButtonmaster.TabStop = true;
            this.radioButtonmaster.Text = "Master Card";
            this.radioButtonmaster.UseVisualStyleBackColor = true;
            this.radioButtonmaster.CheckedChanged += new System.EventHandler(this.radioButtonmaster_CheckedChanged);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCardNumber.Location = new System.Drawing.Point(259, 185);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(161, 22);
            this.txtCardNumber.TabIndex = 2;
            this.txtCardNumber.Text = "0000 0000 0000 0000";
            this.txtCardNumber.TextChanged += new System.EventHandler(this.txtCardName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Card Name :- ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Card Number :- ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valid Thru:- ";
            // 
            // txtCVN
            // 
            this.txtCVN.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCVN.Location = new System.Drawing.Point(259, 344);
            this.txtCVN.Name = "txtCVN";
            this.txtCVN.Size = new System.Drawing.Size(61, 22);
            this.txtCVN.TabIndex = 8;
            this.txtCVN.Text = "XXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "CVV :- ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "/";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPay.Location = new System.Drawing.Point(174, 420);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(93, 31);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnPayCancel
            // 
            this.btnPayCancel.BackColor = System.Drawing.Color.Brown;
            this.btnPayCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayCancel.Location = new System.Drawing.Point(470, 420);
            this.btnPayCancel.Name = "btnPayCancel";
            this.btnPayCancel.Size = new System.Drawing.Size(93, 31);
            this.btnPayCancel.TabIndex = 12;
            this.btnPayCancel.Text = "Cancel";
            this.btnPayCancel.UseVisualStyleBackColor = false;
            this.btnPayCancel.Click += new System.EventHandler(this.btnPayCancel_Click);
            // 
            // txtYYYY
            // 
            this.txtYYYY.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtYYYY.Location = new System.Drawing.Point(359, 269);
            this.txtYYYY.Name = "txtYYYY";
            this.txtYYYY.Size = new System.Drawing.Size(61, 22);
            this.txtYYYY.TabIndex = 13;
            this.txtYYYY.Text = "YYYY";
            // 
            // txtMM
            // 
            this.txtMM.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMM.Location = new System.Drawing.Point(259, 270);
            this.txtMM.Name = "txtMM";
            this.txtMM.Size = new System.Drawing.Size(61, 22);
            this.txtMM.TabIndex = 14;
            this.txtMM.Text = "MM";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.txtMM);
            this.Controls.Add(this.txtYYYY);
            this.Controls.Add(this.btnPayCancel);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCVN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.radioButtonmaster);
            this.Controls.Add(this.radioButtonvisa);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonvisa;
        private System.Windows.Forms.RadioButton radioButtonmaster;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCVN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnPayCancel;
        private System.Windows.Forms.TextBox txtYYYY;
        private System.Windows.Forms.TextBox txtMM;
    }
}