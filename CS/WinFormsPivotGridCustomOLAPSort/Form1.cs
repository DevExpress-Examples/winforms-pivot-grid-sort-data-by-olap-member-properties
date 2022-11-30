using System.Windows.Forms;
using DevExpress.XtraPivotGrid;
using DevExpress.Data.Filtering;
using System.Collections;
using System.Linq;
using System;

namespace WinFormsPivotGridCustomOLAPSort {
    public partial class Form1 : Form {
        public Form1() {

            InitializeComponent();
            // Creates a new collection of OLAP member properties.
            fieldProduct.AutoPopulatedProperties = new string[] { "Color", "Class", "List Price" };
            //Sets a field's sort mode to Custom to raise the CustomServerModeSort event.
            fieldProduct.SortMode = PivotSortMode.Custom;
            fieldFiscalYear.FilterValues.FilterType = PivotFilterType.Included;
            fieldFiscalYear.FilterValues.ValuesIncluded = new object[] { 2004, 2005 };
            pivotGridControl1.BestFit();
       
        }

        private void pivotGridControl1_CustomServerModeSort(object sender, 
            CustomServerModeSortEventArgs e) {
            if (e.Field == fieldProduct) {
                // Sets the result of comparing the "Product" field's values 
                // by the "Color" OLAP member property.
                e.Result = Comparer.Default.Compare(
                    e.OLAPMember1.AutoPopulatedProperties["List Price"].Value,
                    e.OLAPMember2.AutoPopulatedProperties["List Price"].Value
                );
            }
        }

        private void pivotGridControl1_FieldValueDisplayText(object sender,
            PivotFieldDisplayTextEventArgs e) {
            if (e.Field == fieldProduct) {
                IOLAPMember currentMember =
                   e.Field.GetOLAPMembers().First(m => Object.Equals(m.Value, e.Value));
                e.DisplayText +=
                   string.Format(" ({0:C2})", currentMember.AutoPopulatedProperties["List Price"].Value);
            }
        }
    }
}
