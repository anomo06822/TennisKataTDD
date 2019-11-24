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
        [Fact]
        public void Love_All()
        {
            var tennis = new Tennis();
            var result = tennis.GetScore();
            result.Should().Be("Love_All");
        }
    }
}
