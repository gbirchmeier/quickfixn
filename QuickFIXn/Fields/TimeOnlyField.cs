using System;
using QuickFix.Fields.Converters;

namespace QuickFix.Fields;

/// <summary>
/// A FIX field backed by a TimeOnly.  Be aware that this value does not include a time zone.
/// </summary>
public class TimeOnlyField : FieldBase<TimeOnly>
{
    public readonly TimeStampPrecision TimePrecision = TimeStampPrecision.Millisecond;

    /// <summary>
    /// Create a TimeOnlyField set to 00:00:00, i.e. midnight.  Displayed precision will be milliseconds.
    /// </summary>
    /// <param name="tag"></param>
    public TimeOnlyField(int tag)
        : base(tag, new TimeOnly()) { }

    /// <summary>
    /// Create a TimeOnlyField set to the parameter.  Displayed precision will be milliseconds.
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="timeOnly"></param>
    public TimeOnlyField(int tag, TimeOnly timeOnly)
        : base(tag, timeOnly) { }

    /// <summary>
    /// Create a TimeOnlyField with value and displayed precision according to the parameters.
    /// </summary>
    /// <param name="tag"></param>
    /// <param name="timeOnly"></param>
    /// <param name="timeFormatPrecision"></param>
    public TimeOnlyField(int tag, TimeOnly timeOnly, TimeStampPrecision timeFormatPrecision)
        : base(tag, timeOnly)
    {
        TimePrecision = timeFormatPrecision;
    }

    protected override string MakeString()
    {
        return TimeOnlyConverter.Convert(Value, TimePrecision);
    }


    [Obsolete("This ctor will be removed in 1.16.  You should use the TimeOnly-based constructors.")]
    public TimeOnlyField(int tag, DateTime dt)
        : base(tag, TimeOnly.FromDateTime(dt)) { }

    [Obsolete("This ctor will be removed in 1.16.  You should use the TimeOnly-based constructors.")]
    public TimeOnlyField(int tag, DateTime dt, bool showMilliseconds)
        : this(tag, TimeOnly.FromDateTime(dt),
            showMilliseconds ? TimeStampPrecision.Millisecond : TimeStampPrecision.Second) { }

    [Obsolete("This ctor will be removed in 1.16.  You should use the TimeOnly-based constructors.")]
    public TimeOnlyField(int tag, DateTime dt, TimeStampPrecision timeFormatPrecision)
        : this(tag, TimeOnly.FromDateTime(dt), timeFormatPrecision) { }
}
