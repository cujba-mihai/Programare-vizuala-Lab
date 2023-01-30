using System.Xml;

namespace cujba.mihai.lucrare.de.laborator._1
{
    public partial class ReviewReservations : Form
    {

        public ReviewReservations(IEnumerable<string> reservations)
        {
            Reservations = reservations;
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
        }


        public IEnumerable<string> Reservations { get; set; }

        private void ReviewReservations_Load(object sender, EventArgs e)
        {
            foreach (string file in Reservations)
            {
                TreeView.Nodes.Add(file);

            }
        }

        private void TreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            RemoveFile.Visible = false;
            passengersTable.Columns.Clear();
            flightTable.Columns.Clear();

            XmlTextReader reader = new XmlTextReader(e.Node.FullPath);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        switch (reader.Name)
                        {
                            case "Passenger":
                                if (passengersTable.Columns.Count == 0)
                                {
                                    passengersTable.Columns.Add("Title", "Title");
                                    passengersTable.Columns.Add("FirstName", "First name");
                                    passengersTable.Columns.Add("LastName", "Last name");
                                    passengersTable.Columns.Add("Birthdate", "Birthdate");
                                    passengersTable.Columns.Add("CountryCode", "Country code");
                                    passengersTable.Columns.Add("PhoneNumber", "Phone number");
                                    passengersTable.Columns.Add("Email", "Email");
                                    passengersTable.Columns.Add("CheckedLuggage", "Checked luggage");
                                    passengersTable.Columns.Add("HandLuggage", "Hand luggage");
                                }
                                string? Title = reader.GetAttribute("Title");
                                string? FirstName = reader.GetAttribute("FirstName");
                                string? LastName = reader.GetAttribute("LastName");
                                string? BirthDate = reader.GetAttribute("BirthDate");
                                string? CountryCode = reader.GetAttribute("CountryCode");
                                string? PhoneNumber = reader.GetAttribute("PhoneNumber");
                                string? Email = reader.GetAttribute("Email");
                                string? CheckedLuggage = reader.GetAttribute("CheckedLuggage");
                                string? HandLuggage = reader.GetAttribute("HandLuggage");
#pragma warning disable CS8601 // Possible null reference assignment.
                                string[] row = new string[] { Title, FirstName, LastName, BirthDate, CountryCode, PhoneNumber, Email, CheckedLuggage, HandLuggage };
#pragma warning restore CS8601 // Possible null reference assignment.
                                passengersTable.Rows.Add(row);

                                break;
                            case "Flight":
                                if (flightTable.Columns.Count == 0)
                                {
                                    flightTable.Columns.Add("TripType", "TripType");
                                    flightTable.Columns.Add("FlightClass", "FlightClass");
                                    flightTable.Columns.Add("DepartureCity", "DepartureCity");
                                    flightTable.Columns.Add("ArrivalCity", "ArrivalCity");
                                    flightTable.Columns.Add("DepartureDate", "DepartureDate");
                                    flightTable.Columns.Add("ReturnDate", "ReturnDate");
                                    flightTable.Columns.Add("Meal", "Meal");
                                }
                                string? TripType = reader.GetAttribute("TripType");
                                string? FlightClass = reader.GetAttribute("FlightClass");
                                string? DepartureCity = reader.GetAttribute("DepartureCity");
                                string? ArrivalCity = reader.GetAttribute("ArrivalCity");
                                string? DepartureDate = reader.GetAttribute("DepartureDate");
                                string? ReturnDate = reader.GetAttribute("ReturnDate");
                                string? Meal = reader.GetAttribute("Meal");
#pragma warning disable CS8601 // Possible null reference assignment.
                                string[] flightRow = new string[] { TripType, FlightClass, DepartureCity, ArrivalCity, DepartureDate, ReturnDate, Meal };
                                flightTable.Rows.Add(flightRow);
                                break;
                            case "Reservation":
                                break;
                        }

                        break;

                }
            }
            reader.Close();
        }



        private void TreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            string filePath = e.Item.ToString().Replace("TreeNode:", "").Trim();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            // Move the dragged node when the left mouse button is used.
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(filePath, DragDropEffects.Copy);
            }


        }



        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;


        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string filePath = e.Data.GetData(typeof(string)).ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            RemoveFile.Visible = false;

#pragma warning disable CS8604 // Possible null reference argument.
            Reservation.DeleteReservation(filePath);
#pragma warning restore CS8604 // Possible null reference argument.

            TreeView.Nodes.Clear();
            foreach (string file in Reservations)
            {
                TreeView.Nodes.Add(file);
            }

        }

        private void TreeView_MouseDown(object sender, MouseEventArgs e)
        {
            RemoveFile.Visible = true;

        }

        private void RemoveFile_DragLeave(object sender, EventArgs e)
        {
            RemoveFile.Visible = false;

        }

        private void TreeView_MouseLeave(object sender, EventArgs e)
        {

        }

        private void TreeView_DragLeave(object sender, EventArgs e)
        {
            RemoveFile.Visible = false;

        }

        private void passengersTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string filePath = TreeView.SelectedNode.ToString().Replace("TreeNode:", "").Trim();
            int passengerNr = passengersTable.SelectedCells[0].RowIndex + 1;
            int columnIndex = passengersTable.SelectedCells[0].ColumnIndex;
            string attribute = passengersTable.Columns[columnIndex].Name;
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string value = passengersTable.SelectedCells[0].Value.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604 // Possible null reference argument.
            Reservation.EditReservation(filePath, passengerNr, attribute, value, passengersTable);
#pragma warning restore CS8604 // Possible null reference argument.
        }

        private void passengersTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            string filePath = TreeView.SelectedNode.ToString().Replace("TreeNode:", "").Trim();
            int passengerNr = 0;
            if (passengersTable?.SelectedRows.Count > 0)
            {
                passengerNr = passengersTable.SelectedRows[0].Index;
            }
            Reservation.RemovePassenger(filePath, passengerNr + 1);

            TreeView.Nodes.Clear();
            foreach (var file in Reservations)
            {
                TreeView.Nodes.Add(file);
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
