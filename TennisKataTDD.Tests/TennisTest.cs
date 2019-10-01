using Xunit;
using FluentAssertions;

namespace TennisKataTDD.Tests
{
    public class TennisTest
    {
        private Tennis _tennis;

        public TennisTest()
        {
            _tennis = new Tennis();
        }

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
        
        [Fact]
        public void Love_Fifteen()
        {
            GivenSecondPlayerTimes(1);
            ThenScoreShouldBe("Love Fifteen");
        }

        [Fact]
        public void Love_Thirty()
        {
            GivenSecondPlayerTimes(2);
            ThenScoreShouldBe("Love Thirty");
        }

        [Fact]
        public void Love_Forty()
        {
            GivenSecondPlayerTimes(3);
            ThenScoreShouldBe("Love Forty");
        }

        [Fact]
        public void Fifteen_All()
        {
            GivenFirstPlayerTimes(1);
            GivenSecondPlayerTimes(1);
            ThenScoreShouldBe("Fifteen All");
        }

        private void GivenSecondPlayerTimes(int times)
        {
            for (int i = 0; i < times; i++)
            {
                GivenSecondPlayerTimes();
            }
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

        private void GivenSecondPlayerTimes()
        {
            _tennis.SecondPlayerTimes();
        }

        private void ThenScoreShouldBe(string score)
        {
            _tennis.GetStore().Should().Be(score);
        }
    }
}