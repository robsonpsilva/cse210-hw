using System;
class Reference
{
    string book; //This attribute stores the scripture reference book, for example Matthew and I Nephi.
    int chapter; //Scriptures references include not only the book but also the chapter in which 
                    //they   are found. This attribute stores this information.

    int startVerse;
    int endVerse;

    /*
        The following variable stores these verses.
        References are composed of one or more verses. A verse is, in fact, a set of words.
    */
    Dictionary<int,List<Word>> verses = new Dictionary<int, List<Word>>();

    public Reference(string book, int chapter)
    {
        this.book = book;
        this.chapter = chapter;
    }
    
    public Reference(string book, int chapter, int start, int end)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = start;
        this.endVerse = end; 
    }

    public void setVerse(int verseNumber, string verseText)
    {
        string[] w = verseText.Split(" "); //Dividing the verse into its words so you can save them in a word list and manipulate them individually.
        List<Word> verse = new List<Word>();

        foreach (string word in w){
            Word w1 = new Word(word); // Creating the Word object that will hold the words of the verse.
            verse.Add(w1); //Adding the words one by one to the verses, which will allow them to be hidden individually afterwards.
        }
    }
}