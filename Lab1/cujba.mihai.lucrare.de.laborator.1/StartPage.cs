namespace cujba.mihai.lucrare.de.laborator._1
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }


        public static string GetReservationsFolderPath()
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string subFolderPath = Path.Combine(folderPath, "Reservations");

            return subFolderPath;
        }

        private void NewReservation_Click(object sender, EventArgs e)
        {

            string reservationFolderPath = GetReservationsFolderPath();

            if (!Directory.Exists(reservationFolderPath))
            {
                Directory.CreateDirectory(reservationFolderPath);
            }

            FlightReservationStep1 step1 = new FlightReservationStep1();
            step1.Show();
        }

        private void ReviewReservations_Click(object sender, EventArgs e)
        {
            string reservationFolderPath = GetReservationsFolderPath();
            if (!Directory.Exists(reservationFolderPath))
            {
                Directory.CreateDirectory(reservationFolderPath);
            }
            IEnumerable<string> reservations = Directory.EnumerateFiles(reservationFolderPath);
            ReviewReservations review = new ReviewReservations(reservations);
            review.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightReservationStep1 step1 = new FlightReservationStep1();
            step1.Show();
        }

        private void reviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reservationFolderPath = GetReservationsFolderPath();



            if (!Directory.Exists(reservationFolderPath))
            {
                int numberOfFilesInDirectory = Directory.EnumerateFiles(reservationFolderPath, ".xml", SearchOption.AllDirectories).Count();

                if (numberOfFilesInDirectory == 0)
                {
                    MessageBox.Show("No avaialable reservations");
                    return;
                }
                MessageBox.Show("No reservations have been made yet.");

                return;
            }
            IEnumerable<string> reservations = Directory.EnumerateFiles(reservationFolderPath);
            MessageBox.Show(reservations.ToString());
            ReviewReservations review = new ReviewReservations(reservations);
            review.Show();

        }

    }
}
