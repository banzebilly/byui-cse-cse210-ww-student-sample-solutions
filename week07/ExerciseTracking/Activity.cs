
using System;
using System.Globalization;

public abstract class Activity
{
    
    private DateTime _date;
    private int _minutes;

    
    public DateTime Date
    {
        get { return _date; }
    }

    public int Minutes
    {
        get { return _minutes; }
    }

   
    protected Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

  
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

  
    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture)} " +
               $"{GetType().Name} ({Minutes} min): " +
               $"Distance: {GetDistance():F1} km, " +
               $"Speed: {GetSpeed():F1} kph, " +
               $"Pace: {GetPace():F1} min per km";
    }
}
