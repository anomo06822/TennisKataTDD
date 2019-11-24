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
            _tennis = new Tennis();
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
            GivenSameTimes(1);
            ThenScoreShouldBe("Fifteen_All");
        }

        [Fact]
        public void Thirty_All()
        {
            GivenSameTimes(2);
            ThenScoreShouldBe("Thirty_All");
        }

        [Fact]
        public void Deuce()
        {
            GivenSameTimes(3);
            ThenScoreShouldBe("Deuce");
        }

        [Fact]
        public void FirstPlayName_Adv()
        {
            GivenSameTimes(3);
            GivenFirstPlayerTimes(1);
            ThenScoreShouldBe("FirstPlayerName_Adv");
        }

        [Fact]
        public void SecondPlayName_Adv()
        {
            GivenSameTimes(3);
            GivenSecondPlayerTimes(1);
            ThenScoreShouldBe("SecondPlayerName_Adv");
        }

        [Fact]
        public void FirstPlayName_Win()
        { 
            GivenSameTimes(3);
            GivenFirstPlayerTimes(2);
            ThenScoreShouldBe("FirstPlayerName_Win");
        }

        [Fact]
        public void SecondPlayName_Win()
        { 
            GivenSameTimes(3);
            GivenSecondPlayerTimes(2);
            ThenScoreShouldBe("SecondPlayerName_Win");
        }

        private void GivenSameTimes(int times)
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

        private void ThenScoreShouldBe(string score)
        {
            _tennis.GetScore().Should().Be(score);
        }
    }
}
