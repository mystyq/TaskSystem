public static class DateTimeExtensions
{
    public static bool IsEmpty(this DateTime? dateTime)
    {
        return dateTime == default;
    }

    public static bool IsEmpty(this DateTime dateTime)
    {
        return dateTime == default;
    }
}