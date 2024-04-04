using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jacks_House
{
    internal class Part9
    {
        public List<string> Poem = new List<string>();
        public void AddPart(List<string> poem)
        {
            var added = poem.ToImmutableList();
            var newListWithAddedStrings = added.Add("Вот два петуха,\r\nКоторые будят того пастуха,\r\n" +
                "Который бранится с коровницей строгою,\r\nКоторая доит корову безрогую,\r\n" +
                "Лягнувшую старого пса без хвоста,\r\nКоторый за шиворот треплет кота,\r\n" +
                "Который пугает и ловит синицу,\r\nКоторая часто ворует пшеницу,\r\n" +
                "Которая в темном чулане хранится\r\nВ доме,\r\nКоторый построил Джек");
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
