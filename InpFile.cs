using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFile;

namespace Satisfactory2
{
    internal class InpFile
    {
        public struct Competitor
        {
            public string id;
            public string name;
            public int first;
            public int second;
            public int third;

            //public List<int> score;
        }

        TextFileReader reader;

        public InpFile(string fileName)
        {
            reader = new TextFileReader(fileName);
        }

        public bool Read(out Competitor competitor)
        {
            reader.ReadString(out competitor.id);
            reader.ReadString(out competitor.name);
            reader.ReadInt(out competitor.first);
            reader.ReadInt(out competitor.second);
            return reader.ReadInt(out competitor.third);
            //reader.ReadInt(out competitor.score);

        }

    }
}
