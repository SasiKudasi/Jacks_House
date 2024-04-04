using System.Collections.Immutable;

namespace Jacks_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var poem = new List<string>();
            Part1 part1 = new Part1();
            var part2 = new Part2();
            var part3 = new Part3();
            var part4 = new Part4();
            var part5 = new Part5();
            var part6 = new Part6();
            var part7 = new Part7();
            var part8 = new Part8();
            var part9 = new Part9();
          

            part1.AddPart(poem);
            part2.AddPart(part1.Poem);
            part3.AddPart(part2.Poem);
            part4.AddPart(part3.Poem);
            part5.AddPart(part4.Poem);                
            part6.AddPart(part5.Poem);
            part7.AddPart(part6.Poem);
            part8.AddPart(part7.Poem);
            part9.AddPart(part8.Poem);

            Form(part1.Poem);
            Form(part2.Poem);
            Form(part3.Poem);
            Form(part4.Poem);
            Form(part5.Poem);
            Form(part6.Poem);
            Form(part7.Poem);
            Form(part8.Poem);
            Form(part9.Poem);
        }

        static void Form(List<string> part)
        {
            foreach (var part1 in part)
            {
                Console.WriteLine($"{part1}");
            }
            Console.WriteLine("\n___________________________________________");
        }
    }
}