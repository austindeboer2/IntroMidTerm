namespace RandomNumberTest
{
    public class Tests
    {
        MidTerm m;
        Random r;
        [SetUp]
        public void Setup()
        {
            m = new MidTerm();
            r = new Random();
        }

        [Test]
        public void Test1()
        {
            int tens = 0;
            for(int i = 0; i < 10000; i++)
            {
                if (m.GenerateRandomNumber() == 10) tens++;
            }
            if (tens > 900 && tens < 1100) Assert.Pass();
            else Assert.Fail("Your GenerateRandomNumber() method is not returning the proper random numbers");
        }
    }
}