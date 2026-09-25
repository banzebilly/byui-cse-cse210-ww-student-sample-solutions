using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // let Creat video
        Video video1 = new Video(
            "Learning C# Classes",
            "Banze Billy",
            450
        );
        Video video2 = new Video(
            "Introduction to Web Development",
            "Code Academy",
            420
        );
        Video video3 = new Video(
            "Understanding Object-Oriented Programming",
            "Programming School",
            600
        );
        Video video4 = new Video(
            "Building my first website",
            "Web Dev Channel",
            510
        );

        // and i can Add comments to video1
        video1.Comments.Add(new Comment(
            "Billy",
            "This video helped me understand class"
        ));
        video1.Comments.Add(new Comment(
            "Sarah",
            "Very Clear explanation"
        ));
        video1.Comments.Add(new Comment(
            "Michael",
            "I learned a lot from this video"
        ));

        // add comments to video 2
          video2.Comments.Add(new Comment(
            "David",
            "Great introduction to web development."
        ));

        video2.Comments.Add(new Comment(
            "Mary",
            "The examples were easy to follow"
        ));
        video2.Comments.Add(new Comment(
            "Eddo",
            "I will try these techniques in my project."
        ));
      
        // add comments to video 3
          video3.Comments.Add(new Comment(
            "Paul",
            "This was exactly what I needed."
        ));

        video3.Comments.Add(new Comment(
            "MWandWe",
            "Great explanation of html, and css."
        ));
        video3.Comments.Add(new Comment(
            "Daniel",
            "Very useful Tutorial"
        ));

        // add comments to video 4
          video4.Comments.Add(new Comment(
            "Paulin",
            "Object oriented programming makes more sense now."
        ));

        video4.Comments.Add(new Comment(
            "Ermeck",
            "I enjoyed this explanaition"
        ));
        video4.Comments.Add(new Comment(
            "Ermi",
            "I am going to practice this in C#"
        ));


        // To to put all the video into the List

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        // To display the video and comments

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Auther}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");


            foreach (Comment comment in video.Comments)
            {
                Console.Write($"{comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
      
    }
}