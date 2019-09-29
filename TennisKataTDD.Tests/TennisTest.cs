using Xunit;
using FluentAssertions;

namespace TennisKataTDD.Tests
{
    public class TennisTest
    {
        private Tennis _tennis;

        public TennisTest()
        {
            _tennis = new Tennis();
        }

        [Fact]
        public void Love_All()
        {
            ThenScoreShouldBe("Love All");
        }

        [Fact]
        public void Fifteen_Love()
        {
            GivenFirstPlayerTimes();
            ThenScoreShouldBe("Fifteen Love");
        }
        
        [Fact]
        public void Thirty_Love()
        {
            GivenFirstPlayerTimes();
            GivenFirstPlayerTimes();
            ThenScoreShouldBe("Thirty Love");
        }

        [Fact]
        public void Forty_Love()
        {
            GivenFirstPlayerTimes();
            GivenFirstPlayerTimes();
            GivenFirstPlayerTimes();
            ThenScoreShouldBe("Forty Love");
        }

        private void GivenFirstPlayerTimes()
        {
            _tennis.FirstPlayerTimes();
        }

        private void ThenScoreShouldBe(string score)
        {
            _tennis.GetScore().Should().Be(score);
        }
    }
}