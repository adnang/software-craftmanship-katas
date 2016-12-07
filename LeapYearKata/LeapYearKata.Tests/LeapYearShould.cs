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
        
        [TestCase(1)]
        [TestCase(9)]
        [TestCase(10)]
        public void ReturnFalse_WhenVerifyingLeapYears_GivenNotMultiplesOf4AsYear(int year)
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(year);

            isLeapYear.Should().BeFalse();
        }

        [TestCase(4)]
        [TestCase(40)]
        [TestCase(160)]
        public void ReturnTrue_WhenVerifyingLeapYears_GivenAMultipleOf4AsYear(int year)
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(year);

            isLeapYear.Should().BeTrue();
        }
    }
}
