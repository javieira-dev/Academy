using System;
using StrngBuilder.Entities;

namespace StrngBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                 DateTime.Parse("20/12/2021 07:52:30"),
                 "Traveling to New Zeland",
                 "I'm going to visit this wonderful country",
                 12);
            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("Main the force be with you");

            Post p2 = new Post(
                 DateTime.Parse("20/12/2021 07:56:56"),
                 "Good Night guys",
                 "See you tomorrow",
                 5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}
