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
