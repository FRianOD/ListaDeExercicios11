using System;
using ListaDeExercicios11.Entities;

namespace ListaDeExercicios11
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post
            (
                DateTime.Parse("17/12/2021 15:10:05"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
            );

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post
            (
                DateTime.Parse("20/02/2019 23:25:32"),
                "Good night guys",
                "See you tomorrow",
                24
            );
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}