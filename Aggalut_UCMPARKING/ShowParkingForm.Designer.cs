namespace Aggalut_UCMPARKING
{
    partial class ShowParkingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowParkingForm));
            this.parkingGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.countLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.getCountButton = new System.Windows.Forms.Button();
            this.parkingButton = new System.Windows.Forms.Button();
            this.parkingComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.parkingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // parkingGridView
            // 
            this.parkingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parkingGridView.Location = new System.Drawing.Point(24, 148);
            this.parkingGridView.Name = "parkingGridView";
            this.parkingGridView.Size = new System.Drawing.Size(870, 257);
            this.parkingGridView.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(789, 496);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // countLabel
            // 
            this.countLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countLabel.Location = new System.Drawing.Point(114, 442);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(137, 32);
            this.countLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parking Count:";
            // 
            // getCountButton
            // 
            this.getCountButton.Location = new System.Drawing.Point(81, 512);
            this.getCountButton.Name = "getCountButton";
            this.getCountButton.Size = new System.Drawing.Size(137, 23);
            this.getCountButton.TabIndex = 6;
            this.getCountButton.Text = "Get Parking Lot Total";
            this.getCountButton.UseVisualStyleBackColor = true;
            this.getCountButton.Click += new System.EventHandler(this.getCountButton_Click);
            // 
            // parkingButton
            // 
            this.parkingButton.Location = new System.Drawing.Point(281, 83);
            this.parkingButton.Name = "parkingButton";
            this.parkingButton.Size = new System.Drawing.Size(199, 23);
            this.parkingButton.TabIndex = 7;
            this.parkingButton.Text = "Check Parking Status";
            this.parkingButton.UseVisualStyleBackColor = true;
            this.parkingButton.Click += new System.EventHandler(this.parkingButton_Click);
            // 
            // parkingComboBox
            // 
            this.parkingComboBox.FormattingEnabled = true;
            this.parkingComboBox.Location = new System.Drawing.Point(49, 85);
            this.parkingComboBox.Name = "parkingComboBox";
            this.parkingComboBox.Size = new System.Drawing.Size(202, 21);
            this.parkingComboBox.TabIndex = 8;
            this.parkingComboBox.SelectedIndexChanged += new System.EventHandler(this.parkingComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 44);
            this.label4.TabIndex = 16;
            this.label4.Text = "PARKING AT UCM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(622, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ShowParkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 574);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.parkingComboBox);
            this.Controls.Add(this.parkingButton);
            this.Controls.Add(this.getCountButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.parkingGridView);
            this.Name = "ShowParkingForm";
            this.Text = "ShowParkingForm";
            this.Load += new System.EventHandler(this.ShowParkingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parkingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView parkingGridView;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button getCountButton;
        private System.Windows.Forms.Button parkingButton;
        private System.Windows.Forms.ComboBox parkingComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}