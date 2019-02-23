namespace FlightReservationApp
{
    partial class InsPlane
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsPlane));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSavePlane = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtAirline = new System.Windows.Forms.TextBox();
            this.txtPlaneName = new System.Windows.Forms.TextBox();
            this.txtPlaneNo = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlaneColor = new System.Windows.Forms.TextBox();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::FlightReservationApp.WaitForm2), true, true);
            this.planeImg = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planeImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPlaneColor);
            this.groupBox1.Controls.Add(this.btnSavePlane);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.planeImg);
            this.groupBox1.Controls.Add(this.txtAirline);
            this.groupBox1.Controls.Add(this.txtPlaneName);
            this.groupBox1.Controls.Add(this.txtPlaneNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 240);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plane Info";
            // 
            // btnSavePlane
            // 
            this.btnSavePlane.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePlane.Appearance.Options.UseFont = true;
            this.btnSavePlane.Location = new System.Drawing.Point(20, 177);
            this.btnSavePlane.Name = "btnSavePlane";
            this.btnSavePlane.Size = new System.Drawing.Size(185, 47);
            this.btnSavePlane.TabIndex = 15;
            this.btnSavePlane.Text = "Save Record";
            this.btnSavePlane.Click += new System.EventHandler(this.btnSavePlane_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(328, 201);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(86, 23);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "Clear Image";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(242, 201);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(80, 23);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "Load Image";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtAirline
            // 
            this.txtAirline.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAirline.Location = new System.Drawing.Point(222, 30);
            this.txtAirline.Name = "txtAirline";
            this.txtAirline.Size = new System.Drawing.Size(185, 22);
            this.txtAirline.TabIndex = 11;
            this.txtAirline.Text = " Airline";
            // 
            // txtPlaneName
            // 
            this.txtPlaneName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPlaneName.Location = new System.Drawing.Point(20, 69);
            this.txtPlaneName.Name = "txtPlaneName";
            this.txtPlaneName.Size = new System.Drawing.Size(185, 22);
            this.txtPlaneName.TabIndex = 10;
            this.txtPlaneName.Text = " Plane Name";
            // 
            // txtPlaneNo
            // 
            this.txtPlaneNo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPlaneNo.Location = new System.Drawing.Point(20, 30);
            this.txtPlaneNo.Name = "txtPlaneNo";
            this.txtPlaneNo.Size = new System.Drawing.Size(185, 22);
            this.txtPlaneNo.TabIndex = 9;
            this.txtPlaneNo.Text = " Plane No";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Vivaldi", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 34);
            this.label2.TabIndex = 29;
            this.label2.Text = "Plane";
            // 
            // txtPlaneColor
            // 
            this.txtPlaneColor.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPlaneColor.Location = new System.Drawing.Point(20, 108);
            this.txtPlaneColor.Name = "txtPlaneColor";
            this.txtPlaneColor.Size = new System.Drawing.Size(185, 22);
            this.txtPlaneColor.TabIndex = 16;
            this.txtPlaneColor.Text = " Plane Color";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // planeImg
            // 
            this.planeImg.Image = global::FlightReservationApp.Properties.Resources.user_male_shape_in_a_circle_ios_7_interface_symbol_318_35357;
            this.planeImg.Location = new System.Drawing.Point(247, 87);
            this.planeImg.Name = "planeImg";
            this.planeImg.Size = new System.Drawing.Size(160, 96);
            this.planeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planeImg.TabIndex = 12;
            this.planeImg.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FlightReservationApp.Properties.Resources.dark_gray_solid;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 374);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // InsPlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 374);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsPlane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Reservation App";
            this.Load += new System.EventHandler(this.InsPlane_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planeImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAirline;
        private System.Windows.Forms.TextBox txtPlaneName;
        private System.Windows.Forms.TextBox txtPlaneNo;
        private DevExpress.XtraEditors.SimpleButton btnSavePlane;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox planeImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlaneColor;
        public DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}