namespace FlightReservationApp
{
    partial class EmployeeGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeGrid));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRAppDataSet1 = new FlightReservationApp.FRAppDataSet1();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colempId = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colempId = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colempFirstName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colempFirstName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colempLastName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colempLastName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colempContact = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colempContact = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colcountry = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colcountry = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colcity = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colcity = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.coladress = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_coladress = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.coldepartment = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_coldepartment = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.coljobTitle = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_coljobTitle = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colsalary = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colsalary = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colimg = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colimg = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colgender = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colgender = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.fRAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fRAppDataSet = new FlightReservationApp.FRAppDataSet();
            this.employeeTableAdapter = new FlightReservationApp.FRAppDataSet1TableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colempId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colempFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colempLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colempContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coladress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coldepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coljobTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colsalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colgender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.employeeBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(284, 262);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.fRAppDataSet1;
            // 
            // fRAppDataSet1
            // 
            this.fRAppDataSet1.DataSetName = "FRAppDataSet1";
            this.fRAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutView1
            // 
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colempId,
            this.colempFirstName,
            this.colempLastName,
            this.colempContact,
            this.colcountry,
            this.colcity,
            this.coladress,
            this.coldepartment,
            this.coljobTitle,
            this.colsalary,
            this.colimg,
            this.colgender});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.ReadOnly = true;
            this.layoutView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colempId, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colempId
            // 
            this.colempId.FieldName = "empId";
            this.colempId.LayoutViewField = this.layoutViewField_colempId;
            this.colempId.Name = "colempId";
            // 
            // layoutViewField_colempId
            // 
            this.layoutViewField_colempId.EditorPreferredWidth = 117;
            this.layoutViewField_colempId.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colempId.Name = "layoutViewField_colempId";
            this.layoutViewField_colempId.Size = new System.Drawing.Size(202, 24);
            this.layoutViewField_colempId.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colempFirstName
            // 
            this.colempFirstName.FieldName = "empFirstName";
            this.colempFirstName.LayoutViewField = this.layoutViewField_colempFirstName;
            this.colempFirstName.Name = "colempFirstName";
            // 
            // layoutViewField_colempFirstName
            // 
            this.layoutViewField_colempFirstName.EditorPreferredWidth = 117;
            this.layoutViewField_colempFirstName.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colempFirstName.Name = "layoutViewField_colempFirstName";
            this.layoutViewField_colempFirstName.Size = new System.Drawing.Size(202, 24);
            this.layoutViewField_colempFirstName.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colempLastName
            // 
            this.colempLastName.FieldName = "empLastName";
            this.colempLastName.LayoutViewField = this.layoutViewField_colempLastName;
            this.colempLastName.Name = "colempLastName";
            // 
            // layoutViewField_colempLastName
            // 
            this.layoutViewField_colempLastName.EditorPreferredWidth = 117;
            this.layoutViewField_colempLastName.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colempLastName.Name = "layoutViewField_colempLastName";
            this.layoutViewField_colempLastName.Size = new System.Drawing.Size(202, 24);
            this.layoutViewField_colempLastName.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colempContact
            // 
            this.colempContact.FieldName = "empContact";
            this.colempContact.LayoutViewField = this.layoutViewField_colempContact;
            this.colempContact.Name = "colempContact";
            // 
            // layoutViewField_colempContact
            // 
            this.layoutViewField_colempContact.EditorPreferredWidth = 117;
            this.layoutViewField_colempContact.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colempContact.Name = "layoutViewField_colempContact";
            this.layoutViewField_colempContact.Size = new System.Drawing.Size(202, 24);
            this.layoutViewField_colempContact.TextSize = new System.Drawing.Size(78, 13);
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
            this.layoutViewField_colcountry.Location = new System.Drawing.Point(0, 96);
            this.layoutViewField_colcountry.Name = "layoutViewField_colcountry";
            this.layoutViewField_colcountry.Size = new System.Drawing.Size(202, 24);
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
            this.layoutViewField_colcity.Location = new System.Drawing.Point(0, 120);
            this.layoutViewField_colcity.Name = "layoutViewField_colcity";
            this.layoutViewField_colcity.Size = new System.Drawing.Size(202, 24);
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
            this.layoutViewField_coladress.Location = new System.Drawing.Point(0, 144);
            this.layoutViewField_coladress.Name = "layoutViewField_coladress";
            this.layoutViewField_coladress.Size = new System.Drawing.Size(202, 24);
            this.layoutViewField_coladress.TextSize = new System.Drawing.Size(78, 13);
            // 
            // coldepartment
            // 
            this.coldepartment.FieldName = "department";
            this.coldepartment.LayoutViewField = this.layoutViewField_coldepartment;
            this.coldepartment.Name = "coldepartment";
            // 
            // layoutViewField_coldepartment
            // 
            this.layoutViewField_coldepartment.EditorPreferredWidth = 117;
            this.layoutViewField_coldepartment.Location = new System.Drawing.Point(0, 168);
            this.layoutViewField_coldepartment.Name = "layoutViewField_coldepartment";
            this.layoutViewField_coldepartment.Size = new System.Drawing.Size(202, 24);
            this.layoutViewField_coldepartment.TextSize = new System.Drawing.Size(78, 13);
            // 
            // coljobTitle
            // 
            this.coljobTitle.FieldName = "jobTitle";
            this.coljobTitle.LayoutViewField = this.layoutViewField_coljobTitle;
            this.coljobTitle.Name = "coljobTitle";
            // 
            // layoutViewField_coljobTitle
            // 
            this.layoutViewField_coljobTitle.EditorPreferredWidth = 117;
            this.layoutViewField_coljobTitle.Location = new System.Drawing.Point(0, 192);
            this.layoutViewField_coljobTitle.Name = "layoutViewField_coljobTitle";
            this.layoutViewField_coljobTitle.Size = new System.Drawing.Size(202, 24);
            this.layoutViewField_coljobTitle.TextSize = new System.Drawing.Size(78, 13);
            // 
            // colsalary
            // 
            this.colsalary.FieldName = "salary";
            this.colsalary.LayoutViewField = this.layoutViewField_colsalary;
            this.colsalary.Name = "colsalary";
            // 
            // layoutViewField_colsalary
            // 
            this.layoutViewField_colsalary.EditorPreferredWidth = 117;
            this.layoutViewField_colsalary.Location = new System.Drawing.Point(0, 216);
            this.layoutViewField_colsalary.Name = "layoutViewField_colsalary";
            this.layoutViewField_colsalary.Size = new System.Drawing.Size(202, 24);
            this.layoutViewField_colsalary.TextSize = new System.Drawing.Size(78, 13);
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
            this.layoutViewField_colimg.Location = new System.Drawing.Point(0, 240);
            this.layoutViewField_colimg.Name = "layoutViewField_colimg";
            this.layoutViewField_colimg.Size = new System.Drawing.Size(202, 24);
            this.layoutViewField_colimg.StartNewLine = true;
            this.layoutViewField_colimg.TextSize = new System.Drawing.Size(78, 13);
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
            this.layoutViewField_colgender.Location = new System.Drawing.Point(0, 264);
            this.layoutViewField_colgender.Name = "layoutViewField_colgender";
            this.layoutViewField_colgender.Size = new System.Drawing.Size(202, 24);
            this.layoutViewField_colgender.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colempId,
            this.layoutViewField_colempFirstName,
            this.layoutViewField_colempLastName,
            this.layoutViewField_colempContact,
            this.layoutViewField_colcountry,
            this.layoutViewField_colcity,
            this.layoutViewField_coladress,
            this.layoutViewField_coldepartment,
            this.layoutViewField_coljobTitle,
            this.layoutViewField_colsalary,
            this.layoutViewField_colimg,
            this.layoutViewField_colgender});
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // fRAppDataSetBindingSource
            // 
            this.fRAppDataSetBindingSource.DataSource = this.fRAppDataSet;
            this.fRAppDataSetBindingSource.Position = 0;
            // 
            // fRAppDataSet
            // 
            this.fRAppDataSet.DataSetName = "FRAppDataSet";
            this.fRAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.gridControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmployeeGrid";
            this.Text = "Flight Reserveration App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colempId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colempFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colempLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colempContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colcity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coladress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coldepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_coljobTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colsalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colgender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fRAppDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource fRAppDataSetBindingSource;
        private FRAppDataSet fRAppDataSet;
        private FRAppDataSet1 fRAppDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private FRAppDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colempId;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colempId;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colempFirstName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colempFirstName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colempLastName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colempLastName;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colempContact;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colempContact;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcountry;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcountry;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colcity;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colcity;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn coladress;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coladress;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn coldepartment;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coldepartment;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn coljobTitle;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_coljobTitle;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colsalary;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colsalary;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colimg;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colimg;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colgender;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colgender;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
    }
}