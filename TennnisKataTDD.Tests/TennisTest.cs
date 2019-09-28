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
            _tennis = new Tennis("FirstPlayer", "SecondPlayer");
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

        [Fact]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            ScoreShouldBe("Forty Love");
        }

        [Fact]
        public void Love_Fifteen()
        {
            GivenSecondPlayerScore(1);
            ScoreShouldBe("Love Fifteen");
        }

        [Fact]
        public void Love_Thirty()
        {
            GivenSecondPlayerScore(2);
            ScoreShouldBe("Love Thirty");
        }

        [Fact]
        public void Love_Forty()
        {
            GivenSecondPlayerScore(3);
            ScoreShouldBe("Love Forty");
        }

        [Fact]
        public void Fifteen_All()
        {
            GivenSameScore(1);
            ScoreShouldBe("Fifteen All");
        }
       
        [Fact]
        public void Thirty_All()
        {
            GivenSameScore(2);
            ScoreShouldBe("Thirty All");
        }

       [Fact]
        public void Deuce()
        {
            GivenDeuce();
            ScoreShouldBe("Deuce");
        }

       [Fact]
        public void FirstPlayer_Adv()
        {
            GivenDeuce();
            GivenFirstPlayerScore(1);
            ScoreShouldBe("FirstPlayer_Adv");
        }

       [Fact]
        public void SecondPlayer_Adv()
        {
            GivenDeuce();
            GivenSecondPlayerScore(1);
            ScoreShouldBe("SecondPlayer_Adv");
        }


        private void GivenDeuce()
        {
            GivenSameScore(3);
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScore();
            }
        }

        private void GivenSecondPlayerScore(int times)
        {
            for (var i = 0; i < times; i++)
            {
                _tennis.SecondPlayerScore();
            }
        }

        private void GivenSameScore(int times)
        {
            GivenFirstPlayerScore(times);
            GivenSecondPlayerScore(times);
        }

        private void ScoreShouldBe(string actual)
        {
            _tennis.GetScore().Should().Be(actual);
        }
    }
}