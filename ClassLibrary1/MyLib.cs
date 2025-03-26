namespace ClassLibrary1
{
    public class MyLib
    {

        public TimeSpan Date_difference(DateTime x, DateTime y)
        {

            return x - y;
        }

        public double Difference_in_days(DateTime x, DateTime y)
        {
            TimeSpan timeSpan = x.Subtract(y);
            double datka = timeSpan.TotalDays;
            return datka; 
        }

        public double Difference_in_hours(DateTime x, DateTime y)
        {
            TimeSpan timeSpan = x.Subtract(y);
            double datka = timeSpan.TotalHours;
            return datka;
        }

    }
}
