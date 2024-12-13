
using System.Runtime.CompilerServices;

public abstract class Goal{
    private int _goalAccomplishedPoints = 0;
    private string _name;
    private string _description;
    public Goal(string name, string description, int goalAccomplishedPoints)
    {
        this._name = name;
        this._description = description;
        this._goalAccomplishedPoints = goalAccomplishedPoints;
        
    }

    public virtual int GetTotalPoints()
    {
        return this._goalAccomplishedPoints;
    }
    
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string getStringRepresantation();
    public virtual string getDetailsString()
    {
        
        return $"{this._name} ({this._description})";
    }
}