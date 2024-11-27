
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

    public void setTitle(string title)
    {
       this._title = title; 
    }
    public void setAuthor(string author)
    {
        this._author = author;
    }
    public void setLenght(int lenght)
   {
     this._lenght = lenght;
   }
   public void setComments(Comment comment)
   {
        this._comments.Add(comment);
   }
   public string getTitle()
   {
        return this._title;
   }
   public string getAuthor()
   {
        return this._author;
   }
   public int getLenght()
   {
        return this._lenght;
   }
   public List<Comment> GetComments()
   {
        return this._comments;
   }
   public int getNumberOfComments()
   {
        return this._comments.Count();
   }
}