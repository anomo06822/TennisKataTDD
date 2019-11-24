using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace TennisKataTDD.Tests
{
    public class TennisTests
    {
        private Tennis _tennis;

        public TennisTests()
        {
            _tennis = new Tennis("FirstPlayerName", "SecondPlayerName");
        }

        [Fact]
        public void Love_All()
        {
            ThenScoreShouldBe("Love_All");
        }

        [Fact]
        public void Fifteen_Love()
        {
            GivenFirstPlayerTimes(1);
            ThenScoreShouldBe("Fifteen_Love");
        }

        [Fact]
        public void Thirty_Love()
        {
            GivenFirstPlayerTimes(2);
            ThenScoreShouldBe("Thirty_Love");
        }

        [Fact]
        public void Forty_Love()
        {
            GivenFirstPlayerTimes(3);
            ThenScoreShouldBe("Forty_Love");
        }

        [Fact]
        public void Love_Fifteen()
        {
            GivenSecondPlayerTimes(1);
            ThenScoreShouldBe("Love_Fifteen");
        }

        [Fact]
        public void Love_Thirty()
        {
            GivenSecondPlayerTimes(2);
            ThenScoreShouldBe("Love_Thirty");
        }

        [Fact]
        public void Love_Forty()
        {
            GivenSecondPlayerTimes(3);
            ThenScoreShouldBe("Love_Forty");
        }

        [Fact]
        public void Fifteen_All()
        {
            GiveSameScore(1);
            ThenScoreShouldBe("Fifteen_All");
        }

        [Fact]
        public void Thirty_All()
        {
            GiveSameScore(2);
            ThenScoreShouldBe("Thirty_All");
        }

        [Fact]
        public void Deuce()
        {
            GiveSameScore(3);
            ThenScoreShouldBe("Deuce");
        }

        [Fact]
        public void FirstPayer_Adv()
        {
            GiveSameScore(3);
            GivenFirstPlayerTimes(1);
            ThenScoreShouldBe("FirstPlayerName Adv");
        }

        [Fact]
        public void SecondPlayer_Adv()
        {
            GiveSameScore(3);
            GivenSecondPlayerTimes(1);
            ThenScoreShouldBe("SecondPlayerName Adv");
        }

        [Fact]
        public void FirstPayer_Win()
        {
            GiveSameScore(3);
            GivenFirstPlayerTimes(2);
            ThenScoreShouldBe("FirstPlayerName Win");
        }

        [Fact]
        public void SecondPlayer_Win()
        {
            GiveSameScore(3);
            GivenSecondPlayerTimes(2);
            ThenScoreShouldBe("SecondPlayerName Win");
        }

        private void GiveSameScore(int times)
        {
            GivenFirstPlayerTimes(times);
            GivenSecondPlayerTimes(times);
        }

        private void GivenFirstPlayerTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerTimes();
            }
        }

        private void GivenSecondPlayerTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.SecondPlayerTimes();
            }
        }

        private void ThenScoreShouldBe(string loveAll)
        {
            _tennis.GetScore().Should().Be(loveAll);
        }
    }
}
