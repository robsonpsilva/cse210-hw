
public class SwimmingActivity:Activity
{
    private int _laps;
    public SwimmingActivity(string date, int minutes, int laps): base(date,minutes)
    {
        this._laps = laps;
    }
    public override double GetDistance() // in kelometers
    {
        return (this._laps * 50) / 1000;
    }
    public override double GetSpeed()
    {
        return (this.GetDistance() / base.GetLenghtInMinutes()) * 60; // Speed im km per hour

    }

    public override double GetPace()
    {
        return 60 / this.GetSpeed(); // min per km
    }

    public override void GetSummary(string activityType)
    {
        base.GetSummary("Swimming");
    }


}