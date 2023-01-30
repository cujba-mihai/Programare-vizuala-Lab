namespace cujba.mihai.lucrare.de.laborator._1
{
    partial class FlightReservationStep1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightReservationStep1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NextAddPassBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.DepartureCityLabel = new System.Windows.Forms.Label();
            this.DepartureCity = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.ArrivalCityLabel = new System.Windows.Forms.Label();
            this.ArrivalCity = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.DepartureDateLabel = new System.Windows.Forms.Label();
            this.DepartureDateTime = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.ReturnDateLabel = new System.Windows.Forms.Label();
            this.ReturnDateTime = new System.Windows.Forms.DateTimePicker();
            this.MealsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.RegularMeal = new System.Windows.Forms.RadioButton();
            this.KosherMeal = new System.Windows.Forms.RadioButton();
            this.HalalMeal = new System.Windows.Forms.RadioButton();
            this.AgreeTermsLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.AgreeTerms = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TripType = new System.Windows.Forms.ComboBox();
            this.FlightClass = new System.Windows.Forms.ComboBox();
            this._errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StepOneProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.stepOneProgressStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NextAddPassBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(8, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 50);
            this.panel1.TabIndex = 0;
            // 
            // NextAddPassBtn
            // 
            this.NextAddPassBtn.BackColor = System.Drawing.Color.Green;
            this.NextAddPassBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.NextAddPassBtn.ForeColor = System.Drawing.Color.White;
            this.NextAddPassBtn.Location = new System.Drawing.Point(419, 0);
            this.NextAddPassBtn.Name = "NextAddPassBtn";
            this.NextAddPassBtn.Size = new System.Drawing.Size(149, 50);
            this.NextAddPassBtn.TabIndex = 0;
            this.NextAddPassBtn.Text = "Next";
            this.NextAddPassBtn.UseVisualStyleBackColor = false;
            this.NextAddPassBtn.Click += new System.EventHandler(this.NextAddPassBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 20, 8, 20);
            this.groupBox1.Size = new System.Drawing.Size(568, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your flight";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(565, 46);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 272);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(8, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 272);
            this.panel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel2.Controls.Add(this.MealsLabel);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel7);
            this.flowLayoutPanel2.Controls.Add(this.AgreeTermsLabel);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel8);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(557, 229);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.DepartureCityLabel);
            this.flowLayoutPanel3.Controls.Add(this.DepartureCity);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(265, 53);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // DepartureCityLabel
            // 
            this.DepartureCityLabel.AutoSize = true;
            this.DepartureCityLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepartureCityLabel.Location = new System.Drawing.Point(3, 0);
            this.DepartureCityLabel.Name = "DepartureCityLabel";
            this.DepartureCityLabel.Size = new System.Drawing.Size(73, 13);
            this.DepartureCityLabel.TabIndex = 0;
            this.DepartureCityLabel.Text = "From Where?";
            // 
            // DepartureCity
            // 
            this.DepartureCity.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepartureCity.FormattingEnabled = true;
            this.DepartureCity.Items.AddRange(new object[] {
            "Chisinau",
            "Iasi",
            "Balti",
            "Odesa",
            "Bacau"});
            this.DepartureCity.Location = new System.Drawing.Point(3, 16);
            this.DepartureCity.Name = "DepartureCity";
            this.DepartureCity.Size = new System.Drawing.Size(262, 22);
            this.DepartureCity.TabIndex = 1;
            this.DepartureCity.Validating += new System.ComponentModel.CancelEventHandler(this.DepartureCity_Validating);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.ArrivalCityLabel);
            this.flowLayoutPanel4.Controls.Add(this.ArrivalCity);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(274, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(275, 53);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // ArrivalCityLabel
            // 
            this.ArrivalCityLabel.AutoSize = true;
            this.ArrivalCityLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArrivalCityLabel.Location = new System.Drawing.Point(3, 0);
            this.ArrivalCityLabel.Name = "ArrivalCityLabel";
            this.ArrivalCityLabel.Size = new System.Drawing.Size(59, 13);
            this.ArrivalCityLabel.TabIndex = 0;
            this.ArrivalCityLabel.Text = "To Where?";
            // 
            // ArrivalCity
            // 
            this.ArrivalCity.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ArrivalCity.FormattingEnabled = true;
            this.ArrivalCity.Items.AddRange(new object[] {
            "San Francisco",
            "Paris",
            "Berlin",
            "Bali",
            "Rome",
            "London"});
            this.ArrivalCity.Location = new System.Drawing.Point(3, 16);
            this.ArrivalCity.Name = "ArrivalCity";
            this.ArrivalCity.Size = new System.Drawing.Size(272, 22);
            this.ArrivalCity.TabIndex = 1;
            this.ArrivalCity.Validating += new System.ComponentModel.CancelEventHandler(this.ArrivalCity_Validating);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.DepartureDateLabel);
            this.flowLayoutPanel5.Controls.Add(this.DepartureDateTime);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 62);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(265, 62);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // DepartureDateLabel
            // 
            this.DepartureDateLabel.AutoSize = true;
            this.DepartureDateLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepartureDateLabel.Location = new System.Drawing.Point(3, 0);
            this.DepartureDateLabel.Name = "DepartureDateLabel";
            this.DepartureDateLabel.Size = new System.Drawing.Size(81, 13);
            this.DepartureDateLabel.TabIndex = 0;
            this.DepartureDateLabel.Text = "Departure date";
            // 
            // DepartureDateTime
            // 
            this.DepartureDateTime.CustomFormat = "dd MMMM yyyy";
            this.DepartureDateTime.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepartureDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureDateTime.Location = new System.Drawing.Point(3, 16);
            this.DepartureDateTime.MaxDate = new System.DateTime(2023, 9, 18, 0, 0, 0, 0);
            this.DepartureDateTime.MinDate = new System.DateTime(2022, 9, 18, 0, 0, 0, 0);
            this.DepartureDateTime.Name = "DepartureDateTime";
            this.DepartureDateTime.Size = new System.Drawing.Size(262, 22);
            this.DepartureDateTime.TabIndex = 1;
            this.DepartureDateTime.ValueChanged += new System.EventHandler(this.DepartureDateTime_ValueChanged);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.ReturnDateLabel);
            this.flowLayoutPanel6.Controls.Add(this.ReturnDateTime);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(274, 62);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(275, 62);
            this.flowLayoutPanel6.TabIndex = 4;
            // 
            // ReturnDateLabel
            // 
            this.ReturnDateLabel.AutoSize = true;
            this.ReturnDateLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnDateLabel.Location = new System.Drawing.Point(3, 0);
            this.ReturnDateLabel.Name = "ReturnDateLabel";
            this.ReturnDateLabel.Size = new System.Drawing.Size(65, 13);
            this.ReturnDateLabel.TabIndex = 0;
            this.ReturnDateLabel.Text = "Return date";
            // 
            // ReturnDateTime
            // 
            this.ReturnDateTime.CustomFormat = "dd MMMM yyyy";
            this.ReturnDateTime.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReturnDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ReturnDateTime.Location = new System.Drawing.Point(3, 16);
            this.ReturnDateTime.MaxDate = new System.DateTime(2023, 9, 18, 0, 0, 0, 0);
            this.ReturnDateTime.MinDate = new System.DateTime(2022, 9, 19, 16, 59, 0, 862);
            this.ReturnDateTime.Name = "ReturnDateTime";
            this.ReturnDateTime.Size = new System.Drawing.Size(272, 22);
            this.ReturnDateTime.TabIndex = 2;
            this.ReturnDateTime.Value = new System.DateTime(2022, 9, 19, 16, 59, 0, 862);
            // 
            // MealsLabel
            // 
            this.MealsLabel.AutoSize = true;
            this.MealsLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MealsLabel.Location = new System.Drawing.Point(3, 127);
            this.MealsLabel.Name = "MealsLabel";
            this.MealsLabel.Size = new System.Drawing.Size(96, 13);
            this.MealsLabel.TabIndex = 6;
            this.MealsLabel.Text = "Choose your meal";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.RegularMeal);
            this.flowLayoutPanel7.Controls.Add(this.KosherMeal);
            this.flowLayoutPanel7.Controls.Add(this.HalalMeal);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 143);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel7.Size = new System.Drawing.Size(546, 33);
            this.flowLayoutPanel7.TabIndex = 5;
            // 
            // RegularMeal
            // 
            this.RegularMeal.AutoSize = true;
            this.RegularMeal.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegularMeal.Location = new System.Drawing.Point(6, 6);
            this.RegularMeal.Name = "RegularMeal";
            this.RegularMeal.Size = new System.Drawing.Size(66, 18);
            this.RegularMeal.TabIndex = 1;
            this.RegularMeal.TabStop = true;
            this.RegularMeal.Text = "Regular";
            this.RegularMeal.UseVisualStyleBackColor = true;
            this.RegularMeal.Click += new System.EventHandler(this.RegularMeal_Click);
            // 
            // KosherMeal
            // 
            this.KosherMeal.AutoSize = true;
            this.KosherMeal.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KosherMeal.Location = new System.Drawing.Point(78, 6);
            this.KosherMeal.Name = "KosherMeal";
            this.KosherMeal.Size = new System.Drawing.Size(63, 18);
            this.KosherMeal.TabIndex = 2;
            this.KosherMeal.TabStop = true;
            this.KosherMeal.Text = "Kosher";
            this.KosherMeal.UseVisualStyleBackColor = true;
            this.KosherMeal.Click += new System.EventHandler(this.KosherMeal_Click);
            // 
            // HalalMeal
            // 
            this.HalalMeal.AutoSize = true;
            this.HalalMeal.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HalalMeal.Location = new System.Drawing.Point(147, 6);
            this.HalalMeal.Name = "HalalMeal";
            this.HalalMeal.Size = new System.Drawing.Size(54, 18);
            this.HalalMeal.TabIndex = 3;
            this.HalalMeal.TabStop = true;
            this.HalalMeal.Text = "Halal";
            this.HalalMeal.UseVisualStyleBackColor = true;
            this.HalalMeal.Click += new System.EventHandler(this.HalalMeal_Click);
            // 
            // AgreeTermsLabel
            // 
            this.AgreeTermsLabel.AutoSize = true;
            this.AgreeTermsLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgreeTermsLabel.Location = new System.Drawing.Point(3, 179);
            this.AgreeTermsLabel.Name = "AgreeTermsLabel";
            this.AgreeTermsLabel.Size = new System.Drawing.Size(177, 13);
            this.AgreeTermsLabel.TabIndex = 8;
            this.AgreeTermsLabel.Text = "Agree to our terms and conditions";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.AgreeTerms);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 195);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel8.Size = new System.Drawing.Size(546, 33);
            this.flowLayoutPanel8.TabIndex = 7;
            // 
            // AgreeTerms
            // 
            this.AgreeTerms.AutoSize = true;
            this.AgreeTerms.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgreeTerms.Location = new System.Drawing.Point(6, 6);
            this.AgreeTerms.Name = "AgreeTerms";
            this.AgreeTerms.Size = new System.Drawing.Size(64, 18);
            this.AgreeTerms.TabIndex = 0;
            this.AgreeTerms.Text = "Agreed";
            this.AgreeTerms.UseVisualStyleBackColor = true;
            this.AgreeTerms.Click += new System.EventHandler(this.AgreeTerms_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TripType);
            this.flowLayoutPanel1.Controls.Add(this.FlightClass);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3, 8, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(557, 43);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // TripType
            // 
            this.TripType.Dock = System.Windows.Forms.DockStyle.Left;
            this.TripType.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TripType.FormattingEnabled = true;
            this.TripType.Items.AddRange(new object[] {
            "Return",
            "One-way",
            "Multi-city",
            "Nomad"});
            this.TripType.Location = new System.Drawing.Point(6, 11);
            this.TripType.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.TripType.Name = "TripType";
            this.TripType.Size = new System.Drawing.Size(140, 22);
            this.TripType.TabIndex = 1;
            this.TripType.Validating += new System.ComponentModel.CancelEventHandler(this.TripType_Validating);
            // 
            // FlightClass
            // 
            this.FlightClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlightClass.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FlightClass.FormattingEnabled = true;
            this.FlightClass.Items.AddRange(new object[] {
            "Economy",
            "Premium Economy",
            "Business",
            "First Class"});
            this.FlightClass.Location = new System.Drawing.Point(181, 11);
            this.FlightClass.Name = "FlightClass";
            this.FlightClass.Size = new System.Drawing.Size(142, 22);
            this.FlightClass.TabIndex = 2;
            this.FlightClass.Validating += new System.ComponentModel.CancelEventHandler(this.FlightClass_Validating);
            // 
            // _errProvider
            // 
            this._errProvider.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StepOneProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(8, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(568, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StepOneProgressBar
            // 
            this.StepOneProgressBar.Name = "StepOneProgressBar";
            this.StepOneProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stepOneProgressStatusLabel});
            this.statusStrip2.Location = new System.Drawing.Point(8, 419);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(568, 22);
            this.statusStrip2.TabIndex = 3;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // stepOneProgressStatusLabel
            // 
            this.stepOneProgressStatusLabel.Name = "stepOneProgressStatusLabel";
            this.stepOneProgressStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.stepOneProgressStatusLabel.Text = "Step 1";
            // 
            // FlightReservationStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 521);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightReservationStep1";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Management (DBA) - Cujba Mihai";
            this.Load += new System.EventHandler(this.FlightReservationStep1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button NextAddPassBtn;
        private GroupBox groupBox1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox TripType;
        private ComboBox FlightClass;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label DepartureCityLabel;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label ArrivalCityLabel;
        private ComboBox DepartureCity;
        private ComboBox ArrivalCity;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label DepartureDateLabel;
        private DateTimePicker DepartureDateTime;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label ReturnDateLabel;
        private DateTimePicker ReturnDateTime;
        private FlowLayoutPanel flowLayoutPanel7;
        private RadioButton RegularMeal;
        private RadioButton KosherMeal;
        private RadioButton HalalMeal;
        private Label MealsLabel;
        private Label AgreeTermsLabel;
        private FlowLayoutPanel flowLayoutPanel8;
        private CheckBox AgreeTerms;
        private Splitter splitter1;
        private ErrorProvider _errProvider;
        private StatusStrip statusStrip2;
        private ToolStripStatusLabel stepOneProgressStatusLabel;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar StepOneProgressBar;
    }
}