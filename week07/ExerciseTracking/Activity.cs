using System;
public abstract class Activity
{
    private DateTime date;
    private int durationMinutes;

    public Activity(DateTime date, int durationMinutes)
    {
        this.date = date;
        this.durationMinutes = durationMinutes;
    }

    public DateTime Date => date;
    public int DurationMinutes => durationMinutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({durationMinutes} min): Distance {GetDistance():F1} km, Speed: {GetSpeed():F1} km/h, Pace: {GetPace():F2} min per km";
    }
} 