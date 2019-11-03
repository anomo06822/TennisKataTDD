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
            ThenScoreShouldBe("Love_All");
        }
        
        [Fact]
        public void Fifteen_Love()
        {
            GivenFirstPlayerScore(1);
            ThenScoreShouldBe("Fifteen_Love");
        }
    
        [Fact]
        public void Thirty_Love()
        {
            GivenFirstPlayerScore(2);
            ThenScoreShouldBe("Thirty_Love");
        }

        [Fact]
        public void Forty_Love()
        {
            GivenFirstPlayerScore(3);
            ThenScoreShouldBe("Forty_Love");
        }

        [Fact]
        public void Love_Fifteen()
        {
            GivenSecondPlayerScore(1);
            ThenScoreShouldBe("Love_Fifteen");
        }

        [Fact]
        public void Love_Thirty()
        {
            GivenSecondPlayerScore(2);
            ThenScoreShouldBe("Love_Thirty");
        }

        [Fact]
        public void Love_Forty()
        {
            GivenSecondPlayerScore(3);
            ThenScoreShouldBe("Love_Forty");
        }

        private void GivenFirstPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.FirstPlayerScoreTimes();
            }
        }

        private void GivenSecondPlayerScore(int times)
        {
            for (int i = 0; i < times; i++)
            {
                _tennis.SecondPlayerScoreTimes();
            }
        }

        private void ThenScoreShouldBe(string Score)
        {
            _tennis.GetScore().Should().Be(Score);
        }
    }
}