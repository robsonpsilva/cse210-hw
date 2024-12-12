
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
        return $"[] {base.getDetailsString()}";
    }

    public override string getStringRepresantation()
    {
        return $"Eternal Goal:{this.getDetailsString()}, {base.GetPoints()}";
    }

}