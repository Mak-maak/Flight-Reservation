namespace FlightReservationApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtfName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.comboCountry = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDepartureAirport = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateTimePicker1Departure = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.no_of_Adults = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.customerImg = new System.Windows.Forms.PictureBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::FlightReservationApp.WaitForm2), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCountry.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboDepartureAirport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_Adults)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FlightReservationApp.Properties.Resources.dark_gray_solid_copy;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1172, 699);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtlName);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.txtfName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(124, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(180, 109);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(72, 20);
            this.rdbFemale.TabIndex = 22;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.Location = new System.Drawing.Point(98, 109);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(56, 20);
            this.rdbMale.TabIndex = 21;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Gender : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtlName
            // 
            this.txtlName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtlName.Location = new System.Drawing.Point(222, 30);
            this.txtlName.Name = "txtlName";
            this.txtlName.Size = new System.Drawing.Size(185, 22);
            this.txtlName.TabIndex = 11;
            this.txtlName.Text = " Last Name";
            // 
            // txtContact
            // 
            this.txtContact.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtContact.Location = new System.Drawing.Point(20, 69);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(185, 22);
            this.txtContact.TabIndex = 10;
            this.txtContact.Text = " Contact No";
            // 
            // txtfName
            // 
            this.txtfName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtfName.Location = new System.Drawing.Point(20, 30);
            this.txtfName.Name = "txtfName";
            this.txtfName.Size = new System.Drawing.Size(185, 22);
            this.txtfName.TabIndex = 9;
            this.txtfName.Text = " First Name";
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtAddress.Location = new System.Drawing.Point(20, 73);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(185, 22);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Text = " Address";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCity);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.comboCountry);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(590, 205);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 105);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Info";
            // 
            // txtCity
            // 
            this.txtCity.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCity.Location = new System.Drawing.Point(222, 30);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(185, 22);
            this.txtCity.TabIndex = 17;
            this.txtCity.Text = " City";
            // 
            // comboCountry
            // 
            this.comboCountry.EditValue = "Country";
            this.comboCountry.Location = new System.Drawing.Point(20, 30);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCountry.Properties.Appearance.Options.UseFont = true;
            this.comboCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboCountry.Properties.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cabo Verde",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Curacao",
            "Cyprus",
            "Czechia",
            "East Timor (see Timor-Leste)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Holy See",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "Jamaica",
            "Japan",
            "Jordan",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Mauritania",
            "Mauritius",
            "Mexico",
            "Micronesia",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montenegro",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Palestinian Territories",
            "Panama",
            "Papua New Guinea",
            "Paraguay",
            "Peru",
            "Philippines",
            "Poland",
            "Portugal",
            "Qatar",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Sint Maarten",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Korea",
            "South Sudan",
            "Spain",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tonga",
            "Trinidad and Tobago",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.comboCountry.Size = new System.Drawing.Size(185, 22);
            this.comboCountry.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDestination);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboDepartureAirport);
            this.groupBox3.Controls.Add(this.comboClass);
            this.groupBox3.Controls.Add(this.dateTimePicker1Departure);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.no_of_Adults);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(124, 383);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 170);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reservation Info";
            // 
            // txtDestination
            // 
            this.txtDestination.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtDestination.Location = new System.Drawing.Point(222, 129);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(185, 22);
            this.txtDestination.TabIndex = 27;
            this.txtDestination.Text = " Destination";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Age 12+";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboDepartureAirport
            // 
            this.comboDepartureAirport.EditValue = "Departure Airport";
            this.comboDepartureAirport.Location = new System.Drawing.Point(20, 129);
            this.comboDepartureAirport.Name = "comboDepartureAirport";
            this.comboDepartureAirport.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartureAirport.Properties.Appearance.Options.UseFont = true;
            this.comboDepartureAirport.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboDepartureAirport.Properties.Items.AddRange(new object[] {
            "Airport (AAW)",
            "Attock Airport (ATG)",
            "Talhar Airport (BDN)",
            "Bahawalnagar Airport (WGB)",
            "Bahawalpur Airport (BHV)",
            "Bannu Airport (BNP)",
            "Campbellpore Airport (CWP)",
            "Chilas Airport (CHB)",
            "Chitral Airport (CJL)",
            "Dadu Airport (DDU)",
            "Dalbandin Airport (DBA)",
            "Dera Ghazi Khan Airport (DEA)",
            "Dera Ismail Khan Airport (DSK)",
            "Faisalabad Airport (LYP)",
            "Gilgit Airport (GIL)",
            "Gujrat Airport (GRT)",
            "Gwadar Airport (GWD)",
            "Hyderabad Airport (HDD)",
            "Islamabad International Airport (ISB)",
            "Jacobabad Airport (JAG)",
            "Jiwani Airport (JIW)",
            "Kadanwari Airport (KCF)",
            "Kalat Airport (KBH)",
            "Quaid-E-Azam International Airport (KHI)",
            "Khuzdar Airport (KDD)",
            "Kohat Airport (OHT)",
            "Allama Iqbal International Airport (LHE)",
            "Lora Lai Airport (LRG)",
            "Mangla Airport (XJM)",
            "Mansehra Airport (HRA)",
            "Mianwali Airport (MWD)",
            "Mirpur Khas Airport (MPD)",
            "Mohenjodaro Airport (MJD)",
            "Multan Airport (MUX)",
            "Muzaffarabad Airport (MFG)",
            "Nawabshah Airport (WNS)",
            "Nushki Airport (NHS)",
            "Ormara Airport (ORW)",
            "Panjgur Airport (PJG)\t",
            "Para Chinar Airport (PAJ)",
            "Pasni Airport (PSI)",
            "Peshawar International Airport (PEW)",
            "Quetta Airport (UET)",
            "Rahim Yar Khan Airport (RYK)",
            "Rawala Kot Airport (RAZ)",
            "Sahiwal Airport (SWN)",
            "Saidu Sharif Airport (SDT)",
            "Sargodha Bhagatanwala Apt Airport (BHW)",
            "Sargodha Apt Airport (SGI)",
            "Sawan Airport (RZS)",
            "Sehwen Sharif Airport (SYW)",
            "Shikarpur Airport (SWV)",
            "Sialkot Airport (SKT)",
            "Sibi Airport (SBQ)",
            "Skardu Airport (KDU)",
            "Sui Airport (SUL)\t",
            "Sukkur Airport (SKZ)\t",
            "Taftan Airport (TFT)\t",
            "Tarbela Airport (TLB)\t",
            "Turbat Airport (TUK)",
            "Wana Airport (WAF)",
            "Zhob Airport (PZH)"});
            this.comboDepartureAirport.Size = new System.Drawing.Size(185, 22);
            this.comboDepartureAirport.TabIndex = 25;
            // 
            // comboClass
            // 
            this.comboClass.EditValue = "Class";
            this.comboClass.Location = new System.Drawing.Point(222, 80);
            this.comboClass.Name = "comboClass";
            this.comboClass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboClass.Properties.Appearance.Options.UseFont = true;
            this.comboClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboClass.Properties.Items.AddRange(new object[] {
            "Economy",
            "Bussiness",
            "First"});
            this.comboClass.Size = new System.Drawing.Size(185, 22);
            this.comboClass.TabIndex = 24;
            // 
            // dateTimePicker1Departure
            // 
            this.dateTimePicker1Departure.CustomFormat = "dd/mmm/yyyy";
            this.dateTimePicker1Departure.Location = new System.Drawing.Point(129, 34);
            this.dateTimePicker1Departure.Name = "dateTimePicker1Departure";
            this.dateTimePicker1Departure.Size = new System.Drawing.Size(221, 22);
            this.dateTimePicker1Departure.TabIndex = 23;
            this.dateTimePicker1Departure.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Departure Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Adults :";
            // 
            // no_of_Adults
            // 
            this.no_of_Adults.Location = new System.Drawing.Point(115, 81);
            this.no_of_Adults.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.no_of_Adults.Name = "no_of_Adults";
            this.no_of_Adults.Size = new System.Drawing.Size(63, 22);
            this.no_of_Adults.TabIndex = 20;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.simpleButton2);
            this.groupBox4.Controls.Add(this.simpleButton1);
            this.groupBox4.Controls.Add(this.customerImg);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(780, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 222);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Digital Info";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(132, 191);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Clear Image";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(40, 191);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Load Image";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // customerImg
            // 
            this.customerImg.Image = global::FlightReservationApp.Properties.Resources.user_male_shape_in_a_circle_ios_7_interface_symbol_318_35357;
            this.customerImg.Location = new System.Drawing.Point(62, 29);
            this.customerImg.Name = "customerImg";
            this.customerImg.Size = new System.Drawing.Size(123, 146);
            this.customerImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customerImg.TabIndex = 0;
            this.customerImg.TabStop = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(463, 623);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(256, 64);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Reserve Flight";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 699);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Flight Reservation App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboCountry.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboDepartureAirport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_of_Adults)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtlName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtfName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCity;
        private DevExpress.XtraEditors.ComboBoxEdit comboCountry;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1Departure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown no_of_Adults;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit comboDepartureAirport;
        private DevExpress.XtraEditors.ComboBoxEdit comboClass;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.PictureBox customerImg;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtDestination;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}