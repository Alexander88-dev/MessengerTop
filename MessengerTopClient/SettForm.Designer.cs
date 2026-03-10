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
            this.lblNickname = new System.Windows.Forms.Label();
            this.BtnCol = new System.Windows.Forms.ComboBox();
            this.lblColbtn = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GroupCreatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ColForm
            // 
            this.ColForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ColForm.FormattingEnabled = true;
            this.ColForm.Location = new System.Drawing.Point(134, 47);
            this.ColForm.Name = "ColForm";
            this.ColForm.Size = new System.Drawing.Size(138, 24);
            this.ColForm.TabIndex = 0;
            // 
            // lblSett
            // 
            this.lblSett.AutoSize = true;
            this.lblSett.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSett.Location = new System.Drawing.Point(130, 9);
            this.lblSett.Name = "lblSett";
            this.lblSett.Size = new System.Drawing.Size(91, 20);
            this.lblSett.TabIndex = 1;
            this.lblSett.Text = "Настройки";
            // 
            // lblColForm
            // 
            this.lblColForm.AutoSize = true;
            this.lblColForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblColForm.Location = new System.Drawing.Point(29, 50);
            this.lblColForm.Name = "lblColForm";
            this.lblColForm.Size = new System.Drawing.Size(99, 17);
            this.lblColForm.TabIndex = 1;
            this.lblColForm.Text = "Цвет формы :";
            // 
            // btnNickname
            // 
            this.btnNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNickname.Location = new System.Drawing.Point(234, 125);
            this.btnNickname.Name = "btnNickname";
            this.btnNickname.Size = new System.Drawing.Size(123, 31);
            this.btnNickname.TabIndex = 2;
            this.btnNickname.Text = "Сменить имя";
            this.btnNickname.UseVisualStyleBackColor = true;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNickname.Location = new System.Drawing.Point(29, 132);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(199, 17);
            this.lblNickname.TabIndex = 1;
            this.lblNickname.Text = "Смена имени пользователя :";
            // 
            // BtnCol
            // 
            this.BtnCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnCol.FormattingEnabled = true;
            this.BtnCol.Location = new System.Drawing.Point(134, 87);
            this.BtnCol.Name = "BtnCol";
            this.BtnCol.Size = new System.Drawing.Size(138, 24);
            this.BtnCol.TabIndex = 0;
            // 
            // lblColbtn
            // 
            this.lblColbtn.AutoSize = true;
            this.lblColbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblColbtn.Location = new System.Drawing.Point(29, 90);
            this.lblColbtn.Name = "lblColbtn";
            this.lblColbtn.Size = new System.Drawing.Size(99, 17);
            this.lblColbtn.TabIndex = 1;
            this.lblColbtn.Text = "Цвет кнопок :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(12, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GroupCreatebtn
            // 
            this.GroupCreatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GroupCreatebtn.Location = new System.Drawing.Point(189, 180);
            this.GroupCreatebtn.Name = "GroupCreatebtn";
            this.GroupCreatebtn.Size = new System.Drawing.Size(168, 40);
            this.GroupCreatebtn.TabIndex = 3;
            this.GroupCreatebtn.Text = "Создать группу";
            this.GroupCreatebtn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 234);
            this.Controls.Add(this.GroupCreatebtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNickname);
            this.Controls.Add(this.lblNickname);
            this.Controls.Add(this.lblColbtn);
            this.Controls.Add(this.lblColForm);
            this.Controls.Add(this.BtnCol);
            this.Controls.Add(this.lblSett);
            this.Controls.Add(this.ColForm);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColForm;
        private System.Windows.Forms.Label lblSett;
        private System.Windows.Forms.Label lblColForm;
        private System.Windows.Forms.Button btnNickname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.ComboBox BtnCol;
        private System.Windows.Forms.Label lblColbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button GroupCreatebtn;
    }
}