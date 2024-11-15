
using System;
using System.Collections.Generic;
using System.Globalization;

public class QuestionList
{
    public Dictionary<int,string> _questionRecords = new Dictionary<int, string>();

    // Creating a constructor class to initialize the object with a list of questions for the user.
    public QuestionList()
    {
        this.setQuestion("What was the best part of my day?");
        this.setQuestion("What would you like to do?");
        this.setQuestion("WHow have you seen God's hand working in your life today?");
        this.setQuestion("What is the best, kindest thing you did today?");
        this.setQuestion("Which scripture stood out to you the most today? Why?");
        this.setQuestion("What has worried you most today? And how can you invite God to help you?");
        this.setQuestion("What fact or action helped you get closer to your family?");
        this.setQuestion("What did you do today that can increase your self-sufficiency?");
        this.setQuestion("What interesting place have you been today?");
        this.setQuestion("What happened today that helped your faith grow?");
    }
   
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

