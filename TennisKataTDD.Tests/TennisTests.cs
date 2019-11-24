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

        private void ThenScoreShouldBe(string score)
        {
            _tennis.GetScore().Should().Be(score);
        }
    }
}
