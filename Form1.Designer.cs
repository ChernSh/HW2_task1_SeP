namespace T2_task2._1
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
        /// </summary>
        private void InitializeComponent()
        {
            this.messagesTB = new System.Windows.Forms.RichTextBox();
            this.mSendBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.nameBtn = new System.Windows.Forms.Button();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messagesTB
            // 
            this.messagesTB.Location = new System.Drawing.Point(12, 24);
            this.messagesTB.Name = "messagesTB";
            this.messagesTB.ReadOnly = true;
            this.messagesTB.Size = new System.Drawing.Size(382, 402);
            this.messagesTB.TabIndex = 1;
            this.messagesTB.Text = "";
            // 
            // mSendBox
            // 
            this.mSendBox.ForeColor = System.Drawing.Color.DimGray;
            this.mSendBox.Location = new System.Drawing.Point(434, 256);
            this.mSendBox.Name = "mSendBox";
            this.mSendBox.Size = new System.Drawing.Size(230, 22);
            this.mSendBox.TabIndex = 3;
            this.mSendBox.Text = "Написати...";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.sendBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendBtn.Location = new System.Drawing.Point(434, 294);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(230, 48);
            this.sendBtn.TabIndex = 4;
            this.sendBtn.Text = "Надіслати";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // nameBtn
            // 
            this.nameBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.nameBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameBtn.Location = new System.Drawing.Point(434, 138);
            this.nameBtn.Name = "nameBtn";
            this.nameBtn.Size = new System.Drawing.Size(230, 48);
            this.nameBtn.TabIndex = 6;
            this.nameBtn.Text = "Змінити ім\'я";
            this.nameBtn.UseVisualStyleBackColor = false;
            this.nameBtn.Click += new System.EventHandler(this.nameBtn_Click);
            // 
            // nameTB
            // 
            this.nameTB.ForeColor = System.Drawing.Color.DimGray;
            this.nameTB.Location = new System.Drawing.Point(434, 100);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(230, 22);
            this.nameTB.TabIndex = 5;
            this.nameTB.Text = "Ім\'я...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.nameBtn);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.mSendBox);
            this.Controls.Add(this.messagesTB);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox messagesTB;
        private System.Windows.Forms.TextBox mSendBox;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Button nameBtn;
        private System.Windows.Forms.TextBox nameTB;
    }
}

