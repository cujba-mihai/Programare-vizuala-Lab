namespace cujba.mihai.lucrare.de.laborator._1
{
    public partial class StartPage : Form
    {

        private int currentImage = 0;
        protected Graphics myGraphics;
        public StartPage()
        {
            InitializeComponent();
            myGraphics = Graphics.FromHwnd(panel1.Handle);
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
            step1.MdiParent = this;
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
            review.MdiParent = this;
            review.Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightReservationStep1 step1 = new FlightReservationStep1();
            step1.MdiParent = this;
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
            review.MdiParent = this;
            review.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string reservationFolderPath = GetReservationsFolderPath();

            if (!Directory.Exists(reservationFolderPath))
            {
                Directory.CreateDirectory(reservationFolderPath);
            }

            FlightReservationStep1 step1 = new FlightReservationStep1();
            step1.MdiParent = this;
            step1.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string reservationFolderPath = GetReservationsFolderPath();
            if (!Directory.Exists(reservationFolderPath))
            {
                Directory.CreateDirectory(reservationFolderPath);
            }
            IEnumerable<string> reservations = Directory.EnumerateFiles(reservationFolderPath);
            ReviewReservations review = new ReviewReservations(reservations);
            review.MdiParent = this;
            review.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (imageList1.Images.Empty != true)
            {
                if (imageList1.Images.Count - 1 > currentImage)
                {
                    currentImage++;
                }
                else
                {
                    currentImage = 0;
                }
                panel1.Refresh();

                // Draw the image in the panel.
                imageList1.Draw(myGraphics, 10, 10, currentImage);

                // Show the image in the PictureBox.
                pictureBox1.Image = imageList1.Images[currentImage];
                label3.Text = "Current image is " + currentImage;
                listBox1.SelectedIndex = currentImage;
                label5.Text = "Image is " + listBox1.Text;
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontallyTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticallyTileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
    }
}
