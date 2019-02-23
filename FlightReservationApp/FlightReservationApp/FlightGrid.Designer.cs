namespace FlightReservationApp
{
    partial class FlightGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightGrid));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.flightBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRAppDataSet2 = new FlightReservationApp.FRAppDataSet2();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colflightId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colflightId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colplaneId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colplaneId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colcustomerId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colcustomerId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.coldestination = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_coldestination = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.coldepartureAirport = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_coldepartureAirport = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colclass = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colclass = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.coladults = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_coladults = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colDepartureDate = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colDepartureDate = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.flightTableAdapter = new FlightReservationApp.FRAppDataSet2TableAdapters.FlightTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colflightId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colplaneId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcustomerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coldestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coldepartureAirport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colclass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coladults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDepartureDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.flightBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(284, 262);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // flightBindingSource
            // 
            this.flightBindingSource.DataMember = "Flight";
            this.flightBindingSource.DataSource = this.fRAppDataSet2;
            // 
            // fRAppDataSet2
            // 
            this.fRAppDataSet2.DataSetName = "FRAppDataSet2";
            this.fRAppDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colflightId,
            this.colplaneId,
            this.colcustomerId,
            this.coldestination,
            this.coldepartureAirport,
            this.colclass,
            this.coladults,
            this.colDepartureDate});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colflightId
            // 
            this.colflightId.FieldName = "flightId";
            this.colflightId.LayoutViewField = this.layoutViewField_colflightId;
            this.colflightId.Name = "colflightId";
            // 
            // layoutViewField_colflightId
            // 
            this.layoutViewField_colflightId.EditorPreferredWidth = 107;
            this.layoutViewField_colflightId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colflightId.Name = "layoutViewField_colflightId";
            this.layoutViewField_colflightId.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colflightId.TextSize = new System.Drawing.Size(88, 13);
            // 
            // colplaneId
            // 
            this.colplaneId.FieldName = "planeId";
            this.colplaneId.LayoutViewField = this.layoutViewField_colplaneId;
            this.colplaneId.Name = "colplaneId";
            // 
            // layoutViewField_colplaneId
            // 
            this.layoutViewField_colplaneId.EditorPreferredWidth = 107;
            this.layoutViewField_colplaneId.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colplaneId.Name = "layoutViewField_colplaneId";
            this.layoutViewField_colplaneId.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colplaneId.TextSize = new System.Drawing.Size(88, 13);
            // 
            // colcustomerId
            // 
            this.colcustomerId.FieldName = "customerId";
            this.colcustomerId.LayoutViewField = this.layoutViewField_colcustomerId;
            this.colcustomerId.Name = "colcustomerId";
            // 
            // layoutViewField_colcustomerId
            // 
            this.layoutViewField_colcustomerId.EditorPreferredWidth = 107;
            this.layoutViewField_colcustomerId.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colcustomerId.Name = "layoutViewField_colcustomerId";
            this.layoutViewField_colcustomerId.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colcustomerId.TextSize = new System.Drawing.Size(88, 13);
            // 
            // coldestination
            // 
            this.coldestination.FieldName = "destination";
            this.coldestination.LayoutViewField = this.layoutViewField_coldestination;
            this.coldestination.Name = "coldestination";
            // 
            // layoutViewField_coldestination
            // 
            this.layoutViewField_coldestination.EditorPreferredWidth = 107;
            this.layoutViewField_coldestination.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_coldestination.Name = "layoutViewField_coldestination";
            this.layoutViewField_coldestination.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_coldestination.TextSize = new System.Drawing.Size(88, 13);
            // 
            // coldepartureAirport
            // 
            this.coldepartureAirport.FieldName = "departureAirport";
            this.coldepartureAirport.LayoutViewField = this.layoutViewField_coldepartureAirport;
            this.coldepartureAirport.Name = "coldepartureAirport";
            // 
            // layoutViewField_coldepartureAirport
            // 
            this.layoutViewField_coldepartureAirport.EditorPreferredWidth = 107;
            this.layoutViewField_coldepartureAirport.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_coldepartureAirport.Name = "layoutViewField_coldepartureAirport";
            this.layoutViewField_coldepartureAirport.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_coldepartureAirport.TextSize = new System.Drawing.Size(88, 13);
            // 
            // colclass
            // 
            this.colclass.FieldName = "class";
            this.colclass.LayoutViewField = this.layoutViewField_colclass;
            this.colclass.Name = "colclass";
            // 
            // layoutViewField_colclass
            // 
            this.layoutViewField_colclass.EditorPreferredWidth = 107;
            this.layoutViewField_colclass.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colclass.Name = "layoutViewField_colclass";
            this.layoutViewField_colclass.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colclass.TextSize = new System.Drawing.Size(88, 13);
            // 
            // coladults
            // 
            this.coladults.FieldName = "adults";
            this.coladults.LayoutViewField = this.layoutViewField_coladults;
            this.coladults.Name = "coladults";
            // 
            // layoutViewField_coladults
            // 
            this.layoutViewField_coladults.EditorPreferredWidth = 107;
            this.layoutViewField_coladults.Location = new System.Drawing.Point(0, 144);
            this.layoutViewField_coladults.Name = "layoutViewField_coladults";
            this.layoutViewField_coladults.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_coladults.TextSize = new System.Drawing.Size(88, 13);
            // 
            // colDepartureDate
            // 
            this.colDepartureDate.FieldName = "DepartureDate";
            this.colDepartureDate.LayoutViewField = this.layoutViewField_colDepartureDate;
            this.colDepartureDate.Name = "colDepartureDate";
            // 
            // layoutViewField_colDepartureDate
            // 
            this.layoutViewField_colDepartureDate.EditorPreferredWidth = 107;
            this.layoutViewField_colDepartureDate.Location = new System.Drawing.Point(0, 168);
            this.layoutViewField_colDepartureDate.Name = "layoutViewField_colDepartureDate";
            this.layoutViewField_colDepartureDate.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colDepartureDate.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colflightId,
            this.layoutViewField_colplaneId,
            this.layoutViewField_colcustomerId,
            this.layoutViewField_coldestination,
            this.layoutViewField_coldepartureAirport,
            this.layoutViewField_colclass,
            this.layoutViewField_coladults,
            this.layoutViewField_colDepartureDate});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // flightTableAdapter
            // 
            this.flightTableAdapter.ClearBeforeFill = true;
            // 
            // FlightGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FlightGrid";
            this.Text = "Flight Reservation App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FlightGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colflightId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colplaneId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcustomerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coldestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coldepartureAirport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colclass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coladults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDepartureDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private FRAppDataSet2 fRAppDataSet2;
        private System.Windows.Forms.BindingSource flightBindingSource;
        private FRAppDataSet2TableAdapters.FlightTableAdapter flightTableAdapter;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colflightId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colflightId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colplaneId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colplaneId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcustomerId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcustomerId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn coldestination;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coldestination;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn coldepartureAirport;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coldepartureAirport;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colclass;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colclass;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn coladults;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coladults;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDepartureDate;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDepartureDate;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}