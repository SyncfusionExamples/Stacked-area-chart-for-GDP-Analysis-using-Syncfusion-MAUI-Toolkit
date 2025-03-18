
namespace StackedAreaChart
{
    public class Model
    {
        public double Year { get; set; }
        public double Oceania { get; set; }
        public double EasternEurope { get; set; }
        public double Africa { get; set; }
        public double SouthAmerica { get; set; }
        public double NorthAmerica { get; set; }
        public double WesternEurope { get; set; }
        public double Asia { get; set; }
        public double Total { get; set; }

        public Model(double year, double oceania, double easternEurope, double africa, double southAmerica, double northAmerica, double westernEurope, double asia, double total)
        {
            Year = year;
            Oceania = oceania;
            EasternEurope = easternEurope;
            Africa = africa;
            SouthAmerica = southAmerica;
            NorthAmerica = northAmerica;
            WesternEurope = westernEurope;
            Asia = asia;
            Total = total;
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}
