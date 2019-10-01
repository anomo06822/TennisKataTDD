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

        private void ThenScoreShouldBe(string score)
        {
            _tennis.GetStore().Should().Be(score);
        }
    }
}