
public class ReflectingActivity:Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private PromptGenerator _promptGenerator;
    private PromptGenerator _questionsGenarator;
    
    public ReflectingActivity(string activityName, string activityDescription, int activityDuration, List<string> prompts, List<string> questions):
    base(activityName,activityDescription,activityDuration){
        this._prompts = prompts;
        this._questions = questions;

        //The PromptGenerator class is responsible for randomly choosing messages and displaying them without repeating them, that is, a used message will not be repeated.
        this._promptGenerator = new PromptGenerator(this._prompts); //Initialize with prompts messages
        this._questionsGenarator = new PromptGenerator(this._questions); //Initialize with quenstions messages  
    }
    
    public void SetPrompt(string prompt)
    {
        this._prompts.Add(prompt); //Update the message list
        this._promptGenerator.setQuestion(prompt); //Updates the list of questions and the PromptGenerator, which is the component responsible for randomly choosing messages, and choosing without repetition.
    }
    public void SetQuestions(string question)
    {
        this._questions.Add(question);//Update the question list
        this._questionsGenarator.setQuestion(question); //Updates the list of questions and the PromptGenerator, which is the component responsible for randomly choosing messages, and choosing without repetition.

    }



    public void Run()
    {
        
        Console.Clear();
        string time = base.OpeningMessage();
        if(int.TryParse(time, out int result))
        {
            base.SetActivityDuration(result); // After receiving duration from the user we set the activity duration in class
            base.GetReady(3);

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(base.GetActivityDuration());
            DateTime currentTime = DateTime.Now;
            bool flag = true;
            while ((currentTime < futureTime) && flag)
            {
                Console.Clear();
                Console.WriteLine("Consider the following prompt:");
                Console.WriteLine("");

                var p = this._promptGenerator.getRandomQuestion();
                Console.WriteLine($" --- {p.Item2} ----");
                Console.WriteLine("");
                Console.Write("When you have something in mind, press to continue.");
                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("");
                Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                Console.WriteLine("");
                Console.Write("You may begin in: ");
                base.ShowCountDown(5);

                Console.Clear();
                var q = this._questionsGenarator.getRandomQuestion();
                Console.WriteLine(q.Item2);
                base.ShowSpinner(3);
                
                Console.WriteLine("");             
                q = this._questionsGenarator.getRandomQuestion();
                Console.WriteLine(q.Item2);
                base.ShowSpinner(3);

                currentTime = DateTime.Now;

                //If all prompts or questions have been used, end the activity.
                if ((p.Item1 == -1) || (q.Item1 == -1))
                {
                    flag = false;
                }
            }
            Console.Clear();
            base.EndingMessage(3);
        }
        else
        {
            Console.Clear();
            Console.Write("Invalid value, press any key to continue.");
            Console.ReadLine();
        }

    }
    
}