using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        //Creating a comment and inserting it into a video.
        Comment comment = new Comment("zunisheik3357", "Wow those lions were so close...I really loved this 360 view..");
        Video v1 = new Video("Lions 360° | National Geographic","National Geographic", 270, comment);
        
        //Inserting a second comment into the video.
        comment = new Comment("berkeduzova", "WONDERFUL VİDEO. THANKS NATIONAL GEOPHRATICS.");
        v1.setComments(comment);

        //Inserting a third comment into the video.
        comment = new Comment("fatbardh94", "Perfect guys, what a wonderful job God made it happen.");
        v1.setComments(comment);

        //Creating a second video with your comments.
        Video v2 = new Video("Volcanoes 101 | National Geographic", "National Geographic", 298, 
        new Comment("@ryanrock02", "Let's pray Taal eruption doesn't get worse"));

        //Adding a second comment
        v2.setComments(new Comment("@jomolololo4398", "101 series is your best one"));

        //Adding a third comment
        v2.setComments(new Comment("@capnflamesword", "It's more fun to learn something when you're not forced to."));

        //Creating a third video with your comments.
    }
}