using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partnership.Framework
{
    public class WordMaker
    {
        private const int MaxWordLength = 6;
        public IEnumerable<string> Act(IEnumerable<string> input)
        {
            var sortedResult = input.OrderBy(x => x.Length);
            var wordToLengthPairings = sortedResult.ToLookup(w => w.Length);
            var fullWords = wordToLengthPairings[MaxWordLength];

            var result = new List<string>();
            foreach (var smallerWord in sortedResult)
            {
                if (smallerWord.Length < MaxWordLength)
                {
                    result.AddRange(wordToLengthPairings[MaxWordLength - smallerWord.Length]
                        .Select(word2 => (smallerWord + word2))
                        .Where(fullWords.Contains));
                }
            }

            return result;
        }
    }
}
