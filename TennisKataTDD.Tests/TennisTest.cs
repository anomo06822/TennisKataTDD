using Xunit;
using FluentAssertions;

namespace TennisKataTDD.Tests
{
    public class TennisTest
    {
        private Tennis _tennis;

        public TennisTest()
        {
            _tennis = new Tennis("FirstPlayerName", "SecondPlayerName");
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
            GivenSamePlayerTimes(1);
            ThenScoreShouldBe("Fifteen All");
        }

        [Fact]
        public void Thirty_All()
        {
            GivenSamePlayerTimes(2);
            ThenScoreShouldBe("Thirty All");
        }

        [Fact]
        public void Deuce()
        {
            GivenSamePlayerTimes(3);
            ThenScoreShouldBe("Deuce");
        }

        [Fact]
        public void FirstPlayer_Adv()
        {
            GivenSamePlayerTimes(3);
            GivenFirstPlayerTimes(1);
            ThenScoreShouldBe("FirstPlayerName Adv");
        }

        [Fact]
        public void SecondPlayer_Adv()
        {
            GivenSamePlayerTimes(3);
            GivenSecondPlayerTimes(1);
            ThenScoreShouldBe("SecondPlayerName Adv");
        }























        private void GivenSamePlayerTimes(int times)
        {
            GivenFirstPlayerTimes(times);
            GivenSecondPlayerTimes(times);
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