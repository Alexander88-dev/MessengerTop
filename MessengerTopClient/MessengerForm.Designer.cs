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
            this.listBox = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.написатьСообщениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеСообщенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пригласитьВГруппуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip.SuspendLayout();
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
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(12, 64);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(304, 544);
            this.listBox.TabIndex = 1;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F);
            this.richTextBox1.Location = new System.Drawing.Point(322, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(814, 502);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(324, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 39);
            this.label.TabIndex = 5;
            this.label.Text = "_";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.написатьСообщениеToolStripMenuItem,
            this.удалитьВсеСообщенияToolStripMenuItem,
            this.пригласитьВГруппуToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip2";
            this.contextMenuStrip.Size = new System.Drawing.Size(207, 70);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(322, 564);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(725, 47);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1044, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "▶";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MessengerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1131, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.btnSettings);
            this.Name = "MessengerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger Top";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessengerForm_FormClosing);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem написатьСообщениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеСообщенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пригласитьВГруппуToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}