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
        public void ReturnFalse_WhenVerifyingLeapYears_Given9AsYear()
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(9);

            isLeapYear.Should().BeFalse();
        }

        [TestCase(4)]
        [TestCase(40)]
        public void ReturnTrue_WhenVerifyingLeapYears_GivenAMultipleOf4AsYear(int year)
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(year);

            isLeapYear.Should().BeTrue();
        }
    }
}
