namespace Study_Abroad_Management.UR
{
    partial class FormCourseUpdate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCourseCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbDegreeType = new System.Windows.Forms.ComboBox();
            this.cmbIntakeYear = new System.Windows.Forms.ComboBox();
            this.cmbIntakeSeason = new System.Windows.Forms.ComboBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbGRE = new System.Windows.Forms.CheckBox();
            this.cbIELTS = new System.Windows.Forms.CheckBox();
            this.cbSAT = new System.Windows.Forms.CheckBox();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.rdHybrid = new System.Windows.Forms.RadioButton();
            this.rdOnline = new System.Windows.Forms.RadioButton();
            this.rdOnCampus = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxScholarship = new System.Windows.Forms.TextBox();
            this.txtTutionFee = new System.Windows.Forms.TextBox();
            this.txtRequiredGRE = new System.Windows.Forms.TextBox();
            this.txtRequiredIELTS = new System.Windows.Forms.TextBox();
            this.txtRequiredSAT = new System.Windows.Forms.TextBox();
            this.txtCourseDuration = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(914, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 43);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCourseCode);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtCourseName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 598);
            this.panel2.TabIndex = 1;
            // 
            // txtCourseCode
            // 
            this.txtCourseCode.Enabled = false;
            this.txtCourseCode.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseCode.Location = new System.Drawing.Point(650, 85);
            this.txtCourseCode.Multiline = true;
            this.txtCourseCode.Name = "txtCourseCode";
            this.txtCourseCode.Size = new System.Drawing.Size(281, 33);
            this.txtCourseCode.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.OliveDrab;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(505, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 33);
            this.label4.TabIndex = 127;
            this.label4.Text = "Course code :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(206, 85);
            this.txtCourseName.Multiline = true;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(273, 33);
            this.txtCourseName.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.OliveDrab;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(42, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 33);
            this.label2.TabIndex = 122;
            this.label2.Text = "Course name :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Course";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(12, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 77);
            this.panel3.TabIndex = 129;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cmbDegreeType);
            this.panel4.Controls.Add(this.cmbIntakeYear);
            this.panel4.Controls.Add(this.cmbIntakeSeason);
            this.panel4.Controls.Add(this.cmbCountry);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.cbGRE);
            this.panel4.Controls.Add(this.cbIELTS);
            this.panel4.Controls.Add(this.cbSAT);
            this.panel4.Controls.Add(this.dtpDeadline);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.rdHybrid);
            this.panel4.Controls.Add(this.rdOnline);
            this.panel4.Controls.Add(this.rdOnCampus);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtMaxScholarship);
            this.panel4.Controls.Add(this.txtTutionFee);
            this.panel4.Controls.Add(this.txtRequiredGRE);
            this.panel4.Controls.Add(this.txtRequiredIELTS);
            this.panel4.Controls.Add(this.txtRequiredSAT);
            this.panel4.Controls.Add(this.txtCourseDuration);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Location = new System.Drawing.Point(12, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(947, 431);
            this.panel4.TabIndex = 130;
            // 
            // cmbDegreeType
            // 
            this.cmbDegreeType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDegreeType.FormattingEnabled = true;
            this.cmbDegreeType.Items.AddRange(new object[] {
            "Select a Degree",
            "Bachelor\'s",
            "Master\'s"});
            this.cmbDegreeType.Location = new System.Drawing.Point(202, 38);
            this.cmbDegreeType.Name = "cmbDegreeType";
            this.cmbDegreeType.Size = new System.Drawing.Size(244, 33);
            this.cmbDegreeType.TabIndex = 148;
            // 
            // cmbIntakeYear
            // 
            this.cmbIntakeYear.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIntakeYear.FormattingEnabled = true;
            this.cmbIntakeYear.Items.AddRange(new object[] {
            "Select Year",
            "2000",
            "2002",
            "2004",
            "2006",
            "2008",
            "2010",
            "2012",
            "2014",
            "2016",
            "2018",
            "2020",
            "2022",
            "2024",
            "2026",
            "2028",
            "2030",
            "2032",
            "2034",
            "2036",
            "2038",
            "2040",
            "2042",
            "2044",
            "2046",
            "2048",
            "2050"});
            this.cmbIntakeYear.Location = new System.Drawing.Point(840, 260);
            this.cmbIntakeYear.Name = "cmbIntakeYear";
            this.cmbIntakeYear.Size = new System.Drawing.Size(71, 33);
            this.cmbIntakeYear.TabIndex = 155;
            // 
            // cmbIntakeSeason
            // 
            this.cmbIntakeSeason.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIntakeSeason.FormattingEnabled = true;
            this.cmbIntakeSeason.Items.AddRange(new object[] {
            "Select Semester",
            "SPRING",
            "SUMMER",
            "FALL"});
            this.cmbIntakeSeason.Location = new System.Drawing.Point(689, 260);
            this.cmbIntakeSeason.Name = "cmbIntakeSeason";
            this.cmbIntakeSeason.Size = new System.Drawing.Size(145, 33);
            this.cmbIntakeSeason.TabIndex = 154;
            // 
            // cmbCountry
            // 
            this.cmbCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "Select a country",
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas",
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
            "Burundi",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Costa Rica",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "Fiji",
            "Finland",
            "France",
            "Gabon",
            "Gambia",
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
            "Honduras",
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
            "Myanmar",
            "Namibia",
            "Nauru",
            "Nepal",
            "Netherlands",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "North Korea",
            "North Macedonia",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
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
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Vatican City",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.cmbCountry.Location = new System.Drawing.Point(202, 103);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(244, 33);
            this.cmbCountry.TabIndex = 153;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(549, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(276, 23);
            this.label16.TabIndex = 152;
            this.label16.Text = "If SAT, IELTS, GRE is Required, then check it first.";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbGRE
            // 
            this.cbGRE.Location = new System.Drawing.Point(718, 168);
            this.cbGRE.Name = "cbGRE";
            this.cbGRE.Size = new System.Drawing.Size(33, 33);
            this.cbGRE.TabIndex = 151;
            this.cbGRE.UseVisualStyleBackColor = true;
            this.cbGRE.CheckedChanged += new System.EventHandler(this.cbGRE_CheckedChanged);
            // 
            // cbIELTS
            // 
            this.cbIELTS.Location = new System.Drawing.Point(718, 103);
            this.cbIELTS.Name = "cbIELTS";
            this.cbIELTS.Size = new System.Drawing.Size(33, 33);
            this.cbIELTS.TabIndex = 150;
            this.cbIELTS.UseVisualStyleBackColor = true;
            this.cbIELTS.CheckedChanged += new System.EventHandler(this.cbIELTS_CheckedChanged);
            // 
            // cbSAT
            // 
            this.cbSAT.Location = new System.Drawing.Point(718, 38);
            this.cbSAT.Name = "cbSAT";
            this.cbSAT.Size = new System.Drawing.Size(33, 33);
            this.cbSAT.TabIndex = 149;
            this.cbSAT.UseVisualStyleBackColor = true;
            this.cbSAT.CheckedChanged += new System.EventHandler(this.cbSAT_CheckedChanged);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Location = new System.Drawing.Point(689, 323);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(222, 22);
            this.dtpDeadline.TabIndex = 147;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.ForestGreen;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(548, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 33);
            this.label10.TabIndex = 146;
            this.label10.Text = "Deadeline :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rdHybrid
            // 
            this.rdHybrid.AutoSize = true;
            this.rdHybrid.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdHybrid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHybrid.ForeColor = System.Drawing.SystemColors.Control;
            this.rdHybrid.Location = new System.Drawing.Point(384, 230);
            this.rdHybrid.Name = "rdHybrid";
            this.rdHybrid.Size = new System.Drawing.Size(68, 21);
            this.rdHybrid.TabIndex = 145;
            this.rdHybrid.TabStop = true;
            this.rdHybrid.Text = "Hybrid";
            this.rdHybrid.UseVisualStyleBackColor = false;
            // 
            // rdOnline
            // 
            this.rdOnline.AutoSize = true;
            this.rdOnline.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdOnline.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOnline.ForeColor = System.Drawing.SystemColors.Control;
            this.rdOnline.Location = new System.Drawing.Point(309, 230);
            this.rdOnline.Name = "rdOnline";
            this.rdOnline.Size = new System.Drawing.Size(66, 21);
            this.rdOnline.TabIndex = 144;
            this.rdOnline.TabStop = true;
            this.rdOnline.Text = "Online";
            this.rdOnline.UseVisualStyleBackColor = false;
            // 
            // rdOnCampus
            // 
            this.rdOnCampus.AutoSize = true;
            this.rdOnCampus.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdOnCampus.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOnCampus.ForeColor = System.Drawing.SystemColors.Control;
            this.rdOnCampus.Location = new System.Drawing.Point(202, 230);
            this.rdOnCampus.Name = "rdOnCampus";
            this.rdOnCampus.Size = new System.Drawing.Size(97, 21);
            this.rdOnCampus.TabIndex = 143;
            this.rdOnCampus.TabStop = true;
            this.rdOnCampus.Text = "On Campus";
            this.rdOnCampus.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.ForestGreen;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(548, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 33);
            this.label11.TabIndex = 142;
            this.label11.Text = "Intake :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.ForestGreen;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(38, 283);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 33);
            this.label12.TabIndex = 141;
            this.label12.Text = "Max Scholarship :";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.ForestGreen;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(38, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 33);
            this.label13.TabIndex = 140;
            this.label13.Text = "Tution Fee :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.ForestGreen;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(548, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 33);
            this.label14.TabIndex = 139;
            this.label14.Text = "Required GRE :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.ForestGreen;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(548, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 33);
            this.label15.TabIndex = 138;
            this.label15.Text = "Required IELTS :";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.ForestGreen;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(548, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 33);
            this.label6.TabIndex = 137;
            this.label6.Text = "Required SAT :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxScholarship
            // 
            this.txtMaxScholarship.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxScholarship.Location = new System.Drawing.Point(208, 283);
            this.txtMaxScholarship.Multiline = true;
            this.txtMaxScholarship.Name = "txtMaxScholarship";
            this.txtMaxScholarship.Size = new System.Drawing.Size(244, 33);
            this.txtMaxScholarship.TabIndex = 136;
            // 
            // txtTutionFee
            // 
            this.txtTutionFee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutionFee.Location = new System.Drawing.Point(208, 347);
            this.txtTutionFee.Multiline = true;
            this.txtTutionFee.Name = "txtTutionFee";
            this.txtTutionFee.Size = new System.Drawing.Size(244, 33);
            this.txtTutionFee.TabIndex = 135;
            // 
            // txtRequiredGRE
            // 
            this.txtRequiredGRE.Enabled = false;
            this.txtRequiredGRE.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequiredGRE.Location = new System.Drawing.Point(765, 168);
            this.txtRequiredGRE.Multiline = true;
            this.txtRequiredGRE.Name = "txtRequiredGRE";
            this.txtRequiredGRE.Size = new System.Drawing.Size(146, 33);
            this.txtRequiredGRE.TabIndex = 134;
            // 
            // txtRequiredIELTS
            // 
            this.txtRequiredIELTS.Enabled = false;
            this.txtRequiredIELTS.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequiredIELTS.Location = new System.Drawing.Point(765, 103);
            this.txtRequiredIELTS.Multiline = true;
            this.txtRequiredIELTS.Name = "txtRequiredIELTS";
            this.txtRequiredIELTS.Size = new System.Drawing.Size(146, 33);
            this.txtRequiredIELTS.TabIndex = 133;
            // 
            // txtRequiredSAT
            // 
            this.txtRequiredSAT.Enabled = false;
            this.txtRequiredSAT.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRequiredSAT.Location = new System.Drawing.Point(765, 38);
            this.txtRequiredSAT.Multiline = true;
            this.txtRequiredSAT.Name = "txtRequiredSAT";
            this.txtRequiredSAT.Size = new System.Drawing.Size(146, 33);
            this.txtRequiredSAT.TabIndex = 132;
            // 
            // txtCourseDuration
            // 
            this.txtCourseDuration.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseDuration.Location = new System.Drawing.Point(202, 168);
            this.txtCourseDuration.Multiline = true;
            this.txtCourseDuration.Name = "txtCourseDuration";
            this.txtCourseDuration.Size = new System.Drawing.Size(242, 33);
            this.txtCourseDuration.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.ForestGreen;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(38, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 33);
            this.label7.TabIndex = 130;
            this.label7.Text = "Study mode :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.ForestGreen;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(38, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 33);
            this.label8.TabIndex = 129;
            this.label8.Text = "Course duration :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.ForestGreen;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(38, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 33);
            this.label9.TabIndex = 128;
            this.label9.Text = "Degree type :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.ForestGreen;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(38, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 33);
            this.label5.TabIndex = 127;
            this.label5.Text = "Country :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(747, 373);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(164, 42);
            this.btnUpdate.TabIndex = 114;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormCourseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(971, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCourseUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCourseUpdate";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCourseCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbDegreeType;
        private System.Windows.Forms.ComboBox cmbIntakeYear;
        private System.Windows.Forms.ComboBox cmbIntakeSeason;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbGRE;
        private System.Windows.Forms.CheckBox cbIELTS;
        private System.Windows.Forms.CheckBox cbSAT;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rdHybrid;
        private System.Windows.Forms.RadioButton rdOnline;
        private System.Windows.Forms.RadioButton rdOnCampus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxScholarship;
        private System.Windows.Forms.TextBox txtTutionFee;
        private System.Windows.Forms.TextBox txtRequiredGRE;
        private System.Windows.Forms.TextBox txtRequiredIELTS;
        private System.Windows.Forms.TextBox txtRequiredSAT;
        private System.Windows.Forms.TextBox txtCourseDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
    }
}