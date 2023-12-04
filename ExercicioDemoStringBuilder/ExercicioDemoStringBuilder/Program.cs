using ExercicioDemoStringBuilder.Entities;
using System;


namespace ExercicioDemoStringBuilder {
    internal class Program {
        static void Main(string[] args) {

            Comment comment1 = new Comment("Have a nice trip!");
            Comment comment2 = new Comment("Wow that's awesome");

            Post post1 = new Post(
                DateTime.Parse("21/06/2023 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);
            post1.AddComment(comment1);
            post1.AddComment(comment2);

            Comment comment3 = new Comment("Good nigth");
            Comment comment4 = new Comment("May the force be witc you");

            Post post2 = new Post(
                DateTime.Parse("28/07/2023 10:04:44"), "Good nigth guys", "See you tomorrow", 6);
            post2.AddComment(comment3);
            post2.AddComment(comment4);


            Console.WriteLine(post1);
            Console.WriteLine(post2);
        }
    }
}
