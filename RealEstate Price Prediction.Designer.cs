namespace RealEstate_Price_Prediction
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EvaluateButton = new Button();
            BathroomLabel = new Label();
            BalconyLabel = new Label();
            BhkLabel = new Label();
            TotalSqmtLabel = new Label();
            LocationLabel = new Label();
            BathroomTextBox = new TextBox();
            BalconyTextBox = new TextBox();
            BhkTextBox = new TextBox();
            LocationTextBox = new TextBox();
            TotalSqmtTextBox = new TextBox();
            OutputLabel = new Label();
            SuspendLayout();
            // 
            // EvaluateButton
            // 
            EvaluateButton.BackColor = Color.White;
            EvaluateButton.FlatAppearance.BorderColor = Color.Black;
            EvaluateButton.FlatAppearance.MouseDownBackColor = Color.Yellow;
            EvaluateButton.FlatAppearance.MouseOverBackColor = Color.Gold;
            EvaluateButton.FlatStyle = FlatStyle.Flat;
            EvaluateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EvaluateButton.ForeColor = Color.Black;
            EvaluateButton.Location = new Point(317, 363);
            EvaluateButton.Name = "EvaluateButton";
            EvaluateButton.Size = new Size(157, 55);
            EvaluateButton.TabIndex = 0;
            EvaluateButton.Text = "Evaluate";
            EvaluateButton.UseVisualStyleBackColor = false;
            EvaluateButton.Click += EvaluateButton_Click;
            // 
            // BathroomLabel
            // 
            BathroomLabel.AutoSize = true;
            BathroomLabel.Location = new Point(87, 52);
            BathroomLabel.Name = "BathroomLabel";
            BathroomLabel.Size = new Size(60, 15);
            BathroomLabel.TabIndex = 1;
            BathroomLabel.Text = "Bathroom";
            BathroomLabel.Click += label1_Click;
            // 
            // BalconyLabel
            // 
            BalconyLabel.AutoSize = true;
            BalconyLabel.Location = new Point(87, 106);
            BalconyLabel.Name = "BalconyLabel";
            BalconyLabel.Size = new Size(49, 15);
            BalconyLabel.TabIndex = 2;
            BalconyLabel.Text = "Balcony";
            // 
            // BhkLabel
            // 
            BhkLabel.AutoSize = true;
            BhkLabel.Location = new Point(87, 163);
            BhkLabel.Name = "BhkLabel";
            BhkLabel.Size = new Size(30, 15);
            BhkLabel.TabIndex = 3;
            BhkLabel.Text = "BHK";
            // 
            // TotalSqmtLabel
            // 
            TotalSqmtLabel.AutoSize = true;
            TotalSqmtLabel.Location = new Point(87, 217);
            TotalSqmtLabel.Name = "TotalSqmtLabel";
            TotalSqmtLabel.Size = new Size(65, 15);
            TotalSqmtLabel.TabIndex = 4;
            TotalSqmtLabel.Text = "Total_Sqmt";
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Location = new Point(87, 272);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(53, 15);
            LocationLabel.TabIndex = 5;
            LocationLabel.Text = "Location";
            LocationLabel.Click += label5_Click;
            // 
            // BathroomTextBox
            // 
            BathroomTextBox.Location = new Point(101, 70);
            BathroomTextBox.Name = "BathroomTextBox";
            BathroomTextBox.Size = new Size(148, 23);
            BathroomTextBox.TabIndex = 6;
            BathroomTextBox.TextChanged += textBox1_TextChanged;
            // 
            // BalconyTextBox
            // 
            BalconyTextBox.Location = new Point(101, 124);
            BalconyTextBox.Name = "BalconyTextBox";
            BalconyTextBox.Size = new Size(148, 23);
            BalconyTextBox.TabIndex = 7;
            // 
            // BhkTextBox
            // 
            BhkTextBox.Location = new Point(101, 181);
            BhkTextBox.Name = "BhkTextBox";
            BhkTextBox.Size = new Size(148, 23);
            BhkTextBox.TabIndex = 8;
            // 
            // LocationTextBox
            // 
            LocationTextBox.Location = new Point(101, 290);
            LocationTextBox.Name = "LocationTextBox";
            LocationTextBox.Size = new Size(148, 23);
            LocationTextBox.TabIndex = 9;
            // 
            // TotalSqmtTextBox
            // 
            TotalSqmtTextBox.Location = new Point(101, 235);
            TotalSqmtTextBox.Name = "TotalSqmtTextBox";
            TotalSqmtTextBox.Size = new Size(148, 23);
            TotalSqmtTextBox.TabIndex = 10;
            // 
            // OutputLabel
            // 
            OutputLabel.AutoSize = true;
            OutputLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            OutputLabel.Location = new Point(479, 163);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(175, 32);
            OutputLabel.TabIndex = 11;
            OutputLabel.Text = "Predicted_Price";
            OutputLabel.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(OutputLabel);
            Controls.Add(TotalSqmtTextBox);
            Controls.Add(LocationTextBox);
            Controls.Add(BhkTextBox);
            Controls.Add(BalconyTextBox);
            Controls.Add(BathroomTextBox);
            Controls.Add(LocationLabel);
            Controls.Add(TotalSqmtLabel);
            Controls.Add(BhkLabel);
            Controls.Add(BalconyLabel);
            Controls.Add(BathroomLabel);
            Controls.Add(EvaluateButton);
            Name = "Form1";
            Text = "Price Prediction";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EvaluateButton;
        private Label BathroomLabel;
        private Label BalconyLabel;
        private Label BhkLabel;
        private Label TotalSqmtLabel;
        private Label LocationLabel;
        private TextBox BathroomTextBox;
        private TextBox BalconyTextBox;
        private TextBox BhkTextBox;
        private TextBox LocationTextBox;
        private TextBox TotalSqmtTextBox;
        private Label OutputLabel;
    }
}