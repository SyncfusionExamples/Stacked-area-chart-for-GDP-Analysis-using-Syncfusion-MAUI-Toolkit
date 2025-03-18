using Syncfusion.Maui.Toolkit.Charts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackedAreaChart
{
    public class InteractionExt : ChartInteractiveBehavior
    {
        protected override void OnTouchMove(ChartBase chart, float pointX, float pointY)
        {
            base.OnTouchMove(chart, pointX, pointY);
            bool isSeriesTouched = false;

            if (chart is SfCartesianChart stackedAreaChart)
            {
                var series = stackedAreaChart.Series;

                for (int i = 0; i < series.Count; i++)
                {
                    var seriesItem = series[i];

                    if (seriesItem != null)
                    {
                        var index = seriesItem.GetDataPointIndex(pointX, pointY);

                        if (index != -1)
                        {
                            seriesItem.Opacity = 1;
                            isSeriesTouched = true;
                        }
                        else
                        {
                            seriesItem.Opacity = 0.33;
                        }
                    }
                }

                if (!isSeriesTouched)
                {
                    foreach (var item in series)
                    {
                        item.Opacity = 1;
                    }
                }
            }
        }
    }

    public class TrackballExt : ChartTrackballBehavior
    {
        protected override void LabelsGenerated(List<TrackballPointInfo> pointInfos)
        {
            foreach (var item in pointInfos)
            {
                var series = item.Series;

                if (series is StackingAreaSeries stackingArea && stackingArea.YBindingPath != "NorthAmerica")
                {
                    item.Label = string.Empty;
                }

                item.MarkerSettings = new ChartMarkerSettings() { Fill = Colors.White, Stroke = series.Fill, StrokeWidth = 2 };
            }
        }
    }

    public class TrackballLabelConverter : IValueConverter
    {
        private static readonly Dictionary<string, Func<Model, double>> DataSelectors = new()
        {
            { "0", m => m.Oceania },
            { "1", m => m.EasternEurope },
            { "2", m => m.Africa },
            { "3", m => m.SouthAmerica },
            { "4", m => m.NorthAmerica },
            { "5", m => m.WesternEurope },
            { "6", m => m.Asia },
            { "7", m => m.Total }
        };

        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not TrackballPointInfo pointInfo || parameter is not string para)
                return null;

            if (pointInfo.DataItem is Model model && DataSelectors.TryGetValue(para, out var selector))
            {
                double yValue = selector(model);
                return $"{Math.Round(yValue, 2)}%";
            }

            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class TrackballColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is not TrackballPointInfo pointInfo || parameter is not string para)
                return null;

            if (pointInfo.Series.BindingContext is ViewModel viewModel
                && int.TryParse(para, out int index)
                && index >= 0 && index < viewModel.PaletteBrushes.Count)
            {
                return ((SolidColorBrush)viewModel.PaletteBrushes[index]).Color;
            }

            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
