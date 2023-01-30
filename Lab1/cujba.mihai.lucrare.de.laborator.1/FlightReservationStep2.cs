using System.Data;
namespace cujba.mihai.lucrare.de.laborator._1
{
    public partial class FlightReservationStep2 : Form
    {
        // Misc
        DataTable passengersTable = new DataTable();

        // Passenger Data
        string title = String.Empty;
        string firstName = String.Empty;
        string lastName = String.Empty;
        string email = String.Empty;
        DateTime birthdate;
        string countryCode = String.Empty;
        string phoneNumber = String.Empty;
        int checkedLuggage = 0;
        int handLuggage = 0;


        public FlightReservationStep2()
        {
            InitializeComponent();
        }

        private void UseError(System.Windows.Forms.Control target, string msg)
        {

            if (msg == String.Empty)
            {
                _errProvider.SetError(target, String.Empty);

            }
            else
            {
                _errProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
                _errProvider.BlinkRate = 500;
                _errProvider.SetError(target, msg);
            }

            HandleButtonDisable();
        }

        private void Email_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean isValid = Passenger.ValidateField("email", Email.Text);

            if (isValid)
            {
                UseError(Email, String.Empty);
            }


            if (!isValid)
            {
                UseError(Email, "Please provide a valid email.");

            }
        }

        private void FirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean isValid = Passenger.ValidateField("firstName", FirstName.Text);

            if (isValid)
            {
                UseError(FirstName, String.Empty);
            }


            if (!isValid)
            {
                UseError(FirstName, "Please provide a valid first name.");

            }

        }
        public string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            string reservationsFolderPath = StartPage.GetReservationsFolderPath();
            string printPath = reservationsFolderPath + "/" + DateTime.Now.ToUniversalTime().ToString("u").Replace(" ", "T").Replace(":", "-") + "-" + "PNR_" + RandomString(6);
            Reservation reservation = new Reservation(Passenger.allInstancesOfThisClass, Flight.allInstancesOfThisClass[0]);
            reservation.CreateReservation(printPath);
            this.Close();
        }

        private void PhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean isValid = Passenger.ValidateField("phoneNumber", PhoneNumber.Text);

            if (isValid)
            {
                UseError(PhoneNumber, String.Empty);
            }

            if (!isValid)
            {
                UseError(PhoneNumber, "Invalid phone number.");

            }
        }

        private void CountryCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean isValid = Passenger.ValidateField("countryCode", CountryCode.Text);


            if (isValid)
            {
                UseError(PhoneNumber, String.Empty);
            }

            if (!isValid)
            {
                UseError(PhoneNumber, "Invalid country code.");
            }
        }

        private void Title_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean isValid = Passenger.ValidateField("title", Title.Text);

            if (isValid)
            {
                UseError(Title, String.Empty);

            }

            if (!isValid)
            {
                UseError(Title, "Invalid title");
            }
        }

        private void LastName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean isValid = Passenger.ValidateField("lastName", LastName.Text);

            if (isValid)
            {
                UseError(LastName, String.Empty);

            }

            if (!isValid)
            {
                UseError(LastName, "Please provide a valid last name.");

            }
        }


        private void FirstName_Leave(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            if (firstName.Length > 0)
            {
                FirstName.Text = char.ToUpper(firstName[0]) + firstName[1..].ToLower();
            }
        }

        private void LastName_Leave(object sender, EventArgs e)
        {
            string lastName = LastName.Text;
            if (lastName.Length > 0)
            {
                LastName.Text = char.ToUpper(lastName[0]) + lastName[1..].ToLower();
            }

        }

        private Boolean CheckForErrors()
        {
            Boolean _hasEmptyFields =
               new string[] {
                    Title.Text,
                    LastName.Text,
                    FirstName.Text,
                    CountryCode.Text,
                    PhoneNumber.Text,
                    Email.Text,
                }.Any(element => element.Equals(String.Empty));

            Boolean _fieldErrors =
            new string[]{
                _errProvider.GetError(Title),
                _errProvider.GetError(FirstName),
                _errProvider.GetError(LastName),
                _errProvider.GetError(Birthdate),
                _errProvider.GetError(CountryCode),
                _errProvider.GetError(PhoneNumber),
                _errProvider.GetError(Email),
                _errProvider.GetError(CheckedLuggage),
                _errProvider.GetError(HandLuggage),
            }.All(err => err.Equals(String.Empty));

            return !_fieldErrors || _hasEmptyFields;
        }

        private void AddPassengetBtn_Click(object sender, EventArgs e)
        {
            title = Title.Text;
            firstName = FirstName.Text;
            lastName = LastName.Text;
            email = Email.Text;
            birthdate = Birthdate.Value;
            countryCode = CountryCode.Text;
            phoneNumber = PhoneNumber.Text;
            checkedLuggage = (int)CheckedLuggage.Value;
            handLuggage = (int)HandLuggage.Value;

            Boolean hasErrors = CheckForErrors();

            if (hasErrors)
            {
                MessageBox.Show("Please make sure all fields are completed correctly!");
                return;
            }

            AddPassengerToTable();
            ClearPassengerFields();
            HandleButtonDisable();
        }

        public void AddPassengerToTable()
        {
            Passenger passenger = new Passenger(
                title,
                firstName,
                lastName,
                birthdate,
                countryCode,
                phoneNumber,
                email,
                checkedLuggage,
                handLuggage);

            passenger.Save(passengersTable, PassengersGrid);

        }

        public void ClearPassengerFields()
        {

            Title.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
            Email.Text = "";
            CountryCode.Text = CountryCode.Items[0].ToString();
            PhoneNumber.Text = "";
            CheckedLuggage.Value = 0;
            HandLuggage.Value = 0;
            Birthdate.Value = new DateTime(2000, 1, 1);
            CheckedLuggage.Value = 1;
            Title.Text = Title.Items[0].ToString();
        }

        private void HandleButtonDisable()
        {

            Boolean hasErrors = CheckForErrors();
            int passengersAdded = PassengersGrid.RowCount;

            if (passengersAdded == 0)
            {
                BookButton.Enabled = false;
                BookButton.BackColor = Color.Gray;
            }
            else if (passengersAdded > 0)
            {
                BookButton.Enabled = true;
                BookButton.BackColor = Color.Green;
            }

            if (hasErrors)
            {
                AddPassengetBtn.Enabled = false;
                AddPassengetBtn.BackColor = Color.Gray;

            }
            else if (!hasErrors)
            {
                AddPassengetBtn.Enabled = true;
                AddPassengetBtn.BackColor = Color.Green;

            }

        }


        private void FlightManagement_Load(object sender, EventArgs e)
        {
            CountryCode.SelectedItem = CountryCode.Items[0].ToString();
            CheckedLuggage.Value = 1;
            Title.Text = Title.Items[0].ToString();
            HandleButtonDisable();

        }


    }
}
