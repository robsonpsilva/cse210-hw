
public class CiclingActivity:Activity
{
    private double _speed; //km per hour
    public CiclingActivity(string date, int minutes, double speed): base(date,minutes)
    {
        this._speed = speed; //km per hour
    }
    public override double GetDistance()
    {
        return this._speed * (base.GetLenghtInMinutes() / 60); //in km
    }
    public override double GetSpeed()
    {
        return this._speed;//km per hour
    }

    public override double GetPace()
    {
        return 60 / this.GetSpeed(); //min per km
    }

    public override void GetSummary(string activityType)
    {
        
        base.GetSummary("Cicling");
    }
}