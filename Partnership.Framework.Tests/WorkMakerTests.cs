using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Partnership.Framework.Tests
{
    [TestFixture]
    public class WorkMakerTests
    {
        [Test]
        public void when_list_contains_words_but_no_joins_return_empty()
        {
            // arrange
            var wordFilter = new WordMaker();
            var inputWordList = new List<string> {"albums", "beaver", "al", "jig", "weaver"};

            // act
            var output = wordFilter.Act(inputWordList);

            // Assert
            Assert.IsEmpty(output);
        }

        [Test]
        public void when_list_contains_words_return_word()
        {
            // arrange
            var wordFilter = new WordMaker();
            var inputWordList = new List<string> {"albums", "al", "bums"};

            // act
            var output = wordFilter.Act(inputWordList);

            // assert
            Assert.AreEqual("albums", output.First());
        }

        [Test]
        public void when_list_contains_valid_sets_return_items()
        {
            // arrange
            var wordFilter = new WordMaker();
            var inputWordList = new List<string> {"albums", "al", "jigsaw", "bums", "jig", "saw"};

            // act
            var output = wordFilter.Act(inputWordList);

            // assert
            Assert.That(output.Contains("jigsaw"));
            Assert.That(output.Contains("albums"));

            Assert.That(output.Count(), Is.EqualTo(2));
        }

    }
}
