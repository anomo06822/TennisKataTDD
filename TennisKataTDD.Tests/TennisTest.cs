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

        private void GivenFirstPlayerTimes()
        {
            _tennis.FirstPlayerTimes();
        }

        private AndConstraint<StringAssertions> ThenScoreShouldBe(string score)
        {
            return _tennis.GetScore().Should().Be(score);
        }
    }
}