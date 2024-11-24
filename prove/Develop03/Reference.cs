using System;
class Reference
{
    private string _book; //This attribute stores the scripture reference book, for example Matthew and I Nephi.
    private int _chapter; //Scriptures references include not only the book but also the chapter in which they are found. 
                  //This attribute stores this information.

    private int _startVerse; //Store the starting verse number.
    private int _endVerse; //Store the ending verse number.

    private bool _fullHidden = false; //Signals whether the reference has been fully read.

    /*
        The following variable stores these verses.
        References are composed of one or more verses. 
        A verse is, in fact, a set of words.
    */
    private Dictionary<int,List<Word>> _verses = new Dictionary<int, List<Word>>();
    private Random _random = new Random();
    private Random _random1 = new Random();

    public Reference(string book, int chapter, int start)
    {
        //This constructor initializes the class with the book and chapter of the referenced scripture.

        this._book = book;
        this._chapter = chapter;
        this._startVerse = start;
        this._endVerse = start;
    }
    
    public Reference(string book, int chapter, int start, int end)
    {
        /*
            This constructor initializes the class with the book, chapter, 
            Start Verse and End Verse of the referenced scripture.
        */
        this._book = book;
        this._chapter = chapter;
        this._startVerse = start;
        this._endVerse = end; 
    }

    public bool setVerse(int verseNumber, string verseText)
    {
        if (verseNumber>= _startVerse && verseNumber <= _endVerse){
            if (verseText !=""){ //It only makes sense to create a verse if there is text in it.
                string[] w = verseText.Split(" "); //Dividing the verse into its words so you can save them in a word list and manipulate them individually.
                List<Word> verse = new List<Word>();

                foreach (string word in w)
                {
                    Word w1 = new Word(word); // Creating the Word object that will hold the words of the verse.
                    verse.Add(w1); //Adding the words one by one to the verses, which will allow them to be hidden individually afterwards.
                }
                _verses.Add(verseNumber,verse);
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
        string aux = "";
        if (_startVerse == _endVerse)
        {
            output = $"{this._book} {this._chapter}:{this._startVerse} ";
        }
        else
        {
            output = $"{this._book} {this._chapter}:{this._startVerse}-{this._endVerse} ";
        }
        
        for (int i = this._startVerse; i<= this._endVerse; i++)
        {
            List<Word> w = _verses[i];
            foreach (Word wtemp in w)
            {
                aux += $" {wtemp.getWord()}";
            }  
        }

        output += aux; 

        return output.Trim();
    }

    public void hideWord()
    {   
        List<int> verseTrack = new List<int>();
        bool flag = false;
        
        while (verseTrack.Count() <= ((_endVerse-_startVerse)+1) && flag ==  false)
        {
            int verse = _random .Next(_startVerse, _endVerse+1);
            bool exist = verseTrack.Contains(verse);
            int wordNumber = 0;

            if (exist != true)
            {
                verseTrack.Add(verse);
                List<Word> w = _verses[verse];
                wordNumber = _random1.Next(0,w.Count());
                int count = 0;
                while (w[wordNumber].isHidden() == true && count <500)
                {
                    wordNumber = _random1.Next(0,w.Count());
                    count++;
                }
                if(count == 500)
                {
                    if (verseTrack.Count() == ((_endVerse-_startVerse)+1))//It means that all verses have been scanned and there are no more unhidden words in them.
                    {
                        _fullHidden = true;
                        flag = true;
                    }
                    else
                    {
                        _fullHidden = false;
                    } 
                } 
                else
                {
                    w[wordNumber].hideWord();
                    flag = true;
                }

            } 
        }   
    }

    public bool isFullHidden()
    {
        return _fullHidden;
    }
}