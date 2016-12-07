using FluentAssertions;
using NUnit.Framework;

namespace LeapYearKata.Tests
{
    [TestFixture]
    public class LeapYearShould
    {
        [TestCase]
        public void ReturnFalse_WhenVerifyingLeapYears_Given1AsLeapYear()
        {
            var leapYearVerifier = new LeapYear();

            var isLeapYear = leapYearVerifier.IsLeapYear(1);

            isLeapYear.Should().BeFalse();
        }
    }
}
