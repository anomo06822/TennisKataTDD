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
            ThenScoreShouldBe("Love_All");
        }

        [Fact]
        public void Fifteen_Love()
        {
            _tennis.FirstPlayerScoreTimes();
            ThenScoreShouldBe("Fifteen_Love");
        }

        private void ThenScoreShouldBe(string Score)
        {
            _tennis.GetScore().Should().Be(Score);
        }
    }
}