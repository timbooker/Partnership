using System.Linq;
using NUnit.Framework;

namespace Partnership.Framework.Tests
{
    [TestFixture]
    public class ItemParserTests
    {
        [Test]
        public void when_string_contains_words_seperated_properly_returns_list_of_them()
        {
            // arrange 
            var itemParser = new ItemParser();
            var input = "al, albums, aver, bar, barely, be";

            // act
            var result = itemParser.GetItems(input);

            // assert
            Assert.That(result.Count(), Is.EqualTo(6));
        }

        [Test]
        public void when_strings_contain_extra_spaces_is_trimmed_properly()
        {
            // arrnage
            var itemParser = new ItemParser();
            var input = "al,                  albums";

            // act
            var result = itemParser.GetItems(input);

            // assert
            Assert.That(result.ElementAt(1), Is.EqualTo("albums"));
        }
    }
}