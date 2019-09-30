using Xunit;
using FluentAssertions;
using FluentAssertions.Primitives;

namespace TennisKataTDD.Tests
{
    public class TennisTest
    {
        private Tennis _tennis = new Tennis();

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

        public void GivenFirstPlayerTimes(int times)
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