using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacks_House
{
    internal class Part1
    {
        public List<string> Poem = new List<string>();
        public void AddPart(List<string> poem)
        {
            var added = poem.ToImmutableList();
           var newListWithAddedStrings =  added.AddRange(new[] { "Вот дом,", "Который построил Джек." });
            Form(newListWithAddedStrings);

        }

        void Form(ImmutableList<string> poem)
        {
            foreach (var part in poem)
            {
                Poem.Add(part);
            }
        }
    }
}
