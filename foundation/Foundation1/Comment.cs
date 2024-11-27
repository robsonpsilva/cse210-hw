
class Comment
{
    private string _personName;
    private string _comment;

    public Comment (string personName, string comment)
    {
        this._comment = comment;
        this._personName = personName;
    }

    public string getComment()
    {
        return this._comment;
    }
    public string getPersonName()
    {
        return this._personName;
    }

    public void setComment(string comment)
    {
        this._comment = comment;
    }

    public void setPersonName(string personName)
    {
        this._personName = personName;
    }
}