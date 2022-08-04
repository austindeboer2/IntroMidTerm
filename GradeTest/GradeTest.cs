namespace GradeTest
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
            bool passing = true;
            if (m.GradeCalculator(50) != "F") passing = false;
            if (m.GradeCalculator(59.9f) != "F") passing = false;
            if (m.GradeCalculator(60) != "D") passing = false;
            if (m.GradeCalculator(69.9f) != "D") passing = false;
            if (m.GradeCalculator(70) != "C") passing = false;
            if (m.GradeCalculator(79.9f) != "C") passing = false;
            if (m.GradeCalculator(80) != "B") passing = false;
            if (m.GradeCalculator(89.9f) != "B") passing = false;
            if (m.GradeCalculator(90) != "A") passing = false;
            if (m.GradeCalculator(99.9f) != "A") passing = false;
            if (m.GradeCalculator(100f) != "A") passing = false;
            if (passing) Assert.Pass();
            else Assert.Fail("Your GradeCalculator() method is not returning the proper letters");
        }
    }
}