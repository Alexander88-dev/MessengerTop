namespace MessengerTopClient
{
    partial class SettForm
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
            this.ColForm = new System.Windows.Forms.ComboBox();
            this.lblSett = new System.Windows.Forms.Label();
            this.lblColForm = new System.Windows.Forms.Label();
            this.btnNickname = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupCreatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColForm
            // 
            this.ColForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ColForm.FormattingEnabled = true;
            this.ColForm.Location = new System.Drawing.Point(75, 47);
            this.ColForm.Name = "ColForm";
            this.ColForm.Size = new System.Drawing.Size(191, 24);
            this.ColForm.TabIndex = 0;
            // 
            // lblSett
            // 
            this.lblSett.AutoSize = true;
            this.lblSett.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSett.Location = new System.Drawing.Point(124, 9);
            this.lblSett.Name = "lblSett";
            this.lblSett.Size = new System.Drawing.Size(91, 20);
            this.lblSett.TabIndex = 1;
            this.lblSett.Text = "Настройки";
            // 
            // lblColForm
            // 
            this.lblColForm.AutoSize = true;
            this.lblColForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblColForm.Location = new System.Drawing.Point(23, 50);
            this.lblColForm.Name = "lblColForm";
            this.lblColForm.Size = new System.Drawing.Size(46, 17);
            this.lblColForm.TabIndex = 1;
            this.lblColForm.Text = "Тема:";
            // 
            // btnNickname
            // 
            this.btnNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNickname.Location = new System.Drawing.Point(98, 90);
            this.btnNickname.Name = "btnNickname";
            this.btnNickname.Size = new System.Drawing.Size(147, 39);
            this.btnNickname.TabIndex = 2;
            this.btnNickname.Text = "Сменить имя";
            this.btnNickname.UseVisualStyleBackColor = true;
            this.btnNickname.Click += new System.EventHandler(this.btnNickname_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(87, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupCreatebtn
            // 
            this.GroupCreatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GroupCreatebtn.Location = new System.Drawing.Point(98, 146);
            this.GroupCreatebtn.Name = "GroupCreatebtn";
            this.GroupCreatebtn.Size = new System.Drawing.Size(147, 40);
            this.GroupCreatebtn.TabIndex = 3;
            this.GroupCreatebtn.Text = "Создать группу";
            this.GroupCreatebtn.UseVisualStyleBackColor = true;
            this.GroupCreatebtn.Click += new System.EventHandler(this.GroupCreatebtn_Click);
            // 
            // SettForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(336, 259);
            this.Controls.Add(this.GroupCreatebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNickname);
            this.Controls.Add(this.lblColForm);
            this.Controls.Add(this.lblSett);
            this.Controls.Add(this.ColForm);
            this.Name = "SettForm";
            this.Text = "Messenger Top";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColForm;
        private System.Windows.Forms.Label lblSett;
        private System.Windows.Forms.Label lblColForm;
        private System.Windows.Forms.Button btnNickname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GroupCreatebtn;
    }
}