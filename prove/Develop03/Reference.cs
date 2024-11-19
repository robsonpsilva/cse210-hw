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

    public bool setVerse(int verseNumber, string verseText)
    {
        if (verseNumber>= startVerse && verseNumber <= endVerse){
            if (verseText !=""){ //It only makes sense to create a verse if there is text in it.
                string[] w = verseText.Split(" "); //Dividing the verse into its words so you can save them in a word list and manipulate them individually.
                List<Word> verse = new List<Word>();

                foreach (string word in w)
                {
                    Word w1 = new Word(word); // Creating the Word object that will hold the words of the verse.
                    verse.Add(w1); //Adding the words one by one to the verses, which will allow them to be hidden individually afterwards.
                }

                return true;
            }
            else{
                return false; //It only makes sense to create a verse if there is text in it.
            }
        }
        else
        {
            /*
                To ensure consistency, you need to make sure that the verse number 
                is between the numbers of the initial and final verses.
            */
            return false; 
        }   
    }

    public string getHiddenReferenceString()
    {
        string output;
        if (startVerse == endVerse)
        {
            output = $"{this.book} {this.chapter}:{this.startVerse} ";
        }
        else
        {
            output = $"{this.book} {this.chapter}:{this.startVerse}-{this.endVerse} ";
        }
        
        for (int i = this.startVerse; i<= this.endVerse; i++)
        {
            output += $"{verses[i]} "; 
        }

        return output.Trim();
    }

}