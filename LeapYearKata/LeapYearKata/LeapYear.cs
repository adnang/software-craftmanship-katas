namespace LeapYearKata
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (IsMultipleOf4(year))
            {
                return true;
            }

            return false;
        }

        private static bool IsMultipleOf4(int year)
        {
            return year % 4 == 0;
        }
    }
}