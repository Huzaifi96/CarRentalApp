namespace CarRentalApp
{
    partial class AddRentalRecord
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
            this.mainHeading = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.dateRentedLabel = new System.Windows.Forms.Label();
            this.dateRentPicker = new System.Windows.Forms.DateTimePicker();
            this.dateReturnPicker = new System.Windows.Forms.DateTimePicker();
            this.dateReturnedLabel = new System.Windows.Forms.Label();
            this.typeOfCarLabel = new System.Windows.Forms.Label();
            this.cbCarSelected = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainHeading
            // 
            this.mainHeading.AutoSize = true;
            this.mainHeading.Font = new System.Drawing.Font("Lucida Sans Unicode", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeading.Location = new System.Drawing.Point(100, 37);
            this.mainHeading.Name = "mainHeading";
            this.mainHeading.Size = new System.Drawing.Size(733, 91);
            this.mainHeading.TabIndex = 0;
            this.mainHeading.Text = "Add Rental Record";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(31, 157);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(154, 25);
            this.customerNameLabel.TabIndex = 1;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(36, 194);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(260, 22);
            this.tbCustomerName.TabIndex = 2;
            // 
            // dateRentedLabel
            // 
            this.dateRentedLabel.AutoSize = true;
            this.dateRentedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRentedLabel.Location = new System.Drawing.Point(31, 247);
            this.dateRentedLabel.Name = "dateRentedLabel";
            this.dateRentedLabel.Size = new System.Drawing.Size(120, 25);
            this.dateRentedLabel.TabIndex = 3;
            this.dateRentedLabel.Text = "Date Rented";
            // 
            // dateRentPicker
            // 
            this.dateRentPicker.Location = new System.Drawing.Point(36, 294);
            this.dateRentPicker.Name = "dateRentPicker";
            this.dateRentPicker.Size = new System.Drawing.Size(260, 22);
            this.dateRentPicker.TabIndex = 4;
            // 
            // dateReturnPicker
            // 
            this.dateReturnPicker.Location = new System.Drawing.Point(471, 294);
            this.dateReturnPicker.Name = "dateReturnPicker";
            this.dateReturnPicker.Size = new System.Drawing.Size(260, 22);
            this.dateReturnPicker.TabIndex = 6;
            // 
            // dateReturnedLabel
            // 
            this.dateReturnedLabel.AutoSize = true;
            this.dateReturnedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReturnedLabel.Location = new System.Drawing.Point(466, 247);
            this.dateReturnedLabel.Name = "dateReturnedLabel";
            this.dateReturnedLabel.Size = new System.Drawing.Size(137, 25);
            this.dateReturnedLabel.TabIndex = 5;
            this.dateReturnedLabel.Text = "Date Returned";
            // 
            // typeOfCarLabel
            // 
            this.typeOfCarLabel.AutoSize = true;
            this.typeOfCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfCarLabel.Location = new System.Drawing.Point(31, 347);
            this.typeOfCarLabel.Name = "typeOfCarLabel";
            this.typeOfCarLabel.Size = new System.Drawing.Size(115, 25);
            this.typeOfCarLabel.TabIndex = 7;
            this.typeOfCarLabel.Text = "Type of Car";
            // 
            // cbCarSelected
            // 
            this.cbCarSelected.FormattingEnabled = true;
            this.cbCarSelected.Location = new System.Drawing.Point(36, 399);
            this.cbCarSelected.Name = "cbCarSelected";
            this.cbCarSelected.Size = new System.Drawing.Size(260, 24);
            this.cbCarSelected.TabIndex = 8;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(490, 347);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(201, 109);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButtonClicked);
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(471, 194);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(260, 22);
            this.tbCost.TabIndex = 10;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(466, 157);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(53, 25);
            this.costLabel.TabIndex = 11;
            this.costLabel.Text = "Cost";
            // 
            // AddRentalRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 495);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.cbCarSelected);
            this.Controls.Add(this.typeOfCarLabel);
            this.Controls.Add(this.dateReturnPicker);
            this.Controls.Add(this.dateReturnedLabel);
            this.Controls.Add(this.dateRentPicker);
            this.Controls.Add(this.dateRentedLabel);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.mainHeading);
            this.Name = "AddRentalRecord";
            this.Text = "Add Rental Record";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainHeading;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label dateRentedLabel;
        private System.Windows.Forms.DateTimePicker dateRentPicker;
        private System.Windows.Forms.DateTimePicker dateReturnPicker;
        private System.Windows.Forms.Label dateReturnedLabel;
        private System.Windows.Forms.Label typeOfCarLabel;
        private System.Windows.Forms.ComboBox cbCarSelected;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label costLabel;
    }
}

