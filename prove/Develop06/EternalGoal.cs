
public class EternalGoal:Goal
{
    int _innerTotalPoints = 0;
    public EternalGoal(string name, string description, int points):base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        this._innerTotalPoints += base.GetTotalPoints();
    }

    public override bool IsComplete()
    {
        return false;
    }
    public override string getDetailsString()
    {
        return $"[ ] {base.getDetailsString()}";
    }

    public override string getStringRepresentation()
    {
        return $"EternalGoal:{base.GetName()}~|~{base.getDescription()}~|~{this._innerTotalPoints}";
    }
    public override int GetTotalPoints()
    {
        return this._innerTotalPoints;
    }

}