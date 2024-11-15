
using System;
using System.Collections.Generic;

public class QuestionList
{
    public Dictionary<int,string> _questionRecords = new Dictionary<int, string>();

    public void setQuestion(string question)
    {
        int questionNumber = _questionRecords.Count;
        _questionRecords.Add(questionNumber+1, question);

    }


}

