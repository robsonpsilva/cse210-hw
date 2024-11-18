using System;

class Fraction
{
    int _top;
    int _botton;
    
    public Fraction()
    {
        this._top = 1;
        this._botton = 1;
    } 
    public Fraction(int top)
    {
        this._top = top;
        this._botton = 1;
    }
    public Fraction(int top, int botton)
    {
        this._top = top;
        this._botton = botton;
    }

    public int getTopValue()
    {
        return this._top;
    }
    public void setTopValue(int top)
    {
        this._top = top;
    }
    public void setBottonValue(int botton)
    {
        this._botton = botton;
    }

    public int getBottonValue()
    {
        return this._botton;
    }
}