namespace FlightReservationApp
{
    partial class CustomerGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGrid));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRAppDataSet3 = new FlightReservationApp.FRAppDataSet3();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colcustomerId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colcustomerId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colcustomerName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colcustomerName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colcontactNo = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colcontactNo = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colgender = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colgender = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colcountry = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colcountry = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colcity = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colcity = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.coladress = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_coladress = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colimg = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colimg = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.customerTableAdapter = new FlightReservationApp.FRAppDataSet3TableAdapters.CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcustomerId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcontactNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colgender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coladress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.customerBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(284, 262);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.fRAppDataSet3;
            // 
            // fRAppDataSet3
            // 
            this.fRAppDataSet3.DataSetName = "FRAppDataSet3";
            this.fRAppDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colcustomerId,
            this.colcustomerName,
            this.colcontactNo,
            this.colgender,
            this.colcountry,
            this.colcity,
            this.coladress,
            this.colimg});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colcustomerId
            // 
            this.colcustomerId.FieldName = "customerId";
            this.colcustomerId.LayoutViewField = this.layoutViewField_colcustomerId;
            this.colcustomerId.Name = "colcustomerId";
            // 
            // layoutViewField_colcustomerId
            // 
            this.layoutViewField_colcustomerId.EditorPreferredWidth = 117;
            this.layoutViewField_colcustomerId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colcustomerId.Name = "layoutViewField_colcustomerId";
            this.layoutViewField_colcustomerId.Size = new System.Drawing.Size(330, 20);
            this.layoutViewField_colcustomerId.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colcustomerName
            // 
            this.colcustomerName.FieldName = "customerName";
            this.colcustomerName.LayoutViewField = this.layoutViewField_colcustomerName;
            this.colcustomerName.Name = "colcustomerName";
            // 
            // layoutViewField_colcustomerName
            // 
            this.layoutViewField_colcustomerName.EditorPreferredWidth = 117;
            this.layoutViewField_colcustomerName.Location = new System.Drawing.Point(0, 20);
            this.layoutViewField_colcustomerName.Name = "layoutViewField_colcustomerName";
            this.layoutViewField_colcustomerName.Size = new System.Drawing.Size(330, 20);
            this.layoutViewField_colcustomerName.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colcontactNo
            // 
            this.colcontactNo.FieldName = "contactNo";
            this.colcontactNo.LayoutViewField = this.layoutViewField_colcontactNo;
            this.colcontactNo.Name = "colcontactNo";
            // 
            // layoutViewField_colcontactNo
            // 
            this.layoutViewField_colcontactNo.EditorPreferredWidth = 117;
            this.layoutViewField_colcontactNo.Location = new System.Drawing.Point(0, 40);
            this.layoutViewField_colcontactNo.Name = "layoutViewField_colcontactNo";
            this.layoutViewField_colcontactNo.Size = new System.Drawing.Size(330, 20);
            this.layoutViewField_colcontactNo.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colgender
            // 
            this.colgender.FieldName = "gender";
            this.colgender.LayoutViewField = this.layoutViewField_colgender;
            this.colgender.Name = "colgender";
            // 
            // layoutViewField_colgender
            // 
            this.layoutViewField_colgender.EditorPreferredWidth = 117;
            this.layoutViewField_colgender.Location = new System.Drawing.Point(0, 60);
            this.layoutViewField_colgender.Name = "layoutViewField_colgender";
            this.layoutViewField_colgender.Size = new System.Drawing.Size(330, 20);
            this.layoutViewField_colgender.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colcountry
            // 
            this.colcountry.FieldName = "country";
            this.colcountry.LayoutViewField = this.layoutViewField_colcountry;
            this.colcountry.Name = "colcountry";
            // 
            // layoutViewField_colcountry
            // 
            this.layoutViewField_colcountry.EditorPreferredWidth = 117;
            this.layoutViewField_colcountry.Location = new System.Drawing.Point(0, 80);
            this.layoutViewField_colcountry.Name = "layoutViewField_colcountry";
            this.layoutViewField_colcountry.Size = new System.Drawing.Size(330, 20);
            this.layoutViewField_colcountry.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colcity
            // 
            this.colcity.FieldName = "city";
            this.colcity.LayoutViewField = this.layoutViewField_colcity;
            this.colcity.Name = "colcity";
            // 
            // layoutViewField_colcity
            // 
            this.layoutViewField_colcity.EditorPreferredWidth = 117;
            this.layoutViewField_colcity.Location = new System.Drawing.Point(0, 100);
            this.layoutViewField_colcity.Name = "layoutViewField_colcity";
            this.layoutViewField_colcity.Size = new System.Drawing.Size(330, 20);
            this.layoutViewField_colcity.TextSize = new System.Drawing.Size(78, 13);
            // 
            // coladress
            // 
            this.coladress.FieldName = "adress";
            this.coladress.LayoutViewField = this.layoutViewField_coladress;
            this.coladress.Name = "coladress";
            // 
            // layoutViewField_coladress
            // 
            this.layoutViewField_coladress.EditorPreferredWidth = 117;
            this.layoutViewField_coladress.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_coladress.Name = "layoutViewField_coladress";
            this.layoutViewField_coladress.Size = new System.Drawing.Size(330, 20);
            this.layoutViewField_coladress.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colimg
            // 
            this.colimg.FieldName = "img";
            this.colimg.LayoutViewField = this.layoutViewField_colimg;
            this.colimg.Name = "colimg";
            // 
            // layoutViewField_colimg
            // 
            this.layoutViewField_colimg.EditorPreferredWidth = 117;
            this.layoutViewField_colimg.Location = new System.Drawing.Point(0, 140);
            this.layoutViewField_colimg.Name = "layoutViewField_colimg";
            this.layoutViewField_colimg.Size = new System.Drawing.Size(330, 44);
            this.layoutViewField_colimg.StartNewLine = true;
            this.layoutViewField_colimg.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colcustomerId,
            this.layoutViewField_colcustomerName,
            this.layoutViewField_colcontactNo,
            this.layoutViewField_colgender,
            this.layoutViewField_colcountry,
            this.layoutViewField_colcity,
            this.layoutViewField_coladress,
            this.layoutViewField_colimg});
            this.layoutViewCard1.Name = "layoutViewCard1";
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerGrid";
            this.Text = "Flight Reservation App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CustomerGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcustomerId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcontactNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colgender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coladress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private FRAppDataSet3 fRAppDataSet3;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private FRAppDataSet3TableAdapters.CustomerTableAdapter customerTableAdapter;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcustomerId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcustomerId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcustomerName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcustomerName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcontactNo;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcontactNo;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colgender;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colgender;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcountry;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcountry;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcity;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcity;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn coladress;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coladress;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colimg;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colimg;
    }
}