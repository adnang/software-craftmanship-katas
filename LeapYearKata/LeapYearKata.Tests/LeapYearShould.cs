﻿using FluentAssertions;
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
        [TestCase(2001)]
        public void ReturnFalse_WhenVerifyingLeapYears_GivenNotMultiplesOf4AsYear(int year)
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(year);

            isLeapYear.Should().BeFalse();
        }

        [TestCase(4)]
        [TestCase(40)]
        [TestCase(160)]
        [TestCase(1996)]
        public void ReturnTrue_WhenVerifyingLeapYears_GivenAMultipleOf4AsYear(int year)
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(year);

            isLeapYear.Should().BeTrue();
        }

        [TestCase(100)]
        [TestCase(200)]
        [TestCase(1100)]
        [TestCase(1900)]
        public void ReturnFalse_WhenVerifyingLeapYears_GivenMultipleOf100ButNot400(int year)
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(year);

            isLeapYear.Should().BeFalse();
        }

        [TestCase(400)]
        [TestCase(800)]
        [TestCase(1600)]
        [TestCase(2000)]
        public void ReturnTrue_WhenVerifyingLeapYears_GivenMultipleOf400(int year)
        {
            var isLeapYear = leapYearVerifier.IsLeapYear(year);

            isLeapYear.Should().BeTrue();
        }
    }
}