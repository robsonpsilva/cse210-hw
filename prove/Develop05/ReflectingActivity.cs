
public class ReflectingActivity:Activity
{
    List<string> _prompts = new List<string>();
    List<string> _questions = new List<string>();

    
    public ReflectingActivity(string activityName, string activityDescription, int activityDuration, List<string> prompts, List<string> questions):
    base(activityName,activityDescription,activityDuration){
        this._prompts = prompts;
        this._questions = questions;
        
    }
    
    public void SetPrompt(string prompt)
    {
        this._prompts.Add(prompt);
    }
    public void SetQuestions(string question)
    {
        this._questions.Add(question);
    }


    public void Run()
    {
        PromptGenerator prompts = new PromptGenerator(this._prompts); 
        PromptGenerator questions = new PromptGenerator(this._questions);
        Console.Clear();
        string time = base.OpeningMessage();
        if(int.TryParse(time, out int result))
        {
            base.SetActivityDuration(result); // After receiving duration from the user we set the activity duration in class
            Console.Clear();
            Console.WriteLine("Get ready...");
            base.ShowSpinner(5);
            Console.WriteLine("");

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(base.GetActivityDuration());
            DateTime currentTime;
            currentTime = DateTime.Now;

            while (currentTime < futureTime)
            {
                Console.Clear();
                Console.WriteLine("Consider the following prompt:");
                Console.WriteLine("");

                var p = prompts.getRandomQuestion();
                Console.WriteLine($" --- {p.Item2} ----");
                Console.WriteLine("");
                Console.Write("When you have something in mind, press to continue.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                Console.WriteLine("");
                Console.Write("You may begin in: ");
                base.ShowCountDown(3);

                Console.Clear();
                var q = questions.getRandomQuestion();
                Console.WriteLine(q.Item2);
                base.ShowSpinner(5);
                
                Console.WriteLine("");             
                q = questions.getRandomQuestion();
                Console.WriteLine(q.Item2);
                base.ShowSpinner(5);

                currentTime = DateTime.Now;
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