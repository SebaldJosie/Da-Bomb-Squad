namespace Joe_s_Automotive
{
    partial class Vehicle
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
            this.label1 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.vehiclesDataSet1 = new Joe_s_Automotive.VehiclesDataSet();
            this.vehiclesDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesDataSet2 = new Joe_s_Automotive.VehiclesDataSet();
            this.vehiclesDataSet3 = new Joe_s_Automotive.VehiclesDataSet();
            this.vehiclesDataSet4 = new Joe_s_Automotive.VehiclesDataSet();
            this.doneButton = new System.Windows.Forms.Button();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.returnedLabel = new System.Windows.Forms.Label();
            this.invoicesLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.partsAvailableLabel = new System.Windows.Forms.Label();
            this.receivedLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicles";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(349, 20);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 2;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // vehiclesDataSet1
            // 
            this.vehiclesDataSet1.DataSetName = "VehiclesDataSet";
            this.vehiclesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclesDataSet1BindingSource
            // 
            this.vehiclesDataSet1BindingSource.DataSource = this.vehiclesDataSet1;
            this.vehiclesDataSet1BindingSource.Position = 0;
            // 
            // vehiclesDataSet2
            // 
            this.vehiclesDataSet2.DataSetName = "VehiclesDataSet";
            this.vehiclesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclesDataSet3
            // 
            this.vehiclesDataSet3.DataSetName = "VehiclesDataSet";
            this.vehiclesDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclesDataSet4
            // 
            this.vehiclesDataSet4.DataSetName = "VehiclesDataSet";
            this.vehiclesDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(165, 312);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(75, 23);
            this.doneButton.TabIndex = 43;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // carPictureBox
            // 
            this.carPictureBox.Location = new System.Drawing.Point(291, 77);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(246, 139);
            this.carPictureBox.TabIndex = 42;
            this.carPictureBox.TabStop = false;
            // 
            // yearLabel
            // 
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yearLabel.Location = new System.Drawing.Point(26, 193);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(100, 23);
            this.yearLabel.TabIndex = 41;
            this.yearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // modelLabel
            // 
            this.modelLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelLabel.Location = new System.Drawing.Point(26, 135);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(100, 23);
            this.modelLabel.TabIndex = 40;
            this.modelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ownerLabel
            // 
            this.ownerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ownerLabel.Location = new System.Drawing.Point(155, 79);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(100, 25);
            this.ownerLabel.TabIndex = 39;
            this.ownerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // returnedLabel
            // 
            this.returnedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.returnedLabel.Location = new System.Drawing.Point(26, 369);
            this.returnedLabel.Name = "returnedLabel";
            this.returnedLabel.Size = new System.Drawing.Size(100, 22);
            this.returnedLabel.TabIndex = 38;
            this.returnedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // invoicesLabel
            // 
            this.invoicesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoicesLabel.Location = new System.Drawing.Point(155, 135);
            this.invoicesLabel.Name = "invoicesLabel";
            this.invoicesLabel.Size = new System.Drawing.Size(100, 25);
            this.invoicesLabel.TabIndex = 37;
            this.invoicesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notesLabel
            // 
            this.notesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notesLabel.Location = new System.Drawing.Point(309, 252);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(213, 139);
            this.notesLabel.TabIndex = 36;
            this.notesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mileageLabel
            // 
            this.mileageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mileageLabel.Location = new System.Drawing.Point(26, 252);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(100, 22);
            this.mileageLabel.TabIndex = 35;
            this.mileageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partsAvailableLabel
            // 
            this.partsAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsAvailableLabel.Location = new System.Drawing.Point(155, 193);
            this.partsAvailableLabel.Name = "partsAvailableLabel";
            this.partsAvailableLabel.Size = new System.Drawing.Size(100, 81);
            this.partsAvailableLabel.TabIndex = 34;
            this.partsAvailableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receivedLabel
            // 
            this.receivedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receivedLabel.Location = new System.Drawing.Point(26, 312);
            this.receivedLabel.Name = "receivedLabel";
            this.receivedLabel.Size = new System.Drawing.Size(100, 22);
            this.receivedLabel.TabIndex = 33;
            this.receivedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Notes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Parts Available:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Invoices:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Owner:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Date Returned:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Date Received:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mileage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Model:";
            // 
            // makeLabel
            // 
            this.makeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.makeLabel.Location = new System.Drawing.Point(26, 79);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(100, 23);
            this.makeLabel.TabIndex = 23;
            this.makeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Make:";
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 409);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.carPictureBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.returnedLabel);
            this.Controls.Add(this.invoicesLabel);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.mileageLabel);
            this.Controls.Add(this.partsAvailableLabel);
            this.Controls.Add(this.receivedLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label1);
            this.Name = "Vehicle";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnButton;
        private VehiclesDataSet vehiclesDataSet1;
        private System.Windows.Forms.BindingSource vehiclesDataSet1BindingSource;
        private VehiclesDataSet vehiclesDataSet2;
        private VehiclesDataSet vehiclesDataSet3;
        private VehiclesDataSet vehiclesDataSet4;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label returnedLabel;
        private System.Windows.Forms.Label invoicesLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Label partsAvailableLabel;
        private System.Windows.Forms.Label receivedLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label label11;
    }
}