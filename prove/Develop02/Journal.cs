using System;
using System.Collections.Generic;

class Journal
{
    //The journalRecordList variable is composed of a key that will have the format date-question 
    // and its value, which is the user's answer to the question.
    public Dictionary<string,string> _journalRecordList = new Dictionary<string, string>();
    
    public void getRecordList()
    {
        string[] part;
        string recordKeyData;

        foreach (KeyValuePair<string, string> input in _journalRecordList) 
        { 
            //The keys will be formatted as follows: data-questionNumber. 
            recordKeyData = input.Key; 
            part = recordKeyData.Split("-");


            Console.WriteLine($"Date: {part[0]} - {input.Value} anos"); 
        
        
        }
    }


}

gASH0945 00