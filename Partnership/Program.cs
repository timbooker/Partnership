using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Partnership.Framework;

namespace Partnership
{
    class Program
    {
        static void Main(string[] args)
        {
            // could come from whereever like this
            const string values = "al, albums, aver, bar, barely, be, befoul, bums, by, cat, con, convex, ely, foul, here, hereby, jig, jigsaw, or, saw, tail, tailor, vex, we, weaver";

            Console.Write(new WordMaker().Act(new ItemParser().GetItems(values)).Aggregate(string.Empty, (s, s1) => s + s1 + "\r\n"));
            Console.Read();
        }
    }
}
