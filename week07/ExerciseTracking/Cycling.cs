using System;
public class Cycling : Activity
{
    private double speedKph;

    public Cycling(DateTime date, int durationMinutes, double speedKph)
        : base(date, durationMinutes)
    {
        this.speedKph = speedKph;
    }

    public override double GetSpeed() => speedKph;
    public override double GetDistance() => (speedKph * DurationMinutes) / 60;
    public override double GetPace() => 60 / speedKph;
}
