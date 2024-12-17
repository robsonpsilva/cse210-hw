
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
    public List<string> LoadFromFile(string fileName)
    {
        List<string> l = new List<string>();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            l.Add(line);
        }
        return l;
    }
}