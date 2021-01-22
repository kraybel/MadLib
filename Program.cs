using System;

namespace TureCoders_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give me an adjective: ");
            var adj1 = Console.ReadLine();
            Console.Write("Please give me another adjective: ");
            var adj2 = Console.ReadLine();
            Console.Write("Please give me a noun: ");
            var noun1 = Console.ReadLine();
            Console.Write("Please give me another noun: ");
            var noun2 = Console.ReadLine();
            Console.Write("Please give me a plural noun: ");
            var pln1 = Console.ReadLine();
            Console.Write("Please give me the name of a game: ");
            var game = Console.ReadLine();
            Console.Write("Please give me another plural noun: ");
            var pln2 = Console.ReadLine();
            Console.Write("Please give me a verb ending in 'ing': ");
            var v_ing1 = Console.ReadLine();
            Console.Write("Please give me another verb ending in 'ing': ");
            var v_ing2 = Console.ReadLine();
            Console.Write("Please give me another plural noun: ");
            var pln3 = Console.ReadLine();
            Console.Write("Please give me another verb ending in 'ing': ");
            var v_ing3 = Console.ReadLine();
            Console.Write("Please give me another noun: ");
            var noun3 = Console.ReadLine();
            Console.Write("Please give me the name of a plant: ");
            var plant = Console.ReadLine();
            Console.Write("Please give me a part of the body: ");
            var bodyPart = Console.ReadLine();
            Console.Write("Please give me a place: ");
            var place = Console.ReadLine();
            Console.Write("Please give me another verb ending in 'ing': ");
            var v_ing4 = Console.ReadLine();
            Console.Write("Please give me another adjective: ");
            var adj3 = Console.ReadLine();
            Console.Write("Please give me a number: ");
            var num = Console.ReadLine();
            Console.Write("Please give me one last plural noun: ");
            var pln4 = Console.ReadLine();

            Console.WriteLine($"A vacation is when you take a trip to some {adj1} place");
            Console.WriteLine($"with your {adj2} family. Usually you go to some place");
            Console.WriteLine($"that is near a/an {noun1} or up on a/an {noun2}.");
            Console.WriteLine($"A good vacation place is one where you can ride {pln1}");
            Console.WriteLine($"or play {game} or go hunting for {pln2}. I like");
            Console.WriteLine($"to spend my time {v_ing1} or {v_ing2}.");
            Console.WriteLine("When parents go on vacation, they spend their time eating");
            Console.WriteLine($"three {pln3} a day, and fathers play golf, and mothers");
            Console.WriteLine($"sit around {v_ing3}. Last summer, my little brother");
            Console.WriteLine($"fell in a/an {noun3} and got poison {plant} all");
            Console.WriteLine($"over his {bodyPart}. My family is going to go to (the)");
            Console.WriteLine($"{place}, and I will practice {v_ing4}. Parents");
            Console.WriteLine("need vacations more than kids because parents are always very");
            Console.WriteLine($"{adj3} and because they have to work {num}");
            Console.WriteLine($"hours every day all year making enough {pln4} to pay");
            Console.WriteLine("for the vacation.");
        }
    }
}
