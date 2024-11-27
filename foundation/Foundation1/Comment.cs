
class Comment
{
    private string _personName;
    private string _commentText;

    public Comment (string personName, string comment)
    {
        this._commentText = comment;
        this._personName = personName;
    }

    public string getComment()
    {
        return this._commentText;
    }
    public string getPersonName()
    {
        return this._personName;
    }

    public void setComment(string comment)
    {
        this._commentText = comment;
    }

    public void setPersonName(string personName)
    {
        this._personName = personName;
    }
}