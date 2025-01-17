namespace AddressBook
{
    partial class Person
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.isActiveCheckBox = new System.Windows.Forms.CheckBox();
            this.addressListLabel = new System.Windows.Forms.Label();
            this.addressListBox = new System.Windows.Forms.ListBox();
            this.addAdressButton = new System.Windows.Forms.Button();
            this.saveAllRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(185, 52);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(72, 16);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(263, 49);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(140, 22);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(185, 91);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(72, 16);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Location = new System.Drawing.Point(185, 128);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(44, 16);
            this.activeLabel.TabIndex = 0;
            this.activeLabel.Text = "Active";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(263, 88);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(140, 22);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Location = new System.Drawing.Point(264, 128);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(18, 17);
            this.isActiveCheckBox.TabIndex = 3;
            this.isActiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // addressListLabel
            // 
            this.addressListLabel.AutoSize = true;
            this.addressListLabel.Location = new System.Drawing.Point(185, 177);
            this.addressListLabel.Name = "addressListLabel";
            this.addressListLabel.Size = new System.Drawing.Size(81, 16);
            this.addressListLabel.TabIndex = 0;
            this.addressListLabel.Text = "Address List";
            // 
            // addressListBox
            // 
            this.addressListBox.FormattingEnabled = true;
            this.addressListBox.ItemHeight = 16;
            this.addressListBox.Location = new System.Drawing.Point(188, 210);
            this.addressListBox.Name = "addressListBox";
            this.addressListBox.Size = new System.Drawing.Size(329, 196);
            this.addressListBox.TabIndex = 5;
            // 
            // addAdressButton
            // 
            this.addAdressButton.Location = new System.Drawing.Point(441, 181);
            this.addAdressButton.Name = "addAdressButton";
            this.addAdressButton.Size = new System.Drawing.Size(75, 23);
            this.addAdressButton.TabIndex = 4;
            this.addAdressButton.Text = "Add";
            this.addAdressButton.UseVisualStyleBackColor = true;
            this.addAdressButton.Click += new System.EventHandler(this.addAdressButton_Click);
            // 
            // saveAllRecord
            // 
            this.saveAllRecord.Location = new System.Drawing.Point(297, 415);
            this.saveAllRecord.Name = "saveAllRecord";
            this.saveAllRecord.Size = new System.Drawing.Size(75, 23);
            this.saveAllRecord.TabIndex = 6;
            this.saveAllRecord.Text = "Save";
            this.saveAllRecord.UseVisualStyleBackColor = true;
            this.saveAllRecord.Click += new System.EventHandler(this.saveAllRecord_Click);
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveAllRecord);
            this.Controls.Add(this.addAdressButton);
            this.Controls.Add(this.addressListBox);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.addressListLabel);
            this.Controls.Add(this.activeLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Person";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.CheckBox isActiveCheckBox;
        private System.Windows.Forms.Label addressListLabel;
        private System.Windows.Forms.ListBox addressListBox;
        private System.Windows.Forms.Button addAdressButton;
        private System.Windows.Forms.Button saveAllRecord;
    }
}

