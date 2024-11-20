using System;
class Reference
{
    string book; //This attribute stores the scripture reference book, for example Matthew and I Nephi.
    int chapter; //Scriptures references include not only the book but also the chapter in which 
                    //they   are found. This attribute stores this information.

    int startVerse;
    int endVerse;

    bool fullHidden = false;

    /*
        The following variable stores these verses.
        References are composed of one or more verses. A verse is, in fact, a set of words.
    */
    Dictionary<int,List<Word>> verses = new Dictionary<int, List<Word>>();
    Random random = new Random();
    Random random1 = new Random();

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
                verses.Add(verseNumber,verse);
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
            List<Word> w = verses[i];
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
        int[] verseTrack = new int[endVerse-startVerse];
        bool flag = false;
        
        while (verseTrack.Length <= (endVerse-startVerse) && flag ==  false)
        {
            int verse = random.Next(startVerse, endVerse);
            bool exist = Array.Exists(verseTrack, element => element == verse);
            int wordNumber = 0;

            if (exist != true)
            {
                verseTrack.Append(verse);
                List<Word> w = verses[verse];
                wordNumber = random1.Next(0,w.Count()-1);
                int count = 0;
                while (w[wordNumber].isHidden() == true && count <500)
                {
                    wordNumber = random1.Next(0,w.Count()-1);
                }
                if(count == 500)
                {
                    if (verseTrack.Length == (endVerse-startVerse))//It means that all verses have been scanned and there are no more unhidden words in them.
                    {
                        fullHidden = true;
                    }
                    else
                    {
                        fullHidden = false;
                    } 
                } 
                else
                {
                    w[wordNumber].hideWord();
                }

            } 
        }   
    }

    public bool isFullHidden()
    {
        return fullHidden;
    }
}