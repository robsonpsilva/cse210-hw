/*
    **************************************** - Exceeding Requirements - **************************************************************
    Meeting the requirement "Save or load your document to a database or use a different library or format such as JSON for storage."
    Exceeding requirements - The system is saving and reading from a json file.
    See the FileManage class to verify writing and reading of user Journal records to and from a json file.
    The parts where we exceed the requirements are identified as "Exceeding Requirements".
    **********************************************************************************************************************************
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        UserEntry uDisplay = new UserEntry();
        PromptGenerator quest = new PromptGenerator();
        Entry j = new Entry();
        FileManage f = new FileManage();
        PromptGenerator qlist = new PromptGenerator();

        string userDiaryRegister;
        bool runFlag = true;
        int option = 0;

        while (runFlag == true)
        {
            option = uDisplay.screenMenu();
            DateTime currentDate = DateTime.Now.Date;

            if (option == 1) 
            {
                // Option equal to 1 means that the user wants to write in the diary.

                /*
                    Call the PromptGenerator class and get the prompt that will be displayed randomly. 
                    The PromptGenerator class ensures that there will be no repetition on the same day.
                */
                var q = quest.getRandomQuestion(); 
                if (q.Item1!= -1)
                {
                    Console.WriteLine(q.Item2); // Choosing a random question for the user prompt.
                    userDiaryRegister = Console.ReadLine(); //Receiving user records for your journal
                    j.setRecord($"{currentDate.ToString("d")} - {q.Item1}", userDiaryRegister); //Writing in the Journal   
                    Console.WriteLine("Operation completed successfully!");
                }
                else
                {
                    Console.WriteLine("All question prompts have been used, no new records can be added.");
                }
                

            }
            else if (option == 2)
            {
                // Option equal to 2 means that the user wants to display his diary records on the screen.
                j.display(qlist);
            }
            else if (option == 3)
            {
                // Option 3 means that the user wants to load his diary data from a file.
                
                Console.Write("Please enter a file name that has a json extension, for example diary.json. ");
                string filePath = Console.ReadLine();

                //Reading from a file
                var r = f.loadFromFile(filePath);
                if (r.Item1)
                {
                    //Upon entering this section the system was able to read the file successfully.

                    j.setAllRecords(r.Item2); //Loading the journal data from the file into memory. In the program the Journal object is responsible for storing this data.
                    quest.setRandomNumbers(r.Item2); //To avoid repeating prompts, the PromptGenerator object keeps track of the prompts used on today's date, 
                                                    //so it is necessary to reload this object every time the journal is uploaded from the file.

                }
                
            }
            else if (option == 4)
            {
                // Option 4 means that the user wants to save his diary data to a file.
                Console.Write("Please enter a file name that has a json extension, for example diary.json. ");
                string filePath = Console.ReadLine();

                //Writing to a file
                f.saveJournalToFile(j,filePath);
            }
            else if (option == 5)
            {
                // Option 5 means the user wants to exit the program.
                runFlag = false;
            }
        
            Console.Write("Press any key to continue. ");
            Console.ReadLine();
        }
        Console.WriteLine("Closing the program, press any key to finish.");
    }
    
}