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
        
        public void GivenFirstPlayerTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                GivenFirstPlayerTimes();
            }
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