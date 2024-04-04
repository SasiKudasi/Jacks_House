using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacks_House
{
    internal class Part8
    {
        public List<string> Poem = new List<string>();
        public void AddPart(List<string> poem)
        {
            var added = poem.ToImmutableList();
            var newListWithAddedStrings = added.Add("А это ленивый и толстый пастух,\r\nКоторый бранится с коровницей строгою,\r\n" +
                "Которая доит корову безрогую,\r\nЛягнувшую старого пса без хвоста,\r\n" +
                "Который за шиворот треплет кота,\r\nКоторый пугает и ловит синицу,\r\n" +
                "Которая часто ворует пшеницу,\r\nКоторая в темном чулане хранится\r\n" +
                "В доме,\r\nКоторый построил Джек.");
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
