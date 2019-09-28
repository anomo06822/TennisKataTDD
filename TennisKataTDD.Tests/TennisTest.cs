using Xunit;
using FluentAssertions;

namespace TennisKataTDD.Tests
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
            GivenFirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        [Fact]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore();
            GivenFirstPlayerScore();
            ScoreShouldBe("Thirty Love");
        }

    
        private void GivenFirstPlayerScore()
        {
            _tennis.FirstPlayerScore();
        }


        private void ScoreShouldBe(string expected)
        {
            _tennis.GetScore().Should().Be(expected);
        }
    }
}