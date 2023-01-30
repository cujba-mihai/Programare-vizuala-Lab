using System.Data;
using System.Text.RegularExpressions;
using System.Xml;
class Passenger
{
    public Passenger(string title, string firstName, string lastName, DateTime birthDate, string countryCode, string phoneNumber, string email, int checkedLuggage, int handLuggage)
    {
        Title = title;
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        CountryCode = countryCode;
        PhoneNumber = phoneNumber;
        Email = email;
        CheckedLuggage = checkedLuggage;
        HandLuggage = handLuggage;
    }
    public static List<Passenger> allInstancesOfThisClass = new List<Passenger>();

    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string CountryCode { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public int CheckedLuggage { get; set; }
    public int HandLuggage { get; set; }


    public static Boolean ValidateField(string field, string value)
    {

        switch (field)
        {
            case "title":
                {
                    Regex titleRegex = new(@"^Mr?s?\.$|^Dr\.$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    return titleRegex.IsMatch(value);
                }
            case "firstName":
                {
                    Regex firstNamerRegex = new(@"[a-z]{2,}", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    return firstNamerRegex.IsMatch(value);
                }
            case "lastName":
                {
                    Regex lastNameRegex = new(@"[a-z]{2,}", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    return lastNameRegex.IsMatch(value);
                }
            case "email":
                {
                    Regex emailRegex = new(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    return emailRegex.IsMatch(value);
                }
            case "countryCode":
                {
                    Regex countryCodeRegex = new(@"^\+\d{1,3}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    return countryCodeRegex.IsMatch(value);
                }
            case "phoneNumber":
                {
                    Regex phoneNumberRegex = new(@"^\d{6,12}$", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    return phoneNumberRegex.IsMatch(value);
                }
            default: throw new ArgumentException("Invalid arguments passed!");
        }
    }

    public static void PrintPassengers(string path)
    {
        List<Passenger> _passengers = Passenger.allInstancesOfThisClass;
        XmlTextWriter textWriter = new XmlTextWriter(path + ".xml", null);
        int passengersCount = 0;

        textWriter.WriteStartDocument();
        textWriter.WriteStartElement("Reservation");
        // prints instances of passenger in XML Format
        foreach (Passenger _passenger in _passengers)
        {
            passengersCount++;

            textWriter.WriteStartElement("Passenger");
            textWriter.WriteAttributeString("Title", _passenger.Title.ToString());
            textWriter.WriteAttributeString("FirstName", _passenger.FirstName.ToString());
            textWriter.WriteAttributeString("LastName", _passenger.LastName.ToString());
            textWriter.WriteAttributeString("BirthDate", _passenger.BirthDate.ToString());
            textWriter.WriteAttributeString("CountryCode", _passenger.CountryCode.ToString());
            textWriter.WriteAttributeString("PhoneNumber", _passenger.PhoneNumber.ToString());
            textWriter.WriteAttributeString("Email", _passenger.Email.ToString());
            textWriter.WriteAttributeString("CheckedLuggage", _passenger.CheckedLuggage.ToString());
            textWriter.WriteAttributeString("HandLuggage", _passenger.HandLuggage.ToString());
            textWriter.WriteEndElement();


        }
        textWriter.WriteEndElement();

        textWriter.WriteEndDocument();
        textWriter.Close();

    }

    public void Save(DataTable passengersTable, DataGridView PassengersGrid)
    {
        if (passengersTable.Columns.Count == 0)
        {
            passengersTable.Columns.Add("Title");
            passengersTable.Columns.Add("First name");
            passengersTable.Columns.Add("Last name");
            passengersTable.Columns.Add("Birthdate");
            passengersTable.Columns.Add("Country code");
            passengersTable.Columns.Add("Phone number");
            passengersTable.Columns.Add("Email");
            passengersTable.Columns.Add("Checked luggage");
            passengersTable.Columns.Add("Hand luggage");
        }

        DataRow passengersTableRow = passengersTable.NewRow();

        passengersTableRow[0] = Title;
        passengersTableRow[1] = FirstName;
        passengersTableRow[2] = LastName;
        passengersTableRow[3] = BirthDate;
        passengersTableRow[4] = CountryCode;
        passengersTableRow[5] = PhoneNumber;
        passengersTableRow[6] = Email;
        passengersTableRow[7] = CheckedLuggage;
        passengersTableRow[8] = HandLuggage;

        passengersTable.Rows.Add(passengersTableRow);
        PassengersGrid.DataSource = passengersTable;

        Passenger.allInstancesOfThisClass.Add(this);
    }


}