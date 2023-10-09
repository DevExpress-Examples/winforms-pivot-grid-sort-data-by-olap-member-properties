Namespace WinFormsPivotGridCustomOLAPSort

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.fieldFiscalYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldSalesAmount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProduct = New DevExpress.XtraPivotGrid.PivotGridField()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' fieldFiscalYear
            ' 
            Me.fieldFiscalYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldFiscalYear.AreaIndex = 0
            Me.fieldFiscalYear.Caption = "Year"
            Me.fieldFiscalYear.DisplayFolder = "Fiscal"
            Me.fieldFiscalYear.FieldName = "[Date].[Fiscal].[Fiscal Year]"
            Me.fieldFiscalYear.Name = "fieldFiscalYear"
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldSalesAmount, Me.fieldProduct, Me.fieldFiscalYear})
            pivotGridGroup1.Caption = "Date.Fiscal"
            pivotGridGroup1.Fields.Add(Me.fieldFiscalYear)
            pivotGridGroup1.Hierarchy = "[Date].[Fiscal]"
            pivotGridGroup1.ShowNewValues = True
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {pivotGridGroup1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OLAPConnectionString = "provider=MSOLAP;data source=http://demos.devexpress.com/Services/OLAP/msmdpump.dl" & "l;initial catalog=""Adventure Works DW Standard Edition"";cube name=""Adventure Wor" & "ks"""
            Me.pivotGridControl1.OLAPDataProvider = DevExpress.XtraPivotGrid.OLAPDataProvider.Adomd
            Me.pivotGridControl1.Size = New System.Drawing.Size(719, 466)
            Me.pivotGridControl1.TabIndex = 0
            AddHandler Me.pivotGridControl1.CustomServerModeSort, New System.EventHandler(Of DevExpress.XtraPivotGrid.CustomServerModeSortEventArgs)(AddressOf Me.pivotGridControl1_CustomServerModeSort)
            AddHandler Me.pivotGridControl1.FieldValueDisplayText, New DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(AddressOf Me.pivotGridControl1_FieldValueDisplayText)
            ' 
            ' fieldSalesAmount
            ' 
            Me.fieldSalesAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldSalesAmount.AreaIndex = 0
            Me.fieldSalesAmount.Caption = "Sales Amount"
            Me.fieldSalesAmount.DisplayFolder = "Sales Summary"
            Me.fieldSalesAmount.FieldName = "[Measures].[Sales Amount]"
            Me.fieldSalesAmount.Name = "fieldSalesAmount"
            ' 
            ' fieldProduct
            ' 
            Me.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProduct.AreaIndex = 0
            Me.fieldProduct.Caption = "Product"
            Me.fieldProduct.FieldName = "[Product].[Product].[Product]"
            Me.fieldProduct.Name = "fieldProduct"
            Me.fieldProduct.Width = 200
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(719, 466)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Custom OLAP Sorting"
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldSalesAmount As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProduct As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldFiscalYear As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
