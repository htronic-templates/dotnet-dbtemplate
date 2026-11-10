using System.Diagnostics;

namespace DBTemplate.Data.PgSql.Extensions;

/// <summary> Extension methods for converting a Timespan to a date and back, for database storage. </summary>
public static class TimespanExtensions {
    /// <summary> Converts a TimeSpan to a DateTime for database storage. </summary>
    /// <param name="ts"> The TimeSpan to convert. </param>
    /// <returns> The DateTime representing the same point in time. </returns>
    [DebuggerStepThrough]
    public static DateTime ToDbDate(this TimeSpan ts) {
        // Use 1900 as a fixed date for timespan starts
        var tmpdate = new DateTime(1900, 1, 1);
        tmpdate = tmpdate.Add(ts);
        return tmpdate;
    }

    /// <summary> Converts a DateTime from the database to the original TimeSpan. </summary>
    /// <param name="dt"> The DateTime to convert. </param>
    /// <returns> The TimeSpan representing the span of time. </returns>
    [DebuggerStepThrough]
    public static TimeSpan ToDbTimespan(this DateTime dt) {
        // Use 1900 as a fixed date for timespan starts
        var tmpdate = new DateTime(1900, 1, 1);
        var tmpts = dt.Subtract(tmpdate);
        return tmpts;
    }
}