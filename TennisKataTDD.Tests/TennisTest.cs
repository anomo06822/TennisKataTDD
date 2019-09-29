﻿using Xunit;
using FluentAssertions;
using FluentAssertions.Primitives;

namespace TennisKataTDD.Tests
{
    public class TennisTest
    {
        private readonly Tennis _tennis;

        public TennisTest()
        {
            _tennis = new Tennis("FirstPlayerName", "SecondPlayerName");
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

        [Fact]
        public void Love_Fifteen()
        {
            GivenSecondPlayerTimes(1);
            ScoreShouldBe("Love Fifteen");
        }

        [Fact]
        public void Love_Thirty()
        {
            GivenSecondPlayerTimes(2);
            ScoreShouldBe("Love Thirty");
        }

        [Fact]
        public void Love_Forty()
        {
            GivenSecondPlayerTimes(3);
            ScoreShouldBe("Love Forty");
        }

        [Fact]
        public void Fifteen_All()
        {
            GivenSamePlayerScore(1);
            ScoreShouldBe("Fifteen All");
        }

        [Fact]
        public void Thirty_All()
        {
            GivenSamePlayerScore(2);
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
            GivenFirstPlayerTimes(1);
            ScoreShouldBe("FirstPlayerName Adv");
        }

        [Fact]
        public void SecondPlayer_Adv()
        {
            GivenDeuce();
            GivenSecondPlayerTimes(1);
            ScoreShouldBe("SecondPlayerName Adv");
        }

        [Fact]
        public void FirstPlayer_Win()
        {
            GivenDeuce();
            GivenFirstPlayerTimes(2);
            ScoreShouldBe("FirstPlayerName Win");
        }

        private void GivenDeuce()
        {
            GivenSamePlayerScore(3);
        }

        private void GivenSamePlayerScore(int times)
        {
            GivenFirstPlayerTimes(times);
            GivenSecondPlayerTimes(times);
        }

        private void GivenFirstPlayerTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                GivenFirstPlayerTimes();
            }
        }
        private void GivenSecondPlayerTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                GivenSecondPlayerTimes();
            }
        }

        private void GivenFirstPlayerTimes()
        {
            _tennis.FirstPlayerTimes();
        }

        private void GivenSecondPlayerTimes()
        {
            _tennis.SecondPlayerTimes();
        }

        private AndConstraint<StringAssertions> ScoreShouldBe(string score)
        {
            return _tennis.GetScore().Should().Be(score);
        }
    }
}