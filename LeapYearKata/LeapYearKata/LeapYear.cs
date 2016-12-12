namespace LeapYearKata
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            return IsMultipleOf4(year) 
                && EitherMultipleOf400OrNot100(year);
        }

        private static bool EitherMultipleOf400OrNot100(int year)
        {
            return IsMultipleOf400(year) || !IsMultipleOf100(year);
        }

        private static bool IsMultipleOf400(int year)
        {
            return year % 400 == 0;
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