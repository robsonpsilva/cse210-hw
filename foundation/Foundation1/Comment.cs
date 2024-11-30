
class Comment
{
    private string _personName;
    private string _commentText;

    public Comment (string personName, string commentText)
    {
        this._commentText = commentText;
        this._personName = personName;
    }

    public string GetComment()
    {
        return this._commentText;
    }
    public string GetPersonName()
    {
        return this._personName;
    }

    public void SetComment(string commentText)
    {
        this._commentText = commentText;
    }

    public void SetPersonName(string personName)
    {
        this._personName = personName;
    }
}