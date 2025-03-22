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
        public void Summa_Test()
        {
            MyLib myLib = new MyLib();

            int x = 5; 
            int y = 10;

            int c = myLib.Summa(x, y);
            int c2 = x + y;

            Assert.AreEqual(c, c2);
        }

        [Test]
        public void Proizvedenie_Test()
        {
            MyLib myLib = new MyLib();

            int x = 5;
            int y = 10;

            int c = myLib.Proizvedenie(x, y);
            int c2 = x * y;

            Assert.AreEqual(c, c2);
        }

    }
}