
public class ListingActivity:Activity
{
    private PromptGenerator _promptGenerator;
    private List<string> _prompts;
    public ListingActivity(string activityName, string activityDescription, int activityDuration, List<string> prompts):base(activityName,activityDescription,activityDuration)
    {
        this._prompts = prompts;
        //The PromptGenerator class is responsible for randomly choosing messages and displaying them without repeating them, that is, a used message will not be repeated.
        this._promptGenerator = new PromptGenerator(this._prompts); //Initialize with prompts messages
    }

    public void Run()
    {
        Console.Clear();
        string time = base.OpeningMessage();
        if(int.TryParse(time, out int result))
        {
            base.SetActivityDuration(result); // After receiving duration from the user we set the activity duration in class
            Console.Clear();
            Console.WriteLine("Get ready...");
            base.ShowSpinner(5);
            Console.WriteLine("");
            
            Console.Clear();
            Console.WriteLine("List as many responses you can to the following prompt:");
            var q = this._promptGenerator.getRandomQuestion();
            Console.WriteLine(q.Item2);
            Console.Write("You may begin in: ");
            base.ShowCountDown(5);
            Console.WriteLine("");

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(base.GetActivityDuration());
            DateTime currentTime;
            currentTime = DateTime.Now;
            bool flag = true;
            while ((currentTime < futureTime) && flag)
            {
                Console.Write(">");
                Console.ReadLine();
                currentTime = DateTime.Now;

                //If all prompts or questions have been used, end the activity.
                if (q.Item1 == -1)
                {
                    flag = false;
                }
                
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Well done!!");
            Console.WriteLine("");
            base.ShowSpinner(5);
            base.EndingMessage();
            base.ShowSpinner(5);

        }
        else
        {
            Console.Clear();
            Console.Write("Invalid value, press any key to continue.");
            Console.ReadLine();
        }
    }
}