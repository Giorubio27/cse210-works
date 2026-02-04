using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        Video vid1 = new Video("Jaws", "Alfred Hitchcock", 130);



        Comments comment1 = new Comments("Giovanni", "I thought the video was very creative and that the effects were intense to say the least");
        Comments comment2 = new Comments("Gabriela", "I didnt think the movie was all that");
        Comments comment3 = new Comments("Davi", "I love sharks");
        Comments comment4 = new Comments("Regina", "Too violent of a movie for me");

        vid1.newComment(comment1);
        vid1.newComment(comment2);
        vid1.newComment(comment3);
        vid1.newComment(comment4);

        vid1.GetDisplayVideo();

        Video vid2 = new Video("Avengers", "Russo Bros", 1200);

        Comments vid2comment1 = new Comments("Richard", "I didnt like the ending of the film");
        Comments vid2comment2 = new Comments("Denise", "Why in the world did they kill off Tony stark");
        Comments vid2comment3 = new Comments("Tyler", "RIP Tony");

        vid2.newComment(vid2comment1);
        vid2.newComment(vid2comment2);
        vid2.newComment(vid2comment3);

        vid2.GetDisplayVideo();

        Video vid3 = new Video("John Wick", "Keanu Reeves", 1400);

        Comments vid3comment1 = new Comments("George", "How does one man evade death so often");
        Comments vid3comment2 = new Comments("Ben", "Keanu Reeves is a legend");
        Comments vid3comment3 = new Comments("Tyson", "A pencil?");
        Comments vid3comment4 = new Comments("Lorena", "What A VIDEO!");

        vid3.newComment(vid3comment1);
        vid3.newComment(vid3comment2);
        vid3.newComment(vid3comment3);
        vid3.newComment(vid3comment4);

        vid3.GetDisplayVideo();




    }

     
}