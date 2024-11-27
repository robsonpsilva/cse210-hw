
class Comment
{
    private string _personName;
    private string _commentText;

    public Comment (string personName, string commentText)
    {
        this._commentText = commentText;
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

    public void setComment(string commentText)
    {
        this._commentText = commentText;
    }

    public void setPersonName(string personName)
    {
        this._personName = personName;
    }
}