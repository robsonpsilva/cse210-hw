

class Word
{
    bool _displayStatus = true;
    string _word;

    public Word(string word)
    {
        this._word = word;
    }

    public void hideWord()
    {
        _displayStatus = false;
    }
    
    public void showWord()
    {
        _displayStatus = true;
    }

    public bool isHidden()
    {
        return  !_displayStatus;
    }

    public void setWord(string word)
    {
        this._word = word;
    }

    public string getWord()
    {  
       string aux = this._word; 
       if(_displayStatus == false) //Checking whether to hide the word
       {    
        aux="";
            for(int i=0; i<_word.Length; i++) //Replacing each character with an underline.
            {
                aux += "_";
            }
       }
       return aux;
    }
}