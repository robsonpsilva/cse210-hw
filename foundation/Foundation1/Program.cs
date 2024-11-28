using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        //Creating a comment and inserting it into a video.

        List<Video> videos = new List<Video>();

        Comment comment = new Comment("zunisheik3357", "Wow those lions were so close...I really loved this 360 view..");
        Video v1 = new Video("Lions 360° | National Geographic","National Geographic", 270, comment);
       
        //Inserting a second comment into the video.
        comment = new Comment("berkeduzova", "WONDERFUL VİDEO. THANKS NATIONAL GEOPHRATICS.");
        v1.setComments(comment);

        //Inserting a third comment into the video.
        comment = new Comment("fatbardh94", "Perfect guys, what a wonderful job God made it happen.");
        v1.setComments(comment);

        //Putting the video in the list
        videos.Add(v1);

        //Creating a second video with your comments.
        Video v2 = new Video("Volcanoes 101 | National Geographic", "National Geographic", 298, 
        new Comment("@ryanrock02", "Let's pray Taal eruption doesn't get worse"));

        //Adding a second comment
        v2.setComments(new Comment("@jomolololo4398", "101 series is your best one"));

        //Adding a third comment
        v2.setComments(new Comment("@capnflamesword", "It's more fun to learn something when you're not forced to."));

        //Putting the video in the list
        videos.Add(v2);

        //Creating a third video with your comments.
        Video v3 = new Video("Battle bots", "Discovery", 1830, new Comment("@LightningGTM", "PLEASE bring BattleBots back for more seasons. There's nothing else like it on TV"));

        //Adding a second comment
        v3.setComments(new Comment("@betterbillie", "We need more of this in our lives!!"));

        //Adding a third comment
        v3.setComments(new Comment("@snoleopard", "i like how this video progresses through the seasons in chronological order"));
        
        //Adding a fourth comment
        v3.setComments(new Comment("@The_Black_Sheep95", "Nerds and their awesome expensive battle-Bots that i love to watch! "));

        //Putting the video in the list
        videos.Add(v3);

        foreach (Video v in videos)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"Title: {v.getTitle()} - Author: {v.getAuthor()} - Lenght: {v.getLenght()} - Number of Comments: {v.getNumberOfComments()}");
            Console.WriteLine("");
            
            List<Comment> c = v.GetComments();
            
            foreach(Comment comment1 in c)
            {
                Console.WriteLine($"{comment1.getComment()}");
            }
            Console.WriteLine("");
        }
    }
}