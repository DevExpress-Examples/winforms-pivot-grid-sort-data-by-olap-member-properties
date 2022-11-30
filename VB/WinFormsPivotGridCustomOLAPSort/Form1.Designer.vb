Namespace WinFormsPivotGridCustomOLAPSort
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.fieldProduct = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.fieldInternetSalesAmount = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldFiscalYear = New DevExpress.XtraPivotGrid.PivotGridField()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' fieldProduct
			' 
			Me.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProduct.AreaIndex = 0
			Me.fieldProduct.Caption = "Product"
			Me.fieldProduct.FieldName = "[Product].[Product].[Product]"
			Me.fieldProduct.Name = "fieldProduct"
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldInternetSalesAmount, Me.fieldFiscalYear, Me.fieldProduct})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OLAPConnectionString = "provider=MSOLAP;data source=http://demos.devexpress.com/Services/OLAP/msmdpump.dl" & "l;initial catalog=""Adventure Works DW Standard Edition"";cube name=""Adventure Wor" & "ks"""
			Me.pivotGridControl1.OLAPDataProvider = DevExpress.XtraPivotGrid.OLAPDataProvider.Adomd
			Me.pivotGridControl1.Size = New System.Drawing.Size(719, 466)
			Me.pivotGridControl1.TabIndex = 0
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.pivotGridControl1.CustomServerModeSort += new System.EventHandler<DevExpress.XtraPivotGrid.CustomServerModeSortEventArgs>(this.pivotGridControl1_CustomServerModeSort);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.pivotGridControl1.FieldValueDisplayText += new DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(this.pivotGridControl1_FieldValueDisplayText);
			' 
			' fieldInternetSalesAmount
			' 
			Me.fieldInternetSalesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldInternetSalesAmount.AreaIndex = 0
			Me.fieldInternetSalesAmount.Caption = "Internet Sales Amount"
			Me.fieldInternetSalesAmount.DisplayFolder = "Internet Sales"
			Me.fieldInternetSalesAmount.FieldName = "[Measures].[Internet Sales Amount]"
			Me.fieldInternetSalesAmount.Name = "fieldInternetSalesAmount"
			' 
			' fieldFiscalYear
			' 
			Me.fieldFiscalYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldFiscalYear.AreaIndex = 0
			Me.fieldFiscalYear.Caption = "Fiscal Year"
			Me.fieldFiscalYear.DisplayFolder = "Fiscal"
			Me.fieldFiscalYear.FieldName = "[Date].[Fiscal Year].[Fiscal Year]"
			Me.fieldFiscalYear.Name = "fieldFiscalYear"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(719, 466)
			Me.Controls.Add(Me.pivotGridControl1)
			Me.Name = "Form1"
			Me.Text = "Custom OLAP Sorting"
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldInternetSalesAmount As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldFiscalYear As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProduct As DevExpress.XtraPivotGrid.PivotGridField
	End Class
End Namespace

