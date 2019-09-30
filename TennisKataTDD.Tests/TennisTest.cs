using Xunit;
using FluentAssertions;
using FluentAssertions.Primitives;

namespace TennisKataTDD.Tests
{
    public class TennisTest
    {
        private Tennis _tennis = new Tennis();

        [Fact]
        public void Love_All()
        {
            ThenScoreShouldBe("Love All");
        }

        private AndConstraint<StringAssertions> ThenScoreShouldBe(string score)
        {
            return _tennis.GetScore().Should().Be(score);
        }
    }
}