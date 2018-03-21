namespace Joe_s_Automotive
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
            this.customerButton = new System.Windows.Forms.Button();
            this.vehicleButton = new System.Windows.Forms.Button();
            this.partsButton = new System.Windows.Forms.Button();
            this.invoicesButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.invoicesRadioButton = new System.Windows.Forms.RadioButton();
            this.partsRadioButton = new System.Windows.Forms.RadioButton();
            this.VehicleRadioButton = new System.Windows.Forms.RadioButton();
            this.customerRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerButton
            // 
            this.customerButton.Location = new System.Drawing.Point(40, 96);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(75, 23);
            this.customerButton.TabIndex = 0;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = true;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // vehicleButton
            // 
            this.vehicleButton.Location = new System.Drawing.Point(40, 215);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(75, 23);
            this.vehicleButton.TabIndex = 2;
            this.vehicleButton.Text = "Vehicle";
            this.vehicleButton.UseVisualStyleBackColor = true;
            this.vehicleButton.Click += new System.EventHandler(this.vehicleButton_Click);
            // 
            // partsButton
            // 
            this.partsButton.Location = new System.Drawing.Point(40, 153);
            this.partsButton.Name = "partsButton";
            this.partsButton.Size = new System.Drawing.Size(75, 23);
            this.partsButton.TabIndex = 1;
            this.partsButton.Text = "Parts";
            this.partsButton.UseVisualStyleBackColor = true;
            this.partsButton.Click += new System.EventHandler(this.partsButton_Click);
            // 
            // invoicesButton
            // 
            this.invoicesButton.Location = new System.Drawing.Point(40, 271);
            this.invoicesButton.Name = "invoicesButton";
            this.invoicesButton.Size = new System.Drawing.Size(75, 23);
            this.invoicesButton.TabIndex = 3;
            this.invoicesButton.Text = "Invoices";
            this.invoicesButton.UseVisualStyleBackColor = true;
            this.invoicesButton.Click += new System.EventHandler(this.invoicesButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(220, 318);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // invoicesRadioButton
            // 
            this.invoicesRadioButton.AutoSize = true;
            this.invoicesRadioButton.Location = new System.Drawing.Point(193, 235);
            this.invoicesRadioButton.Name = "invoicesRadioButton";
            this.invoicesRadioButton.Size = new System.Drawing.Size(65, 17);
            this.invoicesRadioButton.TabIndex = 7;
            this.invoicesRadioButton.TabStop = true;
            this.invoicesRadioButton.Text = "Invoices";
            this.invoicesRadioButton.UseVisualStyleBackColor = true;
            // 
            // partsRadioButton
            // 
            this.partsRadioButton.AutoSize = true;
            this.partsRadioButton.Location = new System.Drawing.Point(193, 197);
            this.partsRadioButton.Name = "partsRadioButton";
            this.partsRadioButton.Size = new System.Drawing.Size(49, 17);
            this.partsRadioButton.TabIndex = 6;
            this.partsRadioButton.TabStop = true;
            this.partsRadioButton.Text = "Parts";
            this.partsRadioButton.UseVisualStyleBackColor = true;
            // 
            // VehicleRadioButton
            // 
            this.VehicleRadioButton.AutoSize = true;
            this.VehicleRadioButton.Location = new System.Drawing.Point(193, 155);
            this.VehicleRadioButton.Name = "VehicleRadioButton";
            this.VehicleRadioButton.Size = new System.Drawing.Size(60, 17);
            this.VehicleRadioButton.TabIndex = 5;
            this.VehicleRadioButton.TabStop = true;
            this.VehicleRadioButton.Text = "Vehicle";
            this.VehicleRadioButton.UseVisualStyleBackColor = true;
            // 
            // customerRadioButton
            // 
            this.customerRadioButton.AutoSize = true;
            this.customerRadioButton.Location = new System.Drawing.Point(193, 118);
            this.customerRadioButton.Name = "customerRadioButton";
            this.customerRadioButton.Size = new System.Drawing.Size(69, 17);
            this.customerRadioButton.TabIndex = 4;
            this.customerRadioButton.TabStop = true;
            this.customerRadioButton.Text = "Customer";
            this.customerRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "I am looking for...";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(183, 271);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(155, 20);
            this.searchTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Joe\'s Automotives";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Joe_s_Automotive.Properties.Resources.Dodge_Ram;
            this.pictureBox1.Location = new System.Drawing.Point(310, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerRadioButton);
            this.Controls.Add(this.VehicleRadioButton);
            this.Controls.Add(this.partsRadioButton);
            this.Controls.Add(this.invoicesRadioButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.invoicesButton);
            this.Controls.Add(this.partsButton);
            this.Controls.Add(this.vehicleButton);
            this.Controls.Add(this.customerButton);
            this.Name = "Form1";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Button vehicleButton;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.Button invoicesButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.RadioButton invoicesRadioButton;
        private System.Windows.Forms.RadioButton partsRadioButton;
        private System.Windows.Forms.RadioButton VehicleRadioButton;
        private System.Windows.Forms.RadioButton customerRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

