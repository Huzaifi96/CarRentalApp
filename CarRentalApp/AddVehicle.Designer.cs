namespace CarRentalApp
{
    partial class AddVehicle
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.licensePlateTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.lisensePlateLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.vinLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.mainHeading = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.28287F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.71713F));
            this.tableLayoutPanel1.Controls.Add(this.licensePlateTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.yearTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.vinTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.modelTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lisensePlateLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.yearLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.vinLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.makeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.modelLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.makeTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 324);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // licensePlateTextBox
            // 
            this.licensePlateTextBox.Location = new System.Drawing.Point(150, 259);
            this.licensePlateTextBox.Name = "licensePlateTextBox";
            this.licensePlateTextBox.Size = new System.Drawing.Size(310, 22);
            this.licensePlateTextBox.TabIndex = 13;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(150, 195);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(310, 22);
            this.yearTextBox.TabIndex = 12;
            // 
            // vinTextBox
            // 
            this.vinTextBox.Location = new System.Drawing.Point(150, 131);
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.Size = new System.Drawing.Size(310, 22);
            this.vinTextBox.TabIndex = 11;
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(150, 67);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(310, 22);
            this.modelTextBox.TabIndex = 10;
            // 
            // lisensePlateLabel
            // 
            this.lisensePlateLabel.AutoSize = true;
            this.lisensePlateLabel.Location = new System.Drawing.Point(3, 256);
            this.lisensePlateLabel.Name = "lisensePlateLabel";
            this.lisensePlateLabel.Size = new System.Drawing.Size(115, 16);
            this.lisensePlateLabel.TabIndex = 8;
            this.lisensePlateLabel.Text = "License Plate No :";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(3, 192);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(42, 16);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Year :";
            // 
            // vinLabel
            // 
            this.vinLabel.AutoSize = true;
            this.vinLabel.Location = new System.Drawing.Point(3, 128);
            this.vinLabel.Name = "vinLabel";
            this.vinLabel.Size = new System.Drawing.Size(35, 16);
            this.vinLabel.TabIndex = 4;
            this.vinLabel.Text = "VIN :";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(3, 0);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(47, 16);
            this.makeLabel.TabIndex = 0;
            this.makeLabel.Text = "Make :";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(3, 64);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(51, 16);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model :";
            // 
            // makeTextBox
            // 
            this.makeTextBox.Location = new System.Drawing.Point(150, 3);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(310, 22);
            this.makeTextBox.TabIndex = 9;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(66, 422);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(222, 50);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(346, 422);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(222, 50);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // mainHeading
            // 
            this.mainHeading.AutoSize = true;
            this.mainHeading.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainHeading.Location = new System.Drawing.Point(129, 14);
            this.mainHeading.Name = "mainHeading";
            this.mainHeading.Size = new System.Drawing.Size(361, 48);
            this.mainHeading.TabIndex = 3;
            this.mainHeading.Text = "Add New Vehicle";
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 484);
            this.Controls.Add(this.mainHeading);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AddVehicle";
            this.Text = "Add Vehicle";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label mainHeading;
        private System.Windows.Forms.TextBox licensePlateTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox vinTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label lisensePlateLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label vinLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox makeTextBox;
    }
}