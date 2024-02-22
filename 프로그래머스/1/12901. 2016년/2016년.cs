using System;

public class Solution {
    private string GetDay(DateTime dt)
    {
        string strDay = "";
        switch (dt.DayOfWeek)
        {
            case DayOfWeek.Monday:
                strDay = "MON";
                break;
            case DayOfWeek.Tuesday:
                strDay = "TUE";
                break;
            case DayOfWeek.Wednesday:
                strDay = "WED";
                break;
            case DayOfWeek.Thursday:
                strDay = "THU";
                break;
            case DayOfWeek.Friday:
                strDay = "FRI";
                break;
            case DayOfWeek.Saturday:
                strDay = "SAT";
                break;
            case DayOfWeek.Sunday:
                strDay = "SUN";
                break;
        }
        return strDay;
    }
    public string solution(int a, int b) {
        DateTime date = DateTime.Parse("2016-" + a + "-" + b);
            return GetDay(date);
    }
}