using System.IO;
using System.Data;

namespace cujba.mihai.lucrare.de.laborator._1
{
    partial class ReviewReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewReservations));
            this._errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OpenFieldDialog = new System.Windows.Forms.OpenFileDialog();
            this.m_ImageList = new System.Windows.Forms.ImageList(this.components);
            this.m_FilesList = new System.Windows.Forms.ListView();
            this.m_hFileName = new System.Windows.Forms.ColumnHeader();
            this.m_hFileSize = new System.Windows.Forms.ColumnHeader();
            this.m_hFileModified = new System.Windows.Forms.ColumnHeader();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.RemoveFile = new System.Windows.Forms.Panel();
            this.flightTable = new System.Windows.Forms.DataGridView();
            this.TripType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Meal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengersTable = new System.Windows.Forms.DataGridView();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersTable)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _errProvider
            // 
            this._errProvider.ContainerControl = this;
            // 
            // OpenFieldDialog
            // 
            this.OpenFieldDialog.FileName = "OpenFieldDialog";
            // 
            // m_ImageList
            // 
            this.m_ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.m_ImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.m_ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // m_FilesList
            // 
            this.m_FilesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.m_hFileName,
            this.m_hFileSize,
            this.m_hFileModified});
            this.m_FilesList.Location = new System.Drawing.Point(0, 0);
            this.m_FilesList.Name = "m_FilesList";
            this.m_FilesList.Size = new System.Drawing.Size(121, 97);
            this.m_FilesList.TabIndex = 0;
            this.m_FilesList.UseCompatibleStateImageBehavior = false;
            this.m_FilesList.View = System.Windows.Forms.View.Details;
            // 
            // m_hFileName
            // 
            this.m_hFileName.Text = "File Name";
            this.m_hFileName.Width = 200;
            // 
            // m_hFileSize
            // 
            this.m_hFileSize.Text = "Size";
            this.m_hFileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m_hFileSize.Width = 100;
            // 
            // m_hFileModified
            // 
            this.m_hFileModified.Text = "Date Modified";
            this.m_hFileModified.Width = 140;
            // 
            // TreeView
            // 
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeView.Location = new System.Drawing.Point(41, 0);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(560, 217);
            this.TreeView.TabIndex = 2;
            this.TreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.TreeView_ItemDrag);
            this.TreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView_NodeMouseDoubleClick);
            this.TreeView.DragLeave += new System.EventHandler(this.TreeView_DragLeave);
            this.TreeView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TreeView_MouseDown);
            this.TreeView.MouseLeave += new System.EventHandler(this.TreeView_MouseLeave);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RemoveFile);
            this.flowLayoutPanel1.Controls.Add(this.TreeView);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 220);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // RemoveFile
            // 
            this.RemoveFile.AllowDrop = true;
            this.RemoveFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveFile.BackgroundImage")));
            this.RemoveFile.Location = new System.Drawing.Point(3, 177);
            this.RemoveFile.Name = "RemoveFile";
            this.RemoveFile.Size = new System.Drawing.Size(32, 40);
            this.RemoveFile.TabIndex = 7;
            this.RemoveFile.Visible = false;
            this.RemoveFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.RemoveFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.RemoveFile.DragLeave += new System.EventHandler(this.RemoveFile_DragLeave);
            // 
            // flightTable
            // 
            this.flightTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TripType,
            this.FlightClass,
            this.DepartureCity,
            this.ArrivalCity,
            this.DepartureDate,
            this.ReturnDate,
            this.Meal});
            this.flightTable.Location = new System.Drawing.Point(15, 402);
            this.flightTable.Name = "flightTable";
            this.flightTable.RowTemplate.Height = 25;
            this.flightTable.Size = new System.Drawing.Size(554, 161);
            this.flightTable.TabIndex = 5;
            // 
            // TripType
            // 
            this.TripType.HeaderText = "TripType";
            this.TripType.Name = "TripType";
            this.TripType.ReadOnly = true;
            // 
            // FlightClass
            // 
            this.FlightClass.HeaderText = "Flight Class";
            this.FlightClass.Name = "FlightClass";
            this.FlightClass.ReadOnly = true;
            // 
            // DepartureCity
            // 
            this.DepartureCity.HeaderText = "Departure City";
            this.DepartureCity.Name = "DepartureCity";
            this.DepartureCity.ReadOnly = true;
            // 
            // ArrivalCity
            // 
            this.ArrivalCity.HeaderText = "Arrival City";
            this.ArrivalCity.Name = "ArrivalCity";
            this.ArrivalCity.ReadOnly = true;
            // 
            // DepartureDate
            // 
            this.DepartureDate.HeaderText = "Departure Date";
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.ReadOnly = true;
            // 
            // ReturnDate
            // 
            this.ReturnDate.HeaderText = "Return Date";
            this.ReturnDate.Name = "ReturnDate";
            this.ReturnDate.ReadOnly = true;
            // 
            // Meal
            // 
            this.Meal.HeaderText = "Meal";
            this.Meal.Name = "Meal";
            this.Meal.ReadOnly = true;
            // 
            // passengersTable
            // 
            this.passengersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passengersTable.Location = new System.Drawing.Point(15, 238);
            this.passengersTable.Name = "passengersTable";
            this.passengersTable.RowTemplate.Height = 25;
            this.passengersTable.Size = new System.Drawing.Size(557, 158);
            this.passengersTable.TabIndex = 6;
            this.passengersTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.passengersTable_CellEndEdit);
            this.passengersTable.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.passengersTable_RowsRemoved);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tag = "ReservationReviewTimer";
            // 
            // Notification
            // 
            this.Notification.Text = "Notification";
            this.Notification.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ReviewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 575);
            this.Controls.Add(this.passengersTable);
            this.Controls.Add(this.flightTable);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReviewReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flight Management (DBA) - Cujba Mihai";
            this.Load += new System.EventHandler(this.ReviewReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errProvider)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersTable)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ErrorProvider _errProvider;
        private OpenFileDialog OpenFieldDialog;

        //Declarăm trei referinţe la obiecte ColumnHeader care incapsulează
        //lucrul cu coloane ale listei detaliate ListView
        private ColumnHeader m_hFileName;
        private ColumnHeader m_hFileSize;
        private ColumnHeader m_hFileModified;
        //Declarăm o referinţe la un şir de caractere în care vom păstra calea
        //spre directorul curent selectat în lista arborescentă
        private ImageList m_ImageList;
        private ListView m_FilesList;
        private TreeView TreeView;
        private DataGridView flightTable;
        private DataGridViewTextBoxColumn TripType;
        private DataGridViewTextBoxColumn FlightClass;
        private DataGridViewTextBoxColumn DepartureCity;
        private DataGridViewTextBoxColumn ArrivalCity;
        private DataGridViewTextBoxColumn DepartureDate;
        private DataGridViewTextBoxColumn ReturnDate;
        private DataGridViewTextBoxColumn Meal;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView passengersTable;
        private System.Windows.Forms.Timer Timer;
        private NotifyIcon Notification;
        private Panel RemoveFile;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}