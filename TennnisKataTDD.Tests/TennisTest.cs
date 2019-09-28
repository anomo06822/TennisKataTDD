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

        private void ScoreShouldBe(string actual)
        {
            _tennis.GetScore().Should().Be(actual);
        }
    }
}