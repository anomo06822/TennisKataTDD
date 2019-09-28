using System;
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

        [Fact]
        public void Fifteen_Love()
        {
            GivenFirstPlayerScore(1);
            ScoreShouldBe("Fifteen Love");
        }

        [Fact]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            ScoreShouldBe("Thirty Love");
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }

        private void ScoreShouldBe(string actual)
        {
            _tennis.GetScore().Should().Be(actual);
        }
    }
}