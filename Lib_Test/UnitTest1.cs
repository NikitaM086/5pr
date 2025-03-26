using ClassLibrary1;

namespace Lib_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Date_difference_Test()
        {
            MyLib myLib = new MyLib();
            TimeSpan c = myLib.Date_difference(new DateTime(2025, 8, 1, 0, 0, 1), new DateTime(2009, 8, 1, 0, 0, 0));
            TimeSpan c2 = new DateTime(2025, 8, 1, 0, 0, 1) - new DateTime(2009, 8, 1, 0, 0, 0);

            Assert.AreEqual(c, c2);

        }

        [Test]
        public void Difference_in_days_Test()
        {
            MyLib myLib = new MyLib();

            double c = myLib.Difference_in_days(new DateTime(2025, 8, 1, 0, 0, 1), new DateTime(2009, 8, 1, 0, 0, 0));
            TimeSpan c2 = new DateTime(2025, 8, 1, 0, 0, 1) - new DateTime(2009, 8, 1, 0, 0, 0);
            double c3 = c2.TotalDays;

            Assert.AreEqual(c, c3);
        }

        [Test]
        public void Difference_in_hours_Test()
        {
            MyLib myLib = new MyLib();

            double c = myLib.Difference_in_hours(new DateTime(2025, 8, 1, 0, 0, 1), new DateTime(2009, 8, 1, 0, 0, 0));
            TimeSpan c2 = new DateTime(2025, 8, 1, 0, 0, 1) - new DateTime(2009, 8, 1, 0, 0, 0);
            double c3 = c2.TotalHours;

            Assert.AreEqual(c, c3);
        }

    }
}