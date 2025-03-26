namespace ClassLibrary1
{
    public class MyLib
    {

        public TimeSpan Date_difference(DateTime x, DateTime y)
        {
            try
            {
                return x - y;
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                return new TimeSpan(0);
            }
        }

        public double Difference_in_days(DateTime x, DateTime y)
        {
            try
            {
                TimeSpan timeSpan = x.Subtract(y);
                double datka = timeSpan.TotalDays;
                return datka;
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                return 0.0;
            }
        }

        public double Difference_in_hours(DateTime x, DateTime y)
        {
            try
            {
                TimeSpan timeSpan = x.Subtract(y);
                double datka = timeSpan.TotalHours;
                return datka;
            }
            catch (Exception e)
            {
                Console.WriteLine("");
                return 0.0;
            }
        }

        //добавлю эту строчку, чтобы проверить актионс
        //добавлю эту строчку, чтобы проверить актионс 2
        //добавлю эту строчку, чтобы проверить актионс 3
        //добавлю эту строчку, чтобы проверить актионс 4
        //добавлю эту строчку, чтобы проверить актионс 5
        //добавлю эту строчку, чтобы проверить актионс 6
        //добавлю эту строчку, чтобы проверить актионс 7

    }
}
