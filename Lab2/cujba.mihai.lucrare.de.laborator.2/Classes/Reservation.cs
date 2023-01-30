using System.Xml;

class Reservation
{
    public Reservation(List<Passenger> passengers, Flight flight)
    {
        _passengers = passengers;
        _flight = flight;
    }

    public List<Passenger> _passengers { get; set; }
    public Flight _flight { get; set; }


    public static void RemovePassenger(string path, int passengerNr)
    {
        // Initializes the variables to pass to the MessageBox.Show method.

        string message = "Are you sure you want to delete this passenger? This action is irreversible.";
        string caption = "Error Detected in Input";
        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        DialogResult result;

        // Displays the MessageBox.

        result = MessageBox.Show(message, caption, buttons);

        if (result == System.Windows.Forms.DialogResult.Yes)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode root = doc.DocumentElement;
            XmlNode child = doc.SelectSingleNode("descendant::Passenger[@Id=\'" + passengerNr + "\']");
            XmlNodeList aNodes = doc.SelectNodes("descendant::Passenger[@Id=\'" + passengerNr + "\']");
            if (aNodes.Count > 0)
            {
                foreach (XmlNode aNode in aNodes)
                {
                    aNode.ParentNode.RemoveChild(aNode);
                }


                doc.Save(path);
            }

            int passengersLeft = doc.SelectNodes("descendant::Passenger").Count;

            if (passengersLeft == 0)
            {
                File.Delete(path);
            }


        }
    }

    public static void EditReservation(string path, int passengerNr, string attribute, string value, DataGridView passengersTable)
    {
        string attr = Char.ToLowerInvariant(attribute[0]) + attribute[1..];

        bool isValid = Passenger.ValidateField(attr, value);

        if (!isValid)
        {
            MessageBox.Show("Invalid data passed into this field.");
            passengersTable.CancelEdit();
            return;
        }

        XmlDocument doc = new XmlDocument();
        doc.Load(path);

        // get a list of nodes - in this case, I'm selecting all <AID> nodes under
        // the <GroupAIDs> node - change to suit your needs
        XmlNodeList aNodes = doc.SelectNodes("descendant::Passenger[@Id=\'" + passengerNr + "\']");

        // loop through all AID nodes
        foreach (XmlNode aNode in aNodes)
        {

            // grab the "id" attribute
            XmlAttribute targetAttribute = aNode.Attributes[attribute];
            // check if that attribute even exists...
            if (targetAttribute != null)
            {
                // if yes - read its current value
                targetAttribute.Value = value;

            }

        }

        // save the XmlDocument back to disk
        doc.Save(path);

    }

    public static void DeleteReservation(string path)
    {
        File.Delete(path);
    }

    public void CreateReservation(string path)
    {
        XmlTextWriter textWriter = new XmlTextWriter(path + ".xml", null);
        int passengersCount = 0;

        textWriter.WriteStartDocument();
        textWriter.WriteStartElement("Reservation");
        textWriter.WriteStartElement("Flight");
        textWriter.WriteAttributeString("TripType", _flight.TripType.ToString());
        textWriter.WriteAttributeString("FlightClass", _flight.FlightClass.ToString());
        textWriter.WriteAttributeString("DepartureCity", _flight.DepartureCity.ToString());
        textWriter.WriteAttributeString("ArrivalCity", _flight.ArrivalCity.ToString());
        textWriter.WriteAttributeString("DepartureDate", _flight.DepartureDate.ToString());
        textWriter.WriteAttributeString("ReturnDate", _flight.ReturnDate.ToString());
        textWriter.WriteAttributeString("Meal", _flight.Meal.ToString());

        // prints instances of passenger in XML Format
        foreach (Passenger _passenger in _passengers)
        {
            passengersCount++;

            textWriter.WriteStartElement("Passenger");
            textWriter.WriteAttributeString("Id", passengersCount.ToString());
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

        Flight.allInstancesOfThisClass.Clear();
        Passenger.allInstancesOfThisClass.Clear();
    }


}