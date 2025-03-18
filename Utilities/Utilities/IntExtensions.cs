namespace Utilities;

public static class IntExtensions
{
    public static string ToOrdinal(this int num)
    {
        switch (num % 100)
        {
            case 11:
                return $"{num}th";
            case 12:
                return $"{num}th";
            case 13:
                return $"{num}th";
            default:
                break;
        }


        switch (num % 10)
        {
            case 1:
                return $"{num}st";
            case 2:
                return $"{num}nd";
            case 3:
                return $"{num}rd";
            default:
                return $"{num}th";
        } 
    }

    public static bool IsPrime(this int num)
    {
        for (int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}