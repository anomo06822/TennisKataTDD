using Xunit;
using FluentAssertions;

namespace TennisKataTDD.Tests
{
    public class TennisTest
    {
        [Fact]
        public void Love_All()
        {
            var tennis = new Tennis();
            var result = tennis.GetPlayerScore();
            result.Should().Be("Love_All");
        }
    }
}