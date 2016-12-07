using FluentAssertions;
using NUnit.Framework;

namespace LeapYearKata.Tests
{
    [TestFixture]
    public class LeapYearShould
    {
        private LeapYear leapYearVerifier;

        [SetUp]
        public void SetUp()
        {
            leapYearVerifier = new LeapYear();
        }

        [Test]
        public void ReturnFalse_WhenVerifyingLeapYears_Given1AsYear()
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(1);

            isLeapYear.Should().BeFalse();
        }

        [Test]
        public void ReturnTrue_WhenVerifyingLeapYears_Given4AsYear()
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(4);
            
            isLeapYear.Should().BeTrue();
        }

        [Test]
        public void ReturnTrue_WhenVerifyingLeapYears_Given40AsYear()
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(40);

            isLeapYear.Should().BeTrue();
        }
    }
}
