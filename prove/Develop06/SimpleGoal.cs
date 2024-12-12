
public class SimpleGoal:Goal
{
   private bool _isCompleted;
   public SimpleGoal(string name, string description, int points):base(name, description, points)
    {

    }

    public override void RecordEvent()
    {
        this._isCompleted = true;
    }

    public override string getDetailsString()
    {
        string message = $"[ ] {base.getDetailsString()}";
        if (this._isCompleted)
        {
            message = $"[x] {base.getDetailsString()}";
        }
        return message;
    }
    public override string getStringRepresantation()
    {
        return $"Simple Goal:{this.getDetailsString()}, {base.GetPoints()}";
    }

    public override bool IsComplete()
    {
        return this._isCompleted;
    }
    public int GetTotalPoints()
    {
        int total = 0;
        
        if (this.IsComplete())
        {
            total = base.GetPoints();
        }

        return total;
    }

}
