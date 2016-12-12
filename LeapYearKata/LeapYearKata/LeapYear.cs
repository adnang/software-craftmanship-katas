namespace LeapYearKata
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (IsMultipleOf100(year))
            {
                return false;
            }

            if (IsMultipleOf4(year))
            {
                return true;
            }

            return false;
        }

        private static bool IsMultipleOf100(int year)
        {
            return year % 100 == 0;
        }

        private static bool IsMultipleOf4(int year)
        {
            return year % 4 == 0;
        }
    }
}