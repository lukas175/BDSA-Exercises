
using ConsoleApp;

namespace Tests
{
    public class LeapYearTests
    {
        [Fact]
        public void IsLeapYear_2000_true()
        {
            //Assign
            var leapCalculator = new LeapYear();

            //Act
            bool isLeapyear = leapCalculator.IsLeapYear(2000);

            //Assert
            Assert.True(isLeapyear);
        }

        [Fact]
        public void IsLeapYear_2004_true()
        {
            //Assign
            var leapCalculator = new LeapYear();

            //Act
            bool isLeapyear = leapCalculator.IsLeapYear(2004);

            //Assert
            Assert.True(isLeapyear);
        }

        [Fact]
        public void IsLeapYear_2001_false()
        {
            //Assign
            var leapCalculator = new LeapYear();

            //Act
            bool isLeapyear = leapCalculator.IsLeapYear(2001);

            //Assert
            Assert.False(isLeapyear);
        }

        [Fact]
        public void IsLeapYear_1700_false()
        {
            //Assign
            var leapCalculator = new LeapYear();

            //Act
            bool isLeapyear = leapCalculator.IsLeapYear(1700);

            //Assert
            Assert.False(isLeapyear);
        }

        [Fact]
        public void IsLeapYear_1704_true()
        {
            //Assign
            var leapCalculator = new LeapYear();

            //Act
            bool isLeapyear = leapCalculator.IsLeapYear(1704);

            //Assert
            Assert.True(isLeapyear);
        }
    }
}
