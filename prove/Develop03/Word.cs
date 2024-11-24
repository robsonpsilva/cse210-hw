

class Word
{
    bool displayStatus = true;
    string word;

    public Word(string word)
    {
        this.word = word;
    }

    public void hideWord()
    {
        displayStatus = false;
    }
    
    public void showWord()
    {
        displayStatus = true;
    }

    public bool isHidden()
    {
        return  !displayStatus;
    }

    public void setWord(string word)
    {
        this.word = word;
    }

    public string getWord()
    {  
       string aux = this.word; 
       if(displayStatus == false) //Checking whether to hide the word
       {    
        aux="";
            for(int i=0; i<word.Length; i++) //Replacing each character with an underline.
            {
                aux += "_";
            }
       }
       return aux;
    }
}