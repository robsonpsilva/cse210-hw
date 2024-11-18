

public class Word
{
    bool displayStatus = true;
    string word;

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
        return displayStatus;
    }

    public void setWord(string word)
    {
        this.word = word;
    }

    public string getWord()
    {
        return this.word;
    }
}