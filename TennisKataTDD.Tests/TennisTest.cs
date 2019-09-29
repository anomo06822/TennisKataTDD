using Xunit;
using FluentAssertions;
using FluentAssertions.Primitives;

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
            GivenFirstPlayerTimes(1);
            ScoreShouldBe("Fifteen Love");
        }

        [Fact]
        public void Thirty_Love()
        {
            GivenFirstPlayerTimes(2);
            ScoreShouldBe("Thirty Love");
        }

        [Fact]
        public void Forty_Love()
        {
            GivenFirstPlayerTimes(3);
            ScoreShouldBe("Forty Love");
        }

        private void GivenFirstPlayerTimes(int times)
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

        private AndConstraint<StringAssertions> ScoreShouldBe(string score)
        {
            return _tennis.GetScore().Should().Be(score);
        }
    }
}