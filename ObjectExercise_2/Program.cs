using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExercise_2
{
    class Program
    {
        class DictEntry
        {
            string swedish, english;
            public DictEntry (string swe, string eng)
            {
                swedish = swe;
                english = eng;
            }
        }
        static void Main(string[] args)
        {
            DictEntry[] dict = new DictEntry[30];
            dict[0] = new DictEntry("head", "huvud");
            dict[1] = new DictEntry("see", "se");
            dict[2] = new DictEntry("father", "far, pappa");
            dict[3] = new DictEntry("tree", "träd");
            dict[4] = new DictEntry("moon", "måne");
            dict[5] = new DictEntry("move", "flytta");
            dict[6] = new DictEntry("city", "stad");
        }
    }
}
