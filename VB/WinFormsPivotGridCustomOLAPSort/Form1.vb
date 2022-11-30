Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.Filtering
Imports System.Collections
Imports System.Linq
Imports System

Namespace WinFormsPivotGridCustomOLAPSort
	Partial Public Class Form1
		Inherits Form

		Public Sub New()

			InitializeComponent()
			' Creates a new collection of OLAP member properties.
			fieldProduct.AutoPopulatedProperties = New String() { "Color", "Class", "List Price" }
			'Sets a field's sort mode to Custom to raise the CustomServerModeSort event.
			fieldProduct.SortMode = PivotSortMode.Custom
			fieldFiscalYear.FilterValues.FilterType = PivotFilterType.Included
			fieldFiscalYear.FilterValues.ValuesIncluded = New Object() { 2004, 2005 }
			pivotGridControl1.BestFit()

		End Sub

		Private Sub pivotGridControl1_CustomServerModeSort(ByVal sender As Object, ByVal e As CustomServerModeSortEventArgs) Handles pivotGridControl1.CustomServerModeSort
			If e.Field Is fieldProduct Then
				' Sets the result of comparing the "Product" field's values 
				' by the "Color" OLAP member property.
				e.Result = Comparer.Default.Compare(e.OLAPMember1.AutoPopulatedProperties("List Price").Value, e.OLAPMember2.AutoPopulatedProperties("List Price").Value)
			End If
		End Sub

		Private Sub pivotGridControl1_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs) Handles pivotGridControl1.FieldValueDisplayText
			If e.Field Is fieldProduct Then
				Dim currentMember As IOLAPMember = e.Field.GetOLAPMembers().First(Function(m) Object.Equals(m.Value, e.Value))
				e.DisplayText &= String.Format(" ({0:C2})", currentMember.AutoPopulatedProperties("List Price").Value)
			End If
		End Sub
	End Class
End Namespace
