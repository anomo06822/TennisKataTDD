using Xunit;
using FluentAssertions;
using FluentAssertions.Primitives;

namespace TennisKataTDD.Tests
{
    public class TennisTest
    {
        private Tennis _tennis = new Tennis("FirstPlayerName", "SecondPlayerName");

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
            GivenSameScore(1);
            ThenScoreShouldBe("Fifteen All");
        }
        
        [Fact]
        public void Thirty_All()
        {
            GivenSameScore(2);
            ThenScoreShouldBe("Thirty All");
        }
        
        [Fact]
        public void Deuce()
        {
            GivenSameScore(3);
            ThenScoreShouldBe("Deuce");
        }
        
        [Fact]
        public void FirstPlayer_Adv()
        {
            GivenSameScore(3);
            GivenFirstPlayerTimes(1);
            ThenScoreShouldBe("FirstPlayerName Adv");
        }
        
        [Fact]
        public void SecondPlayer_Adv()
        {
            GivenSameScore(3);
            GivenSecondPlayerTimes(1);
            ThenScoreShouldBe("SecondPlayerName Adv");
        }
        
        [Fact]
        public void FirstPlayer_Win()
        {
            GivenSameScore(3);
            GivenFirstPlayerTimes(2);
            ThenScoreShouldBe("FirstPlayerName Win");
        }
        
        [Fact]
        public void SecondPlayer_Win()
        {
            GivenSameScore(3);
            GivenSecondPlayerTimes(2);
            ThenScoreShouldBe("SecondPlayerName Win");
        }

        private void GivenSameScore(int times)
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

        private AndConstraint<StringAssertions> ThenScoreShouldBe(string score)
        {
            return _tennis.GetScore().Should().Be(score);
        }
    }
}