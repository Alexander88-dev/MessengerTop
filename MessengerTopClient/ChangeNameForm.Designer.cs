namespace MessengerTopClient
{
    partial class ChangeNameForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblErr = new System.Windows.Forms.Label();
            this.txtBoxChange = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(58, 173);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(92, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(222, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Смените имя пользователя";
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblErr.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblErr.Location = new System.Drawing.Point(55, 120);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(296, 15);
            this.lblErr.TabIndex = 2;
            this.lblErr.Text = "Имя успешно изменено / Не удалось сменить имя";
            // 
            // txtBoxChange
            // 
            this.txtBoxChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxChange.Location = new System.Drawing.Point(12, 85);
            this.txtBoxChange.Name = "txtBoxChange";
            this.txtBoxChange.Size = new System.Drawing.Size(388, 23);
            this.txtBoxChange.TabIndex = 3;
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChange.Location = new System.Drawing.Point(240, 173);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(111, 36);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Сменить ";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // ChangeNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 238);
            this.Controls.Add(this.txtBoxChange);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ChangeNameForm";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.TextBox txtBoxChange;
        private System.Windows.Forms.Button btnChange;
    }
}