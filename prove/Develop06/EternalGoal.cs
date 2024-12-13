
public class EternalGoal:Goal
{

    public EternalGoal(string name, string description, int points):base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        
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
        return $"Eternal Goal:{base.GetName()},{base.getDescription()},{base.GetTotalPoints()}";
    }
    public override int GetTotalPoints()
    {
        return base.GetTotalPoints();
    }

}