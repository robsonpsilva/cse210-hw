
public class WritingAssignment : Assignment 
{
    string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        this._title = title;
    }

    public string GetWritingAssignment()
    {
        
        return $"{base.getSummary()}{Environment.NewLine}{this._title} by {base.getStudentName()}";
    }
}