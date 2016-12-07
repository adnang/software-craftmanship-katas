using FluentAssertions;
using NUnit.Framework;

namespace LeapYearKata.Tests
{
    [TestFixture]
    public class LeapYearShould
    {
        [Test]
        public void ReturnFalse_WhenVerifyingLeapYears_Given1AsLeapYear()
        {
            var leapYearVerifier = new LeapYear();

            var isLeapYear = leapYearVerifier.IsLeapYear(1);

            isLeapYear.Should().BeFalse();
        }

        [Test]
        public void ReturnTrue_WhenVerifyingLeapYears_Given4AsLeapYear()
        {
            var leapYearVerifier = new LeapYear();

            var isLeapYear = leapYearVerifier.IsLeapYear(4);
            
            isLeapYear.Should().BeTrue();
        }
    }
}
