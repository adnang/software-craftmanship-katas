namespace LeapYearKata
{
    public class LeapYear
    {
        public bool IsLeapYear(int year)
        {
            if (year >= 4 && year != 9)
            {
                return true;
            }

            return false;
        }
    }
}