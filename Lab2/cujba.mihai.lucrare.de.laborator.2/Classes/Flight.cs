

using System.Text.RegularExpressions;

class Flight
{
    public Flight(string tripType, string flightClass, string departureCity, string arrivalCity, DateTime departureDate, DateTime returnDate, string meal)
    {
        TripType = tripType;
        FlightClass = flightClass;
        DepartureCity = departureCity;
        ArrivalCity = arrivalCity;
        DepartureDate = departureDate;
        ReturnDate = returnDate;
        Meal = meal;
    }

    public string TripType { get; set; }
    public string FlightClass { get; set; }
    public string DepartureCity { get; set; }
    public string ArrivalCity { get; set; }
    public DateTime DepartureDate { get; set; }
    public DateTime ReturnDate { get; set; }
    public string Meal { get; set; }

    public static List<Flight> allInstancesOfThisClass = new List<Flight>();

    public static Boolean ValidateFields(string field, string value)
    {
        switch (field)
        {
            case "tripType":
                {
                    Regex flightTypeRegex = new(@"^((Return)|(One-way)|(Multi-city)|(Nomad))$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                    return flightTypeRegex.IsMatch(value);
                }
            case "flightClass":
                {
                    Regex flightClassRegex = new(@"^((Economy)|(Premium Economy)|(Business)|(First Class))$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                    return flightClassRegex.IsMatch(value);
                }
            case "departureCity":
                {
                    Regex cityRegex = new(@".{3,}", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                    return cityRegex.IsMatch(value);
                }
            case "arrivalCity":
                {
                    Regex cityRegex = new(@".{3,}", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                    return cityRegex.IsMatch(value);
                }
            case "meal":
                {
                    Regex mealRegex = new(@"^((Regular)|(Kosher)|(Halal))", RegexOptions.Compiled | RegexOptions.IgnoreCase);

                    return mealRegex.IsMatch(value);
                }
            default: throw new Exception("Invalid arguments passed");
        }

    }

    public static Boolean ValidateFields(DateTime departureDate, DateTime returnDate)
    {
        if (departureDate < returnDate)
        {
            return true;
        }

        return false;
    }

    public void Save()
    {
        Flight.allInstancesOfThisClass.Add(this);
    }



}