namespace MessageWallApp
{
    partial class MessageWall
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
            this.MessageLabel = new System.Windows.Forms.Label();
            this.messageInput = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageListLabel = new System.Windows.Forms.Label();
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(170, 67);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(99, 16);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "Type Message";
            // 
            // messageInput
            // 
            this.messageInput.Location = new System.Drawing.Point(275, 64);
            this.messageInput.Name = "messageInput";
            this.messageInput.Size = new System.Drawing.Size(142, 22);
            this.messageInput.TabIndex = 1;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(439, 63);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageListLabel
            // 
            this.MessageListLabel.AutoSize = true;
            this.MessageListLabel.Location = new System.Drawing.Point(170, 122);
            this.MessageListLabel.Name = "MessageListLabel";
            this.MessageListLabel.Size = new System.Drawing.Size(87, 16);
            this.MessageListLabel.TabIndex = 0;
            this.MessageListLabel.Text = "Message List";
            // 
            // MessageListBox
            // 
            this.MessageListBox.FormattingEnabled = true;
            this.MessageListBox.ItemHeight = 16;
            this.MessageListBox.Location = new System.Drawing.Point(173, 167);
            this.MessageListBox.Name = "MessageListBox";
            this.MessageListBox.Size = new System.Drawing.Size(341, 148);
            this.MessageListBox.TabIndex = 3;
            this.MessageListBox.TabStop = false;
            // 
            // MessageWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MessageListBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.MessageListLabel);
            this.Controls.Add(this.MessageLabel);
            this.Name = "MessageWall";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox messageInput;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label MessageListLabel;
        private System.Windows.Forms.ListBox MessageListBox;
    }
}

