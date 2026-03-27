namespace MessengerTopClient
{
    partial class RegistrForm
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
            this.lblLog = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblLogEr = new System.Windows.Forms.Label();
            this.lblPassEr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblLog.Location = new System.Drawing.Point(51, 25);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(63, 20);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Логин :";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(46, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 37);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReg.Location = new System.Drawing.Point(185, 223);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(198, 37);
            this.btnReg.TabIndex = 2;
            this.btnReg.Text = "Регистрация";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Пароль :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "Подтвердите \r\n        пароль :";
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLog.Location = new System.Drawing.Point(120, 25);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(263, 24);
            this.txtLog.TabIndex = 3;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPass.Location = new System.Drawing.Point(120, 94);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(263, 24);
            this.txtPass.TabIndex = 3;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtConfirmPass.Location = new System.Drawing.Point(120, 159);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(263, 24);
            this.txtConfirmPass.TabIndex = 3;
            // 
            // lblLogEr
            // 
            this.lblLogEr.AutoSize = true;
            this.lblLogEr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblLogEr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblLogEr.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblLogEr.Location = new System.Drawing.Point(78, 63);
            this.lblLogEr.Name = "lblLogEr";
            this.lblLogEr.Size = new System.Drawing.Size(34, 15);
            this.lblLogEr.TabIndex = 4;
            this.lblLogEr.Text = "label";
            // 
            // lblPassEr
            // 
            this.lblPassEr.AutoSize = true;
            this.lblPassEr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPassEr.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPassEr.Location = new System.Drawing.Point(79, 196);
            this.lblPassEr.Name = "lblPassEr";
            this.lblPassEr.Size = new System.Drawing.Size(41, 15);
            this.lblPassEr.TabIndex = 4;
            this.lblPassEr.Text = "label1";
            // 
            // RegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(418, 292);
            this.Controls.Add(this.lblPassEr);
            this.Controls.Add(this.lblLogEr);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLog);
            this.Name = "RegistrForm";
            this.Text = "Messenger Top";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblLogEr;
        private System.Windows.Forms.Label lblPassEr;
    }
}