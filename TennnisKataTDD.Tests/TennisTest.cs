using Xunit;
using FluentAssertions;

namespace TennisKata.Tests
{
    public class TennisTest
    {
        private readonly Tennis _tennis;

        public TennisTest()
        {
            _tennis = new Tennis();
        }
        
        [Fact]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [Fact]
        public void Fifteen_Love()
        {
            _tennis.FirstPlayerScore();

            ScoreShouldBe("Fifteen Love");
        }

        [Fact]
        public void Thirty_Love()
        {
            _tennis.FirstPlayerScore();
            _tennis.FirstPlayerScore();

            ScoreShouldBe("Thirty Love");
        }

        private void ScoreShouldBe(string actual)
        {
            _tennis.GetScore().Should().Be(actual);
        }
    }
}