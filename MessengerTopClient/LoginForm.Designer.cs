namespace MessengerTopClient
{
    partial class LoginForm
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
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.linkL = new System.Windows.Forms.LinkLabel();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Password.Location = new System.Drawing.Point(25, 96);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(75, 20);
            this.Password.TabIndex = 0;
            this.Password.Text = "Пароль :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин :";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPass.Location = new System.Drawing.Point(119, 96);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(239, 24);
            this.txtPass.TabIndex = 1;
            // 
            // txtLog
            // 
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLog.Location = new System.Drawing.Point(119, 41);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(239, 24);
            this.txtLog.TabIndex = 1;
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLog.Location = new System.Drawing.Point(130, 164);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(106, 31);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Вход";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // linkL
            // 
            this.linkL.AutoSize = true;
            this.linkL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkL.Location = new System.Drawing.Point(135, 206);
            this.linkL.Name = "linkL";
            this.linkL.Size = new System.Drawing.Size(92, 17);
            this.linkL.TabIndex = 3;
            this.linkL.TabStop = true;
            this.linkL.Text = "Регистрация";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblError.Location = new System.Drawing.Point(41, 136);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(41, 15);
            this.lblError.TabIndex = 4;
            this.lblError.Text = "label2";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(386, 245);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.linkL);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.LinkLabel linkL;
        private System.Windows.Forms.Label lblError;
    }
}

