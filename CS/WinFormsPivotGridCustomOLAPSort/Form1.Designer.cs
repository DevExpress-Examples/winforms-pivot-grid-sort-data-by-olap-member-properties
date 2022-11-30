namespace WinFormsPivotGridCustomOLAPSort
{
    partial class Form1
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
            this.fieldProduct = new DevExpress.XtraPivotGrid.PivotGridField();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.fieldInternetSalesAmount = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldFiscalYear = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldProduct
            // 
            this.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProduct.AreaIndex = 0;
            this.fieldProduct.Caption = "Product";
            this.fieldProduct.FieldName = "[Product].[Product].[Product]";
            this.fieldProduct.Name = "fieldProduct";
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldInternetSalesAmount,
            this.fieldFiscalYear,
            this.fieldProduct});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OLAPConnectionString = "provider=MSOLAP;data source=http://demos.devexpress.com/Services/OLAP/msmdpump.dl" +
    "l;initial catalog=\"Adventure Works DW Standard Edition\";cube name=\"Adventure Wor" +
    "ks\"";
            this.pivotGridControl1.OLAPDataProvider = DevExpress.XtraPivotGrid.OLAPDataProvider.Adomd;
            this.pivotGridControl1.Size = new System.Drawing.Size(719, 466);
            this.pivotGridControl1.TabIndex = 0;
            this.pivotGridControl1.CustomServerModeSort += new System.EventHandler<DevExpress.XtraPivotGrid.CustomServerModeSortEventArgs>(this.pivotGridControl1_CustomServerModeSort);
            this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
            // 
            // fieldInternetSalesAmount
            // 
            this.fieldInternetSalesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldInternetSalesAmount.AreaIndex = 0;
            this.fieldInternetSalesAmount.Caption = "Internet Sales Amount";
            this.fieldInternetSalesAmount.DisplayFolder = "Internet Sales";
            this.fieldInternetSalesAmount.FieldName = "[Measures].[Internet Sales Amount]";
            this.fieldInternetSalesAmount.Name = "fieldInternetSalesAmount";
            // 
            // fieldFiscalYear
            // 
            this.fieldFiscalYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldFiscalYear.AreaIndex = 0;
            this.fieldFiscalYear.Caption = "Fiscal Year";
            this.fieldFiscalYear.DisplayFolder = "Fiscal";
            this.fieldFiscalYear.FieldName = "[Date].[Fiscal Year].[Fiscal Year]";
            this.fieldFiscalYear.Name = "fieldFiscalYear";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 466);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "Form1";
            this.Text = "Custom OLAP Sorting";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldInternetSalesAmount;
        private DevExpress.XtraPivotGrid.PivotGridField fieldFiscalYear;
        private DevExpress.XtraPivotGrid.PivotGridField fieldProduct;
    }
}

