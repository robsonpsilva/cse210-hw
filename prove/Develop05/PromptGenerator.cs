
using System;
using System.Collections.Generic;
using System.Globalization;

public class PromptGenerator
{
    // The responsibility of this class is to maintain and randomly make questions available to the user.
    public Dictionary<int,string> _prompts = new Dictionary<int, string>();
    List<int> randomNumbers = new List<int>(); 
    

    // Creating a constructor class to initialize the object with a list of questions for the user.
    public PromptGenerator(List<string> questionsOrPrompts)
    {
        // Initializing the list of questions with data, questions, that will be used in the program, later this load can be done from a file or database.
        foreach( string q in questionsOrPrompts)
        {
            this.setQuestion(q);
        } 
    }
   
    public void setQuestion(string question)
    {
        int questionNumber = _prompts.Count;
        _prompts.Add(questionNumber+1, question);

    }

    public string getQuestion(int num)
    {
        return _prompts[num];

    }

    public void changeQuestion(int questionNumber, string question)
    {
        _prompts[questionNumber] = question;


    }

    public void deleteQuestion(int questionNumber)
    {
        _prompts.Remove(questionNumber);

    }

    public (int,string) getRandomQuestion()
    {
        //The purpose of this method is to generate a prompt randomly, avoiding repetitions, 
        //if a prompt has already been used, it will not be repeated.

        Random random = new Random();
        int min = 1;
        int max = _prompts.Count;
        int n = -1;
        int count = 1;
        
        n = random.Next(min, max+1);
        //The following code aims to avoid repetition of questions
        while (randomNumbers.Contains(n) && count <= (2*max))
        {
            n = random.Next(min, max);
            count++;
        }
        if (count >= (2*max)) //If the count variable is equal to the total number of questions, it means that all questions have been used, we are already repeating ourselves.
        {
            n=-1; 
            return (n, "");
        }
        else
        {
            randomNumbers.Add(n);
            return (n, _prompts[n]);
        }
        
    }

    public void setRandomNumbers(string[] inp)
    {
        foreach (string i in inp)
        {
            string[] temp = i.Split("˜|˜");
            string[] temp2 = temp[0].Split("-");
            randomNumbers.Add(int.Parse(temp2[1]));
        }

    }
}
