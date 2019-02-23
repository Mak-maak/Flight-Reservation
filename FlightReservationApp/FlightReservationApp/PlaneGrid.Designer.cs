namespace FlightReservationApp
{
    partial class PlaneGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaneGrid));
            this.fRAppDataSet = new FlightReservationApp.FRAppDataSet();
            this.planeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planeTableAdapter = new FlightReservationApp.FRAppDataSetTableAdapters.PlaneTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colplaneId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colplaneId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colplaneNo = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colplaneNo = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colplaneName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colplaneName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colairline = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colairline = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colimg = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colimg = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colcolor = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colcolor = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colplaneId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colplaneNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colplaneName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colairline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // fRAppDataSet
            // 
            this.fRAppDataSet.DataSetName = "FRAppDataSet";
            this.fRAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planeBindingSource
            // 
            this.planeBindingSource.DataMember = "Plane";
            this.planeBindingSource.DataSource = this.fRAppDataSet;
            // 
            // planeTableAdapter
            // 
            this.planeTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.planeBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(284, 262);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colplaneId,
            this.colplaneNo,
            this.colplaneName,
            this.colairline,
            this.colimg,
            this.colcolor});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colplaneId
            // 
            this.colplaneId.FieldName = "planeId";
            this.colplaneId.LayoutViewField = this.layoutViewField_colplaneId;
            this.colplaneId.Name = "colplaneId";
            // 
            // layoutViewField_colplaneId
            // 
            this.layoutViewField_colplaneId.EditorPreferredWidth = 135;
            this.layoutViewField_colplaneId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colplaneId.Name = "layoutViewField_colplaneId";
            this.layoutViewField_colplaneId.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colplaneId.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colplaneNo
            // 
            this.colplaneNo.FieldName = "planeNo";
            this.colplaneNo.LayoutViewField = this.layoutViewField_colplaneNo;
            this.colplaneNo.Name = "colplaneNo";
            // 
            // layoutViewField_colplaneNo
            // 
            this.layoutViewField_colplaneNo.EditorPreferredWidth = 135;
            this.layoutViewField_colplaneNo.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colplaneNo.Name = "layoutViewField_colplaneNo";
            this.layoutViewField_colplaneNo.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colplaneNo.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colplaneName
            // 
            this.colplaneName.FieldName = "planeName";
            this.colplaneName.LayoutViewField = this.layoutViewField_colplaneName;
            this.colplaneName.Name = "colplaneName";
            // 
            // layoutViewField_colplaneName
            // 
            this.layoutViewField_colplaneName.EditorPreferredWidth = 135;
            this.layoutViewField_colplaneName.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colplaneName.Name = "layoutViewField_colplaneName";
            this.layoutViewField_colplaneName.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colplaneName.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colairline
            // 
            this.colairline.FieldName = "airline";
            this.colairline.LayoutViewField = this.layoutViewField_colairline;
            this.colairline.Name = "colairline";
            // 
            // layoutViewField_colairline
            // 
            this.layoutViewField_colairline.EditorPreferredWidth = 135;
            this.layoutViewField_colairline.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colairline.Name = "layoutViewField_colairline";
            this.layoutViewField_colairline.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colairline.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colimg
            // 
            this.colimg.FieldName = "img";
            this.colimg.LayoutViewField = this.layoutViewField_colimg;
            this.colimg.Name = "colimg";
            // 
            // layoutViewField_colimg
            // 
            this.layoutViewField_colimg.EditorPreferredWidth = 135;
            this.layoutViewField_colimg.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_colimg.Name = "layoutViewField_colimg";
            this.layoutViewField_colimg.Size = new System.Drawing.Size(203, 26);
            this.layoutViewField_colimg.StartNewLine = true;
            this.layoutViewField_colimg.TextSize = new System.Drawing.Size(60, 13);
            // 
            // colcolor
            // 
            this.colcolor.FieldName = "color";
            this.colcolor.LayoutViewField = this.layoutViewField_colcolor;
            this.colcolor.Name = "colcolor";
            // 
            // layoutViewField_colcolor
            // 
            this.layoutViewField_colcolor.EditorPreferredWidth = 135;
            this.layoutViewField_colcolor.Location = new System.Drawing.Point(0, 122);
            this.layoutViewField_colcolor.Name = "layoutViewField_colcolor";
            this.layoutViewField_colcolor.Size = new System.Drawing.Size(203, 24);
            this.layoutViewField_colcolor.TextSize = new System.Drawing.Size(60, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colplaneId,
            this.layoutViewField_colplaneNo,
            this.layoutViewField_colplaneName,
            this.layoutViewField_colairline,
            this.layoutViewField_colimg,
            this.layoutViewField_colcolor});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // PlaneGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlaneGrid";
            this.Text = "Flight Reservation App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlaneGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colplaneId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colplaneNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colplaneName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colairline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FRAppDataSet fRAppDataSet;
        private System.Windows.Forms.BindingSource planeBindingSource;
        private FRAppDataSetTableAdapters.PlaneTableAdapter planeTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colplaneId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colplaneId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colplaneNo;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colplaneNo;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colplaneName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colplaneName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colairline;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colairline;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colimg;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colimg;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcolor;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcolor;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}