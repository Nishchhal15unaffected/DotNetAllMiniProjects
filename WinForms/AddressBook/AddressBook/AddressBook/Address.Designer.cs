namespace AddressBook
{
    partial class Address
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
            this.addressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.LandMarkLabel = new System.Windows.Forms.Label();
            this.LandmarkTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.saveRecordLabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(239, 66);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(58, 16);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(303, 63);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(128, 22);
            this.AddressTextBox.TabIndex = 1;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(237, 110);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(29, 16);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(303, 107);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(128, 22);
            this.CityTextBox.TabIndex = 2;
            // 
            // LandMarkLabel
            // 
            this.LandMarkLabel.AutoSize = true;
            this.LandMarkLabel.Location = new System.Drawing.Point(216, 159);
            this.LandMarkLabel.Name = "LandMarkLabel";
            this.LandMarkLabel.Size = new System.Drawing.Size(67, 16);
            this.LandMarkLabel.TabIndex = 0;
            this.LandMarkLabel.Text = "Landmark";
            // 
            // LandmarkTextBox
            // 
            this.LandmarkTextBox.Location = new System.Drawing.Point(303, 156);
            this.LandmarkTextBox.Name = "LandmarkTextBox";
            this.LandmarkTextBox.Size = new System.Drawing.Size(128, 22);
            this.LandmarkTextBox.TabIndex = 3;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(208, 202);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(81, 16);
            this.postalCodeLabel.TabIndex = 0;
            this.postalCodeLabel.Text = "Postal Code";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.Location = new System.Drawing.Point(303, 199);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(128, 22);
            this.PostalCodeTextBox.TabIndex = 4;
            // 
            // saveRecordLabel
            // 
            this.saveRecordLabel.Location = new System.Drawing.Point(212, 247);
            this.saveRecordLabel.Name = "saveRecordLabel";
            this.saveRecordLabel.Size = new System.Drawing.Size(219, 23);
            this.saveRecordLabel.TabIndex = 5;
            this.saveRecordLabel.Text = "Save Record";
            this.saveRecordLabel.UseVisualStyleBackColor = true;
            this.saveRecordLabel.Click += new System.EventHandler(this.saveRecordLabel_Click);
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveRecordLabel);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.LandmarkTextBox);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.LandMarkLabel);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.addressLabel);
            this.Name = "Address";
            this.Text = "Address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label LandMarkLabel;
        private System.Windows.Forms.TextBox LandmarkTextBox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.Button saveRecordLabel;
    }
}