using System;
using System.IO;

class FileManage
{
    
    public bool saveJournalToFile(Journal entry, string  filePath)
    {
        // Dados para serem salvos no arquivo CSV
        string[] linhas = new string[]
        {
            "Nome,Idade,Cidade",
            "Alice,30,São Paulo",
            "Bob,25,Rio de Janeiro",
            "Charlie,35,Belo Horizonte"
        };

        string recordKeyData;
        string userJournalRegister;
        string[] lines;
        List<string> lTemp = new List<string>();

        foreach (KeyValuePair<string, string> input in entry._journalRecordList) 
        { 
            //The keys will be formatted as follows: data-questionNumber. 
            
            //Each line in the file will have two parts, the registry key and then its value, separated by the character set "˜|~".

            recordKeyData = input.Key; //Getting the Registry Key
            userJournalRegister = input.Value; //Getting the value, the data, from the record
            lTemp.Add(recordKeyData + "˜|˜" + userJournalRegister);
        
        }
         lines = lTemp.ToArray();

        // Escrevendo os dados no arquivo CSV
        
        try{
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Data saved successfully in " + filePath);
            return true; //Meaning success
        }
        catch (UnauthorizedAccessException e) 
        { 
            Console.WriteLine("Error: Access denied. " + e.Message); 
        } 
        catch (IOException e) 
        {   
            Console.WriteLine("I/O Error: " + e.Message); 
        } 
        catch (Exception e) 
        { 
            Console.WriteLine("An unexpected error occurred: " + e.Message); 
        }
        return false;
        
    }
}
