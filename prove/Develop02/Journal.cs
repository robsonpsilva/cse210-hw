using System;
using System.Collections.Generic;

class Journal
{
    //The journalRecordList variable is composed of a key that will have the format date-question 
    // and its value, which is the user's answer to the question.
    public Dictionary<string,string> _journalRecordList = new Dictionary<string, string>();
    private QuestionList qlist = new QuestionList();
    
    public void getRecordList()
    {
        string[] part;
        string recordKeyData;
        string question;

        foreach (KeyValuePair<string, string> input in _journalRecordList) 
        { 
            //The keys will be formatted as follows: data-questionNumber. 
            recordKeyData = input.Key; 
            part = recordKeyData.Split("-");
            question = qlist.getQuestion(int.Parse(part[1]));

            Console.WriteLine($"Date: {part[0]} - Prompt: {question}"); 
            Console.WriteLine($"{input.Value}");
        
        }
    }


}

// gASH0945 00