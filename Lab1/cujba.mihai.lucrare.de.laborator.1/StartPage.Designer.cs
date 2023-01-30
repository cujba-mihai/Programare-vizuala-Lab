namespace cujba.mihai.lucrare.de.laborator._1
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.NewReservation = new System.Windows.Forms.Button();
            this.ReviewReservations = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newReservationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newReservationToolStripMenuItem
            // 
            this.newReservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.reviewToolStripMenuItem});
            this.newReservationToolStripMenuItem.Name = "newReservationToolStripMenuItem";
            this.newReservationToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.newReservationToolStripMenuItem.Text = "Reservations";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // reviewToolStripMenuItem
            // 
            this.reviewToolStripMenuItem.Name = "reviewToolStripMenuItem";
            this.reviewToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.reviewToolStripMenuItem.Text = "Review";
            this.reviewToolStripMenuItem.Click += new System.EventHandler(this.reviewToolStripMenuItem_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.NewReservation);
            this.flowLayoutPanel1.Controls.Add(this.ReviewReservations);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 445);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // NewReservation
            // 
            this.NewReservation.BackColor = System.Drawing.Color.Green;
            this.NewReservation.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewReservation.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewReservation.ForeColor = System.Drawing.Color.White;
            this.NewReservation.Location = new System.Drawing.Point(20, 3);
            this.NewReservation.Margin = new System.Windows.Forms.Padding(20, 3, 40, 3);
            this.NewReservation.Name = "NewReservation";
            this.NewReservation.Size = new System.Drawing.Size(250, 250);
            this.NewReservation.TabIndex = 0;
            this.NewReservation.Text = "New Reservation";
            this.NewReservation.UseVisualStyleBackColor = false;
            this.NewReservation.Click += new System.EventHandler(this.NewReservation_Click);
            // 
            // ReviewReservations
            // 
            this.ReviewReservations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReviewReservations.CausesValidation = false;
            this.ReviewReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReviewReservations.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReviewReservations.Location = new System.Drawing.Point(313, 3);
            this.ReviewReservations.Name = "ReviewReservations";
            this.ReviewReservations.Size = new System.Drawing.Size(250, 250);
            this.ReviewReservations.TabIndex = 1;
            this.ReviewReservations.Text = "Review Reservations";
            this.ReviewReservations.UseVisualStyleBackColor = false;
            this.ReviewReservations.Click += new System.EventHandler(this.ReviewReservations_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.InitialDirectory = "c:\\\\";
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "StartPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Management (DBA) - Cujba Mihai";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newReservationToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem reviewToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button NewReservation;
        private Button ReviewReservations;
        private OpenFileDialog openFileDialog;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}