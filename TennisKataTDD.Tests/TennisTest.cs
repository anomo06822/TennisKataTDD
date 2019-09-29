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
        public void Forty_All()
        {
            GivenPlayerDeuce();
            ThenScoreShouldBe("Deuce");
        }

        [Fact]
        public void FirstPlayer_Adv()
        {
            GivenPlayerDeuce();
            GivenFirstPlayerTimes(1);
            ThenScoreShouldBe("FirstPlayerName Adv");
        }
        
        [Fact]
        public void SecondPlayer_Adv()
        {
            GivenPlayerDeuce();
            GivenSecondPlayerTimes(1);
            ThenScoreShouldBe("SecondPlayerName Adv");
        }
        
        private void GivenPlayerDeuce()
        {
            GivenSamePlayerTimes(3);
        }

        private void GivenSamePlayerTimes(int times)
        {
            GivenFirstPlayerTimes(times);
            GivenSecondPlayerTimes(times);
        }
       
        private void GivenSecondPlayerTimes(int times)
        {
            for (var i = 0; i < times; i++)
            {
                GivenSecondPlayerTimes();
            }
        }

        private void GivenFirstPlayerTimes(int times)
        {
            for (var i = 0; i < times; i++)
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
            _tennis.GetScore().Should().Be(score);
        }
    }
}