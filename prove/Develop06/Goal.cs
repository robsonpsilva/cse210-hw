
using System.Runtime.CompilerServices;

public class Goal{
    private int _goalAccomplishedPoints = 0;
    private string _name;
    private string _description;
    private int amountOfPoints = 0;
    public Goal(string name, string description, int goalAccomplishedPoints)
    {
        this._name = name;
        this._description = description;
        this._goalAccomplishedPoints = goalAccomplishedPoints;
        
    }
}