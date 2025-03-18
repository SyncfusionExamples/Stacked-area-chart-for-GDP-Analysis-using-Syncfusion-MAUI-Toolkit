using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;

namespace StackedAreaChart
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Model>? ExportData { get; set; }
        public ObservableCollection<Country>? Countries { get; set; }

        private string selectedCountry;

        public string SelectedCountry
        {
            get { return selectedCountry; }
            set
            {
                if (selectedCountry != value)
                {
                    selectedCountry = value;
                    OnPropertyChanged(nameof(SelectedCountry));
                    OnPropertyChanged(nameof(TitleText));
                    OnPropertyChanged(nameof(SubTitleText));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public string TitleText => $"{SelectedCountry}’s Merchandise Export Trends Across Continents";
        public string SubTitleText => $"A Historical Analysis of {SelectedCountry}'s Global Trade Expansion.";

        public List<Brush> PaletteBrushes { get; set; }

        public ViewModel()
        {
            SelectedCountry = "Saudi Arabia";
            ExportData = new ObservableCollection<Model>();

            this.Countries = new ObservableCollection<Country>();
            this.Countries.Add(new Country() { Name = "Bangladesh", ID = 0 });
            this.Countries.Add(new Country() { Name = "Russia", ID = 1 });
            this.Countries.Add(new Country() { Name = "Iran", ID = 2 });
            this.Countries.Add(new Country() { Name = "India", ID = 3 });
            this.Countries.Add(new Country() { Name = "Saudi Arabia", ID = 4 });
            this.Countries.Add(new Country() { Name = "Kuwait", ID = 5 });

            ReadCSV(SelectedCountry);

            PaletteBrushes = new List<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#910A67")),
                new SolidColorBrush(Color.FromArgb("#D49B54")),
                new SolidColorBrush(Color.FromArgb("#EB3678")),
                new SolidColorBrush(Color.FromArgb("#4E9F3D")),
                new SolidColorBrush(Color.FromArgb("#107ee2")),
                new SolidColorBrush(Color.FromArgb("#ef5d3d")),
                new SolidColorBrush(Color.FromArgb("#150485")),

            };

        }

        public ObservableCollection<Model> ReadCSV(string country)
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("StackedAreaChart.Resources.Raw.data.csv");

            string line;
            List<string> lines = new();

            using StreamReader reader = new(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            ExportData.Clear();
            lines.RemoveAt(0);

            foreach (var item in lines)
            {
                string[] data = item.Split(',');

                if (data[0] == country)
                {
                    double Parse(string value) => string.IsNullOrWhiteSpace(value) ? 0 : Convert.ToDouble(value);

                    var model = new Model(
                        Parse(data[2]),
                        Parse(data[3]),
                        Parse(data[4]),
                        Parse(data[5]),
                        Parse(data[6]),
                        Parse(data[7]),
                        Parse(data[8]),
                        Parse(data[9]),
                        Parse(data[3]) + Parse(data[4]) + Parse(data[5]) + Parse(data[6]) +
                        Parse(data[7]) + Parse(data[8]) + Parse(data[9])
                    );

                    ExportData.Add(model);
                }
            }

            return ExportData;
        }

    }
}


