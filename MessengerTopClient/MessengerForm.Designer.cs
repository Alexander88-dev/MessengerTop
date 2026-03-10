namespace MessengerTopClient
{
    partial class MessengerForm
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
            this.components = new System.ComponentModel.Container();
            this.btnSettings = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.написатьСообщениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеСообщенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пригласитьВГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSettings.Location = new System.Drawing.Point(12, 22);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(174, 36);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(342, 704);
            this.listBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F);
            this.richTextBox1.Location = new System.Drawing.Point(360, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(759, 706);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(366, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(411, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.написатьСообщениеToolStripMenuItem,
            this.удалитьВсеСообщенияToolStripMenuItem,
            this.пригласитьВГруппуToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(207, 70);
            // 
            // написатьСообщениеToolStripMenuItem
            // 
            this.написатьСообщениеToolStripMenuItem.Name = "написатьСообщениеToolStripMenuItem";
            this.написатьСообщениеToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.написатьСообщениеToolStripMenuItem.Text = "Написать сообщение";
            // 
            // удалитьВсеСообщенияToolStripMenuItem
            // 
            this.удалитьВсеСообщенияToolStripMenuItem.Name = "удалитьВсеСообщенияToolStripMenuItem";
            this.удалитьВсеСообщенияToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.удалитьВсеСообщенияToolStripMenuItem.Text = "Удалить все сообщения";
            // 
            // пригласитьВГруппуToolStripMenuItem
            // 
            this.пригласитьВГруппуToolStripMenuItem.Name = "пригласитьВГруппуToolStripMenuItem";
            this.пригласитьВГруппуToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.пригласитьВГруппуToolStripMenuItem.Text = "Пригласить в группу";
            // 
            // MessengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1131, 776);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSettings);
            this.Name = "MessengerForm";
            this.Text = "Form2";
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem написатьСообщениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеСообщенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пригласитьВГруппуToolStripMenuItem;
    }
}