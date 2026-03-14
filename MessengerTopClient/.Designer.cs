namespace MessengerTopClient
{
    partial class Form1
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
        /// </summary>\
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblErr = new System.Windows.Forms.Label();
            this.txtBoxChange = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblNameG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(58, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(111, 36);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGroup.Location = new System.Drawing.Point(120, 29);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(140, 20);
            this.lblGroup.TabIndex = 1;
            this.lblGroup.Text = "Создание группы";
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblErr.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblErr.Location = new System.Drawing.Point(55, 102);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(311, 15);
            this.lblErr.TabIndex = 2;
            this.lblErr.Text = "Группа успешно создана / Не удалось создать группу";
            // 
            // txtBoxChange
            // 
            this.txtBoxChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxChange.Location = new System.Drawing.Point(148, 66);
            this.txtBoxChange.Name = "txtBoxChange";
            this.txtBoxChange.Size = new System.Drawing.Size(252, 23);
            this.txtBoxChange.TabIndex = 3;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCreate.Location = new System.Drawing.Point(240, 135);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(111, 36);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Создать";
            this.btnCreate.UseVisualStyleBackColor = true;
            // 
            // lblNameG
            // 
            this.lblNameG.AutoSize = true;
            this.lblNameG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameG.Location = new System.Drawing.Point(12, 69);
            this.lblNameG.Name = "lblNameG";
            this.lblNameG.Size = new System.Drawing.Size(130, 17);
            this.lblNameG.TabIndex = 1;
            this.lblNameG.Text = "Название группы :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(412, 185);
            this.Controls.Add(this.txtBoxChange);
            this.Controls.Add(this.lblErr);
            this.Controls.Add(this.lblNameG);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Messenger Top";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.TextBox txtBoxChange;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblNameG;
    }
}