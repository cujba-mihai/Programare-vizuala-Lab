namespace cujba.mihai.lucrare.de.laborator._1
{
    public partial class FlightReservationStep1 : Form
    {
        string meal = "Regular";
        Boolean agreedWithTerms;

        public FlightReservationStep1() => InitializeComponent();

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

        private Boolean CheckForErrors()
        {
            Boolean _hasEmptyFields = new string[] { TripType.Text, FlightClass.Text, DepartureCity.Text, ArrivalCity.Text }
                                        .Any(element => element.Equals(String.Empty));

            Boolean _fieldErrors = new string[]{ _errProvider.GetError(TripType),
                _errProvider.GetError(FlightClass), _errProvider.GetError(DepartureCity),
                _errProvider.GetError(ArrivalCity)}.All(err => err.Equals(String.Empty));

            return !_fieldErrors || _hasEmptyFields || !agreedWithTerms;
        }
        private void HandleButtonDisable()
        {

            Boolean hasErrors = CheckForErrors();

            if (hasErrors)
            {
                NextAddPassBtn.Enabled = false;
                NextAddPassBtn.BackColor = Color.Gray;
            }
            else if (!hasErrors)
            {
                NextAddPassBtn.Enabled = true;
                NextAddPassBtn.BackColor = Color.Green;
            }



        }


        private void NextAddPassBtn_Click(object sender, EventArgs e)
        {
            Flight flight = new Flight(TripType.Text, FlightClass.Text, DepartureCity.Text, ArrivalCity.Text, DepartureDateTime.Value, ReturnDateTime.Value, meal);

            flight.Save();
            FlightReservationStep2 passengerForm = new FlightReservationStep2();

            passengerForm.Show();
        }


        private void FlightReservationStep1_Load(object sender, EventArgs e)
        {
            TripType.Text = TripType.Items[0].ToString();
            FlightClass.Text = FlightClass.Items[0].ToString();
            DepartureCity.Text = DepartureCity.Items[0].ToString();
            RegularMeal.Checked = true;

            HandleButtonDisable();
        }

        private void DepartureDateTime_ValueChanged(object sender, EventArgs e)
        {
            Boolean isValid = Flight.ValidateFields(DepartureDateTime.Value, ReturnDateTime.Value);
            if (!isValid)
            {
                ReturnDateTime.Value = DepartureDateTime.Value.AddDays(1);
            }

            ReturnDateTime.MinDate = DepartureDateTime.Value.AddDays(1);
        }

        private void TripType_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean isValid = Flight.ValidateFields("tripType", TripType.Text);
            if (isValid)
            {
                UseError(TripType, String.Empty);

            }
            if (!isValid)
            {
                UseError(TripType, "Invalid trip type");

            }
        }

        private void FlightClass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean isValid = Flight.ValidateFields("flightClass", FlightClass.Text);
            if (isValid)
            {
                UseError(FlightClass, String.Empty);

            }
            if (!isValid)
            {
                UseError(FlightClass, "Invalid flight class");

            }
        }

        private void DepartureCity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean isValid = Flight.ValidateFields("departureCity", DepartureCity.Text);
            if (isValid)
            {
                UseError(DepartureCity, String.Empty);

            }
            if (!isValid)
            {
                UseError(DepartureCity, "Invalid departure city");

            }
        }

        private void ArrivalCity_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Boolean isValid = Flight.ValidateFields("arrivalCity", ArrivalCity.Text);
            if (isValid)
            {
                UseError(ArrivalCity, String.Empty);

            }
            if (!isValid)
            {
                UseError(ArrivalCity, "Invalid arrival city");

            }

        }

        private void HalalMeal_Click(object sender, EventArgs e)
        {
            if (HalalMeal.Checked)
            {
                meal = HalalMeal.Text;
            }
        }

        private void KosherMeal_Click(object sender, EventArgs e)
        {
            if (KosherMeal.Checked)
            {
                meal = KosherMeal.Text;
            }
        }

        private void RegularMeal_Click(object sender, EventArgs e)
        {
            if (RegularMeal.Checked)
            {
                meal = RegularMeal.Text;
            }
        }

        private void AgreeTerms_Click(object sender, EventArgs e)
        {
            agreedWithTerms = AgreeTerms.Checked;

            if (agreedWithTerms)
            {
                UseError(AgreeTerms, String.Empty);
            }

            if (!agreedWithTerms)
            {
                UseError(AgreeTerms, "Please agree to our terms and conditions.");
            }
        }


    }
}
