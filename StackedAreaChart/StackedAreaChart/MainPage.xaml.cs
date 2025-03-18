using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.Inputs;
using Syncfusion.Maui.Toolkit.Charts;

namespace StackedAreaChart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void chart_TrackballCreated(object sender, TrackballEventArgs e)
        {
            var pointInfo = e.TrackballPointsInfo;
            var model = pointInfo[0].DataItem as Model;
            var index = viewModel.ExportData.IndexOf(model);
            this.dataGrid.SelectedIndex = index + 1;
            this.dataGrid.ScrollToRowIndex(index, ScrollToPosition.Center, true);
        }

        private void dataGrid_SelectionChanged(object sender, DataGridSelectionChangedEventArgs e)
        {
            if (dataGrid.SelectedIndex > 0)
            {
                var index = this.dataGrid.SelectedIndex - 1;
                var model = viewModel.ExportData[index];
                var xPoint = chart.ValueToPoint(chart.XAxes[0], model.Year);
                var yPoint = chart.ValueToPoint(chart.YAxes[0], model.NorthAmerica);
                this.chart.TrackballBehavior.Show(xPoint, yPoint);
            }
            else
            {
                chart.TrackballBehavior.Hide();
            }
        }

        private void DataGrid_QueryRowHeight(object sender, DataGridQueryRowHeightEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                e.Height = e.GetIntrinsicRowHeight(e.RowIndex);
                e.Handled = true;
            }
        }

        private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
        {
            chart.SaveAsImage("Chart.png");
        }

        private void comboBox_SelectionChanged(object sender, Syncfusion.Maui.Inputs.SelectionChangedEventArgs e)
        {
            var comboBox = (SfComboBox)sender;
            int index = comboBox.SelectedIndex;
            var item = comboBox.SelectedItem as Country;
            chart.TrackballBehavior.Hide();
            viewModel.ReadCSV(item.Name);
            viewModel.SelectedCountry = item.Name;
        }
    }
}
