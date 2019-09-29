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
            GivenFirstPlayerTimes(1);
            ThenScoreShouldBe("Fifteen Love");
        }
        
        [Fact]
        public void Thirty_Love()
        {
            GivenFirstPlayerTimes(2);
            ThenScoreShouldBe("Thirty Love");
        }

        [Fact]
        public void Forty_Love()
        {
            GivenFirstPlayerTimes(3);
            ThenScoreShouldBe("Forty Love");
        }

        private void GivenFirstPlayerTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                GivenFirstPlayerTimes();
            }
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