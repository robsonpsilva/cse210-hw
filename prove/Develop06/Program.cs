using System;

/*
   ------------------------ Exceeding the requirements ---------------------------
    I put in place a level system so that if the player reaches a certain level 
    he earns a bonus score rewarding his achievement, this on the one hand, on the 
    other hand when leveling up the next level is much more difficult and it takes 
    more effort and more goals to be achieved in order to reach the next level.
    -------------------------------------------------------------------------------
    It includes some error handling when handling files and as a separator for parameters 
    within the file, it replaces the comma with "~|~", which is a sequence of characters 
    that is less likely to appear naturally in writing.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello Develop06 World!");
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}