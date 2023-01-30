namespace cujba.mihai.lucrare.de.laborator._1
{
    partial class FlightReservationStep2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightReservationStep2));
            this.Birthdate = new System.Windows.Forms.DateTimePicker();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PassengerInfoContainer = new System.Windows.Forms.GroupBox();
            this.HandLuggage = new System.Windows.Forms.NumericUpDown();
            this.HandLuggageLabel = new System.Windows.Forms.Label();
            this.CheckedLuggage = new System.Windows.Forms.NumericUpDown();
            this.CheckedLuggageLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneNrContainer = new System.Windows.Forms.SplitContainer();
            this.CountryCode = new System.Windows.Forms.ComboBox();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.ComboBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.AddPassengetBtn = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this._errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CheckedLuggageTip = new System.Windows.Forms.ToolTip(this.components);
            this.HandLuggageTip = new System.Windows.Forms.ToolTip(this.components);
            this.PassengersGrid = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StepTwoProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StepTwoStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PassengerInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HandLuggage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckedLuggage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNrContainer)).BeginInit();
            this.PhoneNrContainer.Panel1.SuspendLayout();
            this.PhoneNrContainer.Panel2.SuspendLayout();
            this.PhoneNrContainer.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersGrid)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Birthdate
            // 
            this.Birthdate.CalendarFont = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Birthdate.CustomFormat = "dd / MMM / yyyy";
            this.Birthdate.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Birthdate.Location = new System.Drawing.Point(11, 115);
            this.Birthdate.Margin = new System.Windows.Forms.Padding(50, 5, 5, 5);
            this.Birthdate.MaxDate = new System.DateTime(2022, 9, 18, 0, 0, 0, 0);
            this.Birthdate.MinDate = new System.DateTime(1922, 12, 31, 0, 0, 0, 0);
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(130, 22);
            this.Birthdate.TabIndex = 3;
            this.Birthdate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.CausesValidation = false;
            this.TitleLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLabel.Location = new System.Drawing.Point(11, 34);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 100;
            this.TitleLabel.Text = "Title";
            // 
            // PassengerInfoContainer
            // 
            this.PassengerInfoContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PassengerInfoContainer.Controls.Add(this.HandLuggage);
            this.PassengerInfoContainer.Controls.Add(this.HandLuggageLabel);
            this.PassengerInfoContainer.Controls.Add(this.CheckedLuggage);
            this.PassengerInfoContainer.Controls.Add(this.CheckedLuggageLabel);
            this.PassengerInfoContainer.Controls.Add(this.Email);
            this.PassengerInfoContainer.Controls.Add(this.EmailLabel);
            this.PassengerInfoContainer.Controls.Add(this.PhoneNrContainer);
            this.PassengerInfoContainer.Controls.Add(this.Birthdate);
            this.PassengerInfoContainer.Controls.Add(this.PhoneNumberLabel);
            this.PassengerInfoContainer.Controls.Add(this.BirthDateLabel);
            this.PassengerInfoContainer.Controls.Add(this.LastName);
            this.PassengerInfoContainer.Controls.Add(this.FirstName);
            this.PassengerInfoContainer.Controls.Add(this.Title);
            this.PassengerInfoContainer.Controls.Add(this.LastNameLabel);
            this.PassengerInfoContainer.Controls.Add(this.FirstNameLabel);
            this.PassengerInfoContainer.Controls.Add(this.TitleLabel);
            this.PassengerInfoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.PassengerInfoContainer.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassengerInfoContainer.Location = new System.Drawing.Point(8, 8);
            this.PassengerInfoContainer.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.PassengerInfoContainer.Name = "PassengerInfoContainer";
            this.PassengerInfoContainer.Padding = new System.Windows.Forms.Padding(8);
            this.PassengerInfoContainer.Size = new System.Drawing.Size(568, 230);
            this.PassengerInfoContainer.TabIndex = 1;
            this.PassengerInfoContainer.TabStop = false;
            this.PassengerInfoContainer.Text = "Passenger";
            // 
            // HandLuggage
            // 
            this.HandLuggage.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HandLuggage.Location = new System.Drawing.Point(135, 178);
            this.HandLuggage.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.HandLuggage.Name = "HandLuggage";
            this.HandLuggage.Size = new System.Drawing.Size(100, 22);
            this.HandLuggage.TabIndex = 9;
            // 
            // HandLuggageLabel
            // 
            this.HandLuggageLabel.AutoSize = true;
            this.HandLuggageLabel.CausesValidation = false;
            this.HandLuggageLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HandLuggageLabel.Location = new System.Drawing.Point(135, 158);
            this.HandLuggageLabel.Name = "HandLuggageLabel";
            this.HandLuggageLabel.Size = new System.Drawing.Size(78, 13);
            this.HandLuggageLabel.TabIndex = 800;
            this.HandLuggageLabel.Text = "Hand Luggage";
            this.HandLuggageTip.SetToolTip(this.HandLuggageLabel, "MAX. 56 X 36 X 23 cm, 7kg");
            // 
            // CheckedLuggage
            // 
            this.CheckedLuggage.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckedLuggage.Location = new System.Drawing.Point(11, 178);
            this.CheckedLuggage.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.CheckedLuggage.Name = "CheckedLuggage";
            this.CheckedLuggage.Size = new System.Drawing.Size(100, 22);
            this.CheckedLuggage.TabIndex = 8;
            // 
            // CheckedLuggageLabel
            // 
            this.CheckedLuggageLabel.AutoSize = true;
            this.CheckedLuggageLabel.CausesValidation = false;
            this.CheckedLuggageLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckedLuggageLabel.Location = new System.Drawing.Point(11, 158);
            this.CheckedLuggageLabel.Name = "CheckedLuggageLabel";
            this.CheckedLuggageLabel.Size = new System.Drawing.Size(95, 13);
            this.CheckedLuggageLabel.TabIndex = 700;
            this.CheckedLuggageLabel.Text = "Checked Luggage";
            this.CheckedLuggageTip.SetToolTip(this.CheckedLuggageLabel, "MAX. 20kg");
            // 
            // Email
            // 
            this.Email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Email.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(381, 115);
            this.Email.Margin = new System.Windows.Forms.Padding(0);
            this.Email.MaxLength = 100;
            this.Email.Name = "Email";
            this.Email.PlaceholderText = "example@email.com";
            this.Email.Size = new System.Drawing.Size(153, 22);
            this.Email.TabIndex = 7;
            this.Email.Validating += new System.ComponentModel.CancelEventHandler(this.Email_Validating);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.CausesValidation = false;
            this.EmailLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(381, 97);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 600;
            this.EmailLabel.Text = "Email";
            // 
            // PhoneNrContainer
            // 
            this.PhoneNrContainer.Location = new System.Drawing.Point(148, 115);
            this.PhoneNrContainer.Name = "PhoneNrContainer";
            // 
            // PhoneNrContainer.Panel1
            // 
            this.PhoneNrContainer.Panel1.Controls.Add(this.CountryCode);
            // 
            // PhoneNrContainer.Panel2
            // 
            this.PhoneNrContainer.Panel2.Controls.Add(this.PhoneNumber);
            this.PhoneNrContainer.Size = new System.Drawing.Size(230, 22);
            this.PhoneNrContainer.SplitterDistance = 74;
            this.PhoneNrContainer.TabIndex = 4;
            this.PhoneNrContainer.TabStop = false;
            // 
            // CountryCode
            // 
            this.CountryCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CountryCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CountryCode.DropDownHeight = 120;
            this.CountryCode.DropDownWidth = 120;
            this.CountryCode.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountryCode.IntegralHeight = false;
            this.CountryCode.Items.AddRange(new object[] {
            "+373",
            "+40",
            "+44",
            "+380"});
            this.CountryCode.Location = new System.Drawing.Point(0, 0);
            this.CountryCode.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.CountryCode.Name = "CountryCode";
            this.CountryCode.Size = new System.Drawing.Size(63, 22);
            this.CountryCode.TabIndex = 5;
            this.CountryCode.Validating += new System.ComponentModel.CancelEventHandler(this.CountryCode_Validating);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumber.Location = new System.Drawing.Point(0, 0);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(0);
            this.PhoneNumber.MaxLength = 14;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.PlaceholderText = "69000000";
            this.PhoneNumber.Size = new System.Drawing.Size(130, 22);
            this.PhoneNumber.TabIndex = 6;
            this.PhoneNumber.WordWrap = false;
            this.PhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneNumber_Validating);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.CausesValidation = false;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneNumberLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(149, 97);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(81, 13);
            this.PhoneNumberLabel.TabIndex = 500;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.CausesValidation = false;
            this.BirthDateLabel.Enabled = false;
            this.BirthDateLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BirthDateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BirthDateLabel.Location = new System.Drawing.Point(11, 97);
            this.BirthDateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(53, 13);
            this.BirthDateLabel.TabIndex = 400;
            this.BirthDateLabel.Text = "Birthdate";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.Location = new System.Drawing.Point(381, 54);
            this.LastName.Margin = new System.Windows.Forms.Padding(0);
            this.LastName.MaxLength = 40;
            this.LastName.Name = "LastName";
            this.LastName.PlaceholderText = "Cujba";
            this.LastName.Size = new System.Drawing.Size(153, 22);
            this.LastName.TabIndex = 2;
            this.LastName.Leave += new System.EventHandler(this.LastName_Leave);
            this.LastName.Validating += new System.ComponentModel.CancelEventHandler(this.LastName_Validating);
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.Location = new System.Drawing.Point(198, 54);
            this.FirstName.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.FirstName.MaxLength = 40;
            this.FirstName.Name = "FirstName";
            this.FirstName.PlaceholderText = "Mihai";
            this.FirstName.Size = new System.Drawing.Size(165, 22);
            this.FirstName.TabIndex = 1;
            this.FirstName.Leave += new System.EventHandler(this.FirstName_Leave);
            this.FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.FirstName_Validating);
            // 
            // Title
            // 
            this.Title.AutoCompleteCustomSource.AddRange(new string[] {
            "Mr."});
            this.Title.DropDownHeight = 120;
            this.Title.DropDownWidth = 120;
            this.Title.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.IntegralHeight = false;
            this.Title.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms.",
            "Dr."});
            this.Title.Location = new System.Drawing.Point(11, 54);
            this.Title.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.Title.MinimumSize = new System.Drawing.Size(170, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(170, 22);
            this.Title.TabIndex = 0;
            this.Title.Validating += new System.ComponentModel.CancelEventHandler(this.Title_Validating);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.CausesValidation = false;
            this.LastNameLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.Location = new System.Drawing.Point(381, 34);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(62, 13);
            this.LastNameLabel.TabIndex = 300;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.CausesValidation = false;
            this.FirstNameLabel.Font = new System.Drawing.Font("Roboto Medium", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstNameLabel.Location = new System.Drawing.Point(198, 34);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(63, 13);
            this.FirstNameLabel.TabIndex = 200;
            this.FirstNameLabel.Text = "First Name";
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ButtonsPanel.CausesValidation = false;
            this.ButtonsPanel.Controls.Add(this.AddPassengetBtn);
            this.ButtonsPanel.Controls.Add(this.BookButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonsPanel.Location = new System.Drawing.Point(8, 403);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(568, 70);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // AddPassengetBtn
            // 
            this.AddPassengetBtn.AutoSize = true;
            this.AddPassengetBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.AddPassengetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPassengetBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddPassengetBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddPassengetBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddPassengetBtn.Image")));
            this.AddPassengetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPassengetBtn.Location = new System.Drawing.Point(3, 10);
            this.AddPassengetBtn.Name = "AddPassengetBtn";
            this.AddPassengetBtn.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.AddPassengetBtn.Size = new System.Drawing.Size(180, 50);
            this.AddPassengetBtn.TabIndex = 10;
            this.AddPassengetBtn.TabStop = false;
            this.AddPassengetBtn.Text = "Save and Add new";
            this.AddPassengetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddPassengetBtn.UseVisualStyleBackColor = false;
            this.AddPassengetBtn.Click += new System.EventHandler(this.AddPassengetBtn_Click);
            // 
            // BookButton
            // 
            this.BookButton.AutoSize = true;
            this.BookButton.BackColor = System.Drawing.Color.SeaGreen;
            this.BookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BookButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BookButton.Location = new System.Drawing.Point(429, 10);
            this.BookButton.Name = "BookButton";
            this.BookButton.Padding = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.BookButton.Size = new System.Drawing.Size(132, 50);
            this.BookButton.TabIndex = 12;
            this.BookButton.TabStop = false;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // _errProvider
            // 
            this._errProvider.ContainerControl = this;
            // 
            // CheckedLuggageTip
            // 
            this.CheckedLuggageTip.ToolTipTitle = "Checked Luggage";
            // 
            // HandLuggageTip
            // 
            this.HandLuggageTip.ToolTipTitle = "Hand Luggage";
            // 
            // PassengersGrid
            // 
            this.PassengersGrid.AllowUserToAddRows = false;
            this.PassengersGrid.AllowUserToOrderColumns = true;
            this.PassengersGrid.AllowUserToResizeColumns = false;
            this.PassengersGrid.AllowUserToResizeRows = false;
            this.PassengersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PassengersGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PassengersGrid.Location = new System.Drawing.Point(8, 253);
            this.PassengersGrid.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.PassengersGrid.Name = "PassengersGrid";
            this.PassengersGrid.ReadOnly = true;
            this.PassengersGrid.RowTemplate.Height = 25;
            this.PassengersGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PassengersGrid.Size = new System.Drawing.Size(568, 150);
            this.PassengersGrid.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StepTwoStatusLabel,
            this.StepTwoProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(8, 231);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(568, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StepTwoProgressBar
            // 
            this.StepTwoProgressBar.Name = "StepTwoProgressBar";
            this.StepTwoProgressBar.Size = new System.Drawing.Size(100, 16);
            this.StepTwoProgressBar.Value = 50;
            // 
            // StepTwoStatusLabel
            // 
            this.StepTwoStatusLabel.Name = "StepTwoStatusLabel";
            this.StepTwoStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.StepTwoStatusLabel.Text = "Step 2";
            // 
            // FlightReservationStep2
            // 
            this.AcceptButton = this.BookButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PassengersGrid);
            this.Controls.Add(this.PassengerInfoContainer);
            this.Controls.Add(this.ButtonsPanel);
            this.Font = new System.Drawing.Font("Roboto Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlightReservationStep2";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Management (DBA) - Cujba Mihai";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FlightManagement_Load);
            this.PassengerInfoContainer.ResumeLayout(false);
            this.PassengerInfoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HandLuggage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckedLuggage)).EndInit();
            this.PhoneNrContainer.Panel1.ResumeLayout(false);
            this.PhoneNrContainer.Panel2.ResumeLayout(false);
            this.PhoneNrContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNrContainer)).EndInit();
            this.PhoneNrContainer.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersGrid)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private TextBox LastName;
        private TextBox FirstName;
        public ComboBox Title;
        public GroupBox PassengerInfoContainer;
        private DateTimePicker Birthdate;
        private Label PhoneNumberLabel;
        private Label BirthDateLabel;
        private SplitContainer PhoneNrContainer;
        public ComboBox CountryCode;
        private TextBox PhoneNumber;
        private TextBox Email;
        private Label EmailLabel;
        private Button BookButton;
        private ErrorProvider _errProvider;
        private Label CheckedLuggageLabel;
        private NumericUpDown CheckedLuggage;
        private NumericUpDown HandLuggage;
        private Label HandLuggageLabel;
        private ToolTip CheckedLuggageTip;
        private ToolTip HandLuggageTip;
        private Button AddPassengetBtn;
        private Panel ButtonsPanel;
        private DataGridView PassengersGrid;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StepTwoStatusLabel;
        private ToolStripProgressBar StepTwoProgressBar;
    }
}