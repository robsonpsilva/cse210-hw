
using System.Runtime.CompilerServices;

class Video
{
    private string _title;
    private string _author;
    private int _lenght;
    private List<Comment> _comments = new List<Comment>(); 
    public Video( string title, string author, int lenght, Comment comment)
    {
        this._title = title;
        this._author = author;
        this._lenght = lenght;
        this._comments.Add(comment);
    }

    public void SetTitle(string title)
    {
       this._title = title; 
    }
    public void SetAuthor(string author)
    {
        this._author = author;
    }
    public void SetLenght(int lenght)
   {
     this._lenght = lenght;
   }
   public void SetComments(Comment comment)
   {
        this._comments.Add(comment);
   }
   public string GetTitle()
   {
        return this._title;
   }
   public string GetAuthor()
   {
        return this._author;
   }
   public int GetLenght()
   {
        return this._lenght;
   }
   public List<Comment> GetComments()
   {
        return this._comments;
   }
   public int GetNumberOfComments()
   {
        return this._comments.Count();
   }
}