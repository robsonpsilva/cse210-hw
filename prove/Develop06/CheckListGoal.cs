
using System.Numerics;

public class CheckListGoal:Goal
{
    private int _valueCompleted = 0;
    private int _target;
    private int _bonus;
    public CheckListGoal(string name, string description, int points, int valueCompleted, int target, int bonus):base(name, description, points)
    {
        this._valueCompleted = valueCompleted;
        this._target = target;
        this._bonus = bonus;
    }
    public override void RecordEvent()
    {
        if(this._valueCompleted < this._target)
        {
            this._valueCompleted++;
        }
    }

    public override bool IsComplete()
    {
        return this._target == this._valueCompleted;
    }

    public override string getDetailsString()
    {
        string message = "";
        if (!this.IsComplete())
        {
            message = $"[ ] {base.getDetailsString()} -- Currently completed: {this._valueCompleted}/{this._target}";
        }
        else
        {
            message = $"[x] {base.getDetailsString()} -- Currently completed: {this._valueCompleted}/{this._target}";
        }

        return message;
    }
    public override string getStringRepresantation()
    {
        return $"CheckList Goal:{this.getDetailsString()}, {base.GetPoints()}, {this._bonus}, {this._target}, {this._valueCompleted}";
    }
    public int GetTotalPoints()
    {
        int total = 0;
        if (this.IsComplete())
        {
            total = this._valueCompleted * base.GetPoints() + this._bonus;
        }
        else
        {
            total = this._valueCompleted * base.GetPoints();
        }
        return total;
    }
}