
using System;
using System.IO;

public class FileManager
{
    public void SaveToFile(string fileName, List<Goal> goals, int score)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"{score}");
            foreach(Goal g in goals)
            {
                outputFile.WriteLine(g.getStringRepresentation());
            }   
        }
    }
}