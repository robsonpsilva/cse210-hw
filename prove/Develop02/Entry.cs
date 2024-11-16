using System;
using System.Collections.Generic;

class Entry
{
    //The journalRecordList variable is composed of a key that will have the format date-question 
    // and its value, which is the user's answer to the question.
    public Dictionary<string,string> _journalRecordList = new Dictionary<string, string>();
   
    
    public void display(PromptGenerator qlist)
    {
        //This method takes all the Entries(Records) from the Journal and displays 
        //them on the screen separated one by one by empty lines between them.
        string[] part;
        string recordKeyData;
        string question;
        if (_journalRecordList.Count !=0)
        {
            foreach (KeyValuePair<string, string> input in _journalRecordList) 
            { 
                //The keys will be formatted as follows: data-questionNumber. 
                recordKeyData = input.Key; 
                part = recordKeyData.Split("-");
                question = qlist.getQuestion(int.Parse(part[1]));
                //Prints the records found in the Journal
                Console.WriteLine("");
                Console.WriteLine($"Date: {part[0]} - Prompt: {question}"); 
                Console.WriteLine($"{input.Value}");
                Console.WriteLine("");
            }
        }
        else
        {
            Console.WriteLine("The Journal is empty.");
        }
        
    }
    
    
    public void setRecord(string key, string value)
    {
        //The purpose of this setRecord method is to write a user Entry to the Journal.
        _journalRecordList.Add(key,value);
    }

    public void setAllRecords(string[] inp){
        /*
            The function of this method is to clear the internal storage of journal records 
            and do a batch load from the values ​​it received as input.
        */
        _journalRecordList.Clear();
        foreach(string i in inp)
        {
            string[] part = i.Split("˜|˜");
            _journalRecordList.Add(part[0], part[1]);
        }
    }




}
