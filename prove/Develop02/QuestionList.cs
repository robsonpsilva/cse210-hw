
using System;
using System.Collections.Generic;
using System.Globalization;

public class QuestionList
{
    public Dictionary<int,string> _questionRecords = new Dictionary<int, string>();

    public void setQuestion(string question)
    {
        int questionNumber = _questionRecords.Count;
        _questionRecords.Add(questionNumber+1, question);

    }

    public string getQuestion(int num)
    {
        return _questionRecords[num];

    }

    public void changeQuestion(int questionNumber, string question)
    {
        _questionRecords[questionNumber] = question;


    }

    public void deleteQuestion(int questionNumber)
    {
        _questionRecords.Remove(questionNumber);

    }

    public string getRandomQuestion()
    {
        Random random = new Random();
        int min = 1;
        int max = _questionRecords.Count;
        int n;

        n = random.Next(min, max);
        return _questionRecords[n];

    }

}

